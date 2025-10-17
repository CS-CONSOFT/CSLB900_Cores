using CSLB900.MSTools.Calculos.MemoriaDeCalculoV2;

namespace CSCore.Tests.Financeiro.Service.MemoriaDeCalculoV2;

public class MemoriaDeCalculoV2Tests
{
    #region Teste Pagamento por Dias

    [Fact]
    public void GerarMemoriaCalculo_TipoDiasPagamento_DeveRetornarMemoriaCorreta()
    {
        // Arrange
        var parameters = new CS_Get_Qtd_ParcelasParameters(
            InStID_BB008_TP_DIAS: 1,
            InStID_BB008_ParcelaDias: 2,
            InStID_BB008_ParcelaMes: 3,
            InStID_BB008_AVista: 4
        );

        var memoriaItem = new MemoriaCalculoItem(
            InNumeroParcelas: 3,
            CondicaoPagamento: "0;30;60", // [0] qtd parcelas (ignorado), [1-N] dias de vencimento
            BB008_Tipo_ID: 1, // Tipo DIAS
            Prm_Total_Fatura: 1000m,
            Prm_Valor_Entrada: 0m,
            Prm_1o_Vencto: new DateOnly(2024, 1, 15),
            PrmCS_Get_Qtd_ParcelasParameters: parameters
        );

        // Act
        var resultado = MemoriaCalculoGenerator.GerarMemoriaCalculo(memoriaItem);

        // Assert
        Assert.Equal(3, resultado.Count);
        
        // Primeira parcela
        Assert.Equal(1, resultado[0].Parcela);
        Assert.Equal(new DateOnly(2024, 1, 15), resultado[0].Data_Vencto); // Data base + 0 dias
        Assert.Equal(333m, resultado[0].Valor_Parcela); // 1000/3 = 333.33, arredondado + resto
        Assert.Equal(3, resultado[0].Nro_Parcelas);

        // Segunda parcela
        Assert.Equal(2, resultado[1].Parcela);
        Assert.Equal(new DateOnly(2024, 2, 14), resultado[1].Data_Vencto); // Data base + 30 dias
        Assert.Equal(333m, resultado[1].Valor_Parcela);
        Assert.Equal(3, resultado[1].Nro_Parcelas);

        // Terceira parcela
        Assert.Equal(3, resultado[2].Parcela);
        Assert.Equal(new DateOnly(2024, 3, 15), resultado[2].Data_Vencto); // Data base + 60 dias
        Assert.Equal(333m, resultado[2].Valor_Parcela);
        Assert.Equal(3, resultado[2].Nro_Parcelas);
    }

    [Fact]
    public void GerarMemoriaCalculo_TipoDiasPagamento_ComValorComResto_DeveDistribuirResto()
    {
        // Arrange
        var parameters = new CS_Get_Qtd_ParcelasParameters(
            InStID_BB008_TP_DIAS: 1,
            InStID_BB008_ParcelaDias: 2,
            InStID_BB008_ParcelaMes: 3,
            InStID_BB008_AVista: 4
        );

        var memoriaItem = new MemoriaCalculoItem(
            InNumeroParcelas: 3,
            CondicaoPagamento: "0;15;45", 
            BB008_Tipo_ID: 1,
            Prm_Total_Fatura: 100m, // Valor que gera resto na divisão
            Prm_Valor_Entrada: 0m,
            Prm_1o_Vencto: new DateOnly(2024, 1, 10),
            PrmCS_Get_Qtd_ParcelasParameters: parameters
        );

        // Act
        var resultado = MemoriaCalculoGenerator.GerarMemoriaCalculo(memoriaItem);

        // Assert
        Assert.Equal(3, resultado.Count);
        
        // Verifica se a soma das parcelas é igual ao total
        var somaTotal = resultado.Sum(r => r.Valor_Parcela);
        Assert.Equal(100m, somaTotal);
    }

    #endregion


    #region Teste Pagamento por Período (Meses)

