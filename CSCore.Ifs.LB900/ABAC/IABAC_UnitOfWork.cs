using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.LB900.ABAC;
using CSLB900.MSTools.GenerateId;

namespace CSSY103.C82Application.Service.UnitOfWork.ABAC
{
    public interface IABAC_UnitOfWork : IUnitOfWorkBase
    {
        IRepositorioBaseV2ComGets<OsusrE9aCsicpSy030> GetSY030Repository { get; }
        IRepositorioBaseV2ComGets<OsusrE9aCsicpSy031> GetSY031Repository { get; }
        IRepositorioBaseV2ComGets<OsusrE9aCsicpSy032> GetSY032Repository { get; }
        IRepositorioBaseV2ComGets<OsusrE9aCsicpSy035> GetSY035Repository { get; }
        IRepositorioBaseV2ComGets<OsusrE9aCsicpSy036> GetSY036Repository { get; }
        IRepositorioBaseV2ComGets<OsusrE9aCsicpSy037> GetSY037Repository { get; }
        IRepositorioBaseV2ComGets<OsusrE9aCsicpSy038> GetSY038Repository { get; }
        IRepositorioBaseV2ComGets<OsusrE9aCsicpSy039> GetSY039Repository { get; }
        IRepositorioBaseV2ComGets<OsusrE9aCsicpSy040> GetSY040Repository { get; }
        IRepositorioBaseV2ComGets<OsusrE9aCsicpSy041> GetSY041Repository { get; }
        IRepositorioBaseV2ComGets<OsusrE9aCsicpSy042> GetSY042Repository { get; }
        IRepositorioBaseV2ComGets<OsusrE9aCsicpSy043> GetSY043Repository { get; }
        ICS_GenerateId IdGenerator { get; }
    }
}