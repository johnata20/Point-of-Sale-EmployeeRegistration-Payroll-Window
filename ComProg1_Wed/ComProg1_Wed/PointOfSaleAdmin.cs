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
    public partial class PointOfSaleAdmin : Form
    {
        DataClass dclass = new DataClass();

        public string ID;

        public PointOfSaleAdmin()
        {
            //Database Connection//
            dclass.connString();
            InitializeComponent();
        }     

        private void cleartxtboxes()
        {
            IDTxtBox.Clear();
            ItemPriceTxtBox1.Clear();
            ItemPriceTxtBox2.Clear();
            ItemPriceTxtBox3.Clear();
            ItemPriceTxtBox4.Clear();
            ItemPriceTxtBox5.Clear();
            ItemPriceTxtBox6.Clear();
            ItemPriceTxtBox7.Clear();
            ItemPriceTxtBox8.Clear();
            ItemPriceTxtBox9.Clear();
            ItemPriceTxtBox10.Clear();
            ItemPriceTxtBox11.Clear();
            ItemPriceTxtBox12.Clear();
            ItemPriceTxtBox13.Clear();
            ItemPriceTxtBox14.Clear();
            ItemPriceTxtBox15.Clear();
            ItemPriceTxtBox16.Clear();
            ItemPriceTxtBox17.Clear();
            ItemPriceTxtBox18.Clear();
            ItemPriceTxtBox19.Clear();
            ItemPriceTxtBox20.Clear();

            ItemNameTxtBox1.Clear();
            ItemNameTxtBox2.Clear();
            ItemNameTxtBox3.Clear();
            ItemNameTxtBox4.Clear();
            ItemNameTxtBox5.Clear();
            ItemNameTxtBox6.Clear();
            ItemNameTxtBox7.Clear();
            ItemNameTxtBox8.Clear();
            ItemNameTxtBox9.Clear();
            ItemNameTxtBox10.Clear(); 
            ItemNameTxtBox11.Clear();
            ItemNameTxtBox12.Clear();
            ItemNameTxtBox13.Clear();
            ItemNameTxtBox14.Clear();
            ItemNameTxtBox15.Clear();
            ItemNameTxtBox16.Clear();
            ItemNameTxtBox17.Clear();
            ItemNameTxtBox18.Clear();
            ItemNameTxtBox19.Clear();
            ItemNameTxtBox20.Clear();

            PicPathTxtBox1.Clear();
            PicPathTxtBox2.Clear(); 
            PicPathTxtBox3.Clear();
            PicPathTxtBox4.Clear();
            PicPathTxtBox5.Clear();
            PicPathTxtBox6.Clear();
            PicPathTxtBox7.Clear();
            PicPathTxtBox8.Clear();
            PicPathTxtBox9.Clear();
            PicPathTxtBox10.Clear();
            PicPathTxtBox11.Clear();
            PicPathTxtBox12.Clear();
            PicPathTxtBox13.Clear();
            PicPathTxtBox14.Clear();
            PicPathTxtBox15.Clear();
            PicPathTxtBox16.Clear();
            PicPathTxtBox17.Clear();
            PicPathTxtBox18.Clear();
            PicPathTxtBox19.Clear();
            PicPathTxtBox20.Clear();

            DonutPic1.Image = null;
            DonutPic2.Image = null;
            DonutPic3.Image = null;
            DonutPic4.Image = null;
            DonutPic5.Image = null;
            DonutPic6.Image = null;
            DonutPic7.Image = null;
            DonutPic8.Image = null;
            DonutPic9.Image = null;
            DonutPic10.Image = null;
            DonutPic11.Image = null;
            DonutPic12.Image = null;
            DonutPic13.Image = null;
            DonutPic14.Image = null;
            DonutPic15.Image = null;
            DonutPic16.Image = null;
            DonutPic17.Image = null;
            DonutPic18.Image = null;
            DonutPic19.Image = null;
            DonutPic20.Image = null;
        }

        private void fileDialog(TextBox A, PictureBox B)
        {
            //Sets the file dialog to only accept image files//
            openFileDialog1.Filter = "Image Files(*.JPEG;*.JPG;*.PNG;*.IMG)|*.JPEG;*.JPG;*.PNG;*.IMG|All files (*.*)|*.*";

            //Opens File Dialog for picture selection
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK) //If FileDialog returns OK, displays picture and puts the filepath in a temporary textbox//
            {
                string file = openFileDialog1.FileName;

                A.Text = file;
                B.Image = Image.FromFile(A.Text);
            }
        }

        private void sqlselect()
        {
            //Select command//
            dclass.sql = "SELECT * FROM ItemNameTbl INNER JOIN PriceTbl ON ItemNameTbl.POS_ID=PriceTbl.POS_ID INNER JOIN PicPathTbl ON ItemNameTbl.POS_ID=PicPathTbl.POS_ID";
        }

        private void sqladapterinsert()
        {
            //Performs SQL insert command//
            dclass.adaptersql = new SqlDataAdapter();
            dclass.adaptersql.InsertCommand = dclass.command;
            dclass.command.ExecuteNonQuery();
        }

        private void PointOfSaleAdmin_Load(object sender, EventArgs e)
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
            dataGridView1.DataSource = dclass.dsetPOS.Tables[0];

            dclass.connection.Close();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            cleartxtboxes();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            dclass.connString();
            //SQL Query for removing a row of data//
            dclass.sql = "DELETE FROM ItemNameTbl WHERE POS_ID ='" + IDTxtBox.Text + "'";
            dclass.cmd();
            dclass.sqladapter();

            //SQL Query for removing a row of data//
            dclass.sql = "DELETE FROM PriceTbl WHERE POS_ID ='" + IDTxtBox.Text + "'";
            dclass.cmd();
            dclass.sqladapter();

            //SQL Query for removing a row of data//
            dclass.sql = "DELETE FROM PicPathTbl WHERE POS_ID ='" + IDTxtBox.Text + "'";
            dclass.cmd();
            dclass.sqladapter();

            sqlselect();
            dclass.cmd();
            dclass.sqladapter();
            dclass.sqldatasetPOS();
            dataGridView1.DataSource = dclass.dsetPOS.Tables[0];
            cleartxtboxes();

            dclass.connection.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            dclass.connString();
            //SQL Query for editing data in the database//
            dclass.sql = "UPDATE ItemNameTbl SET Item1Name = '" + ItemNameTxtBox1.Text + "', Item2Name = '" + ItemNameTxtBox2.Text + "', Item3Name = '" + ItemNameTxtBox3.Text + "', Item4Name = '" + ItemNameTxtBox4.Text + "', Item5Name ='" + ItemNameTxtBox5.Text + "', Item6Name = '" + ItemNameTxtBox6.Text + "', Item7Name = '" + ItemNameTxtBox7.Text + "', Item8Name = '" + ItemNameTxtBox8.Text + "', Item9Name = '" + ItemNameTxtBox9.Text + "', Item10Name = '" + ItemNameTxtBox10.Text + "', Item11Name = '" + ItemNameTxtBox11.Text + "', Item12Name = '" + ItemNameTxtBox12.Text + "', Item13Name = '" + ItemNameTxtBox13.Text + "', Item14Name = '" + ItemNameTxtBox14.Text + "', Item15Name = '" + ItemNameTxtBox15.Text + "', Item16Name = '" + ItemNameTxtBox16.Text + "', Item17Name = '" + ItemNameTxtBox17.Text + "', Item18Name = '" + ItemNameTxtBox18.Text + "', Item19Name = '" + ItemNameTxtBox19.Text + "', Item20Name = '" + ItemNameTxtBox20.Text + "' WHERE POS_ID = '" + IDTxtBox.Text + "'";
            dclass.cmd();
            dclass.sqladapter();           

            dclass.sql = "UPDATE PriceTbl SET Item1Price = '" + ItemPriceTxtBox1.Text + "', Item2Price = '" + ItemPriceTxtBox2.Text + "', Item3Price = '" + ItemPriceTxtBox3.Text + "', Item4Price = '" + ItemPriceTxtBox4.Text + "', Item5Price ='" + ItemPriceTxtBox5.Text + "', Item6Price = '" + ItemPriceTxtBox6.Text + "', Item7Price = '" + ItemPriceTxtBox7.Text + "', Item8Price = '" + ItemPriceTxtBox8.Text + "', Item9Price = '" + ItemPriceTxtBox9.Text + "', Item10Price = '" + ItemPriceTxtBox10.Text + "', Item11Price = '" + ItemPriceTxtBox11.Text + "', Item12Price = '" + ItemPriceTxtBox12.Text + "', Item13Price = '" + ItemPriceTxtBox13.Text + "', Item14Price = '" + ItemPriceTxtBox14.Text + "', Item15Price = '" + ItemPriceTxtBox15.Text + "', Item16Price = '" + ItemPriceTxtBox16.Text + "', Item17Price = '" + ItemPriceTxtBox17.Text + "', Item18Price = '" + ItemPriceTxtBox18.Text + "', Item19Price = '" + ItemPriceTxtBox19.Text + "', Item20Price = '" + ItemPriceTxtBox20.Text + "' WHERE POS_ID = '" + IDTxtBox.Text + "'";
            dclass.cmd();
            dclass.sqladapter();

            dclass.sql = "UPDATE PicPathTbl SET Item1Pic = '" + PicPathTxtBox1.Text + "', Item2Pic = '" + PicPathTxtBox2.Text + "', Item3Pic = '" + PicPathTxtBox3.Text + "', Item4Pic = '" + PicPathTxtBox4.Text + "', Item5Pic ='" + PicPathTxtBox5.Text + "', Item6Pic = '" + PicPathTxtBox6.Text + "', Item7Pic = '" + PicPathTxtBox7.Text + "', Item8Pic = '" + PicPathTxtBox8.Text + "', Item9Pic = '" + PicPathTxtBox9.Text + "', Item10Pic = '" + PicPathTxtBox10.Text + "', Item11Pic = '" + PicPathTxtBox11.Text + "', Item12Pic = '" + PicPathTxtBox12.Text + "', Item13Pic = '" + PicPathTxtBox13.Text + "', Item14Pic = '" + PicPathTxtBox14.Text + "', Item15Pic = '" + PicPathTxtBox15.Text + "', Item16Pic = '" + PicPathTxtBox16.Text + "', Item17Pic = '" + PicPathTxtBox17.Text + "', Item18Pic = '" + PicPathTxtBox18.Text + "', Item19Pic = '" + PicPathTxtBox19.Text + "', Item20Pic = '" + PicPathTxtBox20.Text + "' WHERE POS_ID = '" + IDTxtBox.Text + "'";
            dclass.cmd();
            dclass.sqladapter();

            sqlselect();
            dclass.cmd();
            dclass.sqladapter();
            dclass.sqldatasetPOS();
            dataGridView1.DataSource = dclass.dsetPOS.Tables[0];
            cleartxtboxes();

            dclass.connection.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            dclass.connString();
            //SQL Query for adding data//
            dclass.sql = "INSERT INTO ItemNameTbl (POS_ID, Item1Name, Item2Name, Item3Name, Item4Name, Item5Name, Item6Name, Item7Name, Item8Name, Item9Name, Item10Name, Item11Name, Item12Name, Item13Name, Item14Name, Item15Name, Item16Name, Item17Name, Item18Name, Item19Name, Item20Name) VALUES ('" + IDTxtBox.Text + "', '" + ItemNameTxtBox1.Text + "', '" + ItemNameTxtBox2.Text + "', '" + ItemNameTxtBox3.Text + "', '" + ItemNameTxtBox4.Text + "', '" + ItemNameTxtBox5.Text + "', '" + ItemNameTxtBox6.Text + "', '" + ItemNameTxtBox7.Text + "', '" + ItemNameTxtBox8.Text + "', '" + ItemNameTxtBox9.Text + "', '" + ItemNameTxtBox10.Text + "', '" + ItemNameTxtBox11.Text + "', '" + ItemNameTxtBox12.Text + "', '" + ItemNameTxtBox13.Text + "', '" + ItemNameTxtBox14.Text + "', '" + ItemNameTxtBox15.Text + "', '" + ItemNameTxtBox16.Text + "', '" + ItemNameTxtBox17.Text + "', '" + ItemNameTxtBox18.Text + "', '" + ItemNameTxtBox19.Text + "', '" + ItemNameTxtBox20.Text + "')";
            dclass.cmd();
            sqladapterinsert();

            dclass.sql = "INSERT INTO PriceTbl (POS_ID, Item1Price, Item2Price, Item3Price, Item4Price, Item5Price, Item6Price, Item7Price, Item8Price, Item9Price, Item10Price, Item11Price, Item12Price, Item13Price, Item14Price, Item15Price, Item16Price, Item17Price, Item18Price, Item19Price, Item20Price) VALUES ('" + IDTxtBox.Text + "', '" + ItemPriceTxtBox1.Text + "', '" + ItemPriceTxtBox2.Text + "', '" + ItemPriceTxtBox3.Text + "', '" + ItemPriceTxtBox4.Text + "', '" + ItemPriceTxtBox5.Text + "', '" + ItemPriceTxtBox6.Text + "', '" + ItemPriceTxtBox7.Text + "', '" + ItemPriceTxtBox8.Text + "', '" + ItemPriceTxtBox9.Text + "', '" + ItemPriceTxtBox10.Text + "', '" + ItemPriceTxtBox11.Text + "', '" + ItemPriceTxtBox12.Text + "', '" + ItemPriceTxtBox13.Text + "', '" + ItemPriceTxtBox14.Text + "', '" + ItemPriceTxtBox15.Text + "', '" + ItemPriceTxtBox16.Text + "', '" + ItemPriceTxtBox17.Text + "', '" + ItemPriceTxtBox18.Text + "', '" + ItemPriceTxtBox19.Text + "', '" + ItemPriceTxtBox20.Text + "')";
            dclass.cmd();
            sqladapterinsert();

            dclass.sql = "INSERT INTO PicPathTbl (POS_ID, Item1Pic, Item2Pic, Item3Pic, Item4Pic, Item5Pic, Item6Pic, Item7Pic, Item8Pic, Item9Pic, Item10Pic, Item11Pic, Item12Pic, Item13Pic, Item14Pic, Item15Pic, Item16Pic, Item17Pic, Item18Pic, Item19Pic, Item20Pic) VALUES ('" + IDTxtBox.Text + "', '" + PicPathTxtBox1.Text + "', '" + PicPathTxtBox2.Text + "', '" + PicPathTxtBox3.Text + "', '" + PicPathTxtBox4.Text + "', '" + PicPathTxtBox5.Text + "', '" + PicPathTxtBox6.Text + "', '" + PicPathTxtBox7.Text + "', '" + PicPathTxtBox8.Text + "', '" + PicPathTxtBox9.Text + "', '" + PicPathTxtBox10.Text + "', '" + PicPathTxtBox11.Text + "', '" + PicPathTxtBox12.Text + "', '" + PicPathTxtBox13.Text + "', '" + PicPathTxtBox14.Text + "', '" + PicPathTxtBox15.Text + "', '" + PicPathTxtBox16.Text + "', '" + PicPathTxtBox17.Text + "', '" + PicPathTxtBox18.Text + "', '" + PicPathTxtBox19.Text + "', '" + PicPathTxtBox20.Text + "')";
            dclass.cmd();
            sqladapterinsert();

            sqlselect();
            dclass.cmd();
            dclass.sqladapter();
            dclass.sqldatasetPOS();
            dataGridView1.DataSource = dclass.dsetPOS.Tables[0];
            cleartxtboxes();

            dclass.connection.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            dclass.connString();
            //Selects data to be displayed//
            dclass.sql = "SELECT * FROM ItemNameTbl INNER JOIN PriceTbl ON ItemNameTbl.POS_ID=PriceTbl.POS_ID INNER JOIN PicPathTbl ON ItemNameTbl.POS_ID=PicPathTbl.POS_ID WHERE ItemNameTbl.POS_ID='" + IDTxtBox.Text +"'";

            dclass.cmd();
            dclass.sqladapter();
            dclass.sqldatasetPOS(); //Puts selected data in a dataset//

            //Calls the dataset to display data//
            ItemNameTxtBox1.Text = dclass.dsetPOS.Tables[0].Rows[0][1].ToString();
            ItemNameTxtBox2.Text = dclass.dsetPOS.Tables[0].Rows[0][2].ToString();
            ItemNameTxtBox3.Text = dclass.dsetPOS.Tables[0].Rows[0][3].ToString();
            ItemNameTxtBox4.Text = dclass.dsetPOS.Tables[0].Rows[0][4].ToString();
            ItemNameTxtBox5.Text = dclass.dsetPOS.Tables[0].Rows[0][5].ToString();
            ItemNameTxtBox6.Text = dclass.dsetPOS.Tables[0].Rows[0][6].ToString();
            ItemNameTxtBox7.Text = dclass.dsetPOS.Tables[0].Rows[0][7].ToString();
            ItemNameTxtBox8.Text = dclass.dsetPOS.Tables[0].Rows[0][8].ToString();
            ItemNameTxtBox9.Text = dclass.dsetPOS.Tables[0].Rows[0][9].ToString();
            ItemNameTxtBox10.Text = dclass.dsetPOS.Tables[0].Rows[0][10].ToString();
            ItemNameTxtBox11.Text = dclass.dsetPOS.Tables[0].Rows[0][11].ToString();
            ItemNameTxtBox12.Text = dclass.dsetPOS.Tables[0].Rows[0][12].ToString();
            ItemNameTxtBox13.Text = dclass.dsetPOS.Tables[0].Rows[0][13].ToString();
            ItemNameTxtBox14.Text = dclass.dsetPOS.Tables[0].Rows[0][14].ToString();
            ItemNameTxtBox15.Text = dclass.dsetPOS.Tables[0].Rows[0][15].ToString();
            ItemNameTxtBox16.Text = dclass.dsetPOS.Tables[0].Rows[0][16].ToString();
            ItemNameTxtBox17.Text = dclass.dsetPOS.Tables[0].Rows[0][17].ToString();
            ItemNameTxtBox18.Text = dclass.dsetPOS.Tables[0].Rows[0][18].ToString();
            ItemNameTxtBox19.Text = dclass.dsetPOS.Tables[0].Rows[0][19].ToString();
            ItemNameTxtBox20.Text = dclass.dsetPOS.Tables[0].Rows[0][20].ToString();

            ItemPriceTxtBox1.Text = dclass.dsetPOS.Tables[0].Rows[0][22].ToString();
            ItemPriceTxtBox2.Text = dclass.dsetPOS.Tables[0].Rows[0][23].ToString();
            ItemPriceTxtBox3.Text = dclass.dsetPOS.Tables[0].Rows[0][24].ToString();
            ItemPriceTxtBox4.Text = dclass.dsetPOS.Tables[0].Rows[0][25].ToString();
            ItemPriceTxtBox5.Text = dclass.dsetPOS.Tables[0].Rows[0][26].ToString();
            ItemPriceTxtBox6.Text = dclass.dsetPOS.Tables[0].Rows[0][27].ToString();
            ItemPriceTxtBox7.Text = dclass.dsetPOS.Tables[0].Rows[0][28].ToString();
            ItemPriceTxtBox8.Text = dclass.dsetPOS.Tables[0].Rows[0][29].ToString();
            ItemPriceTxtBox9.Text = dclass.dsetPOS.Tables[0].Rows[0][30].ToString();
            ItemPriceTxtBox10.Text = dclass.dsetPOS.Tables[0].Rows[0][31].ToString();
            ItemPriceTxtBox11.Text = dclass.dsetPOS.Tables[0].Rows[0][32].ToString();
            ItemPriceTxtBox12.Text = dclass.dsetPOS.Tables[0].Rows[0][33].ToString();
            ItemPriceTxtBox13.Text = dclass.dsetPOS.Tables[0].Rows[0][34].ToString();
            ItemPriceTxtBox14.Text = dclass.dsetPOS.Tables[0].Rows[0][35].ToString();
            ItemPriceTxtBox15.Text = dclass.dsetPOS.Tables[0].Rows[0][36].ToString();
            ItemPriceTxtBox16.Text = dclass.dsetPOS.Tables[0].Rows[0][37].ToString();
            ItemPriceTxtBox17.Text = dclass.dsetPOS.Tables[0].Rows[0][38].ToString();
            ItemPriceTxtBox18.Text = dclass.dsetPOS.Tables[0].Rows[0][39].ToString();
            ItemPriceTxtBox19.Text = dclass.dsetPOS.Tables[0].Rows[0][40].ToString();
            ItemPriceTxtBox20.Text = dclass.dsetPOS.Tables[0].Rows[0][41].ToString();          

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

        private void DonutPic1_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox1, DonutPic1);
        }

        private void DonutPic2_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox2, DonutPic2);
        }

        private void DonutPic3_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox3, DonutPic3);
        }

        private void DonutPic4_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox4, DonutPic4);
        }

        private void DonutPic5_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox5, DonutPic5);
        }

        private void DonutPic6_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox6, DonutPic6);
        }

        private void DonutPic7_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox7, DonutPic7);
        }

        private void DonutPic8_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox8, DonutPic8);
        }

        private void DonutPic9_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox9, DonutPic9);
        }

        private void DonutPic10_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox10, DonutPic10);
        }

        private void DonutPic11_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox11, DonutPic11);
        }

        private void DonutPic12_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox12, DonutPic12);
        }

        private void DonutPic13_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox13, DonutPic13);
        }

        private void DonutPic14_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox14, DonutPic14);
        }

        private void DonutPic15_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox15, DonutPic15);
        }

        private void DonutPic16_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox16, DonutPic16);
        }

        private void DonutPic17_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox17, DonutPic17);
        }

        private void DonutPic18_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox18, DonutPic18);
        }

        private void DonutPic19_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox19, DonutPic19);
        }

        private void DonutPic20_Click(object sender, EventArgs e)
        {
            fileDialog(PicPathTxtBox20, DonutPic20);
        }

        private void IDTxtBox_Leave(object sender, EventArgs e)
        {
            ID = IDTxtBox.Text;
        }
    }
}
