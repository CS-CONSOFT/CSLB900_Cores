using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.Interfaces.DD._06X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.EnviaNFeHercules.Repository.DD06X
{
    public class DD060RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_DD060>(appDbContext, "Dd060Id"), IDD060Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<(List<CSICP_DD060>, int)> GetListAsync(
            int in_tenant, string in_dd040id, int in_page, int in_pageSize)
        {
            var query = from dd060 in _appDbContext.OsusrTeiCsicpDd060s

                        where dd060.TenantId == in_tenant
                        && dd060.Dd040Id == in_dd040id

                        join gg520 in _appDbContext.OsusrE9aCsicpGg520s
                        on dd060.Dd060Saldoid equals gg520.Id into dd060_gg520_join
                        from gg520 in dd060_gg520_join.DefaultIfEmpty()

                        join gg008Kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes
                        on gg520.Gg520KardexId equals gg008Kdx.Gg008Kardexid into dd060_gg008Kdx_join
                        from gg008Kdx in dd060_gg008Kdx_join.DefaultIfEmpty()

                        // AQUI TINHA UM JOIN COMENTADO, VERIFICAR SE VAI SER USADO DEPOIS
                        /*join gg008Kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes
                        on new { ProdutoId = dd060.Dd060Produtoid }
                        equals new { ProdutoId = gg008Kdx.Gg008Produtoid } into gg008Kdx_dd060_join 
                        from gg008Kdx in gg008Kdx_dd060_join.DefaultIfEmpty()*/

                        join gg008Produto in _appDbContext.OsusrE9aCsicpGg008s
                        on dd060.Dd060Produtoid equals gg008Produto.Id into dd060_gg008Produto_join
                        from gg008Produto in dd060_gg008Produto_join.DefaultIfEmpty()

                        join gg005 in _appDbContext.OsusrE9aCsicpGg005s
                        on gg008Produto.Gg008Artigoid equals gg005.Id into gg008Produto_gg005_join
                        from gg005 in gg008Produto_gg005_join.DefaultIfEmpty()

                        join gg006 in _appDbContext.OsusrE9aCsicpGg006s
                        on gg008Produto.Gg008Marcaid equals gg006.Id into gg008Produto_gg006_join
                        from gg006 in gg008Produto_gg006_join.DefaultIfEmpty()

                            //------Leitura da DD061Cfgimp e tabelas relacionadas------------//
                        join dd061_cfgimp in _appDbContext.OsusrTeiCsicpDd061Cfgimps
                        on dd060.Dd060Id equals dd061_cfgimp.Dd060Id into dd060_dd061_cfgimp_join
                        from dd061_cfgimp in dd060_dd061_cfgimp_join.DefaultIfEmpty()

                        join aa031_cstori in _appDbContext.E9ACSICP_AA031Cstoris
                        on dd061_cfgimp.Dd061Bb027bOrigemId equals aa031_cstori.Id into dd061_cfgimp_aa031_cstori_join
                        from aa031_cstori in dd061_cfgimp_aa031_cstori_join.DefaultIfEmpty()

                        join aa032_csticm in _appDbContext.E9ACSICP_AA032Csticms
                        on dd061_cfgimp.Dd061Bb027bCstIcmsId equals aa032_csticm.Id into dd061_cfgimp_aa032_csticm_join
                        from aa032_csticm in dd061_cfgimp_aa032_csticm_join.DefaultIfEmpty()

                        join bb027_modal in _appDbContext.OsusrE9aCsicpBb027Modals
                        on dd061_cfgimp.Dd061Bb027bModbcId equals bb027_modal.Id into dd061_cfgimp_bb027_modal_join
                        from bb027_modal in dd061_cfgimp_bb027_modal_join.DefaultIfEmpty()

                        join aa038_modst in _appDbContext.E9ACSICP_AA038Modsts
                        on dd061_cfgimp.Dd061Bb027bModalbcIcmsSt equals aa038_modst.Id into dd061_cfgimp_aa038_modst_join
                        from aa038_modst in dd061_cfgimp_aa038_modst_join.DefaultIfEmpty()

                        join bb027_motivo in _appDbContext.OsusrE9aCsicpBb027Motivos
                        on dd061_cfgimp.Dd061Bb027bMotdesoneracao equals bb027_motivo.Id into dd061_cfgimp_bb027_motivo_join
                        from bb027_motivo in dd061_cfgimp_bb027_motivo_join.DefaultIfEmpty()

                        join aa033_cstipi in _appDbContext.E9ACSICP_AA033Cstipis
                        on dd061_cfgimp.Dd061Bb027bCstIpiId equals aa033_cstipi.Id into dd061_cfgimp_aa033_cstipi_join
                        from aa033_cstipi in dd061_cfgimp_aa033_cstipi_join.DefaultIfEmpty()

                        join aa034_cstpis in _appDbContext.E9ACSICP_AA034Cstpis
                        on dd061_cfgimp.Dd061Bb027bCstPisId equals aa034_cstpis.Id into dd061_cfgimp_aa034_cstpis_join
                        from aa034_cstpis in dd061_cfgimp_aa034_cstpis_join.DefaultIfEmpty()

                        join aa035_cstcof in _appDbContext.E9ACSICP_AA035Cstcofs
                        on dd061_cfgimp.Dd061Bb027bCstCofinsId equals aa035_cstcof.Id into dd061_cfgimp_aa035_cstcof_join
                        from aa035_cstcof in dd061_cfgimp_aa035_cstcof_join.DefaultIfEmpty()

                        join spedInCfop in _appDbContext.Osusr66cSpedInCfops
                        on dd061_cfgimp.Dd061Bb027bCfopStaticaId equals spedInCfop.Id into dd061_cfgimp_spedInCfop_join
                        from spedInCfop in dd061_cfgimp_spedInCfop_join.DefaultIfEmpty()

                        //fazer dto e mapeamento
                        join aa144_classtrib in _appDbContext.OsusrE9aCsicpAa144s
                        on dd061_cfgimp.Ub13Ub14RfclasstribId equals aa144_classtrib.Id into dd061_cfgimp_aa144_classtrib_join
                        from aa144_classtrib in dd061_cfgimp_aa144_classtrib_join.DefaultIfEmpty()

                        join aa143_leicomp in _appDbContext.CSICP_AA143
                        on dd061_cfgimp.Dd061RflcId equals aa143_leicomp.Id into dd061_cfgimp_aa143_leicomp_join
                        from aa143_leicomp in dd061_cfgimp_aa143_leicomp_join.DefaultIfEmpty()

                        join aa144_ISclasstrib in _appDbContext.OsusrE9aCsicpAa144s
                        on dd061_cfgimp.Ub03IsRfclasstribId equals aa144_ISclasstrib.Id into dd061_cfgimp_aa144_ISclasstrib_join
                        from aa144_ISclasstrib in dd061_cfgimp_aa144_ISclasstrib_join.DefaultIfEmpty()

                        join aa144_tribreg in _appDbContext.OsusrE9aCsicpAa144s
                        on dd061_cfgimp.Ub6970RfclasstribregId equals aa144_tribreg.Id into dd061_cfgimp_aa144_tribreg_join
                        from aa144_tribreg in dd061_cfgimp_aa144_tribreg_join.DefaultIfEmpty()

                        join aa150_ccredpres in _appDbContext.OsusrE9aCsicpAa150Ccredpres
                        on dd061_cfgimp.Ub7479Ccredpresid equals aa150_ccredpres.Id into dd061_cfgimp_aa150_ccredpres_join
                        from aa150_ccredpres in dd061_cfgimp_aa150_ccredpres_join.DefaultIfEmpty()

                        join bb027_reforma in _appDbContext.OsusrE9aCsicpBb027s
                        on dd061_cfgimp.Dd061RfBb027Id equals bb027_reforma.Id into dd061_cfgimp_bb027_reforma_join
                        from bb027_reforma in dd061_cfgimp_bb027_reforma_join.DefaultIfEmpty()

                            //-----------------------FINAL--------------------------//
                        join gg021 in _appDbContext.OsusrE9aCsicpGg021s
                        on gg008Produto.Gg008Ncmid equals gg021.Id into gg008Produto_gg021_join
                        from gg021 in gg008Produto_gg021_join.DefaultIfEmpty()

                        join gg007 in _appDbContext.OsusrE9aCsicpGg007s
                        on dd060.Dd060UnId equals gg007.Id into dd060_gg007_join
                        from gg007 in dd060_gg007_join.DefaultIfEmpty()

                        join gg007_UNSec in _appDbContext.OsusrE9aCsicpGg007s
                        on dd060.Dd060UnSecId equals gg007_UNSec.Id into dd060_gg007_UNSec_join
                        from gg007_UNSec in dd060_gg007_UNSec_join.DefaultIfEmpty()

                        join spedIncenq_IPI in _appDbContext.Osusr66cSpedInCenqIpis
                        on dd061_cfgimp.Dd061Bb027bCenquadIpiId equals spedIncenq_IPI.Id into dd061_cfgimp_in_cEnq_IPI_join
                        from spedIncenq_IPI in dd061_cfgimp_in_cEnq_IPI_join.DefaultIfEmpty()

                        join gg021cest in _appDbContext.OsusrE9aCsicpGg021cests
                        on gg021.Gg021CestId equals gg021cest.Id into gg021_gg021cest_join
                        from gg021cest in gg021_gg021cest_join.DefaultIfEmpty()

                        join stRelevancia in _appDbContext.OsusrSpedNnxCsicpStrelevancia
                        on dd060.Dd060Ierelevanteid equals stRelevancia.Id into dd060_stRelevancia_join
                        from stRelevancia in dd060_stRelevancia_join.DefaultIfEmpty()

                        /*UTILIZANDO TÉCNICA LET PARA EVITAR REGISTROS DUPLICADOS NA QUERY, A DD061 É UMA FILHA DA DD060,
                         O LET AJUDA A EVITAR JOIN DIRETO E FOREACH PRA PEGAR CADA UMA E INSERIR NA DD060
                         */
                        let listdd061 = (from dd061 in _appDbContext.OsusrTeiCsicpDd061s

                                         join aa037Imp in _appDbContext.E9ACSICP_AA037Imps
                                         on dd061.Dd061ImpostoId equals aa037Imp.Id into dd061_aa037Imp_join
                                         from aa037Imp in dd061_aa037Imp_join.DefaultIfEmpty()

                                         //fazer dto e mapeamento
                                         join aa027Uf in _appDbContext.OsusrE9aCsicpAa027s // apenas o campo sigla
                                         on dd061.UB17_UFID equals aa027Uf.Id into dd061_aa027Uf_join
                                         from aa027Uf in dd061_aa027Uf_join.DefaultIfEmpty()

                                         join aa028cidade in _appDbContext.OsusrE9aCsicpAa028s // apenas o campo CDGIBGE, desccidade
                                         on dd061.UB36_MUNICIPIOID equals aa028cidade.Id into dd061_aa028cidade_join
                                         from aa028cidade in dd061_aa028cidade_join.DefaultIfEmpty()

                                         where dd061.TenantId == in_tenant && dd061.Dd060Id == dd060.Dd060Id

                                         select new CSICP_DD061
                                         {
                                             TenantId = dd061.TenantId,
                                             Dd061Id = dd061.Dd061Id,
                                             Dd060Id = dd061.Dd060Id,
                                             Dd061ImpostoId = dd061.Dd061ImpostoId,
                                             Dd061Produtoid = dd061.Dd061Produtoid,
                                             Dd061Codgproduto = dd061.Dd061Codgproduto,
                                             Dd061ImpostoidGeneric = dd061.Dd061ImpostoidGeneric,
                                             Dd061CodgImposto = dd061.Dd061CodgImposto,
                                             Dd061Cst = dd061.Dd061Cst,
                                             Dd061Cfop = dd061.Dd061Cfop,
                                             Dd061Descimposto = dd061.Dd061Descimposto,
                                             Dd061ValorContabil = dd061.Dd061ValorContabil,
                                             Dd061BaseCalculo = dd061.Dd061BaseCalculo,
                                             Dd061Aliquota = dd061.Dd061Aliquota,
                                             Dd061Valorimposto = dd061.Dd061Valorimposto,
                                             Dd061Percreducbase = dd061.Dd061Percreducbase,
                                             Dd061Vredbcicms = dd061.Dd061Vredbcicms,
                                             Dd061Isento = dd061.Dd061Isento,
                                             Dd061Outros = dd061.Dd061Outros,
                                             Dd061Cancelamentos = dd061.Dd061Cancelamentos,
                                             Dd061Descontos = dd061.Dd061Descontos,
                                             Dd061Lucroestimado = dd061.Dd061Lucroestimado,
                                             Dd061Vltribaux = dd061.Dd061Vltribaux,
                                             Dd061Predbcst = dd061.Dd061Predbcst,
                                             Dd061Vbcst = dd061.Dd061Vbcst,
                                             Dd061Picmsst = dd061.Dd061Picmsst,
                                             Dd061Vicmsst = dd061.Dd061Vicmsst,
                                             Dd061Vbcfcp = dd061.Dd061Vbcfcp,
                                             Dd061Pfcp = dd061.Dd061Pfcp,
                                             Dd061Vfcp = dd061.Dd061Vfcp,
                                             Dd061Vbcfcpst = dd061.Dd061Vbcfcpst,
                                             Dd061Pfcpst = dd061.Dd061Pfcpst,
                                             Dd061Vfcpst = dd061.Dd061Vfcpst,
                                             Dd061Agregasubtribut = dd061.Dd061Agregasubtribut,
                                             Dd061QtdTributada = dd061.Dd061QtdTributada,
                                             Dd061VlrUnidade = dd061.Dd061VlrUnidade,
                                             Dd061VlrImposto = dd061.Dd061VlrImposto,
                                             Dd061SomaIpiBaseId = dd061.Dd061SomaIpiBaseId,
                                             Dd061BaseliqbrutaId = dd061.Dd061BaseliqbrutaId,
                                             Dd061Vbcstret = dd061.Dd061Vbcstret,
                                             Dd061Vicmsstret = dd061.Dd061Vicmsstret,
                                             Dd061Vbcfcpstret = dd061.Dd061Vbcfcpstret,
                                             Dd061Pfcpstret = dd061.Dd061Pfcpstret,
                                             Dd061Vfcpstret = dd061.Dd061Vfcpstret,
                                             Dd061Vsuframa = dd061.Dd061Vsuframa,
                                             Dd061Psuframa = dd061.Dd061Psuframa,
                                             Dd061Vbcsuframa = dd061.Dd061Vbcsuframa,
                                             Dd061VicmsDesonerado = dd061.Dd061VicmsDesonerado,
                                             Dd061VpautaIcms = dd061.Dd061VpautaIcms,
                                             Dd061Vbcufdest = dd061.Dd061Vbcufdest,
                                             Dd061Picmsufdest = dd061.Dd061Picmsufdest,
                                             Dd061Picmsinter = dd061.Dd061Picmsinter,
                                             Dd061Picmsinterpart = dd061.Dd061Picmsinterpart,
                                             Dd061Vbcfcpufdest = dd061.Dd061Vbcfcpufdest,
                                             Dd061Pfcpufdest = dd061.Dd061Pfcpufdest,
                                             Dd061Vfcpufdest = dd061.Dd061Vfcpufdest,
                                             Dd061Vicmsufremet = dd061.Dd061Vicmsufremet,
                                             Dd061Vicmsufdest = dd061.Dd061Vicmsufdest,
                                             Dd061Pcredsn = dd061.Dd061Pcredsn,
                                             Dd061Vcredicmssn = dd061.Dd061Vcredicmssn,
                                             Dd061Impostodevol = dd061.Dd061Impostodevol,
                                             Dd061Pdevol = dd061.Dd061Pdevol,
                                             Dd061Ipi = dd061.Dd061Ipi,
                                             Dd061Vipidevol = dd061.Dd061Vipidevol,
                                             Dd061Vbcefet = dd061.Dd061Vbcefet,
                                             Dd061Picmsefet = dd061.Dd061Picmsefet,
                                             Dd061Vicmsefet = dd061.Dd061Vicmsefet,
                                             Dd061Predbcefet = dd061.Dd061Predbcefet,
                                             Dd061Pst = dd061.Dd061Pst,
                                             Dd061Vicmssubstituto = dd061.Dd061Vicmssubstituto,
                                             Dd061Vicmsop = dd061.Dd061Vicmsop,
                                             Dd061Pdif = dd061.Dd061Pdif,
                                             Dd061Vicmsdif = dd061.Dd061Vicmsdif,
                                             N37aQbcmono = dd061.N37aQbcmono,
                                             N38Adremicms = dd061.N38Adremicms,
                                             N39Vicmsmono = dd061.N39Vicmsmono,
                                             N39aQbcmonoreten = dd061.N39aQbcmonoreten,
                                             N40Adremicmsreten = dd061.N40Adremicmsreten,
                                             N41Vicmsmonoreten = dd061.N41Vicmsmonoreten,
                                             N47Predadrem = dd061.N47Predadrem,
                                             N48Motredadrem = dd061.N48Motredadrem,
                                             N41aVicmsmonoop = dd061.N41aVicmsmonoop,
                                             N42Pdif = dd061.N42Pdif,
                                             N43Vicmsmonodif = dd061.N43Vicmsmonodif,
                                             N43aQbcmonoret = dd061.N43aQbcmonoret,
                                             N44Adremicmsret = dd061.N44Adremicmsret,
                                             N45Vicmsmonoret = dd061.N45Vicmsmonoret,

                                             NavAA037Imp = aa037Imp != null ? new CSICP_AA037Imp
                                             {
                                                 Id = aa037Imp.Id,
                                                 Label = aa037Imp.Label,
                                             } : null,
                                         }).ToList()

                        let dd060Combs = (from dd060Combs in _appDbContext.OsusrTeiCsicpDd060combs
                                              where dd060Combs.TenantId == in_tenant && dd060Combs.Dd060Id == dd060.Dd060Id
                                              select dd060Combs).First()

                        let listdd060CombLa01 = (from dd060CombLa01 in _appDbContext.OsusrTeiCsicpDd060combla01s
                                                  where dd060CombLa01.TenantId == in_tenant && dd060CombLa01.Dd060Id == dd060.Dd060Id
                                                  select dd060CombLa01).ToList()

                        select new CSICP_DD060
                        {
                            TenantId = dd060.TenantId,
                            Dd060Id = dd060.Dd060Id,
                            Dd040Id = dd060.Dd040Id,
                            Dd060Produtoid = dd060.Dd060Produtoid,
                            Dd060Saldoid = dd060.Dd060Saldoid,
                            Dd060Codgalmox = dd060.Dd060Codgalmox,
                            Dd060CodigoProduto = dd060.Dd060CodigoProduto,
                            Dd060CodigoBarras = dd060.Dd060CodigoBarras,
                            Dd060Filial = dd060.Dd060Filial,
                            Dd060Ci = dd060.Dd060Ci,
                            Dd060Sequencia = dd060.Dd060Sequencia,
                            Dd060Lote = dd060.Dd060Lote,
                            Dd060SubLote = dd060.Dd060SubLote,
                            Dd060Localizacao = dd060.Dd060Localizacao,
                            Dd060CodgLinha = dd060.Dd060CodgLinha,
                            Dd060CodgColuna = dd060.Dd060CodgColuna,
                            Dd060Quantidade = dd060.Dd060Quantidade,
                            Dd060PrecoTabela = dd060.Dd060PrecoTabela,
                            Dd060Totalbruto = dd060.Dd060Totalbruto,
                            Dd060VlrDescSt1liq = dd060.Dd060VlrDescSt1liq,
                            Dd060Pacrescimo = dd060.Dd060Pacrescimo,
                            Dd060Vacrescimo = dd060.Dd060Vacrescimo,
                            Dd060PrcTabela2 = dd060.Dd060PrcTabela2,
                            Dd060Tpdesc = dd060.Dd060Tpdesc,
                            Dd060PercDesconto = dd060.Dd060PercDesconto,
                            Dd060ValorDesconto = dd060.Dd060ValorDesconto,
                            Dd060PrecoUnitario = dd060.Dd060PrecoUnitario,
                            Dd060Totliqproduto = dd060.Dd060Totliqproduto,
                            Dd060St2Liquido = dd060.Dd060St2Liquido,
                            Dd060TotalDescCascata = dd060.Dd060TotalDescCascata,
                            Dd060TotalDesconto = dd060.Dd060TotalDesconto,
                            Dd060Frete = dd060.Dd060Frete,
                            Dd060Seguro = dd060.Dd060Seguro,
                            Dd060Odespesas = dd060.Dd060Odespesas,
                            Dd060TotalLiquido = dd060.Dd060TotalLiquido,
                            Dd060Vdescsuframa = dd060.Dd060Vdescsuframa,
                            Dd060Vdesccupom = dd060.Dd060Vdesccupom,
                            Dd060Descproduto = dd060.Dd060Descproduto,
                            Dd060Descprodsecund = dd060.Dd060Descprodsecund,
                            Dd060UnId = dd060.Dd060UnId,
                            Dd060Unidade = dd060.Dd060Unidade,
                            Dd060CorSerieMerc = dd060.Dd060CorSerieMerc,
                            Dd060ResponsavelId = dd060.Dd060ResponsavelId,
                            Dd060RespVendedor = dd060.Dd060RespVendedor,
                            Dd060RespComprador = dd060.Dd060RespComprador,
                            Dd060BaseCalcIcms = dd060.Dd060BaseCalcIcms,
                            Dd060PercIcms = dd060.Dd060PercIcms,
                            Dd060ValorIcms = dd060.Dd060ValorIcms,
                            Dd060BaseCalcSubst = dd060.Dd060BaseCalcSubst,
                            Dd060PercSubstTrib = dd060.Dd060PercSubstTrib,
                            Dd060Vlrsubsttribaux = dd060.Dd060Vlrsubsttribaux,
                            Dd060Vlrsubsttribut = dd060.Dd060Vlrsubsttribut,
                            Dd060BaseCalcIpi = dd060.Dd060BaseCalcIpi,
                            Dd060PercIpi = dd060.Dd060PercIpi,
                            Dd060ValorIpi = dd060.Dd060ValorIpi,
                            Dd060Percreducaobaseicms = dd060.Dd060Percreducaobaseicms,
                            Dd060ValorAproxImp = dd060.Dd060ValorAproxImp,
                            Dd060LucroEstimado = dd060.Dd060LucroEstimado,
                            Dd060QtdAnterior = dd060.Dd060QtdAnterior,
                            Dd060Cicronologicasai = dd060.Dd060Cicronologicasai,
                            Dd060Cicronologicaent = dd060.Dd060Cicronologicaent,
                            Dd060Tamanho = dd060.Dd060Tamanho,
                            Dd060Largura = dd060.Dd060Largura,
                            Dd060Espessura = dd060.Dd060Espessura,
                            Dd060CodgTransacao = dd060.Dd060CodgTransacao,
                            Dd060Cfop = dd060.Dd060Cfop,
                            Dd060Cst = dd060.Dd060Cst,
                            Dd060DataMovimento = dd060.Dd060DataMovimento,
                            Dd060ItemTrocado = dd060.Dd060ItemTrocado,
                            Dd060Ambiente = dd060.Dd060Ambiente,
                            Dd060GeraMinuta = dd060.Dd060GeraMinuta,
                            Dd060GeraRequisicao = dd060.Dd060GeraRequisicao,
                            Dd060GeraRequisicaoexterna = dd060.Dd060GeraRequisicaoexterna,
                            Dd060Entregar = dd060.Dd060Entregar,
                            Dd060Transferir = dd060.Dd060Transferir,
                            Dd060Filialtransfsaida = dd060.Dd060Filialtransfsaida,
                            Dd060Almoxtransfsaida = dd060.Dd060Almoxtransfsaida,
                            Dd060PrcVendaOrigin = dd060.Dd060PrcVendaOrigin,
                            Dd060Precocusto = dd060.Dd060Precocusto,
                            Dd060Precocustoreal = dd060.Dd060Precocustoreal,
                            Dd060Precocustomedio = dd060.Dd060Precocustomedio,
                            Dd060Prccustomedioent = dd060.Dd060Prccustomedioent,
                            Dd060UnSecId = dd060.Dd060UnSecId,
                            Dd060UnSec = dd060.Dd060UnSec,
                            Dd060UnSecTipoconvId = dd060.Dd060UnSecTipoconvId,
                            Dd060UnSecFatorconv = dd060.Dd060UnSecFatorconv,
                            Dd060UnSecQtde = dd060.Dd060UnSecQtde,
                            Dd060UnSecValor = dd060.Dd060UnSecValor,
                            Dd060UnSecValorLiquido = dd060.Dd060UnSecValorLiquido,
                            Dd060TransacaoId = dd060.Dd060TransacaoId,
                            Dd060StatusestoqueId = dd060.Dd060StatusestoqueId,
                            Dd060RegraaplicadaId = dd060.Dd060RegraaplicadaId,
                            Dd060SaldovirtualId = dd060.Dd060SaldovirtualId,
                            Dd060Saldoanterior = dd060.Dd060Saldoanterior,
                            Dd060Saldoatual = dd060.Dd060Saldoatual,
                            Dd060Baixaestoque = dd060.Dd060Baixaestoque,
                            Dd060Controlasaldo = dd060.Dd060Controlasaldo,
                            Dd060Contsaldograde = dd060.Dd060Contsaldograde,
                            Dd060Contsaldolote = dd060.Dd060Contsaldolote,
                            Dd060Contsaldolocal = dd060.Dd060Contsaldolocal,
                            Dd060Permsaldoneg = dd060.Dd060Permsaldoneg,
                            Dd060Perccomissao = dd060.Dd060Perccomissao,
                            Dd060Valorcomissao = dd060.Dd060Valorcomissao,
                            Dd060SaldotransfId = dd060.Dd060SaldotransfId,
                            Dd060Indtot = dd060.Dd060Indtot,
                            Dd060Isfixarcalcimp = dd060.Dd060Isfixarcalcimp,
                            Dd060CompContaId = dd060.Dd060CompContaId,
                            Dd060Isservico = dd060.Dd060Isservico,
                            Dd060Mlucro = dd060.Dd060Mlucro,
                            Dd060Precoreposicao = dd060.Dd060Precoreposicao,
                            Dd060UsuariovendId = dd060.Dd060UsuariovendId,
                            Dd060Codbarrasalfa = dd060.Dd060Codbarrasalfa,
                            Dd060Xped = dd060.Dd060Xped,
                            Dd060Nitemped = dd060.Dd060Nitemped,
                            Dd060Infadprod = dd060.Dd060Infadprod,
                            Dd060Ambienteid = dd060.Dd060Ambienteid,
                            Dd060Dpreventrega = dd060.Dd060Dpreventrega,
                            Dd060Dprevmontagem = dd060.Dd060Dprevmontagem,
                            Dd060Modentregaid = dd060.Dd060Modentregaid,
                            Dd060Isentregue = dd060.Dd060Isentregue,
                            Dd060Fpagtoid = dd060.Dd060Fpagtoid,
                            Dd060Condicaopagtoid = dd060.Dd060Condicaopagtoid,
                            Dd060Cbenefic = dd060.Dd060Cbenefic,
                            Dd060Ierelevanteid = dd060.Dd060Ierelevanteid,
                            Dd060Cnpjfabricante = dd060.Dd060Cnpjfabricante,
                            Dd060Nomefabricante = dd060.Dd060Nomefabricante,
                            Dd060Motdesoneracaoid = dd060.Dd060Motdesoneracaoid,
                            Dd060Picmsdesonerado = dd060.Dd060Picmsdesonerado,
                            Dd060Vicmsdesonerado = dd060.Dd060Vicmsdesonerado,
                            Dd060VicmsdesonsubId = dd060.Dd060VicmsdesonsubId,
                            Dd08Ismontar = dd060.Dd08Ismontar,
                            Dd060Isinseridopdv = dd060.Dd060Isinseridopdv,
                            Dd060CashbackVunvendida = dd060.Dd060CashbackVunvendida,
                            Dd060CashbackPvendaliq = dd060.Dd060CashbackPvendaliq,
                            Dd060CashbackVpremio = dd060.Dd060CashbackVpremio,
                            Dd060Nroprctabela = dd060.Dd060Nroprctabela,
                            NavListDD061 = listdd061,
                            NavDD060Combs = dd060Combs,
                            NavListDD060CombsLa01 = listdd060CombLa01,

                            NavGG005 = gg005 != null ? new CSICP_GG005
                            {
                                TenantId = gg005.TenantId,
                                Id = gg005.Id,
                                Gg005Filial = gg005.Gg005Filial,
                                Gg005Filialid = gg005.Gg005Filialid,
                                Gg005Codigoartigo = gg005.Gg005Codigoartigo,
                                Gg005Descartigo = gg005.Gg005Descartigo,
                                Gg005Isactive = gg005.Gg005Isactive,
                                Gg005PesoLe = gg005.Gg005PesoLe,
                            } : null,

                            NavGG006 = gg006 != null ? new CSICP_GG006
                            {
                                TenantId = gg006.TenantId,
                                Id = gg006.Id,
                                Gg006Filial = gg006.Gg006Filial,
                                Gg006Codgfilial = gg006.Gg006Codgfilial,
                                Gg006Codigomarca = gg006.Gg006Codigomarca,
                                Gg006Descmarca = gg006.Gg006Descmarca,
                                Gg006IsActive = gg006.Gg006IsActive,
                            } : null,

                            NavGG007Unidade = gg007 != null ? new CSICP_GG007
                            {
                                TenantId = gg007.TenantId,
                                Id = gg007.Id,
                                Gg007Filial = gg007.Gg007Filial,
                                Gg007Filialid = gg007.Gg007Filialid,
                                Gg007Unidade = gg007.Gg007Unidade,
                                Gg007Descricao = gg007.Gg007Descricao,
                                Gg007IsActive = gg007.Gg007IsActive,
                                Gg007FormavendaId = gg007.Gg007FormavendaId,
                                Gg007Qdecimais = gg007.Gg007Qdecimais,
                            } : null,

                            NavGG007UnidadeSec = gg007_UNSec != null ? new CSICP_GG007
                            {
                                TenantId = gg007_UNSec.TenantId,
                                Id = gg007_UNSec.Id,
                                Gg007Filial = gg007_UNSec.Gg007Filial,
                                Gg007Filialid = gg007_UNSec.Gg007Filialid,
                                Gg007Unidade = gg007_UNSec.Gg007Unidade,
                                Gg007Descricao = gg007_UNSec.Gg007Descricao,
                                Gg007IsActive = gg007_UNSec.Gg007IsActive,
                                Gg007FormavendaId = gg007_UNSec.Gg007FormavendaId,
                                Gg007Qdecimais = gg007_UNSec.Gg007Qdecimais,
                            } : null,

                            NavGG008Produto = gg008Produto != null ? new CSICP_GG008
                            {
                                TenantId = gg008Produto.TenantId,
                                Id = gg008Produto.Id,
                                Gg008Filialid = gg008Produto.Gg008Filialid,
                                Gg008Filial = gg008Produto.Gg008Filial,
                                Gg008Codgproduto = gg008Produto.Gg008Codgproduto,
                                Gg008TipoProduto = gg008Produto.Gg008TipoProduto,
                                Gg008CodigoGrupo = gg008Produto.Gg008CodigoGrupo,
                                Gg008CodigoClasse = gg008Produto.Gg008CodigoClasse,
                                Gg008CodigoArtigo = gg008Produto.Gg008CodigoArtigo,
                                Gg008CodigoMarca = gg008Produto.Gg008CodigoMarca,
                                Gg008CodigoPadrao = gg008Produto.Gg008CodigoPadrao,
                                Gg008CodigoTipo = gg008Produto.Gg008CodigoTipo,
                                Gg008CodigoQualidade = gg008Produto.Gg008CodigoQualidade,
                                Gg008Tipoprodutoid = gg008Produto.Gg008Tipoprodutoid,
                                Gg008Grupoid = gg008Produto.Gg008Grupoid,
                                Gg008Subgrupoid = gg008Produto.Gg008Subgrupoid,
                                Gg008Classeid = gg008Produto.Gg008Classeid,
                                Gg008Artigoid = gg008Produto.Gg008Artigoid,
                                Gg008Marcaid = gg008Produto.Gg008Marcaid,
                                Gg008Linhaid = gg008Produto.Gg008Linhaid,
                                Gg008Padraoid = gg008Produto.Gg008Padraoid,
                                Gg008Tipoid = gg008Produto.Gg008Tipoid,
                                Gg008Qualidadeid = gg008Produto.Gg008Qualidadeid,
                                Gg008Referencia = gg008Produto.Gg008Referencia,
                                Gg008Complemento = gg008Produto.Gg008Complemento,
                                Gg008Codindustrial = gg008Produto.Gg008Codindustrial,
                                Gg008Safradiamesinicio = gg008Produto.Gg008Safradiamesinicio,
                                Gg008SafraDiamesfim = gg008Produto.Gg008SafraDiamesfim,
                                Gg008Etiqueta = gg008Produto.Gg008Etiqueta,
                                Gg008Ncm = gg008Produto.Gg008Ncm,
                                Gg008ExNcm = gg008Produto.Gg008ExNcm,
                                Gg008Ncmid = gg008Produto.Gg008Ncmid,
                                Gg008PesoBruto = gg008Produto.Gg008PesoBruto,
                                Gg008PesoLiquido = gg008Produto.Gg008PesoLiquido,
                                Gg008Tamanho = gg008Produto.Gg008Tamanho,
                                Gg008Largura = gg008Produto.Gg008Largura,
                                Gg008Espessura = gg008Produto.Gg008Espessura,
                                Gg008Embalagem1 = gg008Produto.Gg008Embalagem1,
                                Gg008Embalagem2 = gg008Produto.Gg008Embalagem2,
                                Gg008QtdEmbalagem1 = gg008Produto.Gg008QtdEmbalagem1,
                                Gg008QtdEmbalagem2 = gg008Produto.Gg008QtdEmbalagem2,
                                Gg008Comprimentoarmaz = gg008Produto.Gg008Comprimentoarmaz,
                                Gg008LarguraArmaz = gg008Produto.Gg008LarguraArmaz,
                                Gg008AlturaArmaz = gg008Produto.Gg008AlturaArmaz,
                                Gg008FatorArmaz = gg008Produto.Gg008FatorArmaz,
                                Gg008Empilhagem = gg008Produto.Gg008Empilhagem,
                                Gg008Descreduzida = gg008Produto.Gg008Descreduzida,
                                Gg008UsaNroSerie = gg008Produto.Gg008UsaNroSerie,
                                Gg008Refersimilar = gg008Produto.Gg008Refersimilar,
                                Gg008Przgarancompra = gg008Produto.Gg008Przgarancompra,
                                Gg008Przgaranvenda = gg008Produto.Gg008Przgaranvenda,
                                Gg008Servico = gg008Produto.Gg008Servico,
                                Gg008Montavel = gg008Produto.Gg008Montavel,
                                Gg008Classifvegetal = gg008Produto.Gg008Classifvegetal,
                                Gg008IsActive = gg008Produto.Gg008IsActive,
                                Gg008EstadofisicoId = gg008Produto.Gg008EstadofisicoId,
                                Gg008TpgarantiacompraId = gg008Produto.Gg008TpgarantiacompraId,
                                Gg008TpgarantiavendaId = gg008Produto.Gg008TpgarantiavendaId,
                                Gg008TipokitId = gg008Produto.Gg008TipokitId,
                                Gg008PesavelId = gg008Produto.Gg008PesavelId,
                                Gg008Isforalinha = gg008Produto.Gg008Isforalinha,
                                Gg008Dataforalinha = gg008Produto.Gg008Dataforalinha,
                                Gg008ListservicoId = gg008Produto.Gg008ListservicoId,
                                Gg008Grpsubgrupoid = gg008Produto.Gg008Grpsubgrupoid,
                                Gg008Sequence = gg008Produto.Gg008Sequence,
                                Gg008Dultalteracao = gg008Produto.Gg008Dultalteracao,
                                Gg008Entregar = gg008Produto.Gg008Entregar,
                                Gg008Isecommerce = gg008Produto.Gg008Isecommerce,
                                Gg008AnpId = gg008Produto.Gg008AnpId,
                                Gg008Dregistro = gg008Produto.Gg008Dregistro,
                                Gg008Usuariopropid = gg008Produto.Gg008Usuariopropid,
                                Gg008Usuarioaltid = gg008Produto.Gg008Usuarioaltid,
                                Gg008Ierelevanteid = gg008Produto.Gg008Ierelevanteid,
                                Gg008Cnpjfabricante = gg008Produto.Gg008Cnpjfabricante,
                                Gg008Nomefabricante = gg008Produto.Gg008Nomefabricante,
                                Gg008Vicmsproprio = gg008Produto.Gg008Vicmsproprio,
                                Gg008Descespecial1 = gg008Produto.Gg008Descespecial1,
                                Gg008Descespecial2 = gg008Produto.Gg008Descespecial2,
                            } : null,

                            NavGG008Kdx = gg008Kdx != null ? new CSICP_GG008Kdx
                            {
                                TenantId = gg008Kdx.TenantId,
                                Gg008Kardexid = gg008Kdx.Gg008Kardexid,
                                Gg008Filialid = gg008Kdx.Gg008Filialid,
                                Gg008Produtoid = gg008Kdx.Gg008Produtoid,
                                Gg008Codalmoxpadrao = gg008Kdx.Gg008Codalmoxpadrao,
                                Gg008Codalmtransf = gg008Kdx.Gg008Codalmtransf,
                                Gg008Almoxpadraoid = gg008Kdx.Gg008Almoxpadraoid,
                                Gg008Almoxtransfid = gg008Kdx.Gg008Almoxtransfid,
                                Gg008Unidade = gg008Kdx.Gg008Unidade,
                                Gg008Unidsecundaria = gg008Kdx.Gg008Unidsecundaria,
                                Gg008Unvendavarejoid = gg008Kdx.Gg008Unvendavarejoid,
                                Gg008Uncompravarejoid = gg008Kdx.Gg008Uncompravarejoid,
                                Gg008Unvendaatacadoid = gg008Kdx.Gg008Unvendaatacadoid,
                                Gg008FatorConversao = gg008Kdx.Gg008FatorConversao,
                                Gg008AliquotaIpi = gg008Kdx.Gg008AliquotaIpi,
                                Gg008AliquotaIcms = gg008Kdx.Gg008AliquotaIcms,
                                Gg008AliqIcmsReduzidaPdv = gg008Kdx.Gg008AliqIcmsReduzidaPdv,
                                Gg008AliquotaIss = gg008Kdx.Gg008AliquotaIss,
                                Gg008Margemlucrosai = gg008Kdx.Gg008Margemlucrosai,
                                Gg008Margemlucroent = gg008Kdx.Gg008Margemlucroent,
                                Gg008CalculaIrrf = gg008Kdx.Gg008CalculaIrrf,
                                Gg008CalculaInss = gg008Kdx.Gg008CalculaInss,
                                Gg008PercCsll = gg008Kdx.Gg008PercCsll,
                                Gg008PercCofins = gg008Kdx.Gg008PercCofins,
                                Gg008PercPis = gg008Kdx.Gg008PercPis,
                                Gg008IcmsPauta = gg008Kdx.Gg008IcmsPauta,
                                Gg008IpiPauta = gg008Kdx.Gg008IpiPauta,
                                Gg008Qtdpedidocompra = gg008Kdx.Gg008Qtdpedidocompra,
                                Gg008EstoqueMinimo = gg008Kdx.Gg008EstoqueMinimo,
                                Gg008EstoqueMaximo = gg008Kdx.Gg008EstoqueMaximo,
                                Gg008TempoReposicao = gg008Kdx.Gg008TempoReposicao,
                                Gg008PontoPedido = gg008Kdx.Gg008PontoPedido,
                                Gg008LoteEconomico = gg008Kdx.Gg008LoteEconomico,
                                Gg008GrauAtendimento = gg008Kdx.Gg008GrauAtendimento,
                                Gg008PercTolerancia = gg008Kdx.Gg008PercTolerancia,
                                Gg008Abc = gg008Kdx.Gg008Abc,
                                Gg008PercComissao = gg008Kdx.Gg008PercComissao,
                                Gg008DataFabricacao = gg008Kdx.Gg008DataFabricacao,
                                Gg008DataValidade = gg008Kdx.Gg008DataValidade,
                                Gg008DiasValidade = gg008Kdx.Gg008DiasValidade,
                                Gg008CustoMedio = gg008Kdx.Gg008CustoMedio,
                                Gg008PrecoReposicao = gg008Kdx.Gg008PrecoReposicao,
                                Gg008PercDescItem = gg008Kdx.Gg008PercDescItem,
                                Gg008Prcpromocional = gg008Kdx.Gg008Prcpromocional,
                                Gg008QtdPromocional = gg008Kdx.Gg008QtdPromocional,
                                Gg008FatorLucro = gg008Kdx.Gg008FatorLucro,
                                Gg008PrcVendavarejo = gg008Kdx.Gg008PrcVendavarejo,
                                Gg008PrcVndMercado = gg008Kdx.Gg008PrcVndMercado,
                                Gg008Ultreajprcvenda = gg008Kdx.Gg008Ultreajprcvenda,
                                Gg008PrecoVendaLiq = gg008Kdx.Gg008PrecoVendaLiq,
                                Gg008Vlrmargemlucro = gg008Kdx.Gg008Vlrmargemlucro,
                                Gg008Alteraprcvenda = gg008Kdx.Gg008Alteraprcvenda,
                                Gg008PrecoCusto = gg008Kdx.Gg008PrecoCusto,
                                Gg008Ultreajprccusto = gg008Kdx.Gg008Ultreajprccusto,
                                Gg008PrecoCustoReal = gg008Kdx.Gg008PrecoCustoReal,
                                Gg008CentroCusto = gg008Kdx.Gg008CentroCusto,
                                Gg008Ccustoid = gg008Kdx.Gg008Ccustoid,
                                Gg008ContaContabil = gg008Kdx.Gg008ContaContabil,
                                Gg008ClasseContabil = gg008Kdx.Gg008ClasseContabil,
                                Gg008FornecedorCanal = gg008Kdx.Gg008FornecedorCanal,
                                Gg008Fornecedorpadrao = gg008Kdx.Gg008Fornecedorpadrao,
                                Gg008Contaid = gg008Kdx.Gg008Contaid,
                                Gg008Periodicidadeinv = gg008Kdx.Gg008Periodicidadeinv,
                                Gg008ControlaSaldo = gg008Kdx.Gg008ControlaSaldo,
                                Gg008ControleLote = gg008Kdx.Gg008ControleLote,
                                Gg008ControleGrade = gg008Kdx.Gg008ControleGrade,
                                Gg008Anuente = gg008Kdx.Gg008Anuente,
                                Gg008Restricao = gg008Kdx.Gg008Restricao,
                                Gg008Grupocomprasid = gg008Kdx.Gg008Grupocomprasid,
                                Gg008Permsldnegativo = gg008Kdx.Gg008Permsldnegativo,
                                Gg008Minutaautomatica = gg008Kdx.Gg008Minutaautomatica,
                                Gg008Requisautomatica = gg008Kdx.Gg008Requisautomatica,
                                Gg008DataDesativacao = gg008Kdx.Gg008DataDesativacao,
                                Gg008Localizfixa = gg008Kdx.Gg008Localizfixa,
                                Gg008Diversos = gg008Kdx.Gg008Diversos,
                                Gg008AliqDifPis = gg008Kdx.Gg008AliqDifPis,
                                Gg008AliqDifCofins = gg008Kdx.Gg008AliqDifCofins,
                                Gg008EanTributavel = gg008Kdx.Gg008EanTributavel,
                                Gg008Untributavelid = gg008Kdx.Gg008Untributavelid,
                                Gg008FatorUnidade = gg008Kdx.Gg008FatorUnidade,
                                Gg008ValorPis = gg008Kdx.Gg008ValorPis,
                                Gg008ValorCofins = gg008Kdx.Gg008ValorCofins,
                                Gg008IsActive = gg008Kdx.Gg008IsActive,
                                Gg008TipoConversaoId = gg008Kdx.Gg008TipoConversaoId,
                                Gg008TipoprazoId = gg008Kdx.Gg008TipoprazoId,
                                Gg008TpContribuicaoId = gg008Kdx.Gg008TpContribuicaoId,
                                Gg008RiControlequalidade = gg008Kdx.Gg008RiControlequalidade,
                                Gg008AliquotaIrpj = gg008Kdx.Gg008AliquotaIrpj,
                                Gg008RetencaoAliqInss = gg008Kdx.Gg008RetencaoAliqInss,
                                Gg008RetencaoAliqIrrf = gg008Kdx.Gg008RetencaoAliqIrrf,
                                Gg008DescontoSuframa = gg008Kdx.Gg008DescontoSuframa,
                                Gg008Timestamp = gg008Kdx.Gg008Timestamp,
                                Gg008Plucro = gg008Kdx.Gg008Plucro,
                                Gg008IsctrlGondola = gg008Kdx.Gg008IsctrlGondola,
                                Gg008Qmediaconsumo = gg008Kdx.Gg008Qmediaconsumo,
                                Gg008Vmediaconsumo = gg008Kdx.Gg008Vmediaconsumo,
                                Gg008Dtultprocle = gg008Kdx.Gg008Dtultprocle,
                                Gg008VuncompraCmedio = gg008Kdx.Gg008VuncompraCmedio,
                                Gg008VuncompraReposicao = gg008Kdx.Gg008VuncompraReposicao,
                                Gg008VuncompraPrcvenda = gg008Kdx.Gg008VuncompraPrcvenda,
                                Gg008VuncompraPrcmercado = gg008Kdx.Gg008VuncompraPrcmercado,
                                Gg008VuncompraPrccusto = gg008Kdx.Gg008VuncompraPrccusto,
                                Gg008VuncompraCustoreal = gg008Kdx.Gg008VuncompraCustoreal,
                                Gg008VuncompraVlrmarglucro = gg008Kdx.Gg008VuncompraVlrmarglucro,
                                Gg008Moedaid = gg008Kdx.Gg008Moedaid,
                                Gg008Vmoeda = gg008Kdx.Gg008Vmoeda,
                                Gg008Prcecommerce = gg008Kdx.Gg008Prcecommerce,
                                Gg008Auditasn = gg008Kdx.Gg008Auditasn,
                                Gg008Possuisaldo = gg008Kdx.Gg008Possuisaldo,
                                Gg008Ultrecebimento = gg008Kdx.Gg008Ultrecebimento,
                                Gg008Qtdultrecebto = gg008Kdx.Gg008Qtdultrecebto,
                                Gg008UltimaVenda = gg008Kdx.Gg008UltimaVenda,
                                Gg008QtdeUltVenda = gg008Kdx.Gg008QtdeUltVenda,
                                Gg008TpcbarratribId = gg008Kdx.Gg008TpcbarratribId,
                            } : null,

                            NavGG021 = gg021 != null ? new CSICP_GG021
                            {
                                TenantId = gg021.TenantId,
                                Id = gg021.Id,
                                Gg021Ncm = gg021.Gg021Ncm,
                                Gg021ExNcm = gg021.Gg021ExNcm,
                                Gg021Descricao = gg021.Gg021Descricao,
                                Gg021Unidade = gg021.Gg021Unidade,
                                Gg021Unid = gg021.Gg021Unid,
                                Gg021PercIpi = gg021.Gg021PercIpi,
                                Gg021PercIcms = gg021.Gg021PercIcms,
                                Gg021Tipi = gg021.Gg021Tipi,
                                Gg021ExNbm = gg021.Gg021ExNbm,
                                Gg021IsActive = gg021.Gg021IsActive,
                                Gg021NcmGenero = gg021.Gg021NcmGenero,
                                Gg021Mp255Id = gg021.Gg021Mp255Id,
                                Gg021GeneroId = gg021.Gg021GeneroId,
                                Gg021CnaeId = gg021.Gg021CnaeId,
                                Gg021IsinalanteId = gg021.Gg021IsinalanteId,
                                Gg021CestId = gg021.Gg021CestId,
                                Gg021CestN2 = gg021.Gg021CestN2,
                                Gg021CestN3 = gg021.Gg021CestN3,
                                Gg021PercCsll = gg021.Gg021PercCsll,
                                Gg021PercCofins = gg021.Gg021PercCofins,
                                Gg021PercPis = gg021.Gg021PercPis,
                                Gg021IcmsPauta = gg021.Gg021IcmsPauta,
                                Gg021IpiPauta = gg021.Gg021IpiPauta,
                                Gg021AliquotaIrpj = gg021.Gg021AliquotaIrpj,
                                Gg021Ierelevanteid = gg021.Gg021Ierelevanteid,
                                Gg021Dtiniciovigencia = gg021.Gg021Dtiniciovigencia,
                                Gg021Dtfimvigencia = gg021.Gg021Dtfimvigencia,
                            } : null,

                            NavGG021Cest = gg021cest != null ? new OsusrE9aCsicpGg021cest
                            {
                                Id = gg021cest.Id,
                                Label = gg021cest.Label,
                                Order = gg021cest.Order,
                                IsActive = gg021cest.IsActive,
                                CsCodg = gg021cest.CsCodg,
                            } : null,

                            NavAA031Cstori = aa031_cstori != null ? new CSICP_AA031Cstori
                            {
                                Id = aa031_cstori.Id,
                                Label = aa031_cstori.Label,
                                Order = aa031_cstori.Order,
                                IsActive = aa031_cstori.IsActive,
                                CstDigito = aa031_cstori.CstDigito,
                            } : null,

                            NavAA032Csticm = aa032_csticm != null ? new CSICP_AA032Csticm
                            {
                                Id = aa032_csticm.Id,
                                Label = aa032_csticm.Label,
                                Order = aa032_csticm.Order,
                                IsActive = aa032_csticm.IsActive,
                                CstDigito = aa032_csticm.CstDigito,
                                RegimeId = aa032_csticm.RegimeId,
                                Regime = aa032_csticm.Regime,
                                Informativo = aa032_csticm.Informativo,
                            } : null,

                            NavAA033Cstipi = aa033_cstipi != null ? new CSICP_AA033Cstipi
                            {
                                Id = aa033_cstipi.Id,
                                Label = aa033_cstipi.Label,
                                Order = aa033_cstipi.Order,
                                IsActive = aa033_cstipi.IsActive,
                                CstDigito = aa033_cstipi.CstDigito,
                            } : null,

                            NavAA034Cstpi = aa034_cstpis != null ? new CSICP_AA034Cstpi
                            {
                                Id = aa034_cstpis.Id,
                                Label = aa034_cstpis.Label,
                                Order = aa034_cstpis.Order,
                                IsActive = aa034_cstpis.IsActive,
                                CstDigito = aa034_cstpis.CstDigito,
                            } : null,

                            NavAA038Modst = aa038_modst != null ? new CSICP_AA038Modst
                            {
                                Id = aa038_modst.Id,
                                Label = aa038_modst.Label,
                                Order = aa038_modst.Order,
                                IsActive = aa038_modst.IsActive,
                                Digito = aa038_modst.Digito,
                            } : null,

                            NavBB027Modal = bb027_modal != null ? new CSICP_Bb027Modal
                            {
                                Id = bb027_modal.Id,
                                Label = bb027_modal.Label,
                                Order = bb027_modal.Order,
                                IsActive = bb027_modal.IsActive,
                                Digito = bb027_modal.Digito,
                            } : null,

                            NavBB027Motivo = bb027_motivo != null ? new CSICP_Bb027Motivo
                            {
                                Id = bb027_motivo.Id,
                                Label = bb027_motivo.Label,
                                Order = bb027_motivo.Order,
                                IsActive = bb027_motivo.IsActive,
                                Conteudo = bb027_motivo.Conteudo,
                            } : null,

                            NavBB027Reforma = bb027_reforma != null ? new CSICP_Bb027
                            {
                                TenantId = bb027_reforma.TenantId,
                                Id = bb027_reforma.Id,
                                Bb027Filial = bb027_reforma.Bb027Filial,
                                Bb027Codigo = bb027_reforma.Bb027Codigo,
                                Bb027Descricao = bb027_reforma.Bb027Descricao,
                                Bb027Baixaestoque = bb027_reforma.Bb027Baixaestoque,
                                Bb027Geracreceber = bb027_reforma.Bb027Geracreceber,
                                Bb027Atualizaprcompra = bb027_reforma.Bb027Atualizaprcompra,
                                Bb027Calcsubstituicao = bb027_reforma.Bb027Calcsubstituicao,
                                Bb027Calculaiss = bb027_reforma.Bb027Calculaiss,
                                Bb027Cfopdentroestado = bb027_reforma.Bb027Cfopdentroestado,
                                Bb027Cfopforaestado = bb027_reforma.Bb027Cfopforaestado,
                                Bb027Agregasubstrib = bb027_reforma.Bb027Agregasubstrib,
                                Bb027Difa = bb027_reforma.Bb027Difa,
                                Bb027Icst = bb027_reforma.Bb027Icst,
                                Bb027Irrf = bb027_reforma.Bb027Irrf,
                                Bb027Pis = bb027_reforma.Bb027Pis,
                                Bb027Cofins = bb027_reforma.Bb027Cofins,
                                Bb027Irpj = bb027_reforma.Bb027Irpj,
                                Bb027Icmsdiferido = bb027_reforma.Bb027Icmsdiferido,
                                Bb027Geraestatistica = bb027_reforma.Bb027Geraestatistica,
                                Bb027Codgcst = bb027_reforma.Bb027Codgcst,
                                Bb027Transdevolucao = bb027_reforma.Bb027Transdevolucao,
                                Bb027Reducaoicms = bb027_reforma.Bb027Reducaoicms,
                                Bb027Reducaoipi = bb027_reforma.Bb027Reducaoipi,
                                Bb027Reducaoicmsst = bb027_reforma.Bb027Reducaoicmsst,
                                Bb027Reducaoiss = bb027_reforma.Bb027Reducaoiss,
                                Empresaid = bb027_reforma.Empresaid,
                                Bb027EntsaiId = bb027_reforma.Bb027EntsaiId,
                                Bb027PodertercId = bb027_reforma.Bb027PodertercId,
                                Bb027CalcicmsId = bb027_reforma.Bb027CalcicmsId,
                                Bb027CalcipiId = bb027_reforma.Bb027CalcipiId,
                                Bb027SomaipiBaseicmsId = bb027_reforma.Bb027SomaipiBaseicmsId,
                                Bb027IpiBrutoId = bb027_reforma.Bb027IpiBrutoId,
                                Bb027BaseicmsbrutaliqId = bb027_reforma.Bb027BaseicmsbrutaliqId,
                                Bb027BasesubsbrutaliqId = bb027_reforma.Bb027BasesubsbrutaliqId,
                                Bb027CfopStaticaId = bb027_reforma.Bb027CfopStaticaId,
                                Bb027TdevolucaoId = bb027_reforma.Bb027TdevolucaoId,
                                Bb027RegimeId = bb027_reforma.Bb027RegimeId,
                                Bb027CfopForaestadoId = bb027_reforma.Bb027CfopForaestadoId,
                                Bb027Hashid = bb027_reforma.Bb027Hashid,
                                Bb027Descnatoper = bb027_reforma.Bb027Descnatoper,
                                Bb027CalcajusteicmsId = bb027_reforma.Bb027CalcajusteicmsId,
                                Bb027CodgajusteicmsId = bb027_reforma.Bb027CodgajusteicmsId,
                                //Bb027Icmsdiferidoid = bb027_reforma.Bb027Icmsdiferidoid,
                                Bb027PicmsDiferido = bb027_reforma.Bb027PicmsDiferido,
                                Bb027Tdevolucao = bb027_reforma.Bb027Tdevolucao,

                            } : null,

                            NavDD061Cfgimp = dd061_cfgimp != null ? new CSICP_DD061Cfgimp
                            {
                                TenantId = dd061_cfgimp.TenantId,
                                Dd060Id = dd061_cfgimp.Dd060Id,
                                Dd061Bb027Id = dd061_cfgimp.Dd061Bb027Id,
                                Dd061Bb027bCfgimpId = dd061_cfgimp.Dd061Bb027bCfgimpId,
                                Dd061Bb027bCodgcst = dd061_cfgimp.Dd061Bb027bCodgcst,
                                Dd061Bb027bRegimeId = dd061_cfgimp.Dd061Bb027bRegimeId,
                                Dd061Bb027bOrigemId = dd061_cfgimp.Dd061Bb027bOrigemId,
                                Dd061Bb027bCstIcmsId = dd061_cfgimp.Dd061Bb027bCstIcmsId,
                                Dd061Bb027bCstIpiId = dd061_cfgimp.Dd061Bb027bCstIpiId,
                                Dd061Bb027bCstPisId = dd061_cfgimp.Dd061Bb027bCstPisId,
                                Dd061NatBcCredPis = dd061_cfgimp.Dd061NatBcCredPis,
                                Dd061Bb027bCstCofinsId = dd061_cfgimp.Dd061Bb027bCstCofinsId,
                                Dd061NatBcCredCofins = dd061_cfgimp.Dd061NatBcCredCofins,
                                Dd061Bb027bInfornf = dd061_cfgimp.Dd061Bb027bInfornf,
                                Dd061Bb027bInforipi = dd061_cfgimp.Dd061Bb027bInforipi,
                                Dd061Bb027bInforpis = dd061_cfgimp.Dd061Bb027bInforpis,
                                Dd061Bb027bInforcofins = dd061_cfgimp.Dd061Bb027bInforcofins,
                                Dd061Bb027bModbcId = dd061_cfgimp.Dd061Bb027bModbcId,
                                Dd061Bb027bMotdesoneracao = dd061_cfgimp.Dd061Bb027bMotdesoneracao,
                                Dd061Bb027bUfDestId = dd061_cfgimp.Dd061Bb027bUfDestId,
                                Dd061Bb027bClassecontaId = dd061_cfgimp.Dd061Bb027bClassecontaId,
                                Dd061Bb027bCfopStaticaId = dd061_cfgimp.Dd061Bb027bCfopStaticaId,
                                Dd061Bb027bModalbcIcmsSt = dd061_cfgimp.Dd061Bb027bModalbcIcmsSt,
                                Dd061Bb027bAliquota = dd061_cfgimp.Dd061Bb027bAliquota,
                                Dd061Bb027bReducaobase = dd061_cfgimp.Dd061Bb027bReducaobase,
                                Dd061Bb027bMp255Id = dd061_cfgimp.Dd061Bb027bMp255Id,
                                Dd061Bb027bReducaobcst = dd061_cfgimp.Dd061Bb027bReducaobcst,
                                Dd061Bb027CfopId = dd061_cfgimp.Dd061Bb027CfopId,
                                Dd061Bb027bCfopExcecaoId = dd061_cfgimp.Dd061Bb027bCfopExcecaoId,
                                Dd061Bb027bCenquadIpiId = dd061_cfgimp.Dd061Bb027bCenquadIpiId,
                                Dd061Bb027bAliqInternauf = dd061_cfgimp.Dd061Bb027bAliqInternauf,
                                Dd061Bb027bIndpres = dd061_cfgimp.Dd061Bb027bIndpres,
                            } : null,

                            NavSpedInCenqIpi = spedIncenq_IPI != null ? new Osusr66cSpedInCenqIpi
                            {
                                Id = spedIncenq_IPI.Id,
                                Cod = spedIncenq_IPI.Cod,
                                Grupocst = spedIncenq_IPI.Grupocst,
                                Descricao = spedIncenq_IPI.Descricao,
                                IsActive = spedIncenq_IPI.IsActive,
                            } : null,

                            NavSpedInCfop = spedInCfop != null ? new Osusr66cSpedInCfop
                            {
                                Id = spedInCfop.Id,
                                Codigo = spedInCfop.Codigo,
                                Descricao = spedInCfop.Descricao,
                                IsActive = spedInCfop.IsActive,
                                Order = spedInCfop.Order,
                            } : null,

                            NavStRelavancium = stRelevancia != null ? new SpedCsicpStrelevancium
                            {
                                Id = stRelevancia.Id,
                                Label = stRelevancia.Label,
                                Order = stRelevancia.Order,
                                IsActive = stRelevancia.IsActive,
                                Codgcs = stRelevancia.Codgcs,
                            } : null,
                        };

            var result = await query.ToListAsync();

            return (result, result.Count);
        }
    }
}
