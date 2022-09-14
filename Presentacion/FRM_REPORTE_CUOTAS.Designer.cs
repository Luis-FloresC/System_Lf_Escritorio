namespace Presentacion
{
    partial class FRM_REPORTE_CUOTAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_REPORTE_CUOTAS));
            this.Reports_PrestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.System_LfDataSet4 = new Presentacion.System_LfDataSet4();
            this.REPORTE_PRESTAMOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.System_LfDataSet3 = new Presentacion.System_LfDataSet3();
            this.VW_VISTA_REPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.System_LfDataSet = new Presentacion.System_LfDataSet();
            this.VW_VISTA_REPORTTableAdapter = new Presentacion.System_LfDataSetTableAdapters.VW_VISTA_REPORTTableAdapter();
            this.System_LfDataSet2 = new Presentacion.System_LfDataSet2();
            this.ReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteTableAdapter = new Presentacion.System_LfDataSet2TableAdapters.ReporteTableAdapter();
            this.REPORTE_PRESTAMOSTableAdapter = new Presentacion.System_LfDataSet3TableAdapters.REPORTE_PRESTAMOSTableAdapter();
            this.Reports_PrestamoTableAdapter = new Presentacion.System_LfDataSet4TableAdapters.Reports_PrestamoTableAdapter();
            this.BTN_CERRAR = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Reports_PrestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.System_LfDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORTE_PRESTAMOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.System_LfDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_VISTA_REPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.System_LfDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.System_LfDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CERRAR)).BeginInit();
            this.SuspendLayout();
            // 
            // Reports_PrestamoBindingSource
            // 
            this.Reports_PrestamoBindingSource.DataMember = "Reports_Prestamo";
            this.Reports_PrestamoBindingSource.DataSource = this.System_LfDataSet4;
            // 
            // System_LfDataSet4
            // 
            this.System_LfDataSet4.DataSetName = "System_LfDataSet4";
            this.System_LfDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // REPORTE_PRESTAMOSBindingSource
            // 
            this.REPORTE_PRESTAMOSBindingSource.DataMember = "REPORTE_PRESTAMOS";
            this.REPORTE_PRESTAMOSBindingSource.DataSource = this.System_LfDataSet3;
            // 
            // System_LfDataSet3
            // 
            this.System_LfDataSet3.DataSetName = "System_LfDataSet3";
            this.System_LfDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VW_VISTA_REPORTBindingSource
            // 
            this.VW_VISTA_REPORTBindingSource.DataMember = "VW_VISTA_REPORT";
            this.VW_VISTA_REPORTBindingSource.DataSource = this.System_LfDataSet;
            // 
            // System_LfDataSet
            // 
            this.System_LfDataSet.DataSetName = "System_LfDataSet";
            this.System_LfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VW_VISTA_REPORTTableAdapter
            // 
            this.VW_VISTA_REPORTTableAdapter.ClearBeforeFill = true;
            // 
            // System_LfDataSet2
            // 
            this.System_LfDataSet2.DataSetName = "System_LfDataSet2";
            this.System_LfDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteBindingSource
            // 
            this.ReporteBindingSource.DataMember = "Reporte";
            this.ReporteBindingSource.DataSource = this.System_LfDataSet2;
            // 
            // ReporteTableAdapter
            // 
            this.ReporteTableAdapter.ClearBeforeFill = true;
            // 
            // REPORTE_PRESTAMOSTableAdapter
            // 
            this.REPORTE_PRESTAMOSTableAdapter.ClearBeforeFill = true;
            // 
            // Reports_PrestamoTableAdapter
            // 
            this.Reports_PrestamoTableAdapter.ClearBeforeFill = true;
            // 
            // BTN_CERRAR
            // 
            this.BTN_CERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_CERRAR.BackColor = System.Drawing.Color.Transparent;
            this.BTN_CERRAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CERRAR.Image = ((System.Drawing.Image)(resources.GetObject("BTN_CERRAR.Image")));
            this.BTN_CERRAR.Location = new System.Drawing.Point(740, 1);
            this.BTN_CERRAR.Name = "BTN_CERRAR";
            this.BTN_CERRAR.Size = new System.Drawing.Size(52, 51);
            this.BTN_CERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTN_CERRAR.TabIndex = 60;
            this.BTN_CERRAR.TabStop = false;
            this.BTN_CERRAR.Click += new System.EventHandler(this.BTN_CERRAR_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibilityKeyMap = null;
            this.reportViewer1.Location = new System.Drawing.Point(12, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(722, 305);
            this.reportViewer1.TabIndex = 61;
            // 
            // FRM_REPORTE_CUOTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 398);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.BTN_CERRAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_REPORTE_CUOTAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_REPORTE_CUOTAS";
            this.Load += new System.EventHandler(this.FRM_REPORTE_CUOTAS_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_REPORTE_CUOTAS_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Reports_PrestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.System_LfDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORTE_PRESTAMOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.System_LfDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_VISTA_REPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.System_LfDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.System_LfDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CERRAR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource VW_VISTA_REPORTBindingSource;
        private System_LfDataSet System_LfDataSet;
        private System_LfDataSetTableAdapters.VW_VISTA_REPORTTableAdapter VW_VISTA_REPORTTableAdapter;
        private System.Windows.Forms.BindingSource ReporteBindingSource;
        private System_LfDataSet2 System_LfDataSet2;
        private System_LfDataSet2TableAdapters.ReporteTableAdapter ReporteTableAdapter;
        private System.Windows.Forms.BindingSource REPORTE_PRESTAMOSBindingSource;
        private System_LfDataSet3 System_LfDataSet3;
        private System_LfDataSet3TableAdapters.REPORTE_PRESTAMOSTableAdapter REPORTE_PRESTAMOSTableAdapter;
        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reports_PrestamoBindingSource;
        private System_LfDataSet4 System_LfDataSet4;
        private System_LfDataSet4TableAdapters.Reports_PrestamoTableAdapter Reports_PrestamoTableAdapter;
        private System.Windows.Forms.PictureBox BTN_CERRAR;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
    }
}