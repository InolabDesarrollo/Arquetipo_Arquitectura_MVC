namespace Sol_PuntoVentaPresentacion.Reportes
{
    partial class Frm_Rpta_Punto_Venta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetReportesDatosMaestros = new Sol_PuntoVentaPresentacion.Reportes.DataSetReportesDatosMaestros();
            this.uSPlistadopvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_listado_pvTableAdapter = new Sol_PuntoVentaPresentacion.Reportes.DataSetReportesDatosMaestrosTableAdapters.USP_listado_pvTableAdapter();
            this.Txtp1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportesDatosMaestros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPlistadopvBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(524, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(20, 8);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.uSPlistadopvBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Sol_PuntoVentaPresentacion.Reportes.Rpt_Punto_Venta.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1413, 556);
            this.reportViewer2.TabIndex = 1;
            // 
            // dataSetReportesDatosMaestros
            // 
            this.dataSetReportesDatosMaestros.DataSetName = "DataSetReportesDatosMaestros";
            this.dataSetReportesDatosMaestros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPlistadopvBindingSource
            // 
            this.uSPlistadopvBindingSource.DataMember = "USP_listado_pv";
            this.uSPlistadopvBindingSource.DataSource = this.dataSetReportesDatosMaestros;
            // 
            // uSP_listado_pvTableAdapter
            // 
            this.uSP_listado_pvTableAdapter.ClearBeforeFill = true;
            // 
            // Txtp1
            // 
            this.Txtp1.Location = new System.Drawing.Point(97, 57);
            this.Txtp1.Name = "Txtp1";
            this.Txtp1.Size = new System.Drawing.Size(352, 22);
            this.Txtp1.TabIndex = 2;
            this.Txtp1.Visible = false;
            // 
            // Frm_Rpta_Punto_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 556);
            this.Controls.Add(this.Txtp1);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpta_Punto_Venta";
            this.Text = "Frm_Rpta_Punto_Venta";
            this.Load += new System.EventHandler(this.Frm_Rpta_Punto_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportesDatosMaestros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPlistadopvBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource uSPlistadopvBindingSource;
        private DataSetReportesDatosMaestros dataSetReportesDatosMaestros;
        private DataSetReportesDatosMaestrosTableAdapters.USP_listado_pvTableAdapter uSP_listado_pvTableAdapter;
        internal System.Windows.Forms.TextBox Txtp1;
    }
}