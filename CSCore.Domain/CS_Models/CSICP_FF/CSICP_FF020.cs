using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF020
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff020Filialid { get; set; }

    public int? Ff020Filial { get; set; }

    public int? Ff020Emitidorecid { get; set; }

    public string? Ff020EmitidoRecebido { get; set; }

    public DateTime? Ff020DataEntrada { get; set; }

    public DateTime? Ff020DataCompensacao { get; set; }

    public string? Ff020Contaemitenteid { get; set; }

    public string? Ff020Contatoemitenteid { get; set; }

    public int? Ff020CodCliEmitente { get; set; }

    public string? Ff020ClienteEmitente { get; set; }

    public string? Ff020TelefoneCli { get; set; }

    public string? Ff020Agencia { get; set; }

    public int? Ff020Ccorrente { get; set; }

    public string? Ff020DvCcorrente { get; set; }

    public int? Ff020Banco { get; set; }

    public string? Ff020Agcob { get; set; }

    public string? Ff020Agcobradorid { get; set; }

    public string? Ff020NCheque { get; set; }

    public decimal? Ff020ValorCheque { get; set; }

    public string? Ff020Cidadeid { get; set; }

    public string? Ff020Ccustoid { get; set; }

    public string? Ff020Usuarioproprid { get; set; }

    public string? Ff020Tipocobrancaid { get; set; }

    public int? Ff020PracaCidade { get; set; }

    public int? Ff020CentroCusto { get; set; }

    public int? Ff020Responsavel { get; set; }

    public int? Ff020TipoCobranca { get; set; }

    public string? Ff020Historico { get; set; }

    public string? Ff020SituacaoAtual { get; set; }

    public int? Ff020Seqbxmovimento { get; set; }

    public DateTime? Ff020Dtultmovimento { get; set; }

    public bool? Ff020Confirmabxlogico { get; set; }

    public string? Ff020Usuariomovto { get; set; }

    public DateTime? Ff020DataMovimento { get; set; }

    public DateTime? Ff020HoraMovimento { get; set; }

    public string? Ff020PfxTituloCr { get; set; }

    public decimal? Ff020NTituloCr { get; set; }

    public string? Ff020SfxTituloCr { get; set; }

    public string? Ff020TipoCliente { get; set; }

    public decimal? Ff020CnpjCpf { get; set; }

    public decimal? Ff020InscEstadualRg { get; set; }

    public int? Ff020Situacao { get; set; }

    public bool? Ff020Isactive { get; set; }

    public string? Ff020UfId { get; set; }

    public string? Ff020PaisId { get; set; }

    public string? Ff020Protocolnumber { get; set; }
}
