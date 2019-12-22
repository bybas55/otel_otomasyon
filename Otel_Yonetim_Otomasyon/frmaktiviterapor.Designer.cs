namespace Otel_Yonetim_Otomasyon
{
    partial class frmaktiviterapor
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
            this.otelDataSet3 = new Otel_Yonetim_Otomasyon.otelDataSet3();
            this.AktiviteTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AktiviteTablosuTableAdapter = new Otel_Yonetim_Otomasyon.otelDataSet3TableAdapters.AktiviteTablosuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AktiviteTablosuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AktiviteTablosuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Otel_Yonetim_Otomasyon.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(564, 277);
            this.reportViewer1.TabIndex = 0;
            // 
            // otelDataSet3
            // 
            this.otelDataSet3.DataSetName = "otelDataSet3";
            this.otelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AktiviteTablosuBindingSource
            // 
            this.AktiviteTablosuBindingSource.DataMember = "AktiviteTablosu";
            this.AktiviteTablosuBindingSource.DataSource = this.otelDataSet3;
            // 
            // AktiviteTablosuTableAdapter
            // 
            this.AktiviteTablosuTableAdapter.ClearBeforeFill = true;
            // 
            // frmaktiviterapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 277);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmaktiviterapor";
            this.Text = "frmaktiviterapor";
            this.Load += new System.EventHandler(this.frmaktiviterapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AktiviteTablosuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AktiviteTablosuBindingSource;
        private otelDataSet3 otelDataSet3;
        private otelDataSet3TableAdapters.AktiviteTablosuTableAdapter AktiviteTablosuTableAdapter;
    }
}