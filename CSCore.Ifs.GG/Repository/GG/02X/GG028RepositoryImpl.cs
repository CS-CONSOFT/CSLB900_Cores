using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._01X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._02X
{
    public class GG028RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG028>(appDbContext),
        IGG028Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<RepoGetCSICP_GG028?> GetByIdAsync(string id, int tenant)
        {
            IQueryable<RepoGetCSICP_GG028> query = CriaQueryBaseGG028(tenant);

            return await query.AsNoTracking()
                 .Where(e => e.Id == id)
                 .AsSplitQuery()
                 .FirstOrDefaultAsync();
        }


        public async Task<(IEnumerable<RepoGetCSICP_GG028>, int)> GetListAsync(
            int tenant,
            int pageSize,
            int page,
            string saldoID,
            DateTime DataMovimentoInicial,
            DateTime DataMovimentoFinal)
        {
            IQueryable<RepoGetCSICP_GG028> query = CriaQueryBaseGG028(tenant);
            query = query.Where(e => e.Gg028Saldoid == saldoID);
            query = query.Where(e => e.Gg028DataMovimento >= DataMovimentoInicial
            && e.Gg028DataMovimento <= DataMovimentoFinal);

            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);
            query = query.AsNoTracking().AsSplitQuery();

            return (await query.ToListAsync(), count);
        }


        /// <summary>
        /// Retorna uma lista de CSICP_GG028Tree com base no tenant.
        /// </summary>
        /// <returns>
        /// <params>IEnumerable<CSICP_GG028Tree> É a lista paginada</params>
        /// </returns>
        public async Task<IEnumerable<RepoDtoExtrato>> GetListTreeAsync(int tenant, string in_doc_id, string? in_kardex_id)
        {
            //as vezes a arvore pode nao existir, nesse caso, vamos pegar o id do documento e usar no contains
            List<string> listaIds = await GetListaIdsGG028ParaUsarNoContains(tenant, in_doc_id);

            var queryGG028 = from gg028 in _appDbContext.OsusrE9aCsicpGg028s

                             join gg520 in _appDbContext.OsusrE9aCsicpGg520s
                             on gg028.Gg028Saldoid equals gg520.Id into gg520Join
                             from gg520 in gg520Join.DefaultIfEmpty()

                             join gg001 in _appDbContext.CSICP_GG001s
                             on gg028.Gg028Almoxid equals gg001.Id into gg001Join
                             from gg001 in gg001Join.DefaultIfEmpty()

                             join bb027 in _appDbContext.OsusrE9aCsicpBb027s
                             on gg028.Gg028Transacaoid equals bb027.Id into bb027Join
                             from bb027 in bb027Join.DefaultIfEmpty()

                             join bb012 in _appDbContext.OsusrE9aCsicpBb012s
                             on gg028.Gg028Contaid equals bb012.Id into bb012Join
                             from bb012 in bb012Join.DefaultIfEmpty()

                             join sy001 in _appDbContext.OsusrE9aCsicpSy001s
                             on gg028.Gg028Usuarioid equals sy001.Id into sy001Join
                             from sy001 in sy001Join.DefaultIfEmpty()

                             join gg028EntSai in _appDbContext.OsusrE9aCsicpGg028Entsais
                             on gg028.Gg028EntsaidaId equals gg028EntSai.Id into gg028EntSaiJoin
                             from gg028EntSai in gg028EntSaiJoin.DefaultIfEmpty()

                             join gg028Nat in _appDbContext.OsusrE9aCsicpGg028Nats
                             on gg028.Gg028NaturezaId equals gg028Nat.Id into gg028NatJoin
                             from gg028Nat in gg028NatJoin.DefaultIfEmpty()

                             join gg008 in _appDbContext.OsusrE9aCsicpGg008s
                             on gg028.Gg028Produtoid equals gg008.Id into gg008Join
                             from gg008 in gg008Join.DefaultIfEmpty()



                             where gg028.TenantId == tenant

                             where in_kardex_id != null ? gg520.Gg520KardexId == in_kardex_id : true

                             where listaIds.Contains(gg028.Gg028DoctoId ?? string.Empty)
                             select new RepoDtoExtrato
                             {
                                 Extrato = gg028,
                                 DescricaoReduzidaProduto = gg008.Gg008Descreduzida,
                                 CodigoProduto = gg008.Gg008Codgproduto,
                                 Natureza = gg028Nat.Label,
                                 NF_Cupom = gg028.Gg028NfOuCupom,
                                 Nome_Usuario = sy001.Sy001Usuario,
                                 Almoxarifado_NS = gg001.Gg001Descalmox + "-" + gg520.Gg520NsNumerosaldo,
                                 TipoMovimento = gg028EntSai.Label
                             };

            queryGG028 = queryGG028
                .OrderBy(e => e.CodigoProduto)
                .ThenBy(e => e.Extrato!.Gg028DataReferente)
                .ThenBy(e => e.Extrato!.Gg028Protocolnumber);




            return await queryGG028
                .AsNoTracking()
                .ToListAsync();
        }

        private async Task<List<string>> GetListaIdsGG028ParaUsarNoContains(int tenant, string in_doc_id)
        {
            var listaIds = new List<string>();
            var parentID = "";

            listaIds.Add(in_doc_id);

            var gg028_id_docParentId = await (from _gg028Tree in _appDbContext.OsusrE9aCsicpGg028Trees
                                              where _gg028Tree.TenantId == tenant
                                              && _gg028Tree.Gg028DoctoId == in_doc_id
                                              select new
                                              {
                                                  _gg028Tree.Gg028TreeId,
                                                  _gg028Tree.Gg028DoctoParentId,
                                                  _gg028Tree.Gg028DoctoId
                                              })
                                                  .AsNoTracking()
                                                  .FirstOrDefaultAsync();
            if (gg028_id_docParentId != null)
                listaIds.Add(gg028_id_docParentId?.Gg028DoctoId ?? "");


            parentID = gg028_id_docParentId?.Gg028DoctoParentId ?? string.Empty;

            var listaIds_gg028_id_2 = await (from _gg028Tree in _appDbContext.OsusrE9aCsicpGg028Trees
                                             where _gg028Tree.TenantId == tenant

                                             where parentID == "" ?
                                             _gg028Tree.Gg028DoctoParentId == in_doc_id
                                             : _gg028Tree.Gg028DoctoId == parentID || _gg028Tree.Gg028DoctoParentId == parentID

                                             select _gg028Tree.Gg028DoctoId)
                                    .AsNoTracking()
                                    .ToListAsync();

            listaIds.AddRange(listaIds_gg028_id_2);

            return listaIds;
        }

        private IQueryable<RepoGetCSICP_GG028> CriaQueryBaseGG028(int tenant)
        {
            return from gg028 in _appDbContext.OsusrE9aCsicpGg028s
                   where gg028.TenantId == tenant


                   join gg001 in _appDbContext.CSICP_GG001s
                   on gg028.Gg028Almoxid equals gg001.Id into gg001Join
                   from gg001 in gg001Join.DefaultIfEmpty()

                   join bb027 in _appDbContext.OsusrE9aCsicpBb027s
                   on gg028.Gg028Transacaoid equals bb027.Id into bb027Join
                   from bb027 in bb027Join.DefaultIfEmpty()

                   join bb012 in _appDbContext.OsusrE9aCsicpBb012s
                   on gg028.Gg028Contaid equals bb012.Id into bb012Join
                   from bb012 in bb012Join.DefaultIfEmpty()

                   join sy001 in _appDbContext.OsusrE9aCsicpSy001s
                   on gg028.Gg028Usuarioid equals sy001.Id into sy001Join
                   from sy001 in sy001Join.DefaultIfEmpty()

                   join gg028EntSai in _appDbContext.OsusrE9aCsicpGg028Entsais
                   on gg028.Gg028EntsaidaId equals gg028EntSai.Id into gg028EntSaiJoin
                   from gg028EntSai in gg028EntSaiJoin.DefaultIfEmpty()

                   join gg028Nat in _appDbContext.OsusrE9aCsicpGg028Nats
                   on gg028.Gg028NaturezaId equals gg028Nat.Id into gg028NatJoin
                   from gg028Nat in gg028NatJoin.DefaultIfEmpty()

                   join gg008 in _appDbContext.OsusrE9aCsicpGg008s
                   on gg028.Gg028Produtoid equals gg008.Id into gg008Join
                   from gg008 in gg008Join.DefaultIfEmpty()

                   join gg520 in _appDbContext.OsusrE9aCsicpGg520s
                   on gg028.Gg028Saldoid equals gg520.Id into gg520Join
                   from gg520 in gg520Join.DefaultIfEmpty()

                   select new RepoGetCSICP_GG028
                   {
                       TenantId = gg028.TenantId,
                       Id = gg028.Id,
                       Gg028Filialid = gg028.Gg028Filialid,
                       Gg028Filial = gg028.Gg028Filial,
                       Gg028Protocolnumber = gg028.Gg028Protocolnumber,
                       Gg028Origemprograma = gg028.Gg028Origemprograma,
                       Gg028OrigemPkid = gg028.Gg028OrigemPkid,
                       Gg028DataMovimento = gg028.Gg028DataMovimento,
                       Gg028DataReferente = gg028.Gg028DataReferente,
                       Gg028Almoxid = gg028.Gg028Almoxid,
                       Gg028KardexId = gg028.Gg028KardexId,
                       Gg028Produtoid = gg028.Gg028Produtoid,
                       Gg028Saldoid = gg028.Gg028Saldoid,
                       Gg028Transacaoid = gg028.Gg028Transacaoid,
                       Gg028Contaid = gg028.Gg028Contaid,
                       Gg028Usuarioid = gg028.Gg028Usuarioid,
                       Gg028QtdMovimento = gg028.Gg028QtdMovimento,
                       Gg028ValorUnitario = gg028.Gg028ValorUnitario,
                       Gg028SaldoAnterior = gg028.Gg028SaldoAnterior,
                       Gg028DocProtocolnumber = gg028.Gg028DocProtocolnumber,
                       Gg028DoctoId = gg028.Gg028DoctoId,
                       Gg028NPdv = gg028.Gg028NPdv,
                       Gg028NfOuCupom = gg028.Gg028NfOuCupom,
                       Gg028EntsaidaId = gg028.Gg028EntsaidaId,
                       Gg028NaturezaId = gg028.Gg028NaturezaId,
                       NavBB012_Cliente = bb012,
                       NavBB027 = bb027,
                       NavGG001_Almox = gg001,
                       NavSY001_Usuario = sy001,
                       Nav_GG008_Produto = gg008,
                       Nav_GG028_EntSaida = gg028EntSai,
                       Nav_GG028_Nat = gg028Nat,
                       Nav_GG520_Saldo = gg520
                   };
        }

    }
}


