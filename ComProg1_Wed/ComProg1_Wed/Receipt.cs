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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();           
        }

        public void AddList(string name, string quant, string price)
        {
            ItemList.Items.Add(name).SubItems.AddRange(new string[] {quant, price});
        }

        private void RecCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
