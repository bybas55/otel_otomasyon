namespace Otel_Yonetim_Otomasyon
{
    partial class frmpersonelrapor
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
            this.PersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet4 = new Otel_Yonetim_Otomasyon.otelDataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PersonelTableAdapter = new Otel_Yonetim_Otomasyon.otelDataSet4TableAdapters.PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonelBindingSource
            // 
            this.PersonelBindingSource.DataMember = "Personel";
            this.PersonelBindingSource.DataSource = this.otelDataSet4;
            // 
            // otelDataSet4
            // 
            this.otelDataSet4.DataSetName = "otelDataSet4";
            this.otelDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PersonelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Otel_Yonetim_Otomasyon.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(946, 440);
            this.reportViewer1.TabIndex = 0;
            // 
            // PersonelTableAdapter
            // 
            this.PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // frmpersonelrapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 440);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmpersonelrapor";
            this.Text = "PERSONEL RAPOR";
            this.Load += new System.EventHandler(this.frmpersonelrapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PersonelBindingSource;
        private otelDataSet4 otelDataSet4;
        private otelDataSet4TableAdapters.PersonelTableAdapter PersonelTableAdapter;
    }
}