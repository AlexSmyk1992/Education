namespace BestOil
{
    partial class Form1
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
            this.cmb_TypeOfOil = new System.Windows.Forms.ComboBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.lbl_Petrol = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.rb_Count = new System.Windows.Forms.RadioButton();
            this.rb_Sum = new System.Windows.Forms.RadioButton();
            this.tb_Count = new System.Windows.Forms.TextBox();
            this.tb_Sum = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.chk_HotDog = new System.Windows.Forms.CheckBox();
            this.chk_Hamburger = new System.Windows.Forms.CheckBox();
            this.chk_Cheeseburger = new System.Windows.Forms.CheckBox();
            this.chk_CocaCola = new System.Windows.Forms.CheckBox();
            this.lbl_Price1 = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.tb_HotDogPrice = new System.Windows.Forms.TextBox();
            this.tb_HotDogCount = new System.Windows.Forms.TextBox();
            this.lbl2_Rub = new System.Windows.Forms.Label();
            this.lbl3_Rub = new System.Windows.Forms.Label();
            this.tb_HamburgerCount = new System.Windows.Forms.TextBox();
            this.tb_HamburgerPrice = new System.Windows.Forms.TextBox();
            this.lbl4_Rub = new System.Windows.Forms.Label();
            this.tb_CheesburgerCount = new System.Windows.Forms.TextBox();
            this.tb_CheesburgerPrice = new System.Windows.Forms.TextBox();
            this.lbl5_Rub = new System.Windows.Forms.Label();
            this.tb_CocaColaCount = new System.Windows.Forms.TextBox();
            this.tb_CocaColaPrice = new System.Windows.Forms.TextBox();
            this.lbl_Rub = new System.Windows.Forms.Label();
            this.lbl_ToPayCafe = new System.Windows.Forms.Label();
            this.lbl_Litres = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl1_Rub = new System.Windows.Forms.Label();
            this.tb_ToPayPetrol = new System.Windows.Forms.TextBox();
            this.tb_ToPayCafe = new System.Windows.Forms.TextBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_ToPayPetrol = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_TypeOfOil
            // 
            this.cmb_TypeOfOil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TypeOfOil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_TypeOfOil.FormattingEnabled = true;
            this.cmb_TypeOfOil.Items.AddRange(new object[] {
            "АИ-98",
            "АИ-95",
            "АИ-92",
            "ДТ"});
            this.cmb_TypeOfOil.Location = new System.Drawing.Point(80, 41);
            this.cmb_TypeOfOil.Name = "cmb_TypeOfOil";
            this.cmb_TypeOfOil.Size = new System.Drawing.Size(121, 21);
            this.cmb_TypeOfOil.TabIndex = 1;
            this.cmb_TypeOfOil.SelectedIndexChanged += new System.EventHandler(this.TypeOfOil_SelectedIndexChanged);
            // 
            // tb_Price
            // 
            this.tb_Price.Location = new System.Drawing.Point(80, 109);
            this.tb_Price.Multiline = true;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.ReadOnly = true;
            this.tb_Price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_Price.Size = new System.Drawing.Size(121, 20);
            this.tb_Price.TabIndex = 2;
            this.tb_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Petrol
            // 
            this.lbl_Petrol.AutoSize = true;
            this.lbl_Petrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Petrol.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Petrol.Location = new System.Drawing.Point(29, 44);
            this.lbl_Petrol.Name = "lbl_Petrol";
            this.lbl_Petrol.Size = new System.Drawing.Size(50, 13);
            this.lbl_Petrol.TabIndex = 3;
            this.lbl_Petrol.Text = "Бензин";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Price.ForeColor = System.Drawing.Color.Red;
            this.lbl_Price.Location = new System.Drawing.Point(29, 112);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(37, 13);
            this.lbl_Price.TabIndex = 4;
            this.lbl_Price.Text = "Цена";
            // 
            // rb_Count
            // 
            this.rb_Count.AutoSize = true;
            this.rb_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Count.Location = new System.Drawing.Point(16, 162);
            this.rb_Count.Name = "rb_Count";
            this.rb_Count.Size = new System.Drawing.Size(94, 17);
            this.rb_Count.TabIndex = 5;
            this.rb_Count.Text = "Количество";
            this.rb_Count.UseVisualStyleBackColor = true;
            this.rb_Count.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_Sum
            // 
            this.rb_Sum.AutoSize = true;
            this.rb_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Sum.Location = new System.Drawing.Point(16, 199);
            this.rb_Sum.Name = "rb_Sum";
            this.rb_Sum.Size = new System.Drawing.Size(64, 17);
            this.rb_Sum.TabIndex = 6;
            this.rb_Sum.Text = "Сумма";
            this.rb_Sum.UseVisualStyleBackColor = true;
            // 
            // tb_Count
            // 
            this.tb_Count.Location = new System.Drawing.Point(107, 162);
            this.tb_Count.Name = "tb_Count";
            this.tb_Count.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_Count.Size = new System.Drawing.Size(100, 20);
            this.tb_Count.TabIndex = 7;
            this.tb_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Count.TextChanged += new System.EventHandler(this.tb_Count_TextChanged);
            // 
            // tb_Sum
            // 
            this.tb_Sum.Location = new System.Drawing.Point(107, 198);
            this.tb_Sum.Name = "tb_Sum";
            this.tb_Sum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_Sum.Size = new System.Drawing.Size(100, 20);
            this.tb_Sum.TabIndex = 8;
            this.tb_Sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Sum.TextChanged += new System.EventHandler(this.tb_Sum_TextChanged);
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.FlatAppearance.BorderSize = 5;
            this.btn_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Calculate.ForeColor = System.Drawing.Color.Red;
            this.btn_Calculate.Location = new System.Drawing.Point(125, 343);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(146, 56);
            this.btn_Calculate.TabIndex = 12;
            this.btn_Calculate.Text = "Рассчитать";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // chk_HotDog
            // 
            this.chk_HotDog.AutoSize = true;
            this.chk_HotDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_HotDog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chk_HotDog.Location = new System.Drawing.Point(6, 72);
            this.chk_HotDog.Name = "chk_HotDog";
            this.chk_HotDog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_HotDog.Size = new System.Drawing.Size(71, 17);
            this.chk_HotDog.TabIndex = 15;
            this.chk_HotDog.Text = "Хот-дог";
            this.chk_HotDog.UseVisualStyleBackColor = true;
            this.chk_HotDog.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.chk_HotDog.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chk_Hamburger
            // 
            this.chk_Hamburger.AutoSize = true;
            this.chk_Hamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_Hamburger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chk_Hamburger.Location = new System.Drawing.Point(6, 100);
            this.chk_Hamburger.Name = "chk_Hamburger";
            this.chk_Hamburger.Size = new System.Drawing.Size(89, 17);
            this.chk_Hamburger.TabIndex = 16;
            this.chk_Hamburger.Text = "Гамбургер";
            this.chk_Hamburger.UseVisualStyleBackColor = true;
            this.chk_Hamburger.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.chk_Hamburger.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chk_Cheeseburger
            // 
            this.chk_Cheeseburger.AutoSize = true;
            this.chk_Cheeseburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_Cheeseburger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chk_Cheeseburger.Location = new System.Drawing.Point(6, 127);
            this.chk_Cheeseburger.Name = "chk_Cheeseburger";
            this.chk_Cheeseburger.Size = new System.Drawing.Size(89, 17);
            this.chk_Cheeseburger.TabIndex = 17;
            this.chk_Cheeseburger.Text = "Чизбургер";
            this.chk_Cheeseburger.UseVisualStyleBackColor = true;
            this.chk_Cheeseburger.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.chk_Cheeseburger.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chk_CocaCola
            // 
            this.chk_CocaCola.AutoSize = true;
            this.chk_CocaCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_CocaCola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chk_CocaCola.Location = new System.Drawing.Point(6, 150);
            this.chk_CocaCola.Name = "chk_CocaCola";
            this.chk_CocaCola.Size = new System.Drawing.Size(87, 17);
            this.chk_CocaCola.TabIndex = 18;
            this.chk_CocaCola.Text = "Кока-кола";
            this.chk_CocaCola.UseVisualStyleBackColor = true;
            this.chk_CocaCola.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.chk_CocaCola.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbl_Price1
            // 
            this.lbl_Price1.AutoSize = true;
            this.lbl_Price1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Price1.ForeColor = System.Drawing.Color.Red;
            this.lbl_Price1.Location = new System.Drawing.Point(152, 52);
            this.lbl_Price1.Name = "lbl_Price1";
            this.lbl_Price1.Size = new System.Drawing.Size(37, 13);
            this.lbl_Price1.TabIndex = 19;
            this.lbl_Price1.Text = "Цена";
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Count.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Count.Location = new System.Drawing.Point(219, 52);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(76, 13);
            this.lbl_Count.TabIndex = 20;
            this.lbl_Count.Text = "Количество";
            // 
            // tb_HotDogPrice
            // 
            this.tb_HotDogPrice.Enabled = false;
            this.tb_HotDogPrice.Location = new System.Drawing.Point(108, 70);
            this.tb_HotDogPrice.Name = "tb_HotDogPrice";
            this.tb_HotDogPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_HotDogPrice.Size = new System.Drawing.Size(75, 20);
            this.tb_HotDogPrice.TabIndex = 21;
            this.tb_HotDogPrice.Text = "5";
            // 
            // tb_HotDogCount
            // 
            this.tb_HotDogCount.Location = new System.Drawing.Point(222, 70);
            this.tb_HotDogCount.Name = "tb_HotDogCount";
            this.tb_HotDogCount.Size = new System.Drawing.Size(63, 20);
            this.tb_HotDogCount.TabIndex = 22;
            this.tb_HotDogCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_HotDogCount.TextChanged += new System.EventHandler(this.tb_HotDogCount_TextChanged);
            // 
            // lbl2_Rub
            // 
            this.lbl2_Rub.AutoSize = true;
            this.lbl2_Rub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2_Rub.ForeColor = System.Drawing.Color.Red;
            this.lbl2_Rub.Location = new System.Drawing.Point(189, 74);
            this.lbl2_Rub.Name = "lbl2_Rub";
            this.lbl2_Rub.Size = new System.Drawing.Size(31, 13);
            this.lbl2_Rub.TabIndex = 23;
            this.lbl2_Rub.Text = "руб.";
            // 
            // lbl3_Rub
            // 
            this.lbl3_Rub.AutoSize = true;
            this.lbl3_Rub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3_Rub.ForeColor = System.Drawing.Color.Red;
            this.lbl3_Rub.Location = new System.Drawing.Point(189, 100);
            this.lbl3_Rub.Name = "lbl3_Rub";
            this.lbl3_Rub.Size = new System.Drawing.Size(31, 13);
            this.lbl3_Rub.TabIndex = 26;
            this.lbl3_Rub.Text = "руб.";
            // 
            // tb_HamburgerCount
            // 
            this.tb_HamburgerCount.Location = new System.Drawing.Point(222, 96);
            this.tb_HamburgerCount.Name = "tb_HamburgerCount";
            this.tb_HamburgerCount.Size = new System.Drawing.Size(63, 20);
            this.tb_HamburgerCount.TabIndex = 25;
            this.tb_HamburgerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_HamburgerCount.TextChanged += new System.EventHandler(this.tb_HamburgerCount_TextChanged);
            // 
            // tb_HamburgerPrice
            // 
            this.tb_HamburgerPrice.Enabled = false;
            this.tb_HamburgerPrice.Location = new System.Drawing.Point(108, 96);
            this.tb_HamburgerPrice.Name = "tb_HamburgerPrice";
            this.tb_HamburgerPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_HamburgerPrice.Size = new System.Drawing.Size(75, 20);
            this.tb_HamburgerPrice.TabIndex = 24;
            this.tb_HamburgerPrice.Text = "4";
            // 
            // lbl4_Rub
            // 
            this.lbl4_Rub.AutoSize = true;
            this.lbl4_Rub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl4_Rub.ForeColor = System.Drawing.Color.Red;
            this.lbl4_Rub.Location = new System.Drawing.Point(189, 126);
            this.lbl4_Rub.Name = "lbl4_Rub";
            this.lbl4_Rub.Size = new System.Drawing.Size(31, 13);
            this.lbl4_Rub.TabIndex = 29;
            this.lbl4_Rub.Text = "руб.";
            // 
            // tb_CheesburgerCount
            // 
            this.tb_CheesburgerCount.Location = new System.Drawing.Point(222, 122);
            this.tb_CheesburgerCount.Name = "tb_CheesburgerCount";
            this.tb_CheesburgerCount.Size = new System.Drawing.Size(63, 20);
            this.tb_CheesburgerCount.TabIndex = 28;
            this.tb_CheesburgerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_CheesburgerCount.TextChanged += new System.EventHandler(this.tb_CheesburgerCount_TextChanged);
            // 
            // tb_CheesburgerPrice
            // 
            this.tb_CheesburgerPrice.Enabled = false;
            this.tb_CheesburgerPrice.Location = new System.Drawing.Point(108, 122);
            this.tb_CheesburgerPrice.Name = "tb_CheesburgerPrice";
            this.tb_CheesburgerPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_CheesburgerPrice.Size = new System.Drawing.Size(75, 20);
            this.tb_CheesburgerPrice.TabIndex = 27;
            this.tb_CheesburgerPrice.Text = "6";
            // 
            // lbl5_Rub
            // 
            this.lbl5_Rub.AutoSize = true;
            this.lbl5_Rub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl5_Rub.ForeColor = System.Drawing.Color.Red;
            this.lbl5_Rub.Location = new System.Drawing.Point(189, 152);
            this.lbl5_Rub.Name = "lbl5_Rub";
            this.lbl5_Rub.Size = new System.Drawing.Size(31, 13);
            this.lbl5_Rub.TabIndex = 32;
            this.lbl5_Rub.Text = "руб.";
            // 
            // tb_CocaColaCount
            // 
            this.tb_CocaColaCount.Location = new System.Drawing.Point(222, 148);
            this.tb_CocaColaCount.Name = "tb_CocaColaCount";
            this.tb_CocaColaCount.Size = new System.Drawing.Size(63, 20);
            this.tb_CocaColaCount.TabIndex = 31;
            this.tb_CocaColaCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_CocaColaCount.TextChanged += new System.EventHandler(this.tb_CocaColaCount_TextChanged);
            // 
            // tb_CocaColaPrice
            // 
            this.tb_CocaColaPrice.Enabled = false;
            this.tb_CocaColaPrice.Location = new System.Drawing.Point(108, 148);
            this.tb_CocaColaPrice.Name = "tb_CocaColaPrice";
            this.tb_CocaColaPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_CocaColaPrice.Size = new System.Drawing.Size(75, 20);
            this.tb_CocaColaPrice.TabIndex = 30;
            this.tb_CocaColaPrice.Text = "4,5";
            // 
            // lbl_Rub
            // 
            this.lbl_Rub.AutoSize = true;
            this.lbl_Rub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Rub.ForeColor = System.Drawing.Color.Red;
            this.lbl_Rub.Location = new System.Drawing.Point(207, 116);
            this.lbl_Rub.Name = "lbl_Rub";
            this.lbl_Rub.Size = new System.Drawing.Size(31, 13);
            this.lbl_Rub.TabIndex = 33;
            this.lbl_Rub.Text = "руб.";
            // 
            // lbl_ToPayCafe
            // 
            this.lbl_ToPayCafe.AutoSize = true;
            this.lbl_ToPayCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ToPayCafe.Location = new System.Drawing.Point(340, 237);
            this.lbl_ToPayCafe.Name = "lbl_ToPayCafe";
            this.lbl_ToPayCafe.Size = new System.Drawing.Size(60, 13);
            this.lbl_ToPayCafe.TabIndex = 34;
            this.lbl_ToPayCafe.Text = "К оплате";
            // 
            // lbl_Litres
            // 
            this.lbl_Litres.AutoSize = true;
            this.lbl_Litres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Litres.Location = new System.Drawing.Point(213, 169);
            this.lbl_Litres.Name = "lbl_Litres";
            this.lbl_Litres.Size = new System.Drawing.Size(18, 13);
            this.lbl_Litres.TabIndex = 36;
            this.lbl_Litres.Text = "л.";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Total.Location = new System.Drawing.Point(291, 357);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(90, 25);
            this.lbl_Total.TabIndex = 37;
            this.lbl_Total.Text = "ИТОГО:";
            // 
            // lbl1_Rub
            // 
            this.lbl1_Rub.AutoSize = true;
            this.lbl1_Rub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1_Rub.Location = new System.Drawing.Point(213, 205);
            this.lbl1_Rub.Name = "lbl1_Rub";
            this.lbl1_Rub.Size = new System.Drawing.Size(31, 13);
            this.lbl1_Rub.TabIndex = 39;
            this.lbl1_Rub.Text = "руб.";
            // 
            // tb_ToPayPetrol
            // 
            this.tb_ToPayPetrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ToPayPetrol.Location = new System.Drawing.Point(58, 255);
            this.tb_ToPayPetrol.Multiline = true;
            this.tb_ToPayPetrol.Name = "tb_ToPayPetrol";
            this.tb_ToPayPetrol.Size = new System.Drawing.Size(249, 63);
            this.tb_ToPayPetrol.TabIndex = 40;
            this.tb_ToPayPetrol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_ToPayCafe
            // 
            this.tb_ToPayCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ToPayCafe.Location = new System.Drawing.Point(358, 255);
            this.tb_ToPayCafe.Multiline = true;
            this.tb_ToPayCafe.Name = "tb_ToPayCafe";
            this.tb_ToPayCafe.Size = new System.Drawing.Size(249, 63);
            this.tb_ToPayCafe.TabIndex = 41;
            this.tb_ToPayCafe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_Total
            // 
            this.tb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Total.Location = new System.Drawing.Point(381, 343);
            this.tb_Total.Multiline = true;
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(249, 63);
            this.tb_Total.TabIndex = 42;
            this.tb_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_HotDog);
            this.groupBox1.Controls.Add(this.chk_Hamburger);
            this.groupBox1.Controls.Add(this.chk_Cheeseburger);
            this.groupBox1.Controls.Add(this.chk_CocaCola);
            this.groupBox1.Controls.Add(this.lbl_Price1);
            this.groupBox1.Controls.Add(this.lbl_Count);
            this.groupBox1.Controls.Add(this.tb_HotDogPrice);
            this.groupBox1.Controls.Add(this.tb_HotDogCount);
            this.groupBox1.Controls.Add(this.lbl2_Rub);
            this.groupBox1.Controls.Add(this.lbl5_Rub);
            this.groupBox1.Controls.Add(this.tb_HamburgerPrice);
            this.groupBox1.Controls.Add(this.tb_CocaColaCount);
            this.groupBox1.Controls.Add(this.tb_HamburgerCount);
            this.groupBox1.Controls.Add(this.tb_CocaColaPrice);
            this.groupBox1.Controls.Add(this.lbl3_Rub);
            this.groupBox1.Controls.Add(this.lbl4_Rub);
            this.groupBox1.Controls.Add(this.tb_CheesburgerPrice);
            this.groupBox1.Controls.Add(this.tb_CheesburgerCount);
            this.groupBox1.Location = new System.Drawing.Point(343, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 318);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Мини-кафе";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(16, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 318);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Топливо";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(0, 138);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(306, 75);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 93);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // lbl_ToPayPetrol
            // 
            this.lbl_ToPayPetrol.AutoSize = true;
            this.lbl_ToPayPetrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ToPayPetrol.Location = new System.Drawing.Point(37, 239);
            this.lbl_ToPayPetrol.Name = "lbl_ToPayPetrol";
            this.lbl_ToPayPetrol.Size = new System.Drawing.Size(60, 13);
            this.lbl_ToPayPetrol.TabIndex = 9;
            this.lbl_ToPayPetrol.Text = "К оплате";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(343, 237);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(305, 93);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(675, 434);
            this.Controls.Add(this.tb_Total);
            this.Controls.Add(this.tb_ToPayCafe);
            this.Controls.Add(this.tb_ToPayPetrol);
            this.Controls.Add(this.lbl1_Rub);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Litres);
            this.Controls.Add(this.lbl_ToPayCafe);
            this.Controls.Add(this.lbl_Rub);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.lbl_ToPayPetrol);
            this.Controls.Add(this.tb_Sum);
            this.Controls.Add(this.tb_Count);
            this.Controls.Add(this.rb_Sum);
            this.Controls.Add(this.rb_Count);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Petrol);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.cmb_TypeOfOil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Автозаправка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_TypeOfOil;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label lbl_Petrol;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.RadioButton rb_Count;
        private System.Windows.Forms.RadioButton rb_Sum;
        private System.Windows.Forms.TextBox tb_Count;
        private System.Windows.Forms.TextBox tb_Sum;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.CheckBox chk_HotDog;
        private System.Windows.Forms.CheckBox chk_Hamburger;
        private System.Windows.Forms.CheckBox chk_Cheeseburger;
        private System.Windows.Forms.CheckBox chk_CocaCola;
        private System.Windows.Forms.Label lbl_Price1;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.TextBox tb_HotDogPrice;
        private System.Windows.Forms.TextBox tb_HotDogCount;
        private System.Windows.Forms.Label lbl2_Rub;
        private System.Windows.Forms.Label lbl3_Rub;
        private System.Windows.Forms.TextBox tb_HamburgerCount;
        private System.Windows.Forms.TextBox tb_HamburgerPrice;
        private System.Windows.Forms.Label lbl4_Rub;
        private System.Windows.Forms.TextBox tb_CheesburgerCount;
        private System.Windows.Forms.TextBox tb_CheesburgerPrice;
        private System.Windows.Forms.Label lbl5_Rub;
        private System.Windows.Forms.TextBox tb_CocaColaCount;
        private System.Windows.Forms.TextBox tb_CocaColaPrice;
        private System.Windows.Forms.Label lbl_Rub;
        private System.Windows.Forms.Label lbl_ToPayCafe;
        private System.Windows.Forms.Label lbl_Litres;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl1_Rub;
        private System.Windows.Forms.TextBox tb_ToPayPetrol;
        private System.Windows.Forms.TextBox tb_ToPayCafe;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_ToPayPetrol;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

