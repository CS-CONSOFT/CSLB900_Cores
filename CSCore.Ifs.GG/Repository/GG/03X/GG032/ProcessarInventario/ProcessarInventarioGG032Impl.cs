using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;

namespace CSCore.Ifs.GG.Repository.GG._03X.GG032.ProcessarInventario
{
    public class ProcessarInventarioGG032Impl : OperacoesBaseInventarioRepository, IProcessarInventarioGG032
    {
        private readonly AppDbContext _appDbContext;

        public ProcessarInventarioGG032Impl(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        class InternalPrmProcessaProdutosInventario
        {
            public int Tenant { get; set; }
            public int InStIDEntSaidaSaidaID { get; set; }
            public int InStIDEntSaidaEntradaID { get; set; }
            public int InStIDNatInventarioID { get; set; }
            public CSICP_GG032 Gg032Inventario { get; set; } = null!;
            public List<CSICP_GG033> ListGg033 { get; set; } = null!;
        }

        public async Task<bool> ProcessarInventario(PrmProcessarInventarioGG032 InPrmProcessarInventario)
        {
            var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                CSICP_GG032 gg032inventario =
                    await GetInventarioParaTrabalhoAsync(
                        InPrmProcessarInventario.InTenant, InPrmProcessarInventario.InInventarioId, _appDbContext);

                if (InventarioStatusDifenteBloqueado(InPrmProcessarInventario.InStIDGG032StaBloqueadoID, gg032inventario))
                    throw new Exception("Inventário deve estar como BLOQUEADO para poder ser processado!");

                List<CSICP_GG033> listgg033 =
                    await GetInventarioProdutosAsync(InPrmProcessarInventario.InTenant, gg032inventario.Id, _appDbContext);

                var prm = new InternalPrmProcessaProdutosInventario
                {
                    Tenant = InPrmProcessarInventario.InTenant,
                    InStIDEntSaidaSaidaID = InPrmProcessarInventario.InStIDGG028EntSaidaSaidaID,
                    InStIDEntSaidaEntradaID = InPrmProcessarInventario.InStIDGG028EntSaidaEntradaID,
                    InStIDNatInventarioID = InPrmProcessarInventario.InStIDGG028NatInventarioID,
                    Gg032Inventario = gg032inventario,
                    ListGg033 = listgg033
                };
                await ProcessaProdutosInventarioEAtualizaSaldoEProdutoAsync(prm);

                gg032inventario.Gg032StatusId = InPrmProcessarInventario.InStIDGG032StaConcluidoID;
                gg032inventario.Gg032QtosPodutos = listgg033.Count;
                gg032inventario.Gg032DataHoraProcessado = DateTime.Now.ToLocalTime();


                _appDbContext.Update(gg032inventario);
                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }

        private async Task ProcessaProdutosInventarioEAtualizaSaldoEProdutoAsync
            (InternalPrmProcessaProdutosInventario prmProcessaProdutosInventario)
        {
            foreach (var currProduto in prmProcessaProdutosInventario.ListGg033)
            {
                if (ProdutoNaoEstaMarcadoParaInventariar(currProduto))
                {
                    prmProcessaProdutosInventario.Gg032Inventario.Gg032QtosNaoinventariado += 1;
                    continue;
                }

                if (ProdutoNaoFoiAlterado(currProduto))
                    throw new Exception($"Algum produto não foi alterado, não é possível processar o inventário!");

                CSICP_GG520? saldoEncontrado =
                    await GetSaldoParaTrabalhoAsync(prmProcessaProdutosInventario.Tenant, currProduto.Id, _appDbContext);
                if (saldoEncontrado is null) continue;

                currProduto.Gg033Qtdajuste = QuantidadeInventarioEhIgualSaldo(currProduto, saldoEncontrado) ? 0
                 : QuantidadeInventarioEhMaiorQueSaldo(currProduto, saldoEncontrado)
                 ? currProduto.Gg033Qtdinventario - saldoEncontrado.Gg520Saldo
                 : saldoEncontrado.Gg520Saldo - currProduto.Gg033Qtdinventario;

                currProduto.Gg033Entsai
                    = QuantidadeInventarioEhMenorQueSaldo(currProduto, saldoEncontrado) ? "S" : "E";


                currProduto.Gg033Datareferente = DateTime.Now.ToLocalTime();

                var V_SaldoAnteriorProduto = saldoEncontrado.Gg520Saldo;

                saldoEncontrado.Gg520ItemEmContagem = false;
                saldoEncontrado.Gg520Ultinventario = DateTime.Now.ToLocalTime();

                saldoEncontrado.Gg520Saldo = EhEntrada(currProduto)
                    ? saldoEncontrado.Gg520Saldo + currProduto.Gg033Qtdajuste ?? 0
                    : saldoEncontrado.Gg520Saldo - currProduto.Gg033Qtdajuste ?? 0;

                saldoEncontrado.NavGG001Almox = null;
                saldoEncontrado.NavGG016Gradecoluna = null;
                saldoEncontrado.NavGG016Gradlinha = null;
                saldoEncontrado.Nav_GG008Kardex = null;

                _appDbContext.Update(saldoEncontrado);
                await _appDbContext.SaveChangesAsync();

                await _geraExtrato.CS_CriaExtratoOrigem(
                        inTenant: tenant,
                        inGG028_ORIGEMPROGRAMA: "GG032",
                        inGG028_ORIGEM_PKID: currProduto.Id,
                        inGG028_ORIGEM_DOC_PKID: gg032inventario.Id,
                        inGG028_DATA_MOVIMENTO: gg032inventario.Gg032Datamovimento,
                        inGG028_ALMOXID: gg032inventario.Gg032Almoxid,
                        inGG028_SALDOID: currProduto.Gg033Saldoid,
                        inGG028_TRANSACAOID: null,
                        inGG028_CONTAID: null,
                        inGG028_USUARIOID: gg032inventario.Gg032Usuarioid,
                        inGG028_QTD_MOVIMENTO: currProduto.Gg033Qtdajuste,
                        inGG028_VALOR_UNITARIO: currProduto.Gg033Precocusto,
                        inGG028_SALDO_ANTERIOR: V_SaldoAnteriorProduto,
                        inGG028_N_PDV: null,
                        inProtocolo_Documento: gg032inventario.Gg032Protocolnumber,
                        inGG028_NF_OU_CUPOM: null,
                        inEntSaida_ID: EhEntrada(currProduto) ? in_StID_EntSaida_Entrada_ID : in_StID_EntSaida_Saida_ID,
                        inNatureza_ID: in_StID_Nat_Inventario_ID
                    );


                if (NaoEstaEmConformidade(gg032inventario, currProduto))
                    InvetarioGeraLista_NC_PI(gg032inventario, currProduto);


                _appDbContext.Update(currProduto);
            }
        }

        private void InvetarioGeraLista_NC_PI(CSICP_GG032 gg032inventario, CSICP_GG033 currProduto)
        {
            var id = _generateId.GenerateUuId();
            gg032inventario.Gg032QtosNaoconform += 1;
            var gg037 = new CSICP_GG037
            {
                Gg037Id = id,
                Gg037FilialId = gg032inventario.Gg032Filialid,
                Gg037InventarioId = gg032inventario.Id,
                Gg037SaldoId = currProduto.Gg033Saldoid,
                Gg037QtdNconfirmidade = currProduto.Gg033Qtdajuste,
                Gg037GeradoListaInv = true
            };

            var id_2 = _generateId.GenerateUuId();
            var gg036 = new CSICP_GG036
            {
                Id = id_2,
                Gg036Filialid = gg032inventario.Gg032Filialid,
                Gg036Saldoid = currProduto.Gg033Saldoid,
                Gg036Dataregistro = DateTime.Now.ToLocalTime(),
                Gg036Mensagem = "GERADO DE LISTA DE NÃO CONFORMIDADE",

            };

            _appDbContext.Add(gg037);
            _appDbContext.Add(gg036);
        }

        private static bool NaoEstaEmConformidade(CSICP_GG032 gg032inventario, CSICP_GG033 currProduto)
        {
            return EstaEmConformidade(gg032inventario, currProduto) == false;
        }

        private static bool EstaEmConformidade(CSICP_GG032 gg032inventario, CSICP_GG033 currProduto)
        {
            return EhSaida(currProduto) &&
                                    (gg032inventario.Gg032QtdRegraNconf * -1) < (currProduto.Gg033Qtdajuste * -1);
        }

        private static bool EhEntrada(CSICP_GG033 currProduto)
        {
            return currProduto.Gg033Entsai == "E";
        }

        private static bool EhSaida(CSICP_GG033 currProduto)
        {
            return currProduto.Gg033Entsai == "S";
        }

        private static bool QuantidadeInventarioEhIgualSaldo(CSICP_GG033 currProduto, CSICP_GG520 saldoEncontrado)
        {
            return currProduto.Gg033Qtdinventario == saldoEncontrado.Gg520Saldo;
        }

        private static bool QuantidadeInventarioEhMaiorQueSaldo(CSICP_GG033 currProduto, CSICP_GG520 saldoEncontrado)
        {
            return currProduto.Gg033Qtdinventario > saldoEncontrado.Gg520Saldo;
        }

        private static bool QuantidadeInventarioEhMenorQueSaldo(CSICP_GG033 currProduto, CSICP_GG520 saldoEncontrado)
        {
            return currProduto.Gg033Qtdinventario < saldoEncontrado.Gg520Saldo;
        }

        private static bool ProdutoNaoFoiAlterado(CSICP_GG033 currProduto)
        {
            return currProduto.Gg033Alterado == false;
        }

        private static bool ProdutoNaoEstaMarcadoParaInventariar(CSICP_GG033 current)
        {
            return current.Gg033Naoinventariar == true;
        }


    }
}
