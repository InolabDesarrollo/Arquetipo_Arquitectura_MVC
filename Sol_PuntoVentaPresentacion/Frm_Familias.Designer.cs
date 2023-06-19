using System;

namespace Sol_PuntoVentaPresentacion
{
    partial class Frm_Familias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Familias));
            this.Tab_Principal = new System.Windows.Forms.TabControl();
            this.Mantenimiento = new System.Windows.Forms.TabPage();
            this.Btn_retornar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Consulta = new System.Windows.Forms.TabPage();
            this.Lbl_totalregistros = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Textbox_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_Listado = new System.Windows.Forms.DataGridView();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.Pnl_TituloFormulario = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Tab_Principal.SuspendLayout();
            this.Mantenimiento.SuspendLayout();
            this.Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).BeginInit();
            this.Pnl_TituloFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Principal
            // 
            this.Tab_Principal.Controls.Add(this.Mantenimiento);
            this.Tab_Principal.Controls.Add(this.Consulta);
            this.Tab_Principal.ItemSize = new System.Drawing.Size(100, 30);
            this.Tab_Principal.Location = new System.Drawing.Point(67, 46);
            this.Tab_Principal.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_Principal.Name = "Tab_Principal";
            this.Tab_Principal.SelectedIndex = 0;
            this.Tab_Principal.Size = new System.Drawing.Size(905, 463);
            this.Tab_Principal.TabIndex = 0;
            // 
            // Mantenimiento
            // 
            this.Mantenimiento.Controls.Add(this.Btn_retornar);
            this.Mantenimiento.Controls.Add(this.Btn_guardar);
            this.Mantenimiento.Controls.Add(this.Btn_cancelar);
            this.Mantenimiento.Controls.Add(this.Txt_descripcion);
            this.Mantenimiento.Controls.Add(this.label2);
            this.Mantenimiento.Location = new System.Drawing.Point(4, 34);
            this.Mantenimiento.Margin = new System.Windows.Forms.Padding(4);
            this.Mantenimiento.Name = "Mantenimiento";
            this.Mantenimiento.Padding = new System.Windows.Forms.Padding(4);
            this.Mantenimiento.Size = new System.Drawing.Size(897, 425);
            this.Mantenimiento.TabIndex = 0;
            this.Mantenimiento.Text = "Mantenimiento";
            this.Mantenimiento.UseVisualStyleBackColor = true;
            this.Mantenimiento.Click += new System.EventHandler(this.Mantenimiento_Click);
            // 
            // Btn_retornar
            // 
            this.Btn_retornar.BackColor = System.Drawing.Color.LightGray;
            this.Btn_retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_retornar.Location = new System.Drawing.Point(432, 75);
            this.Btn_retornar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_retornar.Name = "Btn_retornar";
            this.Btn_retornar.Size = new System.Drawing.Size(117, 32);
            this.Btn_retornar.TabIndex = 6;
            this.Btn_retornar.Text = "Retornar";
            this.Btn_retornar.UseVisualStyleBackColor = false;
            this.Btn_retornar.Visible = false;
            this.Btn_retornar.Click += new System.EventHandler(this.Btn_retornar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.LightGray;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Location = new System.Drawing.Point(293, 75);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(117, 32);
            this.Btn_guardar.TabIndex = 5;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Visible = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.LightGray;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Location = new System.Drawing.Point(168, 75);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(117, 32);
            this.Btn_cancelar.TabIndex = 4;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Visible = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Location = new System.Drawing.Point(149, 28);
            this.Txt_descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.ReadOnly = true;
            this.Txt_descripcion.Size = new System.Drawing.Size(493, 22);
            this.Txt_descripcion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Punto de Venta";
            // 
            // Consulta
            // 
            this.Consulta.Controls.Add(this.Lbl_totalregistros);
            this.Consulta.Controls.Add(this.Btn_buscar);
            this.Consulta.Controls.Add(this.Textbox_buscar);
            this.Consulta.Controls.Add(this.label1);
            this.Consulta.Controls.Add(this.Dgv_Listado);
            this.Consulta.Location = new System.Drawing.Point(4, 34);
            this.Consulta.Margin = new System.Windows.Forms.Padding(4);
            this.Consulta.Name = "Consulta";
            this.Consulta.Padding = new System.Windows.Forms.Padding(4);
            this.Consulta.Size = new System.Drawing.Size(897, 425);
            this.Consulta.TabIndex = 1;
            this.Consulta.Text = "Consulta";
            this.Consulta.UseVisualStyleBackColor = true;
            // 
            // Lbl_totalregistros
            // 
            this.Lbl_totalregistros.AutoSize = true;
            this.Lbl_totalregistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_totalregistros.Location = new System.Drawing.Point(734, 385);
            this.Lbl_totalregistros.Name = "Lbl_totalregistros";
            this.Lbl_totalregistros.Size = new System.Drawing.Size(124, 16);
            this.Lbl_totalregistros.TabIndex = 4;
            this.Lbl_totalregistros.Text = " Total registros 0";
            this.Lbl_totalregistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Btn_buscar.Location = new System.Drawing.Point(453, 43);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(117, 32);
            this.Btn_buscar.TabIndex = 3;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Textbox_buscar
            // 
            this.Textbox_buscar.Location = new System.Drawing.Point(84, 50);
            this.Textbox_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_buscar.Name = "Textbox_buscar";
            this.Textbox_buscar.Size = new System.Drawing.Size(347, 22);
            this.Textbox_buscar.TabIndex = 2;
            this.Textbox_buscar.TextChanged += new System.EventHandler(this.Textbox_buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // Dgv_Listado
            // 
            this.Dgv_Listado.AllowUserToAddRows = false;
            this.Dgv_Listado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dgv_Listado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Listado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Dgv_Listado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dgv_Listado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Listado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Listado.ColumnHeadersHeight = 35;
            this.Dgv_Listado.EnableHeadersVisualStyles = false;
            this.Dgv_Listado.Location = new System.Drawing.Point(8, 80);
            this.Dgv_Listado.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Listado.Name = "Dgv_Listado";
            this.Dgv_Listado.ReadOnly = true;
            this.Dgv_Listado.RowHeadersWidth = 51;
            this.Dgv_Listado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Listado.Size = new System.Drawing.Size(850, 292);
            this.Dgv_Listado.TabIndex = 0;
            this.Dgv_Listado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Listado_CellContentClick);
            this.Dgv_Listado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Listado_CellDoubleClick);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.ImageKey = "NuevoReporte.png";
            this.BtnNuevo.ImageList = this.imageList1;
            this.BtnNuevo.Location = new System.Drawing.Point(67, 511);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(155, 58);
            this.BtnNuevo.TabIndex = 5;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Actualizar.png");
            this.imageList1.Images.SetKeyName(1, "eliminar.png");
            this.imageList1.Images.SetKeyName(2, "nuevo.png");
            this.imageList1.Images.SetKeyName(3, "NuevoReporte.png");
            this.imageList1.Images.SetKeyName(4, "salir.png");
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.ImageKey = "Actualizar.png";
            this.BtnActualizar.ImageList = this.imageList1;
            this.BtnActualizar.Location = new System.Drawing.Point(240, 511);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(168, 58);
            this.BtnActualizar.TabIndex = 6;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ImageKey = "eliminar.png";
            this.BtnEliminar.ImageList = this.imageList1;
            this.BtnEliminar.Location = new System.Drawing.Point(420, 511);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(168, 58);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnReporte
            // 
            this.BtnReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporte.ImageKey = "NuevoReporte.png";
            this.BtnReporte.ImageList = this.imageList1;
            this.BtnReporte.Location = new System.Drawing.Point(596, 511);
            this.BtnReporte.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(168, 58);
            this.BtnReporte.TabIndex = 8;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.ImageKey = "salir.png";
            this.BtnSalir.ImageList = this.imageList1;
            this.BtnSalir.Location = new System.Drawing.Point(799, 511);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(168, 58);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Pnl_TituloFormulario
            // 
            this.Pnl_TituloFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Pnl_TituloFormulario.Controls.Add(this.label3);
            this.Pnl_TituloFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_TituloFormulario.Location = new System.Drawing.Point(0, 0);
            this.Pnl_TituloFormulario.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_TituloFormulario.Name = "Pnl_TituloFormulario";
            this.Pnl_TituloFormulario.Size = new System.Drawing.Size(1312, 43);
            this.Pnl_TituloFormulario.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Familias";
            // 
            // Frm_Familias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.Pnl_TituloFormulario);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.Tab_Principal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Familias";
            this.Text = "Frm_Familias";
            this.Load += new System.EventHandler(this.Frm_Familias_Load);
            this.Tab_Principal.ResumeLayout(false);
            this.Mantenimiento.ResumeLayout(false);
            this.Mantenimiento.PerformLayout();
            this.Consulta.ResumeLayout(false);
            this.Consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).EndInit();
            this.Pnl_TituloFormulario.ResumeLayout(false);
            this.Pnl_TituloFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Mantenimiento_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl Tab_Principal;
        private System.Windows.Forms.TabPage Mantenimiento;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Consulta;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Textbox_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_Listado;
        private System.Windows.Forms.Button Btn_retornar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel Pnl_TituloFormulario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_totalregistros;
    }
}