
namespace PurchaseWinform
{
    partial class Purchase_Product_Insert
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
            this.Product = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.Label();
            this.PriceResult = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ProducrSelect = new System.Windows.Forms.ComboBox();
            this.ProductQTY = new System.Windows.Forms.TextBox();
            this.Price_1 = new System.Windows.Forms.Label();
            this.ErrMess = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(722, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.Location = new System.Drawing.Point(49, 333);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(37, 15);
            this.Product.TabIndex = 1;
            this.Product.Text = "商品";
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Location = new System.Drawing.Point(49, 369);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(37, 15);
            this.Qty.TabIndex = 2;
            this.Qty.Text = "數量";
            // 
            // PriceResult
            // 
            this.PriceResult.AutoSize = true;
            this.PriceResult.Location = new System.Drawing.Point(49, 406);
            this.PriceResult.Name = "PriceResult";
            this.PriceResult.Size = new System.Drawing.Size(37, 15);
            this.PriceResult.TabIndex = 3;
            this.PriceResult.Text = "小計";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(52, 446);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "加入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(158, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ProducrSelect
            // 
            this.ProducrSelect.FormattingEnabled = true;
            this.ProducrSelect.Location = new System.Drawing.Point(112, 330);
            this.ProducrSelect.Name = "ProducrSelect";
            this.ProducrSelect.Size = new System.Drawing.Size(121, 23);
            this.ProducrSelect.TabIndex = 6;
            this.ProducrSelect.SelectedIndexChanged += new System.EventHandler(this.ProducrSelect_SelectedIndexChanged);
            // 
            // ProductQTY
            // 
            this.ProductQTY.Location = new System.Drawing.Point(112, 369);
            this.ProductQTY.Name = "ProductQTY";
            this.ProductQTY.Size = new System.Drawing.Size(121, 25);
            this.ProductQTY.TabIndex = 7;
            this.ProductQTY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProductQTY_KeyUp);
            // 
            // Price_1
            // 
            this.Price_1.AutoSize = true;
            this.Price_1.Location = new System.Drawing.Point(109, 406);
            this.Price_1.Name = "Price_1";
            this.Price_1.Size = new System.Drawing.Size(0, 15);
            this.Price_1.TabIndex = 8;
            // 
            // ErrMess
            // 
            this.ErrMess.AutoSize = true;
            this.ErrMess.Location = new System.Drawing.Point(336, 333);
            this.ErrMess.Name = "ErrMess";
            this.ErrMess.Size = new System.Drawing.Size(0, 15);
            this.ErrMess.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "商品列表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(30, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(29, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "*";
            // 
            // Purchase_Product_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrMess);
            this.Controls.Add(this.Price_1);
            this.Controls.Add(this.ProductQTY);
            this.Controls.Add(this.ProducrSelect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.PriceResult);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Purchase_Product_Insert";
            this.Text = "Purchase_Product_Insert";
            this.Load += new System.EventHandler(this.Purchase_Product_Insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Product;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.Label PriceResult;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox ProducrSelect;
        private System.Windows.Forms.TextBox ProductQTY;
        private System.Windows.Forms.Label Price_1;
        private System.Windows.Forms.Label ErrMess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}