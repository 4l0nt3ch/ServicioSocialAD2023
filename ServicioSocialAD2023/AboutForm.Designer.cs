namespace uanl_ss_main_ui
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            lblMainAbout = new Label();
            btAceptar = new Button();
            SuspendLayout();
            // 
            // lblMainAbout
            // 
            lblMainAbout.AutoSize = true;
            lblMainAbout.BackColor = Color.Transparent;
            lblMainAbout.Location = new Point(12, 23);
            lblMainAbout.Name = "lblMainAbout";
            lblMainAbout.Size = new Size(392, 168);
            lblMainAbout.TabIndex = 0;
            lblMainAbout.Text = resources.GetString("lblMainAbout.Text");
            // 
            // btAceptar
            // 
            btAceptar.BackColor = Color.MidnightBlue;
            btAceptar.Location = new Point(436, 213);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(149, 31);
            btAceptar.TabIndex = 1;
            btAceptar.Text = "Aceptar";
            btAceptar.UseVisualStyleBackColor = false;
            btAceptar.Click += BtnAceptarClick;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            BackgroundImage = Properties.Resources.UANL_SS_BOLETAS_login_background_screen;
            ClientSize = new Size(597, 255);
            ControlBox = false;
            Controls.Add(btAceptar);
            Controls.Add(lblMainAbout);
            Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acerca de";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMainAbout;
        private Button btAceptar;
    }
}