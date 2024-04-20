using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPrototipo
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            ultimaEntrada = Entrada.NINGUNA;
            comaDecimal = false;
            
            operador = '\0'; //INICIAR LA VARIABLE A NULO
            num0perandos = 0;
            operando1 = 0;
            operando2 = 0;
        }

        private enum Entrada
        {
            NINGUNA,
            DIGITO,
            OPERADOR,
            CE
        }
        private Entrada ultimaEntrada;
        private bool comaDecimal;
        private char operador;
        private byte num0perandos;
        private double operando1;
        private double operando2;


        private void btDigito_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
           
            if(ultimaEntrada != Entrada.DIGITO)
            {
                if (objButton.Text == "0") return;
                etPantalla.Text = "";
                ultimaEntrada = Entrada.DIGITO;
                comaDecimal = false;
            }

            etPantalla.Text += objButton.Text;
        }

        private void btnComaDec_Click(object sender, EventArgs e)
        {
            if (ultimaEntrada != Entrada.DIGITO)
            {
                etPantalla.Text = "0,";
                ultimaEntrada = Entrada.DIGITO;
            }
            else if (comaDecimal == false)
                etPantalla.Text = etPantalla.Text + ",";

            comaDecimal = true;
        }

        private void btOperacion_Click(object sender, EventArgs e)
        {
            // Obtener el ID del boton que genero el evento
            Button objButton = (Button)sender;
            // Texto del boton pulsado
            string textoBoton = objButton.Text;

            if ((num0perandos == 0) && (textoBoton[0] == '-'))
                    ultimaEntrada = Entrada.DIGITO;

            if (ultimaEntrada == Entrada.DIGITO)
                num0perandos += 1;

            if (num0perandos == 1)
                operando1 = double.Parse(etPantalla.Text);
            else if (num0perandos == 2)
            {
                operando2 = double.Parse(etPantalla.Text);

                switch (operador)
                {
                    case '+':
                        operando1 += operando2;
                        break;
                    case '-':
                        operando1 -= operando2;
                        break;
                    case 'x':
                        operando1 *= operando2;
                        break;
                    case '/':
                        operando1 /= operando2;
                        break;
                    case '=':
                        operando1 = operando2;
                        break;
                }

                //Visualizamos el resultado
                etPantalla.Text = operando1.ToString();
                num0perandos = 1;

            }
            operador = textoBoton[0]; // caracter de la posicion 0
            ultimaEntrada = Entrada.OPERADOR;
        }

        private void btTantoPorciento_Click(object sender, EventArgs e)
        {
            double resultado;
            if(ultimaEntrada == Entrada.DIGITO)
            {
                resultado = operando1 * double.Parse(etPantalla.Text) / 100;
                //Visualizar el resultado
                etPantalla.Text = resultado.ToString();
                // Simular que se ha hecho click en = 
                btnIgual.PerformClick();
                // Enfocar la tecla %
                btnPorCiento.Focus();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            etPantalla.Text = "0,";
            ultimaEntrada = Entrada.NINGUNA;
            comaDecimal = false;
            operador = '\0';
            num0perandos = 0;
            operando1 = 0;
            operando2 = 0;
        }

        private void btnBorrarEntrada_Click(object sender, EventArgs e)
        {
            etPantalla.Text = "0,";
            ultimaEntrada = Entrada.CE;
            comaDecimal = false;
        }
    }
}
