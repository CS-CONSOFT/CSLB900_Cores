using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas;
using CSCore.Domain.Interfaces.BB;
using CSCore.Domain.Interfaces.Combo;
using CSCore.Ifs.CS_Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static CSCore.Domain.ComboTypes;

namespace CSCore.Ifs.Repository.Combo
{
    public class NaoEstaticasComboRepositoryImpl(AppDbContext context) :
       IComboRepository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<IEnumerable<object>> GetCommonListForComboAA(int tenant, ComboTypeAA comboType)
        {
            IQueryable<object> query = comboType switch
            {
                ComboTypeAA.Csicp_aa026 => _appDbContext.OsusrE9aCsicpAa026s
                .Where(c => c.TenantId == tenant)
                .OrderBy(c => c.Aa026Descricao)
                .Select(c => new { Title = c.Aa026Descricao ?? "---", c.Id }),


                ComboTypeAA.Csicp_aa029 => _appDbContext.OsusrE9aCsicpAa029s
                    .Where(c => c.TenantId == tenant && c.Aa029Isactive == true)
                    .OrderBy(c => c.Aa029Descricao)
                    .Select(c => new { Title = c.Aa029Descricao + " - " + c.Aa029Cnae ?? "---", Id = c.Aa029Id }),

                ComboTypeAA.Csicp_aa143 => _appDbContext.CSICP_AA143
  
                .OrderBy(c => c.Aa043Artigo)
                .Select(c => new { Title = c.Aa043Artigo + " - " + c.Aa043LcRedacao ?? "---", Id = c.Id }),


                _ => throw new ArgumentOutOfRangeException(nameof(comboType), "Tipo de combo inválido")

            };

            return await query.ToListAsync();
        }


