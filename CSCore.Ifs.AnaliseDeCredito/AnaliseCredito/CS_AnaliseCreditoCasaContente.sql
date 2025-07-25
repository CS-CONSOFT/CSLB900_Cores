/*
CPFs
'17121876272' --'02150846241'
IDS
9a7ba9e7-b84f-43ba-b7e5-bebc67765556
*/

declare @tenant_id int
declare @idconta varchar (36)
-- Variável E_b (Média Salarial do Bairro)
declare @e_b decimal (2,1)
-- Pesos atribuídos para cada variável (ajustáveis de acordo com a importância desejada)
declare @wC decimal (3,2)
declare @wP decimal (3,2)
declare @wE decimal (3,2)
declare @wR decimal (3,2)
--
declare @Renda decimal (38,8)
declare @F decimal (3,2) -- Fator de Ajuste

set @tenant_id = 135
set @idconta = '01b790d4-c480-462e-971b-b8bd5aa292d3' --'9a7ba9e7-b84f-43ba-b7e5-bebc67765556'; -- Agnaldo Barros

set @Renda = 5000
set @wc = 0.2
set @wP = 0.25
set @wE = 0.15
set @wR = 0.40
set @F	= 0.5

/*
•	0,800 a 1,000 Muito Alto 	E_b = 1
•	0,700 a 0,799 Alto			E_b = 0.7	
•	0,600 a 0,699 Médio			E_b = 0.6
•	0,500 a 0,599 Baixo			E_b = 0.5
•	0,000 a 0,499 Muito Baixo	E_b = 0.4

*/

Declare @IDH_R Decimal (4, 3)
set @IDH_R = 0.556

set @e_b =
CASE
		WHEN @IDH_R >= 0.800 AND @IDH_R <= 1 THEN 1
		WHEN @IDH_R >= 0.700 AND @IDH_R <= 0.799 THEN 0.7
		WHEN @IDH_R >= 0.600 AND @IDH_R <= 0.699 THEN 0.6
		WHEN @IDH_R >= 0.500 AND @IDH_R <= 0.599 THEN 0.5
		WHEN @IDH_R >= 0.000 AND @IDH_R <= 0.499 THEN 0.4
        END;

/*
	    Atrasos frequentes:		P = 0.2
		Atrasos moderados:		P = 0.5
		Pagamentos pontuais:	P = 0.8
		Sempre paga no prazo:	P = 1
*/
-- 2.	Variável P (Comportamento de Pagamentos)
Declare @Peso_AF Decimal (4, 3)
Declare @Peso_AM Decimal (4, 3)
Declare @Peso_PP Decimal (4, 3)
Declare @Peso_SP Decimal (4, 3)
SET @Peso_AF = 0.2
SET @Peso_AM = 0.5
SET @Peso_PP = 0.8
SET @Peso_SP = 1

----- Parametros para o segundo calculo Credito com Score
declare @TS decimal (2,1) -- Taxa de comprometimento ajustada conforme o score de credito do cliente
declare @ScoreClear decimal (5,2) -- Score ClearSale
set @ScoreClear = 413

/*
	Escala para T(S) baseada no Score de Crédito:
	Score entre 800-999: T(S) = 0.4 (40% da renda disponível para crédito)
	Score entre 600-799: T(S) = 0.3 (30% da renda disponível para crédito)
	Score entre 400-599: T(S) = 0.2 (20% da renda disponível para crédito)
	Score abaixo de 400: T(S) = 0.1 (10% da renda disponível para crédito)
*/

set @TS =
CASE
		WHEN @ScoreClear >= 800 AND @ScoreClear <= 900 THEN 0.4
		WHEN @ScoreClear >= 600 AND @ScoreClear <= 799 THEN 0.3
		WHEN @ScoreClear >= 400 AND @ScoreClear <= 599 THEN 0.2
		WHEN @ScoreClear <  400 THEN 0.1
        END;


--- Parametros para o Ternceiro Calculo a Media de credito
/*
((w_S * Crédito Com Score) + (w_N * Crédito Sem Score)) / (w_S + w_N) 
*/

declare @wS decimal (3,2)
declare @wN decimal (3,2)
set @wS = 0.6
set @wN = 0.4
;


-- Define the CTE expression name and column list.

