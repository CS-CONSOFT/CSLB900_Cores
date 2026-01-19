using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSCore.Domain.DELETAR;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.LB900.ABAC.Repository;
using CSLB900.MSTools.GenerateId;

namespace CSCore.Ifs.LB900.ABAC
{
    public interface IABAC_UnitOfWork : IUnitOfWorkBase
    {
        SY030RepositoryImpl GetSY030Repository { get; }
        IRepositorioBaseV2ComGets<OsusrE9aCsicpSy031> GetSY031Repository { get; }
        IRepositorioBaseV2ComGets<OsusrE9aCsicpSy032> GetSY032Repository { get; }
        IRepositorioBaseV2ComGets<ABAC_CSSPH_RESOURCE> GetABAC_CSSPH_RESOURCERepository { get; }
        IRepositorioBaseV2ComGets<ABAC_CSSPH_RESOURCEACTIONS> GetABAC_CSSPH_RESOURCEACTIONSRepository { get; }
        IRepositorioBaseV2ComGets<ABAC_CSSPH_RESOURCEATRIB> GetABAC_CSSPH_RESOURCEATRIBRepository { get; }
        IRepositorioBaseV2ComGets<OsusrE9aCsicpSy038> GetSY038Repository { get; }
        IRepositorioBaseV2ComGets<OsusrE9aCsicpSy039> GetSY039Repository { get; }
        IRepositorioBaseV2ComGets<ABAC_CSSPH_FILTERS> GetABAC_CSSPH_FILTERSRepository { get; }
        IRepositorioBaseV2ComGets<ABAC_CSSPH_OPERADORES> GetABAC_CSSPH_OPERADORESRepository { get; }
        IRepositorioBaseV2ComGets<ABAC_CSSPH_FILTERSOPERADORES> GetABAC_CSSPH_FILTERSOPERADORESRepository { get; }
        IRepositorioBaseV2ComGets<ABAC_CSSPH_FILTERSRESOURCE> GetABAC_CSSPH_FILTERSRESOURCERepository { get; }
        IRepositorioBaseV2ComGets<ABAC_CSSPH_ABACRESOURCEATTRIBUTES> GetABAC_CSSPH_ABACRESOURCEATTRIBUTESRepository { get; }
        IRepositorioBaseV2ComGets<ABAC_CSSPH_ABACUSERATTRIBUTES> GetABAC_CSSPH_ABACUSERATTRIBUTESRepository { get; }
        ICS_GenerateId IdGenerator { get; }
    }
}