using CSCore.Domain.Interfaces.Estatica;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Estatica.Repository.Statica
{
    public class StaticaLabelRepositoryImpl(AppDbContext appDbContext) : IStaticaLabelRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<int> GetIDStaticasByTypeGG071StaPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg071Sta
                .Where(e => e.IsActive == true)
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }
        public async Task<int> GetIDStaticasByTypeFF102_EntPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpFf102Ents
                .Where(e => e.IsActive == true)
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeFF102_SitPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpFf102Sits
                .Where(e => e.IsActive == true)
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }


        public async Task<int> GetIDStaticasByTypeGG073StatusPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg073Stats
                .Where(e => e.IsActive == true)
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeGG072StqPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg072Stqs
               .Where(e => e.IsActive == true)
               .Where(e => e.Label!.Equals(label))
               .Select(e => e.Id)
               .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeGG028NatOpLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg028Nats
              .Where(e => e.IsActive == true)
              .Where(e => e.Label!.Equals(label))
              .Select(e => e.Id)
              .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeGG028EntSaidaLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg028Entsais
             .Where(e => e.IsActive == true)
             .Where(e => e.Label!.Equals(label))
             .Select(e => e.Id)
             .FirstOrDefaultAsync();
            return ID;
        }


        public async Task<int> GetIDStaticasByTypeGG073TMovPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg073Tmovs
             .Where(e => e.IsActive == true)
             .Where(e => e.Label!.Equals(label))
             .Select(e => e.Id)
             .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeBB012_MRELPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpBb012Mrels
               .Where(e => e.IsActive == true)
               .Where(e => e.Label!.Equals(label))
               .Select(e => e.Id)
               .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeGG054StaPorCodCS(int codCs)
        {

            int ID = await _appDbContext.OsusrE9aCsicpGg054Sta
               .Where(e => e.IsActive == true)
               .Where(e => e.Codgcs == codCs)
               .Select(e => e.Id)
               .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeGG055StaPorCodCS(int codCs)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg055Sta
             .Where(e => e.IsActive == true)
             .Where(e => e.Codgcs == codCs)
             .Select(e => e.Id)
             .FirstOrDefaultAsync();
            return ID;
        }





        public async Task<int> GetIDStaticasByTypeGG032TpInvPorCodCS(string codCs)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg032Tpinvs
             .Where(e => e.IsActive == true)
             .Where(e => e.Codgcs!.Equals(codCs))
             .Select(e => e.Id)
             .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeGG032StaPorCodCS(string codCs)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg032Sta
             .Where(e => e.IsActive == true)
             .Where(e => e.Codgcs!.Equals(codCs))
             .Select(e => e.Id)
             .FirstOrDefaultAsync();
            return ID;
        }
        public async Task<int> GetIDStaticasByTypeBB061_TPPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpBb061Tps
                .Where(e => e.IsActive == true)
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }
        public async Task<int> GetIDStaticasByTypeE9ACSICP_StaticaPorLabel(string label)
        {
            int ID = await _appDbContext.E9ACSICP_Statica
                 .Where(e => e.Label!.Equals(label))
                 .Select(e => e.Id)
                 .FirstOrDefaultAsync();
            return ID;
        }
        public async Task<int> GetStaticasByTypeCC081PorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpCc081Cd
                .Where(e => e.IsActive == true)
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasSimNao(string label)
        {
            int ID = await _appDbContext.E9ACSICP_Statica
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeBB008_TPPorLabel(string label)
        {

            int ID = await _appDbContext.OsusrE9aCsicpBb008Tipos
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeBB01201_con_PorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpBb01201Cons
                 .Where(e => e.Label!.Equals(label))
                 .Select(e => e.Id)
                 .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypebb062_staPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpBb062Sta
                 .Where(e => e.Label!.Equals(label))
                 .Select(e => e.Id)
                 .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeGG030Sta(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg030Sta
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }



        public async Task<int> GetIDStaticasByTypeGG023ValPorLabel(string Label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg023Vals
                .Where(e => e.Label!.Equals(Label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeGG030StaPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg030Sta
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeGG019CgBar(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg019Cgbars
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeGG045StatusPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg045Stats
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeGG046SaidaPorLabel(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpGg046Stats
                .Where(e => e.Label!.Equals(label))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> GetIDStaticasByTypeGG001TAlmox(string label)
        {
            int ID = await _appDbContext.CSICP_GG001Talmoxes
                          .Where(e => e.Label!.Equals(label))
                          .Select(e => e.Id)
                          .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> csicp_bb012_GruCta(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpBb012Gructa
                        .Where(e => e.Label!.Equals(label))
                        .Select(e => e.Id)
                        .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> csicp_ff120_trackApi(string label)
        {
              int ID = await _appDbContext.OsusrE9aCsicpFf120Trackapis
                          .Where(e => e.Label!.Equals(label))
                          .Select(e => e.Id)
                          .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> csicp_ff112_cnab(string label)
        {
              int ID = await _appDbContext.OsusrE9aCsicpFf112Cnabs
                          .Where(e => e.Label!.Equals(label))
                          .Select(e => e.Id)
                          .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> csicp_ff112_C026(string label)
        {
              int ID = await _appDbContext.OsusrE9aCsicpFf112C026s
                          .Where(e => e.Label!.Equals(label))
                          .Select(e => e.Id)
                          .FirstOrDefaultAsync();
            return ID;
        }

        public async Task<int> csicp_ff112_G028(string label)
        {
            int ID = await _appDbContext.OsusrE9aCsicpFf112G028s
                          .Where(e => e.Label!.Equals(label))
                          .Select(e => e.Id)
                          .FirstOrDefaultAsync();
            return ID;
        }
    }
}