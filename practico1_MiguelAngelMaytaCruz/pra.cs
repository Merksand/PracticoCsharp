using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practico1_MiguelAngelMaytaCruz
{
    public partial class pra : Form
    {
        public pra()
        {
            InitializeComponent();
        }

        private void pra_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void click2(object sender, EventArgs e)
        {

            Button presionado = (Button)sender;
            String numBoton = presionado.Text.Substring(10);
            string nombrePanel = "panel" + numBoton;
            lblFuera.Text = nombrePanel;

            foreach (Control control in Controls)
            {
                if (control is Panel panel)
                {
                    panel.Visible = control.Name == nombrePanel;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClick3_Click(object sender, EventArgs e)
        {

        }
    }
}