    [Fact]
    public void GerarMemoriaCalculo_TipoPorPeriodoMeses_DeveGerarParcelasComIntervaloMeses()
    {
        // Arrange
        var parameters = new CS_Get_Qtd_ParcelasParameters(
            InStID_BB008_TP_DIAS: 1,
            InStID_BB008_ParcelaDias: 2,
            InStID_BB008_ParcelaMes: 3,
            InStID_BB008_AVista: 4
        );

        var memoriaItem = new MemoriaCalculoItem(
            InNumeroParcelas: 3,
            CondicaoPagamento: "3;0;1", // [0] qtd parcelas, [1] entrada, [2] intervalo meses
            BB008_Tipo_ID: 3, // Tipo PARCELA MÊS
            Prm_Total_Fatura: 900m,
            Prm_Valor_Entrada: 0m,
            Prm_1o_Vencto: new DateOnly(2024, 1, 15),
            PrmCS_Get_Qtd_ParcelasParameters: parameters
        );

        // Act
        var resultado = MemoriaCalculoGenerator.GerarMemoriaCalculo(memoriaItem);

        // Assert
        Assert.Equal(3, resultado.Count);

        // Primeira parcela
        Assert.Equal(1, resultado[0].Parcela);
        Assert.Equal(new DateOnly(2024, 1, 15), resultado[0].Data_Vencto);
        Assert.Equal(300m, resultado[0].Valor_Parcela); // 900/3 = 300
        Assert.Equal(3, resultado[0].Nro_Parcelas);

        // Segunda parcela (+ 1 mês)
        Assert.Equal(2, resultado[1].Parcela);
        Assert.Equal(new DateOnly(2024, 2, 15), resultado[1].Data_Vencto);
        Assert.Equal(300m, resultado[1].Valor_Parcela);

        // Terceira parcela (+ 1 mês)
        Assert.Equal(3, resultado[2].Parcela);
        Assert.Equal(new DateOnly(2024, 3, 15), resultado[2].Data_Vencto);
        Assert.Equal(300m, resultado[2].Valor_Parcela);
    }

  
    #region Testes com CS_Get_Qtd_Parcelas

    [Fact]
    public void GerarMemoriaCalculo_ComNumeroParcelas_Null_DeveUsarCS_Get_Qtd_Parcelas()
    {
        // Arrange
        var parameters = new CS_Get_Qtd_ParcelasParameters(
            InStID_BB008_TP_DIAS: 1,
            InStID_BB008_ParcelaDias: 2,
            InStID_BB008_ParcelaMes: 3,
            InStID_BB008_AVista: 4
        );

        var memoriaItem = new MemoriaCalculoItem(
            InNumeroParcelas: null, // Força uso do CS_Get_Qtd_Parcelas
            CondicaoPagamento: "0;30;60", // Para tipo dias: retorna Length = 3
            BB008_Tipo_ID: 1, // Tipo DIAS
            Prm_Total_Fatura: 600m,
            Prm_Valor_Entrada: 0m,
            Prm_1o_Vencto: new DateOnly(2024, 4, 1),
            PrmCS_Get_Qtd_ParcelasParameters: parameters
        );

        // Act
        var resultado = MemoriaCalculoGenerator.GerarMemoriaCalculo(memoriaItem);

        // Assert
        Assert.Equal(3, resultado.Count); // CS_Get_Qtd_Parcelas retorna 3 para tipo dias
    }

    [Fact]
    public void GerarMemoriaCalculo_ComNumeroParcelas_Zero_DeveUsarCS_Get_Qtd_Parcelas()
    {
        // Arrange
        var parameters = new CS_Get_Qtd_ParcelasParameters(
            InStID_BB008_TP_DIAS: 1,
            InStID_BB008_ParcelaDias: 2,
            InStID_BB008_ParcelaMes: 3,
            InStID_BB008_AVista: 4
        );

        var memoriaItem = new MemoriaCalculoItem(
            InNumeroParcelas: 0, // Força uso do CS_Get_Qtd_Parcelas
            CondicaoPagamento: "5;0;1", // Para tipo mês: retorna int.Parse([0]) = 5
            BB008_Tipo_ID: 3, // Tipo MÊS
            Prm_Total_Fatura: 1000m,
            Prm_Valor_Entrada: 0m,
            Prm_1o_Vencto: new DateOnly(2024, 5, 1),
            PrmCS_Get_Qtd_ParcelasParameters: parameters
        );

        // Act
        var resultado = MemoriaCalculoGenerator.GerarMemoriaCalculo(memoriaItem);

        // Assert
        Assert.Equal(5, resultado.Count); // CS_Get_Qtd_Parcelas retorna 5 para tipo mês
    }

    #endregion

    #region Testes de Validação

    [Fact]
    public void GerarMemoriaCalculo_ComNumeroParcelas_MenorQueZero_DeveLancarException()
    {
        // Arrange
        var parameters = new CS_Get_Qtd_ParcelasParameters(
            InStID_BB008_TP_DIAS: 1,
            InStID_BB008_ParcelaDias: 2,
            InStID_BB008_ParcelaMes: 3,
            InStID_BB008_AVista: 4
        );

        var memoriaItem = new MemoriaCalculoItem(
            InNumeroParcelas: -1, // Valor inválido
            CondicaoPagamento: "0;30;60",
            BB008_Tipo_ID: 1,
            Prm_Total_Fatura: 1000m,
            Prm_Valor_Entrada: 0m,
            Prm_1o_Vencto: new DateOnly(2024, 1, 1),
            PrmCS_Get_Qtd_ParcelasParameters: parameters
        );

        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => 
            MemoriaCalculoGenerator.GerarMemoriaCalculo(memoriaItem));
        
