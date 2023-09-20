namespace uanl_ss_main_ui
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            panel2 = new Panel();
            button4 = new Button();
            label4 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            TBPassword = new TextBox();
            label2 = new Label();
            TBUser = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(TBPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TBUser);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(-11, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(908, 378);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(381, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(527, 375);
            panel2.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.Enabled = false;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(14, 321);
            button4.Name = "button4";
            button4.Size = new Size(491, 31);
            button4.TabIndex = 7;
            button4.Text = "Ver términos y condiciones de uso";
            button4.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gold;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(14, 168);
            label4.Name = "label4";
            label4.Size = new Size(517, 150);
            label4.TabIndex = 1;
            label4.Text = resources.GetString("label4.Text");
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Imagen1;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(14, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(285, 146);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(35, 34);
            label3.Name = "label3";
            label3.Size = new Size(300, 27);
            label3.TabIndex = 7;
            label3.Text = "Ingrese sus credenciales...";
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(35, 250);
            button3.Name = "button3";
            button3.Size = new Size(298, 31);
            button3.TabIndex = 6;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += BTExitAppEvent;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Enabled = false;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(35, 212);
            button2.Name = "button2";
            button2.Size = new Size(298, 31);
            button2.TabIndex = 5;
            button2.Text = "Solicitar Acceso";
            button2.UseVisualStyleBackColor = false;
            button2.Click += BtOpenRA;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(35, 175);
            button1.Name = "button1";
            button1.Size = new Size(298, 31);
            button1.TabIndex = 4;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnLoginEventClick;
            // 
            // TBPassword
            // 
            TBPassword.BackColor = Color.DimGray;
            TBPassword.ForeColor = Color.White;
            TBPassword.Location = new Point(35, 137);
            TBPassword.Name = "TBPassword";
            TBPassword.PasswordChar = 'X';
            TBPassword.Size = new Size(298, 21);
            TBPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(35, 119);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // TBUser
            // 
            TBUser.BackColor = Color.DimGray;
            TBUser.ForeColor = Color.White;
            TBUser.Location = new Point(35, 93);
            TBUser.Name = "TBUser";
            TBUser.Size = new Size(298, 21);
            TBUser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(35, 75);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = Properties.Resources.SL_043021_42650_28;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 530);
            ControlBox = false;
            Controls.Add(panel1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de acceso";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox TBPassword;
        private Label label2;
        private TextBox TBUser;
        private Label label1;
        private Panel panel2;
        private Button button4;
        private Label label4;
        private Panel panel3;
    }
}