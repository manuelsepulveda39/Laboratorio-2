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
        String errorLetra = "Solo se permiten numeros";
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            erroresUno.Visible = false;
            erroresDos.Visible = false;
            String rectaUno = TextBoxRectaUno.Text;
            String rectaDos = TextBoxRectaDos.Text;
            rectaUno = rectaUno.Trim();
            rectaDos = rectaDos.Trim();
            rectaUno = rectaUno.ToLower();
            rectaDos = rectaDos.ToLower();
            int posicionIgualUno = rectaUno.IndexOf("=");
            int posicionIgualDos = rectaDos.IndexOf("=");
            int posicionXUno = rectaUno.IndexOf("x");
            int posicionXDos = rectaDos.IndexOf("x");
            int posicionYUno = rectaUno.IndexOf("y");
            int posicionYDos = rectaDos.IndexOf("y");
            
            if ((posicionIgualUno == -1 || posicionXUno == -1 || posicionYUno == -1) && 
                (posicionIgualDos == -1 || posicionXDos == -1 || posicionYDos == -1))
            {

            }
            else if (posicionIgualUno == -1 || posicionXUno == -1 || posicionYUno == -1)
            {
                erroresUno.Text = error;
                erroresUno.Visible = true;
            }
            else if (posicionIgualDos == -1 || posicionXDos == -1 || posicionYDos == -1)
            { 
                erroresDos.Text = error;
                erroresDos.Visible = true;
            }
            else
            {
                if (posicionXUno < posicionIgualUno || posicionIgualUno < posicionYUno || posicionYUno != 0 || posicionIgualUno != 1)
                {
                    erroresUno.Text = error;
                    erroresUno.Visible = true;
                }
                if (posicionXDos < posicionIgualDos || posicionIgualDos < posicionYDos || posicionYDos != 0 || posicionIgualDos != 1)
                {
                    erroresDos.Text = error;
                    erroresDos.Visible = true;
                }
                if (posicionYUno < posicionIgualUno && posicionIgualUno < posicionXUno && posicionYDos < posicionIgualDos
                    && posicionIgualDos < posicionXDos && posicionIgualDos == 1 && posicionIgualUno == 1 && posicionYUno == 0
                    && posicionYDos == 0)
                {
                    int intervaloUno = posicionXUno - 2;
                    String pendienteUnoString = rectaUno.Substring(2 , intervaloUno);
                    int intervaloDos = posicionXDos - 2;
                    String pendienteDosString = rectaDos.Substring(2, intervaloDos);
                    float pendienteUno;
                    float pendienteDos;
                    if ((float.TryParse(pendienteUnoString, out  pendienteUno) || posicionXUno == posicionIgualUno + 1) &&
                        (float.TryParse(pendienteDosString, out pendienteDos) || posicionXDos == posicionIgualDos + 1))
                    {
                        if (posicionXUno == posicionIgualUno + 1)
                        {
                            pendienteUno = 1;
                        }
                        if (posicionXDos == posicionIgualDos + 1)
                        {
                            pendienteDos = 1;
                        }
                        String interceptoUnoString = rectaUno.Substring(posicionXUno + 1);
                        String interceptoDosString = rectaDos.Substring(posicionXDos + 1);
                        float interceptoUno;
                        float interceptoDos;
                        if ((float.TryParse(interceptoUnoString, out interceptoUno) || interceptoUnoString.Length == posicionXUno + 1)
                            && (float.TryParse(interceptoDosString, out interceptoDos) || interceptoDosString.Length == posicionXDos + 1 ))
                        {
                            if(interceptoUnoString.Length == posicionXUno + 1)
                            {
                                interceptoUno = 0;
                            }
                            if (interceptoDosString.Length == posicionXDos + 1)
                            {
                                interceptoDos = 0;
                            }
                        }
                        else
                        {
                            if (float.TryParse(interceptoUnoString, out interceptoUno))
                            {
                                erroresDos.Text = errorLetra;
                                erroresDos.Visible = true;
                            }
                            if (float.TryParse(interceptoDosString, out interceptoDos))
                            {
                                erroresUno.Text = errorLetra;
                                erroresUno.Visible = true;
                            }
                            else if (!(float.TryParse(interceptoUnoString, out interceptoUno)))
                            {
                                erroresDos.Text = errorLetra;
                                erroresDos.Visible = true;
                                erroresUno.Text = errorLetra;
                                erroresUno.Visible = true;
                            }
                        }
                    }
                    else
                    {
                        if(float.TryParse(pendienteUnoString,out pendienteUno))
                        {
                            erroresDos.Text = errorLetra;
                            erroresDos.Visible = true;
                        }
                        if (float.TryParse(pendienteDosString, out pendienteDos))
                        {
                            erroresUno.Text = errorLetra;
                            erroresUno.Visible = true;
                        }
                        else if (!(float.TryParse(pendienteUnoString, out pendienteUno)))
                        {
                            erroresDos.Text = errorLetra;
                            erroresDos.Visible = true;
                            erroresUno.Text = errorLetra;
                            erroresUno.Visible = true;
                        }
                    }
                }
            }
        }
    }
}
