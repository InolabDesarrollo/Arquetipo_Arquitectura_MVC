namespace Sol_PuntoVentaPresentacion.Reportes
{
    partial class Frm_Rpta_Familias
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
            this.dataSetReportesDatosMaestros = new Sol_PuntoVentaPresentacion.Reportes.DataSetReportesDatosMaestros();
            this.uSPlistadofaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_listado_faTableAdapter = new Sol_PuntoVentaPresentacion.Reportes.DataSetReportesDatosMaestrosTableAdapters.USP_listado_faTableAdapter();
            this.Txtp1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportesDatosMaestros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPlistadofaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.uSPlistadofaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_PuntoVentaPresentacion.Reportes.Rpt_Familias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(934, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetReportesDatosMaestros
            // 
            this.dataSetReportesDatosMaestros.DataSetName = "DataSetReportesDatosMaestros";
            this.dataSetReportesDatosMaestros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPlistadofaBindingSource
            // 
            this.uSPlistadofaBindingSource.DataMember = "USP_listado_fa";
            this.uSPlistadofaBindingSource.DataSource = this.dataSetReportesDatosMaestros;
            // 
            // uSP_listado_faTableAdapter
            // 
            this.uSP_listado_faTableAdapter.ClearBeforeFill = true;
            // 
            // Txtp1
            // 
            this.Txtp1.Location = new System.Drawing.Point(54, 51);
            this.Txtp1.Name = "Txtp1";
            this.Txtp1.Size = new System.Drawing.Size(352, 22);
            this.Txtp1.TabIndex = 3;
            this.Txtp1.Visible = false;
            // 
            // Frm_Rpta_Familias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 522);
            this.Controls.Add(this.Txtp1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpta_Familias";
            this.Text = "Frm_Rpta_Familias";
            this.Load += new System.EventHandler(this.Frm_Rpta_Familias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportesDatosMaestros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPlistadofaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPlistadofaBindingSource;
        private DataSetReportesDatosMaestros dataSetReportesDatosMaestros;
        private DataSetReportesDatosMaestrosTableAdapters.USP_listado_faTableAdapter uSP_listado_faTableAdapter;
        internal System.Windows.Forms.TextBox Txtp1;
    }
}