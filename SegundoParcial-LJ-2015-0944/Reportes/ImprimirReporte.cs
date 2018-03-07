using SegundoParcial_LJ_2015_0944.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SegundoParcial_LJ_2015_0944.Reportes
{
    public partial class ImprimirReporte : Form
    {
        List<Personas> lista = new List<Personas>();
        public ImprimirReporte(List<Personas> listas)
        {
            lista = listas;
            InitializeComponent();
        }

        private void PersonasCrystalReportViewer_Load(object sender, EventArgs e)
        {
            PersonasCrystalReport pcr = new PersonasCrystalReport();

            pcr.Load(@"C:\Users\LJ\Desktop\Programacion\7. Aplicada 1\SegundoParcial-LJ-2015-0944\SegundoParcial-LJ-2015-0944\Reportes\PersonasCrystalReport.rpt");
            pcr.SetDataSource(lista);

            PersonasCrystalReportViewer.ReportSource = pcr;
            PersonasCrystalReportViewer.Refresh();
        }
    }
}
