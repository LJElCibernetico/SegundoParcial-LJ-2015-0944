﻿namespace SegundoParcial_LJ_2015_0944.Reportes
{
    partial class ImprimirReporte
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
            this.PersonasCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // PersonasCrystalReportViewer
            // 
            this.PersonasCrystalReportViewer.ActiveViewIndex = -1;
            this.PersonasCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PersonasCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.PersonasCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonasCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.PersonasCrystalReportViewer.Name = "PersonasCrystalReportViewer";
            this.PersonasCrystalReportViewer.Size = new System.Drawing.Size(284, 261);
            this.PersonasCrystalReportViewer.TabIndex = 0;
            this.PersonasCrystalReportViewer.Load += new System.EventHandler(this.PersonasCrystalReportViewer_Load);
            // 
            // ImprimirReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PersonasCrystalReportViewer);
            this.Name = "ImprimirReporte";
            this.Text = "ImprimirReporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer PersonasCrystalReportViewer;
    }
}