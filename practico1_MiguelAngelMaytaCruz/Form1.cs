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
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void btnClick_Click(object sender, EventArgs e)
        {
            if (txtCadena1.Text.Length > 0)
            {
                for (int i = 0; i < txtCadena1.Text.Length; i++)
                {
                    if (txtCadena1.Text[i] == Convert.ToChar(txtLetra1.Text))
                    {
                        lblResultado1.Text = ("La letra " + txtCadena1.Text[i] + " se encuentra en la posición " + i.ToString());
                    }
                }
            }
            else
            {
                lblResultado1.Text = "No hay suficientes caracteres.";
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
        private void click(object sender, EventArgs e)
        {
            Button presionado = (Button)sender;
            String numBoton = presionado.Text.Substring(10);
            string nombrePanel = "panel" + numBoton;
            foreach (Control control in Controls)
            {
                if (control is Panel panel)
                {
                    panel.Visible = control.Name == nombrePanel;
                }
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClick4_Click(object sender, EventArgs e)
        {
            String cadena4 = txtCadena4.Text;
            String subcadena = txtSubcadena4.Text;
            if (cadena4.Length > 0)
            {

                lblResultado4.Text = cadena4 + subcadena;
            }
            else
            {
                lblResultado4.Text = "No hay suficientes caracteres.";
            }
        }

        private void btnClick5_Click(object sender, EventArgs e)
        {
            String cadena5 = txtCadena5.Text;
            if (cadena5.Length > 0)
            {
                lblResultado5.Text = cadena5.ToUpper();
            }
            else
            {
                lblResultado5.Text = "No hay suficientes caracteres.";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string cadena6 = txtCadena6.Text;
            string[] palabras = cadena6.Split(' ');

            if (cadena6.Length > 0)
            {
                for (int i = 0; i < palabras.Length; i++)
                {
                    if (palabras[i].Length > 0)
                    {
                        char[] letras = palabras[i].ToCharArray();
                        letras[0] = char.ToUpper(letras[0]);
                        palabras[i] = new string(letras);
                    }
                }
                string resultado = string.Join(" ", palabras);
                lblResultado6.Text = resultado;
            }
            else
            {
                lblResultado6.Text = "No hay suficientes caracteres.";
            }

        }

        private void btnClick7_Click(object sender, EventArgs e)
        {
            string cadena7 = txtCadena7.Text;
            string resultado = "";

            if (cadena7.Length > 0)
            {
                foreach (char letra in cadena7)
                {
                    if (!"aeiouAEIOU".Contains(letra))
                    {
                        resultado += letra;
                    }
                }
                lblResultado7.Text = resultado;
            }
            else
            {
                lblResultado7.Text = "No hay suficientes caracteres.";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string cadena = txtCadena8.Text;
            int numeroPalabra;
            if (int.TryParse(txtPalabra8.Text, out numeroPalabra))
            {
                string[] palabras = cadena.Split(' ');

                if (numeroPalabra >= 1 && numeroPalabra <= palabras.Length)
                {
                    palabras[numeroPalabra - 1] = ""; // Eliminar la palabra en la posición k
                    lblResultado8.Text = string.Join(" ", palabras);
                }
                else
                {
                    lblResultado8.Text = "Número de palabra no válido.";
                }
            }
            else
            {
                lblResultado8.Text = "No hay suficientes caracteres..";
            }
        }

        private void btnClick9_Click(object sender, EventArgs e)
        {
            string cadena9 = txtCadena9.Text;
            string[] palabras = cadena9.Split(' ');
            string resultado = "";

            bool palabraPrecedidaPorC = false;

            

            if (cadena9.Length > 0)
            {
                foreach (string palabra in palabras)
                {
                    if (!palabraPrecedidaPorC && (palabra.Length == 1 || palabra[0] != 'c' && palabra[0] != 'C'))
                    {
                    }
                    else
                    {
                        resultado += palabra + " ";

                    }

                    palabraPrecedidaPorC = palabra.Contains('c') || palabra.Contains('C');
                }
                lblResultado9.Text = resultado.Trim();

            }
            else
            {
                lblResultado9.Text = "No hay suficientes caracteres.";
            }

        }

        private void btnClick10_Click(object sender, EventArgs e)
        {
            string cadena10 = txtCadena10.Text;
            string[] palabras = cadena10.Split(' ');

            int cantidadPalabras = palabras.Length;

            if (cadena10.Length > 0)
            {
            lblResultado10.Text = "Cantidad de palabras: " + cantidadPalabras;
            }
            else
            {
                lblResultado10.Text = "No hay suficientes caracteres.";
            }
            
        }

        private void btnClick11_Click(object sender, EventArgs e)
        {
            string cadena11 = txtCadena11.Text;
            char[] caracteres = cadena11.ToCharArray();
            Array.Reverse(caracteres);
            if (cadena11.Length > 0)
            {
                string resultado = new string(caracteres);
                lblResultado11.Text = resultado;
            }
            else
            {
                lblResultado11.Text = "No hay suficientes caracteres.";
            }
        }

        private void btnClick12_Click(object sender, EventArgs e)
        {
            string cadena12 = txtCadena12.Text;
            string[] palabras = cadena12.Split(' ');
            if (cadena12.Length > 0)
            {
                if (palabras.Length >= 2)
                {
                    palabras[1] = new string(palabras[1].Reverse().ToArray());
                    string resultado = string.Join(" ", palabras);

                    lblResultado12.Text = resultado;
                }
                else
                {
                    lblResultado12.Text = "La cadena debe contener al menos dos palabras.";
                }
            }
            else
            {
                lblResultado12.Text = "No hay suficientes caracteres.";
            }
        }

        private void btnClick13_Click(object sender, EventArgs e)
        {
            string cadena13 = txtCadena13.Text;
            string[] palabras = cadena13.Split(' ');

            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length % 2 != 0 && palabras[i].Contains("c"))
                {
                    palabras[i] = palabras[i].ToUpper();
                }
            }

            string resultado = string.Join(" ", palabras);
            lblResultado13.Text = resultado;
        
      }

        private void btnClick14_Click(object sender, EventArgs e)
        {
            String cadena14 = txtCadena14.Text;
            String cadena14B = txtCadena14B.Text;
            if (cadena14.Length > 0)
            {

                lblResultado14.Text = cadena14 + cadena14B;
            }
            else
            {
                lblResultado14.Text = "No hay suficientes caracteres.";
            }
        }

        private void btnClick15_Click(object sender, EventArgs e)
        {
            string cadena15 = txtCadena15.Text;
            char[] caracteres = cadena15.ToCharArray();
            Array.Sort(caracteres);
            string resultado = new string(caracteres);
            if (cadena15.Length > 0)
            {
                lblResultado15.Text = resultado;
            }
            else
            {
                lblResultado15.Text = "No hay suficientes caracteres.";
            }
        }

        private void btnClick16_Click(object sender, EventArgs e)
        {
            string cadena16 = txtCadena16.Text;
            string[] palabras = cadena16.Split(' ');
            Array.Sort(palabras);
            string resultado = string.Join(" ", palabras);
            if (cadena16.Length > 0)
            {
                lblResultado16.Text = resultado;
            }
            else
            {
                lblResultado16.Text = "No hay suficientes caracteres.";
            }
        }

        private void btnClick17_Click(object sender, EventArgs e)
        {
            string conjuntoA = txtConjuntoA.Text;
            string conjuntoB = txtConjuntoB.Text;
            List<char> resultado = new List<char>();
            foreach (char c in conjuntoA)
            {
                if (conjuntoB.Contains(c))
                {
                    resultado.Add(c);
                }
            }
            string conjuntoC = string.Join(",", resultado);
            if (txtConjuntoA.Text.Length > 0)
            {
                lblResultado17.Text = "Conjunto C = {" + conjuntoC + "}";
            }
            else
            {
                lblResultado17.Text = "No hay suficientes caracteres.";
            }
        }

        private void btnClick18_Click(object sender, EventArgs e)
        {
            int numeroDecimal = int.Parse(txtCadena18.Text);
            string numeroBinario = "";
            if (txtCadena18.Text.Length > 0)
            {
                while (numeroDecimal > 0)
                {
                    int residuo = numeroDecimal % 2;
                    numeroBinario = residuo.ToString() + numeroBinario;
                    numeroDecimal /= 2;
                }
                lblResultado18.Text = numeroBinario;
            }
            else
            {
                lblResultado18.Text = "No hay suficientes caracteres.";
            }
        }

        private void btnClick19_Click(object sender, EventArgs e)
        {
            string cadena19 = txtCadena19.Text;
            int contador = 0;
            string vocales = "aeiouAEIOU";
            if (cadena19.Length > 0)
            {
                for (int i = 0; i < cadena19.Length - 1; i++)
                {
                    if (vocales.Contains(cadena19[i].ToString()) && vocales.Contains(cadena19[i + 1].ToString()))
                    {
                        contador++;
                    }
                }
                lblResultado19.Text = contador.ToString();
            }
            else
            {
                lblResultado19.Text = "No hay suficientes caracteres.";
            }
        }
            
        private void btnClick20_Click(object sender, EventArgs e)
        {
            string cadena20 = txtCadena20.Text;
            if (cadena20.Length > 0)
            {
            char[] caracteres = cadena20.ToCharArray();
            Array.Reverse(caracteres);
            string cadenaInvertida = new string(caracteres);
            lblResultado20.Text = cadenaInvertida;
            }
            else
            {
                lblResultado20.Text = "No hay suficientes caracteres.";
            }
        }

        private void btnClick21_Click(object sender, EventArgs e)
        {
            string conjunto = txtCadena21.Text;
            char[] caracteres = conjunto.ToCharArray();
            if (conjunto.Length > 0)
            {
                for (int i = 0; i < caracteres.Length - 1; i++)
                {
                    for (int j = 0; j < caracteres.Length - 1 - i; j++)
                    {
                        if (caracteres[j] > caracteres[j + 1])
                        {
                            char temp = caracteres[j];
                            caracteres[j] = caracteres[j + 1];
                            caracteres[j + 1] = temp;
                        }
                    }
                }
                string conjuntoOrdenado = new string(caracteres);
                lblResultado21.Text = conjuntoOrdenado;
            }
            else
            {
                lblResultado21.Text = "No hay suficientes caracteres.";
            }
        }
        /*
if (cadena-.Length > 0)
{

}
else
{
lblResultado-.Text = "No hay suficientes caracteres.";
}
*/
    }
}
