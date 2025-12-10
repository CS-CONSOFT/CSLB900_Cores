using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.DD
{
    public class DD000BinarioDtoGet
    {
        [JsonIgnore]
        public byte[]? Dd000ArquivoBinarioDigital { get; set; }
        public string? Dd000Senhacertdigital { get; set; }
        public string? Dd000ArquivoBinarioDigitalBase64
        {
            get
            {
                if (Dd000ArquivoBinarioDigital != null)
                {
                    return Convert.ToBase64String(Dd000ArquivoBinarioDigital);
                }
                return null;
            }
        }
    }
}