        public async Task<IEnumerable<object>> GetCommonListForComboBB035(int tenant, string bb012)
        {
            var query = from _bb1208 in _appDbContext.OsusrE9aCsicpBb01208s
                        join _bb035 in _appDbContext.OsusrE9aCsicpBb035s
                        on _bb1208.Bb012Contatoid equals _bb035.Id into bb035Group
                        from _bb035 in bb035Group.DefaultIfEmpty()

                        where _bb1208.TenantId == tenant
                        where _bb1208.Bb012Id == bb012
                        where _bb1208.Bb01208IsActive == true

                        select new
                        {
                            Id = _bb1208 != null ? _bb1208.Id : "O VALOR VEIO NULO",
                            Title = _bb035 != null ? _bb035.Bb035Primeironome + " " + _bb035.Bb035Sobrenome : "---",
                        };

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<object>> GetCommonListForComboBB026(int tenant, TIPO_ESPECIE ESPECIE)
        {
            var query = _appDbContext.OsusrE9aCsicpBb026s
                .Where(c => c.TenantId == tenant);
            long idCorrent = 0;
            if (ESPECIE == TIPO_ESPECIE.AReceber)
            {
                idCorrent = _appDbContext.OsusrE9aCsicpFf003Tpesps.Where(e => e.Label == "A Receber").Select(e => e.Id).FirstOrDefault();

            }
            else
            {
                idCorrent = _appDbContext.OsusrE9aCsicpFf003Tpesps.Where(e => e.Label == "A Pagar").Select(e => e.Id).FirstOrDefault();

            }
            query = query.Where(e => e.Bb026Tipoespecie == idCorrent);
            return await query.Select(e => new {Id = e.Id, Title = e.Bb026Formapagamento }).ToListAsync();
        }

        public async Task<IEnumerable<object>> GetCommonListForComboBB008(int tenant, string FormaPagamentoID)
        {
            var query = _appDbContext.OsusrE9aCsicpBb017s
                .Where(e => e.TenantId == tenant && e.Bb017Fpagtoid == FormaPagamentoID)
                .Include(e => e.NavBb008Condicao);
            
            return await query.Select(e => new { Id = e.Bb017Condicaoid, Title = e.NavBb008Condicao!.Bb008CondicaoPagto }).ToListAsync();
        }

        public async Task<IEnumerable<object>> GetCommonListForComboFF(int tenant, ComboTypeFF comboType)
        {
            IQueryable<object> query = comboType switch
            {
                ComboTypeFF.Csicp_ff003 => _appDbContext.OsusrE9aCsicpFf003s
                .Where(c => c.TenantId == tenant)
                .OrderBy(c => c.Ff003Descresumida)
                .Select(c => new { Title = c.Ff003Descresumida ?? "---", c.Id }),

                ComboTypeFF.Csicp_ff002 => _appDbContext.OsusrE9aCsicpFf002s
               .Where(c => c.TenantId == tenant)
               .OrderBy(c => c.Ff002Motivo)
               .Select(c => new { Title = c.Ff002Motivo ?? "---", c.Id }),

                ComboTypeFF.Csicp_ff014 => _appDbContext.OsusrE9aCsicpFf014s
                 .Where(c => c.TenantId == tenant)
                 .OrderBy(c => c.Ff014Descricao)
                 .Select(c => new { Title = c.Ff014Descricao ?? "---", c.Id }),

                 ComboTypeFF.Csicp_ff012 => _appDbContext.OsusrE9aCsicpFf012s
                   .Where(c => c.TenantId == tenant)
                   .OrderBy(c => c.Ff012DescricaoGrupo)
                   .Select(c => new { Title = c.Ff012DescricaoGrupo ?? "---", c.Id }),


                   ComboTypeFF.Csicp_ff019 => _appDbContext.OsusrE9aCsicpFf019s
                   .Where(c => c.TenantId == tenant)
                   .Include(c => c.NavCondicaoPgto)
                   .OrderBy(c => c.Ff019Condicaoid)
                   .Select(c => new { Title = c.NavCondicaoPgto != null ? c.NavCondicaoPgto.Bb008CondicaoPagto : "---", Id =  c.NavCondicaoPgto.Id }),



                _ => throw new ArgumentOutOfRangeException(nameof(comboType), "Tipo de combo inválido")

            };

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<object>> GetCommonListForComboGG(int tenant, ComboTypeGG comboType)
        {
            IQueryable<object> query = comboType switch
            {
                ComboTypeGG.Csicp_GG002 => _appDbContext.OsusrE9aCsicpGg002s.Where(c => c.TenantId == tenant && c.Gg002Isactive == true)
                .OrderBy(c => c.Gg002Desctipoproduto).Select(c => new { Title = c.Gg002Desctipoproduto ?? "---", c.Id }),
                ComboTypeGG.Csicp_GG004 => _appDbContext.OsusrE9aCsicpGg004s.Where(c => c.TenantId == tenant && c.Gg004Isactive == true)
                .OrderBy(c => c.Gg004Descclasse).Select(c => new { Title = c.Gg004Descclasse ?? "---", c.Id }),
                ComboTypeGG.Csicp_GG005 => _appDbContext.OsusrE9aCsicpGg005s.Where(c => c.TenantId == tenant && c.Gg005Isactive == true)
                .OrderBy(c => c.Gg005Descartigo).Select(c => new { Title = c.Gg005Descartigo ?? "---", c.Id }),
                ComboTypeGG.Csicp_GG006 => _appDbContext.OsusrE9aCsicpGg006s.Where(c => c.TenantId == tenant && c.Gg006IsActive == true)
                .OrderBy(c => c.Gg006Descmarca).Select(c => new { Title = c.Gg006Descmarca ?? "---", c.Id }),
                ComboTypeGG.Csicp_GG007 => _appDbContext.OsusrE9aCsicpGg007s.Where(c => c.TenantId == tenant && c.Gg007IsActive == true)
                .OrderBy(c => c.Gg007Descricao).Select(c => new { Title = c.Gg007Descricao ?? "---", c.Id }),
                ComboTypeGG.Csicp_GG009 => _appDbContext.OsusrE9aCsicpGg009s.Where(c => c.TenantId == tenant && c.Gg009IsActive == true)
                .OrderBy(c => c.Gg009Descpadrao).Select(c => new { Title = c.Gg009Descpadrao ?? "---", c.Id }),
                ComboTypeGG.Csicp_GG010 => _appDbContext.OsusrE9aCsicpGg010s.Where(c => c.TenantId == tenant && c.Gg010IsActive == true)
                .OrderBy(c => c.Gg010Descricaotipopadrao).Select(c => new { Title = c.Gg010Descricaotipopadrao ?? "---", c.Id }),
                ComboTypeGG.Csicp_GG011 => _appDbContext.OsusrE9aCsicpGg011s.Where(c => c.TenantId == tenant && c.Gg011IsActive == true)
                .OrderBy(c => c.Gg011Descricaoqualidade).Select(c => new { Title = c.Gg011Descricaoqualidade ?? "---", c.Id }),
                ComboTypeGG.Csicp_GG014 => _appDbContext.OsusrE9aCsicpGg014s.Where(c => c.TenantId == tenant && c.Gg014IsActive == true)
                .OrderBy(c => c.Gg014Linha).Select(c => new { Title = c.Gg014Linha ?? "---", c.Id }),
                ComboTypeGG.Csicp_GG015 => _appDbContext.OsusrE9aCsicpGg015s.Where(c => c.TenantId == tenant && c.Gg015IsActive == true)
                .OrderBy(c => c.Gg015Subgrupo).Select(c => new { Title = c.Gg015Subgrupo ?? "---", c.Id }),
                ComboTypeGG.Csicp_GG021 => _appDbContext.OsusrE9aCsicpGg021s.Where(c => c.TenantId == tenant && c.Gg021IsActive == true)
                .OrderBy(c => c.Gg021Descricao).Select(c => new { Title = c.Gg021Descricao ?? "---", c.Id }),
                ComboTypeGG.Csicp_GG029 => _appDbContext.OsusrE9aCsicpGg029s.Where(c => c.TenantId == tenant)
                .OrderBy(c => c.Gg029Descricao).Select(c => new { Title = c.Gg029Descricao ?? "---", c.Gg029Id }),

                _ => throw new ArgumentOutOfRangeException(nameof(comboType), "Tipo de combo inválido")
            };

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<object>> GetComboGG001(int tenant, string? estabelecimentoId, bool? ignoraVirtual = false)
        {
            var gg001TAlmoxVirtual = await _appDbContext.CSICP_GG001Talmoxes
                .Where(c => c.Label == "Virtual")
                .Select(c => c.Id)
                .FirstAsync();

            IQueryable<CSICP_GG001> query = _appDbContext.CSICP_GG001s
                .Include(e => e.BB001FilialNav)
                .Where(c => c.TenantId == tenant)
                .Where(c => c.Gg001Filialid == estabelecimentoId);

            if (ignoraVirtual.HasValue && ignoraVirtual.Value)
                query = query.Where(c => c.Gg001Tipoalmoxarifado != gg001TAlmoxVirtual);

            query = query.OrderBy(c => c.Gg001Descalmox);
            IQueryable<object> novaQuery = query.Select(c =>
                    new
                    {
                        Title = (c.BB001FilialNav.Bb001Codigoempresa != null
                            ? c.BB001FilialNav.Bb001Codigoempresa.Value.ToString().PadLeft(3, '0')
                            : "---")
                            + "-" + c.Gg001Codigoalmox + "-" + c.Gg001Descalmox,
                        c.Id
                    });
            return await novaQuery.ToListAsync();
        }

        public async Task<IEnumerable<object>> GetCommonListForComboRR(int tenant, ComboTypeRR comboType)
        {
            IQueryable<object> query = comboType switch
            {
                ComboTypeRR.Csicp_RR002 => _appDbContext.OsusrTo3CsicpRr002s
                .Where(c => c.TenantId == tenant)
                .OrderBy(c => c.Rr002Nomefazenda)
                .Select(c => new { Title = c.Rr002Nomefazenda ?? "---", c.Id }),

                ComboTypeRR.Csicp_RR003 => _appDbContext.OsusrTo3CsicpRr003s
                .Where(c => c.TenantId == tenant)
                .OrderBy(c => c.Rr003Descricao)
                .Select(c => new { Title = c.Rr003Descricao ?? "---", c.Id }),

                ComboTypeRR.Csicp_RR004 => _appDbContext.OsusrTo3CsicpRr004s
                .Where(c => c.TenantId == tenant)
                .OrderBy(c => c.Rr004Raca)
                .Select(c => new { Title = c.Rr004Raca, c.Id }),

                ComboTypeRR.Csicp_RR005 => _appDbContext.OsusrTo3CsicpRr005s
                .Where(c => c.TenantId == tenant)
                .OrderBy(c => c.Rr005Situacao)
                .Select(c => new { Title = c.Rr005Situacao, c.Id }),

                ComboTypeRR.Csicp_RR006 => _appDbContext.OsusrTo3CsicpRr006s
                .Where(c => c.TenantId == tenant)
                .OrderBy(c => c.Rr006Ocorrencia)
                .Select(c => new { Title = c.Rr006Ocorrencia, c.Id }),

                ComboTypeRR.Csicp_RR007 => _appDbContext.OsusrTo3CsicpRr007s
                .Where(c => c.TenantId == tenant)
                .OrderBy(c => c.Rr007Proprietario)
                .Select(c => new { Title = c.Rr007Proprietario, c.Id }),

                ComboTypeRR.Csicp_RR008 => _appDbContext.OsusrTo3CsicpRr008s
                .Where(c => c.TenantId == tenant)
                .OrderBy(c => c.Rr008Regalimentar)
                .Select(c => new { Title = c.Rr008Regalimentar, c.Id }),

                _ => throw new ArgumentOutOfRangeException(nameof(comboType), "Tipo de combo inválido")
            };
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<object>> GetCommonListForComboBB(int tenant, ComboTypeBB ComboTypeBB)
        {
            IQueryable<object> query = ComboTypeBB switch
            {
                ComboTypeBB.CSICP_BB001_Fantasia => _appDbContext.E9ACSICP_BB001s
                   .Where(c => c.TenantId == tenant)
                   .OrderBy(c => c.Bb001Nomefantasia)
                   .Select(c => new { Title = c.Bb001Nomefantasia, c.Id }),

                ComboTypeBB.CSICP_BB001_Fantasia_Codg => _appDbContext.E9ACSICP_BB001s
               .Where(c => c.TenantId == tenant)
               .OrderBy(c => c.Bb001Nomefantasia)
               .Select(c => new { Title = c.Bb001Nomefantasia + "-" + c.Bb001Codigoempresa, Id = c.Id }),

                ComboTypeBB.CSICP_BB001_Razao => _appDbContext.E9ACSICP_BB001s
                   .Where(c => c.TenantId == tenant)
                   .OrderBy(c => c.Bb001Razaosocial)
                   .Select(c => new { Title = c.Bb001Razaosocial, c.Id }),

                ComboTypeBB.CSICP_BB001_Razao_Codg => _appDbContext.E9ACSICP_BB001s
               .Where(c => c.TenantId == tenant)
               .OrderBy(c => c.Bb001Razaosocial)
               .Select(c => new { Title = c.Bb001Razaosocial + "-" + c.Bb001Codigoempresa, c.Id }),

                ComboTypeBB.CSICP_BB002 => _appDbContext.OsusrE9aCsicpBb002s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb002Grupoempresa)
                    .Select(c => new { Title = c.Bb002Grupoempresa, c.Id }),

                ComboTypeBB.CSICP_BB003 => _appDbContext.OsusrE9aCsicpBb003s
                .Where(c => c.TenantId == tenant)
                .Select(c => new { Title = c.Bb003Moeda, c.Id }),

                ComboTypeBB.Csicp_bb005 => _appDbContext.OsusrE9aCsicpBb005s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb005Nomeccusto)
                    .Select(c => new { Title = c.Bb005Nomeccusto, c.Id }),

                ComboTypeBB.Csicp_bb006 => _appDbContext.OsusrE9aCsicpBb006s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb006Banco)
                    .Select(c => new { Title = c.Bb006Nomereduzido, c.Id }),

                ComboTypeBB.Csicp_bb006_Codg => _appDbContext.OsusrE9aCsicpBb006s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb006Codgbanco)
                    .Select(c => new { Title = c.Bb006Codgbanco, c.Id }),

                ComboTypeBB.Csicp_bb006_Nome_Codg => _appDbContext.OsusrE9aCsicpBb006s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb006Banco)
                    .Select(c => new { Title = c.Bb006Nomereduzido + "-" + c.Bb006Codgbanco, c.Id }),

                ComboTypeBB.Csicp_bb007 => _appDbContext.OsusrE9aCsicpBb007s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb007Responsavel)
                    .Select(c => new { Title = c.Bb007Responsavel, c.Id }),

