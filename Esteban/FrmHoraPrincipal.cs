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
    public partial class FrmHoraPrincipal : Form
    {
        public FrmHoraPrincipal()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString("hh:mm:ss");
            fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void fecha_Click(object sender, EventArgs e)
        {

        }
    }
}
