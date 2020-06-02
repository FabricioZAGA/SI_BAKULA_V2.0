using SI_BAKULA_V2._0.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Ventana_envevida.Controller;

namespace SI_BAKULA_V_1._0.Gui
{
    /// <summary>
    /// Lógica de interacción para InfoCliente.xaml
    /// </summary>
    public partial class InfoCliente : Window
    {
        
        public InfoCliente()
        {
            InicioCliente inicioCliente = new InicioCliente();
            InitializeComponent();
            //inicioCliente.btnNombreClient.Content = this.btnNombreClient.Content;
            
        }
        public void StackWindows(Grid grid, UserControl userControl)
        {
            if (grid.Children.Count != 0)
            {
                grid.Children.Clear();
            }
            grid.Children.Add(userControl);

        }

        private void BtnCarroCompras_Click(object sender, RoutedEventArgs e)
        {
            ControllerVentanas cv = new ControllerVentanas();
            cv.EmbeberVentana(grdPrincipal, new UcShoppingCart());
        }

        private void BtnComprasRecientes_Click(object sender, RoutedEventArgs e)
        {
            ControllerVentanas cv = new ControllerVentanas();
            cv.EmbeberVentana(grdPrincipal, new UcComprasRecientes());
        }

        private void BtnActualizarInformaicon_Click(object sender, RoutedEventArgs e)
        {
            ControllerVentanas cv = new ControllerVentanas();
            cv.EmbeberVentana(grdPrincipal, new UcActInfo());
        }

        private void BtnActualizarPago_Click(object sender, RoutedEventArgs e)
        {
            ControllerVentanas cv = new ControllerVentanas();
            cv.EmbeberVentana(grdPrincipal, new UcCambiarPago());
        }

        private void BtnNombreClient_Click(object sender, RoutedEventArgs e)
        {
            InicioCliente ic = new InicioCliente();
            this.Close();
            ic.Show();
        }
    }
}
