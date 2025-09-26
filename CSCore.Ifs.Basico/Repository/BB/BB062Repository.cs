using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_BB.BB06X;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB062Repository(AppDbContext context, IGenerateProtocolo generateProtocolo, ICS_GenerateId generateID) : IBB062Repository
    {
        private readonly AppDbContext _appDbContext = context;
        private readonly IGenerateProtocolo _generateProtocolo = generateProtocolo;
        private readonly ICS_GenerateId _generateID = generateID;

        public async Task<CSICP_Bb062> CreateAsync(CSICP_Bb062 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb062?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb062>> GetListAsync(int tenant, string? search)
        {
            IQueryable<CSICP_Bb062> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb062> RemoveAsync(CSICP_Bb062 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb062> UpdateAsync(CSICP_Bb062 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private static IQueryable<CSICP_Bb062> FiltraQuandoExisteFiltros(string? search, IQueryable<CSICP_Bb062> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb062Descritivo ?? "").Contains(search ?? ""));
            }
            return query;
        }


        private IQueryable<CSICP_Bb062> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb062s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_Bb062?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Bb062Id == long.Parse(id));
        }

        public async Task GerarTitulosConvenio(
            int in_tenant,
            string in_estabelecimentoID,
            long in_bb062_Id,
            int in_StID_bb1201_con_cartaoInternoID,
            int in_StID_bb062_sta_Fechado_ID,
            int in_StID_ff102_Ent_Parcela,
            int in_StID_ff102_Sit_Aberto)
        {
            using (var trans = await _appDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    await CS01_Le_Calend_Contas(
                        in_tenant,
                        in_bb062_Id,
                        in_StID_bb1201_con_cartaoInternoID,
                        in_StID_bb062_sta_Fechado_ID);

                    await _appDbContext.SaveChangesAsync();

                    await CS03_Le_Memoria(
                        in_tenant,
                        in_estabelecimentoID,
                        in_bb062_Id,
                        in_StID_ff102_Ent_Parcela,
                        in_StID_ff102_Sit_Aberto);

                    await _appDbContext.SaveChangesAsync();
                    await trans.CommitAsync();
                }
                catch (Exception ex)
                {
                    await trans.RollbackAsync();
                    throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
                }
            }
        }

        private async Task CS03_Le_Memoria(int in_tenant, string in_estabelecimentoID, long in_bb062_Id, int in_StID_ff102_Ent_Parcela, int in_StID_ff102_Sit_Aberto)
        {
            CSICP_Bb062? calendario = await GetCalendarioBB062(in_tenant, in_bb062_Id) ?? throw new Exception();
            int ano = calendario.Bb062Ano ?? 0;
            int mes = calendario.Bb062Mes ?? 0;
            int dia = calendario.NavBB037Diavencto?.Bb037Dia ?? 0;
            var dataVencimentoFinanceiro = new DateTime(ano, mes, dia);

            List<CSICP_BB063> listaBB063 = await GetListaDeBB063(in_tenant, in_bb062_Id);
            if (listaBB063.Count == 0) throw new Exception("Etapa-2: Não há memória de cálculo para gerar títulos!");

            for (int i = 0; i < listaBB063.Count; i++)
            {
                var currentMemoria = listaBB063[i];
                CSICP_Bb026? formaPagamento = await GetFormaPagamento(in_tenant, currentMemoria);
                if (formaPagamento == null) continue;

                string idff102Gerado = await CS05_Gera_Financeiro(
                    in_tenant,
                    in_estabelecimentoID,
                    formaPagamento.Bb026EspecieId ?? "",
                    currentMemoria.Bb012Contaid ?? "",
                    currentMemoria.Bb063Custoid ?? "",
                    currentMemoria.Bb063Agcobradorid ?? "",
                    currentMemoria.Bb063Responsavelid ?? "",
                    currentMemoria.Bb063Condicaoid ?? "",
                    currentMemoria.Bb063FpagtoId ?? "",
                    currentMemoria.Bb063Tipocobrancaid ?? "",
                    calendario.Bb062Dtemissao ?? DateTime.Now,
                    dataVencimentoFinanceiro,
                    currentMemoria.Bb063Valor ?? 0,
                    currentMemoria.Bb063Valor ?? 0,
                    in_StID_ff102_Ent_Parcela,
                    in_StID_ff102_Sit_Aberto);

                currentMemoria.Ff102Id = idff102Gerado;
                _appDbContext.Update(currentMemoria);
            }

        }

        private async Task<CSICP_Bb026?> GetFormaPagamento(int in_tenant, CSICP_BB063 currentMemoria)
        {
            var queryFormaPagamento = from bb026 in _appDbContext.OsusrE9aCsicpBb026s
                                      where bb026.TenantId == in_tenant
                                      where bb026.Id == currentMemoria.Bb063FpagtoId
                                      where bb026.Bb026Isactive == true
                                      select new CSICP_Bb026
                                      {
                                          Id = bb026.Id,
                                          Bb026EspecieId = bb026.Bb026EspecieId,
                                      };

            CSICP_Bb026? formaPagamento = await queryFormaPagamento.FirstOrDefaultAsync();
            return formaPagamento;
        }

        private async Task<string> CS05_Gera_Financeiro(
            int in_tenant,
            string in_estabelecimentoID,
            string in_especieID,
            string in_contaID,
            string in_ccustoId,
            string in_agenteCobrador_id,
            string in_responsavel_id,
            string in_condicao_id,
            string in_forma_pgto_id,
            string in_tipoCobranca_id,
            DateTime in_data_emissao,
            DateTime in_data_vencimento,
            decimal in_valor_titulo,
            decimal in_valor_liquido_titulo,
            int in_StID_ff102_Ent_Parcela,
            int in_StID_ff102_Sit_Aberto)
        {
            CSICP_BB001? empresa = await GetEmpresa(in_tenant, in_estabelecimentoID);
            if (empresa == null) throw new Exception("Empresa não encontrada ao gerar financeiro!");

            CSICP_FF003? especie = await GetEspecie(in_tenant, in_especieID);
            if (especie == null) throw new Exception("Espécie não encontrada ao gerar financeiro!");


            decimal nroTitutlo = await _generateProtocolo.Fcn_Protocolo10(in_estabelecimentoID, "CRECEBER", in_tenant);
            string id = _generateID.GenerateUuId();
            CSICP_FF102 entityParaSalvar = new()
            {
                Id = id,
                TenantId = in_tenant,
                Ff102Tiporegistro = 1,
                Ff102Filialid = in_estabelecimentoID,
                Ff102Filial = empresa.Bb001Codigoempresa,
                Ff102Pfx = especie.Ff003Pfx,
                Ff102NoTitulo = nroTitutlo,
                Ff102Sfx = "01",
                Ff102Especieid = in_especieID,
                Ff102Tipoparcelaid = in_StID_ff102_Ent_Parcela,
                Ff102TipoParcela = 1,
                Ff102ParcelaX = 1,
                Ff102ParcelaY = 1,
                Ff102Contaid = in_contaID,
                Ff102Contarealid = in_contaID,
                Ff102Ccustoid = in_ccustoId,
                Ff102Usuarioproprieid = null,
                Ff102Agcobradorid = in_agenteCobrador_id,
                Ff102Responsavelid = in_responsavel_id,
                Ff102Condicaoid = in_condicao_id,
                Ff102Tipocobrancaid = in_tipoCobranca_id,
                Ff102DataEmissao = in_data_emissao,
                Ff102DataVencimento = in_data_vencimento,
                Ff102DataVencReal = in_data_vencimento,
                Ff102ValorTitulo = in_valor_titulo,
                Ff102VlLiqTitulo = in_valor_liquido_titulo,
                Ff102Observacao = "Financeiro gerado automático",
                Ff102Origem = "",
                Ff102Situacaoid = in_StID_ff102_Sit_Aberto,
                Ff102Situacao = in_StID_ff102_Sit_Aberto.ToString(),
                Ff102cpRegistroMarcado = false,
                Ff10FpagtoId = in_forma_pgto_id
            };

            _appDbContext.Add(entityParaSalvar);

            return id;
        }

        private async Task<CSICP_FF003?> GetEspecie(int in_tenant, string? especieID)
        {
            var getEspecie = from ff003 in _appDbContext.OsusrE9aCsicpFf003s
                             where ff003.TenantId == in_tenant
                             where ff003.Id == especieID
                             select new CSICP_FF003
                             {
                                 Ff003Pfx = ff003.Ff003Pfx,
                             };
            CSICP_FF003? especie = await getEspecie.FirstOrDefaultAsync();
            return especie;
        }

        private async Task<CSICP_BB001?> GetEmpresa(int in_tenant, string in_estabelecimentoID)
        {
            var getEmpresa = from bb001 in _appDbContext.E9ACSICP_BB001s
                             where bb001.TenantId == in_tenant
                             where bb001.Id == in_estabelecimentoID
                             select new CSICP_BB001
                             {
                                 Bb001Codigoempresa = bb001.Bb001Codigoempresa,
                             };
            CSICP_BB001? empresa = await getEmpresa.FirstOrDefaultAsync();
            return empresa;
        }

        private async Task<List<CSICP_BB063>> GetListaDeBB063(int in_tenant, long in_bb062_Id)
        {
            var queryMemoria = from bb063 in _appDbContext.CsicpBb063s
                               where bb063.Bb062RefId == in_bb062_Id
                               where bb063.TenantId == in_tenant

                               let somaValorTitulo = _appDbContext.CsicpBb063s
                                   .Where(x => x.Bb063Id == bb063.Bb063Id && x.TenantId == in_tenant)
                                   .Sum(x => x.Bb063Valor ?? 0)

                               select new CSICP_BB063
                               {
                                   TenantId = bb063.TenantId,
                                   Bb063Id = bb063.Bb063Id,
                                   Bb063Convenioid = bb063.Bb063Convenioid,
                                   Bb061Tipoassid = bb063.Bb061Tipoassid,
                                   Bb012Contaid = bb063.Bb012Contaid,
                                   Bb063Valor = somaValorTitulo,
                                   Bb063Custoid = bb063.Bb063Custoid,
                                   Bb063Usuarioproprieid = bb063.Bb063Usuarioproprieid,
                                   Bb063Agcobradorid = bb063.Bb063Agcobradorid,
                                   Bb063Responsavelid = bb063.Bb063Responsavelid,
                                   Bb063Condicaoid = bb063.Bb063Condicaoid,
                                   Bb063Tipocobrancaid = bb063.Bb063Tipocobrancaid,
                                   Ff102Id = bb063.Ff102Id,
                                   Bb062RefId = bb063.Bb062RefId,
                                   Bb063FpagtoId = bb063.Bb063FpagtoId,
                                   Bb063Dependenteid = bb063.Bb063Dependenteid,
                                   Bb063Convmasterid = bb063.Bb063Convmasterid,
                               };

            List<CSICP_BB063> listaBB063 = await queryMemoria.ToListAsync();
            return listaBB063;
        }

        private async Task CS01_Le_Calend_Contas(
            int in_tenant,
            long In_bb062_Id,
            int in_bb1201_con_cartaoInternoID,
            int in_bb062_sta_Fechado_ID)
        {
            var msgErroEtapa1 = "Etapa-1: Periodo não está programado!";
            try
            {
                CSICP_Bb062? calendario_bb062Entity = await GetCalendarioBB062(in_tenant, In_bb062_Id)
                    ?? throw new Exception(msgErroEtapa1);
                List<CSICP_BB012> listaContas = await GetListaContas(in_tenant, in_bb1201_con_cartaoInternoID, calendario_bb062Entity);

                for (int i = 0; i < listaContas.Count; i++)
                {
                    var currentConta = listaContas[i];
                    List<CSICP_Bb061> listaAssociadosConvenio = await GetAssociadosConveniadosBB061(in_tenant, currentConta);
                    for (int j = 0; j < listaAssociadosConvenio.Count; j++)
                    {
                        var currentAssociado = listaAssociadosConvenio[j];
                        CS02_Gera_Memoria(in_tenant, In_bb062_Id, currentAssociado);
                    }
                }

                calendario_bb062Entity.Bb062Statusid = in_bb062_sta_Fechado_ID;
                calendario_bb062Entity.NavBb062Status = null;
                calendario_bb062Entity.NavBB037Diavencto = null;

                _appDbContext.Update(calendario_bb062Entity);
            }
            catch (Exception ex)
            {
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }

        private void CS02_Gera_Memoria(int in_tenant, long In_bb062_Id, CSICP_Bb061 currentAssociado)
        {
            CSICP_BB063 entity = new()
            {
                TenantId = in_tenant,
                Bb062RefId = In_bb062_Id,
                Bb063Convenioid = currentAssociado.Bb060Convenioid,
                Bb061Tipoassid = currentAssociado.Bb061Tipoassid,
                Bb012Contaid = currentAssociado.Bb012Contaid,
                Bb063Valor = currentAssociado.Bb061Valor,
                Bb063Dependenteid = currentAssociado.Bb061Dependenteid,
                Bb063Custoid = currentAssociado.NavBb060Convenio?.Bb060Ccustoid,
                Bb063Agcobradorid = currentAssociado.NavBb060Convenio?.Bb060Agcobradorid,
                Bb063Condicaoid = currentAssociado.NavBb060Convenio?.Bb060Condicaoid,
                Bb063Tipocobrancaid = currentAssociado.NavBb060Convenio?.Bb060Tipocobrancaid,
                Bb063Responsavelid = currentAssociado.NavBb060Convenio?.Bb060Responsavelid,
                Bb063FpagtoId = currentAssociado.NavBb060Convenio?.Bb060FpagtoId,
                Bb063Convmasterid = currentAssociado.NavBb060Convenio?.Bb060Convmasterid,
            };
            _appDbContext.Add(entity);
        }

        private async Task<List<CSICP_BB012>> GetListaContas(int in_tenant, int in_bb1201_con_cartaoInternoID, CSICP_Bb062 calendario_bb062Entity)
        {
            IQueryable<CSICP_BB012> query = from bb012 in _appDbContext.OsusrE9aCsicpBb012s

                                            join bb01201 in _appDbContext.OsusrE9aCsicpBb01201s
                                            on bb012.Id equals bb01201.Id into bb01201Join
                                            from bb01201 in bb01201Join.DefaultIfEmpty()

                                            where bb012.TenantId == in_tenant
                                            where bb012.Bb012IsActive == true
                                            where bb01201.Bb012ConvenioId == in_bb1201_con_cartaoInternoID
                                            where bb01201.Bb012Diavenctoid == calendario_bb062Entity.Bb062Diavenctoid

                                            select new CSICP_BB012
                                            {
                                                Id = bb012.Id,
                                            };

            List<CSICP_BB012> listaContas = await query.ToListAsync();
            return listaContas;
        }

        private async Task<List<CSICP_Bb061>> GetAssociadosConveniadosBB061(int in_tenant, CSICP_BB012 currentConta)
        {
            var queryBB061 = from bb061 in _appDbContext.OsusrE9aCsicpBb061s

                             join bb060 in _appDbContext.OsusrE9aCsicpBb060s
                             on bb061.Bb060Convenioid equals bb060.Bb060Convenioid into bb060Join
                             from bb060 in bb060Join.DefaultIfEmpty()


                             where bb061.TenantId == in_tenant
                             where bb061.Bb012Contaid == currentConta.Id
                             where bb061.Bb061Isactive == true
                             where bb060.Bb060Isactive == true
                             select new CSICP_Bb061
                             {

                                 TenantId = bb061.TenantId,
                                 Bb061Id = bb061.Bb061Id,
                                 Bb060Convenioid = bb061.Bb060Convenioid,
                                 Bb061Tipoassid = bb061.Bb061Tipoassid,
                                 Bb012Contaid = bb061.Bb012Contaid,
                                 Bb061Dependenteid = bb061.Bb061Dependenteid,
                                 Bb061Valor = bb061.Bb061Valor,
                                 Bb061Isactive = bb061.Bb061Isactive,
                                 NavBb060Convenio = bb060 != null ? new CSICP_Bb060
                                 {
                                     TenantId = bb060.TenantId,
                                     Bb060Convenioid = bb060.Bb060Convenioid,
                                     Bb060Codigo = bb060.Bb060Codigo,
                                     Bb060Descricao = bb060.Bb060Descricao,
                                     Bb060Vbase = bb060.Bb060Vbase,
                                     Bb060Ccustoid = bb060.Bb060Ccustoid,
                                     Bb060Usuarioproprieid = bb060.Bb060Usuarioproprieid,
                                     Bb060Agcobradorid = bb060.Bb060Agcobradorid,
                                     Bb060Responsavelid = bb060.Bb060Responsavelid,
                                     Bb060Condicaoid = bb060.Bb060Condicaoid,
                                     Bb060Tipocobrancaid = bb060.Bb060Tipocobrancaid,
                                     Bb060Usuarioinc = bb060.Bb060Usuarioinc,
                                     Bb060Usuarioalt = bb060.Bb060Usuarioalt,
                                     Bb060Dthrinc = bb060.Bb060Dthrinc,
                                     Bb060Dthralt = bb060.Bb060Dthralt,
                                     Bb060Especieid = bb060.Bb060Especieid,
                                     Bb060FpagtoId = bb060.Bb060FpagtoId,
                                     Bb060Isactive = bb060.Bb060Isactive,
                                     Bb060Convmasterid = bb060.Bb060Convmasterid,

                                 } : null,
                             };

            List<CSICP_Bb061> listaBB061 = await queryBB061.ToListAsync();
            return listaBB061;
        }

        private async Task<CSICP_Bb062?> GetCalendarioBB062(int in_tenant, long In_bb062_Id)
        {
            var query = from bb062 in _appDbContext.OsusrE9aCsicpBb062s
                        where bb062.TenantId == in_tenant

                        join bb037 in _appDbContext.OsusrE9aCsicpBb037s
                        on bb062.Bb062Diavenctoid equals bb037.Id into bb037Join
                        from bb037 in bb037Join.DefaultIfEmpty()

                        select new CSICP_Bb062
                        {
                            TenantId = bb062.TenantId,
                            Bb062Id = bb062.Bb062Id,
                            Bb062Ano = bb062.Bb062Ano,
                            Bb062Mes = bb062.Bb062Mes,
                            Bb062Descritivo = bb062.Bb062Descritivo,
                            Bb062Dtemissao = bb062.Bb062Dtemissao,
                            Bb062Diavenctoid = bb062.Bb062Diavenctoid,
                            Bb062Statusid = bb062.Bb062Statusid,
                            Bb062Estabid = bb062.Bb062Estabid,
                            NavBB037Diavencto = bb037 ?? null
                        };
            CSICP_Bb062? bb062Entity = await query.FirstOrDefaultAsync(e => e.Bb062Id == In_bb062_Id);
            return bb062Entity;
        }
    }
}
