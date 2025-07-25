using CSCore.Domain;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Compartilhado.Utilidade
{
    public static class RecuperaSeqNroConta
    {
        public static async Task<string> Get_SeqNroConta(
            AppDbContext in_appDbContext, int in_tenant, string in_filialID, string in_novoIdAA006)
        {
            CSICP_AA006? aa006 = await in_appDbContext.OsusrE9aCsicpAa006s
                .Where(e => e.TenantId == in_tenant)
                .Where(e => e.Aa006Filialid == in_filialID)
                .Where(e => e.Aa006Arquivo == "BB012")
                .FirstOrDefaultAsync();


            decimal maxCI = await in_appDbContext.OsusrE9aCsicpAa006s
                .Where(e => e.TenantId == in_tenant)
                .Where(e => e.Aa006Filialid == in_filialID)
                .Where(e => e.Aa006Arquivo == "BB012")
                .MaxAsync(e => e.Aa006Ci) ?? 0;

            int codigoEmpresa = await in_appDbContext.E9ACSICP_BB001s
                .Where(e => e.TenantId == in_tenant && e.Id == in_filialID)
                .Select(e => e.Bb001Codigoempresa)
                .FirstOrDefaultAsync() ?? 0;

            string codigoNovo = codigoEmpresa + "0000001";

            if (aa006 is null)
            {
                aa006 = new CSICP_AA006
                {
                    Id = in_novoIdAA006,
                    Aa006Filialid = in_filialID,
                    Aa006Arquivo = "BB012",
                    Aa006Ci = 1,
                    Aa006Filial = codigoEmpresa,
                    Aa006Dataultcaptura = DateTime.UtcNow.ToLocalTime()
                };
                in_appDbContext.Add(aa006);
                await in_appDbContext.SaveChangesAsync();
                return codigoNovo;
            }


            aa006.Aa006Ci = CiEhMaiorQueMaxNove(aa006) ? 1 : aa006.Aa006Ci + 1;
            aa006.Aa006Dataultcaptura = DateTime.UtcNow.ToLocalTime();
            in_appDbContext.Update(aa006);
            await in_appDbContext.SaveChangesAsync();

            if (CiEhMaiorQueMaxNove(aa006)) codigoNovo = 1.ToString();
            if (CiEhMaiorQueMaxNove(aa006) == false)
            {
                string codigoEmpresaFormatado = codigoEmpresa.ToString("D3");
                string novoCIFormatado = maxCI.ToString();
                string resultado = codigoEmpresaFormatado + novoCIFormatado.ToString();
                return resultado;
            }

            return "Algum erro ocorreu!";

        }

        private static bool CiEhMaiorQueMaxNove(CSICP_AA006 aa006)
        {
            return aa006.Aa006Ci >= 9999999999;
        }
    }
}
