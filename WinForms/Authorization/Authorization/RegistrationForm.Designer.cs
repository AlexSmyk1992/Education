namespace Authorization
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.grbAuthInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStar1 = new System.Windows.Forms.Label();
            this.lblRegRepeatPass = new System.Windows.Forms.Label();
            this.lbRegPass = new System.Windows.Forms.Label();
            this.lbRegLogin = new System.Windows.Forms.Label();
            this.tbRegRepeatPas = new System.Windows.Forms.TextBox();
            this.tbRegPass = new System.Windows.Forms.TextBox();
            this.tbRegLogin = new System.Windows.Forms.TextBox();
            this.grbAuthPersonalData = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRegEmail = new System.Windows.Forms.Label();
            this.tbRegSurname = new System.Windows.Forms.TextBox();
            this.lblRegName = new System.Windows.Forms.Label();
            this.tbRegName = new System.Windows.Forms.TextBox();
            this.lblRegSurname = new System.Windows.Forms.Label();
            this.tbRegEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegOk = new System.Windows.Forms.Button();
            this.btnRegCancel = new System.Windows.Forms.Button();
            this.grbAuthInfo.SuspendLayout();
            this.grbAuthPersonalData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAuthInfo
            // 
            this.grbAuthInfo.Controls.Add(this.label2);
            this.grbAuthInfo.Controls.Add(this.label1);
            this.grbAuthInfo.Controls.Add(this.lbStar1);
            this.grbAuthInfo.Controls.Add(this.lblRegRepeatPass);
            this.grbAuthInfo.Controls.Add(this.lbRegPass);
            this.grbAuthInfo.Controls.Add(this.lbRegLogin);
            this.grbAuthInfo.Controls.Add(this.tbRegRepeatPas);
            this.grbAuthInfo.Controls.Add(this.tbRegPass);
            this.grbAuthInfo.Controls.Add(this.tbRegLogin);
            this.grbAuthInfo.Location = new System.Drawing.Point(12, 12);
            this.grbAuthInfo.Name = "grbAuthInfo";
            this.grbAuthInfo.Size = new System.Drawing.Size(296, 176);
            this.grbAuthInfo.TabIndex = 0;
            this.grbAuthInfo.TabStop = false;
            this.grbAuthInfo.Text = "Информация авторизации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(260, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(260, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "*";
            // 
            // lbStar1
            // 
            this.lbStar1.AutoSize = true;
            this.lbStar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStar1.ForeColor = System.Drawing.Color.Red;
            this.lbStar1.Location = new System.Drawing.Point(260, 40);
            this.lbStar1.Name = "lbStar1";
            this.lbStar1.Size = new System.Drawing.Size(16, 20);
            this.lbStar1.TabIndex = 6;
            this.lbStar1.Text = "*";
            // 
            // lblRegRepeatPass
            // 
            this.lblRegRepeatPass.AutoSize = true;
            this.lblRegRepeatPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegRepeatPass.Location = new System.Drawing.Point(7, 116);
            this.lblRegRepeatPass.Name = "lblRegRepeatPass";
            this.lblRegRepeatPass.Size = new System.Drawing.Size(120, 13);
            this.lblRegRepeatPass.TabIndex = 5;
            this.lblRegRepeatPass.Text = "Повторите пароль:";
            // 
            // lbRegPass
            // 
            this.lbRegPass.AutoSize = true;
            this.lbRegPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRegPass.Location = new System.Drawing.Point(7, 68);
            this.lbRegPass.Name = "lbRegPass";
            this.lbRegPass.Size = new System.Drawing.Size(55, 13);
            this.lbRegPass.TabIndex = 4;
            this.lbRegPass.Text = "Пароль:";
            // 
            // lbRegLogin
            // 
            this.lbRegLogin.AutoSize = true;
            this.lbRegLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRegLogin.Location = new System.Drawing.Point(7, 24);
            this.lbRegLogin.Name = "lbRegLogin";
            this.lbRegLogin.Size = new System.Drawing.Size(47, 13);
            this.lbRegLogin.TabIndex = 3;
            this.lbRegLogin.Text = "Логин:";
            // 
            // tbRegRepeatPas
            // 
            this.tbRegRepeatPas.Location = new System.Drawing.Point(6, 132);
            this.tbRegRepeatPas.Name = "tbRegRepeatPas";
            this.tbRegRepeatPas.Size = new System.Drawing.Size(247, 20);
            this.tbRegRepeatPas.TabIndex = 2;
            // 
            // tbRegPass
            // 
            this.tbRegPass.Location = new System.Drawing.Point(6, 84);
            this.tbRegPass.Name = "tbRegPass";
            this.tbRegPass.Size = new System.Drawing.Size(247, 20);
            this.tbRegPass.TabIndex = 1;
            // 
            // tbRegLogin
            // 
            this.tbRegLogin.Location = new System.Drawing.Point(7, 40);
            this.tbRegLogin.Name = "tbRegLogin";
            this.tbRegLogin.Size = new System.Drawing.Size(247, 20);
            this.tbRegLogin.TabIndex = 0;
            // 
            // grbAuthPersonalData
            // 
            this.grbAuthPersonalData.Controls.Add(this.label6);
            this.grbAuthPersonalData.Controls.Add(this.lblRegEmail);
            this.grbAuthPersonalData.Controls.Add(this.tbRegSurname);
            this.grbAuthPersonalData.Controls.Add(this.lblRegName);
            this.grbAuthPersonalData.Controls.Add(this.tbRegName);
            this.grbAuthPersonalData.Controls.Add(this.lblRegSurname);
            this.grbAuthPersonalData.Controls.Add(this.tbRegEmail);
            this.grbAuthPersonalData.Location = new System.Drawing.Point(327, 12);
            this.grbAuthPersonalData.Name = "grbAuthPersonalData";
            this.grbAuthPersonalData.Size = new System.Drawing.Size(307, 176);
            this.grbAuthPersonalData.TabIndex = 1;
            this.grbAuthPersonalData.TabStop = false;
            this.grbAuthPersonalData.Text = "Личные данные";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(258, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "*";
            // 
            // lblRegEmail
            // 
            this.lblRegEmail.AutoSize = true;
            this.lblRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegEmail.Location = new System.Drawing.Point(6, 118);
            this.lblRegEmail.Name = "lblRegEmail";
            this.lblRegEmail.Size = new System.Drawing.Size(44, 13);
            this.lblRegEmail.TabIndex = 14;
            this.lblRegEmail.Text = "e-mail:";
            // 
            // tbRegSurname
            // 
            this.tbRegSurname.Location = new System.Drawing.Point(6, 42);
            this.tbRegSurname.Name = "tbRegSurname";
            this.tbRegSurname.Size = new System.Drawing.Size(247, 20);
            this.tbRegSurname.TabIndex = 9;
            // 
            // lblRegName
            // 
            this.lblRegName.AutoSize = true;
            this.lblRegName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegName.Location = new System.Drawing.Point(6, 70);
            this.lblRegName.Name = "lblRegName";
            this.lblRegName.Size = new System.Drawing.Size(36, 13);
            this.lblRegName.TabIndex = 13;
            this.lblRegName.Text = "Имя:";
            // 
            // tbRegName
            // 
            this.tbRegName.Location = new System.Drawing.Point(5, 86);
            this.tbRegName.Name = "tbRegName";
            this.tbRegName.Size = new System.Drawing.Size(247, 20);
            this.tbRegName.TabIndex = 10;
            // 
            // lblRegSurname
            // 
            this.lblRegSurname.AutoSize = true;
            this.lblRegSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegSurname.Location = new System.Drawing.Point(6, 26);
            this.lblRegSurname.Name = "lblRegSurname";
            this.lblRegSurname.Size = new System.Drawing.Size(67, 13);
            this.lblRegSurname.TabIndex = 12;
            this.lblRegSurname.Text = "Фамилия:";
            // 
            // tbRegEmail
            // 
            this.tbRegEmail.Location = new System.Drawing.Point(5, 134);
            this.tbRegEmail.Name = "tbRegEmail";
            this.tbRegEmail.Size = new System.Drawing.Size(247, 20);
            this.tbRegEmail.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(18, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "* - поля для обязательного заполнения";
            // 
            // btnRegOk
            // 
            this.btnRegOk.Location = new System.Drawing.Point(478, 204);
            this.btnRegOk.Name = "btnRegOk";
            this.btnRegOk.Size = new System.Drawing.Size(75, 23);
            this.btnRegOk.TabIndex = 10;
            this.btnRegOk.Text = "OK";
            this.btnRegOk.UseVisualStyleBackColor = true;
            this.btnRegOk.Click += new System.EventHandler(this.btnRegOk_Click);
            // 
            // btnRegCancel
            // 
            this.btnRegCancel.Location = new System.Drawing.Point(559, 204);
            this.btnRegCancel.Name = "btnRegCancel";
            this.btnRegCancel.Size = new System.Drawing.Size(75, 23);
            this.btnRegCancel.TabIndex = 11;
            this.btnRegCancel.Text = "Отмена";
            this.btnRegCancel.UseVisualStyleBackColor = true;
            this.btnRegCancel.Click += new System.EventHandler(this.btnRegCancel_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(646, 233);
            this.Controls.Add(this.btnRegCancel);
            this.Controls.Add(this.btnRegOk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grbAuthPersonalData);
            this.Controls.Add(this.grbAuthInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                    Регистрация н" +
    "ового пользователя";
            this.grbAuthInfo.ResumeLayout(false);
            this.grbAuthInfo.PerformLayout();
            this.grbAuthPersonalData.ResumeLayout(false);
            this.grbAuthPersonalData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAuthInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStar1;
        private System.Windows.Forms.Label lblRegRepeatPass;
        private System.Windows.Forms.Label lbRegPass;
        private System.Windows.Forms.Label lbRegLogin;
        private System.Windows.Forms.TextBox tbRegRepeatPas;
        private System.Windows.Forms.TextBox tbRegPass;
        private System.Windows.Forms.TextBox tbRegLogin;
        private System.Windows.Forms.GroupBox grbAuthPersonalData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRegEmail;
        private System.Windows.Forms.TextBox tbRegSurname;
        private System.Windows.Forms.Label lblRegName;
        private System.Windows.Forms.TextBox tbRegName;
        private System.Windows.Forms.Label lblRegSurname;
        private System.Windows.Forms.TextBox tbRegEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegOk;
        private System.Windows.Forms.Button btnRegCancel;
    }
}