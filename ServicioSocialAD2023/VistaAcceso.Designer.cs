namespace uanl_ss_main_ui
{
    partial class VistaAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaAcceso));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 149);
            label1.Name = "label1";
            label1.Size = new Size(132, 13);
            label1.TabIndex = 0;
            label1.Text = "Correo Electrónico UANL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 185);
            label2.Name = "label2";
            label2.Size = new Size(47, 13);
            label2.TabIndex = 1;
            label2.Text = "Teléfono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 67);
            label3.Name = "label3";
            label3.Size = new Size(636, 52);
            label3.TabIndex = 2;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 223);
            label4.Name = "label4";
            label4.Size = new Size(65, 13);
            label4.TabIndex = 3;
            label4.Text = "Contraseña";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(393, 21);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(202, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(393, 21);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(202, 220);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(393, 21);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Light", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 19);
            label5.Name = "label5";
            label5.Size = new Size(264, 35);
            label5.TabIndex = 7;
            label5.Text = "Solicitud de acceso";
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(360, 287);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(506, 287);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 9;
            button1.Text = "Continuar";
            button1.UseVisualStyleBackColor = false;
            // 
            // VistaAcceso
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(662, 328);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Bahnschrift Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VistaAcceso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Requerir acceso";
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
        private TextBox textBox3;
        private Label label5;
        private Button button2;
        private Button button1;
    }
}