namespace MobileStore
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnReadFromFile = new System.Windows.Forms.Button();
            this.btnSaveInFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnDelPhone = new System.Windows.Forms.Button();
            this.lbl_LstTel = new System.Windows.Forms.Label();
            this.lstPhones = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbProcessor = new System.Windows.Forms.TextBox();
            this.tbOS = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProccessor = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lstOptions = new System.Windows.Forms.ListBox();
            this.pctPhone = new System.Windows.Forms.PictureBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddNewPhone = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblEditPrice = new System.Windows.Forms.Label();
            this.lblEditPct = new System.Windows.Forms.Label();
            this.lblEditProc = new System.Windows.Forms.Label();
            this.lblEditOs = new System.Windows.Forms.Label();
            this.lblEditModel = new System.Windows.Forms.Label();
            this.tbEditPrice = new System.Windows.Forms.TextBox();
            this.tbEditPct = new System.Windows.Forms.TextBox();
            this.tbEditProc = new System.Windows.Forms.TextBox();
            this.tbEditOs = new System.Windows.Forms.TextBox();
            this.tbModelEdit = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelOpt = new System.Windows.Forms.Button();
            this.btnAddOpt = new System.Windows.Forms.Button();
            this.tbOptName = new System.Windows.Forms.TextBox();
            this.lblOptName = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.chkLstOptions = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhone)).BeginInit();
            this.grpOptions.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnReadFromFile);
            this.splitContainer1.Panel1.Controls.Add(this.btnSaveInFile);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnClearList);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelPhone);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_LstTel);
            this.splitContainer1.Panel1.Controls.Add(this.lstPhones);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(677, 507);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnReadFromFile
            // 
            this.btnReadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReadFromFile.ForeColor = System.Drawing.Color.Blue;
            this.btnReadFromFile.Location = new System.Drawing.Point(129, 448);
            this.btnReadFromFile.Name = "btnReadFromFile";
            this.btnReadFromFile.Size = new System.Drawing.Size(91, 52);
            this.btnReadFromFile.TabIndex = 6;
            this.btnReadFromFile.Text = "Прочитать из XML-файла";
            this.btnReadFromFile.UseVisualStyleBackColor = true;
            this.btnReadFromFile.Click += new System.EventHandler(this.btnReadFromFile_Click);
            // 
            // btnSaveInFile
            // 
            this.btnSaveInFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveInFile.ForeColor = System.Drawing.Color.Blue;
            this.btnSaveInFile.Location = new System.Drawing.Point(13, 448);
            this.btnSaveInFile.Name = "btnSaveInFile";
            this.btnSaveInFile.Size = new System.Drawing.Size(91, 52);
            this.btnSaveInFile.TabIndex = 5;
            this.btnSaveInFile.Text = "Сохранить в XML-файл";
            this.btnSaveInFile.UseVisualStyleBackColor = true;
            this.btnSaveInFile.Click += new System.EventHandler(this.btnSaveInFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "--------------------------------------------------------------------";
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearList.Location = new System.Drawing.Point(129, 385);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(91, 37);
            this.btnClearList.TabIndex = 3;
            this.btnClearList.Text = "Очистить список";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnDelPhone
            // 
            this.btnDelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelPhone.Location = new System.Drawing.Point(13, 385);
            this.btnDelPhone.Name = "btnDelPhone";
            this.btnDelPhone.Size = new System.Drawing.Size(91, 37);
            this.btnDelPhone.TabIndex = 2;
            this.btnDelPhone.Text = "Удалить текущую";
            this.btnDelPhone.UseVisualStyleBackColor = true;
            this.btnDelPhone.Click += new System.EventHandler(this.btnDelPhone_Click);
            // 
            // lbl_LstTel
            // 
            this.lbl_LstTel.AutoSize = true;
            this.lbl_LstTel.Location = new System.Drawing.Point(5, 9);
            this.lbl_LstTel.Name = "lbl_LstTel";
            this.lbl_LstTel.Size = new System.Drawing.Size(154, 13);
            this.lbl_LstTel.TabIndex = 1;
            this.lbl_LstTel.Text = "Список телефонов магазина";
            // 
            // lstPhones
            // 
            this.lstPhones.FormattingEnabled = true;
            this.lstPhones.Location = new System.Drawing.Point(8, 25);
            this.lstPhones.Name = "lstPhones";
            this.lstPhones.Size = new System.Drawing.Size(231, 498);
            this.lstPhones.TabIndex = 0;
            this.lstPhones.SelectedIndexChanged += new System.EventHandler(this.lstPhones_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(427, 507);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbPrice);
            this.tabPage1.Controls.Add(this.tbProcessor);
            this.tabPage1.Controls.Add(this.tbOS);
            this.tabPage1.Controls.Add(this.tbModel);
            this.tabPage1.Controls.Add(this.lblPrice);
            this.tabPage1.Controls.Add(this.lblProccessor);
            this.tabPage1.Controls.Add(this.lblOS);
            this.tabPage1.Controls.Add(this.lblModel);
            this.tabPage1.Controls.Add(this.lstOptions);
            this.tabPage1.Controls.Add(this.pctPhone);
            this.tabPage1.Controls.Add(this.grpOptions);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(419, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация о телефоне";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(166, 245);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(187, 20);
            this.tbPrice.TabIndex = 10;
            // 
            // tbProcessor
            // 
            this.tbProcessor.Location = new System.Drawing.Point(166, 214);
            this.tbProcessor.Name = "tbProcessor";
            this.tbProcessor.Size = new System.Drawing.Size(187, 20);
            this.tbProcessor.TabIndex = 9;
            // 
            // tbOS
            // 
            this.tbOS.Location = new System.Drawing.Point(166, 180);
            this.tbOS.Name = "tbOS";
            this.tbOS.Size = new System.Drawing.Size(187, 20);
            this.tbOS.TabIndex = 8;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(166, 147);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(187, 20);
            this.tbModel.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(28, 245);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Цена";
            // 
            // lblProccessor
            // 
            this.lblProccessor.AutoSize = true;
            this.lblProccessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProccessor.ForeColor = System.Drawing.Color.Blue;
            this.lblProccessor.Location = new System.Drawing.Point(28, 214);
            this.lblProccessor.Name = "lblProccessor";
            this.lblProccessor.Size = new System.Drawing.Size(72, 13);
            this.lblProccessor.TabIndex = 5;
            this.lblProccessor.Text = "Процессор";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOS.ForeColor = System.Drawing.Color.Blue;
            this.lblOS.Location = new System.Drawing.Point(28, 187);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(24, 13);
            this.lblOS.TabIndex = 4;
            this.lblOS.Text = "OC";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblModel.ForeColor = System.Drawing.Color.Blue;
            this.lblModel.Location = new System.Drawing.Point(28, 155);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(52, 13);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Модель";
            // 
            // lstOptions
            // 
            this.lstOptions.FormattingEnabled = true;
            this.lstOptions.Location = new System.Drawing.Point(18, 304);
            this.lstOptions.Name = "lstOptions";
            this.lstOptions.Size = new System.Drawing.Size(329, 95);
            this.lstOptions.TabIndex = 1;
            // 
            // pctPhone
            // 
            this.pctPhone.Location = new System.Drawing.Point(93, 25);
            this.pctPhone.Name = "pctPhone";
            this.pctPhone.Size = new System.Drawing.Size(260, 101);
            this.pctPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPhone.TabIndex = 0;
            this.pctPhone.TabStop = false;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.gbOptions);
            this.grpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOptions.Location = new System.Drawing.Point(3, 3);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(413, 475);
            this.grpOptions.TabIndex = 2;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Опции";
            // 
            // gbOptions
            // 
            this.gbOptions.Location = new System.Drawing.Point(6, 283);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(344, 160);
            this.gbOptions.TabIndex = 0;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Опции";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddNewPhone);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.lblEditPrice);
            this.tabPage2.Controls.Add(this.lblEditPct);
            this.tabPage2.Controls.Add(this.lblEditProc);
            this.tabPage2.Controls.Add(this.lblEditOs);
            this.tabPage2.Controls.Add(this.lblEditModel);
            this.tabPage2.Controls.Add(this.tbEditPrice);
            this.tabPage2.Controls.Add(this.tbEditPct);
            this.tabPage2.Controls.Add(this.tbEditProc);
            this.tabPage2.Controls.Add(this.tbEditOs);
            this.tabPage2.Controls.Add(this.tbModelEdit);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редактирование информации";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddNewPhone
            // 
            this.btnAddNewPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewPhone.ForeColor = System.Drawing.Color.Red;
            this.btnAddNewPhone.Location = new System.Drawing.Point(273, 439);
            this.btnAddNewPhone.Name = "btnAddNewPhone";
            this.btnAddNewPhone.Size = new System.Drawing.Size(132, 39);
            this.btnAddNewPhone.TabIndex = 14;
            this.btnAddNewPhone.Text = "Добавить новый телефон";
            this.btnAddNewPhone.UseVisualStyleBackColor = true;
            this.btnAddNewPhone.Click += new System.EventHandler(this.btnAddNewPhone_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(26, 439);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 39);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Очистить поля";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblEditPrice
            // 
            this.lblEditPrice.AutoSize = true;
            this.lblEditPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEditPrice.ForeColor = System.Drawing.Color.Red;
            this.lblEditPrice.Location = new System.Drawing.Point(23, 153);
            this.lblEditPrice.Name = "lblEditPrice";
            this.lblEditPrice.Size = new System.Drawing.Size(41, 13);
            this.lblEditPrice.TabIndex = 9;
            this.lblEditPrice.Text = "Цена:";
            // 
            // lblEditPct
            // 
            this.lblEditPct.AutoSize = true;
            this.lblEditPct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEditPct.ForeColor = System.Drawing.Color.Blue;
            this.lblEditPct.Location = new System.Drawing.Point(23, 127);
            this.lblEditPct.Name = "lblEditPct";
            this.lblEditPct.Size = new System.Drawing.Size(67, 13);
            this.lblEditPct.TabIndex = 8;
            this.lblEditPct.Text = "Картинка:";
            // 
            // lblEditProc
            // 
            this.lblEditProc.AutoSize = true;
            this.lblEditProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEditProc.ForeColor = System.Drawing.Color.Blue;
            this.lblEditProc.Location = new System.Drawing.Point(23, 101);
            this.lblEditProc.Name = "lblEditProc";
            this.lblEditProc.Size = new System.Drawing.Size(76, 13);
            this.lblEditProc.TabIndex = 7;
            this.lblEditProc.Text = "Процессор:";
            // 
            // lblEditOs
            // 
            this.lblEditOs.AutoSize = true;
            this.lblEditOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEditOs.ForeColor = System.Drawing.Color.Blue;
            this.lblEditOs.Location = new System.Drawing.Point(23, 75);
            this.lblEditOs.Name = "lblEditOs";
            this.lblEditOs.Size = new System.Drawing.Size(28, 13);
            this.lblEditOs.TabIndex = 6;
            this.lblEditOs.Text = "OC:";
            // 
            // lblEditModel
            // 
            this.lblEditModel.AutoSize = true;
            this.lblEditModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEditModel.ForeColor = System.Drawing.Color.Blue;
            this.lblEditModel.Location = new System.Drawing.Point(23, 49);
            this.lblEditModel.Name = "lblEditModel";
            this.lblEditModel.Size = new System.Drawing.Size(56, 13);
            this.lblEditModel.TabIndex = 5;
            this.lblEditModel.Text = "Модель:";
            // 
            // tbEditPrice
            // 
            this.tbEditPrice.Location = new System.Drawing.Point(184, 146);
            this.tbEditPrice.Name = "tbEditPrice";
            this.tbEditPrice.Size = new System.Drawing.Size(182, 20);
            this.tbEditPrice.TabIndex = 4;
            // 
            // tbEditPct
            // 
            this.tbEditPct.Location = new System.Drawing.Point(184, 120);
            this.tbEditPct.Name = "tbEditPct";
            this.tbEditPct.Size = new System.Drawing.Size(182, 20);
            this.tbEditPct.TabIndex = 3;
            // 
            // tbEditProc
            // 
            this.tbEditProc.Location = new System.Drawing.Point(184, 94);
            this.tbEditProc.Name = "tbEditProc";
            this.tbEditProc.Size = new System.Drawing.Size(182, 20);
            this.tbEditProc.TabIndex = 2;
            // 
            // tbEditOs
            // 
            this.tbEditOs.Location = new System.Drawing.Point(184, 68);
            this.tbEditOs.Name = "tbEditOs";
            this.tbEditOs.Size = new System.Drawing.Size(182, 20);
            this.tbEditOs.TabIndex = 1;
            // 
            // tbModelEdit
            // 
            this.tbModelEdit.Location = new System.Drawing.Point(184, 42);
            this.tbModelEdit.Name = "tbModelEdit";
            this.tbModelEdit.Size = new System.Drawing.Size(182, 20);
            this.tbModelEdit.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadImage);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 192);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(365, 113);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(25, 20);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "...";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelOpt);
            this.groupBox2.Controls.Add(this.btnAddOpt);
            this.groupBox2.Controls.Add(this.tbOptName);
            this.groupBox2.Controls.Add(this.lblOptName);
            this.groupBox2.Controls.Add(this.btnSaveChanges);
            this.groupBox2.Controls.Add(this.chkLstOptions);
            this.groupBox2.Location = new System.Drawing.Point(7, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 234);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btnDelOpt
            // 
            this.btnDelOpt.Location = new System.Drawing.Point(281, 205);
            this.btnDelOpt.Name = "btnDelOpt";
            this.btnDelOpt.Size = new System.Drawing.Size(101, 23);
            this.btnDelOpt.TabIndex = 15;
            this.btnDelOpt.Text = "Удалить опцию";
            this.btnDelOpt.UseVisualStyleBackColor = true;
            this.btnDelOpt.Click += new System.EventHandler(this.btnDelOpt_Click);
            // 
            // btnAddOpt
            // 
            this.btnAddOpt.Location = new System.Drawing.Point(19, 203);
            this.btnAddOpt.Name = "btnAddOpt";
            this.btnAddOpt.Size = new System.Drawing.Size(101, 23);
            this.btnAddOpt.TabIndex = 14;
            this.btnAddOpt.Text = "Добавить опцию";
            this.btnAddOpt.UseVisualStyleBackColor = true;
            this.btnAddOpt.Click += new System.EventHandler(this.btnAddOpt_Click);
            // 
            // tbOptName
            // 
            this.tbOptName.Location = new System.Drawing.Point(155, 179);
            this.tbOptName.Name = "tbOptName";
            this.tbOptName.Size = new System.Drawing.Size(227, 20);
            this.tbOptName.TabIndex = 13;
            // 
            // lblOptName
            // 
            this.lblOptName.AutoSize = true;
            this.lblOptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOptName.ForeColor = System.Drawing.Color.Red;
            this.lblOptName.Location = new System.Drawing.Point(16, 182);
            this.lblOptName.Name = "lblOptName";
            this.lblOptName.Size = new System.Drawing.Size(104, 13);
            this.lblOptName.TabIndex = 12;
            this.lblOptName.Text = "Название опции";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveChanges.Location = new System.Drawing.Point(7, 150);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(391, 23);
            this.btnSaveChanges.TabIndex = 11;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // chkLstOptions
            // 
            this.chkLstOptions.FormattingEnabled = true;
            this.chkLstOptions.Location = new System.Drawing.Point(6, 19);
            this.chkLstOptions.Name = "chkLstOptions";
            this.chkLstOptions.Size = new System.Drawing.Size(392, 124);
            this.chkLstOptions.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 507);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhone)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnReadFromFile;
        private System.Windows.Forms.Button btnSaveInFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnDelPhone;
        private System.Windows.Forms.Label lbl_LstTel;
        private System.Windows.Forms.ListBox lstPhones;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pctPhone;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbProcessor;
        private System.Windows.Forms.TextBox tbOS;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProccessor;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ListBox lstOptions;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label lblEditPrice;
        private System.Windows.Forms.Label lblEditPct;
        private System.Windows.Forms.Label lblEditProc;
        private System.Windows.Forms.Label lblEditOs;
        private System.Windows.Forms.Label lblEditModel;
        private System.Windows.Forms.TextBox tbEditPrice;
        private System.Windows.Forms.TextBox tbEditPct;
        private System.Windows.Forms.TextBox tbEditProc;
        private System.Windows.Forms.TextBox tbEditOs;
        private System.Windows.Forms.TextBox tbModelEdit;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.CheckedListBox chkLstOptions;
        private System.Windows.Forms.Button btnAddNewPhone;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelOpt;
        private System.Windows.Forms.Button btnAddOpt;
        private System.Windows.Forms.TextBox tbOptName;
        private System.Windows.Forms.Label lblOptName;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnLoadImage;
    }
}

