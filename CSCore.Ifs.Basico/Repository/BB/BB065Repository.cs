using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB065Repository(AppDbContext context) : IBB065Repository
    {
        private readonly AppDbContext _appDbContext = context;
        private enum DataAniversarioStatus
        {
            Nulo,
            Ok
        }

        public async Task AtualizaFxEtaria(
            int in_tenant,
            long in_bb064_ID,
            int in_StId_csicp_bb061_tp_Titular,
            int in_StId_csicp_bb061_tp_Dependente)
        {

            List<CSICP_Bb065>? listFaixaEtaria = await (from bb065 in _appDbContext.OsusrE9aCsicpBb065s.AsNoTracking()
                                                        where bb065.TenantId == in_tenant && bb065.Bb064Fxetariaid == in_bb064_ID

                                                        select new CSICP_Bb065
                                                        {
                                                            TenantId = in_tenant,
                                                            Bb065Id = bb065.Bb065Id,
                                                            Bb064Fxetariaid = in_bb064_ID,
                                                            Bb062Convenioid = bb065.Bb062Convenioid,
                                                        }).ToListAsync();


            for (int i = 0; i < listFaixaEtaria.Count; i++)
            {
                var currentFaixaEtaria = listFaixaEtaria[i];

                await CS_AtualizaFaixaEtaria(
                    in_tenant,
                    currentFaixaEtaria,
                    in_StId_csicp_bb061_tp_Titular,
                    in_StId_csicp_bb061_tp_Dependente);

            }
        }

        private async Task CS_AtualizaFaixaEtaria(
            int in_tenant,
            CSICP_Bb065 currentFaixaEtaria,
            int in_StId_csicp_bb061_tp_Titular,
            int in_StId_csicp_bb061_tp_Dependente
            )
        {
            var listaAssociadosConvenio = await _appDbContext.OsusrE9aCsicpBb061s
                            .Where(bb061 => bb061.TenantId == in_tenant
                                && bb061.Bb060Convenioid == currentFaixaEtaria.Bb062Convenioid
                                && bb061.Bb061Isactive == true)
                            .ToListAsync();


            for (int i = 0; i < listaAssociadosConvenio.Count; i++)
            {
                var currentAssociadoConv = listaAssociadosConvenio[i];

                DataAniversarioStatus dataAniversarioStatusCorrente = DataAniversarioStatus.Ok;
                decimal valorFaixaEtariaTitularCorrente = 0;

                if (EhTipoAssociadoTitular(in_StId_csicp_bb061_tp_Titular, currentAssociadoConv.Bb061Tipoassid))
                {
                    (DataAniversarioStatus statusDataAniversarioRetornado, decimal valorFaixaEtariaTitularCorrenteRetornado) =
                        await CalculaFaixaEtariaTitular(in_tenant, currentAssociadoConv);

                    dataAniversarioStatusCorrente = statusDataAniversarioRetornado;
                    valorFaixaEtariaTitularCorrente = valorFaixaEtariaTitularCorrenteRetornado;
                }


                if (EhTipoAssociadoDependente(in_StId_csicp_bb061_tp_Dependente, currentAssociadoConv.Bb061Tipoassid))
                {
                    (DataAniversarioStatus statusDataAniversarioRetornado, decimal valorFaixaEtariaDependenteCorrenteRetornado)
                        = await CalculaValorFaixaEtariaDependente(in_tenant, currentAssociadoConv);

                    dataAniversarioStatusCorrente = statusDataAniversarioRetornado;
                    valorFaixaEtariaTitularCorrente = valorFaixaEtariaDependenteCorrenteRetornado;
                }

                if (dataAniversarioStatusCorrente == DataAniversarioStatus.Nulo) continue;
                currentAssociadoConv.Bb061Valor = valorFaixaEtariaTitularCorrente;


                _appDbContext.Update(currentAssociadoConv);
                await _appDbContext.SaveChangesAsync();
            }
        }



        public async Task<CSICP_Bb065> CreateAsync(CSICP_Bb065 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb065?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb065>> GetListAsync(int tenant)
        {
            IQueryable<CSICP_Bb065> q1 = CreateBaseQuery(tenant).AsQueryable();
            return await q1.ToListAsync();
        }

        public async Task<IEnumerable<CSICP_Bb065>> GetListAsyncPorBB064id(long bb064ID, int tenant)
        {
            IQueryable<CSICP_Bb065> q1 = CreateBaseQuery(tenant).Include(e => e.Bb062Convenio).AsQueryable();
            IQueryable<CSICP_Bb065> q2 = q1.Where(e => e.Bb064Fxetariaid == bb064ID);
            return await q2.ToListAsync();
        }

        public async Task<CSICP_Bb065> RemoveAsync(CSICP_Bb065 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb065> UpdateAsync(CSICP_Bb065 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private IQueryable<CSICP_Bb065> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb065s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_Bb065?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Bb065Id == long.Parse(id));
        }




        private async Task<DateTime?> GetDataAniversarioDependenteAsync(int in_tenant, string? in_Bb061Dependenteid)
        {
            return await (from bb1208 in _appDbContext.OsusrE9aCsicpBb01208s.AsNoTracking()

                          join bb035 in _appDbContext.OsusrE9aCsicpBb035s.AsNoTracking()
                          on bb1208.Bb012Contatoid equals bb035.Id into bb035Join
                          from bb035 in bb035Join.DefaultIfEmpty()

                          where bb1208.TenantId == in_tenant
                          && bb1208.Bb01208IsActive == true
                          && bb1208.Id == in_Bb061Dependenteid
                          select bb035.Bb035DataAniversario).FirstOrDefaultAsync();
        }

        private async Task<DateTime?> GetDataAniversarioTitularAsync(int in_tenant, string? in_Bb012Contaid)
        {
            return await (from bb012 in _appDbContext.OsusrE9aCsicpBb012s.AsNoTracking()
                          where bb012.TenantId == in_tenant
                          && bb012.Bb012IsActive == true
                          && bb012.Id == in_Bb012Contaid
                          select bb012.Bb012DataAniversario).FirstOrDefaultAsync();
        }

        private static bool EhTipoAssociadoDependente(int in_StId_csicp_bb061_tp_Dependente, int? in_Bb061Tipoassid)
        {
            return in_Bb061Tipoassid == in_StId_csicp_bb061_tp_Dependente;
        }

        private static bool EhTipoAssociadoTitular(int in_StId_csicp_bb061_tp_Titular, int? in_Bb061Tipoassid)
        {
            return in_Bb061Tipoassid == in_StId_csicp_bb061_tp_Titular;
        }


        /// <summary>Realiza o calculo do valor da faixa etaria e retorna o valor da faixa etaria para atualizar na tabela 
        /// BB061 Vinculo Convenios e Associados, Dependentes.
        /// </summary>
        /// 
        /// <returns> Retorna o status da data de aniversario, informando se a data de aniversário é nul. 
        /// E retorna a propriedade valor da BB066, que é a tabela Detalhe Faixa Etaria, 
        /// para então usar esse valor para atualizar a tabela BB061 Vinculo Convenios e Associados, Dependentes, com o novo valor
        /// </returns>
        private async Task<(DataAniversarioStatus, decimal)> CalcularValorFaixaEtariaAsync(
            int in_tenant, long? in_bb060_ConvenioID, DateTime? dependenteDataAniversario)
        {
            if (DataAniversarioEhNula(dependenteDataAniversario)) return (DataAniversarioStatus.Nulo, 0);

            double idadeDependente = CalcularIdade(dependenteDataAniversario);

            decimal? valorFaixaEtaria = await BuscarValorFaixaEtariaAsync(in_tenant, in_bb060_ConvenioID ?? 0, idadeDependente);

            return (DataAniversarioStatus.Ok, valorFaixaEtaria ?? 0);
        }



        /// <summary>Recupera a data de aniversario do dependente e Chama o método CalcularValorFaixaEtariaAsync para um Depedente, 
        /// retornando o status da data de aniversario, informando se a data de aniversário é null.
        /// </summary>
        /// 
        /// <returns> Retorna o status da data de aniversario, informando se a data de aniversário é nul. 
        /// E retorna a propriedade valor da BB066, que é a tabela Detalhe Faixa Etaria, 
        /// para então usar esse valor para atualizar a tabela BB061 Vinculo Convenios e Associados, Dependentes, com o novo valor
        /// </returns>
        private async Task<(DataAniversarioStatus, decimal)> CalculaValorFaixaEtariaDependente(int in_tenant, CSICP_Bb061 currentAssociadoConv)
        {
            DateTime? dependenteDataAniversario =
                     await GetDataAniversarioDependenteAsync(in_tenant, currentAssociadoConv.Bb061Dependenteid);

            return await CalcularValorFaixaEtariaAsync(
                    in_tenant,
                    currentAssociadoConv.Bb060Convenioid,
                    dependenteDataAniversario
                    );


        }



        /// <summary>Recupera a data de aniversario do titular e Chama o método CalcularValorFaixaEtariaAsync para um Depedente, 
        /// retornando o status da data de aniversario, informando se a data de aniversário é null.
        /// </summary>
        /// 
        /// <returns> Retorna o status da data de aniversario, informando se a data de aniversário é nul. 
        /// E retorna a propriedade valor da BB066, que é a tabela Detalhe Faixa Etaria, 
        /// para então usar esse valor para atualizar a tabela BB061 Vinculo Convenios e Associados, Dependentes, com o novo valor
        /// </returns>
        private async Task<(DataAniversarioStatus, decimal)> CalculaFaixaEtariaTitular(int in_tenant, CSICP_Bb061 currentAssociadoConv)
        {
            DateTime? titularDataAniversario =
                                    await GetDataAniversarioTitularAsync(in_tenant, currentAssociadoConv.Bb012Contaid);

            return await CalcularValorFaixaEtariaAsync(
                    in_tenant,
                    currentAssociadoConv.Bb060Convenioid,
                    titularDataAniversario
                    );
        }


        private async Task<decimal?> BuscarValorFaixaEtariaAsync(int in_tenant, long in_bb060_ConvenioID, double idade)
        {
            return await (from bb065 in _appDbContext.OsusrE9aCsicpBb065s.AsNoTracking()

                          join bb066 in _appDbContext.OsusrE9aCsicpBb066s.AsNoTracking()
                          on bb065.Bb064Fxetariaid equals bb066.Bb066Fxetariaid into bb066Join
                          from bb066 in bb066Join.DefaultIfEmpty()

                          where bb065.TenantId == in_tenant
                          && bb065.Bb062Convenioid == in_bb060_ConvenioID
                          && idade >= bb066.Bb066Faixade
                          && idade <= bb066.Bb066Faixaate

                          select bb066.Bb066Valor)
                                         .FirstOrDefaultAsync();
        }

        private bool DataAniversarioEhNula(DateTime? data)
        {
            if (data.ToString() == "01-01-1900" || data == null) return true;
            return false;
        }

        public double CalcularIdade(DateTime? dataAniversario)
            => DateTime.UtcNow.ToLocalTime().Subtract(dataAniversario!.Value).Divide(new TimeSpan(365, 0, 0, 0));
    }
}