                ComboTypeBB.Csicp_bb008 => _appDbContext.OsusrE9aCsicpBb008s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb008CondicaoPagto)
                    .Select(c => new { Title = c.Bb008CondicaoPagto, c.Id }),

                ComboTypeBB.Csicp_bb009 => _appDbContext.OsusrE9aCsicpBb009s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb009Tipocobranca)
                    .Select(c => new { Title = c.Bb009Tipocobranca + " - " + c.Bb009Codigo, c.Id }),

                ComboTypeBB.Csicp_bb010 => _appDbContext.OsusrE9aCsicpBb010s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb010Zona)
                    .Select(c => new { Title = c.Bb010Zona, c.Id }),

                ComboTypeBB.Csicp_bb011 => _appDbContext.OsusrE9aCsicpBb011s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb011Atividade)
                    .Select(c => new { Title = c.Bb011Atividade, c.Id }),

                ComboTypeBB.Csicp_bb019 => _appDbContext.OsusrE9aCsicpBb019s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb019Administradora)
                    .Select(c => new { Title = c.Bb019Administradora, c.Id }),

                ComboTypeBB.Csicp_bb025 => _appDbContext.OsusrE9aCsicpBb025s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb025Descricao)
                    .Select(c => new { Title = c.Bb025Descricao, c.Id }),

                ComboTypeBB.Csicp_bb026 => _appDbContext.OsusrE9aCsicpBb026s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb026Formapagamento)
                    .Select(c => new { Title = c.Bb026Formapagamento, c.Id }),

                ComboTypeBB.Csicp_bb027 => _appDbContext.OsusrE9aCsicpBb027s
                      .Where(c => c.TenantId == tenant)
                      .OrderBy(c => c.Bb027Descricao)
                      .Select(c => new { Title = c.Bb027Descricao, c.Id }),

                ComboTypeBB.Csicp_bb029 => _appDbContext.OsusrE9aCsicpBb029s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb029Categoria)
                    .Select(c => new { Title = c.Bb029Categoria, c.Id }),

                ComboTypeBB.Csicp_bb031 => _appDbContext.OsusrE9aCsicpBb031s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb031Descricao)
                    .Select(c => new { Title = c.Bb031Descricao, c.Id }),

                ComboTypeBB.Csicp_bb032 => _appDbContext.OsusrE9aCsicpBb032s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb032Cargo)
                    .Select(c => new { Title = c.Bb032Cargo, c.Id }),

                ComboTypeBB.Csicp_bb035 => _appDbContext.OsusrE9aCsicpBb035s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb035Descricao)
                    .Select(c => new { Title = c.Bb035Primeironome + " " + c.Bb035Sobrenome, c.Id }),

                ComboTypeBB.Csicp_bb037 => _appDbContext.OsusrE9aCsicpBb037s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb037Descricao)
                    .Select(c => new { Title = c.Bb037Descricao, c.Id }),

                ComboTypeBB.Csicp_bb060 => _appDbContext.OsusrE9aCsicpBb060s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb060Descricao)
                    .Select(c => new { Title = c.Bb060Descricao, Id = c.Bb060Convenioid }),

                ComboTypeBB.Csicp_bb067 => _appDbContext.OsusrE9aCsicpBb067s
                    .Where(c => c.TenantId == tenant)
                    .OrderBy(c => c.Bb067Descricao)
                    .Select(c => new { Title = c.Bb067Descricao, Id = c.Bb067Id }),

                _ => throw new ArgumentException($"Tipo de combo não suportado: {ComboTypeBB}")
            };

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<object>> GetCommonListForComboCidade(string? ufId, string? search, int tenant)
        {
            IQueryable<CSICP_Aa028> queryCidade = _appDbContext.OsusrE9aCsicpAa028s
                .Where(e => e.TenantId == tenant).AsQueryable();

            if (ufId != null)
            {
                queryCidade = queryCidade.Where(e => e.Ufid == ufId);
            }
            if (search != null)
            {
                queryCidade = queryCidade.Where(e => e.Aa028Cidade != null && e.Aa028Cidade.Contains(search));
            }

            return await queryCidade
            .OrderBy(c => c.Aa028Cidade)
            .Select(c => new { Title = c.Aa028Cidade, Id = c.Id })
            .AsQueryable()
            .ToListAsync();
        }


        public async Task<IEnumerable<object>> GetCommonListForComboPais(int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpAa025s
                               .Where(c => c.Aa025Isactive == true && c.TenantId == tenant)
                               .OrderBy(c => c.Aa025Descricao)
                               .Select(c => new { Title = c.Aa025Descricao, Id = c.Id })
                               .AsQueryable()
                               .ToListAsync();
        }

        public async Task<IEnumerable<object>> GetCommonListForComboUF(int tenant, string? paisId)
        {
            IQueryable<CSICP_Aa027> queryUF = _appDbContext.OsusrE9aCsicpAa027s
                   .Where(c => c.TenantId == tenant).AsQueryable();


            if (paisId != null)
            {
                queryUF = queryUF.Where(e => e.Paisid == paisId);
            }

            return await queryUF
                  .OrderBy(c => c.Aa027Sigla)
                  .Select(c => new { Title = c.Aa027Sigla, Id = c.Id })
                  .AsQueryable()
                  .ToListAsync();
        }

        public async Task<IEnumerable<object>> GetCommonListForComboSYS(int tenant, ComboTypeSYS comboType)
        {
            IQueryable<object> query = comboType switch
            {
                ComboTypeSYS.Csicp_SY001 => _appDbContext.OsusrE9aCsicpSy001s
                .Where(c => c.TenantId == tenant)
                .OrderBy(c => c.Sy001Nome)
                .Select(c => new { Title = c.Sy001Nome ?? "---", c.Id }),


                _ => throw new ArgumentOutOfRangeException(nameof(comboType), "Tipo de combo inválido")

            };

            return await query.ToListAsync();
        }


        public async Task<IEnumerable<CSICP_Email>> GetComboStaticaEmail()
        {
            List<CSICP_Email> cSICP_Emails =
                await _appDbContext.OsusrE9aCsicpEmails
                .Where(e => e.IsActive == true)
                .ToListAsync();

            return cSICP_Emails;
        }

        public async Task<IEnumerable<object>> GetCommonListForComboBB001(
            int tenant, string sy001_usuarioID, ComboTypeBB001 comboTypeBB)
        {

            IQueryable<object> query = comboTypeBB switch
            {
                ComboTypeBB001.CSICP_BB001_Fantasia => query = from sy013 in _appDbContext.OsusrE9aCsicpSy013s

                                                               join bb001 in _appDbContext.E9ACSICP_BB001s
                                                               on sy013.Sy013Filialid equals bb001.Id

                                                               join sy001 in _appDbContext.OsusrE9aCsicpSy001s
                                                               on sy013.Sy013Usuarioid equals sy001.Id

                                                               where bb001.TenantId == tenant && sy001.Id == sy001_usuarioID

                                                               select new
                                                               {
                                                                   Id = bb001.Id,
                                                                   Title = bb001.Bb001Nomefantasia
                                                               },

                ComboTypeBB001.CSICP_BB001_Fantasia_Codg => query = from sy013 in _appDbContext.OsusrE9aCsicpSy013s

                                                                    join bb001 in _appDbContext.E9ACSICP_BB001s
                                                                    on sy013.Sy013Filialid equals bb001.Id

                                                                    join sy001 in _appDbContext.OsusrE9aCsicpSy001s
                                                                    on sy013.Sy013Usuarioid equals sy001.Id

                                                                    where bb001.TenantId == tenant && sy001.Id == sy001_usuarioID

                                                                    select new
                                                                    {
                                                                        Id = bb001.Id,
                                                                        Title = bb001.Bb001Nomefantasia + "-" + bb001.Bb001Codigoempresa
                                                                    },

                ComboTypeBB001.CSICP_BB001_Razao => query = from sy013 in _appDbContext.OsusrE9aCsicpSy013s

                                                            join bb001 in _appDbContext.E9ACSICP_BB001s
                                                            on sy013.Sy013Filialid equals bb001.Id

                                                            join sy001 in _appDbContext.OsusrE9aCsicpSy001s
                                                            on sy013.Sy013Usuarioid equals sy001.Id

                                                            where bb001.TenantId == tenant && sy001.Id == sy001_usuarioID

                                                            select new
                                                            {
                                                                Id = bb001.Id,
                                                                Title = bb001.Bb001Razaosocial
                                                            },

                ComboTypeBB001.CSICP_BB001_Razao_Codg => query = from sy013 in _appDbContext.OsusrE9aCsicpSy013s

                                                                 join bb001 in _appDbContext.E9ACSICP_BB001s
                                                                 on sy013.Sy013Filialid equals bb001.Id

                                                                 join sy001 in _appDbContext.OsusrE9aCsicpSy001s
                                                                 on sy013.Sy013Usuarioid equals sy001.Id

                                                                 where bb001.TenantId == tenant && sy001.Id == sy001_usuarioID

                                                                 select new
                                                                 {
                                                                     Id = bb001.Id,
                                                                     Title = bb001.Bb001Razaosocial + "-" + bb001.Bb001Codigoempresa
                                                                 },


                _ => throw new ArgumentException($"Tipo de combo não suportado: {comboTypeBB}")
            };

            return await query.ToListAsync();
        }

        public Task<IEnumerable<object>> GetCommonListForComboBB001(int tenant, ComboTypeBB comboType)
        {
            throw new NotImplementedException();
        }
    }
}
