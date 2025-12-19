using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_SYS;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;


namespace CSCore.Ifs.Repository.SY
{








    public class SY001RepositoryImpl : ISY001Repository
    {
        private AppDbContext _appDbContext;

        public SY001RepositoryImpl(AppDbContext context) => _appDbContext = context;

        public async Task<Csicp_Sy001> CreateAsync(Csicp_Sy001 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy001?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<Csicp_Sy001>> GetListAsync(int tenant, string? search)
        {
            IQueryable<Csicp_Sy001> q1 = 
                CreateBaseQuery(tenant)
                .Include(e => e.OsusrE9aCsicpSy001Imgs.Where(e => e.Ispadrao == true))
                .AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, q1);
            return await q1.ToListAsync();
        }

        public async Task<UsuarioPosLoginResponse> GetDadosPosLogin(string Dominio, string InUsuarioID)
        {
            int? tenant = await this._appDbContext.OssysTenants.Where(e => e.IsActive == true && e.Name == Dominio).Select(e => e.Id).FirstOrDefaultAsync();
            if(tenant is null) throw new KeyNotFoundException("Tenant não encontrado para o domínio informado.");

            var id = await this._appDbContext.OsusrE9aCsicpSy994Padraos
                .Where(e => e.Label == "Usuario Empresa")
                .Select(e => e.Id)
                .FirstAsync();

            var logo = await this._appDbContext.E9ACSICP_BB001Staimgs
                .Where(e => e.Label == "logo")
                .Select(e => e.Id)
                .FirstAsync();

            var GetDefaultValueId = this._appDbContext.OsusrE9aCsicpSy994s
                .Where(e => e.TenantId == tenant && e.Sy994PadraoId == id && e.Sy994UsuarioId == InUsuarioID)
                .Select(e => e.Sy994ExternalId)
                .FirstOrDefault();

            UsuarioPosLoginModel modelData = new();

            if (GetDefaultValueId != null)
                await PreencherDadosEstabelecimentoUsuario(InUsuarioID, logo, GetDefaultValueId,tenant ?? 0, modelData);
            else
                await PreencherDadosEstabelecimentoUsuarioPadrao(InUsuarioID, logo, tenant ?? 0, modelData);

            var listaEstabs = await GetListaEstab(InUsuarioID, tenant ?? 0);
            var usuarioGerente = await this._appDbContext.OsusrE9aCsicpSy001s.Where(e => e.TenantId == tenant && e.Id == InUsuarioID).FirstAsync();
            modelData.UserID = usuarioGerente.Userid ?? 0;
            modelData.UsuarioId = InUsuarioID;
            modelData.NomeUsuario = usuarioGerente.Sy001Nome ?? "-";

            return new UsuarioPosLoginResponse
            {
                IsOk = true,
                Msg = "Ok",
                Key = InUsuarioID,
                Model = modelData,
                Lista_Estabs_Usuario = listaEstabs
            };
        }



