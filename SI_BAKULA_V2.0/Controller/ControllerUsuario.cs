using SI_BAKULA_V_1._0.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZGAF_06.Db;

namespace ZGAF_ACT1_3P.Controller
{
    public class ControllerUsuario
    {
        SqlServerConnection sqlServerConnection = null;





        public void InsertUsuario(Usuario usuario)
        {
            sqlServerConnection = new SqlServerConnection();
            SqlCommand cmd = null;
            SqlConnection connection = sqlServerConnection.Abrir();

            //----------------------------INSERCION DATOS PROPIOS DE USUARIO-----------------------------------------
            string query = "INSERT INTO Usuario (_Usuario, Contrasenia, Correo)" +
                             "VALUES (@_Usuario, @Contrasenia, @Correo);";

            cmd = new SqlCommand(query, connection);

            //Se crean los parámetros 
            cmd.Parameters.Add("@_Usuario", SqlDbType.VarChar);
            cmd.Parameters.Add("@Contrasenia", SqlDbType.VarChar);
            cmd.Parameters.Add("@Correo", SqlDbType.VarChar);

            //Inserción de datos a los parámetros
            cmd.Parameters["@_Usuario"].Value = usuario._Usuario;
            cmd.Parameters["@Contrasenia"].Value = usuario.Contrasenia;
            cmd.Parameters["@Correo"].Value = usuario.Correo;
            //Verificación de Query 
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("Registro Exitoso", "Etzito");
            }
            else
            {
                MessageBox.Show("Explotóooo", "BUUUUM");
            }
            sqlServerConnection.Cerrar();
        }


        public string ObtenerUltimoUsuario(Usuario usuario)
        {
            string valorchido = "";
            try
            {
                sqlServerConnection = new SqlServerConnection();

                SqlConnection connection = sqlServerConnection.Abrir();

                string query = "select _Usuario from Usuario " +
                    "WHERE _Usuario = @_Usuario;";

                SqlCommand sqlCommand = new SqlCommand(query, connection);

                //Se crean los parámetros 
                sqlCommand.Parameters.Add("@_Usuario", SqlDbType.VarChar);


                //Inserción de datos a los parámetros
                sqlCommand.Parameters["@_Usuario"].Value = usuario._Usuario;

                valorchido = (string)sqlCommand.ExecuteScalar();

            }
            catch
            {

            }
            finally
            {
                sqlServerConnection.Cerrar();
            }




            return valorchido;
        }
    }
}
