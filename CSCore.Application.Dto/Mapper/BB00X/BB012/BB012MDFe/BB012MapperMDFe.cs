using CSBS101._82Application.Mapper.BB00X.BB012;
using CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB012.Get.BB012MDFe;
using CSCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.BB00X.BB012.BB012MDFe
{
    public static class BB012MapperMDFe
    {
        public static DtoGet_BB012MDFe ToDtoGetBB012MDFe(this CSICP_BB012 entity)
        {
            return new DtoGet_BB012MDFe
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Codigo = entity.Bb012Codigo,
                Bb012NomeCliente = entity.Bb012NomeCliente,
                Bb012NomeFantasia = entity.Bb012NomeFantasia,
                Bb012DataAniversario = entity.Bb012DataAniversario,
                Bb012DataCadastro = entity.Bb012DataCadastro,
                Bb012Telefone = entity.Bb012Telefone,
                Bb012Faxcelular = entity.Bb012Faxcelular,
                Bb012HomePage = entity.Bb012HomePage,
                Bb012Email = entity.Bb012Email,
                Bb012DataEntradaSit = entity.Bb012DataEntradaSit,
                Bb012DataSaidaSit = entity.Bb012DataSaidaSit,
                Bb012Descricao = entity.Bb012Descricao,
                Bb012IsActive = entity.Bb012IsActive,
                Bb012TipoContaId = entity.Bb012TipoContaId,
                Bb012GrupocontaId = entity.Bb012GrupocontaId,
                Bb012ClassecontaId = entity.Bb012ClassecontaId,
                Bb012StatuscontaId = entity.Bb012StatuscontaId,
                Bb012SitContaId = entity.Bb012SitContaId,
                Bb012ModrelacaoId = entity.Bb012ModrelacaoId,
                Bb012Sequence = entity.Bb012Sequence,
                Bb012Dultalteracao = entity.Bb012Dultalteracao,
                Bb012Estabcadid = entity.Bb012Estabcadid,
                Bb012Keyacess = entity.Bb012Keyacess,
                Bb012IdIndicador = entity.Bb012IdIndicador,
                Bb012Countappmcon = entity.Bb012Countappmcon,
                Bb012Oricadastroid = entity.Bb012Oricadastroid,
                Nav_BB01201 = entity.OsusrE9aCsicpBb01201?.ToDtoGetBB01201MDFe(),
                Nav_BB01202 = entity.Nav_BB01202?.ToDtoGetBB01202MDFe(),
            };
        }

        public static DtoGet_BB01201MDFe ToDtoGetBB01201MDFe(this CSICP_BB01201 entity)
        {
            return new DtoGet_BB01201MDFe
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Zonaid = entity.Bb012Zonaid,
                Bb012Atividadeid = entity.Bb012Atividadeid,
                Bb012Limitecredito = entity.Bb012Limitecredito,
                Bb012Limcreditosecun = entity.Bb012Limcreditosecun,
                Bb012Limiteccredito = entity.Bb012Limiteccredito,
                Bb012Diavenctocartao = entity.Bb012Diavenctocartao,
                Bb012Contaconvenio = entity.Bb012Contaconvenio,
                Bb012Diaspagtoconv = entity.Bb012Diaspagtoconv,
                Bb012Padraobancoid = entity.Bb012Padraobancoid,
                Bb012Bcoagenciaconta = entity.Bb012Bcoagenciaconta,
                Bb012Revenda = entity.Bb012Revenda,
                Bb012TaxaAdministracaoCon = entity.Bb012TaxaAdministracaoCon,
                Bb012Requisicao = entity.Bb012Requisicao,
                Bb012Contacontabil = entity.Bb012Contacontabil,
                Bb012Historicocontabilid = entity.Bb012Historicocontabilid,
                Bb012Contratocartao = entity.Bb012Contratocartao,
                Bb012Datacontratocartao = entity.Bb012Datacontratocartao,
                Bb012Dtvalidadecartao = entity.Bb012Dtvalidadecartao,
                Bb012Modalidadecredcartao = entity.Bb012Modalidadecredcartao,
                Bb012Perclimcredito = entity.Bb012Perclimcredito,
                Bb012Prazoentregafornec = entity.Bb012Prazoentregafornec,
                Bb012Condpagtofornec = entity.Bb012Condpagtofornec,
                Bb012Natoperacaoid = entity.Bb012Natoperacaoid,
                Bb012Condpagtoid = entity.Bb012Condpagtoid,
                Bb012Textonotaid = entity.Bb012Textonotaid,
                Bb012GrauRisco = entity.Bb012GrauRisco,
                Bb012ClasseCredito = entity.Bb012ClasseCredito,
                Bb012Dtvalidcadastro = entity.Bb012Dtvalidcadastro,
                Bb012PercIcms = entity.Bb012PercIcms,
                Bb012Codgcategoria = entity.Bb012Codgcategoria,
                Bb012Categoriaid = entity.Bb012Categoriaid,
                Bb012Limitecredparcela = entity.Bb012Limitecredparcela,
                Bb012NumUltFatura = entity.Bb012NumUltFatura,
                Bb012Totcompracarnet = entity.Bb012Totcompracarnet,
                Bb012ValorEntrada = entity.Bb012ValorEntrada,
                Bb012MaiorCompra = entity.Bb012MaiorCompra,
                Bb012MenorCompra = entity.Bb012MenorCompra,
                Bb012Totdiasatraso = entity.Bb012Totdiasatraso,
                Bb012MaiorAtraso = entity.Bb012MaiorAtraso,
                Bb012MenorAtraso = entity.Bb012MenorAtraso,
                Bb012Mediadeatraso = entity.Bb012Mediadeatraso,
                Bb012Maiorsaldo = entity.Bb012Maiorsaldo,
                Bb012Numcompras = entity.Bb012Numcompras,
                Bb012Dtprimcompra = entity.Bb012Dtprimcompra,
                Bb012Dtultcompra = entity.Bb012Dtultcompra,
                Bb012Vlrmaiorpagto = entity.Bb012Vlrmaiorpagto,
                Bb012Numpagtodia = entity.Bb012Numpagtodia,
                Bb012Numpagtoatraso = entity.Bb012Numpagtoatraso,
                Bb012Saldodevedor = entity.Bb012Saldodevedor,
                Bb012Saldopedido = entity.Bb012Saldopedido,
                Bb012Qtdtitprotestado = entity.Bb012Qtdtitprotestado,
                Bb012Ultprotesto = entity.Bb012Ultprotesto,
                Bb012Qtdchqdevolvido = entity.Bb012Qtdchqdevolvido,
                Bb012Ultchqdevolvido = entity.Bb012Ultchqdevolvido,
                Bb012ConvenioId = entity.Bb012ConvenioId,
                Bb012TipogeracaoId = entity.Bb012TipogeracaoId,
                Bb012SitespecialId = entity.Bb012SitespecialId,
                Bb012Entmtgrotaid = entity.Bb012Entmtgrotaid,
                Bb012Vendarotaid = entity.Bb012Vendarotaid,
                Bb012Diavenctoid = entity.Bb012Diavenctoid,
                Bb012Codgbcodebconta = entity.Bb012Codgbcodebconta,
            };
        }

        public static DtoGet_BB01202MDFe ToDtoGetBB01202MDFe(this CSICP_BB01202 entity)
        {
            return new DtoGet_BB01202MDFe
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb012Cnpj = entity!.Bb012Cnpj,
                Bb012Inscestadual = entity.Bb012Inscestadual,
                Bb012Suframa = entity.Bb012Suframa,
                Bb012Regsuframavalido = entity.Bb012Regsuframavalido,
                Bb012Regjuntacomercial = entity.Bb012Regjuntacomercial,
                Bb012Dataregjunta = entity.Bb012Dataregjunta,
                Bb012Patrimonio = entity.Bb012Patrimonio,
                Bb012CapitalSocial = entity.Bb012CapitalSocial,
                Bb012Cpf = entity.Bb012Cpf,
                Bb012Rg = entity.Bb012Rg,
                Bb012Complementorg = entity.Bb012Complementorg,
                Bb012Emissaorg = entity.Bb012Emissaorg,
                Bb012Pis = entity.Bb012Pis,
                Bb012Residedesde = entity.Bb012Residedesde,
                Bb012Nrodependentes = entity.Bb012Nrodependentes,
                Bb012Empadmissao = entity.Bb012Empadmissao,
                Bb012EmpProfissao = entity.Bb012EmpProfissao,
                Bb012Valorremuneracao = entity.Bb012Valorremuneracao,
                Bb012Outrosrendimentos = entity.Bb012Outrosrendimentos,
                Bb012Origemoutrosrend = entity.Bb012Origemoutrosrend,
                Bb012InscEstSniId = entity.Bb012InscEstSniId,
                Bb012SexoId = entity.Bb012SexoId,
                Bb012EstadocivilId = entity.Bb012EstadocivilId,
                Bb012TipodomicilioId = entity.Bb012TipodomicilioId,
                Bb012Compresid01Id = entity.Bb012Compresid01Id,
                Bb012Compresid02Id = entity.Bb012Compresid02Id,
                Bb012GescolaridadeId = entity.Bb012GescolaridadeId,
                Bb012OcupacaoId = entity.Bb012OcupacaoId,
                Bb012NaturaldeId = entity.Bb012NaturaldeId,
                Bb012TptributacaoId = entity.Bb012TptributacaoId,
                Bb012IdentEstrangeiro = entity.Bb012IdentEstrangeiro,
                Bb012Empresa = entity.Bb012Empresa,
                Bb012EmpEndereco = entity.Bb012EmpEndereco,
                Bb012EmpGrupoId = entity.Bb012EmpGrupoId,
                Bb012Motdesoneracaoid = entity.Bb012Motdesoneracaoid,
                NavBB01202Ins = entity.BB012_Insc_Est_SNI
            };
        }
    }
}
