using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_Punto_Venta_Negocio; //Para llamar a capa de negocio y de entidades
using Sol_PuntoVentaEntidades;


namespace Sol_PuntoVentaPresentacion
{
    public partial class Frm_Familias : Form
    {
        public Frm_Familias()
        {
            InitializeComponent();
        }

        

        #region "Mis variables"
        int nCodigo=0;
        int Estadoguarda=0;
        #endregion

        #region "Mis Metodos"
        //Metodo para darle formato a un data gredview
        private void Formato_fa()
        {
            //Se relaciona con la BBD USP LISTADO PV
            Dgv_Listado.Columns[0].Width= 100; // ancho para el contenido
            Dgv_Listado.Columns[0].HeaderText= "CODIGO_FA"; //Texto en titulo
            Dgv_Listado.Columns[1].Width = 400; // ancho para el contenido
            Dgv_Listado.Columns[1].HeaderText = "FAMILIA"; //Texto en titulo
        }
        // Para el enfoque de como hacer el tratamiento de información
        private void Listado_fa(string cTexto)
        {
            try
            {
                //Estamos dentro de la capa presentación, no se puede comunicar con BBD directo
                //Usaremos la capa negocio que se apoya al comunicarse con la de datos (No es directa la comunicacion con la capa de datos)
                //Capa de negocio se usa como puente 
                Dgv_Listado.DataSource=N_Familias.Listado_fa(cTexto); //Metodo Listado_pv esta en capa conexion y regresa una tabla creada con un store procedure
                this.Formato_fa(); //Activara el proceso de formato
                
                //Para que en el label en el dgv listado nos valla apareciendo cuantos registros tenemos
                Lbl_totalregistros.Text="Total registros " + Convert.ToString(Dgv_Listado.Rows.Count);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace); // ex.StackTrace es para que marque donde esta el error 
            }

        }
        private void Limpia_Texto()
        {
            //Dejamos vacio el texto
            Txt_descripcion.Text = "";
        }
        
        //Para cambiar el estado de los botones 
        private void Estado_BotonesPrincipales(bool lEstado) { 
        BtnActualizar.Enabled = lEstado;
        BtnNuevo.Enabled = lEstado;
        BtnEliminar.Enabled = lEstado;
        BtnReporte.Enabled  = lEstado;
        BtnSalir.Enabled  = lEstado;
        }
        //Para definir (Activar y poder escribir) en la barra de busqueda
        private void Estado_Texto(bool lEstado)
        {
            Txt_descripcion.ReadOnly = !lEstado; //cambiamos con el ! de false a true
        }

