namespace qlcafe
{
    partial class faccout
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.dangnhap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdisplayname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnEXit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtusername);
            this.panel2.Controls.Add(this.dangnhap);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 66);
            this.panel2.TabIndex = 1;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(144, 27);
            this.txtusername.Name = "txtusername";
            this.txtusername.ReadOnly = true;
            this.txtusername.Size = new System.Drawing.Size(293, 20);
            this.txtusername.TabIndex = 1;
            // 
            // dangnhap
            // 
            this.dangnhap.AutoSize = true;
            this.dangnhap.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dangnhap.Location = new System.Drawing.Point(18, 23);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(102, 23);
            this.dangnhap.TabIndex = 0;
            this.dangnhap.Text = "UserName";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtdisplayname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 66);
            this.panel1.TabIndex = 2;
            // 
            // txtdisplayname
            // 
            this.txtdisplayname.Location = new System.Drawing.Point(144, 27);
            this.txtdisplayname.Name = "txtdisplayname";
            this.txtdisplayname.Size = new System.Drawing.Size(293, 20);
            this.txtdisplayname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 66);
            this.panel3.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(206, 253);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(96, 53);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnEXit
            // 
            this.btnEXit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEXit.Location = new System.Drawing.Point(353, 253);
            this.btnEXit.Name = "btnEXit";
            this.btnEXit.Size = new System.Drawing.Size(96, 53);
            this.btnEXit.TabIndex = 5;
            this.btnEXit.Text = "Exit";
            this.btnEXit.UseVisualStyleBackColor = true;
            this.btnEXit.Click += new System.EventHandler(this.btnEXit_Click);
            // 
            // faccout
            // 
            this.AcceptButton = this.btnupdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnEXit;
            this.ClientSize = new System.Drawing.Size(489, 325);
            this.Controls.Add(this.btnEXit);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "faccout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Cá Nhân ";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label dangnhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdisplayname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnEXit;
    }
}