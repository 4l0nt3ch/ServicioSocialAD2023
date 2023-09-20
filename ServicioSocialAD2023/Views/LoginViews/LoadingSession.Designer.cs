namespace uanl_ss_main_ui.Views.LoginViews
{
    partial class LoadingSession
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
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 18);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(68, 15);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Cargando...";
            // 
            // LoadingSession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 108);
            ControlBox = false;
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoadingSession";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cargando";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblStatus;
    }
}