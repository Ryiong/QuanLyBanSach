using System.Windows.Forms;

namespace Index
{
    partial class FormDetailImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailImport));
            this.dgDetailImport = new System.Windows.Forms.DataGridView();
            this.titleImport = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalPriceImport = new System.Windows.Forms.Label();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.numPriceImport = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numBookQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailImport)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBookQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDetailImport
            // 
            this.dgDetailImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDetailImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetailImport.Location = new System.Drawing.Point(24, 49);
            this.dgDetailImport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgDetailImport.Name = "dgDetailImport";
            this.dgDetailImport.RowHeadersWidth = 62;
            this.dgDetailImport.RowTemplate.Height = 28;
            this.dgDetailImport.Size = new System.Drawing.Size(949, 336);
            this.dgDetailImport.TabIndex = 0;
            this.dgDetailImport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetailImport_CellClick);
            // 
            // titleImport
            // 
            this.titleImport.AutoSize = true;
            this.titleImport.BackColor = System.Drawing.Color.Transparent;
            this.titleImport.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleImport.ForeColor = System.Drawing.Color.White;
            this.titleImport.Location = new System.Drawing.Point(408, 12);
            this.titleImport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleImport.Name = "titleImport";
            this.titleImport.Size = new System.Drawing.Size(198, 30);
            this.titleImport.TabIndex = 1;
            this.titleImport.Text = "CHI TIẾT PHIẾU NHẬP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbBook);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.numPriceImport);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numBookQuantity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 397);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 137);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Index.Properties.Resources.label1;
            this.panel2.Controls.Add(this.totalPriceImport);
            this.panel2.Location = new System.Drawing.Point(368, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 35);
            this.panel2.TabIndex = 11;
            // 
            // totalPriceImport
            // 
            this.totalPriceImport.AutoSize = true;
            this.totalPriceImport.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceImport.ForeColor = System.Drawing.Color.White;
            this.totalPriceImport.Location = new System.Drawing.Point(12, 6);
            this.totalPriceImport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPriceImport.Name = "totalPriceImport";
            this.totalPriceImport.Size = new System.Drawing.Size(111, 23);
            this.totalPriceImport.TabIndex = 10;
            this.totalPriceImport.Text = "Tổng số tiền: 0";
            // 
            // cbBook
            // 
            this.cbBook.DropDownHeight = 75;
            this.cbBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBook.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBook.FormattingEnabled = true;
            this.cbBook.IntegralHeight = false;
            this.cbBook.Location = new System.Drawing.Point(84, 6);
            this.cbBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(376, 28);
            this.cbBook.TabIndex = 9;
            this.cbBook.SelectedIndexChanged += new System.EventHandler(this.cbBook_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(578, 101);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 31);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(287, 101);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 31);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChange.BackgroundImage")));
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(433, 101);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(126, 31);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numPriceImport
            // 
            this.numPriceImport.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPriceImport.Location = new System.Drawing.Point(728, 10);
            this.numPriceImport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numPriceImport.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPriceImport.Name = "numPriceImport";
            this.numPriceImport.Size = new System.Drawing.Size(243, 25);
            this.numPriceImport.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(655, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá nhập";
            // 
            // numBookQuantity
            // 
            this.numBookQuantity.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBookQuantity.Location = new System.Drawing.Point(546, 10);
            this.numBookQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numBookQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBookQuantity.Name = "numBookQuantity";
            this.numBookQuantity.Size = new System.Drawing.Size(90, 25);
            this.numBookQuantity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(472, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sách";
            // 
            // FormDetailImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Index.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(999, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleImport);
            this.Controls.Add(this.dgDetailImport);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDetailImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetailImport";
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailImport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBookQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDetailImport;
        private System.Windows.Forms.Label titleImport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numBookQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.NumericUpDown numPriceImport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalPriceImport;
        private System.Windows.Forms.ComboBox cbBook;
        private Panel panel2;
    }
}