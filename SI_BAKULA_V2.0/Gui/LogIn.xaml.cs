using SI_BAKULA_V_1._0.Model;
using SI_BAKULA_V2._0;
using SI_BAKULA_V2._0.Gui;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Media;
using ZGAF_06.Db;
using ZGAF_ACT1_3P.Controller;

namespace SI_BAKULA_V_1._0.Gui
{
    /// <summary>
    /// Lógica de interacción para LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public string PlaceholderText { get; set; }
        Usuario usuario = null;
        SqlServerConnection sqlServerConnection = null;
        public LogIn()
        {
            InitializeComponent();

        }
        private void BtnRegistrarse_Click(object sender, RoutedEventArgs e)
        {
            Registro r = new Registro();
            this.Close();
            r.Show();
        }
        private void BtnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            if(LogIngUsuario())
            {
                InicioCliente r = new InicioCliente();
                this.Close();
                r.btnNombreClient.Content = ObtenerUsuario();
                r.Show();
            }
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }

        public string ObtenerUsuario()
        {
            return usuario._Usuario;
        }

        public bool LogIngUsuario()
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();
             usuario = new Usuario();
            //----------------------------BUSQUEDA DE USUARIO-----------------------------------------
            string query = "SELECT _Usuario, Contrasenia FROM Usuario " +
                "WHERE _Usuario = @_Usuario AND Contrasenia = @Contrasenia;";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros 
            cmd.Parameters.Add("@_Usuario", SqlDbType.VarChar);
            cmd.Parameters.Add("@Contrasenia", SqlDbType.VarChar);
            string nombreUsuario = txtUsuario.Text;
            string contraseniaUsuario = txtContrasenia.Password;

            usuario._Usuario = nombreUsuario;
            ControllerUsuario cu = new ControllerUsuario();

            cu.ObtenerUltimoUsuario(usuario);

            //Inserción de datos a los parámetros
            cmd.Parameters["@_Usuario"].Value = nombreUsuario;
            cmd.Parameters["@Contrasenia"].Value = contraseniaUsuario;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                sqlServerConnection.Cerrar();
                MessageBox.Show("ChiCHEÑOOOOL", "Etzito");
                return true;
            }
            else
            {
                sqlServerConnection.Cerrar();
                MessageBox.Show("Usuario y/o Contraseña Incorrectos", "Error");
                return false;
            }
        }

        private void TxtUsuario_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            txtUsuario.Text = "";
            txtUsuario.Foreground = Brushes.Black;
        }
    }
}
