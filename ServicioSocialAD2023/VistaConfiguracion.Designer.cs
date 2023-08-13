namespace uanl_ss_main_ui
{
    partial class VistaConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaConfiguracion));
            tabPage1 = new TabPage();
            panel1 = new Panel();
            ButtonModify = new Button();
            ButtonTest = new Button();
            ButtonDeleteRepository = new Button();
            ButtonSaveRepository = new Button();
            ButtonCleanScreen = new Button();
            label7 = new Label();
            TBPassConfirm = new TextBox();
            label6 = new Label();
            label5 = new Label();
            TBPort = new TextBox();
            label4 = new Label();
            TBServer = new TextBox();
            label3 = new Label();
            CBAmbiente = new ComboBox();
            ButtonUseRepository = new Button();
            CBRepo = new ComboBox();
            label2 = new Label();
            TXTNombre = new TextBox();
            RBSharePoint = new RadioButton();
            RBPhysicalServer = new RadioButton();
            TBUser = new TextBox();
            TBPassword = new TextBox();
            label1 = new Label();
            RPTabPage = new TabControl();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            RPTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(359, 309);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Repositorio";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(ButtonModify);
            panel1.Controls.Add(ButtonTest);
            panel1.Controls.Add(ButtonDeleteRepository);
            panel1.Controls.Add(ButtonSaveRepository);
            panel1.Controls.Add(ButtonCleanScreen);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(TBPassConfirm);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TBPort);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TBServer);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(CBAmbiente);
            panel1.Controls.Add(ButtonUseRepository);
            panel1.Controls.Add(CBRepo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TXTNombre);
            panel1.Controls.Add(RBSharePoint);
            panel1.Controls.Add(RBPhysicalServer);
            panel1.Controls.Add(TBUser);
            panel1.Controls.Add(TBPassword);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 382);
            panel1.TabIndex = 16;
            // 
            // ButtonModify
            // 
            ButtonModify.BackColor = Color.Gold;
            ButtonModify.Location = new Point(49, 352);
            ButtonModify.Name = "ButtonModify";
            ButtonModify.Size = new Size(62, 24);
            ButtonModify.TabIndex = 38;
            ButtonModify.Text = "Modificar";
            ButtonModify.UseVisualStyleBackColor = false;
            ButtonModify.Click += ButtonModify_Click;
            // 
            // ButtonTest
            // 
            ButtonTest.BackColor = Color.Gold;
            ButtonTest.Location = new Point(221, 53);
            ButtonTest.Name = "ButtonTest";
            ButtonTest.Size = new Size(110, 20);
            ButtonTest.TabIndex = 37;
            ButtonTest.Text = "Probar Conexión";
            ButtonTest.UseVisualStyleBackColor = false;
            // 
            // ButtonDeleteRepository
            // 
            ButtonDeleteRepository.BackColor = Color.Gold;
            ButtonDeleteRepository.Location = new Point(117, 352);
            ButtonDeleteRepository.Name = "ButtonDeleteRepository";
            ButtonDeleteRepository.Size = new Size(62, 25);
            ButtonDeleteRepository.TabIndex = 36;
            ButtonDeleteRepository.Text = "Eliminar";
            ButtonDeleteRepository.UseVisualStyleBackColor = false;
            ButtonDeleteRepository.Click += ButtonDeleteRepository_Click;
            // 
            // ButtonSaveRepository
            // 
            ButtonSaveRepository.BackColor = Color.Gold;
            ButtonSaveRepository.Location = new Point(185, 351);
            ButtonSaveRepository.Name = "ButtonSaveRepository";
            ButtonSaveRepository.Size = new Size(70, 25);
            ButtonSaveRepository.TabIndex = 35;
            ButtonSaveRepository.Text = "Guardar";
            ButtonSaveRepository.UseVisualStyleBackColor = false;
            ButtonSaveRepository.Click += ButtonSaveRepository_Click;
            // 
            // ButtonCleanScreen
            // 
            ButtonCleanScreen.BackColor = Color.Gold;
            ButtonCleanScreen.Location = new Point(261, 352);
            ButtonCleanScreen.Name = "ButtonCleanScreen";
            ButtonCleanScreen.Size = new Size(70, 25);
            ButtonCleanScreen.TabIndex = 34;
            ButtonCleanScreen.Text = "Limpiar";
            ButtonCleanScreen.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 296);
            label7.Name = "label7";
            label7.Size = new Size(118, 13);
            label7.TabIndex = 33;
            label7.Text = "Confirmar Contraseña";
            // 
            // TBPassConfirm
            // 
            TBPassConfirm.Location = new Point(3, 312);
            TBPassConfirm.Name = "TBPassConfirm";
            TBPassConfirm.PasswordChar = '*';
            TBPassConfirm.Size = new Size(332, 21);
            TBPassConfirm.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 258);
            label6.Name = "label6";
            label6.Size = new Size(65, 13);
            label6.TabIndex = 31;
            label6.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 220);
            label5.Name = "label5";
            label5.Size = new Size(85, 13);
            label5.TabIndex = 28;
            label5.Text = "Usuario máster";
            // 
            // TBPort
            // 
            TBPort.Location = new Point(3, 198);
            TBPort.Name = "TBPort";
            TBPort.Size = new Size(332, 21);
            TBPort.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 182);
            label4.Name = "label4";
            label4.Size = new Size(41, 13);
            label4.TabIndex = 26;
            label4.Text = "Puerto";
            // 
            // TBServer
            // 
            TBServer.Location = new Point(3, 159);
            TBServer.Name = "TBServer";
            TBServer.Size = new Size(332, 21);
            TBServer.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 144);
            label3.Name = "label3";
            label3.Size = new Size(112, 13);
            label3.TabIndex = 24;
            label3.Text = "Servidor o hostname";
            // 
            // CBAmbiente
            // 
            CBAmbiente.FormattingEnabled = true;
            CBAmbiente.Items.AddRange(new object[] { "Producción", "Pruebas", "Desarrollo" });
            CBAmbiente.Location = new Point(3, 121);
            CBAmbiente.Name = "CBAmbiente";
            CBAmbiente.Size = new Size(332, 21);
            CBAmbiente.TabIndex = 23;
            // 
            // ButtonUseRepository
            // 
            ButtonUseRepository.BackColor = Color.Gold;
            ButtonUseRepository.Location = new Point(221, 27);
            ButtonUseRepository.Name = "ButtonUseRepository";
            ButtonUseRepository.Size = new Size(113, 20);
            ButtonUseRepository.TabIndex = 22;
            ButtonUseRepository.Text = "Utilizar Repositorio";
            ButtonUseRepository.UseVisualStyleBackColor = false;
            ButtonUseRepository.Click += ButtonUseRepository_Click;
            // 
            // CBRepo
            // 
            CBRepo.FormattingEnabled = true;
            CBRepo.Location = new Point(3, 27);
            CBRepo.Name = "CBRepo";
            CBRepo.Size = new Size(214, 21);
            CBRepo.TabIndex = 21;
            CBRepo.SelectedValueChanged += CBRepoSelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 106);
            label2.Name = "label2";
            label2.Size = new Size(91, 13);
            label2.TabIndex = 20;
            label2.Text = "Tipo de ambiente";
            // 
            // TXTNombre
            // 
            TXTNombre.Location = new Point(3, 83);
            TXTNombre.Name = "TXTNombre";
            TXTNombre.Size = new Size(332, 21);
            TXTNombre.TabIndex = 19;
            // 
            // RBSharePoint
            // 
            RBSharePoint.AutoSize = true;
            RBSharePoint.Location = new Point(117, 62);
            RBSharePoint.Name = "RBSharePoint";
            RBSharePoint.Size = new Size(80, 17);
            RBSharePoint.TabIndex = 18;
            RBSharePoint.TabStop = true;
            RBSharePoint.Text = "Sharepoint";
            RBSharePoint.UseVisualStyleBackColor = true;
            RBSharePoint.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // RBPhysicalServer
            // 
            RBPhysicalServer.AutoSize = true;
            RBPhysicalServer.Location = new Point(3, 62);
            RBPhysicalServer.Name = "RBPhysicalServer";
            RBPhysicalServer.Size = new Size(98, 17);
            RBPhysicalServer.TabIndex = 17;
            RBPhysicalServer.TabStop = true;
            RBPhysicalServer.Text = "Servidor físico";
            RBPhysicalServer.UseVisualStyleBackColor = true;
            // 
            // TBUser
            // 
            TBUser.Location = new Point(3, 236);
            TBUser.Name = "TBUser";
            TBUser.Size = new Size(332, 21);
            TBUser.TabIndex = 29;
            TBUser.TextChanged += textBox4_TextChanged;
            // 
            // TBPassword
            // 
            TBPassword.Location = new Point(3, 274);
            TBPassword.Name = "TBPassword";
            TBPassword.PasswordChar = '*';
            TBPassword.Size = new Size(332, 21);
            TBPassword.TabIndex = 30;
            TBPassword.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(123, 13);
            label1.TabIndex = 16;
            label1.Text = "Gestor de Repositorios";
            // 
            // RPTabPage
            // 
            RPTabPage.Controls.Add(tabPage1);
            RPTabPage.Location = new Point(10, 10);
            RPTabPage.Name = "RPTabPage";
            RPTabPage.SelectedIndex = 0;
            RPTabPage.Size = new Size(367, 335);
            RPTabPage.TabIndex = 0;
            // 
            // VistaConfiguracion
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(388, 363);
            Controls.Add(RPTabPage);
            Font = new Font("Bahnschrift Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VistaConfiguracion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuración";
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            RPTabPage.ResumeLayout(false);
            ResumeLayout(false);
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