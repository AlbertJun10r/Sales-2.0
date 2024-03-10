using Newtonsoft.Json;
using System;

namespace Sales_System_2._0.Application.Dtos.Base
{
    public abstract class DtoBase
    {
        [JsonProperty("IdUsuarioMod")]
        public int IdUsuarioMod { get; set; }

        [JsonProperty("FechaMod")]
        public DateTime? FechaMod { get; set; }
    }
}
