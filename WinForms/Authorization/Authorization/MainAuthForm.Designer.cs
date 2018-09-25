namespace Authorization
{
    partial class MainAuthForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAuthForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lnkLbForgotPass = new System.Windows.Forms.LinkLabel();
            this.lnkLbRegirstration = new System.Windows.Forms.LinkLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbChecking = new System.Windows.Forms.Label();
            this.lbWrongData = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Tan;
            this.groupBox2.Controls.Add(this.tbPassword);
            this.groupBox2.Controls.Add(this.tbUserName);
            this.groupBox2.Controls.Add(this.btnEnter);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(265, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 200);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры авторизации";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPassword.Location = new System.Drawing.Point(7, 102);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(222, 19);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.Text = "Пароль";
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbUserName.Location = new System.Drawing.Point(7, 49);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(222, 19);
            this.tbUserName.TabIndex = 4;
            this.tbUserName.Text = "Имя пользователя";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(154, 171);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lnkLbForgotPass
            // 
            this.lnkLbForgotPass.AutoSize = true;
            this.lnkLbForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkLbForgotPass.Location = new System.Drawing.Point(22, 234);
            this.lnkLbForgotPass.Name = "lnkLbForgotPass";
            this.lnkLbForgotPass.Size = new System.Drawing.Size(115, 16);
            this.lnkLbForgotPass.TabIndex = 3;
            this.lnkLbForgotPass.TabStop = true;
            this.lnkLbForgotPass.Text = "Забыли пароль?";
            this.lnkLbForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLbForgotPass_LinkClicked);
            // 
            // lnkLbRegirstration
            // 
            this.lnkLbRegirstration.AutoSize = true;
            this.lnkLbRegirstration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkLbRegirstration.Location = new System.Drawing.Point(402, 234);
            this.lnkLbRegirstration.Name = "lnkLbRegirstration";
            this.lnkLbRegirstration.Size = new System.Drawing.Size(92, 16);
            this.lnkLbRegirstration.TabIndex = 4;
            this.lnkLbRegirstration.TabStop = true;
            this.lnkLbRegirstration.Text = "Регистрация";
            this.lnkLbRegirstration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLbRegirstration_LinkClicked);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(144, 216);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(226, 31);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbChecking
            // 
            this.lbChecking.AutoSize = true;
            this.lbChecking.BackColor = System.Drawing.Color.Brown;
            this.lbChecking.ForeColor = System.Drawing.Color.Linen;
            this.lbChecking.Location = new System.Drawing.Point(210, 225);
            this.lbChecking.Name = "lbChecking";
            this.lbChecking.Size = new System.Drawing.Size(92, 13);
            this.lbChecking.TabIndex = 6;
            this.lbChecking.Text = "Идет проверка...";
            this.lbChecking.Visible = false;
            // 
            // lbWrongData
            // 
            this.lbWrongData.AutoSize = true;
            this.lbWrongData.BackColor = System.Drawing.Color.Brown;
            this.lbWrongData.ForeColor = System.Drawing.Color.Linen;
            this.lbWrongData.Location = new System.Drawing.Point(174, 225);
            this.lbWrongData.Name = "lbWrongData";
            this.lbWrongData.Size = new System.Drawing.Size(162, 13);
            this.lbWrongData.TabIndex = 7;
            this.lbWrongData.Text = "Проверьте введенные данные";
            this.lbWrongData.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Authorization.Properties.Resources.Key;
            this.pictureBox1.Location = new System.Drawing.Point(22, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainAuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(509, 259);
            this.Controls.Add(this.lbWrongData);
            this.Controls.Add(this.lbChecking);
            this.Controls.Add(this.lnkLbRegirstration);
            this.Controls.Add(this.lnkLbForgotPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainAuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = " ";
            this.Text = "                                                                Авторизация...";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.LinkLabel lnkLbForgotPass;
        private System.Windows.Forms.LinkLabel lnkLbRegirstration;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbChecking;
        private System.Windows.Forms.Label lbWrongData;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
    }
}

