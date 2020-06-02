using SI_BAKULA_V_1._0.Model;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using ZGAF_06.Db;
using ZGAF_ACT1_3P.Controller;

namespace SI_BAKULA_V_1._0.Gui
{
    /// <summary>
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : Window
    {
        ControllerUsuario controllerUsuario = new ControllerUsuario();
        Usuario usuario = null;
        public Registro()
        {
            InitializeComponent();
        }

        public void AsignarValores()
        {
            try
            {
                usuario = new Usuario();
                usuario._Usuario = txtUsuario.Text;
                usuario.Contrasenia = txtContrasenia.Text;
                usuario.Correo = txtEmail.Text;
            }
            catch
            {
                MessageBox.Show("Introduzca Valores Válidos", "¡Error!");
            }
        }


        private void BtnRegistrarse_Click(object sender, RoutedEventArgs e)
        {

            AsignarValores();
            controllerUsuario.InsertUsuario(usuario);
            txtUsuario.Text = "";
            txtContrasenia.Text = "";
            txtEmail.Text = "";

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LogIn mw = new LogIn();
            this.Close();
            mw.Show();
        }
    }
}
