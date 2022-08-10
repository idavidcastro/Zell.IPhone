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
            cmbTelefono.Text = " ";
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
                Telefono= cmbTelefono.Text,
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
    }
}
