namespace XmlReadArtists
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.QueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuery1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuery2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuery3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuery4 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuery5 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuery6 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuery7 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuery8 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuery9 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuery10 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(835, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 238);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(835, 194);
            this.dataGridView2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QueryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // QueryToolStripMenuItem
            // 
            this.QueryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuery1,
            this.btnQuery2,
            this.btnQuery3,
            this.btnQuery4,
            this.btnQuery5,
            this.btnQuery6,
            this.btnQuery7,
            this.btnQuery8,
            this.btnQuery9,
            this.btnQuery10});
            this.QueryToolStripMenuItem.Name = "QueryToolStripMenuItem";
            this.QueryToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.QueryToolStripMenuItem.Text = "Запросы";
            // 
            // btnQuery1
            // 
            this.btnQuery1.Name = "btnQuery1";
            this.btnQuery1.Size = new System.Drawing.Size(902, 22);
            this.btnQuery1.Text = "Список всех артистов, который выпустили свои альбомы после распада СССР";
            this.btnQuery1.Click += new System.EventHandler(this.btnQuery1_Click);
            // 
            // btnQuery2
            // 
            this.btnQuery2.Name = "btnQuery2";
            this.btnQuery2.Size = new System.Drawing.Size(902, 22);
            this.btnQuery2.Text = "Список стран (без повторений)";
            this.btnQuery2.Click += new System.EventHandler(this.btnQuery2_Click_1);
            // 
            // btnQuery3
            // 
            this.btnQuery3.Name = "btnQuery3";
            this.btnQuery3.Size = new System.Drawing.Size(902, 22);
            this.btnQuery3.Text = "Список наименований альбомов, выпущенных в США, упорядоченных по году выпуска";
            this.btnQuery3.Click += new System.EventHandler(this.btnQuery3_Click);
            // 
            // btnQuery4
            // 
            this.btnQuery4.Name = "btnQuery4";
            this.btnQuery4.Size = new System.Drawing.Size(902, 22);
            this.btnQuery4.Text = "Суммарную стоимость альбомов за страну";
            this.btnQuery4.Click += new System.EventHandler(this.btnQuery4_Click);
            // 
            // btnQuery5
            // 
            this.btnQuery5.Name = "btnQuery5";
            this.btnQuery5.Size = new System.Drawing.Size(902, 22);
            this.btnQuery5.Text = "Список: компания и количество альбомов за год, года упорядочены по возрастанию";
            this.btnQuery5.Click += new System.EventHandler(this.btnQuery5_Click);
            // 
            // btnQuery6
            // 
            this.btnQuery6.Name = "btnQuery6";
            this.btnQuery6.Size = new System.Drawing.Size(902, 22);
            this.btnQuery6.Text = "Наименование альбомов и имя продюсера, получившего самое большое вознаграждение з" +
    "а вклад в развитие";
            this.btnQuery6.Click += new System.EventHandler(this.btnQuery6_Click);
            // 
            // btnQuery7
            // 
            this.btnQuery7.Name = "btnQuery7";
            this.btnQuery7.Size = new System.Drawing.Size(902, 22);
            this.btnQuery7.Text = "Количество альбомов каждого продюсера в период  между годами выхода альбома 1988 " +
    "– 1990 гг";
            this.btnQuery7.Click += new System.EventHandler(this.btnQuery7_Click);
            // 
            // btnQuery8
            // 
            this.btnQuery8.Name = "btnQuery8";
            this.btnQuery8.Size = new System.Drawing.Size(902, 22);
            this.btnQuery8.Text = "Фамилию продюсера получившего вознаграждение последним";
            this.btnQuery8.Click += new System.EventHandler(this.btnQuery8_Click);
            // 
            // btnQuery9
            // 
            this.btnQuery9.Name = "btnQuery9";
            this.btnQuery9.Size = new System.Drawing.Size(902, 22);
            this.btnQuery9.Text = "Информацию о самом дешевом альбоме (название альбома, исполнителя и продюсера)";
            this.btnQuery9.Click += new System.EventHandler(this.btnQuery9_Click);
            // 
            // btnQuery10
            // 
            this.btnQuery10.Name = "btnQuery10";
            this.btnQuery10.Size = new System.Drawing.Size(902, 22);
            this.btnQuery10.Text = "Полную информацию об альбомах, отсортированную по следующим критериям: год выхода" +
    " альбома, стоимость  альбома, наименование альбома";
            this.btnQuery10.Click += new System.EventHandler(this.btnQuery10_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 453);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Введение в LINQ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem QueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnQuery1;
        private System.Windows.Forms.ToolStripMenuItem btnQuery2;
        private System.Windows.Forms.ToolStripMenuItem btnQuery3;
        private System.Windows.Forms.ToolStripMenuItem btnQuery4;
        private System.Windows.Forms.ToolStripMenuItem btnQuery5;
        private System.Windows.Forms.ToolStripMenuItem btnQuery6;
        private System.Windows.Forms.ToolStripMenuItem btnQuery7;
        private System.Windows.Forms.ToolStripMenuItem btnQuery8;
        private System.Windows.Forms.ToolStripMenuItem btnQuery9;
        private System.Windows.Forms.ToolStripMenuItem btnQuery10;
    }
}

