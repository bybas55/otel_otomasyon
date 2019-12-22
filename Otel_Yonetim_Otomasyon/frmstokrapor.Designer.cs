namespace Otel_Yonetim_Otomasyon
{
    partial class frmstokrapor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.StoklarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet2 = new Otel_Yonetim_Otomasyon.otelDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StoklarTableAdapter = new Otel_Yonetim_Otomasyon.otelDataSet2TableAdapters.StoklarTableAdapter();
            this.otelDataSet6 = new Otel_Yonetim_Otomasyon.otelDataSet6();
            this.StokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StokTableAdapter = new Otel_Yonetim_Otomasyon.otelDataSet6TableAdapters.StokTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StoklarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StoklarBindingSource
            // 
            this.StoklarBindingSource.DataMember = "Stoklar";
            this.StoklarBindingSource.DataSource = this.otelDataSet2;
            // 
            // otelDataSet2
            // 
            this.otelDataSet2.DataSetName = "otelDataSet2";
            this.otelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StokBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Otel_Yonetim_Otomasyon.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(681, 360);
            this.reportViewer1.TabIndex = 0;
            // 
            // StoklarTableAdapter
            // 
            this.StoklarTableAdapter.ClearBeforeFill = true;
            // 
            // otelDataSet6
            // 
            this.otelDataSet6.DataSetName = "otelDataSet6";
            this.otelDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StokBindingSource
            // 
            this.StokBindingSource.DataMember = "Stok";
            this.StokBindingSource.DataSource = this.otelDataSet6;
            // 
            // StokTableAdapter
            // 
            this.StokTableAdapter.ClearBeforeFill = true;
            // 
            // frmstokrapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 360);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmstokrapor";
            this.Text = "frmstokrapor";
            this.Load += new System.EventHandler(this.frmstokrapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StoklarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StoklarBindingSource;
        private otelDataSet2 otelDataSet2;
        private otelDataSet2TableAdapters.StoklarTableAdapter StoklarTableAdapter;
        private System.Windows.Forms.BindingSource StokBindingSource;
        private otelDataSet6 otelDataSet6;
        private otelDataSet6TableAdapters.StokTableAdapter StokTableAdapter;
    }
}