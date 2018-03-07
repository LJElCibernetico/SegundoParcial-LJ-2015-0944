using SegundoParcial_LJ_2015_0944.Consultas;
using SegundoParcial_LJ_2015_0944.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SegundoParcial_LJ_2015_0944
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPersonas rp = new rPersonas();
            rp.MdiParent = this;
            rp.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void estudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cPersonas cp = new cPersonas();
            cp.MdiParent = this;
            cp.Show();
        }
    }
}
