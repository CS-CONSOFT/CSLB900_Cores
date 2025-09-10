using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_SYS.Depreciadas_Tabelas;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.GenerateId;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Eventos.Repository
{
    public class GenerateProtocoloServiceImpl(
        AppDbContext appDbContext,
        ICS_GenerateId? generateId
        ) : IGenerateProtocolo
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        private readonly ICS_GenerateId? _generateId = generateId;


        public async Task<decimal> Fcn_ProtocoloGeral(string empresaID, int InTenantID)
        {
            decimal protocolo = await CS_Protocolo_Kernel_InternalAsync(empresaID, "PTL", tipoProtocolo: 1, inTenantID: InTenantID);
            return protocolo;
        }


        public async Task<decimal> Fcn_Protocolo10(string empresaID, string arquivo, int InTenantID)
        {
            decimal protocolo = await CS_Protocolo_Kernel_InternalAsync(empresaID, arquivo, tipoProtocolo: 2, inTenantID: InTenantID);
            return protocolo;
        }


        public async Task<decimal> Fcn_Protocolo15(string empresaID, string arquivo, int InTenantID)
        {
            decimal protocolo = await CS_Protocolo_Kernel_InternalAsync(empresaID, arquivo, tipoProtocolo: 5, inTenantID: InTenantID);
            return protocolo;
        }

        public async Task<decimal> Fcn_Protocolo(string empresaID, string arquivo, string textName, int InTenantID)
        {
            var uuid = _generateId.GenerateUuId();
            decimal protocolo = await CS_Protocolo_Kernel_InternalAsync(empresaID, arquivo, tipoProtocolo: 2, inTenantID: InTenantID);

            Csicp_Sy996 csicp_Sy996 = new()
            {
                TenantId = 135,
                Sy996Id = uuid,
                Sy996EmpresaId = empresaID,
                Sy996Objeto = protocolo.ToString(),
                Sy996Objid = null,
                Sy996Descricao = protocolo.ToString(),
                Sy996Datahora = DateTime.Now,
                Sy996Usuarioid = empresaID,
                Sy996Nomeusuario = textName,
                Sy996Nometimer = "EXCLUIR"
            };
            if (csicp_Sy996.Sy996Descricao.Length > 25)
            {
                csicp_Sy996.Sy996Descricao = "";
            }
            if (csicp_Sy996.Sy996Objeto.Length > 25)
            {
                csicp_Sy996.Sy996Objeto = "";
            }

            _appDbContext.Add(csicp_Sy996);
            try
            {
                await _appDbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.InnerException?.Message);
            }
            return 200;
        }



        private async Task<decimal> CS_Protocolo_Kernel_InternalAsync
           (string empresaID,
           string arquivo,
           int tipoProtocolo,
           int inTenantID,
           decimal maxCircularValue = 9999,
           bool isCircular = false)
        {
            int codigoEmpresa = 1;
            if (empresaID != null)
            {
                CSICP_BB001? BB001_Entity = await _appDbContext.E9ACSICP_BB001s
                    .Where(e => e.Id == empresaID)
                    .FirstOrDefaultAsync();


                if (BB001_Entity != null)
                {
                    codigoEmpresa = BB001_Entity.Bb001Codigoempresa!.Value;
                    empresaID = BB001_Entity.Id;
                }
            }

            CSICP_AA006 AA006_Entity = await MotandoESalvandoAA006Async(empresaID, arquivo, maxCircularValue, isCircular, codigoEmpresa, inTenantID);
            decimal? result = tipoProtocolo switch
            {
                1 => ProtocolType1(codigoEmpresa, AA006_Entity),
                2 => ProtocolType2(AA006_Entity),
                3 => ProtocolType3(AA006_Entity),
                4 => ProtocolType4(AA006_Entity),
                5 => ProtocolType5(AA006_Entity),
                6 => AA006_Entity.Aa006Ci,
                _ => ProtocolTypeDefault(codigoEmpresa, AA006_Entity)
            };
            return result!.Value;
        }

        private async Task<CSICP_AA006> MotandoESalvandoAA006Async(
            string empresaID, string arquivo, decimal maxCircularValue, bool isCircular, int codigoEmpresa, int InTenantID)
        {
            //recupera AA006
            CSICP_AA006? AA006_Entity = await _appDbContext.OsusrE9aCsicpAa006s
                .Where(e => e.Aa006Filialid == empresaID)
                .Where(e => e.Aa006Arquivo == arquivo)
                .Where(e => e.TenantId == InTenantID) 
                .FirstOrDefaultAsync();

            if (AA006_Entity != null)
            {
                AA006_Entity = HandleCIAndDateUpdate(isCircular, AA006_Entity);
                AA006_Entity.Aa006Dataultcaptura = DateTime.Today;
                _appDbContext.Update(AA006_Entity);
            }
            else
            {
                CSICP_Statica StaticaSIMNAO = await GetStaticaSimNaoByIsCircular(isCircular);
                string? ID = _generateId.GenerateUuId();
                AA006_Entity = new CSICP_AA006
                {
                    Id = ID,
                    TenantId = InTenantID,
                    Aa006Arquivo = arquivo,
                    Aa006Filial = codigoEmpresa,
                    Aa006Filialid = empresaID, // Melhor tratamento para string vazia
                    Aa006Circular = StaticaSIMNAO.Id,
                    Aa006Ci = 1,
                    Aa006Maxcircular = maxCircularValue,
                    Aa006Dataultcaptura = DateTime.Today
                };
                _appDbContext.Add(AA006_Entity);
            }

            await _appDbContext.SaveChangesAsync();
            return AA006_Entity;
        }

        private static CSICP_AA006 HandleCIAndDateUpdate(bool isCircular, CSICP_AA006 AA006_Entity)
        {
            if (isCircular)
            {
                //Sequencia > Max Circular
                if (AA006_Entity.Aa006Ci > AA006_Entity.Aa006Circular)
                {
                    InternalUpdateCiAndCaptureDate(AA006_Entity, false);
                }
                else
                {
                    InternalUpdateCiAndCaptureDate(AA006_Entity, true);
                }
            }

            else
            {
                //Ano Sequencia <> Ano Atual?
                if (AA006_Entity.Aa006Dataultcaptura != null && AA006_Entity.Aa006Dataultcaptura.Value.Year != DateTime.Today.Year)
                {
                    InternalUpdateCiAndCaptureDate(AA006_Entity, false);
                }
                else
                {
                    InternalUpdateCiAndCaptureDate(AA006_Entity, true);
                }
            }
            static void InternalUpdateCiAndCaptureDate(CSICP_AA006 AA006_Entity, bool isIncrementCI)
            {
                //se for para incrementar, incrementa em um, caso nao, seta 1
                AA006_Entity.Aa006Ci = isIncrementCI ? AA006_Entity.Aa006Ci + 1 : 1;
            }
            return AA006_Entity;
        }

        private async Task<CSICP_Statica> GetStaticaSimNaoByIsCircular(bool isCircular)
        {
            CSICP_Statica StaticaSIMNAO;
            if (isCircular)
            {
                StaticaSIMNAO = await _appDbContext.E9ACSICP_Statica.Where(e => e.Label == "Sim").FirstAsync();
            }
            else
            {
                StaticaSIMNAO = await _appDbContext.E9ACSICP_Statica.Where(e => e.Label == "Não").FirstAsync();
            }

            return StaticaSIMNAO;
        }

        private static decimal ProtocolType1(int codigoEmpresa, CSICP_AA006 AA006_Entity)
        {
            decimal yearComponent = DateTime.Today.Year * (decimal)Math.Pow(10, 13);
            decimal companyCodeComponent = codigoEmpresa * (decimal)Math.Pow(10, 10);
            decimal additionalValue = AA006_Entity.Aa006Ci!.Value;

            return yearComponent + companyCodeComponent + additionalValue;
        }

        private static decimal ProtocolType2(CSICP_AA006 AA006_Entity)
        {
            int lastTwoDigitsOfYear = int.Parse(DateTime.Now.Year.ToString().Substring(2, 2));
            decimal result = lastTwoDigitsOfYear * (decimal)Math.Pow(10, 8) + AA006_Entity.Aa006Ci!.Value;
            return result;
        }

        private static decimal ProtocolType3(CSICP_AA006 AA006_Entity)
        {
            int currentYear = DateTime.Now.Year;
            decimal result = currentYear * (decimal)Math.Pow(10, 6) + AA006_Entity.Aa006Ci!.Value;
            return result;
        }

        private static decimal ProtocolType4(CSICP_AA006 AA006_Entity)
        {
            decimal part1 = 99 * (decimal)Math.Pow(10, 8);

            int lastTwoDigitsOfYear = int.Parse(DateTime.Now.Year.ToString().Substring(2, 2));
            decimal part2 = lastTwoDigitsOfYear * (decimal)Math.Pow(10, 6);

            decimal result = part1 + part2 + AA006_Entity.Aa006Ci!.Value;

            return result;
        }

        private static decimal ProtocolType5(CSICP_AA006 AA006_Entity)
        {
            int currentYear = DateTime.Now.Year;
            decimal result = currentYear * (decimal)Math.Pow(10, 11) + AA006_Entity.Aa006Ci!.Value;
            return result;
        }

        private static decimal ProtocolTypeDefault(int codigoEmpresa, CSICP_AA006 AA006_Entity)
        {
            int currentYear = DateTime.Now.Year;
            decimal yearComponent = currentYear * (decimal)Math.Pow(10, 13);
            decimal companyCodeComponent = codigoEmpresa * (decimal)Math.Pow(10, 10);
            decimal result = yearComponent + companyCodeComponent + AA006_Entity.Aa006Ci!.Value;
            return result;
        }

    }
}
