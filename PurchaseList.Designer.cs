
namespace PurchaseWinform
{
    partial class PurchaseList
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.UserInfo = new System.Windows.Forms.Label();
            this.Print = new System.Windows.Forms.Button();
            this.CrystalReport11 = new PurchaseWinform.CrystalReport1();
            this.Insert = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(826, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(301, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "進貨單管理";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(547, 31);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(67, 15);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "商品管理";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // UserInfo
            // 
            this.UserInfo.AutoSize = true;
            this.UserInfo.Location = new System.Drawing.Point(640, 31);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(41, 15);
            this.UserInfo.TabIndex = 4;
            this.UserInfo.Text = "label2";
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(181, 91);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 37);
            this.Print.TabIndex = 5;
            this.Print.Text = "輸出";
            this.Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Insert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Insert.Location = new System.Drawing.Point(13, 87);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(78, 44);
            this.Insert.TabIndex = 6;
            this.Insert.Text = "新增";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delete.Location = new System.Drawing.Point(97, 87);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(78, 44);
            this.delete.TabIndex = 7;
            this.delete.Text = "刪除";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // PurchaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 538);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.UserInfo);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PurchaseList";
            this.Text = "PurchaseListcs";
            this.Load += new System.EventHandler(this.PurchaseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label UserInfo;
        private System.Windows.Forms.Button Print;
        private CrystalReport1 CrystalReport11;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button delete;
    }
}