namespace Authorization
{
    partial class MainWindowAppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowAppForm));
            this.lblEnterSystem = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.tbMainWPersonalData = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterSystem
            // 
            this.lblEnterSystem.AutoSize = true;
            this.lblEnterSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnterSystem.Location = new System.Drawing.Point(12, 22);
            this.lblEnterSystem.Name = "lblEnterSystem";
            this.lblEnterSystem.Size = new System.Drawing.Size(181, 20);
            this.lblEnterSystem.TabIndex = 0;
            this.lblEnterSystem.Text = "Вы вошли в систему";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(16, 46);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(78, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Ваши данные:";
            // 
            // tbMainWPersonalData
            // 
            this.tbMainWPersonalData.Location = new System.Drawing.Point(19, 73);
            this.tbMainWPersonalData.Multiline = true;
            this.tbMainWPersonalData.Name = "tbMainWPersonalData";
            this.tbMainWPersonalData.Size = new System.Drawing.Size(174, 137);
            this.tbMainWPersonalData.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Authorization.Properties.Resources.fun;
            this.pictureBox1.Location = new System.Drawing.Point(252, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindowAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(553, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbMainWPersonalData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblEnterSystem);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindowAppForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "                                                         Главное окно приложения";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterSystem;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox tbMainWPersonalData;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}