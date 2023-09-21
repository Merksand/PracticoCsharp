using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace practico1_MiguelAngelMaytaCruz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //visible(panel1);
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void btnClick_Click(object sender, EventArgs e)
        {
            if (txtCadena.Text.Length > 0)
            {
                for (int i = 0; i < txtCadena.Text.Length; i++)
                {
                    if (txtCadena.Text[i] == Convert.ToChar(txtLetra.Text))
                    {
                        lblResultado.Text = ("La letra " + txtCadena.Text[i] + " se encuentra en la posición " + i.ToString());
                    }
                }
            }
            else
            {
                lblResultado.Text = "No hay suficientes caracteres.";
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnClick2_Click(object sender, EventArgs e)
        {
            string texto2 = txtCadena2.Text;
            if (texto2.Length >= 2)
            {
                char caracterAnteriorAlUltimo = texto2[texto2.Length - 2];
                lblResultado2.Text = "El penúltimo carácter es: " + caracterAnteriorAlUltimo.ToString();
            }
            else
            {
                lblResultado2.Text = "No hay suficientes caracteres.";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
        }
        public void visible(Control indice)
        {
            //foreach (Control boton in Controles)
            //{

            //}
            indice.Visible = true;
        }

        private void click(object sender, EventArgs e)
        {

            Button presionado = (Button)sender;
            String numBoton = presionado.Text.Substring(10);
            string nombrePanel = "panel" + numBoton;
            lblFuera.Text = nombrePanel;

            Control[] controles = Controls.Find(nombrePanel, true);
            Panel panelCorrespondiente = (Panel)controles[0];
            panelCorrespondiente.Visible = true;


            if (controles.Length > 0 && controles[0] is Panel)
            {
                Panel panelCorrespondiente = (Panel)controles[0];
                panelCorrespondiente.Visible = true;
            }
  


        }
        private void btnClick3_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string consonantes = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
            foreach (char letra in txtCadena3.Text)
            {
                if (consonantes.Contains(letra))
                {
                    contador++;
                }
            }
            if (contador > 0)
            {
                lblResultado3.Text = "El total de consonantes es: " + contador;

            }
            else
            {
                lblResultado3.Text = "No hay consonantes en la cadena";
            }
        }

    }
}