WITH 
CTE_ObtemDados
(
 Conta_ID 
,Qtd_Comportamento_compras
,Qtd_AtrasosFreq
,Qtd_AtrasosModerados
,Qtd_PagtosPontuais
,Qtd_SemprePagaPrazo
,Qtd_Titulos
)
AS
-- Define the CTE query.
(
		-- RECUPERA C = Comportamento de compras
		SELECT
		@idconta as Conta_ID
		,COUNT(csicp_dd040.DD040_Id) AS Qtd_Compor_compras --[C=Comportamento Compras],

		-- RECUPERA ATRASOS FREQUENTES
		,(SELECT COUNT (*) * @Peso_AF AS AF FROM
		 OSUSR_E9A_CSICP_FF103 AS FF103
		 INNER JOIN OSUSR_E9A_CSICP_FF102 AS FF102 ON FF102.ID = FF103.FF102_ID
		 WHERE ff103.TENANT_ID = @tenant_id and FF102.FF102_TIPOREGISTRO = 1
		 and (FF102.FF102_DATA_EMISSAO <= GETDATE() AND FF102.FF102_DATA_EMISSAO >= DATEADD(YEAR, -1, GETDATE()) )
		 AND  DATEDIFF(DAY,FF102.FF102_DATA_VENCIMENTO, FF103.FF103_DATA_BAIXA) > 15
		 AND FF102.FF102_CONTAID = @idconta
		 and (FF103_BAIXADO = 1
		 and FF103_ESTORNADO = 0
		 and FF103_CANCELADO = 0)
		 and FF103_TPBAIXAID IN (SELECT ID from csicp_ff103_TpBai WHERE [LABEL] = 'Baixa')
		 )
		 AS Qtd_AtrasosFreq --[P.AF=Atrasos Frequentes],

		  -- RECUPERA ATRASOS MODERADOS
		 ,(SELECT COUNT (*) * @Peso_AM AS AM FROM
		 OSUSR_E9A_CSICP_FF103 AS FF103
		 INNER JOIN OSUSR_E9A_CSICP_FF102 AS FF102 ON FF102.ID = FF103.FF102_ID

		 WHERE ff103.TENANT_ID = @tenant_id
		 AND (FF102.FF102_DATA_EMISSAO <= GETDATE() AND FF102.FF102_DATA_EMISSAO >= DATEADD(YEAR, -1, GETDATE()) )
		 AND ( DATEDIFF(DAY,FF102.FF102_DATA_VENCIMENTO, FF103.FF103_DATA_BAIXA) >= 6 AND DATEDIFF(DAY,FF102.FF102_DATA_VENCIMENTO, FF103.FF103_DATA_BAIXA) <= 15)
		 AND FF102.FF102_CONTAID = @idconta
		 and (FF103_BAIXADO = 1
		 and FF103_ESTORNADO = 0
		 and FF103_CANCELADO = 0)
		 and FF103_TPBAIXAID IN (SELECT ID from csicp_ff103_TpBai WHERE [LABEL] = 'Baixa')
		 )

		 AS Qtd_AtrasosModerados --[P.AM=Atrasos Moderados],

		 -- RECUPERA PAGTO PONTUAL
		 ,(SELECT COUNT (*) * @Peso_PP AS PP FROM
		 OSUSR_E9A_CSICP_FF103 AS FF103
		 INNER JOIN OSUSR_E9A_CSICP_FF102	AS FF102 ON FF102.ID = FF103.FF102_ID
		 WHERE ff103.TENANT_ID = @tenant_id
		 AND (FF102.FF102_DATA_EMISSAO <= GETDATE() AND FF102.FF102_DATA_EMISSAO >= DATEADD(YEAR, -1, GETDATE()) )
		 AND ( DATEDIFF(DAY,FF102.FF102_DATA_VENCIMENTO, FF103.FF103_DATA_BAIXA) >= 1 AND DATEDIFF(DAY,FF102.FF102_DATA_VENCIMENTO, FF103.FF103_DATA_BAIXA) <= 5)
		 AND FF102.FF102_CONTAID = @idconta
		 and (FF103_BAIXADO = 1
		 and FF103_ESTORNADO = 0
		 and FF103_CANCELADO = 0)
		 and FF103_TPBAIXAID IN (SELECT ID from csicp_ff103_TpBai WHERE [LABEL] = 'Baixa')
		 )

		 AS Qtd_PagtosPontuais --[P.PP=Pagtos Pontuais],

		 -- RECUPERA PAGTO NO PRAZO
		 ,(SELECT COUNT (*) * @Peso_SP AS SP FROM
		 OSUSR_E9A_CSICP_FF103 AS FF103
		 INNER JOIN OSUSR_E9A_CSICP_FF102	AS FF102 ON FF102.ID = FF103.FF102_ID
		 WHERE ff103.TENANT_ID = @tenant_id
		 AND (FF102.FF102_DATA_EMISSAO <= GETDATE() AND FF102.FF102_DATA_EMISSAO >= DATEADD(YEAR, -1, GETDATE()) )
		 AND  DATEDIFF(DAY,FF102.FF102_DATA_VENCIMENTO, FF103.FF103_DATA_BAIXA) <= 0
		 AND FF102.FF102_CONTAID = @idconta
		 and (FF103_BAIXADO = 1
		 and FF103_ESTORNADO = 0
		 and FF103_CANCELADO = 0)
		 and FF103_TPBAIXAID IN (SELECT ID from csicp_ff103_TpBai WHERE [LABEL] = 'Baixa')
		 )
		 AS Qtd_SemprePagaPrazo --[p.SP=Sempre Paga no Prazo]

		 -- Qtd Titulo
		 ,(SELECT COUNT (*) AS SP FROM
		 OSUSR_E9A_CSICP_FF103 AS FF103
		 INNER JOIN OSUSR_E9A_CSICP_FF102	AS FF102 ON FF102.ID = FF103.FF102_ID
		 WHERE ff103.TENANT_ID = @tenant_id
		 AND (FF102.FF102_DATA_EMISSAO <= GETDATE() AND FF102.FF102_DATA_EMISSAO >= DATEADD(YEAR, -1, GETDATE()) )
		 AND FF102.FF102_CONTAID = @idconta
		 and (FF103_BAIXADO = 1
		 and FF103_ESTORNADO = 0
		 and FF103_CANCELADO = 0)
		 and FF103_TPBAIXAID IN (SELECT ID from csicp_ff103_TpBai WHERE [LABEL] = 'Baixa')
		 )
		 AS Qtd_Titulos

--- WHERE do select principal
		FROM csicp_dd040
		WHERE csicp_dd040.TENANT_ID = @tenant_id
		AND csicp_dd040.DD040_Data_Emissao <= GETDATE() AND csicp_dd040.DD040_Data_Emissao >= dateadd(YEAR,-1,getdate())
		AND csicp_dd040.DD040_CONTA_ID = @idconta
)
,
-- Use a comma to separate multiple CTE definitions.
-- Define the second CTE query, which returns sales quota data by year for each sales person.
CTE_Obtem_Pesos (Conta_id ,Peso_C, Peso_P)
AS
(
SELECT 
		@idconta as Conta_id
	,CASE
        WHEN Qtd_Comportamento_compras = 0 THEN 0
		WHEN Qtd_Comportamento_compras >= 1 AND Qtd_Comportamento_compras <= 2 THEN 0.3
		WHEN Qtd_Comportamento_compras >= 3 AND Qtd_Comportamento_compras <= 5 THEN 0.5
		WHEN Qtd_Comportamento_compras >= 6 AND Qtd_Comportamento_compras <= 10 THEN 0.8
		WHEN Qtd_Comportamento_compras > 10 THEN 1
        END
		AS Peso_C
		,CASE 
		WHEN Qtd_Titulos > 0 THEN ROUND((Qtd_AtrasosFreq + Qtd_AtrasosModerados + Qtd_PagtosPontuais + Qtd_SemprePagaPrazo) / Qtd_Titulos,1) 
		ELSE 1
		END
		AS Peso_P
FROM CTE_ObtemDados
)
,
CTE_ObtemDadosScore
(
 Conta_ID 
,Renda
,CreditoSemScore
,ScoreClearSale
,TaxaScore
,CreditoComScore
)
AS
-- Define the CTE query.
(
		SELECT
		@idconta as Conta_ID
		,@Renda
		,( (Peso_C * @wC) + (Peso_P * @WP) + (@e_b * @wE) + (Peso_P * @wR)) / (@wC + @wP + @wE + @wR) * @Renda * @F
		,@ScoreClear
		,@TS
        ,ROUND((@Renda * @TS),2)
--- WHERE do select principal
		FROM csicp_bb012
		JOIN CTE_Obtem_Pesos		ON CTE_Obtem_Pesos.Conta_id		= @idconta
		WHERE csicp_bb012.TENANT_ID = @tenant_id
		AND csicp_bb012.ID = @idconta
)

