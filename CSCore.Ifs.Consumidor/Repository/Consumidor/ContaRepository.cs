using CSCore.Domain;
using CSCore.Domain.Interfaces.Consumidor;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Consumidor.Repository.Consumidor
{
    public class ContaRepository(AppDbContext appDbContext) : IContaRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_BB012> AtualizarConta(CSICP_BB012 entity, CSICP_BB01201 bb1201, CSICP_BB01202 bb1202, CSICP_BB01206 bb1206)
        {
            int novoCodigo = IncrementarCodigo
           .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_BB012>
           (_appDbContext, entity.Bb012Codigo, "Bb012Codigo");

            CSICP_Bb012Mrel? cSICP_Bb012Mrel = await _appDbContext.OsusrE9aCsicpBb012Mrels.Where(e => e.Label == "Cliente").FirstOrDefaultAsync();

            entity.Bb012ModrelacaoId = cSICP_Bb012Mrel.Id;

            entity.Bb012Codigo = novoCodigo;
            _appDbContext.Update(entity);
            _appDbContext.Update(bb1201);
            _appDbContext.Update(bb1202);
            _appDbContext.Update(bb1206);

            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB012> CriarConta(CSICP_BB012 entity, CSICP_BB01201 bb1201, CSICP_BB01202 bb1202, CSICP_BB01206 bb1206)
        {
            int novoCodigo = IncrementarCodigo
              .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_BB012>
              (_appDbContext, entity.Bb012Codigo, "Bb012Codigo");

            entity.Bb012Codigo = novoCodigo;

            CSICP_Bb012Mrel? cSICP_Bb012Mrel = await _appDbContext.OsusrE9aCsicpBb012Mrels.Where(e => e.Label == "Cliente").FirstOrDefaultAsync();

            entity.Bb012ModrelacaoId = cSICP_Bb012Mrel.Id;

            _appDbContext.Add(entity);

            _appDbContext.Add(bb1201);

            _appDbContext.Add(bb1202);

            _appDbContext.Add(bb1206);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB012> DeletarConta(CSICP_BB012 entity)
        {
            entity.Bb012Keyacess = null;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB012> GetConta(string IDConta, int tenant)
        {

            IQueryable<CSICP_BB012> queryBB012 = GetContaPadrao(IDConta, tenant);
            CSICP_BB012? cadastroBB012Encontrado = await queryBB012.FirstOrDefaultAsync();

            if (cadastroBB012Encontrado == null) throw new KeyNotFoundException("Conta nao encontrada!");

            return cadastroBB012Encontrado;
        }

        private IQueryable<CSICP_BB012> GetContaPadrao(string IDConta, int tenant)
        {
            return from _get_bb012 in _appDbContext.OsusrE9aCsicpBb012s
                   where _get_bb012.Bb012IsActive == true
                   where _get_bb012.Id == IDConta
                   where _get_bb012.TenantId == tenant

                   select new CSICP_BB012
                   {
                       TenantId = _get_bb012.TenantId,
                       Id = _get_bb012.Id,
                       Bb012Codigo = _get_bb012.Bb012Codigo,
                       Bb012NomeCliente = _get_bb012.Bb012NomeCliente,
                       Bb012NomeFantasia = _get_bb012.Bb012NomeFantasia,
                       Bb012DataAniversario = _get_bb012.Bb012DataAniversario,
                       Bb012DataCadastro = _get_bb012.Bb012DataCadastro,
                       Bb012Telefone = _get_bb012.Bb012Telefone,
                       Bb012Faxcelular = _get_bb012.Bb012Faxcelular,
                       Bb012HomePage = _get_bb012.Bb012HomePage,
                       Bb012Email = _get_bb012.Bb012Email,
                       Bb012DataEntradaSit = _get_bb012.Bb012DataEntradaSit,
                       Bb012DataSaidaSit = _get_bb012.Bb012DataSaidaSit,
                       Bb012Descricao = _get_bb012.Bb012Descricao,
                       Bb012IsActive = _get_bb012.Bb012IsActive,
                       Bb012TipoContaId = _get_bb012.Bb012TipoContaId,
                       Bb012GrupocontaId = _get_bb012.Bb012GrupocontaId,
                       Bb012ClassecontaId = _get_bb012.Bb012ClassecontaId,
                       Bb012StatuscontaId = _get_bb012.Bb012StatuscontaId,
                       Bb012SitContaId = _get_bb012.Bb012SitContaId,
                       Bb012ModrelacaoId = _get_bb012.Bb012ModrelacaoId,
                       Bb012Sequence = _get_bb012.Bb012Sequence,
                       Bb012Dultalteracao = _get_bb012.Bb012Dultalteracao,
                       Bb012Estabcadid = _get_bb012.Bb012Estabcadid,
                       Bb012Keyacess = _get_bb012.Bb012Keyacess,
                       Bb012IdIndicador = _get_bb012.Bb012IdIndicador,
                       Bb012Countappmcon = _get_bb012.Bb012Countappmcon,
                       Bb012Oricadastroid = _get_bb012.Bb012Oricadastroid,
                   };
        }

    }
}
