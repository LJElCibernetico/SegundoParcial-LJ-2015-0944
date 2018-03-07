using SegundoParcial_LJ_2015_0944.BLL;
using SegundoParcial_LJ_2015_0944.Entidades;
using SegundoParcial_LJ_2015_0944.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace SegundoParcial_LJ_2015_0944.Consultas
{
    public partial class cPersonas : Form
    {
        Expression<Func<Personas, bool>> filter = x => true;

        public cPersonas()
        {
            InitializeComponent();
        }

        private void buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            String Nombre;
            if (FiltrarComboBox.SelectedIndex == 0)
            {
                id = int.Parse(CriterioTextBox.Text);
                filter = t => t.personaID == id;
            }

            if(FiltrarComboBox.SelectedIndex == 1)
            {
                Nombre = CriterioTextBox.Text;
                filter = t => t.nombre == Nombre;
            }

            if (FiltrarComboBox.SelectedIndex == 2)
                filter = t => (t.fecha >= FechaInicialDateTimePicker.Value) && (t.fecha <= FechaFinalDateTimePicker.Value);
            
            ConsultarDataGridView.DataSource = PersonasBLL.GetList(filter);
        }

        private void imprimirbutton_Click(object sender, EventArgs e)
        {
            ImprimirReporte ir = new ImprimirReporte(PersonasBLL.GetList(filter));
            ir.Show();
        }
    }
}
