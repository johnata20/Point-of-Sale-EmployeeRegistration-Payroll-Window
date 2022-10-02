namespace ComProg1_Wed
{
    partial class MainForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.POSMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.POSSubAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.POSSubStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.PayrollMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowSubCas = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowSubHori = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowSubVert = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeRegMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.POSMainMenu,
            this.EmployeeRegMenu,
            this.PayrollMainMenu,
            this.WindowMainMenu});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(395, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // POSMainMenu
            // 
            this.POSMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.POSSubAdmin,
            this.POSSubStaff});
            this.POSMainMenu.Name = "POSMainMenu";
            this.POSMainMenu.Size = new System.Drawing.Size(85, 20);
            this.POSMainMenu.Text = "Point of Sale";
            // 
            // POSSubAdmin
            // 
            this.POSSubAdmin.Name = "POSSubAdmin";
            this.POSSubAdmin.Size = new System.Drawing.Size(135, 22);
            this.POSSubAdmin.Text = "Admin POS";
            this.POSSubAdmin.Click += new System.EventHandler(this.POSSubAdmin_Click);
            // 
            // POSSubStaff
            // 
            this.POSSubStaff.Name = "POSSubStaff";
            this.POSSubStaff.Size = new System.Drawing.Size(135, 22);
            this.POSSubStaff.Text = "Staff POS";
            this.POSSubStaff.Click += new System.EventHandler(this.POSSubStaff_Click);
            // 
            // PayrollMainMenu
            // 
            this.PayrollMainMenu.Name = "PayrollMainMenu";
            this.PayrollMainMenu.Size = new System.Drawing.Size(55, 20);
            this.PayrollMainMenu.Text = "Payroll";
            this.PayrollMainMenu.Click += new System.EventHandler(this.PayrollMainMenu_Click);
            // 
            // WindowMainMenu
            // 
            this.WindowMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WindowSubCas,
            this.WindowSubHori,
            this.WindowSubVert});
            this.WindowMainMenu.Name = "WindowMainMenu";
            this.WindowMainMenu.Size = new System.Drawing.Size(63, 20);
            this.WindowMainMenu.Text = "Window";
            // 
            // WindowSubCas
            // 
            this.WindowSubCas.Name = "WindowSubCas";
            this.WindowSubCas.Size = new System.Drawing.Size(160, 22);
            this.WindowSubCas.Text = "Cascade";
            this.WindowSubCas.Click += new System.EventHandler(this.WindowSubCas_Click);
            // 
            // WindowSubHori
            // 
            this.WindowSubHori.Name = "WindowSubHori";
            this.WindowSubHori.Size = new System.Drawing.Size(160, 22);
            this.WindowSubHori.Text = "Tile Horizontally";
            this.WindowSubHori.Click += new System.EventHandler(this.WindowSubHori_Click);
            // 
            // WindowSubVert
            // 
            this.WindowSubVert.Name = "WindowSubVert";
            this.WindowSubVert.Size = new System.Drawing.Size(160, 22);
            this.WindowSubVert.Text = "Tile Vertically";
            this.WindowSubVert.Click += new System.EventHandler(this.WindowSubVert_Click);
            // 
            // EmployeeRegMenu
            // 
            this.EmployeeRegMenu.Name = "EmployeeRegMenu";
            this.EmployeeRegMenu.Size = new System.Drawing.Size(137, 20);
            this.EmployeeRegMenu.Text = "Employee Registration";
            this.EmployeeRegMenu.Click += new System.EventHandler(this.EmployeeRegMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(395, 287);
            this.Controls.Add(this.mainMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem POSMainMenu;
        private System.Windows.Forms.ToolStripMenuItem POSSubAdmin;
        private System.Windows.Forms.ToolStripMenuItem POSSubStaff;
        private System.Windows.Forms.ToolStripMenuItem PayrollMainMenu;
        private System.Windows.Forms.ToolStripMenuItem WindowMainMenu;
        private System.Windows.Forms.ToolStripMenuItem WindowSubCas;
        private System.Windows.Forms.ToolStripMenuItem WindowSubHori;
        private System.Windows.Forms.ToolStripMenuItem WindowSubVert;
        private System.Windows.Forms.ToolStripMenuItem EmployeeRegMenu;
    }
}