namespace uanl_ss_main_ui
{
    partial class VistaProgreso
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
            this.CompleteProgressBar = new System.Windows.Forms.ProgressBar();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.lblBoletaActual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CompleteProgressBar
            // 
            this.CompleteProgressBar.Location = new System.Drawing.Point(12, 77);
            this.CompleteProgressBar.Name = "CompleteProgressBar";
            this.CompleteProgressBar.Size = new System.Drawing.Size(506, 21);
            this.CompleteProgressBar.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 104);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(506, 21);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.ButtonCancelClicked);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(364, 14);
            this.label23.TabIndex = 33;
            this.label23.Text = "Realizando exportación, por favor espere a que termine el proceso.\r\n";
            // 
            // lblBoletaActual
            // 
            this.lblBoletaActual.AutoSize = true;
            this.lblBoletaActual.Location = new System.Drawing.Point(12, 47);
            this.lblBoletaActual.Name = "lblBoletaActual";
            this.lblBoletaActual.Size = new System.Drawing.Size(74, 14);
            this.lblBoletaActual.TabIndex = 34;
            this.lblBoletaActual.Text = "Registrando ";
            // 
            // VistaProgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 138);
            this.ControlBox = false;
            this.Controls.Add(this.lblBoletaActual);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.CompleteProgressBar);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VistaProgreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesando...";
            this.Load += new System.EventHandler(this.VistaProgresoLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ProgressBar CompleteProgressBar;
        public Button btnCancelar;
        public Label label23;
        public Label lblBoletaActual;
    }
}