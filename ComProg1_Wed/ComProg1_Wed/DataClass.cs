using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ComProg1_Wed
{
    class DataClass
    {
        public String connectionString = null;
        public SqlConnection connection;
        public SqlCommand command;
        public DataSet dset, dsetPayroll, dsetPOS;
        public SqlDataAdapter adaptersql;
        public string sql = null;

        public void connString()
        {
            //Database Connection//
            connection = new SqlConnection();
            connectionString = "Data Source = CL3_8; Initial Catalog = COMPROG1Db; user id = sa; password = adamson;";
            connection = new SqlConnection(connectionString);

            connection.ConnectionString = connectionString;
            connection.Open();
        }

        public void cmd()
        {
            //Translates the SQL Query//
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
        }

        public void sqladapter()
        {
            //Performs SQL select command//
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();
        }

        public void sqldataset()
        {
            //Displays database data in DataGridView//
            dset = new DataSet();
            adaptersql.Fill(dset, "EmployeeRegistrationTbl");            
        }

        public void sqldatasetPayroll()
        {
            //Displays database data in DataGridView//
            dsetPayroll = new DataSet();
            adaptersql.Fill(dsetPayroll, "EmployeeRegistrationTbl");  
            adaptersql.Fill(dsetPayroll, "PayrollTbl");
        }

        public void sqldatasetPOS()
        {
            //Displays database data in DataGridView//
            dsetPOS = new DataSet();
            adaptersql.Fill(dsetPOS, "ItemNameTbl");
            adaptersql.Fill(dsetPOS, "PriceTbl");
            adaptersql.Fill(dsetPOS, "PicPathTbl");
        }
    }
}
