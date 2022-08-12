using Lógica;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Esteban
{
    public partial class FrmConsulta : Form
    {
        RegistroService registroService;
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOpcionesdeConsulta.Text.Equals("Iphone"))
            {
                cmbBlanco.Visible = true;
                txtBlanco.Visible = false;

                cmbBlanco.Items.Clear();
                cmbBlanco.Items.Add("IPhone 6");
                cmbBlanco.Items.Add("IPhone 6s");
                cmbBlanco.Items.Add("IPhone 6s Plus");
                cmbBlanco.Items.Add("IPhone 7");
                cmbBlanco.Items.Add("IPhone 7 Plus");
                cmbBlanco.Items.Add("IPhone 8");
                cmbBlanco.Items.Add("IPhone 8 Plus");
                cmbBlanco.Items.Add("IPhone X");
                cmbBlanco.Items.Add("IPhone XR");
                cmbBlanco.Items.Add("IPhone XS");
                cmbBlanco.Items.Add("IPhone XS Max");
                cmbBlanco.Items.Add("IPhone 11");
                cmbBlanco.Items.Add("IPhone 11 Pro");
                cmbBlanco.Items.Add("IPhone 11 Pro Max");
                cmbBlanco.Items.Add("IPhone 12");
                cmbBlanco.Items.Add("IPhone 12 Pro");
                cmbBlanco.Items.Add("IPhone 12 Pro Max");
                cmbBlanco.Items.Add("IPhone 13");
                cmbBlanco.Items.Add("IPhone 13 Pro");
                cmbBlanco.Items.Add("IPhone 13 Pro Max");
                cmbBlanco.Items.Add("IPhone SE 2020");

                BusquedaReponseRegistro respuesta;
            }
            else if (cmbOpcionesdeConsulta.Text.Equals("Apple Watch"))
            {
                cmbBlanco.Visible = true;
                txtBlanco.Visible = false;

                cmbBlanco.Items.Clear();
                cmbBlanco.Items.Add("Serie 1");
                cmbBlanco.Items.Add("Serie 2");
                cmbBlanco.Items.Add("Serie 3");
                cmbBlanco.Items.Add("Serie 4");
                cmbBlanco.Items.Add("Serie 5");
                cmbBlanco.Items.Add("Serie 6");
                cmbBlanco.Items.Add("Serie 7");

            }
            else if (cmbOpcionesdeConsulta.Text.Equals("Samsung"))
            {
                txtBlanco.Visible = true;
                cmbBlanco.Visible = false;


            }
            else if (cmbOpcionesdeConsulta.Text.Equals("Nombre"))
            {
                txtBlanco.Visible = true;
                cmbBlanco.Visible = false;


            }
            else if (cmbOpcionesdeConsulta.Text.Equals("IMEI"))
            {
                txtBlanco.Visible = true;
                cmbBlanco.Visible = false;
            }
            else if (cmbOpcionesdeConsulta.Text.Equals("IMEI"))
            {
                txtBlanco.Visible = true;
                cmbBlanco.Visible = false;
            }
            else if (cmbOpcionesdeConsulta.Text.Equals("Color"))
            {
                cmbBlanco.Visible = true;
                txtBlanco.Visible = false;

                cmbBlanco.Items.Clear();
                cmbBlanco.Items.Add("Amarillo");
                cmbBlanco.Items.Add("Azul");
                cmbBlanco.Items.Add("Blanco");
                cmbBlanco.Items.Add("Dorado");
                cmbBlanco.Items.Add("Negro");
                cmbBlanco.Items.Add("Plateado");
                cmbBlanco.Items.Add("Rojo");
                cmbBlanco.Items.Add("Rosado");
                cmbBlanco.Items.Add("Verde");
            }
            else if (cmbOpcionesdeConsulta.Text.Equals("GB"))
            {
                cmbBlanco.Visible = true;
                txtBlanco.Visible = false;

                cmbBlanco.Items.Clear();
                cmbBlanco.Items.Add("32");
                cmbBlanco.Items.Add("64");
                cmbBlanco.Items.Add("128");
                cmbBlanco.Items.Add("256");
            }

        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreCliente_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigConnectionString.Cadena);
            cn.Open();

            if (cmbOpcionesdeConsulta.Text.Equals("Nombre"))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select *from Registro where Nombre like ('" + txtBlanco.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                dataConsultaEnConsulta.DataSource = dt;

            }
            else if (cmbOpcionesdeConsulta.Text.Equals("Samsung"))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select *from Registro where Samsung like ('" + txtBlanco.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                dataConsultaEnConsulta.DataSource = dt;
            }
            cn.Close();
        }

        private void cmbBlanco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBlanco_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusquedaReponseRegistro respuesta;
            

            /*
            ConsultaReponseRegistro respuesta;

            respuesta = registroService.ConsultarRegistrosIMEI1(cmbBlanco.Text);

            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje);
            }
            else
            {
                dataConsultaEnConsulta.DataSource = respuesta.Registros;
            }
            
            if (cmbOpcionesdeConsulta.Text.Equals("Iphone"))
            {
                ConsultaReponseRegistro respuesta;

                respuesta = registroService.ConsultarRegistrosIphone(cmbBlanco.Text);

                if (respuesta.Error)
                {
                    MessageBox.Show(respuesta.Mensaje);
                }
                else
                {
                    dataConsultaEnConsulta.DataSource = respuesta.Registros;
                }
            }
            else if (cmbOpcionesdeConsulta.Text.Equals("Apple Watch"))
            {
                ConsultaReponseRegistro respuesta;

                respuesta = registroService.ConsultarRegistrosAppleWatch(cmbBlanco.Text);

                if (respuesta.Error)
                {
                    MessageBox.Show(respuesta.Mensaje);
                }
                else
                {
                    dataConsultaEnConsulta.DataSource = respuesta.Registros;
                }
            }
            else if (cmbOpcionesdeConsulta.Text.Equals("IMEI1"))
            {
                ConsultaReponseRegistro respuesta;

                respuesta = registroService.ConsultarRegistrosIMEI1(cmbBlanco.Text);

                if (respuesta.Error)
                {
                    MessageBox.Show(respuesta.Mensaje);
                }
                else
                {
                    dataConsultaEnConsulta.DataSource = respuesta.Registros;
                }
            }
            else if (cmbOpcionesdeConsulta.Text.Equals("IMEI2"))
            {
                ConsultaReponseRegistro respuesta;

                respuesta = registroService.ConsultarRegistrosIMEI2(cmbBlanco.Text);

                if (respuesta.Error)
                {
                    MessageBox.Show(respuesta.Mensaje);
                }
                else
                {
                    dataConsultaEnConsulta.DataSource = respuesta.Registros;
                }
            }
            else if (cmbOpcionesdeConsulta.Text.Equals("Color"))
            {
                ConsultaReponseRegistro respuesta;

                respuesta = registroService.ConsultarRegistrosColor(cmbBlanco.Text);

                if (respuesta.Error)
                {
                    MessageBox.Show(respuesta.Mensaje);
                }
                else
                {
                    dataConsultaEnConsulta.DataSource = respuesta.Registros;
                }
            }
            else if (cmbOpcionesdeConsulta.Text.Equals("GB"))
            {
                ConsultaReponseRegistro respuesta;

                respuesta = registroService.ConsultarRegistrosGB(cmbBlanco.Text);

                if (respuesta.Error)
                {
                    MessageBox.Show(respuesta.Mensaje);
                }
                else
                {
                    dataConsultaEnConsulta.DataSource = respuesta.Registros;
                }
            }
            */
        }
    }
}
