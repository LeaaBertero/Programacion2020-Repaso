﻿namespace operadores
{
    partial class operadores1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btcalcular = new Button();
            laresultado = new Label();
            txnum1 = new TextBox();
            txnum2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btsalir = new Button();
            label1 = new Label();
            btincremento = new Button();
            lbincremento = new Label();
            label5 = new Label();
            btDecrementar = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Txres2 = new TextBox();
            Txres1 = new TextBox();
            LbresResta = new Label();
            btcalcResta = new Button();
            SuspendLayout();
            // 
            // btcalcular
            // 
            btcalcular.Cursor = Cursors.Hand;
            btcalcular.Location = new Point(571, 190);
            btcalcular.Name = "btcalcular";
            btcalcular.Size = new Size(94, 29);
            btcalcular.TabIndex = 3;
            btcalcular.Text = "calcular";
            btcalcular.UseVisualStyleBackColor = true;
            btcalcular.Click += btcalcular_Click;
            // 
            // laresultado
            // 
            laresultado.AutoSize = true;
            laresultado.Location = new Point(727, 194);
            laresultado.Name = "laresultado";
            laresultado.Size = new Size(50, 20);
            laresultado.TabIndex = 1;
            laresultado.Text = "label1";
            laresultado.Visible = false;
            // 
            // txnum1
            // 
            txnum1.Location = new Point(202, 188);
            txnum1.Name = "txnum1";
            txnum1.Size = new Size(125, 27);
            txnum1.TabIndex = 1;
            // 
            // txnum2
            // 
            txnum2.Location = new Point(394, 188);
            txnum2.Name = "txnum2";
            txnum2.Size = new Size(125, 27);
            txnum2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(345, 185);
            label2.Name = "label2";
            label2.Size = new Size(31, 32);
            label2.TabIndex = 4;
            label2.Text = "+";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(202, 136);
            label3.Name = "label3";
            label3.Size = new Size(125, 32);
            label3.TabIndex = 5;
            label3.Text = "numero 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(394, 136);
            label4.Name = "label4";
            label4.Size = new Size(125, 32);
            label4.TabIndex = 6;
            label4.Text = "numero 2";
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(868, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 7;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(79, 64);
            label1.Name = "label1";
            label1.Size = new Size(790, 32);
            label1.TabIndex = 8;
            label1.Text = "Ejercicio de prueba de conversion de variables con método incluido";
            // 
            // btincremento
            // 
            btincremento.Location = new Point(296, 562);
            btincremento.Name = "btincremento";
            btincremento.Size = new Size(106, 29);
            btincremento.TabIndex = 9;
            btincremento.Text = "incrementar";
            btincremento.UseVisualStyleBackColor = true;
            btincremento.Click += btincremento_Click;
            // 
            // lbincremento
            // 
            lbincremento.Font = new Font("Segoe UI", 10F);
            lbincremento.ForeColor = Color.Black;
            lbincremento.Location = new Point(524, 564);
            lbincremento.Name = "lbincremento";
            lbincremento.Size = new Size(55, 23);
            lbincremento.TabIndex = 10;
            lbincremento.Text = "label5";
            lbincremento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(296, 507);
            label5.Name = "label5";
            label5.Size = new Size(283, 32);
            label5.TabIndex = 11;
            label5.Text = "Ejercicio de incremento";
            // 
            // btDecrementar
            // 
            btDecrementar.Location = new Point(296, 635);
            btDecrementar.Name = "btDecrementar";
            btDecrementar.Size = new Size(106, 29);
            btDecrementar.TabIndex = 12;
            btDecrementar.Text = "Decrementar";
            btDecrementar.UseVisualStyleBackColor = true;
            btDecrementar.Click += btDecrementar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(394, 280);
            label6.Name = "label6";
            label6.Size = new Size(125, 32);
            label6.TabIndex = 19;
            label6.Text = "numero 2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(202, 280);
            label7.Name = "label7";
            label7.Size = new Size(125, 32);
            label7.TabIndex = 18;
            label7.Text = "numero 1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.Location = new Point(345, 329);
            label8.Name = "label8";
            label8.Size = new Size(24, 32);
            label8.TabIndex = 17;
            label8.Text = "-";
            // 
            // Txres2
            // 
            Txres2.Location = new Point(394, 332);
            Txres2.Name = "Txres2";
            Txres2.Size = new Size(125, 27);
            Txres2.TabIndex = 15;
            // 
            // Txres1
            // 
            Txres1.Location = new Point(202, 332);
            Txres1.Name = "Txres1";
            Txres1.Size = new Size(125, 27);
            Txres1.TabIndex = 13;
            // 
            // LbresResta
            // 
            LbresResta.AutoSize = true;
            LbresResta.Location = new Point(727, 338);
            LbresResta.Name = "LbresResta";
            LbresResta.Size = new Size(50, 20);
            LbresResta.TabIndex = 14;
            LbresResta.Text = "label1";
            LbresResta.Visible = false;
            // 
            // btcalcResta
            // 
            btcalcResta.Cursor = Cursors.Hand;
            btcalcResta.Location = new Point(571, 334);
            btcalcResta.Name = "btcalcResta";
            btcalcResta.Size = new Size(94, 29);
            btcalcResta.TabIndex = 16;
            btcalcResta.Text = "calcular";
            btcalcResta.UseVisualStyleBackColor = true;
            btcalcResta.Click += btcalcResta_Click;
            // 
            // operadores1
            // 
            AcceptButton = btcalcular;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chartreuse;
            ClientSize = new Size(974, 707);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(Txres2);
            Controls.Add(Txres1);
            Controls.Add(LbresResta);
            Controls.Add(btcalcResta);
            Controls.Add(btDecrementar);
            Controls.Add(label5);
            Controls.Add(lbincremento);
            Controls.Add(btincremento);
            Controls.Add(label1);
            Controls.Add(btsalir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txnum2);
            Controls.Add(txnum1);
            Controls.Add(laresultado);
            Controls.Add(btcalcular);
            Name = "operadores1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "operadores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcalcular;
        private Label laresultado;
        private TextBox txnum1;
        private TextBox txnum2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btsalir;
        private Label label1;
        private Button btincremento;
        private Label lbincremento;
        private Label label5;
        private Button btDecrementar;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox Txres2;
        private TextBox Txres1;
        private Label LbresResta;
        private Button btcalcResta;
    }
}