namespace POS
{
    partial class ReportView
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
            this.ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AkornoDataSet = new POS.AkornoDataSet();
            this.ReportTableAdapter = new POS.AkornoDataSetTableAdapters.ReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AkornoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AkornoReportDataset";
            reportDataSource1.Value = this.ReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(905, 508);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportBindingSource
            // 
            this.ReportBindingSource.DataMember = "Report";
            this.ReportBindingSource.DataSource = this.AkornoDataSet;
            // 
            // AkornoDataSet
            // 
            this.AkornoDataSet.DataSetName = "AkornoDataSet";
            this.AkornoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportTableAdapter
            // 
            this.ReportTableAdapter.ClearBeforeFill = true;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 508);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportView";
            this.Text = "Report View";
            this.Load += new System.EventHandler(this.ReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AkornoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportBindingSource;
        private AkornoDataSet AkornoDataSet;
        private AkornoDataSetTableAdapters.ReportTableAdapter ReportTableAdapter;
    }
}