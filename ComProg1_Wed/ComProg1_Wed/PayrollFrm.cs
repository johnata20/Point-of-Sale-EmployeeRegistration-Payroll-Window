using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ComProg1_Wed
{
    public partial class PayrollFrm : Form
    {
        DataClass dclass = new DataClass();

        public PayrollFrm()
        {
            //Database Connection//
            dclass.connString();           
            InitializeComponent();           
        }

        private void cleartxtboxes()
        {
            //Clear all objects//
            BasicRPerHTxtBox.Clear();
            BasicHrPerCOTxtBox.Clear();
            BasicIncCOTxtBox.Clear();
            HonorRPerHTxtBox.Clear();
            HonorHrPerCOTxtBox.Clear();
            TotHonorPayTxtBox.Clear();
            OtherRPerHrTxtBox.Clear();
            OtherHrPerCOTxtBox.Clear();
            TotOtherPayTxtBox.Clear();
            GIncomeTxtBox.Clear();

            SSSContTxtBox.Clear();
            PhilContTxtBox.Clear();
            TaxTxtBox.Clear();

            SSSLoanTxtBox.Clear();
            PagILoanTxtBox.Clear();
            SavDepTxtBox.Clear();
            SavLoanTxtBox.Clear();
            SalLoanTxtBox.Clear();
            OtherTxtBox.Clear();

            TotDeducTxtBox.Clear();
            NIncomeTxtBox.Clear();
        }

        private void sqlselect()
        {
            //Select command//
            dclass.sql = "SELECT * FROM EmployeeRegistrationTbl INNER JOIN PayrollTbl ON EmployeeRegistrationTbl.emp_id=PayrollTbl.emp_id";
        }

        private void sqladapterinsert()
        {
            //Performs SQL insert command//
            dclass.adaptersql = new SqlDataAdapter();
            dclass.adaptersql.InsertCommand = dclass.command;
            dclass.command.ExecuteNonQuery();
        }

        //Initialize repeated variables as global//
        private double rate;

        private double cutOff;

        private double totPay;

        private double grossInc;

        //Declare reusable functions//
        private string formatCheck(string testObject)
        {
            if (testObject == "")
                return "0.00";

            else
                return testObject;
        }

        private void errorMsg()
        {
            MessageBox.Show("ERROR IN INPUT : Non-Number");
        }

        private void TotalPay()
        {
            //Calculates total pay based on Rate per Hour and Number of Hours per Cut off//

            totPay = rate * cutOff;
        }

        private string SSSCont(double gIncome)
        {
            //Gets SSS Contribution based on gross income//
            if (gIncome < 1000.00 && gIncome >= 0)
            {
                return "0.00";
            }

            else if (gIncome >= 1000.00 && gIncome <= 1249.99)
            {
                return "36.30";
            }

            else if (gIncome >= 1250.00 && gIncome <= 1749.99)
            {
                return "54.50";
            }

            else if (gIncome >= 1750.00 && gIncome <= 2249.99)
            {
                return "72.70";
            }

            else if (gIncome >= 2250.00 && gIncome <= 2749.99)
            {
                return "90.80";
            }

            else if (gIncome >= 2750.00 && gIncome <= 3249.99)
            {
                return "109.00";
            }

            else if (gIncome >= 3250.00 && gIncome <= 3749.99)
            {
                return "127.20";
            }

            else if (gIncome >= 3750.00 && gIncome <= 4249.99)
            {
                return "145.30";
            }

            else if (gIncome >= 4250.00 && gIncome <= 4749.99)
            {
                return "163.50";
            }

            else if (gIncome >= 4750.00 && gIncome <= 5249.99)
            {
                return "181.70";
            }

            else if (gIncome >= 5250.00 && gIncome <= 5749.99)
            {
                return "199.80";
            }

            else if (gIncome >= 5750.00 && gIncome <= 6249.99)
            {
                return "218.00";
            }

            else if (gIncome >= 6250.00 && gIncome <= 6749.99)
            {
                return "236.20";
            }

            else if (gIncome >= 6750.00 && gIncome <= 7249.99)
            {
                return "254.30";
            }

            else if (gIncome >= 7250.00 && gIncome <= 7749.99)
            {
                return "272.50";
            }

            else if (gIncome >= 7750.00 && gIncome <= 8249.99)
            {
                return "290.70";
            }

            else if (gIncome >= 8250.00 && gIncome <= 8749.99)
            {
                return "308.80";
            }

            else if (gIncome >= 8750.00 && gIncome <= 9249.99)
            {
                return "327.00";
            }

            else if (gIncome >= 9250.00 && gIncome <= 9749.99)
            {
                return "345.20";
            }

            else if (gIncome >= 9750.00 && gIncome <= 10249.99)
            {
                return "363.30";
            }

            else if (gIncome >= 10250.00 && gIncome <= 10749.99)
            {
                return "381.50";
            }

            else if (gIncome >= 10750.00 && gIncome <= 11249.99)
            {
                return "399.70";
            }

            else if (gIncome >= 11250.00 && gIncome <= 11749.99)
            {
                return "417.80";
            }

            else if (gIncome >= 11750.00 && gIncome <= 12249.99)
            {
                return "436.00";
            }

            else if (gIncome >= 12250.00 && gIncome <= 12749.99)
            {
                return "454.20";
            }

            else if (gIncome >= 12750.00 && gIncome <= 13249.99)
            {
                return "472.30";
            }

            else if (gIncome >= 13250.00 && gIncome <= 13749.99)
            {
                return "490.50";
            }

            else if (gIncome >= 13750.00 && gIncome <= 14249.99)
            {
                return "508.70";
            }

            else if (gIncome >= 14250.00 && gIncome <= 14749.99)
            {
                return "526.80";
            }

            else if (gIncome >= 14750.00 && gIncome <= 15249.99)
            {
                return "545.00";
            }

            else if (gIncome >= 15250.00 && gIncome <= 15749.99)
            {
                return "563.20";
            }

            else if (gIncome >= 15750.00)
            {
                return "581.30";
            }

            else
            {
                return "";
            }
        }

        private string PhilHealth(double gIncome)
        {
            //Gets PhilHealth Contribution based on gross income//
            if (gIncome <= 8999.99 && gIncome >= 0)
            {
                return "100.00";
            }

            else if (gIncome >= 9000.00 && gIncome <= 9999.99)
            {
                return "112.50";
            }

            else if (gIncome >= 10000.00 && gIncome <= 10999.99)
            {
                return "125.00";
            }

            else if (gIncome >= 11000.00 && gIncome <= 11999.99)
            {
                return "137.50";
            }

            else if (gIncome >= 12000.00 && gIncome <= 12999.99)
            {
                return "150.00";
            }

            else if (gIncome >= 13000.00 && gIncome <= 13999.99)
            {
                return "162.50";
            }

            else if (gIncome >= 14000.00 && gIncome <= 14999.99)
            {
                return "175.00";
            }

            else if (gIncome >= 15000.00 && gIncome <= 15999.99)
            {
                return "187.50";
            }

            else if (gIncome >= 16000.00 && gIncome <= 16999.99)
            {
                return "200.00";
            }

            else if (gIncome >= 17000.00 && gIncome <= 17999.99)
            {
                return "212.50";
            }

            else if (gIncome >= 18000.00 && gIncome <= 18999.99)
            {
                return "225.00";
            }

            else if (gIncome >= 19000.00 && gIncome <= 19999.99)
            {
                return "237.50";
            }

            else if (gIncome >= 20000.00 && gIncome <= 20999.99)
            {
                return "250.00";
            }

            else if (gIncome >= 21000.00 && gIncome <= 21999.99)
            {
                return "262.50";
            }

            else if (gIncome >= 22000.00 && gIncome <= 22999.99)
            {
                return "275.00";
            }

            else if (gIncome >= 23000.00 && gIncome <= 23999.99)
            {
                return "287.50";
            }

            else if (gIncome >= 24000.00 && gIncome <= 24999.99)
            {
                return "300.00";
            }

            else if (gIncome >= 25000.00 && gIncome <= 25999.99)
            {
                return "312.50";
            }

            else if (gIncome >= 26000.00 && gIncome <= 26999.99)
            {
                return "325.00";
            }

            else if (gIncome >= 27000.00 && gIncome <= 27999.99)
            {
                return "337.50";
            }

            else if (gIncome >= 28000.00 && gIncome <= 28999.99)
            {
                return "350.00";
            }

            else if (gIncome >= 29000.00 && gIncome <= 29999.99)
            {
                return "362.50";
            }

            else if (gIncome >= 30000.00 && gIncome <= 30999.99)
            {
                return "375.00";
            }

            else if (gIncome >= 31000.00 && gIncome <= 31999.99)
            {
                return "387.50";
            }

            else if (gIncome >= 32000.00 && gIncome <= 32999.99)
            {
                return "400.00";
            }

            else if (gIncome >= 33000.00 && gIncome <= 33999.99)
            {
                return "412.50";
            }

            else if (gIncome >= 34000.00 && gIncome <= 34999.99)
            {
                return "425.00";
            }

            else if (gIncome >= 35000.00)
            {
                return "437.50";
            }

            else
            {
                return "";
            }
        }

        private string TaxCompute(double gIncome)
        {
            //Gets tax based on gross income//
            double tempTax, lowRange, divisor = 24, additive;

            if(gIncome >= 0 && gIncome <= 10416.67)
            {
                return "0.00";
            }

            else if(gIncome > 10416.67 && gIncome <= 16666.67)
            {
                lowRange = 10416.67;
                tempTax = (gIncome - lowRange) * 0.20;
                return tempTax.ToString("0.00");
            }

            else if(gIncome > 16666.67 && gIncome <= 33333.33)
            {
                lowRange = 16666.67;
                additive = 30000;
                tempTax = ((gIncome - lowRange) * 0.25) + (additive / divisor);
                return tempTax.ToString("0.00");
            }

            else if(gIncome > 33333.33 && gIncome <= 83333.33)
            {
                lowRange = 33333.33;
                additive = 130000;
                tempTax = ((gIncome - lowRange) * 0.30) + (additive / divisor);
                return tempTax.ToString("0.00");
            }

            else if(gIncome > 83333.33 && gIncome <= 333333.33)
            {
                lowRange = 83333.33;
                additive = 490000;
                tempTax = ((gIncome - lowRange) * 0.32) + (additive / divisor);
                return tempTax.ToString("0.00");
            }

            else if(gIncome > 333333.33)
            {
                lowRange = 333333.33;
                additive = 2410000;
                tempTax = ((gIncome - lowRange) * 0.35) + (additive / divisor);
                return tempTax.ToString("0.00");
            }

            else
            {
                return "";
            }

        }

        private void PayrollFrm_Load(object sender, EventArgs e)
        {
            //Disable textboxes that do not need an input on form load//
            BasicIncCOTxtBox.Enabled = false;
            TotHonorPayTxtBox.Enabled = false;
            TotOtherPayTxtBox.Enabled = false;
            GIncomeTxtBox.Enabled = false;
            NIncomeTxtBox.Enabled = false;
            SSSContTxtBox.Enabled = false;
            PhilContTxtBox.Enabled = false;
            PagIContTxtBox.Enabled = false;           
            TaxTxtBox.Enabled = false;
            TotDeducTxtBox.Enabled = false;

            //Pagibig Contribution is a constant value//
            PagIContTxtBox.Text = "100.00";

            dclass.connString();
            sqlselect();
            dclass.cmd();
            dclass.sqladapter();
            dclass.sqldatasetPayroll();
            dataGridView1.DataSource = dclass.dsetPayroll.Tables[0];

            dclass.connection.Close();
        }
       

        private void BasicHrPerCOTxtBox_Leave(object sender, EventArgs e)
        {
            try
            {
                //Gets necessary values for calculation//
                rate = Convert.ToDouble(BasicRPerHTxtBox.Text);
                cutOff = Convert.ToDouble(BasicHrPerCOTxtBox.Text);

                //Calls the TotalPay function to calculate total basic pay//
                TotalPay();

                BasicIncCOTxtBox.Text = totPay.ToString();           
            }

            catch(FormatException)
            {
                errorMsg();
            }            
        }

        private void HonorHrPerCOTxtBox_Leave(object sender, EventArgs e)
        {
            try
            {
                //Gets necessary values for calculation//
                rate = Convert.ToDouble(HonorRPerHTxtBox.Text);
                cutOff = Convert.ToDouble(HonorHrPerCOTxtBox.Text);

                //Calls the TotalPay function to calculate total honorarium pay//
                TotalPay();

                TotHonorPayTxtBox.Text = totPay.ToString();
            }

            catch (FormatException)
            {
                errorMsg();
            }  
        }

        private void OtherHrPerCOTxtBox_Leave(object sender, EventArgs e)
        {
            try
            {
                //Gets necessary values for calculation//
                rate = Convert.ToDouble(OtherRPerHrTxtBox.Text);
                cutOff = Convert.ToDouble(OtherHrPerCOTxtBox.Text);

                //Calls the TotalPay function to calculate total other income pay//
                TotalPay();

                TotOtherPayTxtBox.Text = totPay.ToString();

                //Computes Gross Income//
                double basic, honor, other;
                basic = Convert.ToDouble(BasicIncCOTxtBox.Text);
                honor = Convert.ToDouble(TotHonorPayTxtBox.Text);
                other = Convert.ToDouble(TotOtherPayTxtBox.Text);

                grossInc = basic + honor + other;
                GIncomeTxtBox.Text = grossInc.ToString();
            }

            catch (FormatException)
            {
                errorMsg();
            }  
        }

        private void GIncomeTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Displays regular deductions//
                grossInc = Convert.ToDouble(GIncomeTxtBox.Text);

                SSSContTxtBox.Text = SSSCont(grossInc);
                PhilContTxtBox.Text = PhilHealth(grossInc);
                TaxTxtBox.Text = TaxCompute(grossInc);
            }

            catch (FormatException)
            {
                if (GIncomeTxtBox.Text == "")
                {

                }

                else
                {
                    errorMsg();
                }
            }  
        }

        private void OtherTxtBox_Leave(object sender, EventArgs e)
        {
            try
            {
                //Get sum of regular deductions//
                double regularDeduc, SSSCont, PhilHealthCont, PagICont, Tax;
                SSSCont = Convert.ToDouble(SSSContTxtBox.Text);
                PhilHealthCont = Convert.ToDouble(PhilContTxtBox.Text);
                PagICont = Convert.ToDouble(PagIContTxtBox.Text);
                Tax = Convert.ToDouble(TaxTxtBox.Text);

                regularDeduc = SSSCont + PhilHealthCont + PagICont + Tax;

                //Get sum of other deductions//
                double otherDeduc, SSSLoan, PagILoan, SaviDepo, SaviLoan, SalaLoan, Others;

                SSSLoan = Convert.ToDouble(formatCheck(SSSLoanTxtBox.Text));
                    if (SSSLoan == 0.00)
                        SSSLoanTxtBox.Text = "0.00";

                PagILoan = Convert.ToDouble(formatCheck(PagILoanTxtBox.Text));
                    if (PagILoan == 0.00)
                        PagILoanTxtBox.Text = "0.00";

                SaviDepo = Convert.ToDouble(formatCheck(SavDepTxtBox.Text));
                    if (SaviDepo == 0.00)
                        SavDepTxtBox.Text = "0.00";

                SaviLoan = Convert.ToDouble(formatCheck(SavLoanTxtBox.Text));
                    if (SaviLoan == 0.00)
                        SavLoanTxtBox.Text = "0.00";

                SalaLoan = Convert.ToDouble(formatCheck(SalLoanTxtBox.Text));
                    if (SalaLoan == 0.00)
                        SalLoanTxtBox.Text = "0.00";

                Others = Convert.ToDouble(OtherTxtBox.Text);

                otherDeduc = SSSLoan + PagILoan + SaviDepo + SaviLoan + SalaLoan + Others;

                //Get & diplay total deductions//
                double totDeduc;
                totDeduc = regularDeduc + otherDeduc;
                TotDeducTxtBox.Text = totDeduc.ToString();

                //Get & Display net income//
                double netInc;
                netInc = grossInc - totDeduc;

                NIncomeTxtBox.Text = "₱" + netInc.ToString();
            }

            catch(FormatException)
            {
                errorMsg();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //Closes the current form//
            this.Close();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            cleartxtboxes();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            cleartxtboxes();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            dclass.connString();
            //SQL Query for adding data//
            dclass.sql = "INSERT INTO PayrollTbl (Paydate, BasicRPH, BasicHrNum, BasicInc, HonorRPH, HonorHrNum, HonorInc, OtherRPH, OtherHrNum, OtherInc, GrossInc, NetInc, RDeducSSS, RDeducPhil, RDeducPagibig, RDeducTax, ODeducSSSLoan, ODeducPagibigLoan, ODeducSavDep, ODeducSavLoan, ODeducSalLoan, TotDeduc, emp_id) VALUES ('" + PaydateCmbBox.Text + "', '" + BasicRPerHTxtBox.Text + "', '" + BasicHrPerCOTxtBox.Text + "', '" + BasicIncCOTxtBox.Text + "', '" + HonorRPerHTxtBox.Text + "', '" + HonorHrPerCOTxtBox.Text + "', '" + TotHonorPayTxtBox.Text + "', '" + OtherRPerHrTxtBox.Text + "', '" + OtherHrPerCOTxtBox.Text + "', '" + TotOtherPayTxtBox.Text + "', '" + GIncomeTxtBox.Text + "', '" + NIncomeTxtBox.Text + "', '" + SSSContTxtBox.Text + "', '" + PhilContTxtBox.Text + "', '" + PagIContTxtBox.Text + "', '" + TaxTxtBox.Text + "', '" + SSSLoanTxtBox.Text + "', '" + PagILoanTxtBox.Text + "', '" + SavDepTxtBox.Text + "', '" + SavLoanTxtBox.Text + "', '" + SalLoanTxtBox.Text + "', '" + TotDeducTxtBox.Text + "', '" + EmNumTxtBox.Text +"')";

            dclass.cmd();
            sqladapterinsert();
            sqlselect();
            dclass.cmd();
            dclass.sqladapter();
            dclass.sqldatasetPayroll();
            dataGridView1.DataSource = dclass.dsetPayroll.Tables[0];
            cleartxtboxes();

            dclass.connection.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            dclass.connString();
            //SQL Query for editing data in the database//
            dclass.sql = "UPDATE PayrollTbl SET Paydate = '" + PaydateCmbBox.Text + "', BasicRPH = '" + BasicRPerHTxtBox.Text + "', BasicHrNum = '" + BasicIncCOTxtBox.Text + "', BasicInc = '" + BasicIncCOTxtBox.Text  + "', HonorRPH = '" + HonorRPerHTxtBox.Text + "', HonorHrNum = '" + HonorHrPerCOTxtBox.Text + "', HonorInc = '" + TotHonorPayTxtBox.Text + "', OtherRPH = '" + OtherRPerHrTxtBox.Text + "', OtherHrNum = '" + OtherHrPerCOTxtBox.Text + "', OtherInc = '" + TotOtherPayTxtBox.Text + "', GrossInc = '" + GIncomeTxtBox.Text + "', NetInc = '" + NIncomeTxtBox.Text + "', RDeducSSS = '" + SSSContTxtBox.Text + "', RDeducPhil = '" + PhilContTxtBox.Text + "',  RDeducPagibig = '" + PagIContTxtBox.Text + "', RDeducTax = '" + TaxTxtBox.Text + "', ODeducSSSLoan = '" + SSSLoanTxtBox.Text + "', ODeducPagibigLoan = '" + PagILoanTxtBox.Text + "', ODeducSavDep = '" + SavDepTxtBox.Text + "', ODeducSalLoan = '" + SalLoanTxtBox.Text + "', TotDeduc = '" + TotDeducTxtBox.Text + "' WHERE emp_id = " + EmNumTxtBox.Text + "'";

            dclass.cmd();
            dclass.sqladapter();
            sqlselect();
            dclass.cmd();
            dclass.sqladapter();
            dclass.sqldatasetPayroll();
            dataGridView1.DataSource = dclass.dsetPayroll.Tables[0];

            cleartxtboxes();

            dclass.connection.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            dclass.connString();
            //SQL Query for removing a row of data//
            dclass.sql = "DELETE FROM PayrollTbl WHERE emp_id ='" + EmNumTxtBox.Text + "'";

            dclass.cmd();
            dclass.sqladapter();
            sqlselect();
            dclass.cmd();
            dclass.sqladapter();
            dclass.sqldataset();
            dataGridView1.DataSource = dclass.dset.Tables[0];
            cleartxtboxes();

            dclass.connection.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            dclass.connString();
            //SQL Query for editing data in the database//
            dclass.sql = "SELECT emp_id, fname, mname, surname, status, position, num_of_dependents, department FROM EmployeeRegistrationTbl WHERE emp_id='" + EmNumTxtBox.Text + "'";

            dclass.cmd();
            dclass.sqladapter();
            dclass.sqldataset(); //Puts selected data in a dataset//

            FNameTxtBox.Text = dclass.dset.Tables[0].Rows[0][1].ToString();
            MNameTxtBox.Text = dclass.dset.Tables[0].Rows[0][2].ToString();
            SNameTxtBox.Text = dclass.dset.Tables[0].Rows[0][3].ToString();
            CivStaMainTxtBox.Text = dclass.dset.Tables[0].Rows[0][4].ToString();
            CivStaDepCmbBox.Text = dclass.dset.Tables[0].Rows[0][4].ToString();
            DesigMainTxtBox.Text = dclass.dset.Tables[0].Rows[0][5].ToString();
            DepeNumTxtBox.Text = dclass.dset.Tables[0].Rows[0][6].ToString();
            DepMainTxtBox.Text = dclass.dset.Tables[0].Rows[0][7].ToString();

            dclass.connection.Close();
        }
    }
}