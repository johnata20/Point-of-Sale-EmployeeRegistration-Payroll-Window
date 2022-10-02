namespace ComProg1_Wed
{
    partial class Receipt
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
            this.ItemList = new System.Windows.Forms.ListView();
            this.ItemNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FinalPriceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RecComNameLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.ContactNumLbl = new System.Windows.Forms.Label();
            this.CloseLbl1 = new System.Windows.Forms.Label();
            this.CloseLbl2 = new System.Windows.Forms.Label();
            this.RecCloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemList
            // 
            this.ItemList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemNameCol,
            this.QuantityCol,
            this.FinalPriceCol});
            this.ItemList.Location = new System.Drawing.Point(12, 104);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(269, 342);
            this.ItemList.TabIndex = 0;
            this.ItemList.UseCompatibleStateImageBehavior = false;
            this.ItemList.View = System.Windows.Forms.View.Details;
            // 
            // ItemNameCol
            // 
            this.ItemNameCol.Text = "Item Name";
            this.ItemNameCol.Width = 88;
            // 
            // QuantityCol
            // 
            this.QuantityCol.Text = "Quantity";
            this.QuantityCol.Width = 66;
            // 
            // FinalPriceCol
            // 
            this.FinalPriceCol.Text = "Discounted Price";
            this.FinalPriceCol.Width = 110;
            // 
            // RecComNameLbl
            // 
            this.RecComNameLbl.AutoSize = true;
            this.RecComNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecComNameLbl.Location = new System.Drawing.Point(40, 9);
            this.RecComNameLbl.Name = "RecComNameLbl";
            this.RecComNameLbl.Size = new System.Drawing.Size(211, 20);
            this.RecComNameLbl.TabIndex = 1;
            this.RecComNameLbl.Text = "John Rodolfo (YouTuber)";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLbl.Location = new System.Drawing.Point(92, 41);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(92, 16);
            this.AddressLbl.TabIndex = 2;
            this.AddressLbl.Text = "Paranque City";
            // 
            // ContactNumLbl
            // 
            this.ContactNumLbl.AutoSize = true;
            this.ContactNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumLbl.Location = new System.Drawing.Point(92, 70);
            this.ContactNumLbl.Name = "ContactNumLbl";
            this.ContactNumLbl.Size = new System.Drawing.Size(93, 16);
            this.ContactNumLbl.TabIndex = 3;
            this.ContactNumLbl.Text = "000-1101-1101";
            // 
            // CloseLbl1
            // 
            this.CloseLbl1.AutoSize = true;
            this.CloseLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLbl1.Location = new System.Drawing.Point(53, 466);
            this.CloseLbl1.Name = "CloseLbl1";
            this.CloseLbl1.Size = new System.Drawing.Size(184, 18);
            this.CloseLbl1.TabIndex = 4;
            this.CloseLbl1.Text = "Thank you for purchasing!!!";
            // 
            // CloseLbl2
            // 
            this.CloseLbl2.AutoSize = true;
            this.CloseLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLbl2.Location = new System.Drawing.Point(70, 495);
            this.CloseLbl2.Name = "CloseLbl2";
            this.CloseLbl2.Size = new System.Drawing.Size(142, 18);
            this.CloseLbl2.TabIndex = 5;
            this.CloseLbl2.Text = "Come see us again!!";
            // 
            // RecCloseBtn
            // 
            this.RecCloseBtn.Location = new System.Drawing.Point(95, 529);
            this.RecCloseBtn.Name = "RecCloseBtn";
            this.RecCloseBtn.Size = new System.Drawing.Size(90, 43);
            this.RecCloseBtn.TabIndex = 6;
            this.RecCloseBtn.Text = "Close Receipt";
            this.RecCloseBtn.UseVisualStyleBackColor = true;
            this.RecCloseBtn.Click += new System.EventHandler(this.RecCloseBtn_Click);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(293, 584);
            this.Controls.Add(this.RecCloseBtn);
            this.Controls.Add(this.CloseLbl2);
            this.Controls.Add(this.CloseLbl1);
            this.Controls.Add(this.ContactNumLbl);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.RecComNameLbl);
            this.Controls.Add(this.ItemList);
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ItemList;
        private System.Windows.Forms.ColumnHeader ItemNameCol;
        private System.Windows.Forms.ColumnHeader QuantityCol;
        private System.Windows.Forms.ColumnHeader FinalPriceCol;
        private System.Windows.Forms.Label RecComNameLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.Label ContactNumLbl;
        private System.Windows.Forms.Label CloseLbl1;
        private System.Windows.Forms.Label CloseLbl2;
        private System.Windows.Forms.Button RecCloseBtn;
    }
}