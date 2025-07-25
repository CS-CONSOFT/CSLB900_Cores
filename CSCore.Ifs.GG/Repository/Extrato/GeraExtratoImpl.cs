using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSLB900.MSTools.GenerateId;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.Extrato
{
    public class GeraExtratoImpl(
        AppDbContext appDbContext,
        ICS_GenerateId generateId,
        IGenerateProtocolo generateProtocolo) : IGeraExtrato
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly ICS_GenerateId _generateId = generateId;
        private readonly IGenerateProtocolo _generateProtocolo = generateProtocolo;
        public async Task CS_CriaExtratoOrigem(ParametroGeraExtrato parametroGeraExtrato, int tenant)
        {
            CSICP_GG028 gg028 = new()
            {
                TenantId = tenant,
                Id = _generateId.GenerateUuId(),
                Gg028Filialid = parametroGeraExtrato.Nav_CSICP_GG520?.Nav_GG008Kardex?.Gg008Filialid,
                Gg028Protocolnumber = parametroGeraExtrato.ProtocoloGG028.ToString(),
                Gg028Origemprograma = parametroGeraExtrato.ProgramaOrigem,
                Gg028OrigemPkid = parametroGeraExtrato.Origem_PKID.ToString(),
                Gg028DataMovimento = parametroGeraExtrato.Movimento_DataMovimento,
                Gg028DataReferente = DateTime.UtcNow.ToLocalTime(),
                Gg028Almoxid = parametroGeraExtrato.Almoxarifado_ID,
                Gg028KardexId = parametroGeraExtrato.Nav_CSICP_GG520?.Gg520KardexId,
                Gg028Produtoid = parametroGeraExtrato.Nav_CSICP_GG520?.Nav_GG008Kardex?.Gg008Produtoid,
                Gg028Saldoid = parametroGeraExtrato.GG520_ID,
                Gg028Transacaoid = parametroGeraExtrato.TransacaoID,
                Gg028Contaid = parametroGeraExtrato.ContaID,
                Gg028Usuarioid = parametroGeraExtrato.UsuarioID,
                Gg028QtdMovimento = parametroGeraExtrato.QuantidadeASerBaixada,
                Gg028ValorUnitario = parametroGeraExtrato.ValorUnitario,
                Gg028SaldoAnterior = parametroGeraExtrato.SaldoAnterior,
                Gg028DocProtocolnumber = parametroGeraExtrato.Protocolo_Documento,
                Gg028DoctoId = parametroGeraExtrato.Doc_PKID,
                Gg028NPdv = parametroGeraExtrato.NumeroPDV,
                Gg028NfOuCupom = parametroGeraExtrato.NF_ou_CUPOM,
                Gg028EntsaidaId = parametroGeraExtrato.GG028_Tmov_EntradaSaida_ID,
                Gg028NaturezaId = parametroGeraExtrato.StID_GG028_Nat_ID
            };
            _appDbContext.Add(gg028);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task CS_CriaExtratoOrigem(ParametroGeraExtrato_2 parametroGeraExtrato, int tenant)
        {
            CSICP_GG520? saldoEncontrado = await GetSaldoParaExtrato(parametroGeraExtrato.GG520_ID, tenant);

            decimal protocolo = await _generateProtocolo.Fcn_ProtocoloGeral(saldoEncontrado.Gg520Filialid!);

            CSICP_GG028 gg028 = new()
            {
                //teste do comit
                TenantId = tenant,
                Id = _generateId.GenerateUuId(),
                Gg028Filialid = saldoEncontrado.Gg520Filialid,
                Gg028DoctoId = parametroGeraExtrato.Doc_PKID,
                Gg028Origemprograma = parametroGeraExtrato.ProgramaOrigem,
                Gg028OrigemPkid = parametroGeraExtrato.in_origemID,
                Gg028DataMovimento = parametroGeraExtrato.Movimento_DataMovimento,
                Gg028DataReferente = DateTime.UtcNow.ToLocalTime(),
                Gg028Almoxid = saldoEncontrado.Gg520Almoxid,
                Gg028KardexId = parametroGeraExtrato.Nav_CSICP_GG520?.Gg520KardexId,
                Gg028Produtoid = saldoEncontrado.Nav_GG008Kardex!.Gg008Produtoid,
                Gg028Saldoid = parametroGeraExtrato.GG520_ID,
                Gg028Protocolnumber = protocolo.ToString(),
                Gg028Usuarioid = parametroGeraExtrato.UsuarioID,
                Gg028QtdMovimento = parametroGeraExtrato.QuantidadeASerBaixada,
                Gg028ValorUnitario = parametroGeraExtrato.ValorUnitario,

                Gg028DocProtocolnumber = parametroGeraExtrato.Protocolo_Documento,
                Gg028SaldoAnterior = parametroGeraExtrato.QuantidadeAnterior,
                Gg028EntsaidaId = parametroGeraExtrato.GG028_Tmov_EntradaSaida_ID,
                Gg028NaturezaId = parametroGeraExtrato.GG028_Nat_ID
            };
            _appDbContext.Add(gg028);
            //await _appDbContext.SaveChangesAsync();
        }

      

        public async Task CS_CriaExtratoOrigem(
            int inTenant,
            string? inGG028_ORIGEMPROGRAMA,
            string? inGG028_ORIGEM_PKID,
            string? inGG028_ORIGEM_DOC_PKID,
            DateTime? inGG028_DATA_MOVIMENTO, 
            string? inGG028_ALMOXID,
            string? inGG028_SALDOID,
            string? inGG028_TRANSACAOID,
            string? inGG028_CONTAID,
            string? inGG028_USUARIOID, 
            decimal? inGG028_QTD_MOVIMENTO, 
            decimal? inGG028_VALOR_UNITARIO, 
            decimal? inGG028_SALDO_ANTERIOR,
            int? inGG028_N_PDV,
            string? inProtocolo_Documento,
            decimal? inGG028_NF_OU_CUPOM,
            int? inEntSaida_ID,
            int? inNatureza_ID)
        {
            CSICP_GG520 saldoEncontrado = await GetSaldoParaExtrato(inGG028_SALDOID ?? "", inTenant);
            decimal protocolo = await _generateProtocolo.Fcn_ProtocoloGeral(saldoEncontrado.Gg520Filialid!);
            CSICP_GG028 gg028 = new()
            {
                TenantId = inTenant,
                Id = _generateId.GenerateUuId(),
                Gg028Filialid = saldoEncontrado.Gg520Filialid,
                Gg028Protocolnumber = protocolo.ToString(),
                Gg028Origemprograma = inGG028_ORIGEMPROGRAMA,
                Gg028OrigemPkid = inGG028_ORIGEM_PKID,
                Gg028DataMovimento = inGG028_DATA_MOVIMENTO,
                Gg028Almoxid = inGG028_ALMOXID,
                Gg028Saldoid = inGG028_SALDOID,
                Gg028Transacaoid = inGG028_TRANSACAOID,
                Gg028Contaid = inGG028_CONTAID,
                Gg028Usuarioid = inGG028_USUARIOID,
                Gg028QtdMovimento = inGG028_QTD_MOVIMENTO,
                Gg028ValorUnitario = inGG028_VALOR_UNITARIO,
                Gg028SaldoAnterior = inGG028_SALDO_ANTERIOR,
                Gg028NPdv = inGG028_N_PDV,
                Gg028DocProtocolnumber = inProtocolo_Documento,
                Gg028NfOuCupom = inGG028_NF_OU_CUPOM,
                Gg028EntsaidaId = inEntSaida_ID,
                Gg028NaturezaId = inNatureza_ID,              
                Gg028DataReferente = DateTime.UtcNow.ToLocalTime(),
                Gg028KardexId = saldoEncontrado.Gg520KardexId,
                Gg028Produtoid = saldoEncontrado.Nav_GG008Kardex?.Gg008Produtoid,
                Gg028DoctoId = inGG028_ORIGEM_DOC_PKID,
            };
            _appDbContext.Add(gg028);
            await _appDbContext.SaveChangesAsync();
        }

        private async Task<CSICP_GG520> GetSaldoParaExtrato(string gg520Id, int tenant)
        {
            IQueryable<CSICP_GG520> query = GetQueryGG520ParaExtrato(gg520Id, tenant);

            CSICP_GG520? saldoEncontrado = await query.FirstOrDefaultAsync();
            if (saldoEncontrado == null)
            {
                throw new Exception("Saldo não encontrado para o ID fornecido ao gerar extrato em CS_CriaExtratoOrigem.");
            }

            return saldoEncontrado;
        }

        private IQueryable<CSICP_GG520> GetQueryGG520ParaExtrato(string gg520_id, int tenant)
        {
            return from _gg520 in _appDbContext.OsusrE9aCsicpGg520s

                   join _gg008Kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes
                   on _gg520.Gg520KardexId equals _gg008Kdx.Gg008Kardexid into _gg008KdxJoin
                   from _gg008Kdx in _gg008KdxJoin.DefaultIfEmpty()

                   join _gg008 in _appDbContext.OsusrE9aCsicpGg008s
                   on _gg008Kdx.Gg008Produtoid equals _gg008.Id into _gg008Join
                   from _gg008 in _gg008Join.DefaultIfEmpty()

                   where _gg520.TenantId == tenant
                   where _gg520.Id == gg520_id

                   select new CSICP_GG520
                   {
                       TenantId = _gg520.TenantId,
                       Id = _gg520.Id,
                       Gg520Saldo = _gg520.Gg520Saldo,
                       Gg520KardexId = _gg520.Gg520KardexId,
                       Gg520Almoxid = _gg520.Gg520Almoxid,
                       Gg520Descricaosaldo = _gg520.Gg520Descricaosaldo,
                       Gg520NsNumerosaldo = _gg520.Gg520NsNumerosaldo,
                       Gg520Filialid = _gg520.Gg520Filialid,
                       Gg520Filial = _gg520.Gg520Filial,
                       Gg520Produto = _gg520.Gg520Produto,
                       Nav_GG008Kardex = _gg008Kdx != null ? new CSICP_GG008Kdx
                       {
                           TenantId = _gg008Kdx.TenantId,
                           Gg008Kardexid = _gg008Kdx.Gg008Kardexid,
                           Gg008Produtoid = _gg008Kdx.Gg008Produtoid,
                           NavGG008Produto = _gg008 != null ? new CSICP_GG008
                           {
                               TenantId = _gg520.TenantId,
                               Id = _gg008.Id
                           } : null
                       } : null
                   };
        }
    }
}

