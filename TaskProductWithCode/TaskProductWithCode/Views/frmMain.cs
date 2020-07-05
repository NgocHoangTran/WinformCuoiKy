using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskProductWithCode.Views;

namespace TaskProductWithCode.Views
{
    public partial class btPrint : Form
    {
        frmProduct fromProduct;
        frmDisplayProduct fromdp;
        public btPrint()
        {
            InitializeComponent();
        }

       
        

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if(this.fromProduct is null || this.fromProduct.IsDisposed)
            {
                this.fromProduct = new frmProduct();
                this.fromProduct.Show();
            }
            else
            {
                this.fromProduct.Select();
            }
        }

        private void btnCloseMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btListProduct_Click(object sender, EventArgs e)
        {

            if (this.fromdp is null || this.fromdp.IsDisposed)
            {
                this.fromdp = new frmDisplayProduct();
                this.fromdp.Show();
            }
            else
            {
                this.fromdp.Select();
            }
        }
    }
}
