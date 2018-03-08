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
    }
}
