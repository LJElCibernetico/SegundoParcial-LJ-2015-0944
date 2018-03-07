namespace SegundoParcial_LJ_2015_0944.Registros
{
    partial class rPersonas
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
            this.TiposDeTelefonoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PersonasDataGridView = new System.Windows.Forms.DataGridView();
            this.TelefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.IDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ValidarErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ConsultarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PersonasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TiposDeTelefonoComboBox
            // 
            this.TiposDeTelefonoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiposDeTelefonoComboBox.FormattingEnabled = true;
            this.TiposDeTelefonoComboBox.Location = new System.Drawing.Point(14, 125);
            this.TiposDeTelefonoComboBox.Name = "TiposDeTelefonoComboBox";
            this.TiposDeTelefonoComboBox.Size = new System.Drawing.Size(84, 21);
            this.TiposDeTelefonoComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombres";
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(65, 47);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(186, 20);
            this.NombresTextBox.TabIndex = 3;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(270, 11);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.FechaDateTimePicker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefono";
            // 
            // PersonasDataGridView
            // 
            this.PersonasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonasDataGridView.Location = new System.Drawing.Point(12, 170);
            this.PersonasDataGridView.Name = "PersonasDataGridView";
            this.PersonasDataGridView.Size = new System.Drawing.Size(353, 169);
            this.PersonasDataGridView.TabIndex = 12;
            this.PersonasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonasDataGridView_CellContentClick);
            // 
            // TelefonoMaskedTextBox
            // 
            this.TelefonoMaskedTextBox.Location = new System.Drawing.Point(140, 126);
            this.TelefonoMaskedTextBox.Mask = "(999) 000-0000";
            this.TelefonoMaskedTextBox.Name = "TelefonoMaskedTextBox";
            this.TelefonoMaskedTextBox.Size = new System.Drawing.Size(78, 20);
            this.TelefonoMaskedTextBox.TabIndex = 17;
            // 
            // IDNumericUpDown
            // 
            this.IDNumericUpDown.Location = new System.Drawing.Point(65, 11);
            this.IDNumericUpDown.Name = "IDNumericUpDown";
            this.IDNumericUpDown.Size = new System.Drawing.Size(33, 20);
            this.IDNumericUpDown.TabIndex = 18;
            // 
            // ValidarErrorProvider
            // 
            this.ValidarErrorProvider.ContainerControl = this;
            // 
            // ConsultarButton
            // 
            this.ConsultarButton.Image = global::SegundoParcial_LJ_2015_0944.Properties.Resources.impresora;
            this.ConsultarButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConsultarButton.Location = new System.Drawing.Point(296, 345);
            this.ConsultarButton.Name = "ConsultarButton";
            this.ConsultarButton.Size = new System.Drawing.Size(69, 56);
            this.ConsultarButton.TabIndex = 16;
            this.ConsultarButton.Text = "Consultar";
            this.ConsultarButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConsultarButton.UseVisualStyleBackColor = true;
            this.ConsultarButton.Click += new System.EventHandler(this.ConsultarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::SegundoParcial_LJ_2015_0944.Properties.Resources.delete_remove_page_document_16678;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.Location = new System.Drawing.Point(205, 345);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(69, 56);
            this.EliminarButton.TabIndex = 15;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::SegundoParcial_LJ_2015_0944.Properties.Resources.Save_as_37111;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.Location = new System.Drawing.Point(104, 345);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(69, 56);
            this.GuardarButton.TabIndex = 14;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::SegundoParcial_LJ_2015_0944.Properties.Resources.contrato;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.Location = new System.Drawing.Point(12, 345);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(69, 56);
            this.NuevoButton.TabIndex = 13;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Image = global::SegundoParcial_LJ_2015_0944.Properties.Resources.New_File_36861;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AddButton.Location = new System.Drawing.Point(302, 107);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(63, 39);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::SegundoParcial_LJ_2015_0944.Properties.Resources.preview_search_find_locate_1551;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(104, 5);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(69, 36);
            this.Buscarbutton.TabIndex = 10;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // rPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 419);
            this.Controls.Add(this.IDNumericUpDown);
            this.Controls.Add(this.TelefonoMaskedTextBox);
            this.Controls.Add(this.ConsultarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.PersonasDataGridView);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TiposDeTelefonoComboBox);
            this.Name = "rPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Personas";
            this.Load += new System.EventHandler(this.rPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TiposDeTelefonoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView PersonasDataGridView;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button ConsultarButton;
        private System.Windows.Forms.MaskedTextBox TelefonoMaskedTextBox;
        private System.Windows.Forms.NumericUpDown IDNumericUpDown;
        private System.Windows.Forms.ErrorProvider ValidarErrorProvider;
    }
}