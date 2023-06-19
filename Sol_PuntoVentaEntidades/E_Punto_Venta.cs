using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// La capa entidades se relaciona con la capa de datos 
namespace Sol_PuntoVentaEntidades
{
    public class E_Punto_Venta //mismo nombre que la Tabla de la BBD
    {
        /*Aqui de definiran propiedades que nos ayuden a recolectar los datos temporalmente para despues
         enviarlos a un siguiente proceso */

        //Devuelven las col de la tabla PUNTO_VENTA
        public int Codigo_pv { get; set; } // get para controlar los datos y set para cargarlos
        public string Descripcion_pv { get; set; } 

    }
}
