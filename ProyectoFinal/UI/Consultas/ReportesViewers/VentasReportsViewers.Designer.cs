namespace ProyectoFinal.UI.Consultas.ReportesViewers
{
    partial class VentasReportsViewers
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
            this.MycrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // MycrystalReportViewer
            // 
            this.MycrystalReportViewer.ActiveViewIndex = -1;
            this.MycrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MycrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.MycrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MycrystalReportViewer.Location = new System.Drawing.Point(20, 60);
            this.MycrystalReportViewer.Name = "MycrystalReportViewer";
            this.MycrystalReportViewer.Size = new System.Drawing.Size(783, 420);
            this.MycrystalReportViewer.TabIndex = 0;
            // 
            // VentasReportsViewers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 500);
            this.Controls.Add(this.MycrystalReportViewer);
            this.Name = "VentasReportsViewers";
            this.Text = "Reporte de Ventas";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer MycrystalReportViewer;
    }
}