using CSCore.Application.Dto;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.EstaticasLabel.GG;
using CSCore.Domain.Interfaces.GG._07X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.Baixa;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._07X
{

    public class GG073RepositoryImpl(AppDbContext appDbContext, IBaixarEstoqueMovtEntSaida baixaEstoque)
        : RepositorioBaseImpl<CSICP_GG073>(appDbContext, "Gg073Id"), IGG073Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly IBaixarEstoqueMovtEntSaida _baixaEstoque = baixaEstoque;



        public async Task<CSICP_GG073?> GetByIdAsync(string id, int tenant)
        {
            IQueryable<CSICP_GG073> query = CriaQueryBase(tenant);
            query = query.Where(e => e.Gg073Id == id);

            CSICP_GG073? csicpGg030Entity = await query.FirstOrDefaultAsync();
            if (csicpGg030Entity is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);



            return csicpGg030Entity;
        }


        public async Task UpdateGG073StatusId(CSICP_GG073 entidadeParaAtualizar, int gg073Status_id_fechado)
        {
            _appDbContext.Attach(entidadeParaAtualizar);
            entidadeParaAtualizar.Gg073Statusid = gg073Status_id_fechado;
            _appDbContext.Entry(entidadeParaAtualizar).Property(e => e.Gg073Statusid).IsModified = true;


        }

        public async Task<(IEnumerable<CSICP_GG073>, int)> GetListAsync(int tenant, int pageSize, int page,
            string? Protocolo, string? BB001_EstabID, DateTime DataInicial, DateTime DataFinal, string? BB005_CentroCustoID,
            string? GG001_AlmoxID, int? GG073_StatusID, int? GG073_TMov_ID)
        {
            IQueryable<CSICP_GG073> query = CriaQueryBase(tenant);

            query = FiltrosNecessariosEntidade(query, Protocolo, BB001_EstabID, DataInicial, DataFinal, BB005_CentroCustoID,
                GG001_AlmoxID, GG073_StatusID, GG073_TMov_ID);

            query = query.OrderByDescending(e => e.Gg073DataMovimento).ThenBy(e => e.Gg073Protocolonro);
            query = query.PaginacaoNoBanco(page, pageSize);

            int count = query.GetCountTotal();

            List<CSICP_GG073> listaCSICP_GG073 = await query.ToListAsync();
            return (listaCSICP_GG073, count);
        }


        public async Task BaixaEstoque(string GG073_ID, int tenant, string in_usuarioID)
        {
            CSICP_GG073? gg073_encontrada = await GetByIdAsync(GG073_ID, tenant);

            if (gg073_encontrada is null) throw new KeyNotFoundException("Movimento não encontrado");

            int idGG073Status_Aberto = await _appDbContext.OsusrE9aCsicpGg073Stats
             .Where(e => e.Label != null && e.Label.Equals("Aberto"))
             .Select(e => e.Id).FirstOrDefaultAsync();

            if (gg073_encontrada.Gg073Statusid != idGG073Status_Aberto)
                throw new Exception("Movimento precisa estar aberto");


            int idEstaticaSIM = await _appDbContext.E9ACSICP_Statica
                .Where(e => e.Label != null && e.Label.Equals("Sim")).Select(e => e.Id).FirstOrDefaultAsync();

            int idGG072StqAberto = await _appDbContext.OsusrE9aCsicpGg072Stqs
                .Where(e => e.Label != null && e.Label.Equals(Entities.GG072Stq.Aberto.ToString())).Select(e => e.Id).FirstOrDefaultAsync();

            int idGG072StqErro = await _appDbContext.OsusrE9aCsicpGg072Stqs
                .Where(e => e.Label != null && e.Label.Equals(Entities.GG072Stq.Erro.ToString())).Select(e => e.Id).FirstOrDefaultAsync();

            int idGG072StqBaixado = await _appDbContext.OsusrE9aCsicpGg072Stqs
              .Where(e => e.Label != null && e.Label.Equals(Entities.GG072Stq.Baixado.ToString())).Select(e => e.Id).FirstOrDefaultAsync();

            int idGG072StqInvetario = await _appDbContext.OsusrE9aCsicpGg072Stqs
                .Where(e => e.Label != null && e.Label.Equals(Entities.GG072Stq.Inventario.ToString()))
                .Select(e => e.Id).FirstOrDefaultAsync();

            int idGG072StqSemSaldo = await _appDbContext.OsusrE9aCsicpGg072Stqs
                .Where(e => e.Label != null && e.Label.Equals(Entities.GG072Stq.SemSaldo.ToString()))
                .Select(e => e.Id).FirstOrDefaultAsync();

            int idGG028TMovEntrada = await _appDbContext.OsusrE9aCsicpGg028Entsais
                .Where(e => e.Label != null && e.Label.Equals(Entities.GG028EntSaida.Entrada.ToString()))
                .Select(e => e.Id).FirstOrDefaultAsync();

            int idGG028TMovSaida = await _appDbContext.OsusrE9aCsicpGg028Entsais
                .Where(e => e.Label != null && e.Label.Equals(Entities.GG028EntSaida.Saida.ToString()))
                .Select(e => e.Id).FirstOrDefaultAsync();


            int idGG073Status_Fechado = await _appDbContext.OsusrE9aCsicpGg073Stats
               .Where(e => e.Label != null && e.Label.Equals("Fechado"))
               .Select(e => e.Id).FirstOrDefaultAsync();



            int idGG073Status_Erro = await _appDbContext.OsusrE9aCsicpGg073Stats
              .Where(e => e.Label != null && e.Label.Equals("Erro"))
              .Select(e => e.Id).FirstOrDefaultAsync();

            int idGG073EntSaida_Saida = await _appDbContext.OsusrE9aCsicpGg073Tmovs
              .Where(e => e.Label != null && e.Label.Equals("Saída"))
              .Select(e => e.Id).FirstOrDefaultAsync();


            int idGG028Nat = await _appDbContext.OsusrE9aCsicpGg028Nats
                .Where(e => e.Label.Equals(Entities.GG028Nat.Estoque_1_22))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();

            ParametrosBaixaSaldo parametrosBaixaEstoque = new()
            {
                GG073_ID = gg073_encontrada.Gg073Id,
                BB001_ID = gg073_encontrada.Gg073Estabid,
                Movimento_DataMovimento = gg073_encontrada.Gg073DataMovimento,
                StID_IdGG072StqAberto = idGG072StqAberto,
                StID_IdGG072StqErro = idGG072StqErro,
                StID_IdGG072StqInvetario = idGG072StqInvetario,
                StID_IdGG072StqSemSaldo = idGG072StqSemSaldo,
                StID_GG028_EntSaida_Entrada_ID = idGG028TMovEntrada,
                StID_GG028_EntSaida_Saida_ID = idGG028TMovSaida,
                StID_Estatica_SIM_Id = idEstaticaSIM,
                Header_Movimento_ID = gg073_encontrada.Gg073Id,
                UsuarioID = gg073_encontrada.Gg073Usuarioid,
                ContaID = null,
                TransacaoID = null,
                ProgramaOrigem = "GG073",
                NumeroPDV = 0,
                Protocolo_Documento = gg073_encontrada.Gg073Protocolonro,
                NF_ou_CUPOM = 0,
                StID_GG028_Nat_ID = idGG028Nat,
                StID_IdGG073Status_Erro = idGG073Status_Erro,
                StID_IdGG073Status_Fechado = idGG073Status_Fechado,
                StID_GG073_EntSaida_Saida_ID = idGG073EntSaida_Saida,
                StID_IdGG073Status_Aberto = idGG073Status_Aberto,
                GG073Corrente = gg073_encontrada
            };
            await _baixaEstoque.CS001_Baixa_Movto_ENTSAI(parametrosBaixaEstoque, tenant, in_usuarioID);


        }



        private IQueryable<CSICP_GG073> CriaQueryBase(int tenant)
        {
            IQueryable<CSICP_GG073> query = from _CSICP_GG073 in _appDbContext.OsusrE9aCsicpGg073s
                                            where _CSICP_GG073.TenantId == tenant

                                            join _gg001Almoxmovd in _appDbContext.CSICP_GG001s
                                            on _CSICP_GG073.Gg073Almoxmovd equals _gg001Almoxmovd.Id into _gg001AlmoxmovdJoin
                                            from _gg001Almoxmovd in _gg001AlmoxmovdJoin.DefaultIfEmpty()

                                            join _gg001AlmoxmovdSaida in _appDbContext.CSICP_GG001s
                                            on _CSICP_GG073.Gg073Almoxmovsaida equals _gg001AlmoxmovdSaida.Id into _gg001AlmoxmovdSaidaJoin
                                            from _gg001AlmoxmovdSaida in _gg001AlmoxmovdSaidaJoin.DefaultIfEmpty()

                                            join _gg073Status in _appDbContext.OsusrE9aCsicpGg073Stats
                                            on _CSICP_GG073.Gg073Statusid equals _gg073Status.Id into _gg073StatusJoin
                                            from _gg073Status in _gg073StatusJoin.DefaultIfEmpty()

                                            join _gg073Tmov in _appDbContext.OsusrE9aCsicpGg073Tmovs
                                            on _CSICP_GG073.Gg073Tmovid equals _gg073Tmov.Id into _gg073TmovJoin
                                            from _gg073Tmov in _gg073TmovJoin.DefaultIfEmpty()

                                            join _gg073Valorizarpor in _appDbContext.OsusrE9aCsicpGg023Vals
                                            on _CSICP_GG073.Gg073Valorizarporid equals _gg073Valorizarpor.Id into _gg073ValorizarporJoin
                                            from _gg073Valorizarpor in _gg073ValorizarporJoin.DefaultIfEmpty()

                                            join _navSy001 in _appDbContext.OsusrE9aCsicpSy001s
                                            on _CSICP_GG073.Gg073Usuarioid equals _navSy001.Id into _navSy001Join
                                            from _navSy001 in _navSy001Join.DefaultIfEmpty()

                                            join _navBB005 in _appDbContext.OsusrE9aCsicpBb005s
                                            on _CSICP_GG073.Gg073Ccustoid equals _navBB005.Id into _navBB005Join
                                            from _navBB005 in _navBB005Join.DefaultIfEmpty()


                                            select new CSICP_GG073
                                            {
                                                TenantId = _CSICP_GG073.TenantId,
                                                Gg073Id = _CSICP_GG073.Gg073Id,
                                                Gg073Estabid = _CSICP_GG073.Gg073Estabid,
                                                Gg073DataMovimento = _CSICP_GG073.Gg073DataMovimento,
                                                Gg073Usuarioid = _CSICP_GG073.Gg073Usuarioid,
                                                Gg073Observacao = _CSICP_GG073.Gg073Observacao,
                                                Gg073Ccustoid = _CSICP_GG073.Gg073Ccustoid,
                                                Gg073Almoxmovd = _CSICP_GG073.Gg073Almoxmovd,
                                                Gg073Dhregistro = _CSICP_GG073.Gg073Dhregistro,
                                                Gg073Statusid = _CSICP_GG073.Gg073Statusid,
                                                Gg073Tmovid = _CSICP_GG073.Gg073Tmovid,
                                                Gg073Valorizarporid = _CSICP_GG073.Gg073Valorizarporid,
                                                Gg073Tmovimento = _CSICP_GG073.Gg073Tmovimento,
                                                Gg073Protocolonro = _CSICP_GG073.Gg073Protocolonro,
                                                Gg073Almoxmovsaida = _CSICP_GG073.Gg073Almoxmovsaida,
                                                Gg073QtdeItens = _CSICP_GG073.Gg073QtdeItens,
                                                Gg073IdOrig = _CSICP_GG073.Gg073IdOrig,
                                                Dd190Obraid = _CSICP_GG073.Dd190Obraid,
                                                NavBB005 = _navBB005 != null ? _navBB005 : null,
                                                Gg073Status = _gg073Status,
                                                Gg073Tmov = _gg073Tmov,
                                                Gg073Valorizarpor = _gg073Valorizarpor,
                                                NavSY001 = _navSy001 != null ? new Csicp_Sy001
                                                {
                                                    TenantId = _navSy001.TenantId,
                                                    Id = _navSy001.Id,
                                                    Sy001Usuario = _navSy001.Sy001Usuario,
                                                    Sy001Nome = _navSy001.Sy001Nome,
                                                    Sy001Senha = _navSy001.Sy001Senha,
                                                    Sy001Bloqueado = _navSy001.Sy001Bloqueado,
                                                } : null,
                                                Gg073AlmoxmovdNavigation = _gg001Almoxmovd != null ? new CSICP_GG001
                                                {
                                                    TenantId = _gg001Almoxmovd.TenantId,
                                                    Id = _gg001Almoxmovd.Id,
                                                    Gg001Filial = _gg001Almoxmovd.Gg001Filial,
                                                    Gg001Filialid = _gg001Almoxmovd.Gg001Filialid,
                                                    Gg001Codigoalmox = _gg001Almoxmovd.Gg001Codigoalmox,
                                                    Gg001Descalmox = _gg001Almoxmovd.Gg001Descalmox,
                                                    Gg001Isactive = _gg001Almoxmovd.Gg001Isactive,
                                                    Gg001Tipoalmoxarifado = _gg001Almoxmovd.Gg001Tipoalmoxarifado,
                                                    Gg001RiControlequalidade = _gg001Almoxmovd.Gg001RiControlequalidade,
                                                    Gg001Caparmaz = _gg001Almoxmovd.Gg001Caparmaz,
                                                    Gg001Descnspadrao = _gg001Almoxmovd.Gg001Descnspadrao,
                                                } : null,
                                                Gg073AlmoxmovsaidaNavigation = _gg001AlmoxmovdSaida != null ? new CSICP_GG001
                                                {
                                                    TenantId = _gg001AlmoxmovdSaida.TenantId,
                                                    Id = _gg001AlmoxmovdSaida.Id,
                                                    Gg001Filial = _gg001AlmoxmovdSaida.Gg001Filial,
                                                    Gg001Filialid = _gg001AlmoxmovdSaida.Gg001Filialid,
                                                    Gg001Codigoalmox = _gg001AlmoxmovdSaida.Gg001Codigoalmox,
                                                    Gg001Descalmox = _gg001AlmoxmovdSaida.Gg001Descalmox,
                                                    Gg001Isactive = _gg001AlmoxmovdSaida.Gg001Isactive,
                                                    Gg001Tipoalmoxarifado = _gg001AlmoxmovdSaida.Gg001Tipoalmoxarifado,
                                                    Gg001RiControlequalidade = _gg001AlmoxmovdSaida.Gg001RiControlequalidade,
                                                    Gg001Caparmaz = _gg001AlmoxmovdSaida.Gg001Caparmaz,
                                                    Gg001Descnspadrao = _gg001AlmoxmovdSaida.Gg001Descnspadrao,
                                                } : null
                                            };
            return query;
        }


        private static IQueryable<CSICP_GG073> FiltrosNecessariosEntidade(IQueryable<CSICP_GG073> query,
            string? Protocolo, string? BB001_EstabID, DateTime DataInicial,
            DateTime DataFinal, string? BB005_CentroCustoID,
            string? GG001_AlmoxID, int? GG073_StatusID, int? GG073_TMov_ID)
        {

            query = query.Where(e => e.Gg073DataMovimento >= DataInicial && e.Gg073DataMovimento <= DataFinal);

            if (BB001_EstabID is not null) query = query.Where(e => e.Gg073Estabid != null && e.Gg073Estabid.Equals(BB001_EstabID));
            if (BB005_CentroCustoID is not null) query = query.Where(e => e.Gg073Ccustoid != null && e.Gg073Ccustoid.Equals(BB005_CentroCustoID));
            if (GG001_AlmoxID is not null) query = query.Where(e => e.Gg073Almoxmovd != null && e.Gg073Almoxmovd.Equals(GG001_AlmoxID));
            if (GG073_StatusID is not null) query = query.Where(e => e.Gg073Statusid == GG073_StatusID);
            if (GG073_TMov_ID is not null) query = query.Where(e => e.Gg073Tmovid == GG073_TMov_ID);
            if (Protocolo is not null) query = query.Where(e => e.Gg073Protocolonro == Protocolo);

            return query;
        }

    }
}


