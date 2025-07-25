using CSCore.Application.Dto.Dtos.Basico_AA.AA00X;
using CSCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.AA00X.AA037
{
    public static class AA037ImpMapper
    {
        public static DtoGetAA037Imp ToDtoGetAA037Imp(this CSICP_AA037Imp entity)
        {
            return new DtoGetAA037Imp
            {
                Id = entity.Id,
                Label = entity.Label,
            };
        }
    }
} 
