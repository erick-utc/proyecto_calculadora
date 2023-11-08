using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora
{
    public partial class Calculadora : System.Web.UI.Page
    {
           
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void agregarNumero(string numero)
        {
            if (txtNumero1.Text == "0")
                txtNumero1.Text = "";
            txtNumero1.Text += numero;


        }


        protected void btnSuma_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Equals(String.Empty)) return;
            if (!Global.operacionActiva)
            {
                Global.num1 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                Global.operacionActual = Operaciones.SUMA;
                lblResultado.Text = Global.num1.ToString() + Operaciones.SUMA;
             //   Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
             //   txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = true;

            }
            else
            {
                Global.num2 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                lblResultado.Text = lblResultado.Text + Global.num2.ToString() + "=";
                Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = false;
            }
        }

        protected void btnCero_Click(object sender, EventArgs e)
        {

            var boton = ((Button)sender);
            agregarNumero(boton.Text);

        }

        protected void btnUno_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnDos_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnTres_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnCuatro_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnCinco_Click(object sender, EventArgs e)
        {

            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnSeis_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnSiete_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnOcho_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnNueve_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void bntDelete_Click(object sender, EventArgs e)
        {
            StringBuilder operacion = new StringBuilder(lblResultado.Text);
            if (operacion.Length > 0)
            {
                // Borra el último carácter del StringBuilder
                operacion.Remove(operacion.Length - 1, 1);

                // Actualiza el texto del TextBox y del Label con el StringBuilder modificado
               
                lblResultado.Text = operacion.ToString();
            }
          }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "0";
            lblResultado.Text = "0";
        }

        protected void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtNumero1.Text.Contains("."))
            {
                txtNumero1.Text += ".";



            }
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            if (!Global.operacionActiva)
            {
                lblResultado.Text = txtNumero1.Text;
                txtNumero1.Text = String.Empty;
                Global.operacionActiva = false;
            }else 
            {
                //verifica si input esta vacio y pone cero
                if(txtNumero1.Text.Equals(String.Empty))
                {
                    Global.num2 = 0 ;
                }
                else
                {
                    Global.num2 = float.Parse(txtNumero1.Text);
                }
                
                txtNumero1.Text = String.Empty;
                lblResultado.Text = lblResultado.Text + Global.num2.ToString() + "=";
                Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = false;
            }
        }

        protected void btnPow2_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Equals(String.Empty)) return;
            if (!Global.operacionActiva)
            {
                Global.num1 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                Global.operacionActual = Operaciones.POW2;
                lblResultado.Text = Global.num1.ToString() + Operaciones.POW2 + '=';
                Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = false;

            }
            else
            {
                Global.num2 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                lblResultado.Text = lblResultado.Text + Global.num2.ToString() + "=";
                Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = false;
            }
        }

        protected void btnLog_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Equals(String.Empty)) return;
            if (!Global.operacionActiva)
            {
                Global.num1 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                Global.operacionActual = Operaciones.LOG;
                lblResultado.Text = Operaciones.LOG + Global.num1.ToString() + '=';
                Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = false;

            }
            else
            {
                Global.num2 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                lblResultado.Text = lblResultado.Text + Global.num2.ToString() + "=";
                Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = false;
            }
        }

        protected void btnPow10_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Equals(String.Empty)) return;
            if (!Global.operacionActiva)
            {
                Global.num1 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                Global.operacionActual = Operaciones.POW10;
                lblResultado.Text = Operaciones.POW10 + Global.num1.ToString() + '=';
                Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = false;

            }
            else
            {
                Global.num2 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                lblResultado.Text = lblResultado.Text + Global.num2.ToString() + "=";
                Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = false;
            }
        }

        protected void btnFactorial_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Equals(String.Empty)) return;
            if (!Global.operacionActiva)
            {
                Global.num1 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                Global.operacionActual = Operaciones.FACTORIAL;
                lblResultado.Text = Global.num1.ToString() + Operaciones.FACTORIAL + '=';
                Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = false;

            }
            else
            {
                Global.num2 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                lblResultado.Text = lblResultado.Text + Global.num2.ToString() + "=";
                Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = false;
            }
        }

        protected void btnInverse_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Equals(String.Empty)) return;
            if (!Global.operacionActiva)
            {
                Global.num1 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                Global.operacionActual = Operaciones.INVERSO;
                lblResultado.Text = Operaciones.INVERSO + Global.num1.ToString() + '=';
                Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = false;

            }
            else
            {
                Global.num2 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                lblResultado.Text = lblResultado.Text + Global.num2.ToString() + "=";
                Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = false;
            }
        }

        protected void btnSqrt_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Equals(String.Empty)) return;
            if (!Global.operacionActiva)
            {
                Global.num1 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                Global.operacionActual = Operaciones.SQRT;
                lblResultado.Text = Operaciones.SQRT + Global.num1.ToString() + '=';
                Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = false;

            }
            else
            {
                Global.num2 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                lblResultado.Text = lblResultado.Text + Global.num2.ToString() + "=";
                Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = false;
            }
        }

        protected void btnResta_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Equals(String.Empty)) return;
            if (!Global.operacionActiva)
            {
                Global.num1 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                Global.operacionActual = Operaciones.RESTA;
                lblResultado.Text = Global.num1.ToString() + Operaciones.RESTA;
                //   Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                //   txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = true;

            }
            else
            {
                Global.num2 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                lblResultado.Text = lblResultado.Text + Global.num2.ToString() + "=";
                Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = false;
            }
        }

        protected void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Equals(String.Empty)) return;
            if (!Global.operacionActiva)
            {
                Global.num1 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                Global.operacionActual = Operaciones.MULTIPLICACION;
                lblResultado.Text = Global.num1.ToString() + Operaciones.MULTIPLICACION;
                //   Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                //   txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = true;

            }
            else
            {
                Global.num2 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                lblResultado.Text = lblResultado.Text + Global.num2.ToString() + "=";
                Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = false;
            }
        }

        protected void btnDivision_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Equals(String.Empty)) return;
            if (!Global.operacionActiva)
            {
                Global.num1 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                Global.operacionActual = Operaciones.DIVISION;
                lblResultado.Text = Global.num1.ToString() + Operaciones.DIVISION;
                //   Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                //   txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = true;

            }
            else
            {
                Global.num2 = float.Parse(txtNumero1.Text);
                txtNumero1.Text = String.Empty;
                lblResultado.Text = lblResultado.Text + Global.num2.ToString() + "=";
                Global.resultado = Operaciones.seleccionarOperacion(Global.operacionActual);
                txtNumero1.Text = Global.resultado.ToString();
                Global.operacionActiva = false;
            }
        }

        protected void btnpow_Click(object sender, EventArgs e)
        {

            double baseNumber = Convert.ToDouble(txtNumero1.Text);
            double exponente = Convert.ToDouble(txtNumero1.Text);

            // Calcular x^y
            double resultado = Math.Pow(baseNumber, exponente);

            // Mostrar el resultado en un TextBox o Label
            txtNumero1.Text = resultado.ToString();





        }
    }
}