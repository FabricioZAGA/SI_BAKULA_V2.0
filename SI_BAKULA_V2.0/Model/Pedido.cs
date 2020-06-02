using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_BAKULA_V_1._0.Model
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdUsuario { get; set; }
        public double PrecioTotal { get; set; }
        public DateTime Fecha { get; set; }
        public Boolean Comprado { get; set; }
    }
}
