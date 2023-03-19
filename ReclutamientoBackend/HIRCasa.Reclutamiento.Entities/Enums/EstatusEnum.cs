using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIRCasa.Reclutamiento.Entities.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EstatusType : int
    {
        Pendiente = 0,
        EnProceso = 1,
        Pagado =2,
        Adeudo = 3
    }
}
