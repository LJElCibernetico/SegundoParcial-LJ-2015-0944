using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace SegundoParcial_LJ_2015_0944.DataBase
{
    public class CargarTiposDeTelefono
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader sdr;
        
        public void conectar()
        {
            try
            {
                /*Añadir la conexion de la base de datos que creo, aqui*/
                cnn = new SqlConnection(@"Data Source=LJ-PC\SQLEXPRESS;Initial Catalog=segundoParcialDB;Integrated Security=True");
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Conectado: " + ex.ToString());
            }
        }

        public void llenarComboBox(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("SELECT tipo FROM TiposDeTelefonos", cnn);
                sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    cb.Items.Add(sdr["tipo"].ToString());
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Llenar el ComboBox: " + ex.ToString());
            }
        }
    }
}
