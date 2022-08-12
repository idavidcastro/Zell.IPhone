using Entidad;
using Lógica;
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
    public partial class FrmRegistro : Form
    {
        Registro registro;
        List<Registro> registros;
        RegistroService registroService;

        public FrmRegistro()
        {
            InitializeComponent();
            registroService = new RegistroService(ConfigConnectionString.Cadena);
            CargarListado();
        }
        public void CargarListado()
        {
            registros = new List<Registro>();
            registros = registroService.ConsultarListRegistros();

            dataConsultaEnRegistro.DataSource = registros;
        }
        public void LimpiarCampos()
        {
            txtNombreCliente.Text = " ";
            cmbIphone.Text = " ";
            cmbAppleWatch.Text = " ";
            txtSamsung.Text = " ";
            cmbGB.Text = " ";
            cmbColor.Text = " ";
            txtIMEI1.Text = " ";
            txtIMEI2.Text = " ";
            txtEntrada.Text = " ";
            txtSalida.Text = " ";
            txtObservacion.Text = " ";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registro = new Registro()
            {                
                FechaIngreso = DateTime.Parse(dateTimePicker1.Text),               
                NombreCliente = txtNombreCliente.Text,
                Iphone= cmbIphone.Text,
                AppleWatch= cmbAppleWatch.Text,
                Samsung= txtSamsung.Text,
                GB= cmbGB.Text,
                Color= cmbColor.Text,
                IMEI1= txtIMEI1.Text,
                IMEI2= txtIMEI2.Text,
                Entrada= txtEntrada.Text,
                Salida = txtSalida.Text,
                Observacion= txtObservacion.Text
            };
            

            string mensaje = registroService.GuardarRegistro(registro);
            MessageBox.Show(mensaje, "Guardar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarListado();
            LimpiarCampos();
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >=32 && e.KeyChar <=64) || (e.KeyChar >=91 && e.KeyChar <=96) || (e.KeyChar >=123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo se permiten letras en este campo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIMEI1_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtIMEI1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo se permiten números en este campo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIMEI2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo se permiten números en este campo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo se permiten números en este campo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo se permiten números en este campo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dataConsultaEnRegistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker1.Text= dataConsultaEnRegistro.CurrentRow.Cells[0].Value.ToString();
            txtNombreCliente.Text = dataConsultaEnRegistro.CurrentRow.Cells[1].Value.ToString();
            cmbIphone.Text = dataConsultaEnRegistro.CurrentRow.Cells[2].Value.ToString();
            cmbAppleWatch.Text= dataConsultaEnRegistro.CurrentRow.Cells[3].Value.ToString();
            Samsung.Text = dataConsultaEnRegistro.CurrentRow.Cells[4].Value.ToString();
            cmbGB.Text = dataConsultaEnRegistro.CurrentRow.Cells[5].Value.ToString();
            cmbColor.Text = dataConsultaEnRegistro.CurrentRow.Cells[6].Value.ToString();
            txtIMEI1.Text = dataConsultaEnRegistro.CurrentRow.Cells[7].Value.ToString();
            txtIMEI2.Text = dataConsultaEnRegistro.CurrentRow.Cells[8].Value.ToString();
            txtEntrada.Text = dataConsultaEnRegistro.CurrentRow.Cells[9].Value.ToString();
            txtSalida.Text = dataConsultaEnRegistro.CurrentRow.Cells[10].Value.ToString();
            txtObservacion.Text = dataConsultaEnRegistro.CurrentRow.Cells[11].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            registro = new Registro()
            {
                FechaIngreso = DateTime.Parse(dateTimePicker1.Value.ToString("dd/MM/yyyy")),
                NombreCliente = txtNombreCliente.Text,
                Iphone = cmbIphone.Text,
                AppleWatch = cmbAppleWatch.Text,
                Samsung = txtSamsung.Text,
                GB = cmbGB.Text,
                Color = cmbColor.Text,
                IMEI1 = txtIMEI1.Text,
                IMEI2 = txtIMEI2.Text,
                Entrada = txtEntrada.Text,
                Salida = txtSalida.Text,
                Observacion = txtObservacion.Text
            };

            DialogResult resul = MessageBox.Show("¿Seguro que quiere modificar este registro?", "Modificar", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                string mensaje = registroService.ModificarRegistro(registro, txtIMEI1.Text);
                MessageBox.Show(mensaje, "Modificar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListado();
                LimpiarCampos();
            } 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string IMEI1 = Convert.ToString(dataConsultaEnRegistro.CurrentRow.Cells[7].Value);

            DialogResult resul = MessageBox.Show("¿Seguro que quiere eliminar este registro?", "Eliminiar", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                string mensaje = registroService.EliminarRegistro(IMEI1);
                MessageBox.Show(mensaje, "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListado();
                LimpiarCampos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarListado();
            cmbOpcionesdeConsulta.Text = " ";
            cmbBlanco.Text = " ";
            txtBlanco.Text = " ";
            
        }

        private void btnBuscarEnRegistro_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            
            btnGuardar.Enabled = false;          
            btnEliminar.Enabled = false;
            //btnBuscarEnRegistro.Enabled = false;
            
        }
        public void Validar()
        {
            var vr = !string.IsNullOrEmpty(txtIMEI1.Text);

            btnGuardar.Enabled = vr;

        }
        

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbIphone_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbAppleWatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSamsung_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbGB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSalida_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIMEI2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTelefonoConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBlanco_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                    dataConsultaEnRegistro.DataSource = respuesta.Registros;
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
                    dataConsultaEnRegistro.DataSource = respuesta.Registros;
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
                    dataConsultaEnRegistro.DataSource = respuesta.Registros;
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
                    dataConsultaEnRegistro.DataSource = respuesta.Registros;
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
                    dataConsultaEnRegistro.DataSource = respuesta.Registros;
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
                    dataConsultaEnRegistro.DataSource = respuesta.Registros;
                }
            }
        }

        private void txtBlanco_KeyUp(object sender, KeyEventArgs e)
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
                dataConsultaEnRegistro.DataSource = dt;

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
                dataConsultaEnRegistro.DataSource = dt;
            }
            else if (cmbOpcionesdeConsulta.Text.Equals("IMEI 1"))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select *from Registro where IMEI1 like ('" + txtBlanco.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                dataConsultaEnRegistro.DataSource = dt;
            }
            else if (cmbOpcionesdeConsulta.Text.Equals("IMEI 2"))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select *from Registro where IMEI2 like ('" + txtBlanco.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                dataConsultaEnRegistro.DataSource = dt;
            }
            cn.Close();
        }

        private void cmbOpcionesdeConsulta_SelectedIndexChanged(object sender, EventArgs e)
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
            else if (cmbOpcionesdeConsulta.Text.Equals("IMEI 1"))
            {
                txtBlanco.Visible = true;
                cmbBlanco.Visible = false;
            }
            else if (cmbOpcionesdeConsulta.Text.Equals("IMEI 2"))
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

        private void dataConsultaEnRegistro_SelectionChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
        }
    }
}
