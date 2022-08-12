using Entidad;
using Lógica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                FechaIngreso = dateTimePicker1.Text,               
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
                FechaIngreso = dateTimePicker1.Value.ToString("dd/MM/yyyy"),
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
            cmbTelefonoConsulta.Text = " ";
        }

        private void btnBuscarEnRegistro_Click(object sender, EventArgs e)
        {
            
            ConsultaReponseRegistro respuesta;

            respuesta = registroService.ConsultarRegistrosIMEI1(cmbTelefonoConsulta.Text);

            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje);
            }
            else
            {
                dataConsultaEnRegistro.DataSource = respuesta.Registros;
            }
            
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
    }
}
