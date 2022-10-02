using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComProg1_Wed
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void POSSubStaff_Click(object sender, EventArgs e)
        {
            PointOfSale POS = new PointOfSale();

            POS.MdiParent = this;

            POS.Show();
        }

        private void WindowSubCas_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void WindowSubHori_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void WindowSubVert_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void EmployeeRegMenu_Click(object sender, EventArgs e)
        {
            EmployeeReg EmpReg = new EmployeeReg();

            EmpReg.MdiParent = this;

            EmpReg.Show();
        }

        private void POSSubAdmin_Click(object sender, EventArgs e)
        {
            PointOfSaleAdmin POSAdmin = new PointOfSaleAdmin();

            POSAdmin.MdiParent = this;

            POSAdmin.Show();
        }

        private void PayrollMainMenu_Click(object sender, EventArgs e)
        {
            PayrollFrm Payroll = new PayrollFrm();

            Payroll.MdiParent = this;

            Payroll.Show();
        }
    }
}
