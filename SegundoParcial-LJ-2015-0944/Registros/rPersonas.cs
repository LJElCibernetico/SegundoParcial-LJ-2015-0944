using SegundoParcial_LJ_2015_0944.BLL;
using SegundoParcial_LJ_2015_0944.Consultas;
using SegundoParcial_LJ_2015_0944.DataBase;
using SegundoParcial_LJ_2015_0944.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SegundoParcial_LJ_2015_0944.Registros
{
    public partial class rPersonas : Form
    {
        List<TiposDeTelefonoDetalle> ListaDetalle = new List<TiposDeTelefonoDetalle>();
        public rPersonas()
        {
            InitializeComponent();
        }

        private void rPersonas_Load(object sender, EventArgs e)
        {
            CargarTiposDeTelefono ctt = new CargarTiposDeTelefono();
            ctt.conectar();
            ctt.llenarComboBox(TiposDeTelefonoComboBox);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        bool change = false;
        int x = 0;
        private void Changes(TiposDeTelefonoDetalle telefono)
        {
            if (change)
            {
                ListaDetalle[x].Telefono = TelefonoMaskedTextBox.Text;
                ListaDetalle[x].Tipo = TiposDeTelefonoComboBox.GetItemText(TiposDeTelefonoComboBox.SelectedItem);
                change = false;
                x = -1;
                PersonasDataGridView.DataSource = ListaDetalle.ToList();
                return;
            }

            ListaDetalle.Add(telefono);
            PersonasDataGridView.DataSource = ListaDetalle.ToList();

        }

        private void LimpiarTextBox()
        {
            IDNumericUpDown.Value = 0;
            NombresTextBox.Text = String.Empty;
            FechaDateTimePicker.Value = DateTime.Now;
            TiposDeTelefonoComboBox.Text = String.Empty;
            TelefonoMaskedTextBox.Text = String.Empty;
        }

        private Personas LlenarClase(List<TiposDeTelefonoDetalle> lista)
        {
            Personas persona = new Personas();
            persona.personaID = (int)IDNumericUpDown.Value;
            persona.nombre = NombresTextBox.Text;
            persona.fecha = FechaDateTimePicker.Value;
            persona.Lista = lista;
            return persona;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (PersonasBLL.Eliminar((int)IDNumericUpDown.Value))
                MessageBox.Show("Se elimino la persona");
            else
                MessageBox.Show("No se pudo eliminar esta persona");

            LimpiarTextBox();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Personas persona = PersonasBLL.Buscar((int)IDNumericUpDown.Value);
            Personas p1 = LlenarClase(ListaDetalle);
            if (persona == null)
            {
                if (NombresTextBox.Text == String.Empty || TiposDeTelefonoComboBox.Text == String.Empty || TelefonoMaskedTextBox.Text == String.Empty || FechaDateTimePicker.Text == String.Empty)
                {
                    ValidarErrorProvider.SetError(GuardarButton, "No puede dejar nada vacio");
                }
                else if (PersonasBLL.Guardar(p1))
                        MessageBox.Show("Se guardo esta persona");
                    else if(!PersonasBLL.Guardar(p1))
                        MessageBox.Show("No se pudo guardar esta persona");
            }
            else
            {
                if (PersonasBLL.Modificar(p1))
                    MessageBox.Show("Se modifico esta persona");
                else if (!PersonasBLL.Modificar(p1))
                    MessageBox.Show("No se pudo modificar esta persona");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Personas persona = PersonasBLL.Buscar((int)IDNumericUpDown.Value);
            if (persona != null)
            {
                NombresTextBox.Text = persona.nombre;
                FechaDateTimePicker.Value = persona.fecha;
                ListaDetalle = persona.Lista;
                PersonasDataGridView.DataSource = persona.Lista.ToList();
            }
            else
                MessageBox.Show("Esta persona no existe");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (TelefonoMaskedTextBox.MaskCompleted)
            {
                Changes(new TiposDeTelefonoDetalle(
                    0,
                    ((int)IDNumericUpDown.Value != 0) ? (int)IDNumericUpDown.Value : 0,
                    DevolverID(TiposDeTelefonoComboBox.Text),
                    TiposDeTelefonoComboBox.GetItemText(TiposDeTelefonoComboBox.SelectedItem), TelefonoMaskedTextBox.Text
                    ));
                ValidarErrorProvider.SetError(TelefonoMaskedTextBox, "");
                ValidarErrorProvider.SetError(PersonasDataGridView, "");
            }
            else
                ValidarErrorProvider.SetError(TelefonoMaskedTextBox, "No es un numero de telefono valido");
        }

        private int DevolverID(String tdtc)
        {
            int id = 0;
            if (tdtc == "Recidencial")
                id = 1;
            else if (tdtc == "Trabajo")
                id = 2;
            else if (tdtc == "Oficina")
                id = 3;
            else if (tdtc == "Casa")
                id = 4;
            else if (tdtc == "Celular")
                id = 5;

            return id;
        }

        private void PersonasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            Console.WriteLine(e.ColumnIndex + " " + e.RowIndex);
            TelefonoMaskedTextBox.Text = ListaDetalle[e.RowIndex].Telefono;
            TiposDeTelefonoComboBox.SelectedIndex = ListaDetalle[e.RowIndex].TiposDeTelefonoID - 1;
            x = e.RowIndex;
            change = true;
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            cPersonas cp = new cPersonas();
            cp.Show();
        }
    }
}
