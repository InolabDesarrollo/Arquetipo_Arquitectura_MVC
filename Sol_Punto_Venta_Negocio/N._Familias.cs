using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_PuntoVentaEntidades; //Capa negocio se puede comunicar con el entidades
using Sol_PuntoVenta.Datos; //Capa datos
namespace Sol_Punto_Venta_Negocio
{
    public class N_Familias
    {
        //Metodo para hacer consultas, replicaremos los metodos principales de la clase D_Punto_Venta de la capa de Datos
        public static DataTable Listado_fa(string cTexto)
        {
            //Instanciamos un objeto de la clase D_Punto_Venta de la capa datos 
            D_Familias Datos = new D_Familias();
            return Datos.Listado_fa(cTexto); //llamamos al metodo Listado_pv
        }

        public static string Guardar_fa(int nopcion, E_Familias oPropiedad)
        {
            D_Familias Datos = new D_Familias();
            return Datos.Guardar_fa(nopcion, oPropiedad);
        }

        public static string Eliminar_fa(int nCodigo)
        {
            D_Familias Datos = new D_Familias();

            return Datos.Eliminar_fa(nCodigo);
        }
    }
}