﻿namespace uanl_ss_main_ui
{
    partial class VistaDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaDepartamento));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(194, 14);
            label1.TabIndex = 0;
            label1.Text = "Indique los datos del departamento.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(18, 14);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(59, 14);
            label3.TabIndex = 2;
            label3.Text = "Programa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 125);
            label4.Name = "label4";
            label4.Size = new Size(50, 14);
            label4.TabIndex = 3;
            label4.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(371, 22);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(371, 22);
            textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(109, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(371, 22);
            comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Location = new Point(340, 161);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 7;
            button1.Text = "Continuar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Location = new Point(194, 161);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += BTExit;
            // 
            // VistaDepartamento
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 202);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VistaDepartamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle Departamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
    }
}