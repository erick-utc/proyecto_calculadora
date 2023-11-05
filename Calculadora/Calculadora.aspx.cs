using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("Suma");
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
            if (txtNumero1.Text.Length > 1)
            {
                txtNumero1.Text = txtNumero1.Text.Substring(0, txtNumero1.Text.Length - 1);




            }
            else
            {
                txtNumero1.Text = "0";



            }


        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "0";
        }

        protected void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtNumero1.Text.Contains("."))
            {
                txtNumero1.Text += ".";



            }
        }
    }
}