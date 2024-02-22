﻿namespace VegaJuego
{
    partial class PantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            checkSonido = new CheckBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.LogoBueno;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 205);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.ZeldaLogo;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(517, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(202, 91);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // checkSonido
            // 
            checkSonido.AutoSize = true;
            checkSonido.BackColor = Color.Transparent;
            checkSonido.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkSonido.Location = new Point(517, 198);
            checkSonido.Name = "checkSonido";
            checkSonido.Size = new Size(120, 21);
            checkSonido.TabIndex = 2;
            checkSonido.Text = "Sonido On/Off";
            checkSonido.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(517, 54);
            label1.Name = "label1";
            label1.Size = new Size(211, 17);
            label1.TabIndex = 3;
            label1.Text = "Creado por Ángel Pérez Mengual";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.BackgroundImage = Properties.Resources.Boton;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(361, 343);
            button1.Name = "button1";
            button1.Size = new Size(276, 48);
            button1.TabIndex = 4;
            button1.Text = "Comienza la aventura";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PantallaInicio
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.FondoPantalla;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(806, 467);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(checkSonido);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PantallaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaInicio";
            FormClosed += PantallaInicio_FromClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox checkSonido;
        private Label label1;
        private Button button1;
    }
}