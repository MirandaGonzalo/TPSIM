
namespace WindowsFormsApp1
{
    partial class Informe
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
            this.ReportTablaFrecuencia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportTablaFrecuencia
            // 
            this.ReportTablaFrecuencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportTablaFrecuencia.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.ReporteHisto.rdlc";
            this.ReportTablaFrecuencia.Location = new System.Drawing.Point(0, 0);
            this.ReportTablaFrecuencia.Name = "ReportTablaFrecuencia";
            this.ReportTablaFrecuencia.ServerReport.BearerToken = null;
            this.ReportTablaFrecuencia.Size = new System.Drawing.Size(800, 450);
            this.ReportTablaFrecuencia.TabIndex = 0;
            this.ReportTablaFrecuencia.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportTablaFrecuencia);
            this.Name = "Informe";
            this.Text = "Informe";
            this.Load += new System.EventHandler(this.Informe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportTablaFrecuencia;
    }
}