using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF103RepositoryImpl : RepositorioBaseImpl<CSICP_FF103>, IFF103Repository
    {
        private readonly AppDbContext _appDbContext;

        public FF103RepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<CSICP_FF103> GetByIdAsync(int in_tenant, string in_ff103Id)
        {
            try
            {
                var query = GetQueryBase(in_tenant);
                query = query.Where(e => e.Id.Equals(in_ff103Id));
                return await query.FirstOrDefaultAsync() ?? throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);
            }
            catch (Exception ex)
            {
                if (ex is KeyNotFoundException) throw;
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }

        public Task<(List<CSICP_FF103>, int)> GetListAsync(int in_tenant, string? inff102ID, int in_pageNumber, int in_pageSize)
        {
            try
            {
                var query = GetQueryBase(in_tenant);
                if (inff102ID != null)
                    query = query.Where(e => e.Ff102Id!.Equals(inff102ID));

                query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);
                var count = query.Count();
                return Task.FromResult((query.ToList(), count));
            }
            catch (Exception ex)
            {
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }
        private IQueryable<CSICP_FF103> GetQueryBase(int in_tenant)
        {
            return from ff103 in _appDbContext.OsusrE9aCsicpFf103s
                   .AsNoTracking()

                   // Join com FF102 (Título) para obter as informações do título
                   join ff102 in _appDbContext.OsusrE9aCsicpFf102s
                   on ff103.Ff102Id equals ff102.Id into ff102_ff103_join
                   from ff102 in ff102_ff103_join.DefaultIfEmpty()

                   // Join com BB012 (Conta) para exibir a conta através de Ff102Contaid
                   join bb012 in _appDbContext.OsusrE9aCsicpBb012s
                   on ff102.Ff102Contaid equals bb012.Id into bb012_ff102_join
                   from bb012 in bb012_ff102_join.DefaultIfEmpty()

                   join sy001 in _appDbContext.OsusrE9aCsicpSy001s
                   on ff103.Ff103Usuarioproprid equals sy001.Id into sy001_ff103_join
                   from sy001 in sy001_ff103_join.DefaultIfEmpty()

                   join ff102Sit in _appDbContext.OsusrE9aCsicpFf102Sits
                   on ff102.Ff102Situacaoid equals ff102Sit.Id into ff102Sit_ff102_join
                   from ff102Sit in ff102Sit_ff102_join.DefaultIfEmpty()

                   join bb006 in _appDbContext.OsusrE9aCsicpBb006s
                   on ff103.Ff103Agcobradorid equals bb006.Id into bb006join
                   from bb006 in bb006join.DefaultIfEmpty()

                   where ff103.TenantId == in_tenant
                   select new CSICP_FF103
                   {
                       TenantId = ff103.TenantId,
                       Id = ff103.Id,
                       Ff102Id = ff103.Ff102Id,
                       Ff103Filialid = ff103.Ff103Filialid,
                       Ff103Filial = ff103.Ff103Filial,
                       Ff103Pfx = ff103.Ff103Pfx,
                       Ff103NoTitulo = ff103.Ff103NoTitulo,
                       Ff103Sfx = ff103.Ff103Sfx,
                       Ff103SeqBaixa = ff103.Ff103SeqBaixa,
                       Ff103DataBaixa = ff103.Ff103DataBaixa,
                       Ff103DtaBaixaAnt = ff103.Ff103DtaBaixaAnt,
                       Ff103DataCredito = ff103.Ff103DataCredito,
                       Ff103Agcobradorid = ff103.Ff103Agcobradorid,
                       Ff103Banco = ff103.Ff103Banco,
                       Ff103ValorJuros = ff103.Ff103ValorJuros,
                       Ff103ValorDesconto = ff103.Ff103ValorDesconto,
                       Ff103ValorPago = ff103.Ff103ValorPago,
                       Ff103ValorMulta = ff103.Ff103ValorMulta,
                       Ff103ValorTarifas = ff103.Ff103ValorTarifas,
                       Ff103Atraso = ff103.Ff103Atraso,
                       Ff103Historico = ff103.Ff103Historico,
                       Ff103BaixadoAuto = ff103.Ff103BaixadoAuto,
                       Ff103Usuarioproprid = ff103.Ff103Usuarioproprid,
                       Ff103Cobradorid = ff103.Ff103Cobradorid,
                       Ff103ResponsavelCob = ff103.Ff103ResponsavelCob,
                       Ff103NoPdv = ff103.Ff103NoPdv,
                       Ff103CiPdv = ff103.Ff103CiPdv,
                       Ff103DespesaCartorio = ff103.Ff103DespesaCartorio,
                       Ff103BaixaTesouraria = ff103.Ff103BaixaTesouraria,
                       Ff103Lctoctbbxid = ff103.Ff103Lctoctbbxid,
                       Ff103ObjBxLabel = ff103.Ff103ObjBxLabel,
                       Ff103ObjBxId = ff103.Ff103ObjBxId,
                       Ff103Baixado = ff103.Ff103Baixado,
                       Ff103Estornado = ff103.Ff103Estornado,
                       Ff103Cancelado = ff103.Ff103Cancelado,
                       Ff103Dataregistro = ff103.Ff103Dataregistro,
                       Ff103Tpbaixaid = ff103.Ff103Tpbaixaid,
                       Ff103Flagregistro = ff103.Ff103Flagregistro,
                       Ff103MsgId = ff103.Ff103MsgId,
                       Ff103CtbIscontabilizadoid = ff103.Ff103CtbIscontabilizadoid,
                       Ff103CtbUsuarioid = ff103.Ff103CtbUsuarioid,
                       Ff103CtbDtregistro = ff103.Ff103CtbDtregistro,
                       Ff103CtbIsestornadoid = ff103.Ff103CtbIsestornadoid,
                       Ff103CtbEstusuarioid = ff103.Ff103CtbEstusuarioid,
                       Ff103CtbEstdtreg = ff103.Ff103CtbEstdtreg,
                       Ff103CtbIdlancto = ff103.Ff103CtbIdlancto,
                       Ff103CtbMsg = ff103.Ff103CtbMsg,
                       Ff103FpagtoId = ff103.Ff103FpagtoId,
                       Ff103VlCorrmonetaria = ff103.Ff103VlCorrmonetaria,
                       Ff103VlHonorarios = ff103.Ff103VlHonorarios,
                       Ff103CtlIscontabilizadoid = ff103.Ff103CtlIscontabilizadoid,
                       Ff103CtlUsuarioid = ff103.Ff103CtlUsuarioid,
                       Ff103CtlDtregistro = ff103.Ff103CtlDtregistro,
                       Ff103CtlIsestornadoid = ff103.Ff103CtlIsestornadoid,
                       Ff103CtlEstusuarioid = ff103.Ff103CtlEstusuarioid,
                       Ff103CtlEstdtreg = ff103.Ff103CtlEstdtreg,
                       Ff103CtlIdlancto = ff103.Ff103CtlIdlancto,
                       Ff103CtlMsg = ff103.Ff103CtlMsg,


                       // Navegação aninhada para SY001 (Usuário Proprietário)
                       NavSY001 = sy001 != null ? new Csicp_Sy001
                       {
                           TenantId = sy001.TenantId,
                           Id = sy001.Id,
                           Sy001Usuario = sy001.Sy001Usuario,
                           Sy001Nome = sy001.Sy001Nome,
                           Sy001Email = sy001.Sy001Email
                       } : null,
                       NavBB006 = bb006 != null ? new CSICP_Bb006
                       {
                           TenantId = bb006.TenantId,
                           Id = bb006.Id,
                           Bb006Filial = bb006.Bb006Filial,
                           Bb006Codgbanco = bb006.Bb006Codgbanco,
                           Bb006Banco = bb006.Bb006Banco,
                           Bb006Nomereduzido = bb006.Bb006Nomereduzido,
                           Bb006Nobanco = bb006.Bb006Nobanco,
                           Bb006Agencia = bb006.Bb006Agencia,
                           Bb006AgenciaDv = bb006.Bb006AgenciaDv,
                           Bb006Noconta = bb006.Bb006Noconta,
                           Bb006Contadv = bb006.Bb006Contadv,
                           Bb006Dvagenciacc = bb006.Bb006Dvagenciacc,
                           Bb006Endereco = bb006.Bb006Endereco,
                           Bairroid = bb006.Bairroid,
                           Cidadeid = bb006.Cidadeid,
                           Bb006Telefone = bb006.Bb006Telefone,
                           Bb006Fax = bb006.Bb006Fax,
                           Bb006Email = bb006.Bb006Email,
                           Bb006Homepage = bb006.Bb006Homepage,
                           Bb006Contato = bb006.Bb006Contato,
                           Bb006Diasretencao = bb006.Bb006Diasretencao,
                           Bb006Diasretencaodesc = bb006.Bb006Diasretencaodesc
                       } : null,
                       // Navegação para FF102 (Título) - Adicionando as informações do título
                       NavFF102 = ff102 != null ? new RepoDtoCSICP_FF102
                       {
                           TenantId = ff102.TenantId,
                           Id = ff102.Id,
                           Ff102Tiporegistro = ff102.Ff102Tiporegistro,
                           Ff102Filialid = ff102.Ff102Filialid,
                           Ff102Filial = ff102.Ff102Filial,
                           Ff102Pfx = ff102.Ff102Pfx,
                           Ff102NoTitulo = ff102.Ff102NoTitulo,
                           Ff102Sfx = ff102.Ff102Sfx,
                           Ff102Contaid = ff102.Ff102Contaid,
                           Ff102Contarealid = ff102.Ff102Contarealid,
                           Ff102Usuarioproprieid = ff102.Ff102Usuarioproprieid,
                           Ff102DataEmissao = ff102.Ff102DataEmissao,
                           Ff102DataVencimento = ff102.Ff102DataVencimento,
                           Ff102DataVencReal = ff102.Ff102DataVencReal,
                           Ff102ValorTitulo = ff102.Ff102ValorTitulo,
                           Ff102VlLiqTitulo = ff102.Ff102VlLiqTitulo,
                           Ff102Situacao = ff102.Ff102Situacao,
                           Ff102Situacaoid = ff102.Ff102Situacaoid,
                           Ff102Observacao = ff102.Ff102Observacao,
                           // Navegação aninhada para CSICP_FF102Sit (Situação do Título)
                          NavFF102Sit  = ff102Sit != null ? ff102Sit : null,

                           // Navegação aninhada para BB012 (Conta)
                           NavBB012 = bb012 != null ? new CSICP_BB012
                           {
                               TenantId = bb012.TenantId,
                               Id = bb012.Id,
                               Bb012Codigo = bb012.Bb012Codigo,
                               Bb012NomeCliente = bb012.Bb012NomeCliente,
                               Bb012NomeFantasia = bb012.Bb012NomeFantasia,
                               Bb012Telefone = bb012.Bb012Telefone,
                               Bb012Email = bb012.Bb012Email
                           } : null,
                       } : null
                   };
        }
    }
}
