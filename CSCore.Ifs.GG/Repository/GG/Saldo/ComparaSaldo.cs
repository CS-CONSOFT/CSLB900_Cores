using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.BaixaSaldo;
using CSCore.Ifs.GG.Repository.Extrato;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG.Saldo
{
    public class ComparaSaldo : IComparaSaldo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IBaixaSaldo _baixaSaldo;
        private readonly IGeraExtrato _geraExtrato;

        public ComparaSaldo(AppDbContext appDbContext, IBaixaSaldo baixaSaldo, IGeraExtrato geraExtrato)
        {
            _appDbContext = appDbContext;
            _baixaSaldo = baixaSaldo;
            _geraExtrato = geraExtrato;
        }

        public async Task<(CSICP_GG520? saldoAtual, int Ret_ComprometeSaldo)> CS_RI_CompSaldo
             (int in_tenant,
            string in_saldoID_origem,
            string in_saldoID_Destino,
            decimal in_Qtda,
            string in_idOrigem,
            DateTime in_DataMovimento, string in_usuarioID,
            string in_protocoloDOC,
            string in_docID,
            int in_Prm_EntSaida_GG073_ID,
            int in_StID_EntSai_GG073_Saida_ID,
            int in_StID_EntSai_GG028_Saida_ID,
            int in_StID_EntSai_GG028_Entrada_ID,
            int in_StID_Gg028NatId,
            int in_StID_StaticaSimNao_SIM_id)
        {
            try
            {
                IQueryable<CSICP_GG520> query = GetQuerySaldo(in_tenant, in_saldoID_origem);

                CSICP_GG520? saldo = await query.FirstOrDefaultAsync();
                if (saldo is null) return (null, -1);

                STATUS_SALDO StatusSaldoAtual_Origem = await _baixaSaldo.CS_BaixarSaldo(
                    in_tenant,
                    in_saldoID_origem,
                    in_protocoloDOC,
                    "GG071",
                    in_usuarioID,
                    in_idOrigem,
                    in_docID,
                    in_DataMovimento,
                    in_Qtda,
                    in_Prm_EntSaida_GG073_ID,
                    in_StID_EntSai_GG073_Saida_ID,
                    in_StID_EntSai_GG028_Saida_ID,
                    in_StID_EntSai_GG028_Entrada_ID,
                    in_StID_Gg028NatId,
                    in_StID_StaticaSimNao_SIM_id);

                if (StatusSaldoAtual_Origem != STATUS_SALDO.OK) throw new Exception();

                STATUS_SALDO StatusSaldoAtual_Destino = await _baixaSaldo.CS_BaixarSaldo(
                    in_tenant,
                    in_saldoID_Destino,
                    in_protocoloDOC,
                    "GG071",
                    in_usuarioID,
                    in_idOrigem,
                    in_docID,
                    in_DataMovimento,
                    in_Qtda,
                    in_Prm_EntSaida_GG073_ID,
                    in_StID_EntSai_GG073_Saida_ID,
                    in_StID_EntSai_GG028_Saida_ID,
                    in_StID_EntSai_GG028_Entrada_ID,
                    in_StID_Gg028NatId,
                    in_StID_StaticaSimNao_SIM_id);


                return (saldo, (int)StatusSaldoAtual_Origem);
            }
            catch (Exception ex)
            {
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }

        private void AtualizaInformacoesGG520NaBase(CSICP_GG520 CSICP_GG520_ParaAtualizar,
            DateTime DataMovimento,
          decimal NovoSaldo)
        {
            // Verificar se a entidade já está sendo rastreada
            var entidadeExistente = _appDbContext.ChangeTracker.Entries<CSICP_GG520>()
                                                   .FirstOrDefault(e => e.Entity.Id == CSICP_GG520_ParaAtualizar.Id);

            if (entidadeExistente != null)
            {
                // Se já estiver rastreando, desanexa a entidade
                entidadeExistente.State = EntityState.Detached;
            }

            // Agora pode atualizar
            CSICP_GG520_ParaAtualizar.Gg520UltimaVenda = DataMovimento;
            CSICP_GG520_ParaAtualizar.Gg520Timestamp = DateTime.UtcNow;
            CSICP_GG520_ParaAtualizar.Gg520Saldo = NovoSaldo;

            _appDbContext.Update(CSICP_GG520_ParaAtualizar);
        }

        private static bool PodeBaixar(int statusRet)
        {
            return statusRet == 0;
        }

        private static bool NaoPodeBaixar(int statusRet)
        {
            return statusRet != 0;
        }


        private IQueryable<CSICP_GG520> GetQuerySaldo(int tenant, string saldoID)
        {
            return from _gg520 in _appDbContext.OsusrE9aCsicpGg520s
                   where _gg520.TenantId == tenant
                   where _gg520.Id == saldoID
                   select new CSICP_GG520
                   {
                       TenantId = _gg520.TenantId,
                       Id = _gg520.Id,
                       Gg520Filialid = _gg520.Gg520Filialid,
                       Gg520KardexId = _gg520.Gg520KardexId,
                       Gg520Almoxid = _gg520.Gg520Almoxid,
                       Gg520NsNumerosaldo = _gg520.Gg520NsNumerosaldo,
                       Gg520Descricaosaldo = _gg520.Gg520Descricaosaldo,
                       Gg520Filial = _gg520.Gg520Filial,
                       Gg520Codalmoxarifado = _gg520.Gg520Codalmoxarifado,
                       Gg520Produto = _gg520.Gg520Produto,
                       Gg520Saldo = _gg520.Gg520Saldo,
                       Gg520Qtdcomprometida = _gg520.Gg520Qtdcomprometida,
                       Gg520QtdProducao = _gg520.Gg520QtdProducao,
                       Gg520QtdEmpenho = _gg520.Gg520QtdEmpenho,
                       Gg520QtdReserva = _gg520.Gg520QtdReserva,
                       Gg520Qnpt = _gg520.Gg520Qnpt,
                       Gg520Qtnp = _gg520.Gg520Qtnp,
                       Gg520Ultinventario = _gg520.Gg520Ultinventario,
                       Gg520Ultfechamento = _gg520.Gg520Ultfechamento,
                       Gg520Qtdultfechamento = _gg520.Gg520Qtdultfechamento,
                       Gg520ItemEmContagem = _gg520.Gg520ItemEmContagem,
                       Gg520Proxinventario = _gg520.Gg520Proxinventario,
                       Gg520Ultrecebimento = _gg520.Gg520Ultrecebimento,
                       Gg520Qtdultrecebto = _gg520.Gg520Qtdultrecebto,
                       Gg520UltimaVenda = _gg520.Gg520UltimaVenda,
                       Gg520QtdeUltVenda = _gg520.Gg520QtdeUltVenda,
                       Gg520Qtdpedidocompra = _gg520.Gg520Qtdpedidocompra,
                       Gg520Lote = _gg520.Gg520Lote,
                       Gg520Sublote = _gg520.Gg520Sublote,
                       Gg520DescricaoLote = _gg520.Gg520DescricaoLote,
                       Gg520Compraid = _gg520.Gg520Compraid,
                       Gg520CodgFornecedor = _gg520.Gg520CodgFornecedor,
                       Gg520Contaid = _gg520.Gg520Contaid,
                       Gg520Usuarioid = _gg520.Gg520Usuarioid,
                       Gg520DataFabricacao = _gg520.Gg520DataFabricacao,
                       Gg520DataValidade = _gg520.Gg520DataValidade,
                       Gg520DiasValidade = _gg520.Gg520DiasValidade,
                       Gg520Docto = _gg520.Gg520Docto,
                       Gg520Serie = _gg520.Gg520Serie,
                       Gg520Compraentrada = _gg520.Gg520Compraentrada,
                       Gg520Gradelinhaid = _gg520.Gg520Gradelinhaid,
                       Gg520Gradecolunaid = _gg520.Gg520Gradecolunaid,
                       Gg520Codggradelinha = _gg520.Gg520Codggradelinha,
                       Gg520Codggradecoluna = _gg520.Gg520Codggradecoluna,
                       Gg520EstqMinimo = _gg520.Gg520EstqMinimo,
                       Gg520Estoquemaximo = _gg520.Gg520Estoquemaximo,
                       Gg520Localizacaowms = _gg520.Gg520Localizacaowms,
                       Gg520Superpromocao = _gg520.Gg520Superpromocao,
                       Gg520Periodicidadeinv = _gg520.Gg520Periodicidadeinv,
                       Gg520Exibiremconsulta = _gg520.Gg520Exibiremconsulta,
                       Gg520Saldozerodesabautom = _gg520.Gg520Saldozerodesabautom,
                       Gg520Permitetroca = _gg520.Gg520Permitetroca,
                       Gg520Vbcstret = _gg520.Gg520Vbcstret,
                       Gg520Vicmsstret = _gg520.Gg520Vicmsstret,
                       Gg520Isactive = _gg520.Gg520Isactive,
                       Gg520CodbarrasId = _gg520.Gg520CodbarrasId,
                       Gg520Timestamp = _gg520.Gg520Timestamp,
                       Gg520Ispdv = _gg520.Gg520Ispdv,
                       Gg520Vicmssubstituto = _gg520.Gg520Vicmssubstituto,
                       Gg520VfuturaSaldoid = _gg520.Gg520VfuturaSaldoid,
                   };
        }

        private static bool TemSaldoSuficiente(decimal prm_Qtda, CSICP_GG520 saldo)
        {
            return saldo.Gg520Saldo >= prm_Qtda;
        }

        private static bool NaoTemSaldoSuficiente(decimal prm_Qtda, CSICP_GG520 saldo)
        {
            return saldo.Gg520Saldo < prm_Qtda;
        }

        private static bool EhSaldoNegativo(CSICP_GG520 saldo)
        {
            return saldo.Gg520Saldo < 0;
        }

        private static bool EhSaldoEmContagem(CSICP_GG520 saldo)
        {
            return saldo.Gg520ItemEmContagem == true;
        }

        private static bool EhSaldoZero(CSICP_GG520 saldo)
        {
            return saldo.Gg520Saldo == 0;
        }
    }
}





