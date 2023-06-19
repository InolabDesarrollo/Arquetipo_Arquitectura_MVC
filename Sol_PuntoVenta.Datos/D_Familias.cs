using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //para trabajar con la conectividad al servidor de datos
using Sol_PuntoVentaEntidades; // usamos la capa entidades pues la capa datos consumira recursos de la capa entidades
using System.Data;

namespace Sol_PuntoVenta.Datos
{
    // metodo para traer informacion de la tabla TB_PUNTO_VENTA
    public class D_Familias
    {
        //Metodo para consultar informacin de la tabla PUNTO DE VENTA
        public DataTable Listado_fa(string cTexto) //agragas parametros para que no sea algo estatico y puedas hacer filtrado de datos
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion(); //Definimos la conectividad y asigano a sqlCon
                // se verifica si existe la conexion y la crea asignandola a sqlCon
                SqlCommand Comando = new SqlCommand("USP_listado_fa", sqlCon); //Esta linea define la forma en que solicitaremos informacion 
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto; //agregamos el parametro y el tipo de dato del procedimiento que se hizo en la BBD 


                sqlCon.Open(); //abrimos la conexion
                Resultado = Comando.ExecuteReader(); //cargamos el contenido de lo que retorne sql server 
                Tabla.Load(Resultado); //cargamos a la tabla 

                return Tabla; // devolvemos  el resultado y cerramos el metodo 


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                if (sqlCon.State == ConnectionState.Open) sqlCon.Close(); //si el estado de la conexion es abierto, cierrala
                /* Cada ves que solicitemos informacion de sql server abrimos la conexion y despues de
                 optenerla y se almacene con el x recurso, se cierra la conexion de nuevo no debe estar siempre abierta la conexion*/

            }

        }

        // Metodo para almacenar un nuevo registro y de paso a un escenario de actualizacion 
        public string Guardar_fa(int nOpcion, E_Familias oPropiedad) //el parametro nOpcion es para saber si se guarda un nuevo registro o se actualiza otro; oPropiedad referencia a get y ser de E_Punto_Venta que esta en la entidad
        {
            /*Se carga oPropiedad como un tipo de parametro */
            String Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Guardar_fa", SqlCon); //  SqlCon es la conectividad
                /*USP_Guardar_pv es el procedimiento que se creo en la tabla TB_PUNTO_VENTA*/

                Comando.CommandType = CommandType.StoredProcedure;//indicas que se enfoca que un procedimiento

                //Agregas los parametros que estan tambien en el procedimiento USP_Guardar_pv que esta en sql
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@nCodigo", SqlDbType.Int).Value = oPropiedad.Codigo_fa;
                Comando.Parameters.Add("@cDescripcion", SqlDbType.VarChar).Value = oPropiedad.Descripcion_fa;

                /*Codigo_pv, y Descripcion_pv son metodos que se resguardan en E_Punto_Venta
                 
                ExecuteNonQuery retorna una verficacion de las tareas que se realizaron dentro del procedimiento USP_Guardar_pv
                sabemos perfectamente que aunque hay dos opciones en este procedimiento por el condicional solo se ejecuta 1
                se pone >= 1 porque en el futuro se podria actualizar el procedimiento y agregar mas opciones*/

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";
                // si es >=1 se ejecuto bien, si  no hay fallas 

            }
            catch (Exception ex)
            {
                //si hay un error se mostrara el mensaje de la respectiva excepcion 
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); //para que la conexion no este siempre abierta
            }
            return Rpta;

            //para este metodo, estaremos enviando informacion, este metodo devolvera un mensaje que nos dira si se guardo correctamente

        }

        //METODO SE RELACIONA CON PROCEDIMIENTO USP_Eliminar_Pv; Ultimo metodo de la capa de datos 
        public string Eliminar_fa(int nCodigo)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection(); //instanciamos 
            try
            {
                //Creamos la conexion 
                SqlCon = Conexion.getInstancia().CrearConexion(); //Esto se extrae desde la clase Conexion, se define la conectividad y la llamas en todo momento

                //Sql Command recibe como parametro el procedimiento ya hecho en sql server
                SqlCommand Comando = new SqlCommand("USP_Eliminar_fa", SqlCon); //el segundo parametro es la conexion 
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nCodigo", SqlDbType.Int).Value = nCodigo;
                SqlCon.Open();

                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el registro"; //ExecuteNonQuery devuelve el numero de filas que afecto la consulta
            }
            catch (Exception ex)
            {

                Rpta = ex.Message; //Rpta es la variable respuesta
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }; /*La conexion debe siempre cerrarse despues de traer los datos que nececitas, puede afectar la infraestructura de las redes*/


            }
            return Rpta;
        }


    }
}

