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
    public partial class SampleLang : Form
    {
        String picpath, connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;

        public SampleLang()
        {
            connectionString = "Data Source = CL3_8; Initial Catalog = COMPROG1Db; user id = sa; password = adamson;";
            connection = new SqlConnection(connectionString);

            InitializeComponent();
        }

        private void SampleLang_Load(object sender, EventArgs e)
        {
            picpathtxtbox.Hide();

            connection.Open();

            sql = "SELECT * from studenttbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studenttbl");
            griddisplay.DataSource = dset.Tables[0];

            connection.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "INSERT INTO studenttbl (student_no, name, department, picpath) VALUES ('" + studnumtxtbox.Text + "', '" + studnametxtbox.Text + "', '" + deptxtbox.Text + "', '" + picpathtxtbox.Text + "')";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * from studenttbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studenttbl");
            griddisplay.DataSource = dset.Tables[0];

            picpathtxtbox.Clear();
            studnumtxtbox.Clear();
            studnametxtbox.Clear();
            deptxtbox.Clear();

            connection.Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "SELECT * from studenttbl WHERE student_no = '" + studnumtxtbox.Text + "'";

            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studenttbl");
            griddisplay.DataSource = dset.Tables[0];

            studnumtxtbox.Text = dset.Tables[0].Rows[0][0].ToString();
            studnametxtbox.Text = dset.Tables[0].Rows[0][1].ToString();
            deptxtbox.Text = dset.Tables[0].Rows[0][2].ToString();
            picpathtxtbox.Text = dset.Tables[0].Rows[0][3].ToString();
            pictureBox1.Image = Image.FromFile(picpathtxtbox.Text);

            connection.Close();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "UPDATE studenttbl SET name = '" + studnametxtbox.Text + "', department = '" + deptxtbox.Text + "', picpath = '" + picpathtxtbox.Text + "' WHERE student_no = '" + studnumtxtbox.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * from studenttbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studenttbl");
            griddisplay.DataSource = dset.Tables[0];

            picpathtxtbox.Clear();
            studnumtxtbox.Clear();
            studnametxtbox.Clear();
            deptxtbox.Clear();

            connection.Close();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "DELETE FROM studenttbl WHERE student_no = '" + studnumtxtbox.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * from studenttbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studenttbl");
            griddisplay.DataSource = dset.Tables[0];

            picpathtxtbox.Clear();
            studnumtxtbox.Clear();
            studnametxtbox.Clear();
            deptxtbox.Clear();

            connection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpathtxtbox.Text = picpath;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            picpathtxtbox.Clear();
            studnumtxtbox.Clear();
            studnametxtbox.Clear();
            deptxtbox.Clear();
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            picpathtxtbox.Clear();
            studnumtxtbox.Clear();
            studnametxtbox.Clear();
            deptxtbox.Clear();
        }
    }
}
