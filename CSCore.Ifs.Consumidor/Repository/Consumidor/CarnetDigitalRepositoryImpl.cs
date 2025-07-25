using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.Consumidor;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.Consumidor
{
    public enum EnumTipoRegistro
    {
        CONTAS_RECEBER = 1,
        CARTAO_CREDITO = 2,
        CONTAS_A_PAGAR = 3
    }
    public class CarnetDigitalRepositoryImpl(AppDbContext appDbContext) : ICarnetDigitalRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public Task Gera_Pix_Titulo(string bb012_contaID)
        {
            throw new NotImplementedException();
        }



        public async Task<List<CSICP_DD143Stum>> ConsultaStatus()
        {
            List<CSICP_DD143Stum> listaStatus
                = await _appDbContext.OsusrTeiCsicpDd143Sta.Where(e => e.IsActive == true).ToListAsync();

            return listaStatus;
        }

        public async Task<CSICP_BB001Img?> GetLogoEmpresa(string BB001_ID, int tenant)
        {
            CSICP_BB001Staimg? cSICP_BB001Staimg = await _appDbContext.E9ACSICP_BB001Staimgs.Where(e => e.Label!.Equals("Logo"))
                .FirstOrDefaultAsync();
            CSICP_BB001? cSICP_BB001 = await _appDbContext.E9ACSICP_BB001s
                .FirstOrDefaultAsync(e => e.Id == BB001_ID && e.TenantId == tenant);

            if (cSICP_BB001 is null) throw new KeyNotFoundException("Empresa não encontrada no sistema!");
            if (cSICP_BB001Staimg is null) throw new KeyNotFoundException("cSICP_BB001Staimg não encontrada no sistema!");

            CSICP_BB001Img? cSICP_BB001Img = cSICP_BB001.OsusrE9aCsicpBb001Imgs.Where(e => e.Status == cSICP_BB001Staimg.Id)
                .FirstOrDefault();
            return cSICP_BB001Img;
        }

        public async Task<(IEnumerable<CSICP_FF102>, int count)> ListadeTituloByConta_ID(
            int tenantId,
            string bb012_contaID,
            int situacaoTitulo,
            int diasAteDataVencimento,
            int pageSize,
            int pageNumber)
        {
            List<int> listaIDSituacao = await ObterListaSituacaoTitulo(situacaoTitulo);
            IQueryable<CSICP_FF102> query
                = ObterConsultaTitulo(tenantId, bb012_contaID, diasAteDataVencimento, listaIDSituacao);

            var queryCount = query;
            int count = queryCount.Count();

            query = query.PaginacaoNoBanco(pageNumber, pageSize);
            List<CSICP_FF102> listaExtendidaFF102 = await query.ToListAsync();

            return (listaExtendidaFF102, count);
        }


        public async Task<CSICP_FF102> TituloByConta_ID(int tenantId, string bb012_contaID, string tituloID,
            int situacaoTitulo, int diasAteDataVencimento)
        {
            List<int> listaIDSituacao = await ObterListaSituacaoTitulo(situacaoTitulo);
            IQueryable<CSICP_FF102> query
               = ObterConsultaTitulo(tenantId, bb012_contaID, diasAteDataVencimento, listaIDSituacao);
            query = query.Where(e => e.Id == tituloID);

            CSICP_FF102? tituloEncontrado = await query.FirstOrDefaultAsync();
            if (tituloEncontrado is null) throw new KeyNotFoundException("Título não encontrado no sistema!");
            return tituloEncontrado;
        }

        private async Task<List<int>> ObterListaSituacaoTitulo(int situacaoTitulo)
        {
            var listaSitTitulo = new List<int?>();

            if (situacaoTitulo == 1)
            {
                listaSitTitulo.Add(1);
                listaSitTitulo.Add(2);
            }

            if (situacaoTitulo == 2) listaSitTitulo.Add(3);

            if (situacaoTitulo == 9)
            {
                listaSitTitulo.Add(1);
                listaSitTitulo.Add(2);
                listaSitTitulo.Add(3);
            }


            List<int> listaIDSituacao = await _appDbContext
                .OsusrE9aCsicpFf102Sits
                .Where(e => e.IsActive == true)
                .Where(e => listaSitTitulo.Contains(e.Codgcs))
                .Select(e => e.Id)
                .ToListAsync() ?? throw new KeyNotFoundException();
            return listaIDSituacao;
        }


        private IQueryable<CSICP_FF102> ObterConsultaTitulo(int tenantId, string bb012_contaID, int diasAteDataVencimento, List<int> listaIDSituacao)
        {
            return from ff102 in _appDbContext.OsusrE9aCsicpFf102s

                   join ff102Sit in _appDbContext.OsusrE9aCsicpFf102Sits
                   on ff102.Ff102Situacaoid equals ff102Sit.Id

                   join _ff000 in _appDbContext.OsusrE9aCsicpFf000s
                   on ff102.Ff102Filialid equals _ff000.Ff000EstabId into _ff000Group
                   from _ff000 in _ff000Group.DefaultIfEmpty()

                   join _ff000BaseCalc in _appDbContext.OsusrE9aCsicpFf000Basecalcs
                   on _ff000.Ff000BasecalcId equals _ff000BaseCalc.Id into _ff000BaseCalcGroup
                   from _ff000BaseCalc in _ff000BaseCalcGroup.DefaultIfEmpty()

                   join _bb012 in _appDbContext.OsusrE9aCsicpBb012s
                    on ff102.Ff102Contaid equals _bb012.Id into _bb012Join
                   from _bb012 in _bb012Join.DefaultIfEmpty()


                   where ff102.TenantId == tenantId
                   where ff102.Ff102Contaid == bb012_contaID
                   where ff102.Ff102Tiporegistro == 1
                   where listaIDSituacao.Contains(ff102.Ff102Situacaoid)

                   where ff102.Ff102DataVencimento <= DateTime.UtcNow &&
                   ff102.Ff102DataVencimento >= DateTime.UtcNow.AddDays(-diasAteDataVencimento)

                   select new CSICP_FF102
                   {
                       Id = ff102.Id,
                       Ff102Pfx = ff102.Ff102Pfx,
                       Ff102NoTitulo = ff102.Ff102NoTitulo,
                       Ff102Sfx = ff102.Ff102Sfx,
                       Ff102DataEmissao = ff102.Ff102DataEmissao,
                       Ff102DataVencimento = ff102.Ff102DataVencimento,
                       Ff102VlLiqTitulo = ff102.Ff102VlLiqTitulo,
                       Ff102PercCorrmonetaria = ff102.Ff102PercCorrmonetaria,
                       Ff102PercHonorarios = ff102.Ff102PercHonorarios,
                       Ff102PercJurosAtr = ff102.Ff102PercJurosAtr,
                       Ff102PercMulta = ff102.Ff102PercMulta,
                       Ff102Nodiasliberacao = ff102.Ff102Nodiasliberacao,
                       Ff102PixcobQrcode = ff102.Ff102PixcobQrcode,
                       Ff102Linhadigital = ff102.Ff102Linhadigital,

                       NavFF102Sit = new CSICP_FF102Sit
                       {
                           Label = ff102Sit.Label
                       },
                       NavFF000 = new CSICP_FF000
                       {
                           Ff000PercMulta = _ff000.Ff000PercMulta,
                           Ff000Diascarmulta = _ff000.Ff000Diascarmulta,
                           Ff000Diascarjuros = _ff000.Ff000Diascarjuros,
                           Ff000PercCorrmonetaria = _ff000.Ff000PercCorrmonetaria,
                           Ff000PercHonorarios = _ff000.Ff000PercHonorarios,
                           Ff000PercJuros = _ff000.Ff000PercJuros,
                           NavFF000BaseCalculo = new CSICP_FF000Basecalc
                           {
                               Label = _ff000BaseCalc.Label,
                               Order = _ff000BaseCalc.Order
                           }
                       },
                       NavBB012 = new CSICP_BB012
                       {
                           Bb012NomeCliente = _bb012.Bb012NomeCliente,
                           Bb012NomeFantasia = _bb012.Bb012NomeFantasia,
                       }
                   };
        }

    }
}
