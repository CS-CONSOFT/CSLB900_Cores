using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.Extrato;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.BaixaSaldo
{
    public enum ESTADO_SALDO
    {
        OK = 0,
        BAIXADO = 2,
        INVENTARIO = 5,
        SALDO_ZERO = 6,
        SALDO_NEGATIVO = 4,
        ERROR = 4
    }

    public enum FLAG_ERRO_SUCESSO
    {
        SUCCESS = 0,
        ERROR = 1
    }

    public enum STATUS_SALDO
    {
        OK = 0,
        EM_CONTAGEM = 1,
        SALDO_ZERO = 2,
        SALDO_NEGATIVO = 3,
        ERRO = -1
    }

    public class BaixaSaldoImpl(AppDbContext appDbContext, IGeraExtrato geraExtrato)
        : IBaixaSaldo
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly IGeraExtrato _geraExtrato = geraExtrato;


        public async Task<STATUS_SALDO> CS_BaixarSaldo(
            int in_tenant,
            string? in_G520_ID_origem,
            string? in_protocolo,
            string? in_programaOrigem,
            string? in_usuarioID,
            string? in_idOrigemPkID,
            string? in_docID_PkID,
            DateTime in_DataMovimento,
            decimal in_quantidadeASerBaixada,
            int in_Prm_EntSaida_GG073_ID,
            int in_StID_EntSai_GG073_Saida_ID,
            int in_StID_EntSai_GG028_Saida_ID,
            int in_StID_EntSai_GG028_Entrada_ID,
            int in_StID_Gg028NatId,
            int in_StID_StaticaSimNao_SIM_id)
        {
            CSICP_GG520? gg520_encontrada = await GetGG520(in_G520_ID_origem ?? "", in_tenant);
            if (gg520_encontrada is null) return STATUS_SALDO.ERRO;

            decimal saldoGG520Anterior = gg520_encontrada.Gg520Saldo;

            STATUS_SALDO statusSaldo = STATUS_SALDO.OK;

            if (gg520_encontrada.Gg520ItemEmContagem == true) return STATUS_SALDO.EM_CONTAGEM;

            int in_gg028_entSaida_ID = 0;
            if (EhMovimentoEntrada(in_Prm_EntSaida_GG073_ID, in_StID_EntSai_GG073_Saida_ID))
            {
                in_gg028_entSaida_ID = in_StID_EntSai_GG028_Entrada_ID;
                await BaixaSaldoAumentandoEstoque(in_DataMovimento, in_quantidadeASerBaixada, gg520_encontrada);
            }
            ;


            if (EhMovimentoSaida(in_Prm_EntSaida_GG073_ID, in_StID_EntSai_GG073_Saida_ID))
            {
                in_gg028_entSaida_ID = in_StID_EntSai_GG028_Saida_ID;
                if (PermiteSaldoNegativo(in_StID_StaticaSimNao_SIM_id, gg520_encontrada))
                {
                    await BaixaSaldoSubtraindoEstoque(in_DataMovimento, in_quantidadeASerBaixada, gg520_encontrada);
                }

                if (gg520_encontrada.Gg520Saldo == 0) return STATUS_SALDO.SALDO_ZERO;
                if (gg520_encontrada.Gg520Saldo < 0) return STATUS_SALDO.SALDO_NEGATIVO;
                await BaixaSaldoSubtraindoEstoque(in_DataMovimento, in_quantidadeASerBaixada, gg520_encontrada);
            }

            await MontaParametrosEGeraExtrato(
                      in_tenant,
                      in_gg028_entSaida_ID,
                      gg520_encontrada,
                      in_DataMovimento,
                      in_usuarioID ?? "",
                      in_docID_PkID ?? "",
                      in_programaOrigem ?? "",
                      in_idOrigemPkID ?? "",
                      in_protocolo ?? "",
                      in_StID_Gg028NatId,
                      in_quantidadeASerBaixada,
                      saldoGG520Anterior
                      );

            return statusSaldo;
        }

        public async Task AtualizaStatusDaGG074(CSICP_GG074 navCurrentGG074, int estado_saldo)
        {
            navCurrentGG074.NavGG008Kdx = null;
            int idStq = await LerIdDaGG072Stq(estado_saldo);
            navCurrentGG074.Gg074Statusestqid = idStq;
            _appDbContext.Update(navCurrentGG074);

        }

        private async Task<int> LerIdDaGG072Stq(int estado_saldo)
        {
            IQueryable<CSICP_GG072Stq> query = from _gg072Stq in _appDbContext.OsusrE9aCsicpGg072Stqs
                                               where _gg072Stq.Codgcs == estado_saldo
                                               select _gg072Stq;

            int id = await query.Select(e => e.Id).FirstOrDefaultAsync();

            return id;
        }


        private async Task MontaParametrosEGeraExtrato(
            int in_tenant,
            int in_idEntradaSaida,
            CSICP_GG520? in_gg520_encontrada,
            DateTime IN_GG028_DATA_MOVIMENTO,
            string in_usuarioID,
            string IN_GG028_ORIGEM_DOC_PKID,
            string IN_GG028_ORIGEMPROGRAMA,
            string IN_GG028_ORIGEM_PKID,
            string IN_Protocolo_Documento,
            int in_GG028_Nat_ID,
            decimal in_QuantidadeASerBaixada,
            decimal in_quantidadeAnterior
           )
        {
            ParametroGeraExtrato_2 parametroGeraExtrato = new()
            {
                Doc_PKID = IN_GG028_ORIGEM_DOC_PKID,
                in_origemID = IN_GG028_ORIGEM_PKID,
                GG520_ID = in_gg520_encontrada!.Id,
                Movimento_DataMovimento = IN_GG028_DATA_MOVIMENTO,
                UsuarioID = in_usuarioID,
                ProgramaOrigem = IN_GG028_ORIGEMPROGRAMA,
                Protocolo_Documento = IN_Protocolo_Documento,
                GG028_Nat_ID = in_GG028_Nat_ID,
                Nav_CSICP_GG520 = in_gg520_encontrada,
                GG028_Tmov_EntradaSaida_ID = in_idEntradaSaida,
                QuantidadeASerBaixada = in_QuantidadeASerBaixada,
                QuantidadeAnterior = in_quantidadeAnterior
            };
            await _geraExtrato.CS_CriaExtratoOrigem(parametroGeraExtrato, in_tenant);
        }



        private async Task CS_BaixarSaldo_Fim(CSICP_GG520 CSICP_GG520_ParaAtualizar, DateTime DataMovimento, Func<decimal> calculaSaldo)
        {
            await AtualizaInformacoesGG520NaBase(CSICP_GG520_ParaAtualizar, DataMovimento, calculaSaldo());
        }

        private async Task AtualizaInformacoesGG520NaBase(CSICP_GG520 CSICP_GG520_ParaAtualizar, DateTime DataMovimento,
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

            // Verificar se a entidade relacionada GG008Kdx está sendo rastreada
            if (CSICP_GG520_ParaAtualizar.Nav_GG008Kardex != null)
            {
                var entidadeRelacionadaExistente = _appDbContext.ChangeTracker.Entries<CSICP_GG008Kdx>()
                    .FirstOrDefault(e => e.Entity.Gg008Kardexid == CSICP_GG520_ParaAtualizar.Nav_GG008Kardex.Gg008Kardexid);

                if (entidadeRelacionadaExistente != null)
                {
                    entidadeRelacionadaExistente.State = EntityState.Detached;
                }
            }

            // Agora pode atualizar
            CSICP_GG520_ParaAtualizar.Gg520UltimaVenda = DataMovimento;
            CSICP_GG520_ParaAtualizar.Gg520Timestamp = DateTime.UtcNow;
            CSICP_GG520_ParaAtualizar.Gg520Saldo = NovoSaldo;

            // Definir a entidade relacionada como null para evitar problemas de rastreamento
            CSICP_GG520_ParaAtualizar.Nav_GG008Kardex = null;

            _appDbContext.Update(CSICP_GG520_ParaAtualizar);
            await _appDbContext.SaveChangesAsync();
        }

        private async Task<CSICP_GG520?> GetGG520(string SaldoID_GG520, int tenant)
        {
            IQueryable<CSICP_GG520> queryGG520 = from _gg520 in _appDbContext.OsusrE9aCsicpGg520s
                                                 where _gg520.Id == SaldoID_GG520
                                                 where _gg520.TenantId == tenant

                                                 join _gg008Kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes.AsNoTracking()
                                                 on _gg520.Gg520KardexId equals _gg008Kdx.Gg008Kardexid into join_gg520_gg008kdx
                                                 from _gg008Kdx in join_gg520_gg008kdx.DefaultIfEmpty()

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
                                                     Nav_GG008Kardex = new CSICP_GG008Kdx
                                                     {
                                                         Gg008Kardexid = _gg008Kdx.Gg008Kardexid,
                                                         Gg008Permsldnegativo = _gg008Kdx.Gg008Permsldnegativo,
                                                     }
                                                 };

            CSICP_GG520? gg520_encontrada = await queryGG520.FirstOrDefaultAsync();
            return gg520_encontrada;
        }


        public async Task BaixaSaldoAumentandoEstoque(
            DateTime Movimento_DataMovimento,
            decimal QuantidadeASerBaixada,
            CSICP_GG520 gg520_encontrada)
        {
            await CS_BaixarSaldo_Fim(gg520_encontrada, Movimento_DataMovimento,
                () => gg520_encontrada.Gg520Saldo + QuantidadeASerBaixada);
        }

        public async Task BaixaSaldoSubtraindoEstoque(DateTime Movimento_DataMovimento, decimal QuantidadeASerBaixada, CSICP_GG520 gg520_encontrada)
        {
            await CS_BaixarSaldo_Fim(gg520_encontrada, Movimento_DataMovimento,
                                   () => gg520_encontrada.Gg520Saldo - QuantidadeASerBaixada);
        }


        private static bool PermiteSaldoNegativo(int Estatica_SIM_Id, CSICP_GG520 gg520_encontrada)
        {
            return gg520_encontrada.Nav_GG008Kardex.Gg008Permsldnegativo == Estatica_SIM_Id;
        }


        private static bool EhMovimentoEntrada(int Prm_SdID_GG073_EntSaida_ID, int csicp_gg073_EntSaida_Saida_ID)
        {
            return Prm_SdID_GG073_EntSaida_ID != csicp_gg073_EntSaida_Saida_ID;
        }

        private static bool EhMovimentoSaida(int Prm_SdID_GG073_EntSaida_ID, int csicp_gg073_EntSaida_Saida_ID)
        {
            return Prm_SdID_GG073_EntSaida_ID == csicp_gg073_EntSaida_Saida_ID;
        }
    }
}





