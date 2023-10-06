using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_2
{
    public partial class Form1 : Form
    {
        String error = "La formula esta mal escrita";
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            errores.Visible = false;
            String rectaUno = TextBoxRectaUno.Text;
            String rectaDos = TextBoxRectaDos.Text;
            rectaUno = rectaUno.Trim();
            rectaDos = rectaDos.Trim();
            rectaUno = rectaUno.ToLower();
            rectaDos = rectaDos.ToLower();
            if (comboBox1.Text == "y-y1=m(x-x1")
            {
                int posicionIgual = rectaUno.IndexOf("=");
                int posicionX = rectaUno.IndexOf("x");
                int posicionY = rectaUno.IndexOf("y");
                int posicionAbrPare = rectaUno.IndexOf("(");
                int posicionCiePare = rectaUno.IndexOf(")");

            }
            if (comboBox2.Text == "y-y1=m(x-x1")
            {
                int posicionIgual = rectaDos.IndexOf("=");
                int posicionX = rectaDos.IndexOf("x");
                int posicionY = rectaDos.IndexOf("y");
                int posicionAbrPare = rectaDos.IndexOf("(");
                int posicionCiePare = rectaDos.IndexOf(")");
            }
            if (comboBox1.Text == "y=mx+b")
            {
                int posicionIgual = rectaUno.IndexOf("=");
                int posicionParen = rectaUno.IndexOf("Y");
                int posicionX = rectaUno.IndexOf("x");
            }
            if(comboBox2.Text == "y=mx+b")
            {
                int posicionIgual = rectaDos.IndexOf("=");
                int posicionParen = rectaDos.IndexOf("Y");
                int posicionX = rectaDos.IndexOf("x");
            }
        }

        public float pendientePenInte(String recta, int posicionX, int posicionIgual)
        {
            int intervalo = posicionX - posicionIgual - 1;
            String pendienteString = recta.Substring(posicionIgual + 1, intervalo);
            float pendiente = 0;
            if (float.TryParse(pendienteString, out pendiente))
            {
                return pendiente;
            }
            else
            {
                errores.Text = error;
                errores.Visible = true;
                return (float)Math.PI;
            }
        }
        public float interceptoPenInte(String recta, int posicionX)
        {
            String interceptoString = recta.Substring(posicionX+1);
            float intercepto = 0;
            if (float.TryParse(interceptoString, out intercepto))
            {
                return intercepto;
            }
            else
            {
                errores.Text = error;
                errores.Visible = true;
                return (float)Math.PI;
            }

        }
        public float pendientePunPend(String recta, int posicionIgual, int posicionParen)
        {
            int intervalo = posicionParen - posicionIgual - 1;
            String pendienteString = recta.Substring(posicionIgual + 1, intervalo);
            float pendiente = 0;
            if (float.TryParse(pendienteString, out pendiente))
            {
                return pendiente;
            }
            else
            {
                errores.Text = error;
                errores.Visible = true;
                return (float)Math.PI;
            }
        }
        public float interceptoPunPend(String recta, int posicionIgual, int posicionX, int posicionY,
            int posicionCieParen, float pendiente)
        {
            int intervaloYIgual = posicionIgual - posicionY - 1;
            int intervaloXParen = posicionCieParen - posicionX - 1;
            String yString = recta.Substring(posicionY + 1, intervaloYIgual);
            String xString = recta.Substring(posicionX + 1, intervaloXParen);
            float x = 0;
            float y = 0;
            if (float.TryParse(xString, out x) && float.TryParse(yString, out y))
            {
                return ((x * pendiente) - y);
            }
            else
            {
                errores.Text = error;
                errores.Visible = true;
                return (float)Math.PI;
            }
        }
    }
}
