namespace CalculadoraPrototipo
{
    partial class Calculadora
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
            this.etPantalla = new System.Windows.Forms.Label();
            this.btnDigito0 = new System.Windows.Forms.Button();
            this.btnComaDec = new System.Windows.Forms.Button();
            this.btnDigito1 = new System.Windows.Forms.Button();
            this.btnDigito2 = new System.Windows.Forms.Button();
            this.btnDigito3 = new System.Windows.Forms.Button();
            this.btnDigito6 = new System.Windows.Forms.Button();
            this.btnDigito5 = new System.Windows.Forms.Button();
            this.btnDigito4 = new System.Windows.Forms.Button();
            this.btnDigito9 = new System.Windows.Forms.Button();
            this.btnDigito8 = new System.Windows.Forms.Button();
            this.btnDigito7 = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnPor = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnBorrarEntrada = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnPorCiento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etPantalla
            // 
            this.etPantalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.etPantalla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.etPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etPantalla.Location = new System.Drawing.Point(10, 19);
            this.etPantalla.Name = "etPantalla";
            this.etPantalla.Size = new System.Drawing.Size(254, 34);
            this.etPantalla.TabIndex = 0;
            this.etPantalla.Text = "0,";
            this.etPantalla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDigito0
            // 
            this.btnDigito0.Location = new System.Drawing.Point(10, 209);
            this.btnDigito0.Name = "btnDigito0";
            this.btnDigito0.Size = new System.Drawing.Size(86, 40);
            this.btnDigito0.TabIndex = 1;
            this.btnDigito0.Text = "0";
            this.btnDigito0.UseVisualStyleBackColor = true;
            this.btnDigito0.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btnComaDec
            // 
            this.btnComaDec.Location = new System.Drawing.Point(102, 209);
            this.btnComaDec.Name = "btnComaDec";
            this.btnComaDec.Size = new System.Drawing.Size(40, 40);
            this.btnComaDec.TabIndex = 2;
            this.btnComaDec.Text = ".";
            this.btnComaDec.UseVisualStyleBackColor = true;
            this.btnComaDec.Click += new System.EventHandler(this.btnComaDec_Click);
            // 
            // btnDigito1
            // 
            this.btnDigito1.Location = new System.Drawing.Point(10, 163);
            this.btnDigito1.Name = "btnDigito1";
            this.btnDigito1.Size = new System.Drawing.Size(40, 40);
            this.btnDigito1.TabIndex = 3;
            this.btnDigito1.Text = "1";
            this.btnDigito1.UseVisualStyleBackColor = true;
            this.btnDigito1.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btnDigito2
            // 
            this.btnDigito2.Location = new System.Drawing.Point(56, 163);
            this.btnDigito2.Name = "btnDigito2";
            this.btnDigito2.Size = new System.Drawing.Size(40, 40);
            this.btnDigito2.TabIndex = 4;
            this.btnDigito2.Text = "2";
            this.btnDigito2.UseVisualStyleBackColor = true;
            this.btnDigito2.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btnDigito3
            // 
            this.btnDigito3.Location = new System.Drawing.Point(102, 163);
            this.btnDigito3.Name = "btnDigito3";
            this.btnDigito3.Size = new System.Drawing.Size(40, 40);
            this.btnDigito3.TabIndex = 5;
            this.btnDigito3.Text = "3";
            this.btnDigito3.UseVisualStyleBackColor = true;
            this.btnDigito3.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btnDigito6
            // 
            this.btnDigito6.Location = new System.Drawing.Point(102, 117);
            this.btnDigito6.Name = "btnDigito6";
            this.btnDigito6.Size = new System.Drawing.Size(40, 40);
            this.btnDigito6.TabIndex = 8;
            this.btnDigito6.Text = "6";
            this.btnDigito6.UseVisualStyleBackColor = true;
            this.btnDigito6.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btnDigito5
            // 
            this.btnDigito5.Location = new System.Drawing.Point(56, 117);
            this.btnDigito5.Name = "btnDigito5";
            this.btnDigito5.Size = new System.Drawing.Size(40, 40);
            this.btnDigito5.TabIndex = 7;
            this.btnDigito5.Text = "5";
            this.btnDigito5.UseVisualStyleBackColor = true;
            this.btnDigito5.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btnDigito4
            // 
            this.btnDigito4.Location = new System.Drawing.Point(10, 117);
            this.btnDigito4.Name = "btnDigito4";
            this.btnDigito4.Size = new System.Drawing.Size(40, 40);
            this.btnDigito4.TabIndex = 6;
            this.btnDigito4.Text = "4";
            this.btnDigito4.UseVisualStyleBackColor = true;
            this.btnDigito4.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btnDigito9
            // 
            this.btnDigito9.Location = new System.Drawing.Point(102, 71);
            this.btnDigito9.Name = "btnDigito9";
            this.btnDigito9.Size = new System.Drawing.Size(40, 40);
            this.btnDigito9.TabIndex = 11;
            this.btnDigito9.Text = "9";
            this.btnDigito9.UseVisualStyleBackColor = true;
            this.btnDigito9.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btnDigito8
            // 
            this.btnDigito8.Location = new System.Drawing.Point(56, 71);
            this.btnDigito8.Name = "btnDigito8";
            this.btnDigito8.Size = new System.Drawing.Size(40, 40);
            this.btnDigito8.TabIndex = 10;
            this.btnDigito8.Text = "8";
            this.btnDigito8.UseVisualStyleBackColor = true;
            this.btnDigito8.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btnDigito7
            // 
            this.btnDigito7.Location = new System.Drawing.Point(10, 71);
            this.btnDigito7.Name = "btnDigito7";
            this.btnDigito7.Size = new System.Drawing.Size(40, 40);
            this.btnDigito7.TabIndex = 9;
            this.btnDigito7.Text = "7";
            this.btnDigito7.UseVisualStyleBackColor = true;
            this.btnDigito7.Click += new System.EventHandler(this.btDigito_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(178, 71);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(40, 40);
            this.btnIniciar.TabIndex = 15;
            this.btnIniciar.Text = "C";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(178, 117);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(40, 40);
            this.btnDividir.TabIndex = 14;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btOperacion_Click);
            // 
            // btnPor
            // 
            this.btnPor.Location = new System.Drawing.Point(178, 163);
            this.btnPor.Name = "btnPor";
            this.btnPor.Size = new System.Drawing.Size(40, 40);
            this.btnPor.TabIndex = 13;
            this.btnPor.Text = "x";
            this.btnPor.UseVisualStyleBackColor = true;
            this.btnPor.Click += new System.EventHandler(this.btOperacion_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(178, 209);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(40, 40);
            this.btnIgual.TabIndex = 12;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btOperacion_Click);
            // 
            // btnBorrarEntrada
            // 
            this.btnBorrarEntrada.Location = new System.Drawing.Point(224, 71);
            this.btnBorrarEntrada.Name = "btnBorrarEntrada";
            this.btnBorrarEntrada.Size = new System.Drawing.Size(40, 40);
            this.btnBorrarEntrada.TabIndex = 19;
            this.btnBorrarEntrada.Text = "CE";
            this.btnBorrarEntrada.UseVisualStyleBackColor = true;
            this.btnBorrarEntrada.Click += new System.EventHandler(this.btnBorrarEntrada_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(224, 117);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(40, 40);
            this.btnMenos.TabIndex = 18;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btOperacion_Click);
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(224, 163);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(40, 40);
            this.btnMas.TabIndex = 17;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btOperacion_Click);
            // 
            // btnPorCiento
            // 
            this.btnPorCiento.Location = new System.Drawing.Point(224, 209);
            this.btnPorCiento.Name = "btnPorCiento";
            this.btnPorCiento.Size = new System.Drawing.Size(40, 40);
            this.btnPorCiento.TabIndex = 16;
            this.btnPorCiento.Text = "%";
            this.btnPorCiento.UseVisualStyleBackColor = true;
            this.btnPorCiento.Click += new System.EventHandler(this.btTantoPorciento_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 261);
            this.Controls.Add(this.btnBorrarEntrada);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.btnPorCiento);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnPor);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnDigito9);
            this.Controls.Add(this.btnDigito8);
            this.Controls.Add(this.btnDigito7);
            this.Controls.Add(this.btnDigito6);
            this.Controls.Add(this.btnDigito5);
            this.Controls.Add(this.btnDigito4);
            this.Controls.Add(this.btnDigito3);
            this.Controls.Add(this.btnDigito2);
            this.Controls.Add(this.btnDigito1);
            this.Controls.Add(this.btnComaDec);
            this.Controls.Add(this.btnDigito0);
            this.Controls.Add(this.etPantalla);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label etPantalla;
        private System.Windows.Forms.Button btnDigito0;
        private System.Windows.Forms.Button btnComaDec;
        private System.Windows.Forms.Button btnDigito1;
        private System.Windows.Forms.Button btnDigito2;
        private System.Windows.Forms.Button btnDigito3;
        private System.Windows.Forms.Button btnDigito6;
        private System.Windows.Forms.Button btnDigito5;
        private System.Windows.Forms.Button btnDigito4;
        private System.Windows.Forms.Button btnDigito9;
        private System.Windows.Forms.Button btnDigito8;
        private System.Windows.Forms.Button btnDigito7;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnPor;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnBorrarEntrada;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnPorCiento;
    }
}

