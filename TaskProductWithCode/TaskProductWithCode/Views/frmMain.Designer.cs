namespace TaskProductWithCode.Views
{
    partial class btPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btPrint));
            this.btListProduct = new System.Windows.Forms.Button();
            this.btnCloseMain = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btListProduct
            // 
            this.btListProduct.BackgroundImage = global::TaskProductWithCode.Properties.Resources.download;
            resources.ApplyResources(this.btListProduct, "btListProduct");
            this.btListProduct.ForeColor = System.Drawing.Color.ForestGreen;
            this.btListProduct.Name = "btListProduct";
            this.btListProduct.UseVisualStyleBackColor = true;
            this.btListProduct.Click += new System.EventHandler(this.btListProduct_Click);
            // 
            // btnCloseMain
            // 
            this.btnCloseMain.BackgroundImage = global::TaskProductWithCode.Properties.Resources.image_Close;
            this.btnCloseMain.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.btnCloseMain, "btnCloseMain");
            this.btnCloseMain.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCloseMain.Name = "btnCloseMain";
            this.btnCloseMain.UseVisualStyleBackColor = true;
            this.btnCloseMain.Click += new System.EventHandler(this.btnCloseMain_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackgroundImage = global::TaskProductWithCode.Properties.Resources.Add_Product;
            resources.ApplyResources(this.btnProduct, "btnProduct");
            this.btnProduct.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btPrint
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TaskProductWithCode.Properties.Resources._0_glguLZmY3H2gltmQ1;
            this.Controls.Add(this.btListProduct);
            this.Controls.Add(this.btnCloseMain);
            this.Controls.Add(this.btnProduct);
            this.Name = "btPrint";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCloseMain;
        private System.Windows.Forms.Button btListProduct;
    }
}

