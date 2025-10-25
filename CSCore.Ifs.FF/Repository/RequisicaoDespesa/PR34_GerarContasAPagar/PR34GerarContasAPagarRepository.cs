using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.LB900;
using CSLB900.MSTools.Calculos.MemoriaDeCalculoV2;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.RequisicaoDespesa.PR34_GerarContasAPagar
{
    public interface IPR34GerarContasAPagarRepository
    {
        Task CS003_Gera_Titulo(
            int tenant,
            long ff140Id,
            string NovoFF102_ID,
            string InEmpresaID,
            int InStIDcsicp_ff102_Ent_Parcela,
            int InStIDcsicp_ff102_sitAberto,
            int InStIDEstaticaSIM,
            int InStIDEstaticaNAO,
            Rec_Memoria rec_Memoria);
    }
    public class PR34GerarContasAPagarRepository : IPR34GerarContasAPagarRepository
    {
        private readonly AppDbContext appDbContext; 


        public PR34GerarContasAPagarRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task CS003_Gera_Titulo(
            int tenant,
            long ff140Id,
            string NovoFF102_ID,
            string InEmpresaID,
            int InStIDcsicp_ff102_Ent_Parcela,
            int InStIDcsicp_ff102_sitAberto,
            int InStIDEstaticaSIM,
            int InStIDEstaticaNAO,
            Rec_Memoria rec_Memoria)
        {
            var ff140 = 
                await this.appDbContext.OsusrE9aCsicpFf140s.Where(e => e.TenantId == tenant && e.Ff140Id == ff140Id).FirstOrDefaultAsync() ?? throw new KeyNotFoundException();
            var isTrue = await Verifica_ConfirmAutomatico.Verifica(InEmpresaID, tenant, this.appDbContext);
            var ff102 = CSICP_FF102.CreateInstance(
                       id: NovoFF102_ID,
                       tenantId: tenant,
                       ff102Tiporegistro: 3,
                       ff102Filialid: InEmpresaID,
                       ff102Tipoparcelaid: InStIDcsicp_ff102_Ent_Parcela,
                       ff102ParcelaX: rec_Memoria.Parcela,
                       ff102ParcelaY: rec_Memoria.Nro_Parcelas,
                       ff102Contaid: ff140.Ff140Contaid,
                       ff102Ccustoid: ff140.Ff140Ccustoid,
                       ff102Usuarioproprieid: ff140.Ff140Usuarioproprieid,
                       ff102Agcobradorid: ff140.Ff140Agcobradorid,
                       ff102Condicaoid: ff140.Ff140Condicaoid,
                       ff102DataEmissao: ff140.Ff140Data,
                       ff102DataVencimento:new DateTime(rec_Memoria.Data_Vencto.Year, rec_Memoria.Data_Vencto.Month, rec_Memoria.Data_Vencto.Day) ,
                       ff102ValorTitulo: rec_Memoria.Valor_Parcela,
                       ff102VlLiqTitulo: rec_Memoria.Valor_Parcela,
                       ff102Observacao: "Geração em massa de Titulos CP " + ff140.Ff140Protocolnumber,
                       ff102FluxoCaixa: InStIDEstaticaSIM,
                       ff102Situacaoid: InStIDcsicp_ff102_sitAberto,
                       ff10FpagtoId: ff140.Ff140FpagtoId,
                       ff102cpConfirmadoId: isTrue ? InStIDEstaticaSIM : InStIDEstaticaNAO,
                       ff102cpPagtoautorizadoId: isTrue ? InStIDEstaticaSIM : InStIDEstaticaNAO,
                       ff102Especieid: ff140.Ff140Especieid,
                       ff102Nodiasliberacao: 0,
                       ff102AdtoId: ff140.Ff140AdtoId);
            await this.appDbContext.OsusrE9aCsicpFf102s.AddAsync(ff102);
        }
    }
}
