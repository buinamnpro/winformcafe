namespace qlcafe
{
    partial class maintable
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adiminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHongTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvbill = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbcategory = new System.Windows.Forms.ComboBox();
            this.cbfood = new System.Windows.Forms.ComboBox();
            this.btnaddfood = new System.Windows.Forms.Button();
            this.nmfoodcount = new System.Windows.Forms.NumericUpDown();
            this.pnltable = new System.Windows.Forms.FlowLayoutPanel();
            this.btnpay = new System.Windows.Forms.Button();
            this.btndiscount = new System.Windows.Forms.Button();
            this.nmdiscount = new System.Windows.Forms.NumericUpDown();
            this.btnswitchtable = new System.Windows.Forms.Button();
            this.cbswitchtable = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmfoodcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adiminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adiminToolStripMenuItem
            // 
            this.adiminToolStripMenuItem.Name = "adiminToolStripMenuItem";
            this.adiminToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.adiminToolStripMenuItem.Text = "Adimin";
            this.adiminToolStripMenuItem.Click += new System.EventHandler(this.adiminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tHongTinCáNhânToolStripMenuItem,
            this.đăngToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "thông tin tài khoản ";
            // 
            // tHongTinCáNhânToolStripMenuItem
            // 
            this.tHongTinCáNhânToolStripMenuItem.Name = "tHongTinCáNhânToolStripMenuItem";
            this.tHongTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tHongTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.tHongTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.tHongTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngToolStripMenuItem
            // 
            this.đăngToolStripMenuItem.Name = "đăngToolStripMenuItem";
            this.đăngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngToolStripMenuItem.Click += new System.EventHandler(this.đăngToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvbill);
            this.panel2.Location = new System.Drawing.Point(542, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 400);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbswitchtable);
            this.panel3.Controls.Add(this.btnswitchtable);
            this.panel3.Controls.Add(this.nmdiscount);
            this.panel3.Controls.Add(this.btndiscount);
            this.panel3.Controls.Add(this.btnpay);
            this.panel3.Location = new System.Drawing.Point(542, 532);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 70);
            this.panel3.TabIndex = 3;
            // 
            // lsvbill
            // 
            this.lsvbill.HideSelection = false;
            this.lsvbill.Location = new System.Drawing.Point(6, 18);
            this.lsvbill.Name = "lsvbill";
            this.lsvbill.Size = new System.Drawing.Size(467, 379);
            this.lsvbill.TabIndex = 0;
            this.lsvbill.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmfoodcount);
            this.panel4.Controls.Add(this.btnaddfood);
            this.panel4.Controls.Add(this.cbfood);
            this.panel4.Controls.Add(this.cbcategory);
            this.panel4.Location = new System.Drawing.Point(542, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(473, 84);
            this.panel4.TabIndex = 4;
            // 
            // cbcategory
            // 
            this.cbcategory.FormattingEnabled = true;
            this.cbcategory.Location = new System.Drawing.Point(3, 3);
            this.cbcategory.Name = "cbcategory";
            this.cbcategory.Size = new System.Drawing.Size(218, 21);
            this.cbcategory.TabIndex = 0;
            // 
            // cbfood
            // 
            this.cbfood.FormattingEnabled = true;
            this.cbfood.Location = new System.Drawing.Point(3, 42);
            this.cbfood.Name = "cbfood";
            this.cbfood.Size = new System.Drawing.Size(218, 21);
            this.cbfood.TabIndex = 1;
            // 
            // btnaddfood
            // 
            this.btnaddfood.Location = new System.Drawing.Point(245, 13);
            this.btnaddfood.Name = "btnaddfood";
            this.btnaddfood.Size = new System.Drawing.Size(87, 50);
            this.btnaddfood.TabIndex = 2;
            this.btnaddfood.Text = "Add Food";
            this.btnaddfood.UseVisualStyleBackColor = true;
            // 
            // nmfoodcount
            // 
            this.nmfoodcount.Location = new System.Drawing.Point(390, 28);
            this.nmfoodcount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmfoodcount.Name = "nmfoodcount";
            this.nmfoodcount.Size = new System.Drawing.Size(50, 20);
            this.nmfoodcount.TabIndex = 3;
            this.nmfoodcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnltable
            // 
            this.pnltable.Location = new System.Drawing.Point(12, 42);
            this.pnltable.Name = "pnltable";
            this.pnltable.Size = new System.Drawing.Size(524, 560);
            this.pnltable.TabIndex = 5;
            // 
            // btnpay
            // 
            this.btnpay.Location = new System.Drawing.Point(367, 3);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(106, 64);
            this.btnpay.TabIndex = 3;
            this.btnpay.Text = "Pay";
            this.btnpay.UseVisualStyleBackColor = true;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // btndiscount
            // 
            this.btndiscount.Location = new System.Drawing.Point(255, 3);
            this.btndiscount.Name = "btndiscount";
            this.btndiscount.Size = new System.Drawing.Size(106, 28);
            this.btndiscount.TabIndex = 4;
            this.btndiscount.Text = "discount";
            this.btndiscount.UseVisualStyleBackColor = true;
            // 
            // nmdiscount
            // 
            this.nmdiscount.Location = new System.Drawing.Point(255, 37);
            this.nmdiscount.Name = "nmdiscount";
            this.nmdiscount.Size = new System.Drawing.Size(106, 20);
            this.nmdiscount.TabIndex = 4;
            this.nmdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnswitchtable
            // 
            this.btnswitchtable.Location = new System.Drawing.Point(3, 3);
            this.btnswitchtable.Name = "btnswitchtable";
            this.btnswitchtable.Size = new System.Drawing.Size(117, 28);
            this.btnswitchtable.TabIndex = 5;
            this.btnswitchtable.Text = "move table";
            this.btnswitchtable.UseVisualStyleBackColor = true;
            // 
            // cbswitchtable
            // 
            this.cbswitchtable.FormattingEnabled = true;
            this.cbswitchtable.Location = new System.Drawing.Point(6, 37);
            this.cbswitchtable.Name = "cbswitchtable";
            this.cbswitchtable.Size = new System.Drawing.Size(114, 21);
            this.cbswitchtable.TabIndex = 4;
            // 
            // maintable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 614);
            this.Controls.Add(this.pnltable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "maintable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qlcafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmfoodcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adiminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHongTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvbill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmfoodcount;
        private System.Windows.Forms.Button btnaddfood;
        private System.Windows.Forms.ComboBox cbfood;
        private System.Windows.Forms.ComboBox cbcategory;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.FlowLayoutPanel pnltable;
        private System.Windows.Forms.Button btndiscount;
        private System.Windows.Forms.ComboBox cbswitchtable;
        private System.Windows.Forms.Button btnswitchtable;
        private System.Windows.Forms.NumericUpDown nmdiscount;
    }
}