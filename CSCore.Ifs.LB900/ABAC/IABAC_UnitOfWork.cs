using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.LB900.ABAC;
using CSLB900.MSTools.GenerateId;

namespace CSSY103.C82Application.Service.UnitOfWork.ABAC
{
    public interface IABAC_UnitOfWork : IUnitOfWorkBase
    {
        IRepositorioBaseV2ComGets<OsusrE9aCsicpSy030> GetSY030Repository { get; }
        ICS_GenerateId IdGenerator { get; }
    }
}