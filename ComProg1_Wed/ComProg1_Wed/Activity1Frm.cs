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
    public partial class Activity1Frm : Form
    {
        public Activity1Frm()
        {
            InitializeComponent();            
        }

        private void Activity1Frm_Load(object sender, EventArgs e)
        {

        }

        private void DiscAmountTxtBox_TextChanged(object sender, EventArgs e)
        {
            double DiscPrice;

            if (DiscAmountTxtBox.Text.ToString() == "") ;

            else
            {
                DiscPrice = (Convert.ToDouble(QuantityTxtBox.Text) * Convert.ToDouble(PriceTxtBox.Text)) - Convert.ToDouble(DiscAmountTxtBox.Text);
                DiscPriceTxtBox.Text = DiscPrice.ToString();
            }
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            double DiscAmount, Change, DiscGiven;
            int ItemNum;

            if (TotDiscAmTxtBox.Text.ToString() == "")
                DiscAmount = 0 + Convert.ToDouble(DiscAmountTxtBox.Text);              
            else
                DiscAmount = Convert.ToDouble(TotDiscAmTxtBox.Text) + Convert.ToDouble(DiscAmountTxtBox.Text);

            if (TotItemNumTxtBox.Text.ToString() == "")
                ItemNum = 0 + Convert.ToInt32(QuantityTxtBox.Text);  
            else
                ItemNum = Convert.ToInt32(TotItemNumTxtBox.Text) + Convert.ToInt32(QuantityTxtBox.Text);


            if (TotDiscGivenTxtBox.Text.ToString() == "")
                DiscGiven = 1;
            else
                DiscGiven = 1 + Convert.ToDouble(DiscAmountTxtBox.Text);

            try
            {
                Change = Convert.ToDouble(CashRenTxtBox.Text) - Convert.ToDouble(DiscPriceTxtBox.Text);
            }
                TotDiscGivenTxtBox.Text = DiscGiven.ToString();
                TotItemNumTxtBox.Text = ItemNum.ToString();
                TotDiscAmTxtBox.Text = DiscAmount.ToString();
                ChangeTxtBox.Text = Change.ToString();            

            catch(FormatException)
            {

            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            ItemNameTxtBox.Clear();
            QuantityTxtBox.Clear();
            PriceTxtBox.Clear();
            DiscAmountTxtBox.Clear();
            DiscPriceTxtBox.Clear();
            CashRenTxtBox.Clear();
            ChangeTxtBox.Clear();
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
        }

    }
}
