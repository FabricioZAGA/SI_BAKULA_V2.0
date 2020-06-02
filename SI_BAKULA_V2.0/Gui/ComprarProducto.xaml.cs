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

namespace SI_BAKULA_V_1._0.Gui
{
    /// <summary>
    /// Lógica de interacción para ComprarProducto.xaml
    /// </summary>
    public partial class ComprarProducto : Window
    {
        public ComprarProducto()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InicioCliente ic = new InicioCliente();
            this.Close();
            ic.Show();
        }
    }
}
