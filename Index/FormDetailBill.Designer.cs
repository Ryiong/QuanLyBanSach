namespace Index
{
    partial class FormDetailBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailBill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalPriceBill = new System.Windows.Forms.Label();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.numBookQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleBill = new System.Windows.Forms.Label();
            this.dgDetailBill = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBookQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailBill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.totalPriceBill);
            this.panel1.Controls.Add(this.cbBook);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.numBookQuantity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 611);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1474, 211);
            this.panel1.TabIndex = 5;
            // 
            // totalPriceBill
            // 
            this.totalPriceBill.AutoSize = true;
            this.totalPriceBill.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceBill.ForeColor = System.Drawing.Color.White;
            this.totalPriceBill.Location = new System.Drawing.Point(1023, 27);
            this.totalPriceBill.Name = "totalPriceBill";
            this.totalPriceBill.Size = new System.Drawing.Size(163, 35);
            this.totalPriceBill.TabIndex = 10;
            this.totalPriceBill.Text = "Tổng số tiền: 0";
            // 
            // cbBook
            // 
            this.cbBook.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(125, 23);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(562, 39);
            this.cbBook.TabIndex = 9;
            this.cbBook.SelectedIndexChanged += new System.EventHandler(this.cbBook_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(867, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 45);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(431, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(182, 45);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // btnChange
            // 
            this.btnChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChange.BackgroundImage")));
            this.btnChange.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(650, 139);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(182, 45);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // numBookQuantity
            // 
            this.numBookQuantity.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBookQuantity.Location = new System.Drawing.Point(818, 25);
            this.numBookQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBookQuantity.Name = "numBookQuantity";
            this.numBookQuantity.Size = new System.Drawing.Size(135, 34);
            this.numBookQuantity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bricolage Grotesque 24pt SemiBo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(707, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bricolage Grotesque 24pt SemiBo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sách";
            // 
            // titleBill
            // 
            this.titleBill.AutoSize = true;
            this.titleBill.BackColor = System.Drawing.Color.Transparent;
            this.titleBill.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBill.ForeColor = System.Drawing.Color.White;
            this.titleBill.Location = new System.Drawing.Point(617, 19);
            this.titleBill.Name = "titleBill";
            this.titleBill.Size = new System.Drawing.Size(255, 43);
            this.titleBill.TabIndex = 4;
            this.titleBill.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // dgDetailBill
            // 
            this.dgDetailBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDetailBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetailBill.Location = new System.Drawing.Point(36, 75);
            this.dgDetailBill.Name = "dgDetailBill";
            this.dgDetailBill.RowHeadersWidth = 62;
            this.dgDetailBill.RowTemplate.Height = 28;
            this.dgDetailBill.Size = new System.Drawing.Size(1423, 517);
            this.dgDetailBill.TabIndex = 3;
            this.dgDetailBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetailBill_CellClick);
            // 
            // FormDetailBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Index.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(1498, 834);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleBill);
            this.Controls.Add(this.dgDetailBill);
            this.Name = "FormDetailBill";
            this.Text = "FormDetailBill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBookQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalPriceBill;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.NumericUpDown numBookQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titleBill;
        private System.Windows.Forms.DataGridView dgDetailBill;
    }
}