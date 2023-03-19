using HIRCasa.Reclutamiento.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIRCasa.Reclutamiento.Entities.Dtos
{
    public class ClienteUpdateDto : ClienteCreationDto
    {
        public EstatusType Estatus { get; set; }
        public Boolean Aprobación { get; set; }
    }
}
