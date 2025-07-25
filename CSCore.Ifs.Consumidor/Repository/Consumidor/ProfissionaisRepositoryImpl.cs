using CSCore.Domain;
using CSCore.Domain.Interfaces.Consumidor;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.Consumidor
{
    public class ProfissionaisRepositoryImpl : IProfissionaisRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProfissionaisRepositoryImpl(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<CSICP_Bb055>> Get_ListadeProfissionais(int tenant, string? search, int page, int pageSize)
        {
            IQueryable<CSICP_Bb055> queryBase = criaQueryBaseBB055(tenant);

            if (!string.IsNullOrWhiteSpace(search))
            {
                queryBase = queryBase.Where(e =>
                    (e.Bb055Nome != null && e.Bb055Nome.Contains(search)) ||
                    (e.Bb055Tags != null && e.Bb055Tags.Contains(search))
                );
            }

            queryBase = queryBase.PaginacaoNoBanco(page, pageSize);
            queryBase = queryBase.OrderBy(e => e.Bb055Id);

            return await queryBase.ToListAsync();

        }

        public async Task<IEnumerable<CSICP_Bb056>> Get_ListadeProfissionaisAvaliacao(
            int tenant,
            string profissionalID)
        {
            IQueryable<CSICP_Bb056> queryBase = _appDbContext.OsusrE9aCsicpBb056s
                .Include(e => e.NavBB012)
                .Where(e => e.TenantId == tenant)
                .Where(e => e.Bb056Profid == profissionalID)
                .Where(e => e.Bb056Isactive == true)
                .AsSplitQuery();

            return await queryBase.ToListAsync();

        }

        public async Task PostRegistraClickProfissional(CSICP_Bb057 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task Post_AplicarAvaliacao(CSICP_Bb056 entity)
        {
            entity.Bb056Isactive = true;
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task Post_RegistraProfissional(CSICP_Bb055 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
        }

        private IQueryable<CSICP_Bb055> criaQueryBaseBB055(int tenant)
        {
            return from _CSICP_BB055 in _appDbContext.OsusrE9aCsicpBb055s
                   where _CSICP_BB055.TenantId == tenant
                   where _CSICP_BB055.Bb055IsActive == true

                   join _CSICP_AA027 in _appDbContext.OsusrE9aCsicpAa027s
                   on _CSICP_BB055.Bb055UfId equals _CSICP_AA027.Id into joined_aa027
                   from _CSICP_AA027 in joined_aa027.DefaultIfEmpty()

                   join _CSICP_AA028 in _appDbContext.OsusrE9aCsicpAa028s
                   on _CSICP_BB055.Bb055Cidadeid equals _CSICP_AA028.Id into joined_aa028
                   from _CSICP_AA028 in joined_aa028.DefaultIfEmpty()

                   select new CSICP_Bb055
                   {

                       TenantId = _CSICP_BB055.TenantId,
                       Bb055Id = _CSICP_BB055.Bb055Id,
                       Bb055Nome = _CSICP_BB055.Bb055Nome,
                       Bb055Email = _CSICP_BB055.Bb055Email,
                       Bb055Telefone = _CSICP_BB055.Bb055Telefone,
                       Bb055IsActive = _CSICP_BB055.Bb055IsActive,
                       Bb055Logradouro = _CSICP_BB055.Bb055Logradouro,
                       Bb055Numero = _CSICP_BB055.Bb055Numero,
                       Bb055Complemento = _CSICP_BB055.Bb055Complemento,
                       Bb055Perimetro = _CSICP_BB055.Bb055Perimetro,
                       Bb055Bairro = _CSICP_BB055.Bb055Bairro,
                       Bb055Cidadeid = _CSICP_BB055.Bb055Cidadeid,
                       Bb055UfId = _CSICP_BB055.Bb055UfId,
                       Bb055Cep = _CSICP_BB055.Bb055Cep,
                       Bb055Paisid = _CSICP_BB055.Bb055Paisid,
                       Bb055Nomecontato = _CSICP_BB055.Bb055Nomecontato,
                       Bb055CelularContato = _CSICP_BB055.Bb055CelularContato,
                       Bb055EmailContato = _CSICP_BB055.Bb055EmailContato,
                       Bb055UrlLogo = _CSICP_BB055.Bb055UrlLogo,
                       Bb055UrlAvatar = _CSICP_BB055.Bb055UrlAvatar,
                       Bb055Desespecialidade = _CSICP_BB055.Bb055Desespecialidade,
                       Bb055UrlSeloqld = _CSICP_BB055.Bb055UrlSeloqld,
                       Bb055Ratemedia = _CSICP_BB055.Bb055Ratemedia,
                       Bb055Tags = _CSICP_BB055.Bb055Tags,
                       Nav_CSICP_AA027 = _CSICP_AA027 != null ? new CSICP_Aa027
                       {
                           TenantId = _CSICP_AA027.TenantId,
                           Id = _CSICP_AA027.Id,
                           Aa027Sigla = _CSICP_AA027.Aa027Sigla,
                           Descricao = _CSICP_AA027.Descricao,
                           Aa027Percicmscontrib = _CSICP_AA027.Aa027Percicmscontrib,
                           Aa027Percicmsncontrib = _CSICP_AA027.Aa027Percicmsncontrib,
                           Aa027Percsubsttribut = _CSICP_AA027.Aa027Percsubsttribut,
                           Aa027Mascinsestadual = _CSICP_AA027.Aa027Mascinsestadual,
                           Aa027Percicmsentrada = _CSICP_AA027.Aa027Percicmsentrada,
                           Aa027Mascieimpressao = _CSICP_AA027.Aa027Mascieimpressao,
                           Aa027Codigoibge = _CSICP_AA027.Aa027Codigoibge,
                           Paisid = _CSICP_AA027.Paisid,
                           Regiaoid = _CSICP_AA027.Regiaoid,
                           Aa027Naturalidade = _CSICP_AA027.Aa027Naturalidade,
                           Aa027ExportUfid = _CSICP_AA027.Aa027ExportUfid,
                           Aa025ExportPaisid = _CSICP_AA027.Aa025ExportPaisid,
                           Aa026ExportRegiaoid = _CSICP_AA027.Aa026ExportRegiaoid,
                       } : null,
                       Nav_CSICP_AA028 = _CSICP_AA028 != null ? new CSICP_Aa028
                       {
                           TenantId = _CSICP_AA028.TenantId,
                           Id = _CSICP_AA028.Id,
                           Aa028Cidade = _CSICP_AA028.Aa028Cidade,
                           Aa028Percicmscontrib = _CSICP_AA028.Aa028Percicmscontrib,
                           A028Percicmsncontrib = _CSICP_AA028.A028Percicmsncontrib,
                           A028Percsubsttribut = _CSICP_AA028.A028Percsubsttribut,
                           A028Mascinsestadual = _CSICP_AA028.A028Mascinsestadual,
                           A028Percicmsentrada = _CSICP_AA028.A028Percicmsentrada,
                           A028Mascieimpressao = _CSICP_AA028.A028Mascieimpressao,
                           Aa028Codgibge = _CSICP_AA028.Aa028Codgibge,
                           Aa028Zonafranca = _CSICP_AA028.Aa028Zonafranca,
                           Aa028Estadobrasil = _CSICP_AA028.Aa028Estadobrasil,
                           Ufid = _CSICP_AA028.Ufid,
                           Aa028ExportCidadeid = _CSICP_AA028.Aa028ExportCidadeid,
                           Aa027ExportUfid = _CSICP_AA028.Aa027ExportUfid,
                       } : null,
                   };
        }
    }
}

