using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.Consumidor;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace CSCore.Ifs.Consumidor.Repository.Consumidor
{
    public class CashbackRepositoryImpl : ICashbackRepository
    {
        private readonly AppDbContext _appDbContext;

        public CashbackRepositoryImpl(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<CSICP_DD142>> Get_CashbackConta
            (int tenant, string? BB012_ID, decimal? CPF, string LabelTipoCashback)
        {
            string? currentBB012_ID = BB012_ID;
            IQueryable<CSICP_BB012> queryBase = GetQueryBaseBB012(tenant);
            if (BB012_ID is null)
            {
                queryBase = queryBase.Where(e => e.Nav_BB01202!.Bb012Cpf == CPF);
                string? ID_BB012 = await queryBase.Select(e => e.Id).FirstOrDefaultAsync();
                if (ID_BB012 is null) throw new KeyNotFoundException("Conta não encontrada");
                currentBB012_ID = ID_BB012;
            }

            IQueryable<CSICP_DD142> queryDD142 = await GeraQueryDD142(tenant, currentBB012_ID!);

            int ID_DD143_sTA = await _appDbContext.OsusrTeiCsicpDd143Sta
                .Where(e => e.Label == LabelTipoCashback)
                .Select(e => e.Id)
                .FirstOrDefaultAsync();

            queryDD142 = queryDD142.Where(e => e.Dd142Statusid == ID_DD143_sTA);

            List<CSICP_DD142> ListaDD142 = await queryDD142.ToListAsync();



            return ListaDD142;

        }


        public async Task<List<CSICP_DD126>> Get_MovimentosCashback(int tenant, string? BB012_ID)
        {
            string? idCartaCredito = await GetSaldoCashback(tenant, BB012_ID);

            IQueryable<CSICP_DD126> queryDD126 = GetQueryDD126(tenant, idCartaCredito);

            List<CSICP_DD126> listaDD126 = await queryDD126.ToListAsync();

            if (listaDD126.IsNullOrEmpty()) throw new Exception("Carta de crédito sem movimentos!");

            return listaDD126;
        }

        public async Task<string?> GetSaldoCashback(int tenant, string? BB012_ID)
        {
            IQueryable<CSICP_DD125> queryDD125 = await GetQueryDD125(tenant, BB012_ID);

            var valorSaldo = await queryDD125.Select(e => e.Dd125VsaldoCarta).FirstOrDefaultAsync();

            if (valorSaldo is null) throw new KeyNotFoundException("Carta de crédito não localizada!");
            return valorSaldo?.ToString("0.00");
        }

        private IQueryable<CSICP_DD126> GetQueryDD126(int tenant, string? idCartaCredito)
        {
            return from _dd126 in _appDbContext.OsusrTeiCsicpDd126s
                   where _dd126.TenantId == tenant
                   where _dd126.Dd126CartacreditoId == idCartaCredito


                   join _dd126TMov in _appDbContext.OsusrTeiCsicpDd126Tmovs
                   on _dd126.Dd126TmovtoCcreId equals _dd126TMov.Id into joined
                   from _dd126TMov in joined.DefaultIfEmpty()


                   select new CSICP_DD126
                   {
                       TenantId = _dd126.TenantId,
                       Dd126RegccredId = _dd126.Dd126RegccredId,
                       Dd126CartacreditoId = _dd126.Dd126CartacreditoId,
                       Dd126FilialId = _dd126.Dd126FilialId,
                       Dd126UsuariopropId = _dd126.Dd126UsuariopropId,
                       Dd126DataMovto = _dd126.Dd126DataMovto,
                       Dd126DataCredito = _dd126.Dd126DataCredito,
                       Dd126VlrUtilizado = _dd126.Dd126VlrUtilizado,
                       Dd126Historico = _dd126.Dd126Historico,
                       Dd126PdvId = _dd126.Dd126PdvId,
                       Dd126TmovtoCcreId = _dd126.Dd126TmovtoCcreId,
                       Dd126UsoInternoWs = _dd126.Dd126UsoInternoWs,
                       Dd126Protocolnumber = _dd126.Dd126Protocolnumber,
                       Dd142HashCalculador = _dd126.Dd142HashCalculador,
                       Nav_Dd126TmovtoCcre = _dd126TMov
                   };
        }

        private async Task<IQueryable<CSICP_DD125>> GetQueryDD125(int tenant, string? BB012_ID)
        {
            int dd125_tp_cashback_id = await _appDbContext
                .OsusrTeiCsicpDd125Tps
                .Where(e => e.CsUsocs.Equals("Cashback"))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();



            IQueryable<CSICP_DD125> query = from _dd125 in _appDbContext.OsusrTeiCsicpDd125s
                                            where _dd125.TenantId == tenant
                                            where _dd125.Dd125ContaId == BB012_ID
                                            where _dd125.Dd125Tiporegid == dd125_tp_cashback_id
                                            select new CSICP_DD125
                                            {
                                                TenantId = _dd125.TenantId,
                                                Dd125CartacredId = _dd125.Dd125CartacredId,
                                                Dd125FilialId = _dd125.Dd125FilialId,
                                                Dd120TrocaId = _dd125.Dd120TrocaId,
                                                Dd125ContaId = _dd125.Dd125ContaId,
                                                Dd125DataMovto = _dd125.Dd125DataMovto,
                                                Dd125Vcarta = _dd125.Dd125Vcarta,
                                                Dd125VsaldoCarta = _dd125.Dd125VsaldoCarta,
                                                Dd125UsuariopropId = _dd125.Dd125UsuariopropId,
                                                Dd125StatusId = _dd125.Dd125StatusId,
                                                Dd125Email = _dd125.Dd125Email,
                                                Dd125Sms = _dd125.Dd125Sms,
                                                Dd125Protocolnumber = _dd125.Dd125Protocolnumber,
                                                Dd125Islock = _dd125.Dd125Islock,
                                                Dd125Tiporegid = _dd125.Dd125Tiporegid,
                                            };
            return query;
        }

        private async Task<IQueryable<CSICP_DD142>> GeraQueryDD142(int tenant, string currentBB012_ID)
        {

            int Status_143Sta_Order_ID = await _appDbContext
                .OsusrTeiCsicpDd143Sta
                .Where(e => e.Label.Equals("Registrado"))
                .Select(e => e.Id)
                .FirstOrDefaultAsync();

            var query = from _dd142 in _appDbContext.OsusrTeiCsicpDd142s
                        where _dd142.TenantId == tenant
                        where _dd142.Bb012Id == currentBB012_ID


                        join _bb012 in _appDbContext.OsusrE9aCsicpBb012s
                        on _dd142.Bb012Id equals _bb012.Id into joined
                        from _bb012 in joined.DefaultIfEmpty()

                        join _bb01202 in _appDbContext.OsusrE9aCsicpBb01202s
                        on _bb012.Id equals _bb01202.Id into joined_02
                        from _bb01202 in joined_02.DefaultIfEmpty()


                        join _dd040 in _appDbContext.OsusrTeiCsicpDd040s
                        on _dd142.Dd040Id equals _dd040.Dd040Id into joined_03
                        from _dd040 in joined_03.DefaultIfEmpty()

                        join _dd143Sta in _appDbContext.OsusrTeiCsicpDd143Sta
                        on _dd142.Dd142Statusid equals _dd143Sta.Id into joined_04
                        from _dd143Sta in joined_04.DefaultIfEmpty()

                        select new CSICP_DD142
                        {
                            TenantId = _dd142.TenantId,
                            Dd142Id = _dd142.Dd142Id,
                            Dd142Dtregistro = _dd142.Dd142Dtregistro,
                            Dd142Dhregistro = _dd142.Dd142Dhregistro,
                            Bb012Id = _dd142.Bb012Id,
                            Dd040Id = _dd142.Dd040Id,
                            Dd142Statusid = _dd142.Dd142Statusid,
                            Dd142Cartacreditoid = _dd142.Dd142Cartacreditoid,
                            Dd142Vcashback = _dd142.Dd142Vcashback,
                            Dd142Dtliberacao = _dd142.Dd142Dtliberacao,
                            Dd142HashCalculador = _dd142.Dd142HashCalculador,
                            Nav_BB012 = new CSICP_BB012
                            {
                                TenantId = _bb012.TenantId,
                                Id = _bb012.Id,
                                Bb012Codigo = _bb012.Bb012Codigo,
                                Bb012NomeCliente = _bb012.Bb012NomeCliente,
                                Bb012NomeFantasia = _bb012.Bb012NomeFantasia,
                                Nav_BB01202 = new CSICP_BB01202
                                {
                                    TenantId = _bb01202.TenantId,
                                    Id = _bb01202.Id,
                                    Bb012Cnpj = _bb01202.Bb012Cnpj,
                                    Bb012Cpf = _bb01202.Bb012Cpf,
                                    Bb012Rg = _bb01202.Bb012Rg,
                                }
                            },
                            Nav_Dd040 = new CSICP_DD040
                            {
                                TenantId = _dd040.TenantId,
                                Dd040Id = _dd040.Dd040Id,
                                Dd040Empresaid = _dd040.Dd040Empresaid,
                                Dd042Chaveacessonfe = _dd040.Dd042Chaveacessonfe,
                                Dd040Filial = _dd040.Dd040Filial,
                                Dd040TipoMovimento = _dd040.Dd040TipoMovimento,
                                Dd040Serie = _dd040.Dd040Serie,
                                Dd040NoNf = _dd040.Dd040NoNf
                            },
                            Nav_Dd143Status = _dd143Sta
                        };
            return query;
        }

        private IQueryable<CSICP_BB012> GetQueryBaseBB012(int tenant)
        {
            return from _bb012 in _appDbContext.OsusrE9aCsicpBb012s
                   where _bb012.Bb012IsActive == true
                   where _bb012.TenantId == tenant

                   join _bb01202 in _appDbContext.OsusrE9aCsicpBb01202s
                   on _bb012.Id equals _bb01202.Id into joined
                   from _bb01202 in joined.DefaultIfEmpty()


                   select new CSICP_BB012
                   {
                       TenantId = _bb012.TenantId,
                       Id = _bb012.Id,
                       Bb012Codigo = _bb012.Bb012Codigo,
                       Bb012NomeCliente = _bb012.Bb012NomeCliente,
                       Bb012NomeFantasia = _bb012.Bb012NomeFantasia,
                       Bb012DataAniversario = _bb012.Bb012DataAniversario,
                       Bb012DataCadastro = _bb012.Bb012DataCadastro,
                       Bb012Telefone = _bb012.Bb012Telefone,
                       Bb012Faxcelular = _bb012.Bb012Faxcelular,
                       Bb012HomePage = _bb012.Bb012HomePage,
                       Bb012Email = _bb012.Bb012Email,
                       Bb012DataEntradaSit = _bb012.Bb012DataEntradaSit,
                       Bb012DataSaidaSit = _bb012.Bb012DataSaidaSit,
                       Bb012Descricao = _bb012.Bb012Descricao,
                       Bb012IsActive = _bb012.Bb012IsActive,
                       Bb012TipoContaId = _bb012.Bb012TipoContaId,
                       Bb012GrupocontaId = _bb012.Bb012GrupocontaId,
                       Bb012ClassecontaId = _bb012.Bb012ClassecontaId,
                       Bb012StatuscontaId = _bb012.Bb012StatuscontaId,
                       Bb012SitContaId = _bb012.Bb012SitContaId,
                       Bb012ModrelacaoId = _bb012.Bb012ModrelacaoId,
                       Bb012Sequence = _bb012.Bb012Sequence,
                       Bb012Dultalteracao = _bb012.Bb012Dultalteracao,
                       Bb012Estabcadid = _bb012.Bb012Estabcadid,
                       Bb012Keyacess = _bb012.Bb012Keyacess,
                       Bb012IdIndicador = _bb012.Bb012IdIndicador,
                       Bb012Countappmcon = _bb012.Bb012Countappmcon,
                       Bb012Oricadastroid = _bb012.Bb012Oricadastroid,
                       Nav_BB01202 = new CSICP_BB01202
                       {
                           Bb012Cpf = _bb01202.Bb012Cpf,
                       }
                   };
        }
    }
}


