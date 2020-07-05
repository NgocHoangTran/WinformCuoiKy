namespace TaskProductWithCode.Views
{
    partial class frmDisplayProduct
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
            this.cIDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNamProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDProduct,
            this.cNamProduct,
            this.cPrice,
            this.cDataCreate,
            this.cDescription});
            this.dataGridView1.Location = new System.Drawing.Point(12, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // cIDProduct
            // 
            this.cIDProduct.HeaderText = "Mã sản phẩm";
            this.cIDProduct.MinimumWidth = 6;
            this.cIDProduct.Name = "cIDProduct";
            // 
            // cNamProduct
            // 
            this.cNamProduct.HeaderText = "Tên sản phẩm";
            this.cNamProduct.MinimumWidth = 6;
            this.cNamProduct.Name = "cNamProduct";
            // 
            // cPrice
            // 
            this.cPrice.HeaderText = "Giá";
            this.cPrice.MinimumWidth = 6;
            this.cPrice.Name = "cPrice";
            // 
            // cDataCreate
            // 
            this.cDataCreate.HeaderText = "Ngày tạo";
            this.cDataCreate.MinimumWidth = 6;
            this.cDataCreate.Name = "cDataCreate";
            // 
            // cDescription
            // 
            this.cDescription.HeaderText = "Mô tả";
            this.cDescription.MinimumWidth = 6;
            this.cDescription.Name = "cDescription";
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSearch.Location = new System.Drawing.Point(12, 37);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(138, 37);
            this.btSearch.TabIndex = 1;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(509, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(573, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDisplayProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDisplayProduct";
            this.Text = "Danh sách sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNamProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescription;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}