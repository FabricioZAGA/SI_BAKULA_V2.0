using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_BAKULA_V_1._0.Model
{
    public class Persona : Usuario
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string RFC { get; set; }
        public string Telefono { get; set; }

    }
}
