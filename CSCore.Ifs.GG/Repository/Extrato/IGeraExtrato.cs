namespace CSCore.Ifs.GG.Repository.Extrato
{
    public interface IGeraExtrato
    {
        Task CS_CriaExtratoOrigem(ParametroGeraExtrato parametroGeraExtrato, int tenant);
        Task CS_CriaExtratoOrigem(ParametroGeraExtrato_2 parametroGeraExtrato, int tenant);

        Task CS_CriaExtratoOrigem(
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
        int? inNatureza_ID);
    }
}
