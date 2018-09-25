namespace Authorization
{
    partial class ResetPassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassForm));
            this.lblResetEmail = new System.Windows.Forms.Label();
            this.lblResetPass = new System.Windows.Forms.Label();
            this.lblResetRepeatPass = new System.Windows.Forms.Label();
            this.tbResetEmail = new System.Windows.Forms.TextBox();
            this.tbResetPass = new System.Windows.Forms.TextBox();
            this.tbResetRepeatPass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResetEmail
            // 
            this.lblResetEmail.AutoSize = true;
            this.lblResetEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResetEmail.Location = new System.Drawing.Point(6, 16);
            this.lblResetEmail.Name = "lblResetEmail";
            this.lblResetEmail.Size = new System.Drawing.Size(97, 13);
            this.lblResetEmail.TabIndex = 0;
            this.lblResetEmail.Text = "Введите e-mail:";
            // 
            // lblResetPass
            // 
            this.lblResetPass.AutoSize = true;
            this.lblResetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResetPass.Location = new System.Drawing.Point(10, 75);
            this.lblResetPass.Name = "lblResetPass";
            this.lblResetPass.Size = new System.Drawing.Size(96, 13);
            this.lblResetPass.TabIndex = 1;
            this.lblResetPass.Text = "Новый пароль:";
            // 
            // lblResetRepeatPass
            // 
            this.lblResetRepeatPass.AutoSize = true;
            this.lblResetRepeatPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResetRepeatPass.Location = new System.Drawing.Point(10, 150);
            this.lblResetRepeatPass.Name = "lblResetRepeatPass";
            this.lblResetRepeatPass.Size = new System.Drawing.Size(161, 13);
            this.lblResetRepeatPass.TabIndex = 2;
            this.lblResetRepeatPass.Text = "Повторите новый пароль:";
            // 
            // tbResetEmail
            // 
            this.tbResetEmail.Location = new System.Drawing.Point(22, 51);
            this.tbResetEmail.Name = "tbResetEmail";
            this.tbResetEmail.Size = new System.Drawing.Size(241, 20);
            this.tbResetEmail.TabIndex = 3;
            // 
            // tbResetPass
            // 
            this.tbResetPass.Location = new System.Drawing.Point(13, 106);
            this.tbResetPass.Name = "tbResetPass";
            this.tbResetPass.Size = new System.Drawing.Size(238, 20);
            this.tbResetPass.TabIndex = 4;
            this.tbResetPass.PasswordChar = '*';
            // 
            // tbResetRepeatPass
            // 
            this.tbResetRepeatPass.Location = new System.Drawing.Point(13, 180);
            this.tbResetRepeatPass.Name = "tbResetRepeatPass";
            this.tbResetRepeatPass.Size = new System.Drawing.Size(238, 20);
            this.tbResetRepeatPass.TabIndex = 5;
            this.tbResetRepeatPass.PasswordChar = '*';
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbResetRepeatPass);
            this.groupBox1.Controls.Add(this.lblResetEmail);
            this.groupBox1.Controls.Add(this.lblResetPass);
            this.groupBox1.Controls.Add(this.tbResetPass);
            this.groupBox1.Controls.Add(this.lblResetRepeatPass);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 224);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(95, 239);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ResetPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(284, 270);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbResetEmail);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                Восстановление пароля";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResetEmail;
        private System.Windows.Forms.Label lblResetPass;
        private System.Windows.Forms.Label lblResetRepeatPass;
        private System.Windows.Forms.TextBox tbResetEmail;
        private System.Windows.Forms.TextBox tbResetPass;
        private System.Windows.Forms.TextBox tbResetRepeatPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}