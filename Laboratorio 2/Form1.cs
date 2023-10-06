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

            }
            if (comboBox2.Text == "y-y1=m(x-x1")
            {

            }
            if (comboBox1.Text == "y=mx+b")
            {

            }
            if(comboBox2.Text == "y=mx+b")
            {

            }
        }

        public float pendientePenInte(String recta)
        {

            int posicionIgual = recta.IndexOf("=");
            int posicionX = recta.IndexOf("x");
            int intervalo = posicionIgual - posicionX - 1;
            String pendienteString = recta.Substring(posicionX + 1, intervalo);
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
        public float interceptoPenInte(String recta)
        {
            int posicionX = recta.IndexOf('X');
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
        public float pendientePunPend(String recta)
        {

        }
    }
}
