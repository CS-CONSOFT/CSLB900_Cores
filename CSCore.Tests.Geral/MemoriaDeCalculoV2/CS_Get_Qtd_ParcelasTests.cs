using CSLB900.MSTools.Calculos.MemoriaDeCalculoV2;

namespace CSCore.Tests.Geral.MemoriaDeCalculoV2;

public class CS_Get_Qtd_ParcelasTests
{
    [Theory]
    [InlineData("0;30;60", 1, 3)] // Tipo Dias - retorna quantidade de elementos
    [InlineData("10;15;30;45;60", 1, 5)] // Tipo Dias - 5 elementos
    [InlineData("0", 1, 1)] // Tipo Dias - 1 elemento
    public void Executar_TipoDias_DeveRetornarQuantidadeElementos(string condicaoPagamento, int tipoDias, int quantidadeEsperada)
    {
        // Arrange
        var parameters = new CS_Get_Qtd_ParcelasParameters(
            InStID_BB008_TP_DIAS: tipoDias,
            InStID_BB008_ParcelaDias: 2,
            InStID_BB008_ParcelaMes: 3,
            InStID_BB008_AVista: 4
        );

        // Act
        var resultado = CS_Get_Qtd_Parcelas.Executar(condicaoPagamento, tipoDias, parameters);

        // Assert
        Assert.Equal(quantidadeEsperada, resultado.Qtd_Parcelas);
        Assert.Equal(0, resultado.Entrada); // Tipo dias sempre retorna entrada 0
    }

    [Theory]
    [InlineData("12;0;1", 2, 12, 0)] // 12 parcelas, sem entrada
    [InlineData("6;100;1", 2, 6, 100)] // 6 parcelas, entrada 100
    [InlineData("3;50;30", 3, 3, 50)] // 3 parcelas, entrada 50 (tipo mês)
    public void Executar_TipoParcelaDiasOuMes_DeveRetornarValoresCorretos(
        string condicaoPagamento, int tipoId, int qtdEsperada, int entradaEsperada)
    {
        // Arrange
        var parameters = new CS_Get_Qtd_ParcelasParameters(
            InStID_BB008_TP_DIAS: 1,
            InStID_BB008_ParcelaDias: 2,
            InStID_BB008_ParcelaMes: 3,
            InStID_BB008_AVista: 4
        );

        // Act
        var resultado = CS_Get_Qtd_Parcelas.Executar(condicaoPagamento, tipoId, parameters);

        // Assert
        Assert.Equal(qtdEsperada, resultado.Qtd_Parcelas);
        Assert.Equal(entradaEsperada, resultado.Entrada);
    }

    [Theory]
    [InlineData(4)] // À vista
    [InlineData(5)] // Tipo não mapeado
    [InlineData(99)] // Tipo qualquer
    public void Executar_TipoAVistaOuOutro_DeveRetornarUmaParcela(int tipoId)
    {
        // Arrange
        var parameters = new CS_Get_Qtd_ParcelasParameters(
            InStID_BB008_TP_DIAS: 1,
            InStID_BB008_ParcelaDias: 2,
            InStID_BB008_ParcelaMes: 3,
            InStID_BB008_AVista: 4
        );

        // Act
        var resultado = CS_Get_Qtd_Parcelas.Executar("qualquer;coisa", tipoId, parameters);

        // Assert
        Assert.Equal(1, resultado.Qtd_Parcelas);
        Assert.Equal(0, resultado.Entrada);
    }

    [Fact]
    public void Executar_CondicaoPagamentoVazia_TipoDias_DeveRetornarUmaParcela()
    {
        // Arrange
        var parameters = new CS_Get_Qtd_ParcelasParameters(
            InStID_BB008_TP_DIAS: 1,
            InStID_BB008_ParcelaDias: 2,
            InStID_BB008_ParcelaMes: 3,
            InStID_BB008_AVista: 4
        );

        // Act
        var resultado = CS_Get_Qtd_Parcelas.Executar("", 1, parameters);

        // Assert
        Assert.Equal(1, resultado.Qtd_Parcelas); // String vazia gera 1 elemento no split
        Assert.Equal(0, resultado.Entrada);
    }
}