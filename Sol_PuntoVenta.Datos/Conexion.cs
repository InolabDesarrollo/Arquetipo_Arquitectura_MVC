using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Paquete que permite la conexion a SQL Server
namespace Sol_PuntoVenta.Datos
{
    public class Conexion // .Net la agregara por default intern pero se cambia a public, modificadores de acceso

    {
        // Propiedades 
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null; //debe ser private por seguridad y rendimiento

        //Metodo para conectar, metodo CONSTRUCTOR 
        private Conexion()
        {
            //"DESKTOP-NRNLRUP\\SQLEXPRESS" servidor casa
            this.Base = "BD_PUNTOVENTA"; 
            this.Servidor = "DESKTOP-UR1C9B2\\SQLEXPRESS02"; //Ya agrega el segundo guion \ que es necesario para c# entienda
            this.Usuario = "user_sistema";
            this.Clave = "12345";

        }

        public SqlConnection CrearConexion () //referencias a SqlConnection Clase https://learn.microsoft.com/es-es/dotnet/api/system.data.sqlclient.sqlconnection?view=dotnet-plat-ext-7.0
        {
            SqlConnection Cadena = new SqlConnection(); // esta instancia puede tomar como propiedad una cadena de conexion
            
            // para poder controlar los errores dee
            try //try + doble tap 
            {
                //Aqui se define la forma de conectividad, se pasan los datos a las propiedades de la clase
                Cadena.ConnectionString = "Server=" + this.Servidor +
                                         "; Database=" + this.Base +
                                         "; User Id=" + this.Usuario +
                                         ";Password=" + this.Clave;
            }
            catch (Exception ex)
            {

                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia() // metodo para verificar que la conexion este abierta y que devuelve una conexion
        {
            // Este condicional indica de que en caso de que la conexion no este abierta la cree
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
