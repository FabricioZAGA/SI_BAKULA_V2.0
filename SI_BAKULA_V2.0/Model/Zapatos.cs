using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_BAKULA_V_1._0.Model
{
    public class Zapatos : Modelo
    {
        public int IdZapatos { get; set; }
        public int IdVendedor { get; set; }
        public double Precio { get; set; } 
        public string Existencia { get; set; }

    }
}
