using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskProductWithCode.Controller;
using TaskProductWithCode.Models;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TaskProductWithCode.Views
{
    public partial class frmProduct : Form
    {
        string duongdan;
        int j=0;
        int Numberof;
        int totalnumber = 0;
        int itemperpage = 0;

        public frmProduct()
        {
            InitializeComponent();
            this.datacqrbarCode.DataPropertyName = nameof(Product.codeBarQR);
            this.datacNameProduct.DataPropertyName = nameof(Product.nameProduct);
            this.datacPrice.DataPropertyName = nameof(Product.Price);
            this.datacDateCreate.DataPropertyName = nameof(Product.dateCreate);
            this.datacDescription.DataPropertyName = nameof(Product.Descriptions);
            this.dataProduct.AutoGenerateColumns = false;
            List<Product> productList = new List<Product>();
            productList = ProductController.getlistProduct();
            for (int i = 0; i < productList.Count; i++)
            {
                if (productList[i].pathImage == null)
                {
                    ProductController.DeleteProduct(productList[i]);
                }
            }
            BindingSource source = new BindingSource();
            source.DataSource = ProductController.getlistProduct();
            this.dataProduct.DataSource = source;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (this.txtIDproduct.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(txtIDproduct, "Chưa nhập ID sản phẩm");
                return;
            }
            else
                this.errorProvider1.Clear();

            if (this.txtNameProduct.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(txtNameProduct, "Chưa nhập tên sản phẩm");
                return;
            }
            else
                this.errorProvider1.Clear();

            if (this.txtPrice.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(txtPrice, "Chưa nhập giá sản phẩm");
                return;
            }
            else
                this.errorProvider1.Clear();

            if (this.txtDescription.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(txtDescription, "Chưa nhập mô tả cho sản phẩm");
                return;
            }
            else
                this.errorProvider1.Clear();
            if (this.ptbSaveImage.Image == null)
            {
                return;
            }
            // // nhap product
            Product product = new Product();
            product.codeBarQR = this.txtIDproduct.Text.Trim();
            product.nameProduct = this.txtNameProduct.Text.Trim();
            product.Price = this.txtPrice.Text.Trim();

            product.dateCreate = DateTime.Now;
            product.Descriptions = this.txtDescription.Text.Trim();
            product.pathImage = this.duongdan;

            // them product vao list
            if (ProductController.AddProduct(product) == false)
            {
                MessageBox.Show("Không thêm sản phẩm được");
                return;
            }



            // hien thi list len datagridview
            BindingSource source = new BindingSource();
            source.DataSource = ProductController.getlistProduct();
            this.dataProduct.DataSource = source;
        
            

            // clear cac txt de nhap thong tin product 
            this.txtIDproduct.Clear();
            this.txtNameProduct.Clear();
            this.txtPrice.Clear();
            this.txtDescription.Clear();
            this.dtpDateCreate.Value = DateTime.Now;
            this.ptbSaveImage.CreateGraphics().Clear(Color.White);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataProduct.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chọn hàng để xóa");
                return;
            }
            if (this.dataProduct.SelectedRows[0].Cells[0].Value is null)
            {
                MessageBox.Show("Không có giá trị để xóa");
                return;
            }
            else
            {
                Product product = ProductController.getProduct(this.dataProduct.SelectedRows[0].Cells[0].Value.ToString());
                ProductController.DeleteProduct(product);
                BindingSource source = new BindingSource();
                source.DataSource = ProductController.getlistProduct();
                this.dataProduct.DataSource = source;

            }

        }

        private void dataProduct_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            Product product = new Product();
            
            if (this.dataProduct.CurrentRow.Cells[0].Value is null)
            {
                return;
            }
            else
            {
                product.codeBarQR = this.dataProduct.CurrentRow.Cells[0].Value.ToString();
            }
            if (product.codeBarQR.Length <= 0)
            {
                return;
            }
            
            try
            {

                product.nameProduct = this.dataProduct.CurrentRow.Cells[1].Value.ToString();
                product.Price = this.dataProduct.CurrentRow.Cells[2].Value.ToString();
                product.dateCreate = DateTime.Parse(dataProduct.CurrentRow.Cells[3].Value.ToString());
                product.Descriptions = this.dataProduct.CurrentRow.Cells[4].Value.ToString();
                //product.pathImage=this.duongdan;

            }
            catch
            {
                //product.nameProduct = "";
                //product.nameProduct = "";
                //product.dateCreate = DateTime.Now;
                //product.Descriptions = "";
                return;
            }
            this.ofdSelectPricture.ShowDialog();
            duongdan = ofdSelectPricture.FileName;
            product.pathImage = duongdan;
            ptbSaveImage.Image = Image.FromFile(duongdan);
            ProductController.UpdateProduct(product);
            BindingSource source = new BindingSource();
            source.DataSource = ProductController.getlistProduct();

        }

        private void dataProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                this.rbBarcode.Enabled = true;
                this.rbQrcode.Enabled = true;
                this.txtNumberof.Enabled = true;
                return;
            }
            
            if (this.dataProduct.Columns[e.ColumnIndex].DataPropertyName == nameof(Product.dateCreate))
            {
                dtpDateCreate = new DateTimePicker();
                dtpDateCreate.Format = DateTimePickerFormat.Short;
                dtpDateCreate.Visible = true;
                Rectangle rect = this.dataProduct.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtpDateCreate.Location = new Point(rect.X, rect.Y);
                dtpDateCreate.Size = new Size(rect.Width, rect.Height);

                try
                {
                    dtpDateCreate.Value = DateTime.Parse(dataProduct.CurrentRow.Cells[3].Value.ToString());
                }
                catch
                {
                    dtpDateCreate.Value = DateTime.Now;
                }



                dtpDateCreate.CloseUp += DtpDateCreate_CloseUp; ;
                dtpDateCreate.TextChanged += DtpDateCreate_TextChanged;
                Product product = ProductController.getProduct(this.dataProduct.CurrentRow.Cells[0].Value.ToString().Trim());
                ProductController.UpdateProduct(product);
                this.dataProduct.Controls.Add(dtpDateCreate);



            }

        }

        private void DtpDateCreate_TextChanged(object sender, EventArgs e)
        {
            this.dataProduct.CurrentCell.Value = this.dtpDateCreate.Value.ToString();
        }

        private void DtpDateCreate_CloseUp(object sender, EventArgs e)
        {
            dtpDateCreate.Visible = false;
            dtpDateCreate.Dispose();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.dataProduct.Rows[j].DefaultCellStyle.BackColor = Color.White;
            this.cbSearch.Items.Clear();
            // tim usersname trong listuser
            if (ProductController.getlistProduct(this.txtSearch.Text.Trim()) == null)
            {
                this.cbSearch.Items.Clear();
            }
            List<Product> searchProduct = ProductController.getlistProduct(this.txtSearch.Text.Trim());

            for (int i = 0; i < searchProduct.Count; i++)
            {
                this.cbSearch.Items.Add(searchProduct[i]);
            }
            if (this.txtSearch.Text == "")
            {
                this.cbSearch.Items.Clear();
            }
        }

        private void btPicture_Click(object sender, EventArgs e)
        {
            this.ofdSelectPricture.ShowDialog();
           
            duongdan = ofdSelectPricture.FileName;
            if (duongdan is null)
            {
                return;
            }
            else
            {
                this.ptbSaveImage.Image = Image.FromFile(duongdan);
            }
        }
           

        private void frmProduct_Load(object sender, EventArgs e)
        {
            this.rbBarcode.Enabled = false;
            this.rbQrcode.Enabled = false;
            this.txtNumberof.Enabled = false;
            this.helpProvider1.SetHelpString(txtIDproduct,"Nhập mã sản phẩm để in");
            this.helpProvider1.SetHelpString(txtNameProduct, "Nhập tên sản phẩm");
            this.helpProvider1.SetHelpString(txtPrice, "Giá của sản phẩm");
            this.helpProvider1.SetHelpString(txtDescription,"Mo tả sản phẩm");
            this.helpProvider1.SetHelpString(dtpDateCreate, "Ngày lưu sản phẩm");
        }

        private void btPrint_Click(object sender, EventArgs e)
        {

            try
            {
                Numberof = int.Parse(txtNumberof.Text.Trim());
                if (Numberof <= 0 )
                {
                    MessageBox.Show("Nhập số lượng ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Nhập số lượng ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbBarcode.Checked == false && rbQrcode.Checked == false)
            {
                return;
            }
            itemperpage = totalnumber = 0;
            printDocQRbarcode.DefaultPageSettings.PaperSize = new PaperSize("papersize",4*220, 5*215);
            printPreQrBarcode.Document = printDocQRbarcode;
            printPreQrBarcode.ShowDialog();

        }

        private void dataProduct_Click(object sender, EventArgs e)
        {
            if (this.dataProduct.SelectedRows.Count <= 0)
            {
                return;
            }
            if (this.dataProduct.SelectedRows[0].Cells[0].Value is null)
            {
                return;
            }
            else
            {
                Product product = ProductController.getProduct(this.dataProduct.SelectedRows[0].Cells[0].Value.ToString());
                    this.ptbSaveImage.Image = Image.FromFile(product.pathImage);
                    this.txtIDproduct.Text = product.codeBarQR;
                    this.txtNameProduct.Text = product.nameProduct;
                    this.txtPrice.Text = product.Price;
                    this.txtDescription.Text = product.Descriptions;
                    this.dtpDateCreate.Value = DateTime.Parse(product.dateCreate.ToString().Trim());
                duongdan = product.pathImage;
            }

        }

        private void printDocQRbarcode_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int hihi = Numberof / 20;
            int haha = Numberof / 12;
            string ConvertQRcode;
            string ConvertBarcode;
            ConvertBarcode = "Code product  " + txtIDproduct.Text.Trim();
            ConvertQRcode = "Code product    " + txtIDproduct.Text.Trim() + '\n' + "Name product  " + txtNameProduct.Text.Trim() + '\n' + "Price product    " + txtPrice.Text.Trim() + '\n' + "Date print code product  " + dtpDateCreate.Value.ToString(); ;
            if (rbBarcode.Checked == true)
            {
                Zen.Barcode.Code128BarcodeDraw barCodeDraw = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                var barcodeImage = barCodeDraw.Draw(ConvertBarcode, 100);
                var resultImage01 = new Bitmap(barcodeImage.Width, barcodeImage.Height);
                using (var graphics = Graphics.FromImage(resultImage01))
                using (var font = new Font("Times New Roman", 13))
                using (var brush = new SolidBrush(Color.Black))
                using (var format = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Far
                })
                {
                    graphics.Clear(Color.White);
                    graphics.DrawImage(barcodeImage, 0, 0);
                }
                if(Numberof <= 12)
                {
                    int counter = 0;
                    for (int y = -180; y < ((Numberof / 2)) * 180; y = y + 180)
                    {
                        for (int x = -400; x < 1 * 400; x = x + 400)
                        {
                            e.Graphics.DrawImage(resultImage01, new Point(x + 400, y + 180));
                            counter = counter + 1;
                            if (counter == Numberof)
                                return;

                        }
                    }
                }
                else
                {
                    for (int y = -180; y < ((Numberof / 2)) * 180; y = y + 180)
                    {
                        for (int x = -400; x < 1 * 400; x = x + 400)
                        {
                            e.Graphics.DrawImage(resultImage01, new Point(x + 400, y + 180));

                            totalnumber += 1;

                            if (totalnumber == Numberof+haha)
                                return;
                            if (itemperpage < 12)
                            {
                                itemperpage += 1;
                                e.HasMorePages = false;
                            }
                            else
                            {
                                itemperpage = 0;
                                e.HasMorePages = true;
                                return;
                            }
                        }
                    }
                }
            }

            if (rbQrcode.Checked == true)
            {
                Zen.Barcode.CodeQrBarcodeDraw QRcodeDraw = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                var QRcodeImage = QRcodeDraw.Draw(ConvertQRcode, 100);
                var resultImage02 = new Bitmap(QRcodeImage.Width, QRcodeImage.Height);
                using (var graphics = Graphics.FromImage(resultImage02))
                using (var font = new Font("Times New Roman", 13))
                using (var brush = new SolidBrush(Color.Black))
                using (var format = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Far
                })
                {
                    graphics.Clear(Color.White);
                    graphics.DrawImage(QRcodeImage, 0, 0);
                }

                //e.Graphics.DrawImage(resultImage02, new Point(0, 0));

                if (Numberof <= 20)
                {
                    int CountImage = 0;
                    for (int y = -220; y < ((Numberof / 4)) * 220; y = y + 220)
                    {
                        for (int x = -220; x < 3 * 220; x = x + 220)
                        {
                            e.Graphics.DrawImage(resultImage02, new Point(x + 220, y + 220));
                            CountImage = CountImage + 1;
                            if (CountImage == Numberof)
                                return;
                        }
                    }
                }
                else
                {
                    for (int y = -220; y < ((Numberof / 4)) * 220; y = y + 220)
                    {
                        for (int x = -220; x < 3 * 220; x = x + 220)
                        {
                            e.Graphics.DrawImage(resultImage02, new Point(x + 220, y + 220));
                            
                            totalnumber += 1;

                            if (totalnumber == Numberof+hihi)
                                return;
                            if (itemperpage < 20)
                            {
                                itemperpage += 1;
                                e.HasMorePages = false;
                            }
                            else
                            {
                                itemperpage = 0;
                                e.HasMorePages = true;
                                return;
                            }
                        }
                    }
                }

            }
        }
        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataProduct.Rows[j].DefaultCellStyle.BackColor = Color.White;
            if (this.cbSearch.SelectedIndex >= 0)
            {
                for (int i = 0; i < this.dataProduct.Rows.Count; i++)
                {
                    if (this.cbSearch.SelectedItem.ToString() == this.dataProduct.Rows[i].Cells[0].Value.ToString())
                    {
                        this.dataProduct.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        j = i;
                        return;
                    }
                }
            }
        }
    }
}
