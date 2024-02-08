﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class While : Form
    {
        //constructor
        public While()
        {
            InitializeComponent();
        }
        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
            //MessageBox.Show("Estas seguro de salir?");
        }
        private void btejecutar_Click(object sender, EventArgs e)
        {
            Form frmDoWhile = new DoWhile();
            frmDoWhile.ShowDialog();

            MessageBox.Show("Cerraste el formulario y no terminaste tu tarea !!");
        }
        private void btnRojo_Click(object sender, EventArgs e)
        {
            //declaración de variables 
            //Rectangulo Rojo
            int anchoFormulario = 0;
            int ancholabel = 0;
            int anchoBorde = 580;
            int X = 0;
            int paso = 2;

            //variables inicializadas
            anchoFormulario = this.Width;
            ancholabel = lblRojo.Width;
            X = 0;

            //evento click de botón
            btnRojo.BackColor = Color.Blue;

            //for (int incremento = 0; incremento < anchoFormulario - ancholabel - anchoBorde; incremento++)
            //{
            //    lblcuadrado.Left = incremento;
            //    this.Refresh();
            //} 

            //estructura de while(Mientras)
            while (X < anchoFormulario - ancholabel - anchoBorde)
            {
                lblRojo.Left = X;
                X = X + paso;
                this.Refresh();
            }

            MessageBox.Show("Soy un cuadrado rojo y he llegado bien..");
        }
        private void btnAzul_Click(object sender, EventArgs e)
        {

            //declaracion e inicializacion de variables
            int anchoForm = 0;
            int anchoLbl = 0;
            int anchoBrd = 320;
            int Eje_x = 0;
            int paso = 2;

            anchoForm = this.Width;
            anchoLbl = lbAzul.Width;
            Eje_x = 0;


            btnAzul.BackColor = Color.Red;

            while (Eje_x < anchoForm - anchoLbl - anchoBrd)
            {
                lbAzul.Left = Eje_x;
                Eje_x = Eje_x + paso;
                this.Refresh();

            }

            MessageBox.Show("Soy un cuadrado azul y he llegado bien..");

        }

        private void lblRojo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No me toques");
        }

        private void lbAzul_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A mi.. tampoco me toques !!");
        }
    }
}










               




      
