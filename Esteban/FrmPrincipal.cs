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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        public void MostrarFormulario(Form formulario)
        {
            if (panelBlancoPrincipal.Controls.Count > 0)
            {
                panelBlancoPrincipal.Controls.RemoveAt(0);
            }

            formulario.TopLevel = false;
            this.panelBlancoPrincipal.Controls.Add(formulario);
            formulario.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegistro = new FrmRegistro();
            MostrarFormulario(frmRegistro);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmConsulta frmConsulta = new FrmConsulta();
            MostrarFormulario(frmConsulta);

        }

        private void btnCerrarPrincipal_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("¿Seguro que quiere salir de la aplicación?", "Salir", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmHoraPrincipal frmHoraPrincipal = new FrmHoraPrincipal();
            MostrarFormulario(frmHoraPrincipal);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString("hh:mm:ss");
            fecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
