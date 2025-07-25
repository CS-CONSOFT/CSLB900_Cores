select gg016f.GG016E_ID, gg016f.GG016F_GRADELINHAID, gg016f.GG016F_GRADECOLUNAID, gg016_c1.GG016_DESCRICAO, gg016_c2.GG016_DESCRICAO
from csicp_gg016f as gg016f
left join csicp_gg016 as gg016_c1 on gg016f.GG016F_GRADELINHAID = gg016_c1.ID
left join csicp_gg016 as gg016_c2 on gg016f.GG016F_GRADECOLUNAID = gg016_c2.ID
where gg016f.Tenant_ID = 135
and GG016E_ID = '17';

 SELECT [o].[TENANT_ID] AS [TenantId], [o].[GG016F_ID] AS [Gg016fId], 
 [o].[GG016E_ID] AS [Gg016eId], [o].[GG016F_GRADELINHAID] AS [Gg016fGradelinhaid],
 [o].[GG016F_GRADECOLUNAID] AS [Gg016fGradecolunaid], [o0].[TENANT_ID] AS [TenantId], 
 [o0].[ID] AS [Id], [o0].[GG016_FILIALID] AS [Gg016Filialid], 
 [o0].[GG016_FILIAL] AS [Gg016Filial], [o0].[GG016_GRADE] AS [Gg016Grade],
 [o0].[GG016_DESCRICAO] AS [Gg016Descricao], [o0].[GG016_LINCOLID] AS [Gg016Lincolid], 
 [o0].[GG016_ISMARCADO] AS [Gg016Ismarcado], [o2].[ID] AS [Id], [o2].[BB001_CODIGOEMPRESA] AS [Bb001Codigoempresa],
 [o2].[BB001_RAZAOSOCIAL] AS [Bb001Razaosocial], [o2].[BB001_NOMEFANTASIA] AS [Bb001Nomefantasia], 
 [o1].[TENANT_ID] AS [TenantId], [o1].[ID] AS [Id], [o1].[GG016_FILIALID] AS [Gg016Filialid], 
 [o1].[GG016_FILIAL] AS [Gg016Filial], [o1].[GG016_GRADE] AS [Gg016Grade], [o1].[GG016_DESCRICAO] AS [Gg016Descricao], 
 [o1].[GG016_LINCOLID] AS [Gg016Lincolid], [o1].[GG016_ISMARCADO] AS [Gg016Ismarcado]
      FROM [OSUSR_E9A_CSICP_GG016F] AS [o]
      LEFT JOIN [OSUSR_E9A_CSICP_GG016] AS [o0] ON [o].[GG016F_GRADELINHAID] = [o0].[ID]
      LEFT JOIN [OSUSR_E9A_CSICP_GG016] AS [o1] ON [o].[GG016F_GRADECOLUNAID] = [o1].[ID]
      LEFT JOIN [OSUSR_E9A_CSICP_BB001] AS [o2] ON [o0].[GG016_FILIALID] = [o2].[ID]
      WHERE [o].[TENANT_ID] = 135 AND [o].[GG016E_ID] = 13



