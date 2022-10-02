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
    public partial class PointOfSale : Form
    {
        DataClass dclass = new DataClass();

        public string ID;

        public PointOfSale()
        {           
            InitializeComponent();            
        }

        private void ErrorMessage()
        {
            MessageBox.Show("Error!!!");
        }
        private void PointOfSale_Load(object sender, EventArgs e)
        {
            PicPathTxtBox1.Hide();
            PicPathTxtBox2.Hide();
            PicPathTxtBox3.Hide();
            PicPathTxtBox4.Hide();
            PicPathTxtBox5.Hide();
            PicPathTxtBox6.Hide();
            PicPathTxtBox7.Hide();
            PicPathTxtBox8.Hide();
            PicPathTxtBox9.Hide();
            PicPathTxtBox10.Hide();
            PicPathTxtBox11.Hide();
            PicPathTxtBox12.Hide();
            PicPathTxtBox13.Hide();
            PicPathTxtBox14.Hide();
            PicPathTxtBox15.Hide();
            PicPathTxtBox16.Hide();
            PicPathTxtBox17.Hide();
            PicPathTxtBox18.Hide();
            PicPathTxtBox19.Hide();
            PicPathTxtBox20.Hide();        

            dclass.connString();

            sqlselect();
            dclass.cmd();
            dclass.sqladapter();
            dclass.sqldatasetPOS();

            DonutLbl1.Text = dclass.dsetPOS.Tables[0].Rows[0][1].ToString();
            DonutLbl2.Text = dclass.dsetPOS.Tables[0].Rows[0][2].ToString();
            DonutLbl3.Text = dclass.dsetPOS.Tables[0].Rows[0][3].ToString();
            DonutLbl4.Text = dclass.dsetPOS.Tables[0].Rows[0][4].ToString();
            DonutLbl5.Text = dclass.dsetPOS.Tables[0].Rows[0][5].ToString();
            DonutLbl6.Text = dclass.dsetPOS.Tables[0].Rows[0][6].ToString();
            DonutLbl7.Text = dclass.dsetPOS.Tables[0].Rows[0][7].ToString();
            DonutLbl8.Text = dclass.dsetPOS.Tables[0].Rows[0][8].ToString();
            DonutLbl9.Text = dclass.dsetPOS.Tables[0].Rows[0][9].ToString();
            DonutLbl10.Text = dclass.dsetPOS.Tables[0].Rows[0][10].ToString();
            DonutLbl11.Text = dclass.dsetPOS.Tables[0].Rows[0][11].ToString();
            DonutLbl12.Text = dclass.dsetPOS.Tables[0].Rows[0][12].ToString();
            DonutLbl13.Text = dclass.dsetPOS.Tables[0].Rows[0][13].ToString();
            DonutLbl14.Text = dclass.dsetPOS.Tables[0].Rows[0][14].ToString();
            DonutLbl15.Text = dclass.dsetPOS.Tables[0].Rows[0][15].ToString();
            DonutLbl16.Text = dclass.dsetPOS.Tables[0].Rows[0][16].ToString();
            DonutLbl17.Text = dclass.dsetPOS.Tables[0].Rows[0][17].ToString();
            DonutLbl18.Text = dclass.dsetPOS.Tables[0].Rows[0][18].ToString();
            DonutLbl19.Text = dclass.dsetPOS.Tables[0].Rows[0][19].ToString();
            DonutLbl20.Text = dclass.dsetPOS.Tables[0].Rows[0][20].ToString();

            label1.Text = dclass.dsetPOS.Tables[0].Rows[0][22].ToString();
            label2.Text = dclass.dsetPOS.Tables[0].Rows[0][23].ToString();
            label3.Text = dclass.dsetPOS.Tables[0].Rows[0][24].ToString();
            label4.Text = dclass.dsetPOS.Tables[0].Rows[0][25].ToString();
            label5.Text = dclass.dsetPOS.Tables[0].Rows[0][26].ToString();
            label6.Text = dclass.dsetPOS.Tables[0].Rows[0][27].ToString();
            label7.Text = dclass.dsetPOS.Tables[0].Rows[0][28].ToString();
            label8.Text = dclass.dsetPOS.Tables[0].Rows[0][29].ToString();
            label9.Text = dclass.dsetPOS.Tables[0].Rows[0][30].ToString();
            label10.Text = dclass.dsetPOS.Tables[0].Rows[0][31].ToString();
            label11.Text = dclass.dsetPOS.Tables[0].Rows[0][32].ToString();
            label12.Text = dclass.dsetPOS.Tables[0].Rows[0][33].ToString();
            label13.Text = dclass.dsetPOS.Tables[0].Rows[0][34].ToString();
            label14.Text = dclass.dsetPOS.Tables[0].Rows[0][35].ToString();
            label15.Text = dclass.dsetPOS.Tables[0].Rows[0][36].ToString();
            label16.Text = dclass.dsetPOS.Tables[0].Rows[0][37].ToString();
            label17.Text = dclass.dsetPOS.Tables[0].Rows[0][38].ToString();
            label18.Text = dclass.dsetPOS.Tables[0].Rows[0][39].ToString();
            label19.Text = dclass.dsetPOS.Tables[0].Rows[0][40].ToString();
            label20.Text = dclass.dsetPOS.Tables[0].Rows[0][41].ToString();

            PicPathTxtBox1.Text = dclass.dsetPOS.Tables[0].Rows[0][43].ToString();
            PicPathTxtBox2.Text = dclass.dsetPOS.Tables[0].Rows[0][44].ToString();
            PicPathTxtBox3.Text = dclass.dsetPOS.Tables[0].Rows[0][45].ToString();
            PicPathTxtBox4.Text = dclass.dsetPOS.Tables[0].Rows[0][46].ToString();
            PicPathTxtBox5.Text = dclass.dsetPOS.Tables[0].Rows[0][47].ToString();
            PicPathTxtBox6.Text = dclass.dsetPOS.Tables[0].Rows[0][48].ToString();
            PicPathTxtBox7.Text = dclass.dsetPOS.Tables[0].Rows[0][49].ToString();
            PicPathTxtBox8.Text = dclass.dsetPOS.Tables[0].Rows[0][50].ToString();
            PicPathTxtBox9.Text = dclass.dsetPOS.Tables[0].Rows[0][51].ToString();
            PicPathTxtBox10.Text = dclass.dsetPOS.Tables[0].Rows[0][52].ToString();
            PicPathTxtBox11.Text = dclass.dsetPOS.Tables[0].Rows[0][53].ToString();
            PicPathTxtBox12.Text = dclass.dsetPOS.Tables[0].Rows[0][54].ToString();
            PicPathTxtBox13.Text = dclass.dsetPOS.Tables[0].Rows[0][55].ToString();
            PicPathTxtBox14.Text = dclass.dsetPOS.Tables[0].Rows[0][56].ToString();
            PicPathTxtBox15.Text = dclass.dsetPOS.Tables[0].Rows[0][57].ToString();
            PicPathTxtBox16.Text = dclass.dsetPOS.Tables[0].Rows[0][58].ToString();
            PicPathTxtBox17.Text = dclass.dsetPOS.Tables[0].Rows[0][59].ToString();
            PicPathTxtBox18.Text = dclass.dsetPOS.Tables[0].Rows[0][60].ToString();
            PicPathTxtBox19.Text = dclass.dsetPOS.Tables[0].Rows[0][61].ToString();
            PicPathTxtBox20.Text = dclass.dsetPOS.Tables[0].Rows[0][62].ToString();

            try
            {
                DonutPic1.Image = Image.FromFile(PicPathTxtBox1.Text);
                DonutPic2.Image = Image.FromFile(PicPathTxtBox2.Text);
                DonutPic3.Image = Image.FromFile(PicPathTxtBox3.Text);
                DonutPic4.Image = Image.FromFile(PicPathTxtBox4.Text);
                DonutPic5.Image = Image.FromFile(PicPathTxtBox5.Text);
                DonutPic6.Image = Image.FromFile(PicPathTxtBox6.Text);
                DonutPic7.Image = Image.FromFile(PicPathTxtBox7.Text);
                DonutPic8.Image = Image.FromFile(PicPathTxtBox8.Text);
                DonutPic9.Image = Image.FromFile(PicPathTxtBox9.Text);
                DonutPic10.Image = Image.FromFile(PicPathTxtBox10.Text);
                DonutPic11.Image = Image.FromFile(PicPathTxtBox11.Text);
                DonutPic12.Image = Image.FromFile(PicPathTxtBox12.Text);
                DonutPic13.Image = Image.FromFile(PicPathTxtBox13.Text);
                DonutPic14.Image = Image.FromFile(PicPathTxtBox14.Text);
                DonutPic15.Image = Image.FromFile(PicPathTxtBox15.Text);
                DonutPic16.Image = Image.FromFile(PicPathTxtBox16.Text);
                DonutPic17.Image = Image.FromFile(PicPathTxtBox17.Text);
                DonutPic18.Image = Image.FromFile(PicPathTxtBox18.Text);
                DonutPic19.Image = Image.FromFile(PicPathTxtBox19.Text);
                DonutPic20.Image = Image.FromFile(PicPathTxtBox20.Text);
            }

            catch { };
        }

        private void sqlselect()
        {
            //Select command//
            dclass.sql = "SELECT * FROM ItemNameTbl INNER JOIN PriceTbl ON ItemNameTbl.POS_ID=PriceTbl.POS_ID INNER JOIN PicPathTbl ON ItemNameTbl.POS_ID=PicPathTbl.POS_ID WHERE ItemNameTbl.POS_ID='3'";
        }

        private void sqladapterinsert()
        {
            //Performs SQL insert command//
            dclass.adaptersql = new SqlDataAdapter();
            dclass.adaptersql.InsertCommand = dclass.command;
            dclass.command.ExecuteNonQuery();
        }

        public string[] NameList = new string[0];

        public string[] QuantList = new string[0];

        public string[] DisPriceList = new string[0];

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            double DiscAmount,  DiscGiven, Change, ItemNum;

            if (Convert.ToDouble(CashRenTxtBox.Text) < Convert.ToDouble(DiscPriceTxtBox.Text))
            {

            }

            else
            {
                Array.Resize(ref NameList, NameList.Length + 1);
                Array.Resize(ref QuantList, QuantList.Length + 1);
                Array.Resize(ref DisPriceList, DisPriceList.Length + 1);

                NameList[NameList.Length - 1] = ItemNameTxtBox.Text;
                QuantList[NameList.Length - 1] = QuantityTxtBox.Text;
                DisPriceList[NameList.Length - 1] = DiscPriceTxtBox.Text;

                Change = Convert.ToDouble(CashRenTxtBox.Text) - Convert.ToDouble(DiscPriceTxtBox.Text);
                ChangeTxtBox.Text = 'P' + Change.ToString("0.00");

                if (TotDiscAmTxtBox.Text.ToString() == "")
                    DiscAmount = 0 + Convert.ToDouble(DiscPriceTxtBox.Text);
                else
                    DiscAmount = Convert.ToDouble(TotDiscAmTxtBox.Text) + Convert.ToDouble(DiscPriceTxtBox.Text);

                if (TotItemNumTxtBox.Text.ToString() == "")
                    ItemNum = 0 + Convert.ToDouble(QuantityTxtBox.Text);
                else
                    ItemNum = Convert.ToDouble(TotItemNumTxtBox.Text) + Convert.ToDouble(QuantityTxtBox.Text);


                if (TotDiscGivenTxtBox.Text.ToString() == "")
                    DiscGiven = 0 + Convert.ToDouble(DiscAmountTxtBox.Text);
                else
                    DiscGiven = Convert.ToDouble(TotDiscGivenTxtBox.Text) + Convert.ToDouble(DiscAmountTxtBox.Text);

                TotDiscGivenTxtBox.Text = DiscGiven.ToString("0.00");
                TotItemNumTxtBox.Text = ItemNum.ToString();
                TotDiscAmTxtBox.Text = DiscAmount.ToString("0.00");

            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ItemNameTxtBox.Clear();
            QuantityTxtBox.Clear();
            PriceTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
        }

        private void DonutPic1_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl1.Text;
            PriceTxtBox.Text = label1.Text;
        }

        private void DonutPic2_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl2.Text;
            PriceTxtBox.Text = label2.Text;
        }

        private void DonutPic3_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl3.Text;
            PriceTxtBox.Text = label3.Text;
        }

        private void DonutPic4_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl4.Text;
            PriceTxtBox.Text = label4.Text;
        }

        private void DonutPic5_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl5.Text;
            PriceTxtBox.Text = label5.Text;
        }

        private void DonutPic6_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl6.Text;
            PriceTxtBox.Text = label6.Text;
        }

        private void DonutPic7_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl7.Text;
            PriceTxtBox.Text = label7.Text;
        }

        private void DonutPic8_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl8.Text;
            PriceTxtBox.Text = label8.Text;
        }

        private void DonutPic9_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl9.Text;
            PriceTxtBox.Text = label9.Text;
        }

        private void DonutPic10_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl10.Text;
            PriceTxtBox.Text = label10.Text;
        }

        private void DonutPic11_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl11.Text;
            PriceTxtBox.Text = label11.Text;
        }

        private void DonutPic12_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl12.Text;
            PriceTxtBox.Text = label12.Text;
        }

        private void DonutPic13_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl13.Text;
            PriceTxtBox.Text = label13.Text;
        }

        private void DonutPic14_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl14.Text;
            PriceTxtBox.Text = label14.Text;
        }

        private void DonutPic15_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl15.Text;
            PriceTxtBox.Text = label15.Text;
        }

        private void DonutPic16_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl16.Text;
            PriceTxtBox.Text = label16.Text;
        }

        private void DonutPic17_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl17.Text;
            PriceTxtBox.Text = label17.Text;
        }

        private void DonutPic18_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl18.Text;
            PriceTxtBox.Text = label18.Text;
        }

        private void DonutPic19_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl19.Text;
            PriceTxtBox.Text = label19.Text;
        }

        private void DonutPic20_Click(object sender, EventArgs e)
        {
            QuantityTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
            SenDisRadBtn.Checked = false;
            CardDiscRadBtn.Checked = false;
            EmpDiscRadBtn.Checked = false;
            NoDiscRadBtn.Checked = false;
            ItemNameTxtBox.Text = DonutLbl20.Text;
            PriceTxtBox.Text = label20.Text;
        }

        private void SenDisRadBtn_Click(object sender, EventArgs e)
        {
            double Discount = .30;

            DiscAmountTxtBox.Text = ((Convert.ToDouble(PriceTxtBox.Text)*Convert.ToDouble(QuantityTxtBox.Text)) * Discount).ToString("0.00");
            DiscPriceTxtBox.Text = (((Convert.ToDouble(PriceTxtBox.Text) - (Convert.ToDouble(PriceTxtBox.Text) * Discount))*Convert.ToDouble(QuantityTxtBox.Text))).ToString("0.00");
        }

        private void CardDiscRadBtn_Click(object sender, EventArgs e)
        {
            double Discount = .15;

            DiscAmountTxtBox.Text = ((Convert.ToDouble(PriceTxtBox.Text) * Convert.ToDouble(QuantityTxtBox.Text)) * Discount).ToString("0.00");
            DiscPriceTxtBox.Text = (((Convert.ToDouble(PriceTxtBox.Text) - (Convert.ToDouble(PriceTxtBox.Text) * Discount)) * Convert.ToDouble(QuantityTxtBox.Text))).ToString("0.00");
        }

        private void EmpDiscRadBtn_Click(object sender, EventArgs e)
        {
            double Discount = .10;

            DiscAmountTxtBox.Text = ((Convert.ToDouble(PriceTxtBox.Text) * Convert.ToDouble(QuantityTxtBox.Text)) * Discount).ToString("0.00");
            DiscPriceTxtBox.Text = (((Convert.ToDouble(PriceTxtBox.Text) - (Convert.ToDouble(PriceTxtBox.Text) * Discount)) * Convert.ToDouble(QuantityTxtBox.Text))).ToString("0.00");
        }

        private void NoDiscRadBtn_Click(object sender, EventArgs e)
        {
            double Discount = 0;

            DiscAmountTxtBox.Text = ((Convert.ToDouble(PriceTxtBox.Text) * Convert.ToDouble(QuantityTxtBox.Text)) * Discount).ToString("0.00");
            DiscPriceTxtBox.Text = (((Convert.ToDouble(PriceTxtBox.Text) - (Convert.ToDouble(PriceTxtBox.Text) * Discount)) * Convert.ToDouble(QuantityTxtBox.Text))).ToString("0.00");
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (CashRenTxtBox.Text != "" && DiscPriceTxtBox.Text != "")
                CalculateBtn_Click(sender, e);
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (DiscPriceTxtBox.Text != "")
            {
                if (Convert.ToDouble(CashRenTxtBox.Text) > 0)
                    CashRenTxtBox.Text = CashRenTxtBox.Text.ToString() + '0';
            }

            if (CashRenTxtBox.Text == "")
            {
                if (QuantityTxtBox.Text != "0" || QuantityTxtBox.Text == "0")                
                    QuantityTxtBox.Text = QuantityTxtBox.Text.ToString() + '0';               
            }
            
        }

        private void DecimalBtn_Click(object sender, EventArgs e)
        {
            if (DiscPriceTxtBox.Text != "")
            {
                if (CashRenTxtBox.Text == "" && CashRenTxtBox.Text.Contains('.') == false)
                    CashRenTxtBox.Text = "0.";
                else if (CashRenTxtBox.Text != "0" && CashRenTxtBox.Text.Contains('.') == false)
                    CashRenTxtBox.Text = CashRenTxtBox.Text.ToString() + '.';
            }

            if (CashRenTxtBox.Text == "")
            {
                if (QuantityTxtBox.Text == "" && QuantityTxtBox.Text.Contains('.') == false)
                    QuantityTxtBox.Text = "0.";
                else if (QuantityTxtBox.Text != "0" && QuantityTxtBox.Text.Contains('.') == false)
                    QuantityTxtBox.Text = QuantityTxtBox.Text.ToString() + '.';               
            }
          
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (DiscPriceTxtBox.Text != "")
            {
                if (CashRenTxtBox.Text == "")
                    CashRenTxtBox.Text = "1";
                else
                    CashRenTxtBox.Text = CashRenTxtBox.Text + '1';
            }

            if (CashRenTxtBox.Text == "")
            {
                if (QuantityTxtBox.Text == "")
                    QuantityTxtBox.Text = "1";
                else
                    QuantityTxtBox.Text = QuantityTxtBox.Text + '1';
            }          
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (DiscPriceTxtBox.Text != "")
            {
                if (CashRenTxtBox.Text == "")
                    CashRenTxtBox.Text = "2";
                else
                    CashRenTxtBox.Text = CashRenTxtBox.Text + '2';
            }

            if (CashRenTxtBox.Text == "")
            {
                if (QuantityTxtBox.Text == "")
                    QuantityTxtBox.Text = "2";
                else
                    QuantityTxtBox.Text = QuantityTxtBox.Text + '2';
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {

            if (DiscPriceTxtBox.Text != "")
            {
                if (CashRenTxtBox.Text == "")
                    CashRenTxtBox.Text = "3";
                else
                    CashRenTxtBox.Text = CashRenTxtBox.Text + '3';
            }

            if (CashRenTxtBox.Text == "")
            {
                if (QuantityTxtBox.Text == "")
                    QuantityTxtBox.Text = "3";
                else
                    QuantityTxtBox.Text = QuantityTxtBox.Text + '3';
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (DiscPriceTxtBox.Text != "")
            {
                if (CashRenTxtBox.Text == "")
                    CashRenTxtBox.Text = "4";
                else
                    CashRenTxtBox.Text = CashRenTxtBox.Text + '4';
            }

            if (CashRenTxtBox.Text == "")
            {
                if (QuantityTxtBox.Text == "")
                    QuantityTxtBox.Text = "4";
                else
                    QuantityTxtBox.Text = QuantityTxtBox.Text + '4';
            }            
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (DiscPriceTxtBox.Text != "")
            {
                if (CashRenTxtBox.Text == "")
                    CashRenTxtBox.Text = "5";
                else
                    CashRenTxtBox.Text = CashRenTxtBox.Text + '5';
            }

            if (CashRenTxtBox.Text == "")
            {
                if (QuantityTxtBox.Text == "")
                    QuantityTxtBox.Text = "5";
                else
                    QuantityTxtBox.Text = QuantityTxtBox.Text + '5';
            }         
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (DiscPriceTxtBox.Text != "")
            {
                if (CashRenTxtBox.Text == "")
                    CashRenTxtBox.Text = "6";
                else
                    CashRenTxtBox.Text = CashRenTxtBox.Text + '6';
            }

            if (CashRenTxtBox.Text == "")
            {
                if (QuantityTxtBox.Text == "")
                    QuantityTxtBox.Text = "6";
                else
                    QuantityTxtBox.Text = QuantityTxtBox.Text + '6';
            }           
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (DiscPriceTxtBox.Text != "")
            {
                if (CashRenTxtBox.Text == "")
                    CashRenTxtBox.Text = "7";
                else
                    CashRenTxtBox.Text = CashRenTxtBox.Text + '7';
            }

            if (CashRenTxtBox.Text == "")
            {
                if (QuantityTxtBox.Text == "")
                    QuantityTxtBox.Text = "7";
                else
                    QuantityTxtBox.Text = QuantityTxtBox.Text + '7';
            }            
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (DiscPriceTxtBox.Text != "")
            {
                if (CashRenTxtBox.Text == "")
                    CashRenTxtBox.Text = "8";
                else
                    CashRenTxtBox.Text = CashRenTxtBox.Text + '8';
            }

            if (CashRenTxtBox.Text == "")
            {
                if (QuantityTxtBox.Text == "")
                    QuantityTxtBox.Text = "8";
                else
                    QuantityTxtBox.Text = QuantityTxtBox.Text + '8';
            }          
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (DiscPriceTxtBox.Text != "")
            {
                if (CashRenTxtBox.Text == "")
                    CashRenTxtBox.Text = "9";
                else
                    CashRenTxtBox.Text = CashRenTxtBox.Text + '9';
            }

            if (CashRenTxtBox.Text == "")
            {
                if (QuantityTxtBox.Text == "")
                    QuantityTxtBox.Text = "9";
                else
                    QuantityTxtBox.Text = QuantityTxtBox.Text + '9';
            }          
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            Receipt Receipt = new Receipt();
          
            Receipt.Show();
            for (int x = 0; x < NameList.Length; x++ )
                Receipt.AddList(NameList[x], QuantList[x], DisPriceList[x]);
        }

        private void CompanynameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
