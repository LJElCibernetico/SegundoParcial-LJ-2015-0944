namespace SegundoParcial_LJ_2015_0944.Consultas
{
    partial class cPersonas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.FiltrarComboBox = new System.Windows.Forms.ComboBox();
            this.ConsultarDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaInicialDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaFinalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.imprimirbutton = new System.Windows.Forms.Button();
            this.buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Metodo de busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = " Filtro";
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(105, 113);
            this.CriterioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(283, 20);
            this.CriterioTextBox.TabIndex = 56;
            // 
            // FiltrarComboBox
            // 
            this.FiltrarComboBox.FormattingEnabled = true;
            this.FiltrarComboBox.Items.AddRange(new object[] {
            "Persona ID",
            "Nombre",
            "Fecha"});
            this.FiltrarComboBox.Location = new System.Drawing.Point(9, 113);
            this.FiltrarComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FiltrarComboBox.Name = "FiltrarComboBox";
            this.FiltrarComboBox.Size = new System.Drawing.Size(92, 21);
            this.FiltrarComboBox.TabIndex = 55;
            // 
            // ConsultarDataGridView
            // 
            this.ConsultarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultarDataGridView.Location = new System.Drawing.Point(9, 137);
            this.ConsultarDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultarDataGridView.Name = "ConsultarDataGridView";
            this.ConsultarDataGridView.RowTemplate.Height = 24;
            this.ConsultarDataGridView.Size = new System.Drawing.Size(456, 298);
            this.ConsultarDataGridView.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Fecha Inicial";
            // 
            // FechaInicialDateTimePicker
            // 
            this.FechaInicialDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaInicialDateTimePicker.Location = new System.Drawing.Point(91, 20);
            this.FechaInicialDateTimePicker.Name = "FechaInicialDateTimePicker";
            this.FechaInicialDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.FechaInicialDateTimePicker.TabIndex = 63;
            // 
            // FechaFinalDateTimePicker
            // 
            this.FechaFinalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaFinalDateTimePicker.Location = new System.Drawing.Point(91, 50);
            this.FechaFinalDateTimePicker.Name = "FechaFinalDateTimePicker";
            this.FechaFinalDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.FechaFinalDateTimePicker.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Fecha Final";
            // 
            // imprimirbutton
            // 
            this.imprimirbutton.Image = global::SegundoParcial_LJ_2015_0944.Properties.Resources.impresora;
            this.imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.imprimirbutton.Location = new System.Drawing.Point(194, 440);
            this.imprimirbutton.Name = "imprimirbutton";
            this.imprimirbutton.Size = new System.Drawing.Size(72, 56);
            this.imprimirbutton.TabIndex = 60;
            this.imprimirbutton.Text = "Imprimir";
            this.imprimirbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.imprimirbutton.UseVisualStyleBackColor = true;
            this.imprimirbutton.Click += new System.EventHandler(this.imprimirbutton_Click);
            // 
            // buscarbutton
            // 
            this.buscarbutton.Image = global::SegundoParcial_LJ_2015_0944.Properties.Resources.preview_search_find_locate_1551;
            this.buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buscarbutton.Location = new System.Drawing.Point(393, 94);
            this.buscarbutton.Name = "buscarbutton";
            this.buscarbutton.Size = new System.Drawing.Size(72, 40);
            this.buscarbutton.TabIndex = 59;
            this.buscarbutton.Text = "Buscar";
            this.buscarbutton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buscarbutton.UseVisualStyleBackColor = true;
            this.buscarbutton.Click += new System.EventHandler(this.buscarbutton_Click);
            // 
            // cPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 508);
            this.Controls.Add(this.FechaFinalDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FechaInicialDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imprimirbutton);
            this.Controls.Add(this.buscarbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.FiltrarComboBox);
            this.Controls.Add(this.ConsultarDataGridView);
            this.Name = "cPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Personas";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button imprimirbutton;
        private System.Windows.Forms.Button buscarbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.ComboBox FiltrarComboBox;
        private System.Windows.Forms.DataGridView ConsultarDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechaInicialDateTimePicker;
        private System.Windows.Forms.DateTimePicker FechaFinalDateTimePicker;
        private System.Windows.Forms.Label label4;
    }
}