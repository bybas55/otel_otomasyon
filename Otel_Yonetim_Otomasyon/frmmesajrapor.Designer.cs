namespace Otel_Yonetim_Otomasyon
{
    partial class frmmesajrapor
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.otelDataSet1 = new Otel_Yonetim_Otomasyon.otelDataSet1();
            this.MesajlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MesajlarTableAdapter = new Otel_Yonetim_Otomasyon.otelDataSet1TableAdapters.MesajlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesajlarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MesajlarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Otel_Yonetim_Otomasyon.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(639, 392);
            this.reportViewer1.TabIndex = 0;
            // 
            // otelDataSet1
            // 
            this.otelDataSet1.DataSetName = "otelDataSet1";
            this.otelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MesajlarBindingSource
            // 
            this.MesajlarBindingSource.DataMember = "Mesajlar";
            this.MesajlarBindingSource.DataSource = this.otelDataSet1;
            // 
            // MesajlarTableAdapter
            // 
            this.MesajlarTableAdapter.ClearBeforeFill = true;
            // 
            // frmmesajrapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 392);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmmesajrapor";
            this.Text = "MESAJ RAPOR";
            this.Load += new System.EventHandler(this.frmmesajrapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesajlarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MesajlarBindingSource;
        private otelDataSet1 otelDataSet1;
        private otelDataSet1TableAdapters.MesajlarTableAdapter MesajlarTableAdapter;
    }
}