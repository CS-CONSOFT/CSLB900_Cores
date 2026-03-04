using CSCore.Domain;
using CSCore.Domain.Interfaces.BB.Conta;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.Compartilhado.Utilidade.SiteProperties;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.CS_QueryFilters;
using CSLB900.MSTools.CS_QueryFilters.Specific;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB.Conta
{
    public class BB012Repository(
        AppDbContext context,
        IVerificaSiteProperties verificaSiteProperties) : IBB012Repository
    {
        private readonly AppDbContext _appDbContext = context;
        private readonly IVerificaSiteProperties _verificaSiteProperties = verificaSiteProperties;

        public async Task<CSICP_BB012> CreateAsync(
            CSICP_BB012 bb012, CSICP_BB01201 bb01201, CSICP_BB01202 bb01202, CSICP_BB01206 bb01206,
            string? in_FilialLoagadaID,
            string? in_ID_AA006)
        {
            await GeraBb012CodigoSeFaltandoAsync(bb012, in_FilialLoagadaID, in_ID_AA006);
            await ValidarObrigatoriedadesClienteAsync(bb012);
            ValidaCpfCnpj(bb01202);


            _appDbContext.Add(bb012);
            _appDbContext.Add(bb01201);
            _appDbContext.Add(bb01202);
            _appDbContext.Add(bb01206);
            await _appDbContext.SaveChangesAsync();
            return bb012;
        }




        public async Task<CSICP_BB012?> GetByIdAsync(string id, int tenant)
        {
            CSICP_BB012? bb012 = await GetEntityById(id, tenant);
            return bb012;
        }

        public async Task<(IEnumerable<CSICP_BB012>, int)> GetListAsync(
            int tenant,
            string? search,
            int? searchCode,
            bool? isActive,
            int? ClasseId,
            int? ModRelacaoId,
            int? SituacaoId,
            int? StatusId,
            int? GrupoId,
            string? CPF_CNPJ,
            BB012ContaParameters parametrosBaseFiltro
            )
        {
            IQueryable<CSICP_BB012> queryCount;
            IQueryable<CSICP_BB012> q1 = CreateBaseQuery(tenant).AsQueryable();



            q1 = FiltraQuandoExisteFiltros(search, searchCode, isActive, q1);
            q1 = FilterByStaticasIdAndCpfCnpj(ClasseId, ModRelacaoId, SituacaoId, StatusId, GrupoId, CPF_CNPJ, q1);



            queryCount = q1;
            int count = queryCount.Count();

            q1 = q1.OrderBy(e => e.Bb012NomeCliente)
                .PaginacaoNoBanco(parametrosBaseFiltro.PageNumber, parametrosBaseFiltro.PageSize);



            return (await q1.ToListAsync(), count);
        }

        public async Task<CSICP_BB012> RemoveAsync(CSICP_BB012 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB012> UpdateAsync(
            CSICP_BB012 bb012, CSICP_BB01201 bb01201, CSICP_BB01202 bb01202, CSICP_BB01206 bb01206)
        {

            await ValidarObrigatoriedadesClienteAsync(bb012);
            ValidaCpfCnpj(bb01202);


            _appDbContext.Update(bb012);
            await _appDbContext.SaveChangesAsync();
            _appDbContext.Update(bb01201);
            await _appDbContext.SaveChangesAsync();
            _appDbContext.Update(bb01202);
            await _appDbContext.SaveChangesAsync();
            _appDbContext.Update(bb01206);
            await _appDbContext.SaveChangesAsync();
            return bb012;
        }


        public async Task<CSICP_BB012> ChangeActive(CSICP_BB012 entity)
        {
            entity.Bb012IsActive = !entity.Bb012IsActive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<CSICP_BB01206?> GetBB1206PorClienteID(string BB012clienteID, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpBb01206s
            .AsNoTracking()
            .Where(e => e.TenantId == tenant && e.Bb012Id == BB012clienteID)
            .FirstOrDefaultAsync();
        }


        public async Task<List<CSICP_BB01203>> GetNotas(string id, int tenant)
        {
            //recupera as notas
            return await _appDbContext.OsusrE9aCsicpBb01203s
            .AsNoTracking()
            .Where(e => e.TenantId == tenant && e.Bb012Id == id)
            .ToListAsync();
        }

        public async Task<List<CSICP_BB012o>> GetRetencaoImpostos(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpBb012os
                .AsSplitQuery()
                .AsNoTracking()
                .Include(e => e.NavBb012oImposto)
                .Include(e => e.NavStatica_Retem)
                .Where(e => e.TenantId == tenant && e.Bb012Id == id)
                .ToListAsync();
        }

        public async Task<List<CSICP_BB012q>> GetDadosBancarios(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpBb012qs
                .AsNoTracking()
                .Where(e => e.TenantId == tenant && e.Bb012Id == id && e.Bb012qIsActive == true)
                .ToListAsync();
        }


        public async Task<List<CSICP_BB012j>> GetOutrosEnderecos(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpBb012js
                .AsSplitQuery()
                .AsNoTracking()
                .Where(e => e.Bb012Id == id && e.TenantId == tenant)
                .Where(e => e.NavBB1206_Endereco != null) // Filtra registros sem endereço
                .Include(e => e.NavTipoEndereco)
                .Include(e => e.NavBB1206_Endereco)
                    .ThenInclude(e => e.AA025_Pais)
                .Include(e => e.NavBB1206_Endereco)
                    .ThenInclude(e => e.AA028_Cidade)
                .Include(e => e.NavBB1206_Endereco)
                    .ThenInclude(e => e.AA027_UF)
                .ToListAsync();
        }
        public async Task<List<CSICP_BB01208>> GetContatos(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpBb01208s
                .AsSplitQuery()
                .AsNoTracking()
                .Include(e => e.NavCSICP_BB035Gpa)
                .Include(e => e.NavCSICP_BB035)
                .ThenInclude(e => e.NavCSICP_BB035End)
                .Where(e => e.Bb012Id == id)
                .ToListAsync();
        }

        public async Task<List<CSICP_BB012m>> GetGED(string id, int tenant)
        {
            var query = from _csicp_bb012M in _appDbContext.OsusrE9aCsicpBb012ms
                        where _csicp_bb012M.Bb012Id == id
                        where _csicp_bb012M.TenantId == tenant

                        join _csicp_navBB012MDC in _appDbContext.OsusrE9aCsicpBb012mdcs
                        on _csicp_bb012M.Bb012mDoctoid equals _csicp_navBB012MDC.Id into _csicp_navBB012MJoined
                        from _csicp_navBB012MDC in _csicp_navBB012MJoined.DefaultIfEmpty()

                        join _csicp_navBB012MTD in _appDbContext.OsusrE9aCsicpBb012mtds
                       on _csicp_bb012M.Bb012mTipodoctoid equals _csicp_navBB012MTD.Id into _csicp_navBB012MTdJoined
                        from _csicp_navBB012MTD in _csicp_navBB012MTdJoined.DefaultIfEmpty()

                        select new CSICP_BB012m
                        {

                            TenantId = _csicp_bb012M.TenantId,
                            Id = _csicp_bb012M.Id,
                            Bb012Id = _csicp_bb012M.Bb012Id,
                            Bb012Contatoid = _csicp_bb012M.Bb012Contatoid,
                            Bb012Candidatoid = _csicp_bb012M.Bb012Candidatoid,
                            Bb043Campanhaid = _csicp_bb012M.Bb043Campanhaid,
                            Bb042Potencialid = _csicp_bb012M.Bb042Potencialid,
                            Bb040Atividadeid = _csicp_bb012M.Bb040Atividadeid,
                            Bb041Casoid = _csicp_bb012M.Bb041Casoid,
                            Bb012mCodigoCliente = _csicp_bb012M.Bb012mCodigoCliente,
                            Bb012mDescricao = _csicp_bb012M.Bb012mDescricao,
                            Bb012mContent = _csicp_bb012M.Bb012mContent,
                            Bb012mFiletype = _csicp_bb012M.Bb012mFiletype,
                            Bb012mFilename = _csicp_bb012M.Bb012mFilename,
                            Bb012mIsActive = _csicp_bb012M.Bb012mIsActive,
                            Bb012mTipodoctoid = _csicp_bb012M.Bb012mTipodoctoid,
                            Bb012mDoctoid = _csicp_bb012M.Bb012mDoctoid,
                            Bb012mDatadocto = _csicp_bb012M.Bb012mDatadocto,
                            Bb012mPath = _csicp_bb012M.Bb012mPath,
                            NavBB012MDC = _csicp_navBB012MDC,
                            NavBB012MTD = _csicp_navBB012MTD,
                        };


            List<CSICP_BB012m> cSICP_BB012ms = await query.ToListAsync();
            return cSICP_BB012ms;
        }

        public async Task<List<CSICP_BB01209>> GetMeuCrediario(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpBb01209s
                .AsNoTracking()
               .Where(e => e.Bb012Contaid == id && e.TenantId == tenant)
               .ToListAsync();
        }
        public async Task<List<CSICP_BB01210>> GetAnaliseCredito(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpBb01210s
                .AsNoTracking()
               .Where(e => e.Bb012Id == id && e.TenantId == tenant)
               .ToListAsync();
        }
        public async Task<List<CSICP_BB012c>> GetBens(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpBb012cs.
                Where(e => e.Bb012Id == id && e.TenantId == tenant && e.Bb012cIsActive == true)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// tipoRegMembroConvenio
        ///  1.Membro
        ///  2.Convenio
        ///  3.Avalista
        /// </summary>
        public async Task<List<CSICP_BB01207>> GetMembros(string id, int tenant, int tipoRegMembroConvenio)
        {
            List<CSICP_BB01207> csicpBb01207MembroList = await _appDbContext.OsusrE9aCsicpBb01207s
               .AsSplitQuery()
               .Where(e => e.TenantId == tenant)
               .Where(e => e.Bb012Id == id)
               .Where(e => e.Bb01207IsActive == true)
               .Where(e => e.Bb012TipoRegMembroconveni == tipoRegMembroConvenio)
               .Include(e => e.NavBb012Membro)
               .ToListAsync();
            return csicpBb01207MembroList;
        }


        public async Task<IReadOnlyCollection<CSICP_BB012>> GetComboCliente(
            int tenant, int modRel, string? search)
        {
            IQueryable<CSICP_BB012> queryBase = _appDbContext
                .OsusrE9aCsicpBb012s
                .Where(e => e.Bb012IsActive == true)
                .Where(e => e.TenantId == tenant)
                .OrderBy(e => e.Bb012NomeCliente);

            if (search != "" && search != null)
            {
                queryBase = queryBase
                    .Where(e => e.Bb012NomeCliente != null
                    && e.Bb012NomeCliente.Contains(search));
            }

            var listFiltro = new List<int>() { modRel, 3 };
            queryBase = queryBase.Where(e => listFiltro.Contains(e.Bb012ModrelacaoId));

            return await queryBase.ToListAsync();
        }


        private static IQueryable<CSICP_BB012> FiltraQuandoExisteFiltros(string? search, int? searchCode, bool? isActive, IQueryable<CSICP_BB012> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb012NomeCliente ?? "").Contains(search ?? "") ||
                           (entity.Bb012NomeFantasia ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query.Where(e => e.Bb012Codigo == searchCode);
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb012IsActive == isActive);
            }

            return query;
        }

        private static IQueryable<CSICP_BB012> FilterByStaticasIdAndCpfCnpj(int? ClasseId, int? ModRelacaoId, int? SituacaoId, int? StatusId, int? GrupoId, string? CPF_CNPJ, IQueryable<CSICP_BB012> q1)
        {

            if (ClasseId != null && ClasseId != 0)
            {
                q1 = q1.Where(e => e.Bb012ClassecontaId == ClasseId);
            }


            if (ModRelacaoId != null && ModRelacaoId != 0)
            {
                q1 = q1.Where(e => e.Bb012ModrelacaoId == ModRelacaoId);
            }


            if (SituacaoId != null && SituacaoId != 0)
            {
                q1 = q1.Where(e => e.Bb012SitContaId == SituacaoId);
            }

            if (StatusId != null && StatusId != 0)
            {
                q1 = q1.Where(e => e.Bb012StatuscontaId == StatusId);
            }


            if (GrupoId != null && GrupoId != 0)
            {
                q1 = q1.Where(e => e.Bb012GrupocontaId == GrupoId);
            }

            if (CPF_CNPJ != null)
            {
                if (CPF_CNPJ.Length == 11)
                {
                    q1 = q1.Where(e => e.Nav_BB01202.Bb012Cpf == decimal.Parse(CPF_CNPJ));
                }
                else if (CPF_CNPJ.Length == 14)
                {
                    q1 = q1.Where(e => e.Nav_BB01202.Bb012Cnpj == CPF_CNPJ);
                }
            }

            return q1;
        }
        private async Task GeraBb012CodigoSeFaltandoAsync(CSICP_BB012 bb012, string? in_FilialLoagadaID, string? in_ID_AA006)
        {
            if (bb012.Bb012Codigo == 0 || bb012.Bb012Codigo == null)
            {
                string codigo = await RecuperaSeqNroConta.Get_SeqNroConta(context, bb012.TenantId,
                in_filialID: in_FilialLoagadaID ?? "",
                in_novoIdAA006: in_ID_AA006 ?? "");

                bb012.Bb012Codigo = int.Parse(codigo);
            }
        }

        private async Task ValidarObrigatoriedadesClienteAsync(CSICP_BB012 bb012)
        {
            bool tornaAtividadeObrigatoria =
                await _verificaSiteProperties.VerificaAsync(bb012.TenantId, SiteProperties.BB012_TornaAtividadeObrigatoria);

            bool tornaZonaCobrancaObrigatoria =
                await _verificaSiteProperties.VerificaAsync(bb012.TenantId, SiteProperties.BB012_TornaZonaCobrancaObrigatoria);

            bool tornaZonaEntregaObrigatoria =
                await _verificaSiteProperties.VerificaAsync(bb012.TenantId, SiteProperties.BB012_TornaZonaEntregaObrigatoria);

            if (tornaAtividadeObrigatoria) throw new Exception("A Atividade é obrigatória para o cliente.");
            if (tornaZonaCobrancaObrigatoria) throw new Exception("A Zona de Cobrança é obrigatória para o cliente.");
            if (tornaZonaEntregaObrigatoria) throw new Exception("A Zona de Entrega é obrigatória para o cliente.");
        }

        private static void ValidaCpfCnpj(CSICP_BB01202 bb01202)
        {
            if (bb01202.Bb012Cpf != null && bb01202.Bb012Cpf != 0)
            {
                bb01202.Bb012Cnpj = "";
                bool valido = ValidaCpf.CpfValido(bb01202.Bb012Cpf);
                if (valido == false) throw new Exception("O CPF informado é inválido.");
                return;
            }

            if (bb01202.Bb012Cnpj != null && bb01202.Bb012Cnpj != "0" || bb01202.Bb012Cnpj != "")
            {
                bb01202.Bb012Cpf = 0;
                bool valido = ValidaCnpj.CnpjValido(bb01202.Bb012Cnpj);
                if (valido == false) throw new Exception("O CNPJ informado é inválido.");
                return;
            }
        }

        private IQueryable<CSICP_BB012> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb012s
            .AsSplitQuery()
            .AsNoTracking()
            .Where(e => e.TenantId == tenant)
            .Include(e => e.BB012_GrupoConta)
            .Include(e => e.BB012_MCred)
            .Include(e => e.BB012_SitConta)
            .Include(e => e.BB012_StatusConta)
            .Include(e => e.BB012_TipoConta)
            .Include(e => e.BB012_ModeloRelacao)
            .Include(e => e.Nav_AA146_TP_GOV)
            .Include(e => e.Nav_AA143)
            .Include(e => e.BB012_ClasseConta)

            .Include(e => e.OsusrE9aCsicpBb01201)
            .ThenInclude(e => e.BB010_Zona)

            .Include(e => e.OsusrE9aCsicpBb01201)
            .ThenInclude(e => e.BB011_Atividade)

            .Include(e => e.OsusrE9aCsicpBb01201)
            .ThenInclude(e => e.BB006_BancoPadrao)

            .Include(e => e.OsusrE9aCsicpBb01201)
            .ThenInclude(e => e.Revenda)

            .Include(e => e.OsusrE9aCsicpBb01201)
            .ThenInclude(e => e.Requisicao)

            .Include(e => e.OsusrE9aCsicpBb01201)
            .ThenInclude(e => e.BB025_NatOperacao)

            .Include(e => e.OsusrE9aCsicpBb01201)
            .ThenInclude(e => e.BB008_CondPagamento)

            .Include(e => e.OsusrE9aCsicpBb01201)
            .ThenInclude(e => e.BB029_Categoria)

            .Include(e => e.OsusrE9aCsicpBb01201)
            .ThenInclude(e => e.BB01201_Convenio)

            .Include(e => e.OsusrE9aCsicpBb01201)
            .ThenInclude(e => e.BB01201_TpGeracao)

            .Include(e => e.OsusrE9aCsicpBb01201)
            .ThenInclude(e => e.BB01201_SitEspecial)

            .Include(e => e.OsusrE9aCsicpBb01201)
            .ThenInclude(e => e.BB010_EntregaMontagem)

            .Include(e => e.OsusrE9aCsicpBb01201)
            .ThenInclude(e => e.BB010_VendaRota)

            .Include(e => e.OsusrE9aCsicpBb01201)
            .ThenInclude(e => e.BB037_DiaVencimento)


            .Include(e => e.Nav_BB01202)
            .ThenInclude(e => e.BB012_RegSUFRAMAValido)

            .Include(e => e.Nav_BB01202)
            .ThenInclude(e => e.BB012_Insc_Est_SNI)

            .Include(e => e.Nav_BB01202)
            .ThenInclude(e => e.BB012_Sexo)

            .Include(e => e.Nav_BB01202)
            .ThenInclude(e => e.BB012_EstadoCivil)

            .Include(e => e.Nav_BB01202)
            .ThenInclude(e => e.BB012_Domicilio)

            .Include(e => e.Nav_BB01202)
            .ThenInclude(e => e.BB012_ComprovanteResidencia1)

            .Include(e => e.Nav_BB01202)
            .ThenInclude(e => e.BB012_ComprovanteResidencia2)

            .Include(e => e.Nav_BB01202)
            .ThenInclude(e => e.BB012_Escolaridade)

            .Include(e => e.Nav_BB01202)
            .ThenInclude(e => e.BB012_Ocupacao)

            .Include(e => e.Nav_BB01202)
            .ThenInclude(e => e.AA028_NatualDe)

            .Include(e => e.Nav_BB01202)
            .ThenInclude(e => e.BB001_Tributacao)

            .Include(e => e.Nav_BB01202)
            .ThenInclude(e => e.BB012_TipoDaEmpresaTrabalho)

            .Include(e => e.Nav_BB01202)
            .ThenInclude(e => e.BB027_MotivoDesoneracao)


            .Include(e => e.NavBB01206)
            .ThenInclude(e => e.AA025_Pais)

            .Include(e => e.NavBB01206)
            .ThenInclude(e => e.AA028_Cidade)

            .Include(e => e.NavBB01206)
            .ThenInclude(e => e.AA027_UF);

        }

        private async Task<CSICP_BB012?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                        .FirstOrDefaultAsync(e => e.Id == id);
        }

    }
}


