namespace TaskProductWithCode.Views
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.txtIDproduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNameProduct = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateCreate = new System.Windows.Forms.DateTimePicker();
            this.dataProduct = new System.Windows.Forms.DataGridView();
            this.datacqrbarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacNameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacDateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btPicture = new System.Windows.Forms.Button();
            this.ofdSelectPricture = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.rbQrcode = new System.Windows.Forms.RadioButton();
            this.rbBarcode = new System.Windows.Forms.RadioButton();
            this.btPrint = new System.Windows.Forms.Button();
            this.ptbSaveImage = new System.Windows.Forms.PictureBox();
            this.printPreQrBarcode = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocQRbarcode = new System.Drawing.Printing.PrintDocument();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.txtNumberof = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSaveImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDproduct
            // 
            this.txtIDproduct.Location = new System.Drawing.Point(203, 33);
            this.txtIDproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDproduct.Name = "txtIDproduct";
            this.txtIDproduct.Size = new System.Drawing.Size(169, 22);
            this.txtIDproduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm";
            // 
            // lbNameProduct
            // 
            this.lbNameProduct.AutoSize = true;
            this.lbNameProduct.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameProduct.Location = new System.Drawing.Point(83, 89);
            this.lbNameProduct.Name = "lbNameProduct";
            this.lbNameProduct.Size = new System.Drawing.Size(100, 19);
            this.lbNameProduct.TabIndex = 2;
            this.lbNameProduct.Text = "Tên sản phẩm";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(83, 140);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(33, 19);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mô tả";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(203, 85);
            this.txtNameProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(169, 22);
            this.txtNameProduct.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(203, 140);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(172, 22);
            this.txtPrice.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(588, 84);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(187, 22);
            this.txtDescription.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(12, 329);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 34);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(418, 329);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 34);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ngày tạo";
            // 
            // dtpDateCreate
            // 
            this.dtpDateCreate.CalendarFont = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateCreate.CustomFormat = "dd/MM, yyyy HH:mm:ss tt";
            this.dtpDateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateCreate.Location = new System.Drawing.Point(588, 31);
            this.dtpDateCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateCreate.Name = "dtpDateCreate";
            this.dtpDateCreate.Size = new System.Drawing.Size(187, 22);
            this.dtpDateCreate.TabIndex = 17;
            // 
            // dataProduct
            // 
            this.dataProduct.AllowUserToAddRows = false;
            this.dataProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datacqrbarCode,
            this.datacNameProduct,
            this.datacPrice,
            this.datacDateCreate,
            this.datacDescription});
            this.dataProduct.Location = new System.Drawing.Point(2, 401);
            this.dataProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataProduct.Name = "dataProduct";
            this.dataProduct.RowHeadersWidth = 51;
            this.dataProduct.RowTemplate.Height = 24;
            this.dataProduct.Size = new System.Drawing.Size(883, 383);
            this.dataProduct.TabIndex = 18;
            this.dataProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProduct_CellClick);
            this.dataProduct.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProduct_CellEndEdit);
            this.dataProduct.Click += new System.EventHandler(this.dataProduct_Click);
            // 
            // datacqrbarCode
            // 
            this.datacqrbarCode.HeaderText = "Mã code";
            this.datacqrbarCode.MinimumWidth = 6;
            this.datacqrbarCode.Name = "datacqrbarCode";
            // 
            // datacNameProduct
            // 
            this.datacNameProduct.HeaderText = "Tên sản phẩm";
            this.datacNameProduct.MinimumWidth = 6;
            this.datacNameProduct.Name = "datacNameProduct";
            // 
            // datacPrice
            // 
            this.datacPrice.HeaderText = "Giá sản phẩm";
            this.datacPrice.MinimumWidth = 6;
            this.datacPrice.Name = "datacPrice";
            this.datacPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.datacPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // datacDateCreate
            // 
            this.datacDateCreate.HeaderText = "Ngày tạo ";
            this.datacDateCreate.MinimumWidth = 6;
            this.datacDateCreate.Name = "datacDateCreate";
            // 
            // datacDescription
            // 
            this.datacDescription.HeaderText = "Mô tả sản phẩm";
            this.datacDescription.MinimumWidth = 6;
            this.datacDescription.Name = "datacDescription";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(203, 329);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 34);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(588, 136);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 22);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tìm kiếm";
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(833, 134);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(192, 24);
            this.cbSearch.TabIndex = 23;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(829, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Sản phẩm cần tìm";
            // 
            // btPicture
            // 
            this.btPicture.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPicture.Location = new System.Drawing.Point(87, 192);
            this.btPicture.Name = "btPicture";
            this.btPicture.Size = new System.Drawing.Size(93, 30);
            this.btPicture.TabIndex = 25;
            this.btPicture.Text = "Hình ảnh";
            this.btPicture.UseVisualStyleBackColor = true;
            this.btPicture.Click += new System.EventHandler(this.btPicture_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(472, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Chọn loại mã in";
            // 
            // rbQrcode
            // 
            this.rbQrcode.AutoSize = true;
            this.rbQrcode.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQrcode.Location = new System.Drawing.Point(637, 235);
            this.rbQrcode.Name = "rbQrcode";
            this.rbQrcode.Size = new System.Drawing.Size(112, 23);
            this.rbQrcode.TabIndex = 28;
            this.rbQrcode.TabStop = true;
            this.rbQrcode.Text = "Mã QRcode";
            this.rbQrcode.UseVisualStyleBackColor = true;
            // 
            // rbBarcode
            // 
            this.rbBarcode.AutoSize = true;
            this.rbBarcode.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBarcode.Location = new System.Drawing.Point(637, 190);
            this.rbBarcode.Name = "rbBarcode";
            this.rbBarcode.Size = new System.Drawing.Size(110, 23);
            this.rbBarcode.TabIndex = 27;
            this.rbBarcode.TabStop = true;
            this.rbBarcode.Text = "Mã barcode";
            this.rbBarcode.UseVisualStyleBackColor = true;
            // 
            // btPrint
            // 
            this.btPrint.BackColor = System.Drawing.Color.DarkCyan;
            this.btPrint.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Location = new System.Drawing.Point(637, 329);
            this.btPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(128, 34);
            this.btPrint.TabIndex = 30;
            this.btPrint.Text = "In";
            this.btPrint.UseVisualStyleBackColor = false;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // ptbSaveImage
            // 
            this.ptbSaveImage.Location = new System.Drawing.Point(203, 192);
            this.ptbSaveImage.Name = "ptbSaveImage";
            this.ptbSaveImage.Size = new System.Drawing.Size(192, 106);
            this.ptbSaveImage.TabIndex = 26;
            this.ptbSaveImage.TabStop = false;
            // 
            // printPreQrBarcode
            // 
            this.printPreQrBarcode.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreQrBarcode.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreQrBarcode.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreQrBarcode.Document = this.printDocQRbarcode;
            this.printPreQrBarcode.Enabled = true;
            this.printPreQrBarcode.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreQrBarcode.Icon")));
            this.printPreQrBarcode.Name = "printPreviewDialog1";
            this.printPreQrBarcode.Visible = false;
            // 
            // printDocQRbarcode
            // 
            this.printDocQRbarcode.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocQRbarcode_PrintPage);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtNumberof
            // 
            this.txtNumberof.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberof.Location = new System.Drawing.Point(588, 275);
            this.txtNumberof.Name = "txtNumberof";
            this.txtNumberof.Size = new System.Drawing.Size(187, 27);
            this.txtNumberof.TabIndex = 33;
            this.txtNumberof.Text = "Nhập số lượng cần in";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 785);
            this.Controls.Add(this.txtNumberof);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbQrcode);
            this.Controls.Add(this.rbBarcode);
            this.Controls.Add(this.ptbSaveImage);
            this.Controls.Add(this.btPicture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataProduct);
            this.Controls.Add(this.dtpDateCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbNameProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDproduct);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProduct";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSaveImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDproduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNameProduct;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateCreate;
        private System.Windows.Forms.DataGridView dataProduct;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btPicture;
        private System.Windows.Forms.PictureBox ptbSaveImage;
        private System.Windows.Forms.OpenFileDialog ofdSelectPricture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbQrcode;
        private System.Windows.Forms.RadioButton rbBarcode;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreQrBarcode;
        private System.Drawing.Printing.PrintDocument printDocQRbarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacqrbarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacNameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacDateCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacDescription;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox txtNumberof;
    }
}