        //Metodos para activar los botones de pestaña mantenimieno
        private void Estado_BontonesProceso(bool Lestado){
            Btn_cancelar.Visible = Lestado;
            Btn_guardar.Visible = Lestado;
            Btn_retornar.Visible=!Lestado;
        }

       
       public void Seleccion_item(){
            //Se verificara si el Dgv esta nullo o vacio
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_fa"].Value)))
            { 
            MessageBox.Show("Selecciona un registro","Aviso del sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
            else
            {
                //LLenamos el codigo como valor entero
                this.nCodigo = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_fa"].Value);
                Txt_descripcion.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_pv"].Value);
            }

        }
        #endregion
        //Metodo para el evento doble click en el Dgv
        private void Frm_Familias_Load(object sender, EventArgs e)
        {
            //Para crar este evento das doble click en load dentro del rayito, eventos
            // Para una mejor organización del codigo se usan regiones dee

            this.Listado_fa("%"); //Activo el metodo, el porcentaje es para que liste todos los registros que tenga
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Eliminar datos del Dgv
            //Debemos validar que el Dgv tenga registros 
            if (Dgv_Listado.Rows.Count > 0)
            {
                //Antes de eliminar agregare una opcion para que pregunte al usuario si esta seguro de eliminar
                DialogResult Opcion; //Se guardara aqui la respuesta del usuario
                Opcion = MessageBox.Show("Estas seguro de eliminar el registro seleccionado",
                    "AVISO DEL SISTEMA",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if(Opcion==DialogResult.Yes)
                {
                    string Rpta = "";
                    this.Seleccion_item(); //Toma el contenido del Dgv verificando que sea  valido
                    Rpta = N_Familias.Eliminar_fa(this.nCodigo);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_fa("%"); //Actualizamos la informacion 
                        MessageBox.Show("El registro ha sido eliminado",
                            "Aviso del sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show(Rpta, "Aviso del sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                
                this.Limpia_Texto();
               
            }
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            //Para que se puede actualizar el data greed view debe siempre tener contenido
            if (Dgv_Listado.Rows.Count >0) {

                this.Estadoguarda = 2; //Actualizar registro
                this.Estado_BotonesPrincipales(false); //Desactivo botones principales 
                this.Estado_BontonesProceso(true); //Activan
                this.Estado_Texto(true);
                this.Limpia_Texto();
                this.Seleccion_item();
                Tab_Principal.SelectedIndex= 0;
                Txt_descripcion.Focus(); //Para que el  cursor se posicione en txt descripcion
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.Estadoguarda=1; //Nuevo registro

            //Acciona el metodo para limpiar el texto para buscar un nuevo registro 
            Estado_BotonesPrincipales(false); //Desactiva el resto de los botones para que se pase al siguiente paso
            Estado_BontonesProceso(true); //Para activar botn guardar y cancelar y desactivar boton retornar
            this.Limpia_Texto();
            this.Estado_Texto(true); //Se activa para escrbir la caja de texto
            Tab_Principal.SelectedIndex= 0; //Para que pase a la pestaña de mantenimiento, primera pestaña es cero la siguiente 1
            Txt_descripcion.Focus(); //Para que se posicione en la barra de busqueda

        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            //El reporte solo se va a generar si se tiene contenido activo en la tabla
            if (Dgv_Listado.Rows.Count >0)
            {
                //Accedes a la carpeta reportes, instancias un opjeto tipo reporte
               Reportes.Frm_Rpta_Familias oRpt_fa = new Reportes.Frm_Rpta_Familias();
               oRpt_fa.Txtp1.Text = Textbox_buscar.Text.Trim();

             //si el formulario esta filtrado, el reporte tendra lo mismo
               oRpt_fa.ShowDialog(); //Activo la visibilidad del reporte
            }
            
        } 

        private void Dgv_Listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se le quita la opcion de agregar y de edicion porque solo debe mostrar info
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Limpia_Texto();
            this.Estado_Texto(false); //Solo lectura
            this.Estado_BotonesPrincipales(true);
            this.Estado_BontonesProceso(false);
            Tab_Principal.SelectedIndex = 1; //para que pase a pestaña consulta
        }

        private void Btn_retornar_Click(object sender, EventArgs e)
        {
            Tab_Principal.SelectedIndex = 1; //Pasa a pestaña consulta
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Si no tiene datos 
                if(Txt_descripcion.Text== String.Empty) { 
                MessageBox.Show("Falta ingresar datos requeridos ()",
                    "Aviso del sistema",MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }
                else
                {
                    string Rpta="";

                    //La logica de validaciòn no se ejecuta dentro de c#, se usan los
                    // store procedures para ese objetivo
                    //No caragaremos directo a BBD, pasara por capa entidad y despues por negocio
                    E_Familias oPropiedad = new E_Familias();
                    oPropiedad.Codigo_fa=this.nCodigo;
                    oPropiedad.Descripcion_fa=Txt_descripcion.Text.Trim(); //Trim es para mandarlo sin espacios de izquierda ni derecha


                    Rpta =N_Familias.Guardar_fa(this.Estadoguarda, oPropiedad); //Se le pasa al metodo si es registro nuevo 

                    //Verificas si informacion se guardo  de forma correcta
                    if (Rpta.Equals("OK"))
                    { 
                    MessageBox.Show("Los datos se guardaron correctamente",
                        "Aviso del sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        this.Limpia_Texto();
                        this.Estado_Texto(false);
                        this.Estado_BotonesPrincipales(true);
                        this.Estadoguarda =0; //receteamos a valor cero porque ya cumplio el objetivo de cargar un nuevo registro
                        
                        //Se actualice la BBD con los registros que agregamos 
                        this.Listado_fa("%");
                        Tab_Principal.SelectedIndex=1;
                    }
                    else
                    {
                        MessageBox.Show(Rpta,
                            "Aviso del sistema",MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void Dgv_Listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Activo el evento doble click sobre el data gred view

            if(this.Estadoguarda==0) //Se aplica si esta fuera de un proceso de actualizacion o nuevo registro
            {
                //invocamos el metodo
                this.Seleccion_item();
                this.Estado_BontonesProceso(false);
            //Pase a pestaÑa mantenimiendo
            Tab_Principal.SelectedIndex = 0;

            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            //Aplique el filtro o busqueda
            this.Listado_fa(Textbox_buscar.Text.Trim()); //Traremos el texto del textbox sin espacios
        }

        private void Textbox_buscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
