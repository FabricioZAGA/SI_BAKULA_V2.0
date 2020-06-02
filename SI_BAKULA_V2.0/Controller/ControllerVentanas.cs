using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Ventana_envevida.Controller
{
    public class ControllerVentanas
    {
        public void EmbeberVentana(Grid g,UserControl uc)
        {
            if (g.Children.Count != 0)
            {
                g.Children.Clear();
            }
            g.Children.Add(uc);
            

        }
    }
}