,
CTE_ObtemMediaCredito
(
 Conta_ID 
,MediaCredito
)
AS
-- Define the CTE query.
(
SELECT 
CTE_ObtemDados.Conta_ID
,((@wS * CTE_ObtemDadosScore.CreditoComScore) + (@wN * ( (CTE_Obtem_Pesos.Peso_C * @wC) + (CTE_Obtem_Pesos.Peso_P * @WP) + (@e_b * @wE) + (Peso_P * @wR)) / (@wC + @wP + @wE + @wR) * @Renda * @F
)) / (@wS + @wN) 

FROM CTE_ObtemDados
JOIN CTE_Obtem_Pesos		ON CTE_Obtem_Pesos.Conta_id		= CTE_ObtemDados.Conta_ID
JOIN CTE_ObtemDadosScore	ON CTE_ObtemDadosScore.Conta_ID	= CTE_ObtemDados.Conta_ID 
)
------------------------------------------------------
-- Define the outer query referencing the CTE name.
-- Define the outer query by referencing columns from both CTEs.
SELECT 
YEAR(GETDATE())  AS Ano
,MONTH(GETDATE()) AS Mes
,CTE_ObtemDados.Conta_ID
,Qtd_Comportamento_compras
,Qtd_AtrasosFreq
,Qtd_AtrasosModerados
,Qtd_PagtosPontuais
,Qtd_SemprePagaPrazo
,Qtd_Titulos
,CTE_Obtem_Pesos.Peso_C
,CTE_Obtem_Pesos.Peso_P
, @e_b as [Media Salarial Bairro]
,@Renda as [Renda]
,@F AS [Fator Ajuste]
,@wC as [wC]
,@wP as [wP]
,@wE as [wE]
,@wR as [wR]
,CTE_ObtemDadosScore.CreditoSemScore		AS [Credito Sem Score]
,CTE_ObtemDadosScore.ScoreClearSale 
,CTE_ObtemDadosScore.TaxaScore 
,CTE_ObtemDadosScore.CreditoComScore		AS [Credito Com Score]
,CTE_ObtemMediaCredito.MediaCredito
FROM CTE_ObtemDados
JOIN CTE_Obtem_Pesos		ON CTE_Obtem_Pesos.Conta_id		= CTE_ObtemDados.Conta_ID
JOIN CTE_ObtemDadosScore	ON CTE_ObtemDadosScore.Conta_ID	= CTE_ObtemDados.Conta_ID 
JOIN CTE_ObtemMediaCredito	ON CTE_ObtemMediaCredito.Conta_ID = CTE_ObtemDados.Conta_ID


