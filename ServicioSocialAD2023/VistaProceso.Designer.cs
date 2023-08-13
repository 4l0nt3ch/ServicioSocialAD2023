namespace uanl_ss_main_ui
{
    partial class VistaProceso
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
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(10, 217);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(496, 20);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 46);
            label1.Name = "label1";
            label1.Size = new Size(74, 13);
            label1.TabIndex = 1;
            label1.Text = "Programa SS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 71);
            label2.Name = "label2";
            label2.Size = new Size(61, 13);
            label2.TabIndex = 2;
            label2.Text = "Estudiante";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 96);
            label3.Name = "label3";
            label3.Size = new Size(69, 13);
            label3.TabIndex = 3;
            label3.Text = "Coordinador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 124);
            label4.Name = "label4";
            label4.Size = new Size(0, 13);
            label4.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(105, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 21);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(105, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(403, 21);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(105, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(403, 21);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 192);
            label5.Name = "label5";
            label5.Size = new Size(50, 13);
            label5.TabIndex = 8;
            label5.Text = "Registro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 192);
            label6.Name = "label6";
            label6.Size = new Size(87, 13);
            label6.TabIndex = 9;
            label6.Text = "0 de 0 registros";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(105, 119);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(403, 21);
            textBox4.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 121);
            label7.Name = "label7";
            label7.Size = new Size(71, 13);
            label7.TabIndex = 10;
            label7.Text = "Responsable";
            // 
            // VistaProceso
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 247);
            ControlBox = false;
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Font = new Font("Bahnschrift Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "VistaProceso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Procesando...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
    }
}