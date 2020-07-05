using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskProductWithCode.Controller;
using TaskProductWithCode.Models;


namespace TaskProductWithCode.Views
{
    public partial class frmDisplayProduct : Form
    {
        public frmDisplayProduct()
        {
            InitializeComponent();
            this.cIDProduct.DataPropertyName = nameof(Product.codeBarQR);
            this.cNamProduct.DataPropertyName = nameof(Product.nameProduct);
            this.cPrice.DataPropertyName = nameof(Product.Price);
            this.cDataCreate.DataPropertyName = nameof(Product.dateCreate);
            this.cDescription.DataPropertyName = nameof(Product.Descriptions);
            this.dataGridView1.AutoGenerateColumns = false;
            BindingSource source = new BindingSource();
            source.DataSource = ProductController.getlistProduct();
            this.dataGridView1.DataSource = source;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = ProductController.getlistProduct(this.textBox1.Text.Trim());
            this.dataGridView1.DataSource = source;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()=="")    
            {
                BindingSource source = new BindingSource();
                source.DataSource = ProductController.getlistProduct();
                this.dataGridView1.DataSource = source;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
