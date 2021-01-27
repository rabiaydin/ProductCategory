
namespace ProductCategory
{
    partial class category
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
            this.buttoncatupdate = new System.Windows.Forms.Button();
            this.buttoncatdelete = new System.Windows.Forms.Button();
            this.buttoncatadd = new System.Windows.Forms.Button();
            this.textBoxcatname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxcategories = new System.Windows.Forms.ComboBox();
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
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxcategories);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(987, 325);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttoncatupdate);
            this.groupBox1.Controls.Add(this.buttoncatdelete);
            this.groupBox1.Controls.Add(this.buttoncatadd);
            this.groupBox1.Controls.Add(this.textBoxcatname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 196);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // buttoncatupdate
            // 
            this.buttoncatupdate.Enabled = false;
            this.buttoncatupdate.Location = new System.Drawing.Point(135, 78);
            this.buttoncatupdate.Name = "buttoncatupdate";
            this.buttoncatupdate.Size = new System.Drawing.Size(111, 31);
            this.buttoncatupdate.TabIndex = 7;
            this.buttoncatupdate.Text = "Update";
            this.buttoncatupdate.UseVisualStyleBackColor = true;
            this.buttoncatupdate.Click += new System.EventHandler(this.buttoncatupdate_Click);
            // 
            // buttoncatdelete
            // 
            this.buttoncatdelete.Enabled = false;
            this.buttoncatdelete.Location = new System.Drawing.Point(18, 80);
            this.buttoncatdelete.Name = "buttoncatdelete";
            this.buttoncatdelete.Size = new System.Drawing.Size(111, 29);
            this.buttoncatdelete.TabIndex = 6;
            this.buttoncatdelete.Text = "Delete";
            this.buttoncatdelete.UseVisualStyleBackColor = true;
            this.buttoncatdelete.Click += new System.EventHandler(this.buttoncatdelete_Click);
            // 
            // buttoncatadd
            // 
            this.buttoncatadd.Location = new System.Drawing.Point(252, 77);
            this.buttoncatadd.Name = "buttoncatadd";
            this.buttoncatadd.Size = new System.Drawing.Size(111, 32);
            this.buttoncatadd.TabIndex = 5;
            this.buttoncatadd.Text = "Add";
            this.buttoncatadd.UseVisualStyleBackColor = true;
            this.buttoncatadd.Click += new System.EventHandler(this.buttoncatadd_Click);
            // 
            // textBoxcatname
            // 
            this.textBoxcatname.Location = new System.Drawing.Point(136, 38);
            this.textBoxcatname.Name = "textBoxcatname";
            this.textBoxcatname.Size = new System.Drawing.Size(227, 22);
            this.textBoxcatname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category Name";
            // 
            // comboBoxcategories
            // 
            this.comboBoxcategories.FormattingEnabled = true;
            this.comboBoxcategories.Location = new System.Drawing.Point(83, 66);
            this.comboBoxcategories.Name = "comboBoxcategories";
            this.comboBoxcategories.Size = new System.Drawing.Size(188, 24);
            this.comboBoxcategories.TabIndex = 1;
            this.comboBoxcategories.SelectionChangeCommitted += new System.EventHandler(this.comboBoxcategories_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 325);
            this.Controls.Add(this.splitContainer1);
            this.Name = "category";
            this.Text = "category";
            this.Load += new System.EventHandler(this.category_Load);
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
        private System.Windows.Forms.Button buttoncatadd;
        private System.Windows.Forms.TextBox textBoxcatname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxcategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttoncatupdate;
        private System.Windows.Forms.Button buttoncatdelete;
    }
}