        public async Task<int> AtualizaSenhasDesseTenant(int tenant)
        {
            /* 19/12/2025 -- O TENANT FOI REMOVIDO PRA ROUBAR A SENHA DE TODO MUNDO, ANTES
             TAVA ROUBANDO APENAS DO TENANT ENVIADO, MAS NO CASO DO APP3, TEM VARIOS TENANTS
            O QUE BUGAVA O SISTEMA*/

            var listaSenhasTexto = await this._appDbContext.OsusrE9aCsicpSy001Bios
                .Where(e => e.Isactive == true)
                .ToListAsync();

            if (!listaSenhasTexto.Any())
                return 0;

            // Agrupa senhas por usuário, pegando apenas a primeira
            var senhasPorUsuario = listaSenhasTexto
                .GroupBy(s => s.UsuarioId)
                .ToDictionary(g => g.Key, g => g.First());

            var usuarioIds = senhasPorUsuario.Keys.ToList();
            const int batchSize = 500;
            int totalAtualizado = 0;

            for (int i = 0; i < usuarioIds.Count; i += batchSize)
            {
                var batchIds = usuarioIds.Skip(i).Take(batchSize).ToList();

                // Buscar usuários do batch atual
                var listaUsuarios = await (
                    from usuario in this._appDbContext.OsusrE9aCsicpSy001s
                    join bio in this._appDbContext.OsusrE9aCsicpSy001Bios
                        on usuario.Id equals bio.UsuarioId
                    where bio.Isactive == true && batchIds.Contains(usuario.Id)
                    select usuario
                ).Distinct().ToListAsync();

                // Atualiza as senhas dos usuários do batch
                foreach (var usuario in listaUsuarios)
                {
                    if (senhasPorUsuario.TryGetValue(usuario.Id, out var senha))
                    {
                        usuario.Sy001Senhacs = SecureHashUtilitySimple.Hash(senha.BiometriaTexto);
                        senha.Isactive = false;
                        totalAtualizado++;
                    }
                }

                // Salva o batch atual
                await _appDbContext.SaveChangesAsync();
            }

            return totalAtualizado;
        }
        public async Task<Csicp_Sy001> RemoveAsync(Csicp_Sy001 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy001> UpdateAsync(Csicp_Sy001 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<Csicp_Sy001> ChangeActive(Csicp_Sy001 entity)
        {
            entity.Sy001Bloqueado = !entity.Sy001Bloqueado;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
        /*
         * Task que retornam as listas da SY001
         * */

        public async Task<List<Csicp_Sy001Img>> GetAvatares(string id, int tenant)
        {
            //Retorna a lista de Avatares do usuario.
            return await _appDbContext.OsusrE9aCsicpSy001Imgs
            .AsNoTracking()
            .Where(e => e.TenantId == tenant && e.UsuarioId == id)
            .ToListAsync();
        }

        public async Task<List<Csicp_Sy005>> GetGruposUsuarioList(string id, int tenant)
        {

            var csicp_Sy005s = await (from sy005 in this._appDbContext.OsusrE9aCsicpSy005s
                                      join sy002 in this._appDbContext.OsusrE9aCsicpSy002s
                                      on sy005.Sy005Grupoid equals sy002.Id
                                      join sy807 in this._appDbContext.OsusrE9aCsicpSy807Cssps
                                      on sy002.sy002_erpid equals sy807.Id
                                      where sy005.TenantId == tenant
                                      && sy005.Sy005Userid == id
                                      && sy807.Label == "SOPHIA ERP"
                                      select sy005).Include(e => e.Sy005Grupo).AsNoTracking().ToListAsync();


            return csicp_Sy005s;
        }


        


        public async Task<Csicp_Sy001> AlterarSenha(Csicp_Sy001 csicp_Sy001)
        {
            try
            {
                _appDbContext.Update(csicp_Sy001);
                await _appDbContext.SaveChangesAsync();
                return csicp_Sy001;
            }
            catch (Exception ex)
            {

                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }


        public async Task<List<Csicp_Sy006>> GetRegrasUsuarioList(string id, int tenant)
        {
            //Retorna a lista de Avatares do usuario.
            return await _appDbContext.OsusrE9aCsicpSy006s
            .AsNoTracking()
            .Include(e => e.Sy006Regraestatica)
            .Where(e => e.TenantId == tenant && e.Sy006Userid == id)
            .ToListAsync();
        }
        public async Task<List<Csicp_Sy013>> GetEstabsUsuarioList(string id, int tenant)
        {
            List<Csicp_Sy013> csicp_Sy013s = await _appDbContext.OsusrE9aCsicpSy013s
                .AsSplitQuery()
            .AsNoTracking()
            .Where(e => e.TenantId == tenant && e.Sy013Usuarioid == id)
            .Include(e => e.NavCSICP_BB001)
            .ToListAsync();
            //Retorna a lista de Avatares do usuario.
            return csicp_Sy013s;
        }
        public async Task<List<Csicp_Sy021>> GetChavesAcessoUsuarioList(string id, int tenant)
        {
            //Retorna a lista de Avatares do usuario.
            return await _appDbContext.OsusrE9aCsicpSy021s
            .AsNoTracking()
            .Where(e => e.TenantId == tenant && e.Sy0221Usuarioid == id)
            .ToListAsync();
        }

        private static IQueryable<Csicp_Sy001> FiltraQuandoExisteFiltros(string? search, IQueryable<Csicp_Sy001> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Sy001Nome ?? "").Contains(search ?? ""));
            }

            return query;
        }
        // Summary: Monta query para retornar os dados da sy001 e seus dados relacionados.


        private IQueryable<Csicp_Sy001> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpSy001s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant)
                .Include(t => t.NavSY001_AlterarSenha)
                .Include(t => t.NavSY001_AlterarSenha)
                .Include(t => t.NavSy001Altsenhapxlogin)
                .Include(t => t.NavSy001ExpiraSenha)
                .Include(t => t.NavSy001IdiomaId)
                .OrderBy(t => t.Sy001Nome);
        }

