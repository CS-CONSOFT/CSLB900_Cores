using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF;
using CSCore.Ex.Personalizada;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Cria_Titulos.Parametro;
using CSLB900.MSTools.GenerateId;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Cria_Titulos
{
    public class Renegociacao_Cria_Titulos
    {
        private readonly AppDbContext _appDbContext;
        private readonly ICS_GenerateId _generateId;
        private readonly IGenerateProtocolo _generateProtocolo;

        public async Task Executar(Prm_Renegociacao_Cria_Titulo InPrmCriaTitulo)
        {
            CSICP_FF017 WorkFF017 = await _appDbContext.OsusrE9aCsicpFf017s
                .Where(e => e.TenantId == InPrmCriaTitulo.In_TenantID 
                && e.Id == InPrmCriaTitulo.In_FF017_ID)
                .AsNoTracking()
                .FirstOrDefaultAsync() ?? throw new ExceptionSemAuditoria("Renegociação não encontrada!");

            CSICP_FF003 Work_GetEspecie = await _appDbContext.OsusrE9aCsicpFf003s
                .Where(e => e.TenantId == InPrmCriaTitulo.In_TenantID 
                && e.Id == WorkFF017.Ff017Especieid)
                .AsNoTracking()
                .FirstOrDefaultAsync() ?? throw new ExceptionSemAuditoria("Espécie não encontrada!");

            IEnumerable<CSICP_FF999> Work_GetMemoriaCalculo = await _appDbContext.OsusrE9aCsicpFf999s
                .Where(e => e.TenantId == InPrmCriaTitulo.In_TenantID 
                && e.Ff999IdControle == InPrmCriaTitulo.In_FF999_ControleID)
                .AsNoTracking()
                .ToListAsync();

            if(!Work_GetMemoriaCalculo.Any()) throw new ExceptionSemAuditoria("Memória de cálculo não encontrada!");

            decimal protocolo = await _generateProtocolo.Fcn_Protocolo10(InPrmCriaTitulo.In_BB001_FilialID, "CPAGAR");

            bool AuxIsConfAprovAutomatico = await Verifica_ConfirmAutomatico(InPrmCriaTitulo.In_BB001_FilialID, InPrmCriaTitulo.In_TenantID);
            List<CSICP_FF102> FF102EntidadesParaInserir = [];
            foreach (var current in Work_GetMemoriaCalculo)
            {
                CSICP_FF102 AuxFF102ParaInserir = new CSICP_FF102
                {
                    Id = _generateId.GenerateUuId(),
                    TenantId = InPrmCriaTitulo.In_TenantID,
                    Ff102Tiporegistro = WorkFF017.Ff017Tiporegistro == 2 ? 3 : WorkFF017.Ff017Tiporegistro,
                    Ff102Filialid = WorkFF017.Ff017Filialid,
                    Ff102Pfx = Work_GetEspecie.Ff003Pfx,
                    Ff102NoTitulo = protocolo,
                    Ff102Sfx = current.Ff999Parcela?.ToString().PadLeft(2, '0'),
                    Ff102Especieid = WorkFF017.Ff017Especieid,
                    Ff102Tipoparcelaid = current.Ff999Parcela == 1 && WorkFF017.Ff017ValorEntrada > 0 ? InPrmCriaTitulo.In_FF102_Ent_Entrada : InPrmCriaTitulo.In_FF102_Ent_Parcela,
                    Ff102ParcelaX = current.Ff999Parcela ?? 0,
                    Ff102ParcelaY = Work_GetMemoriaCalculo.Count(),
                    Ff102cpConfirmadoId = WorkFF017.Ff017Tiporegistro == 3 && AuxIsConfAprovAutomatico ? InPrmCriaTitulo.In_Statica_Sim : InPrmCriaTitulo.In_Statica_Nao,
                    Ff102cpPagtoautorizadoId = WorkFF017.Ff017Tiporegistro == 3 && AuxIsConfAprovAutomatico ? InPrmCriaTitulo.In_FF102AutPgtoAutorizado : InPrmCriaTitulo.In_FF102AutPgtoNaoAutorizado,
                };
                FF102EntidadesParaInserir.Add(AuxFF102ParaInserir);
            }
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
