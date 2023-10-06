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
            float pendienteUno = 0;
            float pendienteDos = 0;
            float interceptoUno = 0;
            float interceptoDos = 0;
            errores.Visible = false;
            String rectaUno = TextBoxRectaUno.Text;
            String rectaDos = TextBoxRectaDos.Text;
            rectaUno = rectaUno.Trim();
            rectaDos = rectaDos.Trim();
            rectaUno = rectaUno.ToLower();
            rectaDos = rectaDos.ToLower();
            if (comboBox1.Text == "y-y1=m(x-x1)")
            {
                int posicionIgual = rectaUno.IndexOf("=");
                int posicionX = rectaUno.IndexOf("x");
                int posicionY = rectaUno.IndexOf("y");
                int posicionAbrPare = rectaUno.IndexOf("(");
                int posicionCiePare = rectaUno.IndexOf(")");
                if (posicionIgual != -1 && posicionX != -1 && posicionY != -1 && posicionAbrPare == -1 && posicionCiePare == -1 && 
                    posicionY < posicionIgual && posicionIgual < posicionAbrPare && posicionAbrPare == posicionX - 1 && posicionX < posicionCiePare)
                {
                    pendienteUno = pendientePunPend(rectaUno, posicionIgual, posicionAbrPare);
                    if (pendienteUno != (float)Math.PI)
                    {
                        interceptoUno = interceptoPunPend(rectaUno, posicionIgual, posicionX, posicionY, posicionCiePare, pendienteUno);
                    }
                }
                else
                {
                    errores.Text = error;
                    errores.Visible = true;
                }
            }
            if (comboBox2.Text == "y-y1=m(x-x1)")
            {
                int posicionIgual = rectaDos.IndexOf("=");
                int posicionX = rectaDos.IndexOf("x");
                int posicionY = rectaDos.IndexOf("y");
                int posicionAbrPare = rectaDos.IndexOf("(");
                int posicionCiePare = rectaDos.IndexOf(")");
                if (posicionIgual != -1 && posicionX != -1 && posicionY != -1 && posicionAbrPare == -1 && posicionCiePare == -1 &&
                    posicionY < posicionIgual && posicionIgual < posicionAbrPare && posicionAbrPare == posicionX - 1 && posicionX < posicionCiePare)
                {
                    pendienteDos = pendientePunPend(rectaDos, posicionIgual, posicionAbrPare);
                    if (pendienteDos != (float)Math.PI)
                    {
                        interceptoDos = interceptoPunPend(rectaDos, posicionIgual, posicionX, posicionY, posicionCiePare, pendienteDos);
                    }
                }
                else
                {
                    errores.Text = error;
                    errores.Visible = true;
                }
            }
            if (comboBox1.Text == "y=mx+b")
            {
                int posicionIgual = rectaUno.IndexOf("=");
                int posicionY = rectaUno.IndexOf("Y");
                int posicionX = rectaUno.IndexOf("x");
                if (posicionIgual != -1 && posicionY != -1 && posicionX != -1 && posicionY == posicionIgual -1 && posicionX > posicionIgual)
                {
                    pendienteUno = pendientePenInte(rectaUno, posicionX, posicionIgual);
                    if (pendienteUno != (float)Math.PI)
                    {
                        interceptoUno = interceptoPenInte(rectaUno, posicionX);
                    }
                }
                else
                {
                    errores.Text = error;
                    errores.Visible = true;
                }
            }
            if(comboBox2.Text == "y=mx+b")
            {
                int posicionIgual = rectaDos.IndexOf("=");
                int posicionY = rectaDos.IndexOf("y");
                int posicionX = rectaDos.IndexOf("x");
                if (posicionIgual != -1 && posicionY != -1 && posicionX != -1 && posicionY == posicionIgual - 1 && posicionX > posicionIgual)
                {
                    pendienteDos = pendientePenInte(rectaDos, posicionX, posicionIgual);
                    if (pendienteDos != (float)Math.PI)
                    {
                        interceptoDos = interceptoPenInte(rectaDos, posicionX);
                    }
                }
                else
                {
                    errores.Text = error;
                    errores.Visible = true;
                }
            }
            if (pendienteUno != (float)Math.PI && pendienteDos != (float)Math.PI && interceptoUno != (float)Math.PI && interceptoDos != (float)Math.PI)
            {

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
