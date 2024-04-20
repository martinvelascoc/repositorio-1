namespace Project_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bcomando = new Button();
            SuspendLayout();
            // 
            // Bcomando
            // 
            Bcomando.ImageAlign = ContentAlignment.TopLeft;
            Bcomando.Location = new Point(12, 12);
            Bcomando.Name = "Bcomando";
            Bcomando.Size = new Size(213, 75);
            Bcomando.TabIndex = 0;
            Bcomando.Text = "boton-comando";
            Bcomando.UseVisualStyleBackColor = true;
            Bcomando.Click += Bcomando_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 216);
            Controls.Add(Bcomando);
            Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Formulario";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Bcomando;
    }
}