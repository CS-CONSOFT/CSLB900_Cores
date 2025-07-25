select * from csicp_Sy996
where SY996_NOMETIMER = 'EXCLUIR' 
and TENANT_ID = 135 
and SY996_EMPRESA_ID = '08878f25-412d-4914-934f-f785d61b8b77'
;

select * from csicp_aa006 where TENANT_ID = 135;

select * from csicp_Sy996;

delete from csicp_sy996 where SY996_NOMETIMER = 'EXCLUIR' 
and TENANT_ID = 135 
and SY996_EMPRESA_ID = '08878f25-412d-4914-934f-f785d61b8b77'
;