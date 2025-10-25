//using CSLB900.MSTools.Calculos.MemoriaDeCalculoV2;

//namespace CSCore.Tests.Financeiro.Service.MemoriaDeCalculoV2;

//public class MemoriaDeCalculoV2EdgeCasesTests
//{
//    #region Testes de Arredondamento e Distribuição de Centavos

   
   

//    #endregion

//    #region Testes de Datas Limites

//    [Fact]
//    public void GerarMemoriaCalculo_DataFimDeAno_DeveCalcularProximoAnoCorretamente()
//    {
//        // Arrange
//        var parameters = new CS_Get_Qtd_ParcelasParameters(
//            InStID_BB008_TP_DIAS: 1,
//            InStID_BB008_ParcelaDias: 2,
//            InStID_BB008_ParcelaMes: 3,
//            InStID_BB008_AVista: 4
//        );

//        var memoriaItem = new MemoriaCalculoItem(
//            InNumeroParcelas: 3,
//            CondicaoPagamento: "3;0;1", // 3 parcelas mensais
//            BB008_Tipo_ID: 3, // Tipo MÊS
//            Prm_Total_Fatura: 1500m,
//            Prm_Valor_Entrada: 0m,
//            Prm_1o_Vencto: new DateOnly(2023, 11, 15), // Novembro
//            PrmCS_Get_Qtd_ParcelasParameters: parameters
//        );

//        // Act
//        var resultado = MemoriaCalculoGenerator.GerarMemoriaCalculo(memoriaItem);

//        // Assert
//        Assert.Equal(3, resultado.Count);
//        Assert.Equal(new DateOnly(2023, 11, 15), resultado[0].Data_Vencto); // Novembro 2023
//        Assert.Equal(new DateOnly(2023, 12, 15), resultado[1].Data_Vencto); // Dezembro 2023
//        Assert.Equal(new DateOnly(2024, 1, 15), resultado[2].Data_Vencto);  // Janeiro 2024
//    }

//    [Fact]
//    public void GerarMemoriaCalculo_DataAnoBissexto_DeveCalcularCorretamente()
//    {
//        // Arrange
//        var parameters = new CS_Get_Qtd_ParcelasParameters(
//            InStID_BB008_TP_DIAS: 1,
//            InStID_BB008_ParcelaDias: 2,
//            InStID_BB008_ParcelaMes: 3,
//            InStID_BB008_AVista: 4
//        );

//        var memoriaItem = new MemoriaCalculoItem(
//            InNumeroParcelas: 2,
//            CondicaoPagamento: "2;0;1",
//            BB008_Tipo_ID: 3, // Tipo MÊS
//            Prm_Total_Fatura: 1000m,
//            Prm_Valor_Entrada: 0m,
//            Prm_1o_Vencto: new DateOnly(2024, 2, 29), // 29 de fevereiro (ano bissexto)
//            PrmCS_Get_Qtd_ParcelasParameters: parameters
//        );

//        // Act
//        var resultado = MemoriaCalculoGenerator.GerarMemoriaCalculo(memoriaItem);

//        // Assert
//        Assert.Equal(2, resultado.Count);
//        Assert.Equal(new DateOnly(2024, 2, 29), resultado[0].Data_Vencto); // 29 fev 2024
//        Assert.Equal(new DateOnly(2024, 3, 29), resultado[1].Data_Vencto); // 29 mar 2024
//    }

//    [Fact]
//    public void GerarMemoriaCalculo_DataFinalDoMes_DeveAjustarProximoMes()
//    {
//        // Arrange
//        var parameters = new CS_Get_Qtd_ParcelasParameters(
//            InStID_BB008_TP_DIAS: 1,
//            InStID_BB008_ParcelaDias: 2,
//            InStID_BB008_ParcelaMes: 3,
//            InStID_BB008_AVista: 4
//        );

//        var memoriaItem = new MemoriaCalculoItem(
//            InNumeroParcelas: 3,
//            CondicaoPagamento: "3;0;1",
//            BB008_Tipo_ID: 3, // Tipo MÊS
//            Prm_Total_Fatura: 1500m,
//            Prm_Valor_Entrada: 0m,
//            Prm_1o_Vencto: new DateOnly(2024, 1, 31), // 31 de janeiro
//            PrmCS_Get_Qtd_ParcelasParameters: parameters
//        );

//        // Act
//        var resultado = MemoriaCalculoGenerator.GerarMemoriaCalculo(memoriaItem);

//        // Assert
//        Assert.Equal(3, resultado.Count);
//        Assert.Equal(new DateOnly(2024, 1, 31), resultado[0].Data_Vencto); // 31 jan
//        Assert.Equal(new DateOnly(2024, 2, 29), resultado[1].Data_Vencto); // 29 fev (ajuste automático)
//        Assert.Equal(new DateOnly(2024, 3, 29), resultado[2].Data_Vencto); // 29 mar (mantém o dia ajustado)
//    }

//    #endregion

//    #region Testes de Performance com Muitas Parcelas

//    #endregion

//    #region Testes de Integração com Diferentes Configurações

   

//    #endregion

//    #region Testes de Casos Específicos do Negócio

//    [Fact]
//    public void GerarMemoriaCalculo_CenarioRealCartaoCredito_DeveProcessarCorretamente()
//    {
//        // Arrange - Simulando parcelamento de cartão de crédito
//        var parameters = new CS_Get_Qtd_ParcelasParameters(
//            InStID_BB008_TP_DIAS: 1,
//            InStID_BB008_ParcelaDias: 2,
//            InStID_BB008_ParcelaMes: 3,
//            InStID_BB008_AVista: 4
//        );

//        var memoriaItem = new MemoriaCalculoItem(
//            InNumeroParcelas: 10,
//            CondicaoPagamento: "10;0;1", // 10x sem juros
//            BB008_Tipo_ID: 3, // Tipo MÊS
//            Prm_Total_Fatura: 1299.90m, // Valor típico de compra
//            Prm_Valor_Entrada: 0m,
//            Prm_1o_Vencto: new DateOnly(2024, 2, 10), // Vencimento cartão
//            PrmCS_Get_Qtd_ParcelasParameters: parameters
//        );

//        // Act
//        var resultado = MemoriaCalculoGenerator.GerarMemoriaCalculo(memoriaItem);

//        // Assert
//        Assert.Equal(10, resultado.Count);

//        // Verifica se o valor está distribuído corretamente
//        var somaTotal = resultado.Sum(r => r.Valor_Parcela);
//        Assert.Equal(1299.90m, somaTotal);

//        // A maioria das parcelas deve ter valor 129.99
//        var parcelasComValorBase = resultado.Count(r => r.Valor_Parcela == 129.99m);
//        Assert.True(parcelasComValorBase >= 9); // Pelo menos 9 parcelas com valor base
//    }


//    #endregion
//}