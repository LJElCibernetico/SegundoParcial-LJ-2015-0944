using SegundoParcial_LJ_2015_0944.DataBase;
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
    }
}
