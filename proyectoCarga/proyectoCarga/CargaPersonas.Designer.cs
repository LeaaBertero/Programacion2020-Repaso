﻿namespace proyectoCarga
{
    partial class CargaPersonas
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
            btsalir = new Button();
            txNombre = new TextBox();
            btcargar = new Button();
            btmostrar = new Button();
            lbres = new Label();
            txañoNacimiento = new TextBox();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(694, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 0;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(177, 99);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(125, 27);
            txNombre.TabIndex = 1;
            // 
            // btcargar
            // 
            btcargar.Cursor = Cursors.Hand;
            btcargar.Location = new Point(33, 99);
            btcargar.Name = "btcargar";
            btcargar.Size = new Size(94, 29);
            btcargar.TabIndex = 2;
            btcargar.Text = "cargar";
            btcargar.UseVisualStyleBackColor = true;
            btcargar.Click += btcargar_Click;
            // 
            // btmostrar
            // 
            btmostrar.Cursor = Cursors.Hand;
            btmostrar.Location = new Point(33, 154);
            btmostrar.Name = "btmostrar";
            btmostrar.Size = new Size(94, 29);
            btmostrar.TabIndex = 3;
            btmostrar.Text = "Mostrar";
            btmostrar.UseVisualStyleBackColor = true;
            btmostrar.Click += btmostrar_Click;
            // 
            // lbres
            // 
            lbres.AutoSize = true;
            lbres.Location = new Point(252, 158);
            lbres.Name = "lbres";
            lbres.Size = new Size(50, 20);
            lbres.TabIndex = 4;
            lbres.Text = "label1";
            // 
            // txañoNacimiento
            // 
            txañoNacimiento.Location = new Point(361, 99);
            txañoNacimiento.Name = "txañoNacimiento";
            txañoNacimiento.Size = new Size(125, 27);
            txañoNacimiento.TabIndex = 5;
            // 
            // CargaPersonas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(txañoNacimiento);
            Controls.Add(lbres);
            Controls.Add(btmostrar);
            Controls.Add(btcargar);
            Controls.Add(txNombre);
            Controls.Add(btsalir);
            Name = "CargaPersonas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CargaPersonas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private TextBox txNombre;
        private Button btcargar;
        private Button btmostrar;
        private Label lbres;
        private TextBox txañoNacimiento;
    }
}