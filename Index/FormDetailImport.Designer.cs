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
            this.dgDetailImport = new System.Windows.Forms.DataGridView();
            this.titleImport = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.numPriceImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBookQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDetailImport
            // 
            this.dgDetailImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDetailImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetailImport.Location = new System.Drawing.Point(36, 75);
            this.dgDetailImport.Name = "dgDetailImport";
            this.dgDetailImport.RowHeadersWidth = 62;
            this.dgDetailImport.RowTemplate.Height = 28;
            this.dgDetailImport.Size = new System.Drawing.Size(1423, 517);
            this.dgDetailImport.TabIndex = 0;
            this.dgDetailImport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetailImport_CellClick);
            // 
            // titleImport
            // 
            this.titleImport.AutoSize = true;
            this.titleImport.BackColor = System.Drawing.Color.Transparent;
            this.titleImport.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleImport.ForeColor = System.Drawing.Color.White;
            this.titleImport.Location = new System.Drawing.Point(612, 18);
            this.titleImport.Name = "titleImport";
            this.titleImport.Size = new System.Drawing.Size(294, 43);
            this.titleImport.TabIndex = 1;
            this.titleImport.Text = "CHI TIẾT PHIẾU NHẬP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.totalPriceImport);
            this.panel1.Controls.Add(this.cbBook);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.numPriceImport);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numBookQuantity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 611);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1474, 211);
            this.panel1.TabIndex = 2;
            // 
            // totalPriceImport
            // 
            this.totalPriceImport.AutoSize = true;
            this.totalPriceImport.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceImport.ForeColor = System.Drawing.Color.White;
            this.totalPriceImport.Location = new System.Drawing.Point(631, 90);
            this.totalPriceImport.Name = "totalPriceImport";
            this.totalPriceImport.Size = new System.Drawing.Size(163, 35);
            this.totalPriceImport.TabIndex = 10;
            this.totalPriceImport.Text = "Tổng số tiền: 0";
            // 
            // cbBook
            // 
            this.cbBook.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(126, 10);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(562, 39);
            this.cbBook.TabIndex = 9;
            this.cbBook.SelectedIndexChanged += new System.EventHandler(this.cbBook_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Index.Properties.Resources.btn;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(867, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 45);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Index.Properties.Resources.btn;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(431, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(182, 45);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackgroundImage = global::Index.Properties.Resources.btn;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(650, 155);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(182, 45);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numPriceImport
            // 
            this.numPriceImport.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPriceImport.Location = new System.Drawing.Point(1092, 15);
            this.numPriceImport.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPriceImport.Name = "numPriceImport";
            this.numPriceImport.Size = new System.Drawing.Size(365, 34);
            this.numPriceImport.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(983, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá nhập";
            // 
            // numBookQuantity
            // 
            this.numBookQuantity.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBookQuantity.Location = new System.Drawing.Point(819, 15);
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
            this.label3.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(708, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bricolage Grotesque 24pt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sách";
            // 
            // FormDetailImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Index.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(1498, 834);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleImport);
            this.Controls.Add(this.dgDetailImport);
            this.Name = "FormDetailImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetailImport";
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailImport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}