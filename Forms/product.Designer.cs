
namespace ProductCategory
{
    partial class product
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxprocat = new System.Windows.Forms.ComboBox();
            this.buttonproupdate = new System.Windows.Forms.Button();
            this.buttonprodelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxauthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonproadd = new System.Windows.Forms.Button();
            this.textBoxproname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxproducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxproducts);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1154, 512);
            this.splitContainer1.SplitterDistance = 493;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxprocat);
            this.groupBox1.Controls.Add(this.buttonproupdate);
            this.groupBox1.Controls.Add(this.buttonprodelete);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxauthor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonproadd);
            this.groupBox1.Controls.Add(this.textBoxproname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 321);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxprocat
            // 
            this.comboBoxprocat.FormattingEnabled = true;
            this.comboBoxprocat.Location = new System.Drawing.Point(136, 154);
            this.comboBoxprocat.Name = "comboBoxprocat";
            this.comboBoxprocat.Size = new System.Drawing.Size(121, 24);
            this.comboBoxprocat.TabIndex = 12;
            // 
            // buttonproupdate
            // 
            this.buttonproupdate.Enabled = false;
            this.buttonproupdate.Location = new System.Drawing.Point(149, 240);
            this.buttonproupdate.Name = "buttonproupdate";
            this.buttonproupdate.Size = new System.Drawing.Size(115, 30);
            this.buttonproupdate.TabIndex = 11;
            this.buttonproupdate.Text = "Update";
            this.buttonproupdate.UseVisualStyleBackColor = true;
            this.buttonproupdate.Click += new System.EventHandler(this.buttonproupdate_Click);
            // 
            // buttonprodelete
            // 
            this.buttonprodelete.Enabled = false;
            this.buttonprodelete.Location = new System.Drawing.Point(153, 285);
            this.buttonprodelete.Name = "buttonprodelete";
            this.buttonprodelete.Size = new System.Drawing.Size(111, 30);
            this.buttonprodelete.TabIndex = 10;
            this.buttonprodelete.Text = "Delete";
            this.buttonprodelete.UseVisualStyleBackColor = true;
            this.buttonprodelete.Click += new System.EventHandler(this.buttonprodelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category Name";
            // 
            // textBoxauthor
            // 
            this.textBoxauthor.Location = new System.Drawing.Point(136, 92);
            this.textBoxauthor.Name = "textBoxauthor";
            this.textBoxauthor.Size = new System.Drawing.Size(128, 22);
            this.textBoxauthor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author";
            // 
            // buttonproadd
            // 
            this.buttonproadd.Location = new System.Drawing.Point(151, 193);
            this.buttonproadd.Name = "buttonproadd";
            this.buttonproadd.Size = new System.Drawing.Size(113, 30);
            this.buttonproadd.TabIndex = 5;
            this.buttonproadd.Text = "Add";
            this.buttonproadd.UseVisualStyleBackColor = true;
            this.buttonproadd.Click += new System.EventHandler(this.buttonproadd_Click);
            // 
            // textBoxproname
            // 
            this.textBoxproname.Location = new System.Drawing.Point(136, 38);
            this.textBoxproname.Name = "textBoxproname";
            this.textBoxproname.Size = new System.Drawing.Size(128, 22);
            this.textBoxproname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // comboBoxproducts
            // 
            this.comboBoxproducts.FormattingEnabled = true;
            this.comboBoxproducts.Location = new System.Drawing.Point(131, 75);
            this.comboBoxproducts.Name = "comboBoxproducts";
            this.comboBoxproducts.Size = new System.Drawing.Size(128, 24);
            this.comboBoxproducts.TabIndex = 1;
            this.comboBoxproducts.SelectionChangeCommitted += new System.EventHandler(this.comboBoxproducts_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(653, 508);
            this.dataGridView1.TabIndex = 0;
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 512);
            this.Controls.Add(this.splitContainer1);
            this.Name = "product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.product_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonproadd;
        private System.Windows.Forms.TextBox textBoxproname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxproducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxauthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonproupdate;
        private System.Windows.Forms.Button buttonprodelete;
        private System.Windows.Forms.ComboBox comboBoxprocat;
    }
}