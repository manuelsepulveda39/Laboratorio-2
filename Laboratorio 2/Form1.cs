using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Hola sofi, espero te guste mi codigo. Perdon si cometi algun error de ortografia

namespace Laboratorio_2
{
    public partial class Form1 : Form
    {
        //Aca se define el error
        String error = "La formula esta mal escrita";
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            //Se crean e inicializan las variables
            float pendienteUno = 0;
            float pendienteDos = 0;
            float interceptoUno = 0;
            float interceptoDos = 0;

            //Se pone la solucion y los errores en oculto
            errores.Visible = false;
            solucion.Visible = false;
            intercepto.Visible = false;

            //Se nombran las rectas, se le quitan espacios y mayusculas
            String rectaUno = TextBoxRectaUno.Text;
            String rectaDos = TextBoxRectaDos.Text;
            rectaUno = rectaUno.Replace(" ", "");
            rectaDos = rectaDos.Replace(" ", "");
            rectaUno = rectaUno.ToLower();
            rectaDos = rectaDos.ToLower();

            //si se ingresa la misma recta se le dice al usuario desde el inicio
            if (rectaUno == rectaDos)
            {
                solucion.Text = "Son la misma recta";
                solucion.Visible = true;
            }
            else
            {
                // se valida cual es la opcion que puso el usuario
                if (comboBox1.Text == "y-y1=m(x-x1)")
                {
                    // se crean variables con las posiciones de las cosas que deben tener las ecuaciones
                    int posicionIgual = rectaUno.IndexOf("=");
                    int posicionX = rectaUno.IndexOf("x");
                    int posicionY = rectaUno.IndexOf("y");
                    int posicionAbrPare = rectaUno.IndexOf("(");
                    int posicionCiePare = rectaUno.IndexOf(")");

                    //Se valida que se alla ingresado todas las cosas necesarias y en el orden correcto
                    if (posicionIgual != -1 && posicionX != -1 && posicionY != -1 && posicionAbrPare != -1 && posicionCiePare != -1 &&
                        posicionY < posicionIgual && posicionIgual < posicionAbrPare && posicionAbrPare == posicionX - 1 && posicionX < posicionCiePare)
                    {
                        //Se llama la funcion para saber la pendiete de la recta
                        pendienteUno = pendientePunPend(rectaUno, posicionIgual, posicionAbrPare);

                        //Se verifica que la pendiente si se correcta
                        if (pendienteUno != (float)Math.PI)
                        {
                            //Se llama la funcion del intercepto
                            interceptoUno = interceptoPunPend(rectaUno, posicionIgual, posicionX, posicionY, posicionCiePare, pendienteUno);
                        }
                    }
                    else
                    {
                        // Se muestra el error si en ingresan una funcion invalida
                        errores.Text = error;
                        errores.Visible = true;
                    }
                }
                //Esta condicional funciona igual que la anterior
                if (comboBox2.Text == "y-y1=m(x-x1)")
                {
                    int posicionIgual = rectaDos.IndexOf("=");
                    int posicionX = rectaDos.IndexOf("x");
                    int posicionY = rectaDos.IndexOf("y");
                    int posicionAbrPare = rectaDos.IndexOf("(");
                    int posicionCiePare = rectaDos.IndexOf(")");
                    if (posicionIgual != -1 && posicionX != -1 && posicionY != -1 && posicionAbrPare != -1 && posicionCiePare != -1 &&
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

                //En esta se valida si la opcion ingresada es y=mx+b
                if (comboBox1.Text == "y=mx+b")
                {
                    //Se crean variables con las posiciones de las cosas necesarias para la funcion
                    int posicionIgual = rectaUno.IndexOf("=");
                    int posicionY = rectaUno.IndexOf("y");
                    int posicionX = rectaUno.IndexOf("x");

                    //Se valida que la funcion tenga todos los componentes y en el orden correcto
                    if (posicionIgual != -1 && posicionY != -1 && posicionX != -1 && posicionY == posicionIgual - 1 && posicionX > posicionIgual)
                    {
                        //Se llama la funcion de la pendiente
                        pendienteUno = pendientePenInte(rectaUno, posicionX, posicionIgual);

                        //Se valida que la pendiente sea valida
                        if (pendienteUno != (float)Math.PI)
                        {
                            //Se llama la funcion del intercepto
                            interceptoUno = interceptoPenInte(rectaUno, posicionX);
                        }
                    }
                    else
                    {
                        //Mensaje de error por si se ingresa una funcion invalida
                        errores.Text = error;
                        errores.Visible = true;
                    }
                }
                // Este condicional funciona igual que el anterior
                if (comboBox2.Text == "y=mx+b")
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

                // Se valida que los datos de las pendientes e interceptos sean validos
                if (pendienteUno != (float)Math.PI && pendienteDos != (float)Math.PI && interceptoUno != (float)Math.PI && interceptoDos != (float)Math.PI)
                {
                    //Se valida si las pendientes son iguales
                    if (pendienteUno == pendienteDos)
                    {
                        //En tal caso que lo sean se mostrara que son paralelas
                        solucion.Text = "Las rectas son paralelas";
                        solucion.Visible = true;
                    }
                    else
                    {
                        //En caso de no serlo se buscara cual es el punto en comun de las funciones, despejando x
                        float interceptoX = (interceptoDos - interceptoUno) / (pendienteUno - pendienteDos);

                        //Y luego el valor de x remplzandolo en la funcion numero uno
                        float interceptoY = (pendienteUno * interceptoX) + interceptoUno;

                        // Se valida si las funciones son ortogonales
                        if (pendienteUno * pendienteDos == -1)
                        {
                            //Se le avisa al usuario que sus rectas son perpendiculares y se muestra el punto donde se cortan
                            solucion.Text = "Las rectas son ortogonales";
                            intercepto.Text = "Corte en el punto (" + interceptoX + "," + interceptoY + ")";
                            solucion.Visible = true;
                            intercepto.Visible = true;
                        }
                        else
                        {
                            // Si las funciones no son perpendiculares solo mostrar el intercepto de las dos rectas
                            intercepto.Text = "Corte en el punto (" + interceptoX + "," + interceptoY + ")";
                            intercepto.Visible = true;
                        }
                    }
                }
            }
            
        }

        //Se crea la funcion de pendiente para la funcion de pendiente intercepto (y=mx+b)
        public float pendientePenInte(String recta, int posicionX, int posicionIgual)
        {
            //Se crea una variable donde se genera el intervalo donde se encuantra la pendiente
            int intervalo = posicionX - posicionIgual - 1;

            // Si el intervalo es igual a 0 es porque la funcion tiene una forma y=x... Osea su pendiente es 1
            if (intervalo == 0)
            {
                return 1;
            }

            //Se la funcion llega hasta aca es porque no es 1 entoces pasa a darle su valor
            String pendienteString = recta.Substring(posicionIgual + 1, intervalo);
            float pendiente = 0;

            //Se valida que la pendiente no sean letras
            if (float.TryParse(pendienteString, out pendiente))
            {
                //Se retorna la pendiente
                return pendiente;
            }
            else
            {
                //Se muestra el error y se retorna PI como un caso de error
                errores.Text = error;
                errores.Visible = true;
                return (float)Math.PI;
            }
        }

        //Esta es la funcion intercepto para funciones y=mx+b
        public float interceptoPenInte(String recta, int posicionX)
        {
            //Se crea una variable con el largo de la funcion
            int largoFormula = recta.Length;

            //Si el tamaño de la funcion es igual a la posicion de X mas 1 es porque no hay un valor despues de la x
            //osea el intercepto es 0
            if (largoFormula == posicionX + 1)
            {
                return 0;
            }
            //Se crea una variable tipo String para el intercepto que son todos los datos despues de la X
            String interceptoString = recta.Substring(posicionX+1);
            float intercepto = 0;

            //Se valida que si sea un numero
            if (float.TryParse(interceptoString, out intercepto))
            {
                //Si lo es se retorna como el intercepto
                return intercepto;
            }
            else
            {
                //Sino se le muestra al usuario el error y se retorna PI como caso de error
                errores.Text = error;
                errores.Visible = true;
                return (float)Math.PI;
            }

        }

        //Esta es la funcion de la pendiente para la foma punto pendiente
        public float pendientePunPend(String recta, int posicionIgual, int posicionParen)
        {
            //Primero se crea la variable donde se almacena el intervalo donde va la pendiente
            int intervalo = posicionParen - posicionIgual - 1;

            //Si el intervalo es 0 es porque la pendiente es 1
            if (intervalo == 0)
            {
                //Se retorna 1
                return 1;
            }

            //Se crea una variable tipo String para almacenar la pendiente
            String pendienteString = recta.Substring(posicionIgual + 1, intervalo);
            float pendiente = 0;

            //Se intenta cambiar el tipo de dato a float
            if (float.TryParse(pendienteString, out pendiente))
            {
                //se retorna si el dato ingresado es un numero
                return pendiente;
            }
            else
            {
                //De lo contrario se muestra el error y se retorna PI como caso de error
                errores.Text = error;
                errores.Visible = true;
                return (float)Math.PI;
            }
        }

        // Y por ultimo la funcion para saber el intercepto de la formal punto pendiente
        public float interceptoPunPend(String recta, int posicionIgual, int posicionX, int posicionY,
            int posicionCieParen, float pendiente)
        {
            //Se incializan las variables que se van a usar
            float x = 0;
            float y = 0;

            //Se crean los intervalos de los numeros que necesitamos
            int intervaloYIgual = posicionIgual - posicionY - 1;
            int intervaloXParen = posicionCieParen - posicionX - 1;

            // Si este intervalo nos da 0 es porque no hay nada entre la "y" y el igual
            if (intervaloYIgual == 0)
            {
                y = 0;
            }
            else
            {
                //Aca se crea una variable para poder guardar la "y" de la funcion
                String yString = recta.Substring(posicionY + 1, intervaloYIgual);

                //Luego se valida y se intenta cambiar a flotante
                if (!(float.TryParse(yString,out y)))
                {
                    //Si entra aca es porque hay letras entonces mostrara el error y retornara PI
                    errores.Text = error;
                    errores.Visible = true;
                    return (float)Math.PI;
                }
            }

            // Se valida si el intervalo entre la x y el parentesis es 0
            if (intervaloXParen == 0)
            {
                //Si lo es porque la "x" es igual a 0 osea no hay ninguno numero
                x = 0;
            }
            else
            {
                //Y si no lo es se crea una variable para almanarce la x
                String xString = recta.Substring(posicionX + 1, intervaloXParen);

                //Se intenta cambiar el tipo de dato a flotante
                if (!(float.TryParse(xString, out x)))
                {
                    //Si no deja es salta error y se retorna PI
                    errores.Text = error;
                    errores.Visible = true;
                    return (float)Math.PI;
                }
            }
            //Se retorna el intercepto de la funcion
            return ((-1 * x * pendiente) - y);
        }
    }
}
