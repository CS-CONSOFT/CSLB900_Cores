using CSCore.Ifs.FF.Repository.FF1XX.FF128;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF._1XX.FF128
{
    public interface IFF128Repository
    {
        void CriaHistoricoRegistroCobrador(PrmCriaHistoricoRegistroCobrador prm);
    }
}