/*
JSON PARAMETRO
[
  "Parametros_List": [
    [
      "Item": 1,
      "Descricao": "wC",
      "Orientacao": "Credito Sem Score. Pesos atribuido para cada variavel, ajustada de acordo com a importancia desejada.",
      "Value": "0.2"
    ],
	[
      "Item": 2,
      "Descricao": "wP",
      "Orientacao": "Credito Sem Score. Pesos atribuido para cada variavel, ajustada de acordo com a importancia desejada.",
      "Value": "0.25"
    ],
	[
      "Item": 3,
      "Descricao": "wE",
      "Orientacao": "Credito Sem Score. Pesos atribuido para cada variavel, ajustada de acordo com a importancia desejada.",
      "Value": "0.15"
    ],
	[
      "Item": 4,
      "Descricao": "wR",
      "Orientacao": "Credito Sem Score. Pesos atribuido para cada variavel, ajustada de acordo com a importancia desejada.",
      "Value": "0.4"
    ],
	[
      "Item": 5,
      "Descricao": "F",
      "Orientacao": "Credito Sem Score. Fator de ajuste.",
      "Value": "0.5"
    ],
	[
      "Item": 6,
      "Descricao": "wS",
      "Orientacao": "Credito Media. Pesos atribuido para cada variavel, ajustada de acordo com a importancia desejada.",
      "Value": "0.6"
    ],
	[
      "Item": 7,
      "Descricao": "wN",
      "Orientacao": "Credito Media. Pesos atribuido para cada variavel, ajustada de acordo com a importancia desejada.",
      "Value": "0.4"
    ],
	[
      "Item": 8,
      "Descricao": "G",
      "Orientacao": "Credito Gradual. Fator de Gradualidade.",
      "Value": "0.4"
    ],
	[
      "Item": 9,
      "Descricao": "wPA",
      "Orientacao": "Credito Gradual. Peso de atraso.",
      "Value": "0.4"
    ],
	[
      "Item": 10,
      "Descricao": "wU",
      "Orientacao": "Credito Gradual. Peso de Percentual do Credito Usado.",
      "Value": "0.4"
    ],
	[
      "Item": 11,
      "Descricao": "wF",
      "Orientacao": "Credito Gradual. Peso de Frequencia de Uso.",
      "Value": "0.4"
    ]
  ]
]
*/
