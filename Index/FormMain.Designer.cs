namespace Index
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.cTable = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numBookPrice = new System.Windows.Forms.NumericUpDown();
            this.numBookQuantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBookAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBookBookType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBookNameBook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.btnBookChange = new System.Windows.Forms.Button();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.dgBook = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBookTypeNameBookType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBookTypeDelete = new System.Windows.Forms.Button();
            this.btnBookTypeChange = new System.Windows.Forms.Button();
            this.btnBookTypeAdd = new System.Windows.Forms.Button();
            this.dgBookType = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBillDetail = new System.Windows.Forms.Button();
            this.dateTimeMakeBill = new System.Windows.Forms.DateTimePicker();
            this.textBillNameCustomer = new System.Windows.Forms.TextBox();
            this.textPhoneCustomer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBillDelete = new System.Windows.Forms.Button();
            this.btnBillChange = new System.Windows.Forms.Button();
            this.btnBillAdd = new System.Windows.Forms.Button();
            this.dgBill = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnImportDetail = new System.Windows.Forms.Button();
            this.dateTimeMakeImport = new System.Windows.Forms.DateTimePicker();
            this.textImportNameProvider = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnImportDelete = new System.Windows.Forms.Button();
            this.btnImportChange = new System.Windows.Forms.Button();
            this.btnImportAdd = new System.Windows.Forms.Button();
            this.dgImport = new System.Windows.Forms.DataGridView();
            this.cTable.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBookPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBookQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBook)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookType)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBill)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).BeginInit();
            this.SuspendLayout();
            // 
            // cTable
            // 
            this.cTable.Controls.Add(this.tabPage1);
            this.cTable.Controls.Add(this.tabPage2);
            this.cTable.Controls.Add(this.tabPage3);
            this.cTable.Controls.Add(this.tabPage4);
            this.cTable.Location = new System.Drawing.Point(30, 29);
            this.cTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cTable.Name = "cTable";
            this.cTable.SelectedIndex = 0;
            this.cTable.Size = new System.Drawing.Size(1638, 843);
            this.cTable.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::Index.Properties.Resources.bg;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgBook);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1630, 795);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sách";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.numBookPrice);
            this.panel1.Controls.Add(this.numBookQuantity);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBookAuthor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbBookBookType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBookNameBook);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBookDelete);
            this.panel1.Controls.Add(this.btnBookChange);
            this.panel1.Controls.Add(this.btnBookAdd);
            this.panel1.Location = new System.Drawing.Point(7, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1616, 199);
            this.panel1.TabIndex = 1;
            // 
            // numBookPrice
            // 
            this.numBookPrice.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBookPrice.Location = new System.Drawing.Point(452, 151);
            this.numBookPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numBookPrice.Name = "numBookPrice";
            this.numBookPrice.Size = new System.Drawing.Size(258, 39);
            this.numBookPrice.TabIndex = 13;
            // 
            // numBookQuantity
            // 
            this.numBookQuantity.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBookQuantity.Location = new System.Drawing.Point(168, 151);
            this.numBookQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBookQuantity.Name = "numBookQuantity";
            this.numBookQuantity.Size = new System.Drawing.Size(162, 39);
            this.numBookQuantity.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(194)))), ((int)(((byte)(137)))));
            this.label5.Location = new System.Drawing.Point(336, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 40);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giá bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(194)))), ((int)(((byte)(137)))));
            this.label4.Location = new System.Drawing.Point(36, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số lượng";
            // 
            // textBookAuthor
            // 
            this.textBookAuthor.BackColor = System.Drawing.Color.White;
            this.textBookAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBookAuthor.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBookAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(188)))), ((int)(((byte)(186)))));
            this.textBookAuthor.Location = new System.Drawing.Point(716, 78);
            this.textBookAuthor.Name = "textBookAuthor";
            this.textBookAuthor.Size = new System.Drawing.Size(364, 39);
            this.textBookAuthor.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(194)))), ((int)(((byte)(137)))));
            this.label3.Location = new System.Drawing.Point(609, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tác giả";
            // 
            // cbBookBookType
            // 
            this.cbBookBookType.BackColor = System.Drawing.Color.White;
            this.cbBookBookType.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBookBookType.FormattingEnabled = true;
            this.cbBookBookType.Location = new System.Drawing.Point(168, 75);
            this.cbBookBookType.Margin = new System.Windows.Forms.Padding(0);
            this.cbBookBookType.Name = "cbBookBookType";
            this.cbBookBookType.Size = new System.Drawing.Size(398, 46);
            this.cbBookBookType.TabIndex = 7;
            this.cbBookBookType.SelectedIndexChanged += new System.EventHandler(this.cbBookBookType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(194)))), ((int)(((byte)(137)))));
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại sách";
            // 
            // textBookNameBook
            // 
            this.textBookNameBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBookNameBook.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBookNameBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(188)))), ((int)(((byte)(186)))));
            this.textBookNameBook.Location = new System.Drawing.Point(168, 6);
            this.textBookNameBook.Name = "textBookNameBook";
            this.textBookNameBook.Size = new System.Drawing.Size(912, 39);
            this.textBookNameBook.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(194)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(36, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên sách";
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookDelete.BackgroundImage")));
            this.btnBookDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookDelete.FlatAppearance.BorderSize = 0;
            this.btnBookDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookDelete.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookDelete.ForeColor = System.Drawing.Color.White;
            this.btnBookDelete.Location = new System.Drawing.Point(1259, 154);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(182, 45);
            this.btnBookDelete.TabIndex = 2;
            this.btnBookDelete.Text = "Xóa";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // btnBookChange
            // 
            this.btnBookChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookChange.BackgroundImage")));
            this.btnBookChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookChange.FlatAppearance.BorderSize = 0;
            this.btnBookChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookChange.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookChange.ForeColor = System.Drawing.Color.White;
            this.btnBookChange.Location = new System.Drawing.Point(1259, 80);
            this.btnBookChange.Name = "btnBookChange";
            this.btnBookChange.Size = new System.Drawing.Size(182, 45);
            this.btnBookChange.TabIndex = 1;
            this.btnBookChange.Text = "Sửa";
            this.btnBookChange.UseVisualStyleBackColor = true;
            this.btnBookChange.Click += new System.EventHandler(this.btnBookChange_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.BackgroundImage = global::Index.Properties.Resources.btn;
            this.btnBookAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookAdd.FlatAppearance.BorderSize = 0;
            this.btnBookAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookAdd.Font = new System.Drawing.Font("Bricolage Grotesque 24pt SemiBo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookAdd.ForeColor = System.Drawing.Color.White;
            this.btnBookAdd.Location = new System.Drawing.Point(1259, 3);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(182, 45);
            this.btnBookAdd.TabIndex = 0;
            this.btnBookAdd.Text = "Thêm";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // dgBook
            // 
            this.dgBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBook.Location = new System.Drawing.Point(0, 0);
            this.dgBook.Name = "dgBook";
            this.dgBook.RowHeadersWidth = 62;
            this.dgBook.RowTemplate.Height = 28;
            this.dgBook.Size = new System.Drawing.Size(1634, 544);
            this.dgBook.TabIndex = 0;
            this.dgBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBook_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.BackgroundImage = global::Index.Properties.Resources.bg;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dgBookType);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1630, 795);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loại sách";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBookTypeNameBookType);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnBookTypeDelete);
            this.panel2.Controls.Add(this.btnBookTypeChange);
            this.panel2.Controls.Add(this.btnBookTypeAdd);
            this.panel2.Location = new System.Drawing.Point(3, 573);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1616, 199);
            this.panel2.TabIndex = 3;
            // 
            // textBookTypeNameBookType
            // 
            this.textBookTypeNameBookType.BackColor = System.Drawing.Color.White;
            this.textBookTypeNameBookType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBookTypeNameBookType.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBookTypeNameBookType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(188)))), ((int)(((byte)(186)))));
            this.textBookTypeNameBookType.Location = new System.Drawing.Point(259, 31);
            this.textBookTypeNameBookType.Name = "textBookTypeNameBookType";
            this.textBookTypeNameBookType.Size = new System.Drawing.Size(912, 39);
            this.textBookTypeNameBookType.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(194)))), ((int)(((byte)(137)))));
            this.label10.Location = new System.Drawing.Point(77, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 40);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tên loại sách";
            // 
            // btnBookTypeDelete
            // 
            this.btnBookTypeDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookTypeDelete.BackgroundImage")));
            this.btnBookTypeDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookTypeDelete.FlatAppearance.BorderSize = 0;
            this.btnBookTypeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookTypeDelete.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookTypeDelete.ForeColor = System.Drawing.Color.White;
            this.btnBookTypeDelete.Location = new System.Drawing.Point(742, 120);
            this.btnBookTypeDelete.Name = "btnBookTypeDelete";
            this.btnBookTypeDelete.Size = new System.Drawing.Size(182, 45);
            this.btnBookTypeDelete.TabIndex = 2;
            this.btnBookTypeDelete.Text = "Xóa";
            this.btnBookTypeDelete.UseVisualStyleBackColor = true;
            this.btnBookTypeDelete.Click += new System.EventHandler(this.btnBookTypeDelete_Click);
            // 
            // btnBookTypeChange
            // 
            this.btnBookTypeChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookTypeChange.BackgroundImage")));
            this.btnBookTypeChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookTypeChange.FlatAppearance.BorderSize = 0;
            this.btnBookTypeChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookTypeChange.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookTypeChange.ForeColor = System.Drawing.Color.White;
            this.btnBookTypeChange.Location = new System.Drawing.Point(497, 120);
            this.btnBookTypeChange.Name = "btnBookTypeChange";
            this.btnBookTypeChange.Size = new System.Drawing.Size(182, 45);
            this.btnBookTypeChange.TabIndex = 1;
            this.btnBookTypeChange.Text = "Sửa";
            this.btnBookTypeChange.UseVisualStyleBackColor = true;
            this.btnBookTypeChange.Click += new System.EventHandler(this.btnBookTypeChange_Click);
            // 
            // btnBookTypeAdd
            // 
            this.btnBookTypeAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookTypeAdd.BackgroundImage")));
            this.btnBookTypeAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookTypeAdd.FlatAppearance.BorderSize = 0;
            this.btnBookTypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookTypeAdd.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookTypeAdd.ForeColor = System.Drawing.Color.White;
            this.btnBookTypeAdd.Location = new System.Drawing.Point(259, 120);
            this.btnBookTypeAdd.Name = "btnBookTypeAdd";
            this.btnBookTypeAdd.Size = new System.Drawing.Size(182, 45);
            this.btnBookTypeAdd.TabIndex = 0;
            this.btnBookTypeAdd.Text = "Thêm";
            this.btnBookTypeAdd.UseVisualStyleBackColor = true;
            this.btnBookTypeAdd.Click += new System.EventHandler(this.btnBookTypeAdd_Click);
            // 
            // dgBookType
            // 
            this.dgBookType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBookType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookType.Location = new System.Drawing.Point(-4, 0);
            this.dgBookType.Name = "dgBookType";
            this.dgBookType.RowHeadersWidth = 62;
            this.dgBookType.RowTemplate.Height = 28;
            this.dgBookType.Size = new System.Drawing.Size(1634, 544);
            this.dgBookType.TabIndex = 2;
            this.dgBookType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBookType_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.BackgroundImage = global::Index.Properties.Resources.bg;
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.dgBill);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(1630, 795);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hóa đơn";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBillDetail);
            this.panel3.Controls.Add(this.dateTimeMakeBill);
            this.panel3.Controls.Add(this.textBillNameCustomer);
            this.panel3.Controls.Add(this.textPhoneCustomer);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnBillDelete);
            this.panel3.Controls.Add(this.btnBillChange);
            this.panel3.Controls.Add(this.btnBillAdd);
            this.panel3.Location = new System.Drawing.Point(7, 573);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1616, 199);
            this.panel3.TabIndex = 3;
            // 
            // btnBillDetail
            // 
            this.btnBillDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBillDetail.BackgroundImage")));
            this.btnBillDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillDetail.FlatAppearance.BorderSize = 0;
            this.btnBillDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillDetail.Font = new System.Drawing.Font("Bricolage Grotesque 24pt SemiBo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillDetail.ForeColor = System.Drawing.Color.White;
            this.btnBillDetail.Location = new System.Drawing.Point(1003, 145);
            this.btnBillDetail.Name = "btnBillDetail";
            this.btnBillDetail.Size = new System.Drawing.Size(182, 45);
            this.btnBillDetail.TabIndex = 12;
            this.btnBillDetail.Text = "Chi tiết >>";
            this.btnBillDetail.UseVisualStyleBackColor = true;
            this.btnBillDetail.Click += new System.EventHandler(this.btnBillDetail_Click);
            // 
            // dateTimeMakeBill
            // 
            this.dateTimeMakeBill.Location = new System.Drawing.Point(282, 11);
            this.dateTimeMakeBill.Name = "dateTimeMakeBill";
            this.dateTimeMakeBill.Size = new System.Drawing.Size(558, 34);
            this.dateTimeMakeBill.TabIndex = 11;
            // 
            // textBillNameCustomer
            // 
            this.textBillNameCustomer.BackColor = System.Drawing.Color.White;
            this.textBillNameCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBillNameCustomer.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBillNameCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(188)))), ((int)(((byte)(186)))));
            this.textBillNameCustomer.Location = new System.Drawing.Point(282, 76);
            this.textBillNameCustomer.Name = "textBillNameCustomer";
            this.textBillNameCustomer.Size = new System.Drawing.Size(423, 39);
            this.textBillNameCustomer.TabIndex = 10;
            // 
            // textPhoneCustomer
            // 
            this.textPhoneCustomer.BackColor = System.Drawing.Color.White;
            this.textPhoneCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPhoneCustomer.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhoneCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(188)))), ((int)(((byte)(186)))));
            this.textPhoneCustomer.Location = new System.Drawing.Point(983, 77);
            this.textPhoneCustomer.Name = "textPhoneCustomer";
            this.textPhoneCustomer.Size = new System.Drawing.Size(364, 39);
            this.textPhoneCustomer.TabIndex = 9;
            this.textPhoneCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPhoneCustomer_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(194)))), ((int)(((byte)(137)))));
            this.label8.Location = new System.Drawing.Point(763, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 40);
            this.label8.TabIndex = 8;
            this.label8.Text = "SĐT khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(194)))), ((int)(((byte)(137)))));
            this.label9.Location = new System.Drawing.Point(36, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 40);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tên khách hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(194)))), ((int)(((byte)(137)))));
            this.label11.Location = new System.Drawing.Point(36, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 40);
            this.label11.TabIndex = 3;
            this.label11.Text = "Ngày lập hóa đơn";
            // 
            // btnBillDelete
            // 
            this.btnBillDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBillDelete.BackgroundImage")));
            this.btnBillDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillDelete.FlatAppearance.BorderSize = 0;
            this.btnBillDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillDelete.Font = new System.Drawing.Font("Bricolage Grotesque 24pt SemiBo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillDelete.ForeColor = System.Drawing.Color.White;
            this.btnBillDelete.Location = new System.Drawing.Point(750, 145);
            this.btnBillDelete.Name = "btnBillDelete";
            this.btnBillDelete.Size = new System.Drawing.Size(182, 45);
            this.btnBillDelete.TabIndex = 2;
            this.btnBillDelete.Text = "Xóa";
            this.btnBillDelete.UseVisualStyleBackColor = true;
            this.btnBillDelete.Click += new System.EventHandler(this.btnBillDelete_Click);
            // 
            // btnBillChange
            // 
            this.btnBillChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBillChange.BackgroundImage")));
            this.btnBillChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillChange.FlatAppearance.BorderSize = 0;
            this.btnBillChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillChange.Font = new System.Drawing.Font("Bricolage Grotesque 24pt SemiBo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillChange.ForeColor = System.Drawing.Color.White;
            this.btnBillChange.Location = new System.Drawing.Point(505, 145);
            this.btnBillChange.Name = "btnBillChange";
            this.btnBillChange.Size = new System.Drawing.Size(182, 45);
            this.btnBillChange.TabIndex = 1;
            this.btnBillChange.Text = "Sửa";
            this.btnBillChange.UseVisualStyleBackColor = true;
            this.btnBillChange.Click += new System.EventHandler(this.btnBillChange_Click);
            // 
            // btnBillAdd
            // 
            this.btnBillAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBillAdd.BackgroundImage")));
            this.btnBillAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillAdd.FlatAppearance.BorderSize = 0;
            this.btnBillAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillAdd.Font = new System.Drawing.Font("Bricolage Grotesque 24pt SemiBo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillAdd.ForeColor = System.Drawing.Color.White;
            this.btnBillAdd.Location = new System.Drawing.Point(253, 145);
            this.btnBillAdd.Name = "btnBillAdd";
            this.btnBillAdd.Size = new System.Drawing.Size(182, 45);
            this.btnBillAdd.TabIndex = 0;
            this.btnBillAdd.Text = "Thêm";
            this.btnBillAdd.UseVisualStyleBackColor = true;
            this.btnBillAdd.Click += new System.EventHandler(this.btnBillAdd_Click);
            // 
            // dgBill
            // 
            this.dgBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBill.Location = new System.Drawing.Point(0, 0);
            this.dgBill.Name = "dgBill";
            this.dgBill.RowHeadersWidth = 62;
            this.dgBill.RowTemplate.Height = 28;
            this.dgBill.Size = new System.Drawing.Size(1634, 544);
            this.dgBill.TabIndex = 2;
            this.dgBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBill_CellClick);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.BackgroundImage = global::Index.Properties.Resources.bg;
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.dgImport);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Size = new System.Drawing.Size(1630, 795);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Phiếu nhập";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnImportDetail);
            this.panel4.Controls.Add(this.dateTimeMakeImport);
            this.panel4.Controls.Add(this.textImportNameProvider);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.btnImportDelete);
            this.panel4.Controls.Add(this.btnImportChange);
            this.panel4.Controls.Add(this.btnImportAdd);
            this.panel4.Location = new System.Drawing.Point(3, 564);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1616, 199);
            this.panel4.TabIndex = 3;
            // 
            // btnImportDetail
            // 
            this.btnImportDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImportDetail.BackgroundImage")));
            this.btnImportDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportDetail.FlatAppearance.BorderSize = 0;
            this.btnImportDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportDetail.Font = new System.Drawing.Font("Bricolage Grotesque 24pt SemiBo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportDetail.ForeColor = System.Drawing.Color.White;
            this.btnImportDetail.Location = new System.Drawing.Point(1055, 122);
            this.btnImportDetail.Name = "btnImportDetail";
            this.btnImportDetail.Size = new System.Drawing.Size(182, 45);
            this.btnImportDetail.TabIndex = 11;
            this.btnImportDetail.Text = "Chi tiết >>";
            this.btnImportDetail.UseVisualStyleBackColor = true;
            this.btnImportDetail.Click += new System.EventHandler(this.btnImportDetail_Click);
            // 
            // dateTimeMakeImport
            // 
            this.dateTimeMakeImport.Location = new System.Drawing.Point(311, 7);
            this.dateTimeMakeImport.Name = "dateTimeMakeImport";
            this.dateTimeMakeImport.Size = new System.Drawing.Size(440, 34);
            this.dateTimeMakeImport.TabIndex = 10;
            // 
            // textImportNameProvider
            // 
            this.textImportNameProvider.BackColor = System.Drawing.Color.White;
            this.textImportNameProvider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textImportNameProvider.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textImportNameProvider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(188)))), ((int)(((byte)(186)))));
            this.textImportNameProvider.Location = new System.Drawing.Point(958, 3);
            this.textImportNameProvider.Name = "textImportNameProvider";
            this.textImportNameProvider.Size = new System.Drawing.Size(494, 39);
            this.textImportNameProvider.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(194)))), ((int)(((byte)(137)))));
            this.label14.Location = new System.Drawing.Point(768, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 40);
            this.label14.TabIndex = 8;
            this.label14.Text = "Nhà cung cấp";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(194)))), ((int)(((byte)(137)))));
            this.label16.Location = new System.Drawing.Point(36, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(269, 40);
            this.label16.TabIndex = 3;
            this.label16.Text = "Ngày lập phiếu nhập";
            // 
            // btnImportDelete
            // 
            this.btnImportDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImportDelete.BackgroundImage")));
            this.btnImportDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportDelete.FlatAppearance.BorderSize = 0;
            this.btnImportDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportDelete.Font = new System.Drawing.Font("Bricolage Grotesque 24pt SemiBo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportDelete.ForeColor = System.Drawing.Color.White;
            this.btnImportDelete.Location = new System.Drawing.Point(837, 122);
            this.btnImportDelete.Name = "btnImportDelete";
            this.btnImportDelete.Size = new System.Drawing.Size(182, 45);
            this.btnImportDelete.TabIndex = 2;
            this.btnImportDelete.Text = "Xóa";
            this.btnImportDelete.UseVisualStyleBackColor = true;
            this.btnImportDelete.Click += new System.EventHandler(this.btnImportDelete_Click);
            // 
            // btnImportChange
            // 
            this.btnImportChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImportChange.BackgroundImage")));
            this.btnImportChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportChange.FlatAppearance.BorderSize = 0;
            this.btnImportChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportChange.Font = new System.Drawing.Font("Bricolage Grotesque 24pt SemiBo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportChange.ForeColor = System.Drawing.Color.White;
            this.btnImportChange.Location = new System.Drawing.Point(612, 122);
            this.btnImportChange.Name = "btnImportChange";
            this.btnImportChange.Size = new System.Drawing.Size(182, 45);
            this.btnImportChange.TabIndex = 1;
            this.btnImportChange.Text = "Sửa";
            this.btnImportChange.UseVisualStyleBackColor = true;
            this.btnImportChange.Click += new System.EventHandler(this.btnImportChange_Click);
            // 
            // btnImportAdd
            // 
            this.btnImportAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImportAdd.BackgroundImage")));
            this.btnImportAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportAdd.FlatAppearance.BorderSize = 0;
            this.btnImportAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportAdd.Font = new System.Drawing.Font("Bricolage Grotesque 24pt SemiBo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportAdd.ForeColor = System.Drawing.Color.White;
            this.btnImportAdd.Location = new System.Drawing.Point(393, 122);
            this.btnImportAdd.Name = "btnImportAdd";
            this.btnImportAdd.Size = new System.Drawing.Size(182, 45);
            this.btnImportAdd.TabIndex = 0;
            this.btnImportAdd.Text = "Thêm";
            this.btnImportAdd.UseVisualStyleBackColor = true;
            this.btnImportAdd.Click += new System.EventHandler(this.btnImportAdd_Click);
            // 
            // dgImport
            // 
            this.dgImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImport.Location = new System.Drawing.Point(0, 0);
            this.dgImport.Name = "dgImport";
            this.dgImport.RowHeadersWidth = 62;
            this.dgImport.RowTemplate.Height = 28;
            this.dgImport.Size = new System.Drawing.Size(1630, 544);
            this.dgImport.TabIndex = 2;
            this.dgImport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgImport_CellClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Index.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1697, 923);
            this.Controls.Add(this.cTable);
            this.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.cTable.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBookPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBookQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBook)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookType)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBill)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl cTable;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgBook;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.Button btnBookChange;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.TextBox textBookNameBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBookAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBookBookType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numBookQuantity;
        private System.Windows.Forms.NumericUpDown numBookPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBookTypeNameBookType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBookTypeDelete;
        private System.Windows.Forms.Button btnBookTypeChange;
        private System.Windows.Forms.Button btnBookTypeAdd;
        private System.Windows.Forms.DataGridView dgBookType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textPhoneCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBillDelete;
        private System.Windows.Forms.Button btnBillChange;
        private System.Windows.Forms.Button btnBillAdd;
        private System.Windows.Forms.DataGridView dgBill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textImportNameProvider;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnImportDelete;
        private System.Windows.Forms.Button btnImportChange;
        private System.Windows.Forms.Button btnImportAdd;
        private System.Windows.Forms.DataGridView dgImport;
        private System.Windows.Forms.DateTimePicker dateTimeMakeBill;
        private System.Windows.Forms.TextBox textBillNameCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimeMakeImport;
        private System.Windows.Forms.Button btnImportDetail;
        private System.Windows.Forms.Button btnBillDetail;
    }
}