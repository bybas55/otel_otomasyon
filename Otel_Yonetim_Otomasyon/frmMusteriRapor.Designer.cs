namespace Otel_Yonetim_Otomasyon
{
    partial class frmMusteriRapor
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
            this.otelDataSet = new Otel_Yonetim_Otomasyon.otelDataSet();
            this.MusterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MusterilerTableAdapter = new Otel_Yonetim_Otomasyon.otelDataSetTableAdapters.MusterilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusterilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.MusterilerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Otel_Yonetim_Otomasyon.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(982, 447);
            this.reportViewer1.TabIndex = 0;
            // 
            // otelDataSet
            // 
            this.otelDataSet.DataSetName = "otelDataSet";
            this.otelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MusterilerBindingSource
            // 
            this.MusterilerBindingSource.DataMember = "Musteriler";
            this.MusterilerBindingSource.DataSource = this.otelDataSet;
            // 
            // MusterilerTableAdapter
            // 
            this.MusterilerTableAdapter.ClearBeforeFill = true;
            // 
            // frmMusteriRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 447);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmMusteriRapor";
            this.Text = "MUSTERİ RAPOR";
            this.Load += new System.EventHandler(this.frmMusteriRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusterilerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MusterilerBindingSource;
        private otelDataSet otelDataSet;
        private otelDataSetTableAdapters.MusterilerTableAdapter MusterilerTableAdapter;
    }
}