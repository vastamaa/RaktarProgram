
namespace RaktarProgram
{
    partial class Products
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.lblAddNumber = new System.Windows.Forms.Label();
            this.tbAddNumber = new System.Windows.Forms.TextBox();
            this.tbAddProduct = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDelTitle = new System.Windows.Forms.Label();
            this.tbDelNumber = new System.Windows.Forms.TextBox();
            this.lblDelNumber = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblRTBTitle = new System.Windows.Forms.Label();
            this.myDataGridView = new System.Windows.Forms.DataGridView();
            this.tbAddCost = new System.Windows.Forms.TextBox();
            this.lblAddCost = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddTitle.Location = new System.Drawing.Point(276, 7);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(133, 16);
            this.lblAddTitle.TabIndex = 0;
            this.lblAddTitle.Text = "Új termék felvétele";
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddProduct.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddProduct.Location = new System.Drawing.Point(186, 62);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(85, 16);
            this.lblAddProduct.TabIndex = 1;
            this.lblAddProduct.Text = "Terméknév:";
            // 
            // lblAddNumber
            // 
            this.lblAddNumber.AutoSize = true;
            this.lblAddNumber.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddNumber.Location = new System.Drawing.Point(198, 39);
            this.lblAddNumber.Name = "lblAddNumber";
            this.lblAddNumber.Size = new System.Drawing.Size(73, 16);
            this.lblAddNumber.TabIndex = 2;
            this.lblAddNumber.Text = "Cikkszám:";
            // 
            // tbAddNumber
            // 
            this.tbAddNumber.Location = new System.Drawing.Point(279, 35);
            this.tbAddNumber.Name = "tbAddNumber";
            this.tbAddNumber.ShortcutsEnabled = false;
            this.tbAddNumber.Size = new System.Drawing.Size(130, 20);
            this.tbAddNumber.TabIndex = 3;
            this.tbAddNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbAddNumber_KeyPress);
            // 
            // tbAddProduct
            // 
            this.tbAddProduct.Location = new System.Drawing.Point(279, 61);
            this.tbAddProduct.Name = "tbAddProduct";
            this.tbAddProduct.ShortcutsEnabled = false;
            this.tbAddProduct.Size = new System.Drawing.Size(130, 20);
            this.tbAddProduct.TabIndex = 4;
            this.tbAddProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbAddProduct_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.ForeColor = System.Drawing.Color.LightGray;
            this.btnAdd.Location = new System.Drawing.Point(304, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 24);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Hozzáadás";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.BtnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.BtnAdd_MouseLeave);
            // 
            // lblDelTitle
            // 
            this.lblDelTitle.AutoSize = true;
            this.lblDelTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDelTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDelTitle.Location = new System.Drawing.Point(291, 156);
            this.lblDelTitle.Name = "lblDelTitle";
            this.lblDelTitle.Size = new System.Drawing.Size(105, 16);
            this.lblDelTitle.TabIndex = 7;
            this.lblDelTitle.Text = "Termék törlése";
            // 
            // tbDelNumber
            // 
            this.tbDelNumber.Location = new System.Drawing.Point(279, 191);
            this.tbDelNumber.Name = "tbDelNumber";
            this.tbDelNumber.ShortcutsEnabled = false;
            this.tbDelNumber.Size = new System.Drawing.Size(130, 20);
            this.tbDelNumber.TabIndex = 8;
            this.tbDelNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbDelNumber_KeyPress);
            // 
            // lblDelNumber
            // 
            this.lblDelNumber.AutoSize = true;
            this.lblDelNumber.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDelNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDelNumber.Location = new System.Drawing.Point(198, 192);
            this.lblDelNumber.Name = "lblDelNumber";
            this.lblDelNumber.Size = new System.Drawing.Size(73, 16);
            this.lblDelNumber.TabIndex = 9;
            this.lblDelNumber.Text = "Cikkszám:";
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDel.ForeColor = System.Drawing.Color.LightGray;
            this.btnDel.Location = new System.Drawing.Point(304, 221);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(82, 24);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Töröl";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            this.btnDel.MouseEnter += new System.EventHandler(this.BtnDel_MouseEnter);
            this.btnDel.MouseLeave += new System.EventHandler(this.BtnDel_MouseLeave);
            // 
            // lblRTBTitle
            // 
            this.lblRTBTitle.AutoSize = true;
            this.lblRTBTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRTBTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRTBTitle.Location = new System.Drawing.Point(13, 18);
            this.lblRTBTitle.Name = "lblRTBTitle";
            this.lblRTBTitle.Size = new System.Drawing.Size(120, 16);
            this.lblRTBTitle.TabIndex = 11;
            this.lblRTBTitle.Text = "Termékek listája:";
            // 
            // myDataGridView
            // 
            this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView.Location = new System.Drawing.Point(16, 95);
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.RowHeadersVisible = false;
            this.myDataGridView.Size = new System.Drawing.Size(168, 150);
            this.myDataGridView.TabIndex = 12;
            // 
            // tbAddCost
            // 
            this.tbAddCost.Location = new System.Drawing.Point(279, 87);
            this.tbAddCost.Name = "tbAddCost";
            this.tbAddCost.ShortcutsEnabled = false;
            this.tbAddCost.Size = new System.Drawing.Size(130, 20);
            this.tbAddCost.TabIndex = 13;
            this.tbAddCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbAddCost_KeyPress);
            // 
            // lblAddCost
            // 
            this.lblAddCost.AutoSize = true;
            this.lblAddCost.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddCost.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddCost.Location = new System.Drawing.Point(243, 88);
            this.lblAddCost.Name = "lblAddCost";
            this.lblAddCost.Size = new System.Drawing.Size(28, 16);
            this.lblAddCost.TabIndex = 14;
            this.lblAddCost.Text = "Ár:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.ForeColor = System.Drawing.Color.LightGray;
            this.btnRefresh.Location = new System.Drawing.Point(16, 61);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 24);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Frissítés";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            this.btnRefresh.MouseEnter += new System.EventHandler(this.BtnRefresh_MouseEnter);
            this.btnRefresh.MouseLeave += new System.EventHandler(this.BtnRefresh_MouseLeave);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblAddCost);
            this.Controls.Add(this.tbAddCost);
            this.Controls.Add(this.myDataGridView);
            this.Controls.Add(this.lblRTBTitle);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblDelNumber);
            this.Controls.Add(this.tbDelNumber);
            this.Controls.Add(this.lblDelTitle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbAddProduct);
            this.Controls.Add(this.tbAddNumber);
            this.Controls.Add(this.lblAddNumber);
            this.Controls.Add(this.lblAddProduct);
            this.Controls.Add(this.lblAddTitle);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(440, 265);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.Label lblAddNumber;
        private System.Windows.Forms.TextBox tbAddNumber;
        private System.Windows.Forms.TextBox tbAddProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDelTitle;
        private System.Windows.Forms.TextBox tbDelNumber;
        private System.Windows.Forms.Label lblDelNumber;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblRTBTitle;
        private System.Windows.Forms.DataGridView myDataGridView;
        private System.Windows.Forms.TextBox tbAddCost;
        private System.Windows.Forms.Label lblAddCost;
        private System.Windows.Forms.Button btnRefresh;
    }
}
