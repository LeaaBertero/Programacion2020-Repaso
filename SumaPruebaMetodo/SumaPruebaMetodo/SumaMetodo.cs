﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaPruebaMetodo
{
    public partial class SumaMetodo : Form
    {
        public SumaMetodo()
        {
            InitializeComponent();
        }

        private void btcalcular_Click(object sender, EventArgs e)
        {
            //int numero1;
            //int numero2;
            //int resultado;

            //numero1 = Convert.ToInt32(txoper1.Text);
            //numero2 = Convert.ToInt32(txoper2.Text);

            //resultado = numero1 + numero2;

            lbresultado.Text = "Restultado:" + " " + Convert.ToString(Suma());
            lbresultado.Visible = true;
        }

        private int Suma()
        {
            int numero1;
            int numero2;
            int resultado;

            numero1 = Convert.ToInt32(txoper1.Text);
            numero2 = Convert.ToInt32(txoper2.Text);    

            resultado = numero1 + numero2;

            return resultado;
        }
    }
}
