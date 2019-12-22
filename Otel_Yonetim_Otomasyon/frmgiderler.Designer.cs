namespace Otel_Yonetim_Otomasyon
{
    partial class frmgiderler
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
            this.otelDataSet5 = new Otel_Yonetim_Otomasyon.otelDataSet5();
            this.GiderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GiderlerTableAdapter = new Otel_Yonetim_Otomasyon.otelDataSet5TableAdapters.GiderlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiderlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GiderlerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Otel_Yonetim_Otomasyon.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(479, 282);
            this.reportViewer1.TabIndex = 0;
            // 
            // otelDataSet5
            // 
            this.otelDataSet5.DataSetName = "otelDataSet5";
            this.otelDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GiderlerBindingSource
            // 
            this.GiderlerBindingSource.DataMember = "Giderler";
            this.GiderlerBindingSource.DataSource = this.otelDataSet5;
            // 
            // GiderlerTableAdapter
            // 
            this.GiderlerTableAdapter.ClearBeforeFill = true;
            // 
            // frmgiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 282);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmgiderler";
            this.Text = "frmgiderler";
            this.Load += new System.EventHandler(this.frmgiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiderlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GiderlerBindingSource;
        private otelDataSet5 otelDataSet5;
        private otelDataSet5TableAdapters.GiderlerTableAdapter GiderlerTableAdapter;
    }
}