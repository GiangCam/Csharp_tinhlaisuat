namespace Csharp_tinhlaisuat
{
    partial class Form1
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
            this.btntinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.lbxKQ = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlai = new System.Windows.Forms.TextBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(578, 233);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(90, 30);
            this.btntinh.TabIndex = 0;
            this.btntinh.Text = "TÍNH";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số Tiền ";
            // 
            // txtsotien
            // 
            this.txtsotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsotien.Location = new System.Drawing.Point(187, 92);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(431, 40);
            this.txtsotien.TabIndex = 2;
            // 
            // lbxKQ
            // 
            this.lbxKQ.FormattingEnabled = true;
            this.lbxKQ.Location = new System.Drawing.Point(85, 269);
            this.lbxKQ.Name = "lbxKQ";
            this.lbxKQ.Size = new System.Drawing.Size(583, 251);
            this.lbxKQ.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lãi Suất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Năm";
            // 
            // txtlai
            // 
            this.txtlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlai.Location = new System.Drawing.Point(274, 143);
            this.txtlai.Name = "txtlai";
            this.txtlai.Size = new System.Drawing.Size(256, 40);
            this.txtlai.TabIndex = 6;
            // 
            // txtnam
            // 
            this.txtnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnam.Location = new System.Drawing.Point(274, 198);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(256, 40);
            this.txtnam.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.txtlai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxKQ);
            this.Controls.Add(this.txtsotien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.ListBox lbxKQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlai;
        private System.Windows.Forms.TextBox txtnam;
    }
}

