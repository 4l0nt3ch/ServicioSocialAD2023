namespace uanl_ss_main_ui
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PanelLogo = new Panel();
            FilterPanel = new Panel();
            btnMinimize = new Button();
            button1 = new Button();
            BtSettings = new Button();
            BtSearchTerm = new Button();
            TBSearchFilter = new TextBox();
            label13 = new Label();
            label12 = new Label();
            CBOptionFilter = new ComboBox();
            RBFilterBy = new RadioButton();
            RBShowAll = new RadioButton();
            lblTemplate = new Label();
            CBTemplateEngine = new ComboBox();
            label1 = new Label();
            CBCoordinador = new ComboBox();
            CBPeriodo = new ComboBox();
            label3 = new Label();
            CBDocEditable = new CheckBox();
            CBAccessPassword = new CheckBox();
            label4 = new Label();
            TBPassword = new TextBox();
            label5 = new Label();
            TBPasswordConfirm = new TextBox();
            label6 = new Label();
            templatePanel = new Panel();
            label27 = new Label();
            BTUpdateDepEd = new Button();
            BTShowDepEd = new Button();
            CBDepEducativa = new ComboBox();
            label22 = new Label();
            button16 = new Button();
            BTUpdateCoordinador = new Button();
            button13 = new Button();
            BTShowCoordinador = new Button();
            RegisterPanel = new Panel();
            InfoPanel = new Panel();
            BtSubstractPag = new Button();
            BtAddPag = new Button();
            btNextPag = new Button();
            btPrevPag = new Button();
            label21 = new Label();
            TBBatchAmmount = new TextBox();
            label20 = new Label();
            TBPagination = new TextBox();
            TBCorrectFiles = new TextBox();
            label19 = new Label();
            TBErrorFiles = new TextBox();
            label18 = new Label();
            TBUnexportedRecords = new TextBox();
            label17 = new Label();
            label16 = new Label();
            TBFoundFiles = new TextBox();
            TBExportedRecords = new TextBox();
            label15 = new Label();
            TBFoundRecords = new TextBox();
            label14 = new Label();
            ButtonUpdateStatus = new Button();
            ButtonGenerateSend = new Button();
            ButtonGenerateDocuments = new Button();
            LVMain = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            EmailPanel = new Panel();
            CBExportFilter = new ComboBox();
            RBOnlyFolder = new RadioButton();
            RBSeparatedFolders = new RadioButton();
            label11 = new Label();
            CLBEmailOptions = new CheckedListBox();
            CBEnableSendEmail = new CheckBox();
            label10 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            LVFormatRepoList = new ListView();
            ButtonCreateDR = new Button();
            ButtonManageDR = new Button();
            label26 = new Label();
            CbImportTool = new ComboBox();
            CBExportEngine = new ComboBox();
            ButtonDeleteDR = new Button();
            label23 = new Label();
            label9 = new Label();
            ButtonImportDR = new Button();
            ConfigPanel = new Panel();
            FilterPanel.SuspendLayout();
            templatePanel.SuspendLayout();
            RegisterPanel.SuspendLayout();
            InfoPanel.SuspendLayout();
            EmailPanel.SuspendLayout();
            panel1.SuspendLayout();
            ConfigPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PanelLogo
            // 
            PanelLogo.AllowDrop = true;
            PanelLogo.BackgroundImage = Properties.Resources.UANL_SS_BOLETAS_banner;
            PanelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            PanelLogo.Location = new Point(3, 20);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(460, 60);
            PanelLogo.TabIndex = 2;
            PanelLogo.Click += PanelLogoClick;
            // 
            // FilterPanel
            // 
            FilterPanel.Controls.Add(btnMinimize);
            FilterPanel.Controls.Add(button1);
            FilterPanel.Controls.Add(BtSettings);
            FilterPanel.Controls.Add(BtSearchTerm);
            FilterPanel.Controls.Add(TBSearchFilter);
            FilterPanel.Controls.Add(label13);
            FilterPanel.Controls.Add(label12);
            FilterPanel.Controls.Add(CBOptionFilter);
            FilterPanel.Controls.Add(RBFilterBy);
            FilterPanel.Controls.Add(RBShowAll);
            FilterPanel.Location = new Point(478, 12);
            FilterPanel.Name = "FilterPanel";
            FilterPanel.Size = new Size(1174, 80);
            FilterPanel.TabIndex = 3;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Gold;
            btnMinimize.BackgroundImage = (Image)resources.GetObject("btnMinimize.BackgroundImage");
            btnMinimize.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(1121, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(22, 25);
            btnMinimize.TabIndex = 34;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += BtnMinimizeClicked;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Gold;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1149, 3);
            button1.Name = "button1";
            button1.Size = new Size(22, 25);
            button1.TabIndex = 33;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BtSettings
            // 
            BtSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtSettings.BackColor = Color.Gold;
            BtSettings.BackgroundImage = Properties.Resources.ajustes;
            BtSettings.BackgroundImageLayout = ImageLayout.Stretch;
            BtSettings.FlatStyle = FlatStyle.Flat;
            BtSettings.Location = new Point(1093, 3);
            BtSettings.Name = "BtSettings";
            BtSettings.Size = new Size(22, 25);
            BtSettings.TabIndex = 32;
            BtSettings.UseVisualStyleBackColor = false;
            BtSettings.Click += BtSettingsEvent;
            // 
            // BtSearchTerm
            // 
            BtSearchTerm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtSearchTerm.BackColor = Color.Gold;
            BtSearchTerm.FlatStyle = FlatStyle.Flat;
            BtSearchTerm.ForeColor = Color.Black;
            BtSearchTerm.Location = new Point(1055, 46);
            BtSearchTerm.Name = "BtSearchTerm";
            BtSearchTerm.Size = new Size(116, 24);
            BtSearchTerm.TabIndex = 31;
            BtSearchTerm.Text = "Buscar";
            BtSearchTerm.UseVisualStyleBackColor = false;
            // 
            // TBSearchFilter
            // 
            TBSearchFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TBSearchFilter.BackColor = SystemColors.ControlDarkDark;
            TBSearchFilter.ForeColor = Color.White;
            TBSearchFilter.Location = new Point(796, 46);
            TBSearchFilter.Name = "TBSearchFilter";
            TBSearchFilter.Size = new Size(253, 21);
            TBSearchFilter.TabIndex = 30;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(721, 48);
            label13.Name = "label13";
            label13.Size = new Size(64, 15);
            label13.TabIndex = 29;
            label13.Text = "Búsqueda";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 18);
            label12.Name = "label12";
            label12.Size = new Size(117, 15);
            label12.TabIndex = 28;
            label12.Text = "Filtros de búsqueda";
            // 
            // CBOptionFilter
            // 
            CBOptionFilter.BackColor = SystemColors.ControlDarkDark;
            CBOptionFilter.ForeColor = Color.White;
            CBOptionFilter.FormattingEnabled = true;
            CBOptionFilter.Items.AddRange(new object[] { "Estudiante", "Carrera", "Dependencia Educativa", "Dependencia Privada", "Responsable", "Coordinador", "Periodo" });
            CBOptionFilter.Location = new Point(250, 45);
            CBOptionFilter.Name = "CBOptionFilter";
            CBOptionFilter.Size = new Size(261, 23);
            CBOptionFilter.TabIndex = 27;
            // 
            // RBFilterBy
            // 
            RBFilterBy.AutoSize = true;
            RBFilterBy.Location = new Point(165, 46);
            RBFilterBy.Name = "RBFilterBy";
            RBFilterBy.Size = new Size(80, 19);
            RBFilterBy.TabIndex = 1;
            RBFilterBy.TabStop = true;
            RBFilterBy.Text = "Filtrar por:";
            RBFilterBy.UseVisualStyleBackColor = true;
            // 
            // RBShowAll
            // 
            RBShowAll.AutoSize = true;
            RBShowAll.Location = new Point(23, 46);
            RBShowAll.Name = "RBShowAll";
            RBShowAll.Size = new Size(93, 19);
            RBShowAll.TabIndex = 0;
            RBShowAll.TabStop = true;
            RBShowAll.Text = "Mostrar todo";
            RBShowAll.UseVisualStyleBackColor = true;
            // 
            // lblTemplate
            // 
            lblTemplate.AutoSize = true;
            lblTemplate.Location = new Point(11, 40);
            lblTemplate.Name = "lblTemplate";
            lblTemplate.Size = new Size(107, 15);
            lblTemplate.TabIndex = 0;
            lblTemplate.Text = "Plantilla a generar";
            // 
            // CBTemplateEngine
            // 
            CBTemplateEngine.BackColor = Color.DimGray;
            CBTemplateEngine.ForeColor = Color.White;
            CBTemplateEngine.FormattingEnabled = true;
            CBTemplateEngine.Items.AddRange(new object[] { "Boleta de Presentación", "Carta de Inicio", "Kardex" });
            CBTemplateEngine.Location = new Point(13, 58);
            CBTemplateEngine.Name = "CBTemplateEngine";
            CBTemplateEngine.Size = new Size(435, 23);
            CBTemplateEngine.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 129);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 2;
            label1.Text = "Coordinador SS UANL";
            // 
            // CBCoordinador
            // 
            CBCoordinador.BackColor = Color.DimGray;
            CBCoordinador.ForeColor = Color.White;
            CBCoordinador.FormattingEnabled = true;
            CBCoordinador.Location = new Point(13, 147);
            CBCoordinador.Name = "CBCoordinador";
            CBCoordinador.Size = new Size(375, 23);
            CBCoordinador.TabIndex = 3;
            // 
            // CBPeriodo
            // 
            CBPeriodo.BackColor = Color.DimGray;
            CBPeriodo.ForeColor = Color.White;
            CBPeriodo.FormattingEnabled = true;
            CBPeriodo.Location = new Point(13, 192);
            CBPeriodo.Name = "CBPeriodo";
            CBPeriodo.Size = new Size(375, 23);
            CBPeriodo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 7;
            label3.Text = "Periodo/Semestre";
            // 
            // CBDocEditable
            // 
            CBDocEditable.AutoSize = true;
            CBDocEditable.Location = new Point(135, 228);
            CBDocEditable.Name = "CBDocEditable";
            CBDocEditable.Size = new Size(71, 19);
            CBDocEditable.TabIndex = 8;
            CBDocEditable.Text = "Editable";
            CBDocEditable.UseVisualStyleBackColor = true;
            CBDocEditable.CheckedChanged += CBDocEditable_CheckedChanged;
            // 
            // CBAccessPassword
            // 
            CBAccessPassword.AutoSize = true;
            CBAccessPassword.Location = new Point(220, 228);
            CBAccessPassword.Name = "CBAccessPassword";
            CBAccessPassword.Size = new Size(186, 19);
            CBAccessPassword.TabIndex = 9;
            CBAccessPassword.Text = "Activar contraseña de acceso";
            CBAccessPassword.UseVisualStyleBackColor = true;
            CBAccessPassword.CheckedChanged += CBAccessPassword_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 228);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 10;
            label4.Text = "Lectura/Escritura";
            label4.Click += label4_Click;
            // 
            // TBPassword
            // 
            TBPassword.BackColor = Color.Gray;
            TBPassword.Enabled = false;
            TBPassword.ForeColor = Color.White;
            TBPassword.Location = new Point(170, 264);
            TBPassword.Name = "TBPassword";
            TBPassword.PasswordChar = '*';
            TBPassword.Size = new Size(279, 21);
            TBPassword.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 267);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 12;
            label5.Text = "Contraseña";
            // 
            // TBPasswordConfirm
            // 
            TBPasswordConfirm.BackColor = Color.Gray;
            TBPasswordConfirm.Enabled = false;
            TBPasswordConfirm.ForeColor = Color.White;
            TBPasswordConfirm.Location = new Point(170, 305);
            TBPasswordConfirm.Name = "TBPasswordConfirm";
            TBPasswordConfirm.PasswordChar = '*';
            TBPasswordConfirm.Size = new Size(278, 21);
            TBPasswordConfirm.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 309);
            label6.Name = "label6";
            label6.Size = new Size(130, 15);
            label6.TabIndex = 14;
            label6.Text = "Confirmar Contraseña";
            // 
            // templatePanel
            // 
            templatePanel.AutoScroll = true;
            templatePanel.BackColor = Color.Transparent;
            templatePanel.Controls.Add(label27);
            templatePanel.Controls.Add(BTUpdateDepEd);
            templatePanel.Controls.Add(BTShowDepEd);
            templatePanel.Controls.Add(CBDepEducativa);
            templatePanel.Controls.Add(label22);
            templatePanel.Controls.Add(button16);
            templatePanel.Controls.Add(BTUpdateCoordinador);
            templatePanel.Controls.Add(button13);
            templatePanel.Controls.Add(BTShowCoordinador);
            templatePanel.Controls.Add(label6);
            templatePanel.Controls.Add(TBPasswordConfirm);
            templatePanel.Controls.Add(label5);
            templatePanel.Controls.Add(TBPassword);
            templatePanel.Controls.Add(label4);
            templatePanel.Controls.Add(CBAccessPassword);
            templatePanel.Controls.Add(CBDocEditable);
            templatePanel.Controls.Add(label3);
            templatePanel.Controls.Add(CBPeriodo);
            templatePanel.Controls.Add(CBCoordinador);
            templatePanel.Controls.Add(label1);
            templatePanel.Controls.Add(CBTemplateEngine);
            templatePanel.Controls.Add(lblTemplate);
            templatePanel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            templatePanel.ForeColor = Color.Black;
            templatePanel.Location = new Point(3, 314);
            templatePanel.Name = "templatePanel";
            templatePanel.Size = new Size(469, 341);
            templatePanel.TabIndex = 0;
            templatePanel.Tag = "Control de Plantillas";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(12, 15);
            label27.Name = "label27";
            label27.Size = new Size(177, 14);
            label27.TabIndex = 33;
            label27.Text = "Construcción de documentos";
            // 
            // BTUpdateDepEd
            // 
            BTUpdateDepEd.BackColor = Color.Gold;
            BTUpdateDepEd.BackgroundImage = (Image)resources.GetObject("BTUpdateDepEd.BackgroundImage");
            BTUpdateDepEd.BackgroundImageLayout = ImageLayout.Stretch;
            BTUpdateDepEd.FlatStyle = FlatStyle.Flat;
            BTUpdateDepEd.Location = new Point(394, 103);
            BTUpdateDepEd.Name = "BTUpdateDepEd";
            BTUpdateDepEd.Size = new Size(24, 22);
            BTUpdateDepEd.TabIndex = 32;
            BTUpdateDepEd.UseVisualStyleBackColor = false;
            // 
            // BTShowDepEd
            // 
            BTShowDepEd.BackColor = Color.Gold;
            BTShowDepEd.BackgroundImage = (Image)resources.GetObject("BTShowDepEd.BackgroundImage");
            BTShowDepEd.BackgroundImageLayout = ImageLayout.Stretch;
            BTShowDepEd.FlatStyle = FlatStyle.Flat;
            BTShowDepEd.Location = new Point(425, 103);
            BTShowDepEd.Name = "BTShowDepEd";
            BTShowDepEd.Size = new Size(24, 22);
            BTShowDepEd.TabIndex = 31;
            BTShowDepEd.UseVisualStyleBackColor = false;
            // 
            // CBDepEducativa
            // 
            CBDepEducativa.BackColor = Color.DimGray;
            CBDepEducativa.ForeColor = Color.White;
            CBDepEducativa.FormattingEnabled = true;
            CBDepEducativa.Location = new Point(13, 103);
            CBDepEducativa.Name = "CBDepEducativa";
            CBDepEducativa.Size = new Size(375, 23);
            CBDepEducativa.TabIndex = 28;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(11, 85);
            label22.Name = "label22";
            label22.Size = new Size(137, 15);
            label22.TabIndex = 27;
            label22.Text = "Dependencia Educativa";
            // 
            // button16
            // 
            button16.BackColor = Color.Gold;
            button16.BackgroundImage = (Image)resources.GetObject("button16.BackgroundImage");
            button16.BackgroundImageLayout = ImageLayout.Stretch;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Location = new Point(394, 193);
            button16.Name = "button16";
            button16.Size = new Size(24, 22);
            button16.TabIndex = 26;
            button16.UseVisualStyleBackColor = false;
            // 
            // BTUpdateCoordinador
            // 
            BTUpdateCoordinador.BackColor = Color.Gold;
            BTUpdateCoordinador.BackgroundImage = (Image)resources.GetObject("BTUpdateCoordinador.BackgroundImage");
            BTUpdateCoordinador.BackgroundImageLayout = ImageLayout.Stretch;
            BTUpdateCoordinador.FlatStyle = FlatStyle.Flat;
            BTUpdateCoordinador.Location = new Point(394, 148);
            BTUpdateCoordinador.Name = "BTUpdateCoordinador";
            BTUpdateCoordinador.Size = new Size(24, 22);
            BTUpdateCoordinador.TabIndex = 24;
            BTUpdateCoordinador.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = Color.Gold;
            button13.BackgroundImage = (Image)resources.GetObject("button13.BackgroundImage");
            button13.BackgroundImageLayout = ImageLayout.Stretch;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Location = new Point(425, 192);
            button13.Name = "button13";
            button13.Size = new Size(24, 22);
            button13.TabIndex = 23;
            button13.UseVisualStyleBackColor = false;
            // 
            // BTShowCoordinador
            // 
            BTShowCoordinador.BackColor = Color.Gold;
            BTShowCoordinador.BackgroundImage = (Image)resources.GetObject("BTShowCoordinador.BackgroundImage");
            BTShowCoordinador.BackgroundImageLayout = ImageLayout.Stretch;
            BTShowCoordinador.FlatStyle = FlatStyle.Flat;
            BTShowCoordinador.Location = new Point(425, 148);
            BTShowCoordinador.Name = "BTShowCoordinador";
            BTShowCoordinador.Size = new Size(24, 22);
            BTShowCoordinador.TabIndex = 21;
            BTShowCoordinador.UseVisualStyleBackColor = false;
            // 
            // RegisterPanel
            // 
            RegisterPanel.AutoScroll = true;
            RegisterPanel.BackColor = Color.LightGray;
            RegisterPanel.Controls.Add(InfoPanel);
            RegisterPanel.Controls.Add(LVMain);
            RegisterPanel.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterPanel.ForeColor = Color.Black;
            RegisterPanel.Location = new Point(472, 95);
            RegisterPanel.Name = "RegisterPanel";
            RegisterPanel.Size = new Size(1187, 916);
            RegisterPanel.TabIndex = 6;
            // 
            // InfoPanel
            // 
            InfoPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            InfoPanel.Controls.Add(BtSubstractPag);
            InfoPanel.Controls.Add(BtAddPag);
            InfoPanel.Controls.Add(btNextPag);
            InfoPanel.Controls.Add(btPrevPag);
            InfoPanel.Controls.Add(label21);
            InfoPanel.Controls.Add(TBBatchAmmount);
            InfoPanel.Controls.Add(label20);
            InfoPanel.Controls.Add(TBPagination);
            InfoPanel.Controls.Add(TBCorrectFiles);
            InfoPanel.Controls.Add(label19);
            InfoPanel.Controls.Add(TBErrorFiles);
            InfoPanel.Controls.Add(label18);
            InfoPanel.Controls.Add(TBUnexportedRecords);
            InfoPanel.Controls.Add(label17);
            InfoPanel.Controls.Add(label16);
            InfoPanel.Controls.Add(TBFoundFiles);
            InfoPanel.Controls.Add(TBExportedRecords);
            InfoPanel.Controls.Add(label15);
            InfoPanel.Controls.Add(TBFoundRecords);
            InfoPanel.Controls.Add(label14);
            InfoPanel.Controls.Add(ButtonUpdateStatus);
            InfoPanel.Controls.Add(ButtonGenerateSend);
            InfoPanel.Controls.Add(ButtonGenerateDocuments);
            InfoPanel.Location = new Point(0, 831);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Size = new Size(1165, 82);
            InfoPanel.TabIndex = 34;
            InfoPanel.Paint += panel2_Paint;
            // 
            // BtSubstractPag
            // 
            BtSubstractPag.BackColor = Color.Gold;
            BtSubstractPag.BackgroundImage = (Image)resources.GetObject("BtSubstractPag.BackgroundImage");
            BtSubstractPag.BackgroundImageLayout = ImageLayout.Stretch;
            BtSubstractPag.FlatStyle = FlatStyle.Flat;
            BtSubstractPag.Location = new Point(738, 43);
            BtSubstractPag.Name = "BtSubstractPag";
            BtSubstractPag.Size = new Size(24, 22);
            BtSubstractPag.TabIndex = 55;
            BtSubstractPag.UseVisualStyleBackColor = false;
            BtSubstractPag.Click += ButtonRemPaginationBatchClick;
            // 
            // BtAddPag
            // 
            BtAddPag.BackColor = Color.Gold;
            BtAddPag.BackgroundImage = Properties.Resources.plus;
            BtAddPag.BackgroundImageLayout = ImageLayout.Stretch;
            BtAddPag.FlatStyle = FlatStyle.Flat;
            BtAddPag.Location = new Point(768, 43);
            BtAddPag.Name = "BtAddPag";
            BtAddPag.Size = new Size(24, 22);
            BtAddPag.TabIndex = 54;
            BtAddPag.UseVisualStyleBackColor = false;
            BtAddPag.Click += ButtonAddPaginationBatchClick;
            // 
            // btNextPag
            // 
            btNextPag.BackColor = Color.Gold;
            btNextPag.BackgroundImage = (Image)resources.GetObject("btNextPag.BackgroundImage");
            btNextPag.BackgroundImageLayout = ImageLayout.Stretch;
            btNextPag.FlatStyle = FlatStyle.Flat;
            btNextPag.Location = new Point(768, 13);
            btNextPag.Name = "btNextPag";
            btNextPag.Size = new Size(24, 22);
            btNextPag.TabIndex = 53;
            btNextPag.UseVisualStyleBackColor = false;
            btNextPag.Click += BtnPagSiguienteClick;
            // 
            // btPrevPag
            // 
            btPrevPag.BackColor = Color.Gold;
            btPrevPag.BackgroundImage = (Image)resources.GetObject("btPrevPag.BackgroundImage");
            btPrevPag.BackgroundImageLayout = ImageLayout.Stretch;
            btPrevPag.FlatStyle = FlatStyle.Flat;
            btPrevPag.Location = new Point(738, 13);
            btPrevPag.Name = "btPrevPag";
            btPrevPag.Size = new Size(24, 22);
            btPrevPag.TabIndex = 52;
            btPrevPag.UseVisualStyleBackColor = false;
            btPrevPag.Click += BtnPagAnteriorClick;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Left;
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(621, 47);
            label21.Name = "label21";
            label21.Size = new Size(31, 15);
            label21.TabIndex = 51;
            label21.Text = "Lote";
            // 
            // TBBatchAmmount
            // 
            TBBatchAmmount.Anchor = AnchorStyles.Left;
            TBBatchAmmount.BackColor = Color.DimGray;
            TBBatchAmmount.ForeColor = Color.White;
            TBBatchAmmount.Location = new Point(657, 43);
            TBBatchAmmount.Name = "TBBatchAmmount";
            TBBatchAmmount.ReadOnly = true;
            TBBatchAmmount.Size = new Size(75, 22);
            TBBatchAmmount.TabIndex = 50;
            TBBatchAmmount.TabStop = false;
            TBBatchAmmount.Text = "50";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Left;
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(621, 18);
            label20.Name = "label20";
            label20.Size = new Size(32, 15);
            label20.TabIndex = 49;
            label20.Text = "Pág.";
            // 
            // TBPagination
            // 
            TBPagination.Anchor = AnchorStyles.Left;
            TBPagination.BackColor = Color.DimGray;
            TBPagination.ForeColor = Color.White;
            TBPagination.Location = new Point(657, 14);
            TBPagination.Name = "TBPagination";
            TBPagination.ReadOnly = true;
            TBPagination.Size = new Size(75, 22);
            TBPagination.TabIndex = 48;
            TBPagination.TabStop = false;
            // 
            // TBCorrectFiles
            // 
            TBCorrectFiles.Anchor = AnchorStyles.Left;
            TBCorrectFiles.BackColor = Color.DimGray;
            TBCorrectFiles.ForeColor = Color.White;
            TBCorrectFiles.Location = new Point(441, 55);
            TBCorrectFiles.Name = "TBCorrectFiles";
            TBCorrectFiles.ReadOnly = true;
            TBCorrectFiles.Size = new Size(161, 22);
            TBCorrectFiles.TabIndex = 47;
            TBCorrectFiles.TabStop = false;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Left;
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(311, 59);
            label19.Name = "label19";
            label19.Size = new Size(107, 15);
            label19.TabIndex = 46;
            label19.Text = "Archivos correctos";
            // 
            // TBErrorFiles
            // 
            TBErrorFiles.Anchor = AnchorStyles.Left;
            TBErrorFiles.BackColor = Color.DimGray;
            TBErrorFiles.ForeColor = Color.White;
            TBErrorFiles.Location = new Point(441, 30);
            TBErrorFiles.Name = "TBErrorFiles";
            TBErrorFiles.ReadOnly = true;
            TBErrorFiles.Size = new Size(161, 22);
            TBErrorFiles.TabIndex = 45;
            TBErrorFiles.TabStop = false;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Left;
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(311, 34);
            label18.Name = "label18";
            label18.Size = new Size(106, 15);
            label18.TabIndex = 44;
            label18.Text = "Archivos erróneos";
            // 
            // TBUnexportedRecords
            // 
            TBUnexportedRecords.Anchor = AnchorStyles.Left;
            TBUnexportedRecords.BackColor = Color.DimGray;
            TBUnexportedRecords.ForeColor = Color.White;
            TBUnexportedRecords.Location = new Point(136, 55);
            TBUnexportedRecords.Name = "TBUnexportedRecords";
            TBUnexportedRecords.ReadOnly = true;
            TBUnexportedRecords.Size = new Size(161, 22);
            TBUnexportedRecords.TabIndex = 43;
            TBUnexportedRecords.TabStop = false;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(6, 59);
            label17.Name = "label17";
            label17.Size = new Size(128, 15);
            label17.TabIndex = 42;
            label17.Text = "Registros sin exportar";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(311, 7);
            label16.Name = "label16";
            label16.Size = new Size(125, 15);
            label16.TabIndex = 41;
            label16.Text = "Archivos encontrados";
            // 
            // TBFoundFiles
            // 
            TBFoundFiles.Anchor = AnchorStyles.Left;
            TBFoundFiles.BackColor = Color.DimGray;
            TBFoundFiles.ForeColor = Color.White;
            TBFoundFiles.Location = new Point(441, 5);
            TBFoundFiles.Name = "TBFoundFiles";
            TBFoundFiles.ReadOnly = true;
            TBFoundFiles.Size = new Size(161, 22);
            TBFoundFiles.TabIndex = 40;
            TBFoundFiles.TabStop = false;
            // 
            // TBExportedRecords
            // 
            TBExportedRecords.Anchor = AnchorStyles.Left;
            TBExportedRecords.BackColor = Color.DimGray;
            TBExportedRecords.ForeColor = Color.White;
            TBExportedRecords.Location = new Point(136, 29);
            TBExportedRecords.Name = "TBExportedRecords";
            TBExportedRecords.ReadOnly = true;
            TBExportedRecords.Size = new Size(161, 22);
            TBExportedRecords.TabIndex = 39;
            TBExportedRecords.TabStop = false;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(6, 33);
            label15.Name = "label15";
            label15.Size = new Size(125, 15);
            label15.TabIndex = 38;
            label15.Text = "Registros exportados";
            // 
            // TBFoundRecords
            // 
            TBFoundRecords.Anchor = AnchorStyles.Left;
            TBFoundRecords.BackColor = Color.DimGray;
            TBFoundRecords.ForeColor = Color.White;
            TBFoundRecords.Location = new Point(136, 4);
            TBFoundRecords.Name = "TBFoundRecords";
            TBFoundRecords.ReadOnly = true;
            TBFoundRecords.Size = new Size(161, 22);
            TBFoundRecords.TabIndex = 37;
            TBFoundRecords.TabStop = false;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(6, 7);
            label14.Name = "label14";
            label14.Size = new Size(133, 15);
            label14.TabIndex = 36;
            label14.Text = "Registros encontrados";
            // 
            // ButtonUpdateStatus
            // 
            ButtonUpdateStatus.Anchor = AnchorStyles.Right;
            ButtonUpdateStatus.BackColor = Color.Gold;
            ButtonUpdateStatus.FlatStyle = FlatStyle.Flat;
            ButtonUpdateStatus.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonUpdateStatus.Location = new Point(1000, 56);
            ButtonUpdateStatus.Name = "ButtonUpdateStatus";
            ButtonUpdateStatus.Size = new Size(164, 22);
            ButtonUpdateStatus.TabIndex = 35;
            ButtonUpdateStatus.Text = "Actualizar";
            ButtonUpdateStatus.UseVisualStyleBackColor = false;
            ButtonUpdateStatus.Click += ListViewUpdateEvent;
            // 
            // ButtonGenerateSend
            // 
            ButtonGenerateSend.Anchor = AnchorStyles.Right;
            ButtonGenerateSend.BackColor = Color.Gold;
            ButtonGenerateSend.FlatStyle = FlatStyle.Flat;
            ButtonGenerateSend.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonGenerateSend.Location = new Point(1000, 32);
            ButtonGenerateSend.Name = "ButtonGenerateSend";
            ButtonGenerateSend.Size = new Size(164, 22);
            ButtonGenerateSend.TabIndex = 34;
            ButtonGenerateSend.Text = "Generar y enviar";
            ButtonGenerateSend.UseVisualStyleBackColor = false;
            // 
            // ButtonGenerateDocuments
            // 
            ButtonGenerateDocuments.Anchor = AnchorStyles.Right;
            ButtonGenerateDocuments.BackColor = Color.Gold;
            ButtonGenerateDocuments.FlatStyle = FlatStyle.Flat;
            ButtonGenerateDocuments.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonGenerateDocuments.Location = new Point(1000, 8);
            ButtonGenerateDocuments.Name = "ButtonGenerateDocuments";
            ButtonGenerateDocuments.Size = new Size(164, 22);
            ButtonGenerateDocuments.TabIndex = 33;
            ButtonGenerateDocuments.Text = "Generar";
            ButtonGenerateDocuments.UseVisualStyleBackColor = false;
            ButtonGenerateDocuments.Click += BtGenerateDocs;
            // 
            // LVMain
            // 
            LVMain.BackColor = Color.FromArgb(64, 64, 64);
            LVMain.BorderStyle = BorderStyle.FixedSingle;
            LVMain.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader10, columnHeader11, columnHeader12, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            LVMain.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LVMain.ForeColor = Color.White;
            LVMain.FullRowSelect = true;
            LVMain.Location = new Point(0, 0);
            LVMain.Name = "LVMain";
            LVMain.OwnerDraw = true;
            LVMain.Size = new Size(1165, 827);
            LVMain.TabIndex = 6;
            LVMain.UseCompatibleStateImageBehavior = false;
            LVMain.View = View.Details;
            LVMain.DrawColumnHeader += listView1_DrawColumnHeader;
            LVMain.DrawSubItem += listView1_DrawSubItem;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Matrícula";
            columnHeader1.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Boleta de Presentación";
            columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Carta de Inicio";
            columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Kardex";
            columnHeader12.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Apellido Paterno";
            columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Apellido Materno";
            columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Carrera";
            columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Razón Social";
            columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Tipo Actividad Económica";
            columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Descripción Programa";
            columnHeader8.Width = 140;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Departamento Programa";
            columnHeader9.Width = 140;
            // 
            // EmailPanel
            // 
            EmailPanel.AutoScroll = true;
            EmailPanel.BackColor = Color.Transparent;
            EmailPanel.Controls.Add(CBExportFilter);
            EmailPanel.Controls.Add(RBOnlyFolder);
            EmailPanel.Controls.Add(RBSeparatedFolders);
            EmailPanel.Controls.Add(label11);
            EmailPanel.Controls.Add(CLBEmailOptions);
            EmailPanel.Controls.Add(CBEnableSendEmail);
            EmailPanel.Controls.Add(label10);
            EmailPanel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmailPanel.ForeColor = Color.Black;
            EmailPanel.Location = new Point(3, 656);
            EmailPanel.Name = "EmailPanel";
            EmailPanel.Size = new Size(469, 246);
            EmailPanel.TabIndex = 33;
            // 
            // CBExportFilter
            // 
            CBExportFilter.BackColor = Color.DimGray;
            CBExportFilter.Enabled = false;
            CBExportFilter.ForeColor = Color.White;
            CBExportFilter.FormattingEnabled = true;
            CBExportFilter.Items.AddRange(new object[] { "Estudiante", "Carrera", "Dependencia Educativa", "Dependencia Privada", "Responsable", "Coordinador", "Periodo" });
            CBExportFilter.Location = new Point(170, 173);
            CBExportFilter.Name = "CBExportFilter";
            CBExportFilter.Size = new Size(279, 23);
            CBExportFilter.TabIndex = 33;
            // 
            // RBOnlyFolder
            // 
            RBOnlyFolder.AutoSize = true;
            RBOnlyFolder.Checked = true;
            RBOnlyFolder.Location = new Point(11, 196);
            RBOnlyFolder.Name = "RBOnlyFolder";
            RBOnlyFolder.Size = new Size(119, 19);
            RBOnlyFolder.TabIndex = 32;
            RBOnlyFolder.TabStop = true;
            RBOnlyFolder.Text = "Una sola carpeta";
            RBOnlyFolder.UseVisualStyleBackColor = true;
            RBOnlyFolder.CheckedChanged += RBOnlyFolder_CheckedChanged;
            // 
            // RBSeparatedFolders
            // 
            RBSeparatedFolders.AutoSize = true;
            RBSeparatedFolders.Location = new Point(11, 173);
            RBSeparatedFolders.Name = "RBSeparatedFolders";
            RBSeparatedFolders.Size = new Size(163, 19);
            RBSeparatedFolders.TabIndex = 31;
            RBSeparatedFolders.TabStop = true;
            RBSeparatedFolders.Text = "Carpetas separadas por:";
            RBSeparatedFolders.UseVisualStyleBackColor = true;
            RBSeparatedFolders.CheckedChanged += RBSeparatedFolders_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 152);
            label11.Name = "label11";
            label11.Size = new Size(141, 15);
            label11.TabIndex = 30;
            label11.Text = "Carpetas de exportación";
            // 
            // CLBEmailOptions
            // 
            CLBEmailOptions.BackColor = Color.DimGray;
            CLBEmailOptions.Enabled = false;
            CLBEmailOptions.ForeColor = Color.White;
            CLBEmailOptions.FormattingEnabled = true;
            CLBEmailOptions.Items.AddRange(new object[] { "Enviar al estudiante (Correo personal)", "Enviar al estudiante (Correo UANL)", "Envíar al representante", "Enviar al coordinador" });
            CLBEmailOptions.Location = new Point(11, 70);
            CLBEmailOptions.Name = "CLBEmailOptions";
            CLBEmailOptions.Size = new Size(438, 68);
            CLBEmailOptions.TabIndex = 29;
            // 
            // CBEnableSendEmail
            // 
            CBEnableSendEmail.AutoSize = true;
            CBEnableSendEmail.Location = new Point(12, 45);
            CBEnableSendEmail.Name = "CBEnableSendEmail";
            CBEnableSendEmail.Size = new Size(126, 19);
            CBEnableSendEmail.TabIndex = 28;
            CBEnableSendEmail.Text = "Mandar por correo";
            CBEnableSendEmail.UseVisualStyleBackColor = true;
            CBEnableSendEmail.CheckedChanged += CBEnableSendEmail_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(10, 17);
            label10.Name = "label10";
            label10.Size = new Size(187, 14);
            label10.TabIndex = 27;
            label10.Text = "Compartir después de generar";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(LVFormatRepoList);
            panel1.Controls.Add(ButtonCreateDR);
            panel1.Controls.Add(ButtonManageDR);
            panel1.Controls.Add(label26);
            panel1.Controls.Add(CbImportTool);
            panel1.Controls.Add(CBExportEngine);
            panel1.Controls.Add(ButtonDeleteDR);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(ButtonImportDR);
            panel1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 313);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 130);
            label2.Name = "label2";
            label2.Size = new Size(164, 15);
            label2.TabIndex = 47;
            label2.Text = "Lista de repositorio de datos";
            // 
            // LVFormatRepoList
            // 
            LVFormatRepoList.BackColor = Color.DimGray;
            LVFormatRepoList.ForeColor = SystemColors.Window;
            LVFormatRepoList.Location = new Point(13, 148);
            LVFormatRepoList.MultiSelect = false;
            LVFormatRepoList.Name = "LVFormatRepoList";
            LVFormatRepoList.Size = new Size(435, 109);
            LVFormatRepoList.TabIndex = 46;
            LVFormatRepoList.UseCompatibleStateImageBehavior = false;
            LVFormatRepoList.View = View.List;
            // 
            // ButtonCreateDR
            // 
            ButtonCreateDR.BackColor = Color.Gold;
            ButtonCreateDR.FlatStyle = FlatStyle.Flat;
            ButtonCreateDR.ForeColor = Color.Black;
            ButtonCreateDR.Location = new Point(10, 42);
            ButtonCreateDR.Name = "ButtonCreateDR";
            ButtonCreateDR.Size = new Size(101, 33);
            ButtonCreateDR.TabIndex = 45;
            ButtonCreateDR.Text = "Crear";
            ButtonCreateDR.UseVisualStyleBackColor = false;
            ButtonCreateDR.Click += BTCreateDSEvent;
            // 
            // ButtonManageDR
            // 
            ButtonManageDR.BackColor = Color.Gold;
            ButtonManageDR.FlatStyle = FlatStyle.Flat;
            ButtonManageDR.ForeColor = Color.Black;
            ButtonManageDR.Location = new Point(225, 42);
            ButtonManageDR.Name = "ButtonManageDR";
            ButtonManageDR.Size = new Size(116, 34);
            ButtonManageDR.TabIndex = 44;
            ButtonManageDR.Text = "Gestionar";
            ButtonManageDR.UseVisualStyleBackColor = false;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(10, 14);
            label26.Name = "label26";
            label26.Size = new Size(124, 14);
            label26.TabIndex = 43;
            label26.Text = "Datos e Importación";
            // 
            // CbImportTool
            // 
            CbImportTool.BackColor = Color.DimGray;
            CbImportTool.ForeColor = SystemColors.Window;
            CbImportTool.FormattingEnabled = true;
            CbImportTool.Items.AddRange(new object[] { "Microsoft Excel", "Microsoft Access" });
            CbImportTool.Location = new Point(13, 100);
            CbImportTool.Name = "CbImportTool";
            CbImportTool.Size = new Size(435, 23);
            CbImportTool.TabIndex = 42;
            CbImportTool.SelectedIndexChanged += CBSelectedIndexChanged;
            // 
            // CBExportEngine
            // 
            CBExportEngine.BackColor = Color.DimGray;
            CBExportEngine.ForeColor = SystemColors.Window;
            CBExportEngine.FormattingEnabled = true;
            CBExportEngine.Items.AddRange(new object[] { "Microsoft Word", "Aspose PDF" });
            CBExportEngine.Location = new Point(13, 281);
            CBExportEngine.Name = "CBExportEngine";
            CBExportEngine.Size = new Size(435, 23);
            CBExportEngine.TabIndex = 41;
            // 
            // ButtonDeleteDR
            // 
            ButtonDeleteDR.BackColor = Color.Gold;
            ButtonDeleteDR.FlatStyle = FlatStyle.Flat;
            ButtonDeleteDR.ForeColor = Color.Black;
            ButtonDeleteDR.Location = new Point(347, 42);
            ButtonDeleteDR.Name = "ButtonDeleteDR";
            ButtonDeleteDR.Size = new Size(101, 34);
            ButtonDeleteDR.TabIndex = 36;
            ButtonDeleteDR.Text = "Eliminar";
            ButtonDeleteDR.UseVisualStyleBackColor = false;
            ButtonDeleteDR.Click += BTDeleteDS;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(12, 82);
            label23.Name = "label23";
            label23.Size = new Size(268, 15);
            label23.TabIndex = 32;
            label23.Text = "Formato de importación de repositorio de datos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 263);
            label9.Name = "label9";
            label9.Size = new Size(212, 15);
            label9.TabIndex = 16;
            label9.Text = "Motor de exportación de documentos ";
            // 
            // ButtonImportDR
            // 
            ButtonImportDR.BackColor = Color.Gold;
            ButtonImportDR.FlatStyle = FlatStyle.Flat;
            ButtonImportDR.ForeColor = Color.Black;
            ButtonImportDR.Location = new Point(118, 42);
            ButtonImportDR.Name = "ButtonImportDR";
            ButtonImportDR.Size = new Size(101, 34);
            ButtonImportDR.TabIndex = 3;
            ButtonImportDR.Text = "Importar";
            ButtonImportDR.UseVisualStyleBackColor = false;
            ButtonImportDR.Click += ButtonImportFileEvent;
            // 
            // ConfigPanel
            // 
            ConfigPanel.AutoScroll = true;
            ConfigPanel.BackColor = Color.LightGray;
            ConfigPanel.Controls.Add(panel1);
            ConfigPanel.Controls.Add(EmailPanel);
            ConfigPanel.Controls.Add(templatePanel);
            ConfigPanel.Location = new Point(-3, 95);
            ConfigPanel.Name = "ConfigPanel";
            ConfigPanel.Size = new Size(475, 916);
            ConfigPanel.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1664, 1011);
            Controls.Add(ConfigPanel);
            Controls.Add(RegisterPanel);
            Controls.Add(FilterPanel);
            Controls.Add(PanelLogo);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SS UANL Desktop v0.2";
            FilterPanel.ResumeLayout(false);
            FilterPanel.PerformLayout();
            templatePanel.ResumeLayout(false);
            templatePanel.PerformLayout();
            RegisterPanel.ResumeLayout(false);
            InfoPanel.ResumeLayout(false);
            InfoPanel.PerformLayout();
            EmailPanel.ResumeLayout(false);
            EmailPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ConfigPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelLogo;
        private Panel FilterPanel;
        private Label label12;
        private ComboBox CBOptionFilter;
        private RadioButton RBFilterBy;
        private RadioButton RBShowAll;
        private Button BtSearchTerm;
        private TextBox TBSearchFilter;
        private Label label13;
        private Label lblTemplate;
        private ComboBox CBTemplateEngine;
        private Label label1;
        private ComboBox CBCoordinador;
        private ComboBox CBPeriodo;
        private Label label3;
        private CheckBox CBDocEditable;
        private CheckBox CBAccessPassword;
        private Label label4;
        private TextBox TBPassword;
        private Label label5;
        private TextBox TBPasswordConfirm;
        private Label label6;
        private Panel templatePanel;
        private Button button16;
        private Button BTUpdateCoordinador;
        private Panel RegisterPanel;
        private ListView LVMain;
        private Button BTUpdateDepEd;
        private ComboBox CBDepEducativa;
        private Label label22;
        private Panel panel1;
        private Label label9;
        private Button ButtonImportDR;
        private Label label23;
        private Button ButtonDeleteDR;
        private Label label27;
        private Label label26;
        private ComboBox CbImportTool;
        private ComboBox CBExportEngine;
        private Panel EmailPanel;
        private ComboBox CBExportFilter;
        private RadioButton RBOnlyFolder;
        private RadioButton RBSeparatedFolders;
        private Label label11;
        private CheckedListBox CLBEmailOptions;
        private CheckBox CBEnableSendEmail;
        private Label label10;
        private Button BtSettings;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Button BTShowDepEd;
        private Button button13;
        private Button BTShowCoordinador;
        private Label label2;
        private Button ButtonCreateDR;
        private Button ButtonManageDR;
        private ListView LVFormatRepoList;
        private Button button1;
        private Panel InfoPanel;
        private Button BtSubstractPag;
        private Button BtAddPag;
        private Button btNextPag;
        private Button btPrevPag;
        private Label label21;
        private TextBox TBBatchAmmount;
        private Label label20;
        private TextBox TBPagination;
        private TextBox TBCorrectFiles;
        private Label label19;
        private TextBox TBErrorFiles;
        private Label label18;
        private TextBox TBUnexportedRecords;
        private Label label17;
        private Label label16;
        private TextBox TBFoundFiles;
        private TextBox TBExportedRecords;
        private Label label15;
        private TextBox TBFoundRecords;
        private Label label14;
        private Button ButtonUpdateStatus;
        private Button ButtonGenerateSend;
        private Button ButtonGenerateDocuments;
        private Panel ConfigPanel;
        private Button btnMinimize;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
    }
}