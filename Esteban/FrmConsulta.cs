using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esteban
{
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOpcionesdeConsulta.Text.Equals("Teléfono"))
            {
                cmbBlanco.Visible = true;
                txtNombreClienteConsultar.Visible = false;
                labelBlanco.Text = "Teléfono:";


            }
            else if (cmbOpcionesdeConsulta.Text.Equals("Nombre"))
            {
                txtNombreClienteConsultar.Visible = true;
                cmbBlanco.Visible = false;
                labelBlanco.Text = "Nombre:";
                
            }
            else if (cmbOpcionesdeConsulta.Text.Equals("IMEI"))
            {
                labelBlanco.Text = "IMEI:";
            }
            else if (cmbOpcionesdeConsulta.Text.Equals("Color"))
            {
                labelBlanco.Text = "Color:";
            }
            else if (cmbOpcionesdeConsulta.Text.Equals("GB"))
            {
                labelBlanco.Text = "GB:";
            }

        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreCliente_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigConnectionString.Cadena);
            cn.Open();

            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select *from Registro where Telefono like ('"+ txtNombreClienteConsultar.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataConsultaEnConsulta.DataSource = dt;


            cn.Close();
        }
    }
}