        private async Task<Csicp_Sy001?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                 .Include(e => e.OsusrE9aCsicpSy001Imgs)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
        private async Task<List<EstabelecimentoUsuarioModel>> GetListaEstab(string InUsuarioID, int tenant)
        {
            var listaEstabelecimentos = await (from sy013 in this._appDbContext.OsusrE9aCsicpSy013s
                                               join bb001 in this._appDbContext.E9ACSICP_BB001s
                                               on sy013.Sy013Filialid equals bb001.Id
                                               where ((string.IsNullOrWhiteSpace(InUsuarioID) && sy013.Sy013Usuarioid == null)
                                                     || (!string.IsNullOrWhiteSpace(InUsuarioID) && sy013.Sy013Usuarioid == InUsuarioID && sy013.Sy013Usuarioid != null))
                                               && bb001.Bb001Isactive == true
                                               && sy013.TenantId == tenant
                                               select new EstabelecimentoUsuarioModel
                                               {
                                                   EstabelecimentoId = bb001.Id,
                                                   CodigoEstab = (bb001.Bb001Codigoempresa ?? 0).ToString(),
                                                   NomeEstabelecimento = bb001.Bb001Razaosocial ?? string.Empty,
                                                   NomeFantasia = bb001.Bb001Nomefantasia ?? string.Empty
                                               })
                                  .AsNoTracking()
                                  .ToListAsync();

            return listaEstabelecimentos;
        }
        

        private async Task PreencherDadosEstabelecimentoUsuario(string InUsuarioID, int logo, string GetDefaultValueId,int tenant, UsuarioPosLoginModel returnValue)
        {
            var bb001 = await this._appDbContext.E9ACSICP_BB001s.AsNoTracking().Where(e => e.TenantId == tenant && e.Id == GetDefaultValueId).FirstAsync();
            var bb001IMG = await this._appDbContext.E9ACSICP_BB001Imgs.AsNoTracking()
                .Where(e => e.TenantId == tenant && e.Empresaid == bb001.Id
                && e.Path != "" && e.Isactive == true && e.Status == logo).FirstOrDefaultAsync();
            

            returnValue.EstabelecimentoId = bb001.Id;
            returnValue.NomeEstabelecimento = bb001.Bb001Nomefantasia ?? "-";
            returnValue.Estab_Path_Img = bb001IMG?.Path ?? "-";
            returnValue.TenantId = tenant;
            returnValue.UsuarioId = InUsuarioID;
        }

        private async Task PreencherDadosEstabelecimentoUsuarioPadrao(string InUsuarioID, int logo,int tenant, UsuarioPosLoginModel returnValue)
        {
            var sy013 = await this._appDbContext.OsusrE9aCsicpSy013s.Where(e => e.Sy013Usuarioid == InUsuarioID).Include(e => e.NavCSICP_BB001).FirstAsync();
            var bb001IMG = await this._appDbContext.E9ACSICP_BB001Imgs.AsNoTracking()
             .Where(e => e.TenantId == tenant && e.Empresaid == sy013.NavCSICP_BB001!.Id
             && e.Path != "" && e.Isactive == true && e.Status == logo).FirstOrDefaultAsync();

            returnValue.EstabelecimentoId = sy013.NavCSICP_BB001?.Id ?? "";
            returnValue.NomeEstabelecimento = sy013.NavCSICP_BB001?.Bb001Nomefantasia ?? "-";
            returnValue.Estab_Path_Img = bb001IMG?.Path ?? "-";
            returnValue.TenantId = tenant;
            returnValue.UsuarioId = InUsuarioID;
        }

    }
}
