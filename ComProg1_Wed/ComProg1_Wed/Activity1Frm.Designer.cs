namespace ComProg1_Wed
{
    partial class Activity1Frm
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
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CompanynameLbl = new System.Windows.Forms.Label();
            this.DisplayGrpBox = new System.Windows.Forms.GroupBox();
            this.ChangeTxtBox = new System.Windows.Forms.TextBox();
            this.CashRenTxtBox = new System.Windows.Forms.TextBox();
            this.ChangeLbl = new System.Windows.Forms.Label();
            this.CashRenLbl = new System.Windows.Forms.Label();
            this.SummaryGrpBox = new System.Windows.Forms.GroupBox();
            this.TotDiscAmTxtBox = new System.Windows.Forms.TextBox();
            this.TotDiscGivenTxtBox = new System.Windows.Forms.TextBox();
            this.TotItemNumTxtBox = new System.Windows.Forms.TextBox();
            this.TotDiscGivenLbl = new System.Windows.Forms.Label();
            this.TotDiscAmLbl = new System.Windows.Forms.Label();
            this.TotItemNumLbl = new System.Windows.Forms.Label();
            this.InputGrpBox = new System.Windows.Forms.GroupBox();
            this.DiscPriceTxtBox = new System.Windows.Forms.TextBox();
            this.DiscAmountTxtBox = new System.Windows.Forms.TextBox();
            this.PriceTxtBox = new System.Windows.Forms.TextBox();
            this.QuantityTxtBox = new System.Windows.Forms.TextBox();
            this.ItemNameTxtBox = new System.Windows.Forms.TextBox();
            this.DiscPriceLbl = new System.Windows.Forms.Label();
            this.DiscAmountLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.ItemNameLbl = new System.Windows.Forms.Label();
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.DisplayGrpBox.SuspendLayout();
            this.SummaryGrpBox.SuspendLayout();
            this.InputGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(751, 82);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(108, 46);
            this.CalculateBtn.TabIndex = 0;
            this.CalculateBtn.Text = "CALCULATE";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(751, 134);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(108, 44);
            this.NewBtn.TabIndex = 1;
            this.NewBtn.Text = "NEW";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(751, 184);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(108, 46);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "CANCEL";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PrintBtn.Location = new System.Drawing.Point(751, 244);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(108, 43);
            this.PrintBtn.TabIndex = 3;
            this.PrintBtn.Text = "PRINT";
            this.PrintBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(751, 298);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(108, 47);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CompanynameLbl
            // 
            this.CompanynameLbl.AutoSize = true;
            this.CompanynameLbl.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanynameLbl.ForeColor = System.Drawing.Color.Gold;
            this.CompanynameLbl.Location = new System.Drawing.Point(208, 9);
            this.CompanynameLbl.Name = "CompanynameLbl";
            this.CompanynameLbl.Size = new System.Drawing.Size(491, 29);
            this.CompanynameLbl.TabIndex = 5;
            this.CompanynameLbl.Text = "JEEAH CLOTHING LINE INCORPORATED";
            this.CompanynameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayGrpBox
            // 
            this.DisplayGrpBox.Controls.Add(this.ChangeTxtBox);
            this.DisplayGrpBox.Controls.Add(this.CashRenTxtBox);
            this.DisplayGrpBox.Controls.Add(this.ChangeLbl);
            this.DisplayGrpBox.Controls.Add(this.CashRenLbl);
            this.DisplayGrpBox.Location = new System.Drawing.Point(35, 354);
            this.DisplayGrpBox.Name = "DisplayGrpBox";
            this.DisplayGrpBox.Size = new System.Drawing.Size(824, 188);
            this.DisplayGrpBox.TabIndex = 6;
            this.DisplayGrpBox.TabStop = false;
            // 
            // ChangeTxtBox
            // 
            this.ChangeTxtBox.Enabled = false;
            this.ChangeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeTxtBox.Location = new System.Drawing.Point(515, 74);
            this.ChangeTxtBox.Multiline = true;
            this.ChangeTxtBox.Name = "ChangeTxtBox";
            this.ChangeTxtBox.Size = new System.Drawing.Size(238, 93);
            this.ChangeTxtBox.TabIndex = 3;
            this.ChangeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CashRenTxtBox
            // 
            this.CashRenTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashRenTxtBox.Location = new System.Drawing.Point(80, 74);
            this.CashRenTxtBox.Multiline = true;
            this.CashRenTxtBox.Name = "CashRenTxtBox";
            this.CashRenTxtBox.Size = new System.Drawing.Size(238, 93);
            this.CashRenTxtBox.TabIndex = 2;
            this.CashRenTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChangeLbl
            // 
            this.ChangeLbl.AutoSize = true;
            this.ChangeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeLbl.ForeColor = System.Drawing.Color.White;
            this.ChangeLbl.Location = new System.Drawing.Point(565, 25);
            this.ChangeLbl.Name = "ChangeLbl";
            this.ChangeLbl.Size = new System.Drawing.Size(139, 31);
            this.ChangeLbl.TabIndex = 1;
            this.ChangeLbl.Text = "CHANGE:";
            this.ChangeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CashRenLbl
            // 
            this.CashRenLbl.AutoSize = true;
            this.CashRenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashRenLbl.ForeColor = System.Drawing.Color.White;
            this.CashRenLbl.Location = new System.Drawing.Point(74, 25);
            this.CashRenLbl.Name = "CashRenLbl";
            this.CashRenLbl.Size = new System.Drawing.Size(259, 31);
            this.CashRenLbl.TabIndex = 0;
            this.CashRenLbl.Text = "CASH RENDERED:";
            // 
            // SummaryGrpBox
            // 
            this.SummaryGrpBox.Controls.Add(this.TotDiscAmTxtBox);
            this.SummaryGrpBox.Controls.Add(this.TotDiscGivenTxtBox);
            this.SummaryGrpBox.Controls.Add(this.TotItemNumTxtBox);
            this.SummaryGrpBox.Controls.Add(this.TotDiscGivenLbl);
            this.SummaryGrpBox.Controls.Add(this.TotDiscAmLbl);
            this.SummaryGrpBox.Controls.Add(this.TotItemNumLbl);
            this.SummaryGrpBox.Location = new System.Drawing.Point(35, 235);
            this.SummaryGrpBox.Name = "SummaryGrpBox";
            this.SummaryGrpBox.Size = new System.Drawing.Size(710, 113);
            this.SummaryGrpBox.TabIndex = 7;
            this.SummaryGrpBox.TabStop = false;
            this.SummaryGrpBox.Text = "SUMMARY";
            // 
            // TotDiscAmTxtBox
            // 
            this.TotDiscAmTxtBox.Enabled = false;
            this.TotDiscAmTxtBox.Location = new System.Drawing.Point(306, 77);
            this.TotDiscAmTxtBox.Name = "TotDiscAmTxtBox";
            this.TotDiscAmTxtBox.Size = new System.Drawing.Size(358, 20);
            this.TotDiscAmTxtBox.TabIndex = 10;
            // 
            // TotDiscGivenTxtBox
            // 
            this.TotDiscGivenTxtBox.Enabled = false;
            this.TotDiscGivenTxtBox.Location = new System.Drawing.Point(306, 47);
            this.TotDiscGivenTxtBox.Name = "TotDiscGivenTxtBox";
            this.TotDiscGivenTxtBox.Size = new System.Drawing.Size(358, 20);
            this.TotDiscGivenTxtBox.TabIndex = 9;
            // 
            // TotItemNumTxtBox
            // 
            this.TotItemNumTxtBox.Enabled = false;
            this.TotItemNumTxtBox.Location = new System.Drawing.Point(306, 21);
            this.TotItemNumTxtBox.Name = "TotItemNumTxtBox";
            this.TotItemNumTxtBox.Size = new System.Drawing.Size(358, 20);
            this.TotItemNumTxtBox.TabIndex = 8;
            // 
            // TotDiscGivenLbl
            // 
            this.TotDiscGivenLbl.AutoSize = true;
            this.TotDiscGivenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotDiscGivenLbl.ForeColor = System.Drawing.Color.White;
            this.TotDiscGivenLbl.Location = new System.Drawing.Point(77, 51);
            this.TotDiscGivenLbl.Name = "TotDiscGivenLbl";
            this.TotDiscGivenLbl.Size = new System.Drawing.Size(181, 16);
            this.TotDiscGivenLbl.TabIndex = 7;
            this.TotDiscGivenLbl.Text = "TOTAL DISCOUNTS GIVEN:";
            // 
            // TotDiscAmLbl
            // 
            this.TotDiscAmLbl.AutoSize = true;
            this.TotDiscAmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotDiscAmLbl.ForeColor = System.Drawing.Color.White;
            this.TotDiscAmLbl.Location = new System.Drawing.Point(77, 78);
            this.TotDiscAmLbl.Name = "TotDiscAmLbl";
            this.TotDiscAmLbl.Size = new System.Drawing.Size(218, 16);
            this.TotDiscAmLbl.TabIndex = 6;
            this.TotDiscAmLbl.Text = "TOTAL DISCOUNTED AMOUNTS:";
            // 
            // TotItemNumLbl
            // 
            this.TotItemNumLbl.AutoSize = true;
            this.TotItemNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotItemNumLbl.ForeColor = System.Drawing.Color.White;
            this.TotItemNumLbl.Location = new System.Drawing.Point(77, 28);
            this.TotItemNumLbl.Name = "TotItemNumLbl";
            this.TotItemNumLbl.Size = new System.Drawing.Size(182, 16);
            this.TotItemNumLbl.TabIndex = 5;
            this.TotItemNumLbl.Text = "TOTAL NUMBER OF ITEMS:";
            // 
            // InputGrpBox
            // 
            this.InputGrpBox.Controls.Add(this.DiscPriceTxtBox);
            this.InputGrpBox.Controls.Add(this.DiscAmountTxtBox);
            this.InputGrpBox.Controls.Add(this.PriceTxtBox);
            this.InputGrpBox.Controls.Add(this.QuantityTxtBox);
            this.InputGrpBox.Controls.Add(this.ItemNameTxtBox);
            this.InputGrpBox.Controls.Add(this.DiscPriceLbl);
            this.InputGrpBox.Controls.Add(this.DiscAmountLbl);
            this.InputGrpBox.Controls.Add(this.PriceLbl);
            this.InputGrpBox.Controls.Add(this.QuantityLbl);
            this.InputGrpBox.Controls.Add(this.ItemNameLbl);
            this.InputGrpBox.Location = new System.Drawing.Point(35, 73);
            this.InputGrpBox.Name = "InputGrpBox";
            this.InputGrpBox.Size = new System.Drawing.Size(710, 157);
            this.InputGrpBox.TabIndex = 8;
            this.InputGrpBox.TabStop = false;
            // 
            // DiscPriceTxtBox
            // 
            this.DiscPriceTxtBox.Enabled = false;
            this.DiscPriceTxtBox.Location = new System.Drawing.Point(129, 123);
            this.DiscPriceTxtBox.Name = "DiscPriceTxtBox";
            this.DiscPriceTxtBox.Size = new System.Drawing.Size(292, 20);
            this.DiscPriceTxtBox.TabIndex = 9;
            // 
            // DiscAmountTxtBox
            // 
            this.DiscAmountTxtBox.Location = new System.Drawing.Point(129, 97);
            this.DiscAmountTxtBox.Name = "DiscAmountTxtBox";
            this.DiscAmountTxtBox.Size = new System.Drawing.Size(292, 20);
            this.DiscAmountTxtBox.TabIndex = 8;
            this.DiscAmountTxtBox.TextChanged += new System.EventHandler(this.DiscAmountTxtBox_TextChanged);
            this.DiscAmountTxtBox.Leave += new System.EventHandler(this.DiscAmountTxtBox_TextChanged);
            // 
            // PriceTxtBox
            // 
            this.PriceTxtBox.Location = new System.Drawing.Point(129, 71);
            this.PriceTxtBox.Name = "PriceTxtBox";
            this.PriceTxtBox.Size = new System.Drawing.Size(292, 20);
            this.PriceTxtBox.TabIndex = 7;
            // 
            // QuantityTxtBox
            // 
            this.QuantityTxtBox.Location = new System.Drawing.Point(129, 46);
            this.QuantityTxtBox.Name = "QuantityTxtBox";
            this.QuantityTxtBox.Size = new System.Drawing.Size(292, 20);
            this.QuantityTxtBox.TabIndex = 6;
            // 
            // ItemNameTxtBox
            // 
            this.ItemNameTxtBox.Location = new System.Drawing.Point(129, 20);
            this.ItemNameTxtBox.Name = "ItemNameTxtBox";
            this.ItemNameTxtBox.Size = new System.Drawing.Size(575, 20);
            this.ItemNameTxtBox.TabIndex = 5;
            // 
            // DiscPriceLbl
            // 
            this.DiscPriceLbl.AutoSize = true;
            this.DiscPriceLbl.ForeColor = System.Drawing.Color.White;
            this.DiscPriceLbl.Location = new System.Drawing.Point(28, 123);
            this.DiscPriceLbl.Name = "DiscPriceLbl";
            this.DiscPriceLbl.Size = new System.Drawing.Size(91, 13);
            this.DiscPriceLbl.TabIndex = 4;
            this.DiscPriceLbl.Text = "Discounted Price:";
            // 
            // DiscAmountLbl
            // 
            this.DiscAmountLbl.AutoSize = true;
            this.DiscAmountLbl.ForeColor = System.Drawing.Color.White;
            this.DiscAmountLbl.Location = new System.Drawing.Point(28, 97);
            this.DiscAmountLbl.Name = "DiscAmountLbl";
            this.DiscAmountLbl.Size = new System.Drawing.Size(91, 13);
            this.DiscAmountLbl.TabIndex = 3;
            this.DiscAmountLbl.Text = "Discount Amount:";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.ForeColor = System.Drawing.Color.White;
            this.PriceLbl.Location = new System.Drawing.Point(28, 72);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(34, 13);
            this.PriceLbl.TabIndex = 2;
            this.PriceLbl.Text = "Price:";
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.ForeColor = System.Drawing.Color.White;
            this.QuantityLbl.Location = new System.Drawing.Point(28, 46);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(49, 13);
            this.QuantityLbl.TabIndex = 1;
            this.QuantityLbl.Text = "Quantity:";
            // 
            // ItemNameLbl
            // 
            this.ItemNameLbl.AutoSize = true;
            this.ItemNameLbl.ForeColor = System.Drawing.Color.White;
            this.ItemNameLbl.Location = new System.Drawing.Point(28, 20);
            this.ItemNameLbl.Name = "ItemNameLbl";
            this.ItemNameLbl.Size = new System.Drawing.Size(73, 13);
            this.ItemNameLbl.TabIndex = 0;
            this.ItemNameLbl.Text = "Name of Item:";
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerLabel.ForeColor = System.Drawing.Color.White;
            this.OwnerLabel.Location = new System.Drawing.Point(590, 54);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(198, 16);
            this.OwnerLabel.TabIndex = 9;
            this.OwnerLabel.Text = "By: Julius D. Calleja Terminal #7";
            // 
            // Activity1Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(899, 554);
            this.Controls.Add(this.OwnerLabel);
            this.Controls.Add(this.InputGrpBox);
            this.Controls.Add(this.SummaryGrpBox);
            this.Controls.Add(this.DisplayGrpBox);
            this.Controls.Add(this.CompanynameLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.CalculateBtn);
            this.Name = "Activity1Frm";
            this.Text = "Activity1Frm";
            this.Load += new System.EventHandler(this.Activity1Frm_Load);
            this.DisplayGrpBox.ResumeLayout(false);
            this.DisplayGrpBox.PerformLayout();
            this.SummaryGrpBox.ResumeLayout(false);
            this.SummaryGrpBox.PerformLayout();
            this.InputGrpBox.ResumeLayout(false);
            this.InputGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label CompanynameLbl;
        private System.Windows.Forms.GroupBox DisplayGrpBox;
        private System.Windows.Forms.GroupBox SummaryGrpBox;
        private System.Windows.Forms.GroupBox InputGrpBox;
        private System.Windows.Forms.TextBox DiscPriceTxtBox;
        private System.Windows.Forms.TextBox DiscAmountTxtBox;
        private System.Windows.Forms.TextBox PriceTxtBox;
        private System.Windows.Forms.TextBox QuantityTxtBox;
        private System.Windows.Forms.TextBox ItemNameTxtBox;
        private System.Windows.Forms.Label DiscPriceLbl;
        private System.Windows.Forms.Label DiscAmountLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Label ItemNameLbl;
        private System.Windows.Forms.Label OwnerLabel;
        private System.Windows.Forms.Label TotDiscGivenLbl;
        private System.Windows.Forms.Label TotDiscAmLbl;
        private System.Windows.Forms.Label TotItemNumLbl;
        private System.Windows.Forms.TextBox TotDiscAmTxtBox;
        private System.Windows.Forms.TextBox TotDiscGivenTxtBox;
        private System.Windows.Forms.TextBox TotItemNumTxtBox;
        private System.Windows.Forms.TextBox ChangeTxtBox;
        private System.Windows.Forms.TextBox CashRenTxtBox;
        private System.Windows.Forms.Label ChangeLbl;
        private System.Windows.Forms.Label CashRenLbl;
    }
}

