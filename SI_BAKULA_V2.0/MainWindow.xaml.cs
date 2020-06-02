using SI_BAKULA_V_1._0.Gui;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SI_BAKULA_V2._0
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LogIn l = new LogIn();
            this.Close();
            l.Show();
        }
        private void SpImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            LogIn cp = new LogIn();
            this.Close();
            cp.Show();
        }
    }
}
