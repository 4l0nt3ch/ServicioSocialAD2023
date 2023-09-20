namespace uanl_ss_main_ui
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonModify = new System.Windows.Forms.Button();
            this.ButtonTest = new System.Windows.Forms.Button();
            this.ButtonDeleteRepository = new System.Windows.Forms.Button();
            this.ButtonSaveRepository = new System.Windows.Forms.Button();
            this.ButtonCleanScreen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TBPassConfirm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBAmbiente = new System.Windows.Forms.ComboBox();
            this.ButtonUseRepository = new System.Windows.Forms.Button();
            this.CBRepo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTNombre = new System.Windows.Forms.TextBox();
            this.RBSharePoint = new System.Windows.Forms.RadioButton();
            this.RBPhysicalServer = new System.Windows.Forms.RadioButton();
            this.TBUser = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RPTabPage = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.RPTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(359, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Repositorio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.ButtonModify);
            this.panel1.Controls.Add(this.ButtonTest);
            this.panel1.Controls.Add(this.ButtonDeleteRepository);
            this.panel1.Controls.Add(this.ButtonSaveRepository);
            this.panel1.Controls.Add(this.ButtonCleanScreen);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TBPassConfirm);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TBPort);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TBServer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CBAmbiente);
            this.panel1.Controls.Add(this.ButtonUseRepository);
            this.panel1.Controls.Add(this.CBRepo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TXTNombre);
            this.panel1.Controls.Add(this.RBSharePoint);
            this.panel1.Controls.Add(this.RBPhysicalServer);
            this.panel1.Controls.Add(this.TBUser);
            this.panel1.Controls.Add(this.TBPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 382);
            this.panel1.TabIndex = 16;
            // 
            // ButtonModify
            // 
            this.ButtonModify.BackColor = System.Drawing.Color.Gold;
            this.ButtonModify.Location = new System.Drawing.Point(49, 352);
            this.ButtonModify.Name = "ButtonModify";
            this.ButtonModify.Size = new System.Drawing.Size(62, 24);
            this.ButtonModify.TabIndex = 38;
            this.ButtonModify.Text = "Modificar";
            this.ButtonModify.UseVisualStyleBackColor = false;
            this.ButtonModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // ButtonTest
            // 
            this.ButtonTest.BackColor = System.Drawing.Color.Gold;
            this.ButtonTest.Location = new System.Drawing.Point(221, 53);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.Size = new System.Drawing.Size(110, 20);
            this.ButtonTest.TabIndex = 37;
            this.ButtonTest.Text = "Probar Conexión";
            this.ButtonTest.UseVisualStyleBackColor = false;
            // 
            // ButtonDeleteRepository
            // 
            this.ButtonDeleteRepository.BackColor = System.Drawing.Color.Gold;
            this.ButtonDeleteRepository.Location = new System.Drawing.Point(117, 352);
            this.ButtonDeleteRepository.Name = "ButtonDeleteRepository";
            this.ButtonDeleteRepository.Size = new System.Drawing.Size(62, 25);
            this.ButtonDeleteRepository.TabIndex = 36;
            this.ButtonDeleteRepository.Text = "Eliminar";
            this.ButtonDeleteRepository.UseVisualStyleBackColor = false;
            this.ButtonDeleteRepository.Click += new System.EventHandler(this.ButtonDeleteRepository_Click);
            // 
            // ButtonSaveRepository
            // 
            this.ButtonSaveRepository.BackColor = System.Drawing.Color.Gold;
            this.ButtonSaveRepository.Location = new System.Drawing.Point(185, 351);
            this.ButtonSaveRepository.Name = "ButtonSaveRepository";
            this.ButtonSaveRepository.Size = new System.Drawing.Size(70, 25);
            this.ButtonSaveRepository.TabIndex = 35;
            this.ButtonSaveRepository.Text = "Guardar";
            this.ButtonSaveRepository.UseVisualStyleBackColor = false;
            this.ButtonSaveRepository.Click += new System.EventHandler(this.ButtonSaveRepository_Click);
            // 
            // ButtonCleanScreen
            // 
            this.ButtonCleanScreen.BackColor = System.Drawing.Color.Gold;
            this.ButtonCleanScreen.Location = new System.Drawing.Point(261, 352);
            this.ButtonCleanScreen.Name = "ButtonCleanScreen";
            this.ButtonCleanScreen.Size = new System.Drawing.Size(70, 25);
            this.ButtonCleanScreen.TabIndex = 34;
            this.ButtonCleanScreen.Text = "Limpiar";
            this.ButtonCleanScreen.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Confirmar Contraseña";
            // 
            // TBPassConfirm
            // 
            this.TBPassConfirm.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TBPassConfirm.ForeColor = System.Drawing.Color.White;
            this.TBPassConfirm.Location = new System.Drawing.Point(3, 312);
            this.TBPassConfirm.Name = "TBPassConfirm";
            this.TBPassConfirm.PasswordChar = '*';
            this.TBPassConfirm.Size = new System.Drawing.Size(332, 21);
            this.TBPassConfirm.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Usuario máster";
            // 
            // TBPort
            // 
            this.TBPort.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TBPort.ForeColor = System.Drawing.Color.White;
            this.TBPort.Location = new System.Drawing.Point(3, 198);
            this.TBPort.Name = "TBPort";
            this.TBPort.Size = new System.Drawing.Size(332, 21);
            this.TBPort.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Puerto";
            // 
            // TBServer
            // 
            this.TBServer.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TBServer.ForeColor = System.Drawing.Color.White;
            this.TBServer.Location = new System.Drawing.Point(3, 159);
            this.TBServer.Name = "TBServer";
            this.TBServer.Size = new System.Drawing.Size(332, 21);
            this.TBServer.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Servidor o hostname";
            // 
            // CBAmbiente
            // 
            this.CBAmbiente.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CBAmbiente.ForeColor = System.Drawing.Color.White;
            this.CBAmbiente.FormattingEnabled = true;
            this.CBAmbiente.Items.AddRange(new object[] {
            "Producción",
            "Pruebas",
            "Desarrollo"});
            this.CBAmbiente.Location = new System.Drawing.Point(3, 121);
            this.CBAmbiente.Name = "CBAmbiente";
            this.CBAmbiente.Size = new System.Drawing.Size(332, 21);
            this.CBAmbiente.TabIndex = 23;
            // 
            // ButtonUseRepository
            // 
            this.ButtonUseRepository.BackColor = System.Drawing.Color.Gold;
            this.ButtonUseRepository.Location = new System.Drawing.Point(221, 27);
            this.ButtonUseRepository.Name = "ButtonUseRepository";
            this.ButtonUseRepository.Size = new System.Drawing.Size(113, 20);
            this.ButtonUseRepository.TabIndex = 22;
            this.ButtonUseRepository.Text = "Utilizar Repositorio";
            this.ButtonUseRepository.UseVisualStyleBackColor = false;
            // 
            // CBRepo
            // 
            this.CBRepo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CBRepo.ForeColor = System.Drawing.Color.White;
            this.CBRepo.FormattingEnabled = true;
            this.CBRepo.Location = new System.Drawing.Point(3, 27);
            this.CBRepo.Name = "CBRepo";
            this.CBRepo.Size = new System.Drawing.Size(214, 21);
            this.CBRepo.TabIndex = 21;
            this.CBRepo.SelectedIndexChanged += new System.EventHandler(this.CBRepoSelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tipo de ambiente";
            // 
            // TXTNombre
            // 
            this.TXTNombre.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TXTNombre.ForeColor = System.Drawing.Color.White;
            this.TXTNombre.Location = new System.Drawing.Point(3, 83);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.Size = new System.Drawing.Size(332, 21);
            this.TXTNombre.TabIndex = 19;
            // 
            // RBSharePoint
            // 
            this.RBSharePoint.AutoSize = true;
            this.RBSharePoint.Location = new System.Drawing.Point(117, 62);
            this.RBSharePoint.Name = "RBSharePoint";
            this.RBSharePoint.Size = new System.Drawing.Size(80, 17);
            this.RBSharePoint.TabIndex = 18;
            this.RBSharePoint.TabStop = true;
            this.RBSharePoint.Text = "Sharepoint";
            this.RBSharePoint.UseVisualStyleBackColor = true;
            // 
            // RBPhysicalServer
            // 
            this.RBPhysicalServer.AutoSize = true;
            this.RBPhysicalServer.Location = new System.Drawing.Point(3, 62);
            this.RBPhysicalServer.Name = "RBPhysicalServer";
            this.RBPhysicalServer.Size = new System.Drawing.Size(98, 17);
            this.RBPhysicalServer.TabIndex = 17;
            this.RBPhysicalServer.TabStop = true;
            this.RBPhysicalServer.Text = "Servidor físico";
            this.RBPhysicalServer.UseVisualStyleBackColor = true;
            // 
            // TBUser
            // 
            this.TBUser.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TBUser.ForeColor = System.Drawing.Color.White;
            this.TBUser.Location = new System.Drawing.Point(3, 236);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(332, 21);
            this.TBUser.TabIndex = 29;
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TBPassword.ForeColor = System.Drawing.Color.White;
            this.TBPassword.Location = new System.Drawing.Point(3, 274);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(332, 21);
            this.TBPassword.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gestor de Repositorios";
            // 
            // RPTabPage
            // 
            this.RPTabPage.Controls.Add(this.tabPage1);
            this.RPTabPage.Location = new System.Drawing.Point(10, 10);
            this.RPTabPage.Name = "RPTabPage";
            this.RPTabPage.SelectedIndex = 0;
            this.RPTabPage.Size = new System.Drawing.Size(367, 335);
            this.RPTabPage.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(388, 363);
            this.Controls.Add(this.RPTabPage);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.RPTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage1;
        private Panel panel1;
        private Button ButtonDeleteRepository;
        private Button ButtonSaveRepository;
        private Button ButtonCleanScreen;
        private Label label7;
        private TextBox TBPassConfirm;
        private Label label6;
        private Label label5;
        private TextBox TBPort;
        private Label label4;
        private TextBox TBServer;
        private Label label3;
        private ComboBox CBAmbiente;
        private Button ButtonUseRepository;
        private ComboBox CBRepo;
        private Label label2;
        private TextBox TXTNombre;
        private RadioButton RBSharePoint;
        private RadioButton RBPhysicalServer;
        private TextBox TBUser;
        private TextBox TBPassword;
        private Label label1;
        private TabControl RPTabPage;
        private Button ButtonTest;
        private Button ButtonModify;
    }
}