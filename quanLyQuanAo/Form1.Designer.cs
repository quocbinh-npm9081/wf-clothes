
namespace quanLyQuanAo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textName = new System.Windows.Forms.TextBox();
            this.textCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.textAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(174, 31);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(427, 31);
            this.textName.TabIndex = 0;
            this.textName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(174, 87);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(427, 31);
            this.textCode.TabIndex = 1;
            this.textCode.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ten Sinh vien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "MSSV";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Them";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableView
            // 
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameStudent,
            this.ageStudent,
            this.codeStudent});
            this.tableView.Location = new System.Drawing.Point(46, 194);
            this.tableView.Name = "tableView";
            this.tableView.RowHeadersWidth = 62;
            this.tableView.RowTemplate.Height = 33;
            this.tableView.Size = new System.Drawing.Size(688, 228);
            this.tableView.TabIndex = 5;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(174, 139);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(427, 31);
            this.textAge.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tuoi";
            // 
            // nameStudent
            // 
            this.nameStudent.DataPropertyName = "nameStudent";
            this.nameStudent.HeaderText = "Name";
            this.nameStudent.MinimumWidth = 8;
            this.nameStudent.Name = "nameStudent";
            this.nameStudent.ReadOnly = true;
            this.nameStudent.Width = 150;
            // 
            // ageStudent
            // 
            this.ageStudent.DataPropertyName = "ageStudent";
            this.ageStudent.HeaderText = "Age";
            this.ageStudent.MinimumWidth = 8;
            this.ageStudent.Name = "ageStudent";
            this.ageStudent.ReadOnly = true;
            this.ageStudent.Width = 150;
            // 
            // codeStudent
            // 
            this.codeStudent.DataPropertyName = "codeStudent";
            this.codeStudent.HeaderText = "Code";
            this.codeStudent.MinimumWidth = 8;
            this.codeStudent.Name = "codeStudent";
            this.codeStudent.ReadOnly = true;
            this.codeStudent.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.tableView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.textName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeStudent;
    }
}

