namespace ComProg1_Wed
{
    partial class SampleLang
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
            this.SampleProgLbl = new System.Windows.Forms.Label();
            this.StudentNumLbl = new System.Windows.Forms.Label();
            this.StudentNameLbl = new System.Windows.Forms.Label();
            this.DeptLbl = new System.Windows.Forms.Label();
            this.griddisplay = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            this.studnumtxtbox = new System.Windows.Forms.TextBox();
            this.studnametxtbox = new System.Windows.Forms.TextBox();
            this.deptxtbox = new System.Windows.Forms.TextBox();
            this.picpathtxtbox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.griddisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SampleProgLbl
            // 
            this.SampleProgLbl.AutoSize = true;
            this.SampleProgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SampleProgLbl.ForeColor = System.Drawing.Color.White;
            this.SampleProgLbl.Location = new System.Drawing.Point(390, 24);
            this.SampleProgLbl.Name = "SampleProgLbl";
            this.SampleProgLbl.Size = new System.Drawing.Size(263, 25);
            this.SampleProgLbl.TabIndex = 1;
            this.SampleProgLbl.Text = "Sample Program Lang Po!";
            // 
            // StudentNumLbl
            // 
            this.StudentNumLbl.AutoSize = true;
            this.StudentNumLbl.ForeColor = System.Drawing.Color.White;
            this.StudentNumLbl.Location = new System.Drawing.Point(343, 64);
            this.StudentNumLbl.Name = "StudentNumLbl";
            this.StudentNumLbl.Size = new System.Drawing.Size(87, 13);
            this.StudentNumLbl.TabIndex = 2;
            this.StudentNumLbl.Text = "Student Number:";
            // 
            // StudentNameLbl
            // 
            this.StudentNameLbl.AutoSize = true;
            this.StudentNameLbl.ForeColor = System.Drawing.Color.White;
            this.StudentNameLbl.Location = new System.Drawing.Point(343, 91);
            this.StudentNameLbl.Name = "StudentNameLbl";
            this.StudentNameLbl.Size = new System.Drawing.Size(78, 13);
            this.StudentNameLbl.TabIndex = 3;
            this.StudentNameLbl.Text = "Student Name:";
            // 
            // DeptLbl
            // 
            this.DeptLbl.AutoSize = true;
            this.DeptLbl.ForeColor = System.Drawing.Color.White;
            this.DeptLbl.Location = new System.Drawing.Point(343, 120);
            this.DeptLbl.Name = "DeptLbl";
            this.DeptLbl.Size = new System.Drawing.Size(65, 13);
            this.DeptLbl.TabIndex = 4;
            this.DeptLbl.Text = "Department:";
            // 
            // griddisplay
            // 
            this.griddisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddisplay.Location = new System.Drawing.Point(322, 159);
            this.griddisplay.Name = "griddisplay";
            this.griddisplay.Size = new System.Drawing.Size(379, 131);
            this.griddisplay.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 376);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(322, 296);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(120, 43);
            this.savebtn.TabIndex = 6;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(452, 296);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(120, 43);
            this.searchbtn.TabIndex = 7;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(581, 296);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(120, 43);
            this.delbtn.TabIndex = 8;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(322, 345);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(120, 43);
            this.editbtn.TabIndex = 9;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(452, 345);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(120, 43);
            this.cancelbtn.TabIndex = 10;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // newbtn
            // 
            this.newbtn.Location = new System.Drawing.Point(581, 347);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(120, 43);
            this.newbtn.TabIndex = 11;
            this.newbtn.Text = "New";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // studnumtxtbox
            // 
            this.studnumtxtbox.Location = new System.Drawing.Point(452, 64);
            this.studnumtxtbox.Name = "studnumtxtbox";
            this.studnumtxtbox.Size = new System.Drawing.Size(156, 20);
            this.studnumtxtbox.TabIndex = 12;
            // 
            // studnametxtbox
            // 
            this.studnametxtbox.Location = new System.Drawing.Point(452, 91);
            this.studnametxtbox.Name = "studnametxtbox";
            this.studnametxtbox.Size = new System.Drawing.Size(249, 20);
            this.studnametxtbox.TabIndex = 13;
            // 
            // deptxtbox
            // 
            this.deptxtbox.Location = new System.Drawing.Point(452, 120);
            this.deptxtbox.Name = "deptxtbox";
            this.deptxtbox.Size = new System.Drawing.Size(249, 20);
            this.deptxtbox.TabIndex = 14;
            // 
            // picpathtxtbox
            // 
            this.picpathtxtbox.Location = new System.Drawing.Point(330, 1);
            this.picpathtxtbox.Name = "picpathtxtbox";
            this.picpathtxtbox.Size = new System.Drawing.Size(100, 20);
            this.picpathtxtbox.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SampleLang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(713, 409);
            this.Controls.Add(this.picpathtxtbox);
            this.Controls.Add(this.deptxtbox);
            this.Controls.Add(this.studnametxtbox);
            this.Controls.Add(this.studnumtxtbox);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.griddisplay);
            this.Controls.Add(this.DeptLbl);
            this.Controls.Add(this.StudentNameLbl);
            this.Controls.Add(this.StudentNumLbl);
            this.Controls.Add(this.SampleProgLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SampleLang";
            this.Text = "SampleLang";
            this.Load += new System.EventHandler(this.SampleLang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.griddisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SampleProgLbl;
        private System.Windows.Forms.Label StudentNumLbl;
        private System.Windows.Forms.Label StudentNameLbl;
        private System.Windows.Forms.Label DeptLbl;
        private System.Windows.Forms.DataGridView griddisplay;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.TextBox studnumtxtbox;
        private System.Windows.Forms.TextBox studnametxtbox;
        private System.Windows.Forms.TextBox deptxtbox;
        private System.Windows.Forms.TextBox picpathtxtbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}