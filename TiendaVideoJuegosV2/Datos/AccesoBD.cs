using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;

namespace TiendaVideoJuegosV2.Datos
{
    public class AccesoBD
    {
        private String servidor;
        private String baseDatos;
        private String usuario;
        private String password;
        private MySqlConnection conexion;
        private MySqlCommand comando;
        private MySqlTransaction transaccion;
        public AccesoBD()
        {
            servidor = ConfigurationManager.AppSettings["servidor"].ToString();
            baseDatos = ConfigurationManager.AppSettings["baseDatos"].ToString();
            usuario = ConfigurationManager.AppSettings["usuario"].ToString();
            password = ConfigurationManager.AppSettings["password"].ToString();
        }
        protected void abrirConexion()
        {
            try
            {
                conexion = new MySqlConnection();
                conexion.ConnectionString = "Server=" + servidor + "; Database=" + baseDatos + "; Uid=" + usuario + "; Pwd=" + password + ";AllowPublicKeyRetrieval=true";
                conexion.Open();
            }
            catch (Exception e)
            {
                throw;
            }

        }
        protected void cerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        protected void iniciarTransaccion()
        {
            try
            {
                transaccion = this.conexion.BeginTransaction();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        protected void aceptarTransaccion()
        {
            try
            {
                transaccion.Commit();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        protected void cancelarTransaccion()
        {
            try
            {
                transaccion.Rollback();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public Boolean ejecutarUpdate(String sql)
        {
            abrirConexion();
            try
            {
                comando = new MySqlCommand(sql, conexion);
                return comando.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public List<Object> ejecutarConsulta(String sql, Object objeto)
        {
            abrirConexion();
            List<Object> objetos = new List<object>();
            MySqlDataReader dataReader = null;
            try
            {
                comando = new MySqlCommand(sql, conexion);
                dataReader = comando.ExecuteReader();
                List<String> nombrePropiedades = Mapeo.ObtenerNombrePropiedades(objeto);

                while (dataReader.Read())
                {
                    Object obj = Activator.CreateInstance(objeto.GetType());
                    foreach (String nombre in nombrePropiedades)
                    {
                        String valor = dataReader[nombre].ToString();
                        PropertyInfo propiedad = obj.GetType().GetProperty(nombre);
                        propiedad.SetValue(obj, Convert.ChangeType(valor, propiedad.PropertyType), null);
                    }
                    objetos.Add(obj);
                }
                dataReader.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                cerrarConexion();
            }
            return objetos;
        }
    }

    
}