        Assert.Equal("Número de parcelas deve ser maior que zero.", exception.Message);
    }

    [Fact]
    public void GerarMemoriaCalculo_ValoresFinanceirosNulos_DeveConsiderarZero()
    {
        // Arrange
        var parameters = new CS_Get_Qtd_ParcelasParameters(
            InStID_BB008_TP_DIAS: 1,
            InStID_BB008_ParcelaDias: 2,
            InStID_BB008_ParcelaMes: 3,
            InStID_BB008_AVista: 4
        );

        var memoriaItem = new MemoriaCalculoItem(
            InNumeroParcelas: 1,
            CondicaoPagamento: "",
            BB008_Tipo_ID: 4, // À vista
            Prm_Total_Fatura: null, // Valor nulo
            Prm_Valor_Entrada: null, // Valor nulo
            Prm_1o_Vencto: new DateOnly(2024, 1, 1),
            PrmCS_Get_Qtd_ParcelasParameters: parameters
        );

        // Act
        var resultado = MemoriaCalculoGenerator.GerarMemoriaCalculo(memoriaItem);

        // Assert
        Assert.Single(resultado);
        Assert.Equal(0m, resultado[0].Valor_Parcela); // Deve ser 0 quando valores são nulos
    }

    #endregion

    #region Testes de Casos Complexos

    [Fact]
    public void GerarMemoriaCalculo_CondicaoPagamentoComplexaDias_DeveProcessarCorretamente()
    {
        // Arrange
        var parameters = new CS_Get_Qtd_ParcelasParameters(
            InStID_BB008_TP_DIAS: 1,
            InStID_BB008_ParcelaDias: 2,
            InStID_BB008_ParcelaMes: 3,
            InStID_BB008_AVista: 4
        );

        var memoriaItem = new MemoriaCalculoItem(
            InNumeroParcelas: 5,
            CondicaoPagamento: "0;7;14;21;30", // 5 parcelas em dias específicos
            BB008_Tipo_ID: 1,
            Prm_Total_Fatura: 2500m,
            Prm_Valor_Entrada: 500m,
            Prm_1o_Vencto: new DateOnly(2024, 1, 1),
            PrmCS_Get_Qtd_ParcelasParameters: parameters
        );

        // Act
        var resultado = MemoriaCalculoGenerator.GerarMemoriaCalculo(memoriaItem);

        // Assert
        Assert.Equal(5, resultado.Count);
        
        // Verifica se todas as datas estão corretas
        Assert.Equal(new DateOnly(2024, 1, 1), resultado[0].Data_Vencto);  // +0 dias
        Assert.Equal(new DateOnly(2024, 1, 8), resultado[1].Data_Vencto);  // +7 dias
        Assert.Equal(new DateOnly(2024, 1, 15), resultado[2].Data_Vencto); // +14 dias
        Assert.Equal(new DateOnly(2024, 1, 22), resultado[3].Data_Vencto); // +21 dias
        Assert.Equal(new DateOnly(2024, 1, 31), resultado[4].Data_Vencto); // +30 dias

        // Verifica se a soma total está correta
        var somaTotal = resultado.Sum(r => r.Valor_Parcela);
        Assert.Equal(2000m, somaTotal); // Total - Entrada
    }

    [Fact]
    public void GerarMemoriaCalculo_Cenario_Real_ParcelaMensal_12x_DeveProcessarCorretamente()
    {
        // Arrange - Simulando um cenário real de 12 parcelas mensais
        var parameters = new CS_Get_Qtd_ParcelasParameters(
            InStID_BB008_TP_DIAS: 1,
            InStID_BB008_ParcelaDias: 2,
            InStID_BB008_ParcelaMes: 3,
            InStID_BB008_AVista: 4
        );

        var memoriaItem = new MemoriaCalculoItem(
            InNumeroParcelas: 12,
            CondicaoPagamento: "12;0;1", // 12 parcelas, sem entrada, intervalo 1 mês
            BB008_Tipo_ID: 3, // Tipo MÊS
            Prm_Total_Fatura: 12000m,
            Prm_Valor_Entrada: 0m,
            Prm_1o_Vencto: new DateOnly(2024, 1, 10),
            PrmCS_Get_Qtd_ParcelasParameters: parameters
        );

        // Act
        var resultado = MemoriaCalculoGenerator.GerarMemoriaCalculo(memoriaItem);

        // Assert
        Assert.Equal(12, resultado.Count);
        
        // Verifica algumas datas chave
        Assert.Equal(new DateOnly(2024, 1, 10), resultado[0].Data_Vencto);  // Janeiro
        Assert.Equal(new DateOnly(2024, 6, 10), resultado[5].Data_Vencto);  // Junho
        Assert.Equal(new DateOnly(2024, 12, 10), resultado[11].Data_Vencto); // Dezembro

        // Verifica se todas as parcelas têm o mesmo valor
        Assert.All(resultado, r => Assert.Equal(1000m, r.Valor_Parcela));
        
        // Verifica se a soma total está correta
        var somaTotal = resultado.Sum(r => r.Valor_Parcela);
        Assert.Equal(12000m, somaTotal);
    }

    #endregion
    #endregion
}