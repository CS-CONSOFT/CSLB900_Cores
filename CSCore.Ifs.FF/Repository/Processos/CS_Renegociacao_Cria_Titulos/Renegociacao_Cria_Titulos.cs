using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ex.Personalizada;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Cria_Titulos.Parametro;
using CSCore.Ifs.LB900.AdapterGerarValores;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Cria_Titulos
{
    public class Renegociacao_Cria_Titulos : IRenegociacaoCriaTitulo
    {
        private readonly AppDbContext _appDbContext;


        private readonly ICS_GenerateId _generateId;
        private readonly IGenerateProtocolo _generateProtocolo;

        public Renegociacao_Cria_Titulos(AppDbContext appDbContext, ICS_GenerateId generateId, IGenerateProtocolo generateProtocolo)
        {
            _appDbContext = appDbContext;
            _generateId = generateId;
            _generateProtocolo = generateProtocolo;
        }

        public async Task<bool> Executar(Prm_Renegociacao_Cria_Titulo InPrmCriaTitulo)
        {
            using var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {

                CSICP_FF017 WorkFF017 = await GetRenegociacaoById(InPrmCriaTitulo);

                IEnumerable<CSICP_FF999> Work_GetMemoriaCalculo = await GetMemoriaCalculoByControleId(InPrmCriaTitulo);

                if (!Work_GetMemoriaCalculo.Any()) throw new Exception("Memória de cálculo não encontrada!");

                decimal protocolo = await _generateProtocolo.Fcn_Protocolo10(InPrmCriaTitulo.InBB001FilialID, "CPAGAR");

                bool AuxIsConfAprovAutomatico = await Verifica_ConfirmAutomatico(InPrmCriaTitulo.InBB001FilialID, InPrmCriaTitulo.InTenantID);

                CSICP_FF003 Work_GetEspecie = await GetEspecieById(InPrmCriaTitulo, WorkFF017);

                var Work_AgenteCobrador = await (from bb006 in _appDbContext.OsusrE9aCsicpBb006s
                                                 where bb006.TenantId == InPrmCriaTitulo.InTenantID
                                                 && bb006.Id == WorkFF017.Ff017Agcobradorid && bb006.Bb006Isactive == true
                                                 join sy001 in _appDbContext.OsusrE9aCsicpSy001s
                                                 on bb006.Bb006CodcobradorId equals sy001.Id into sy001Group
                                                 from sy001 in sy001Group.DefaultIfEmpty()
                                                 select new
                                                 {
                                                     bb006.Bb006CodcobradorId,
                                                     bb006.Bb006Nomereduzido,
                                                     bb006.Bb006Isactive,
                                                     sy001.Sy001Nome
                                                 }).AsNoTrackingWithIdentityResolution().FirstOrDefaultAsync()
                                                 ?? throw new Exception("Agente cobrador não encontrado!");

                List<CSICP_FF102> FF102EntidadesParaInserir = [];
                List<CSICP_FF103> FF103EntidadesParaInserir = [];
                List<CSICP_FF104> FF104EntidadesParaInserir = [];
                List<CSICP_FF999> FF999EntidadesParaDeletar = [];

                foreach (var current in Work_GetMemoriaCalculo)
                {
                    string? Ff102SfxValue = current.Ff999Parcela?.ToString().PadLeft(2, '0');
                    CSICP_FF102 AuxFF102ParaInserir = CriarEntidadeFF102(InPrmCriaTitulo, WorkFF017, Work_GetMemoriaCalculo, protocolo, AuxIsConfAprovAutomatico, Work_GetEspecie, Work_AgenteCobrador.Bb006CodcobradorId, current, Ff102SfxValue);
                    FF102EntidadesParaInserir.Add(AuxFF102ParaInserir);

                    CSICP_FF104 AuxFF104ParaInserir = CriaEntidadeFF104(InPrmCriaTitulo, WorkFF017, AuxFF102ParaInserir);
                    FF104EntidadesParaInserir.Add(AuxFF104ParaInserir);

                    // Adiciona o título atual à lista de títulos a serem deletados
                    FF999EntidadesParaDeletar.Add(current);

                    if (IsEntLiquidadaEPrimeiraParcela(InPrmCriaTitulo, Ff102SfxValue))
                    {
                        CSICP_FF103 AuxFF103ParaInserir = CriaEntidadeFF103(InPrmCriaTitulo, WorkFF017, AuxFF102ParaInserir);
                        FF103EntidadesParaInserir.Add(AuxFF103ParaInserir);
                    }
                }
                // Atualiza os campos da renegociação
                WorkFF017.Ff017Aberto = false;
                List<CSICP_FF102> FF102EntidadesParaAtualizar = await GetTitulosParaAtualizar(InPrmCriaTitulo, WorkFF017);
                await PersistirRenegociacaoTitulos(WorkFF017, FF102EntidadesParaInserir, FF103EntidadesParaInserir, FF104EntidadesParaInserir, FF999EntidadesParaDeletar, FF102EntidadesParaAtualizar);
                await transaction.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                if (ex is ExceptionSemAuditoria) throw new ExceptionSemAuditoria(1001, HandlerExceptionMessage.CreateExceptionMessage(ex));
                else throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }

        private CSICP_FF103 CriaEntidadeFF103(Prm_Renegociacao_Cria_Titulo InPrmCriaTitulo, CSICP_FF017 WorkFF017, CSICP_FF102 AuxFF102ParaInserir)
        {
            return new CSICP_FF103
            {
                Id =  _generateId.GenerateUuId(),
                TenantId = InPrmCriaTitulo.InTenantID,
                Ff103Filialid = AuxFF102ParaInserir.Ff102Filialid,
                Ff103Pfx = AuxFF102ParaInserir.Ff102Pfx,
                Ff103NoTitulo = AuxFF102ParaInserir.Ff102NoTitulo,
                Ff103Sfx = AuxFF102ParaInserir.Ff102Sfx,
                Ff103SeqBaixa = 1,
                Ff103DataBaixa = DateTime.UtcNow.ToLocalTime(),
                Ff103DataCredito = DateTime.UtcNow.ToLocalTime(),
                Ff103Agcobradorid = AuxFF102ParaInserir.Ff102Agcobradorid,
                Ff103ValorPago = AuxFF102ParaInserir.Ff102ValorTitulo,
                Ff103Usuarioproprid = AuxFF102ParaInserir.Ff102Usuarioproprieid,
                Ff103Cobradorid = AuxFF102ParaInserir.Ff102Agcobradorid,
                Ff103Tpbaixaid = InPrmCriaTitulo.InSTIDFf103TpBaiAutPgtoNaoAutorizado,
                Ff103FpagtoId = AuxFF102ParaInserir.Ff10FpagtoId,
                Ff103Historico = "Bx via Vale Crédito da Renegociação",
                Ff103ObjBxLabel = "BXRENEG",
                Ff103ObjBxId = WorkFF017.Id,
                Ff103Baixado = true
            };
        }

        private CSICP_FF104 CriaEntidadeFF104(Prm_Renegociacao_Cria_Titulo InPrmCriaTitulo, CSICP_FF017 WorkFF017, CSICP_FF102 AuxFF102ParaInserir)
        {
            return new CSICP_FF104
            {
                Id = _generateId.GenerateUuId(),
                TenantId = InPrmCriaTitulo.InTenantID,
                Ff104Filialid = WorkFF017.Ff017Filialid,
                Ff104Renegociacaoid = WorkFF017.Id,
                Ff102Id = AuxFF102ParaInserir.Id,
                Ff104Dataemissao = WorkFF017.Ff017DataRenegociacao ?? DateTime.UtcNow.ToLocalTime(),
                Ff104Valornf = WorkFF017.Ff017Totrenegociado,
                Ff104CiNfNCupom = decimal.Parse(WorkFF017.Ff017Protocolnumber ?? "0"),
            };
        }

        private bool IsEntLiquidadaEPrimeiraParcela(Prm_Renegociacao_Cria_Titulo InPrmCriaTitulo, string? Ff102SfxValue)
            {
                return InPrmCriaTitulo.InEntLiquidada && Ff102SfxValue == "01";
            }

        private CSICP_FF102 CriarEntidadeFF102(Prm_Renegociacao_Cria_Titulo InPrmCriaTitulo, CSICP_FF017 WorkFF017, IEnumerable<CSICP_FF999> Work_GetMemoriaCalculo, decimal protocolo, bool AuxIsConfAprovAutomatico, CSICP_FF003 Work_GetEspecie, string Bb006CodcobradorId, CSICP_FF999 current, string? Ff102SfxValue)
        {
            return new CSICP_FF102
            {
                Id = _generateId.GenerateUuId(),
                TenantId = InPrmCriaTitulo.InTenantID,
                Ff102Tiporegistro = WorkFF017.Ff017Tiporegistro == 2 ? 3 : WorkFF017.Ff017Tiporegistro,
                Ff102Filialid = WorkFF017.Ff017Filialid,
                Ff102Pfx = Work_GetEspecie.Ff003Pfx,
                Ff102NoTitulo = protocolo,
                Ff102Sfx = Ff102SfxValue,
                Ff102Especieid = WorkFF017.Ff017Especieid,
                Ff102Tipoparcelaid = current.Ff999Parcela == 1 && WorkFF017.Ff017ValorEntrada > 0 ? InPrmCriaTitulo.InStIDFF102EntEntrada : InPrmCriaTitulo.InStIDFF102EntParcela,
                Ff102ParcelaX = current.Ff999Parcela ?? 0,
                Ff102ParcelaY = Work_GetMemoriaCalculo.Count(),
                Ff102cpConfirmadoId = WorkFF017.Ff017Tiporegistro == 3 && AuxIsConfAprovAutomatico ? InPrmCriaTitulo.InSTIDStaticaSim : InPrmCriaTitulo.InSTIDStaticaNao,
                Ff102cpPagtoautorizadoId = WorkFF017.Ff017Tiporegistro == 3 && AuxIsConfAprovAutomatico ? InPrmCriaTitulo.InSTIDFF102AutPgtoAutorizado : InPrmCriaTitulo.InSTIDFF102AutPgtoNaoAutorizado,
                Ff102Contaid = WorkFF017.Ff017Contatomadordivid ?? WorkFF017.Ff017Contaid,
                Ff102Ccustoid = WorkFF017.Ff017Ccustoid,
                Ff102Usuarioproprieid = InPrmCriaTitulo.InSy001ID,
                Ff102Agcobradorid = Bb006CodcobradorId,
                Ff102Condicaoid = WorkFF017.Ff017Condicaoid,
                Ff102DataEmissao = WorkFF017.Ff017DataRenegociacao ?? DateTime.UtcNow.ToLocalTime(),
                Ff102DataVencimento = current.Ff999Datavencto ?? DateTime.UtcNow.ToLocalTime(),
                Ff102DataVencReal = current.Ff999Datavencto ?? DateTime.UtcNow.ToLocalTime(),
                Ff102ValorTitulo = current.Ff999Valorparcela ?? 0,
                Ff102FluxoCaixa = InPrmCriaTitulo.InSTIDStaticaSim,
                Ff102Origem = "Renegociação",
                Ff102Situacaoid = IsEntLiquidadaEPrimeiraParcela(InPrmCriaTitulo, Ff102SfxValue) ? InPrmCriaTitulo.InSTIDFF102SitLiquidado : InPrmCriaTitulo.InStIDFF102SitAberto,
                Ff10FpagtoId = WorkFF017.Ff017Formapagtoid
            };
        }

        private async Task PersistirRenegociacaoTitulos(CSICP_FF017 WorkFF017, List<CSICP_FF102> FF102EntidadesParaInserir, List<CSICP_FF103> FF103EntidadesParaInserir, List<CSICP_FF104> FF104EntidadesParaInserir, List<CSICP_FF999> FF999EntidadesParaDeletar, List<CSICP_FF102> FF102EntidadesParaAtualizar)
        {
            _appDbContext.AddRange(FF102EntidadesParaInserir);
            _appDbContext.AddRange(FF103EntidadesParaInserir);
            _appDbContext.AddRange(FF104EntidadesParaInserir);
            _appDbContext.UpdateRange(FF102EntidadesParaAtualizar);
            _appDbContext.RemoveRange(FF999EntidadesParaDeletar);
            _appDbContext.Update(WorkFF017);

            await _appDbContext.SaveChangesAsync();

        }

        private async Task<List<CSICP_FF102>> GetTitulosParaAtualizar(Prm_Renegociacao_Cria_Titulo InPrmCriaTitulo, CSICP_FF017 WorkFF017)
        {
            List<string?> AuxFF018TitulosIds = await _appDbContext.OsusrE9aCsicpFf018s
                .Where(e => e.TenantId == InPrmCriaTitulo.InTenantID
                && e.Ff017Id == WorkFF017.Id)
                .AsNoTracking()
                .Select(e => e.Ff102Tituloid)
                .ToListAsync();

            // Buscar todos os títulos em uma única consulta
            Dictionary<string, CSICP_FF102> AuxTitulosDict = await _appDbContext.OsusrE9aCsicpFf102s
                .Where(e => e.TenantId == InPrmCriaTitulo.InTenantID && AuxFF018TitulosIds.Contains(e.Id))
                .AsNoTracking()
                .ToDictionaryAsync(e => e.Id, e => e);

            List<CSICP_FF102> FF102EntidadesParaAtualizar = [];
            foreach (var current in AuxFF018TitulosIds)
            {
                if (current == null || !AuxTitulosDict.TryGetValue(current, out var workFF102))
                    continue;
                if (workFF102 is null) continue;

                workFF102.Ff102Situacaoid = InPrmCriaTitulo.InSTIDFF102SitRenegociado;
                workFF102.Ff102Dtimestamp = DateTime.UtcNow.ToLocalTime();
                FF102EntidadesParaAtualizar.Add(workFF102);
            }

            return FF102EntidadesParaAtualizar;
        }

        private async Task<CSICP_FF003> GetEspecieById(Prm_Renegociacao_Cria_Titulo InPrmCriaTitulo, CSICP_FF017 WorkFF017)
        {
            return await _appDbContext.OsusrE9aCsicpFf003s
                           .Where(e => e.TenantId == InPrmCriaTitulo.InTenantID
                           && e.Id == WorkFF017.Ff017Especieid)
                           .AsNoTracking()
                           .FirstOrDefaultAsync() ?? throw new ExceptionSemAuditoria("Espécie não encontrada!");
        }

        private async Task<IEnumerable<CSICP_FF999>> GetMemoriaCalculoByControleId(Prm_Renegociacao_Cria_Titulo InPrmCriaTitulo)
        {
            return await _appDbContext.OsusrE9aCsicpFf999s
                .Where(e => e.TenantId == InPrmCriaTitulo.InTenantID
                && e.Ff999IdControle == InPrmCriaTitulo.InFF999ControleID)
                .AsNoTracking()
                .ToListAsync();
        }

        private async Task<CSICP_FF017> GetRenegociacaoById(Prm_Renegociacao_Cria_Titulo InPrmCriaTitulo)
        {
            return await _appDbContext.OsusrE9aCsicpFf017s
                .Where(e => e.TenantId == InPrmCriaTitulo.InTenantID
                && e.Id == InPrmCriaTitulo.InFF017ID)
                .AsNoTracking()
                .FirstOrDefaultAsync() ?? throw new ExceptionSemAuditoria("Renegociação não encontrada!");
        }

        private async Task<bool> Verifica_ConfirmAutomatico(string In_FilialID, int In_TenantID)
        {
            CSICP_FF000? WorkFF000 = await _appDbContext.OsusrE9aCsicpFf000s
                .Where(e => e.Ff000EstabId == In_FilialID && e.TenantId == In_TenantID)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            return WorkFF000 == null ? false : WorkFF000.Ff000Isdesabfcconfaut ?? false;
        }
    }
}
