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
    public partial class EmployeeReg : Form
    {
        DataClass dclass = new DataClass();

        public EmployeeReg()
        {
            //Database Connection//
            dclass.connString();

            InitializeComponent();
        }

        private void cleartxtboxes()
        {
            //Clear all objects//
            EmpNumTxtBox.Clear();
            FNameTxtBox.Clear();
            MNameTxtBox.Clear();
            SNameTxtBox.Clear();
            NumOfDepTxtBox.Clear();
            AgeCmbBox.Text = "";
            GenderCmbBox.Text = "";
            SSSTxtBox.Clear();
            TINTxtBox.Clear();
            PhilHealthTxtBox.Clear();
            PagibigTxtBox.Clear();
            StatusCmbBox.Text = "";
            HeightTxtBox.Clear();
            WeightTxtBox.Clear();
            YearsTxtBox.Clear();
            HouseNumTxtBox.Clear();
            SubdiviTxtBox.Clear();
            PhaseTxtBox.Clear();
            StreetTxtBox.Clear();
            BarangayTxtBox.Clear();
            MuniTxtBox.Clear();
            CityTxtBox.Clear();
            CountryTxtBox.Clear();
            StateTxtBox.Clear();
            ZipTxtBox.Clear();
            PermYearsTxtBox.Clear();
            PermHouseNumTxtBox.Clear();
            PermSubdiviTxtBox.Clear();
            PermPhaseTxtBox.Clear();
            PermStreetTxtBox.Clear();
            PermBarangayTxtBox.Clear();
            PermMuniTxtBox.Clear();
            PermCityTxtBox.Clear();
            PermCountryTxtBox.Clear();
            PermStateTxtBox.Clear();
            PermZipTxtBox.Clear();
            TeleTxtBox.Clear();
            Cell1TxtBox.Clear();
            Cell2TxtBox.Clear();
            EmailTxtBox.Clear();
            ContactPerTxtBox.Clear();
            ContactNumTxtBox.Clear();
            ContactAddTxtBox.Clear();
            ElemSchoolTxtBox.Clear();
            ElemAddTxtBox.Clear();
            ElemGradYearDateTime.Value = DateTime.Now;
            ElemAwardTxtBox.Clear();
            SecondSchoolTxtBox.Clear();
            SecondAddTxtBox.Clear();
            SecondGradYearDateTime.Value = DateTime.Now;
            SecondAwardTxtBox.Clear();
            TertSchoolTxtBox.Clear();
            TertAddTxtBox.Clear();
            TertCourseTxtBox.Clear();
            TertGradYearDateTime.Value = DateTime.Now;
            TertAwardTxtBox.Clear();
            GradSchoolTxtBox.Clear();
            GradAddTxtBox.Clear();
            GradDegTxtBox.Clear();
            GradGradYearDateTime.Value = DateTime.Now;
            GradAwardTxtBox.Clear();
            OthersTxtBox.Clear();
            PosTxtBox.Clear();
            DependTxtBox.Clear();
            HireDateTime.Value = DateTime.Now;
            DeptTxtBox.Clear();
            EmpPicBox.Image = null;
        }

        private void sqlselect()
        {
            //Select command//
            dclass.sql = "SELECT * FROM EmployeeRegistrationTbl";
        }        
        

        private void sqladapterinsert()
        {
            //Performs SQL insert command//
            dclass.adaptersql = new SqlDataAdapter();
            dclass.adaptersql.InsertCommand = dclass.command;
            dclass.command.ExecuteNonQuery();
        }
        private void EmployeeReg_Load(object sender, EventArgs e)
        {
            PicPathTxtBox.Hide(); //Hides PicPathTxtBox//
            //Connects DataGridView to database on form load//
            dclass.connString();

            sqlselect();
            dclass.cmd();
            dclass.sqladapter();
            dclass.sqldataset();
            EmpDataGrid.DataSource = dclass.dset.Tables[0];

            dclass.connection.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            dclass.connString();
            //SQL Query for adding data//
            dclass.sql = "INSERT INTO EmployeeRegistrationTbl (emp_id, fname, mname, surname, num_of_dependents, age, gender, SSS_NO, TIN_NO, PhilHealth_NO, PAGIBIG_NO, status, height, weight, current_yrs, current_house_no, current_sub_no, current_phase_no, current_street, current_barangay, current_municipality, current_city, current_country, current_province, current_Zipcode, permanent_yrs, permanent_house_no, permanent_sub_no, permanent_phase_no, permanent_street, permanent_barangay, permanent_municipality, permanent_city, permanent_country, permanent_province, permanent_Zipcode, elem_name, elem_address, elem_yr_grad, elem_award, sec_name, sec_address, sec_yr_grad, sec_award, ter_name, ter_address, ter_course, ter_yr_grad, ter_award, grad_name, grad_address, grad_degree, grad_yr_grad, grad_award, others, position, dependent, date_hired, department, picpath) VALUES ('" + EmpNumTxtBox.Text + "', '" + FNameTxtBox.Text + "', '" + MNameTxtBox.Text + "', '" + SNameTxtBox.Text + "', '" + NumOfDepTxtBox.Text + "', '" + AgeCmbBox.Text + "', '" + GenderCmbBox.Text + "', '" + SSSTxtBox.Text + "', '" + TINTxtBox.Text + "', '" + PhilHealthTxtBox.Text + "', '" + PagibigTxtBox.Text + "', '" + StatusCmbBox.Text + "', '" + HeightTxtBox.Text + "', '" + WeightTxtBox.Text + "', '" + YearsTxtBox.Text + "', '" + HouseNumTxtBox.Text + "', '" + SubdiviTxtBox.Text + "', '" + PhaseTxtBox.Text + "', '" + StreetTxtBox.Text + "', '" + BarangayTxtBox.Text + "', '" + MuniTxtBox.Text + "', '" + CityTxtBox.Text + "', '" + CountryTxtBox.Text + "', '" + StateTxtBox.Text + "', '" + ZipTxtBox.Text + "', '" + PermYearsTxtBox.Text + "', '" + PermHouseNumTxtBox.Text + "', '" + PermSubdiviTxtBox.Text + "', '" + PermPhaseTxtBox.Text + "', '" + PermStreetTxtBox.Text + "', '" + PermBarangayTxtBox.Text + "', '" + PermMuniTxtBox.Text + "', '" + PermCityTxtBox.Text + "', '" + PermCountryTxtBox.Text + "', '" + PermStateTxtBox.Text + "', '" + PermZipTxtBox.Text + "', '" + ElemSchoolTxtBox.Text + "', '" + ElemAddTxtBox.Text + "', '" + ElemGradYearDateTime.Text + "', '" + ElemAwardTxtBox.Text + "', '" + SecondSchoolTxtBox.Text + "', '" + SecondAddTxtBox.Text + "', '" + SecondGradYearDateTime.Text + "', '" + SecondAwardTxtBox.Text + "', '" + TertSchoolTxtBox.Text + "', '" + TertAddTxtBox.Text + "', '" + TertCourseTxtBox.Text + "', '" + TertGradYearDateTime.Text + "', '" + TertAwardTxtBox.Text + "', '" + GradSchoolTxtBox.Text + "', '" + GradAddTxtBox.Text + "', '" + GradDegTxtBox.Text + "', '" + GradGradYearDateTime.Text + "', '" + GradAwardTxtBox.Text + "', '" + OthersTxtBox.Text + "', '" + PosTxtBox.Text + "', '" + DependTxtBox.Text + "', '" + HireDateTime.Text + "', '" + DeptTxtBox.Text + "', '" + PicPathTxtBox.Text + "')";

            dclass.cmd();
            sqladapterinsert();
            sqlselect();
            dclass.cmd();
            dclass.sqladapter();
            dclass.sqldataset();
            EmpDataGrid.DataSource = dclass.dset.Tables[0];
            cleartxtboxes();

            dclass.connection.Close();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            cleartxtboxes(); //Calls the function to clear textboxes//
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            cleartxtboxes(); //Calls the function to clear textboxes//
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes the current form//
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            dclass.connString();
            //SQL Query for removing a row of data//
            dclass.sql = "DELETE FROM EmployeeRegistrationTbl WHERE emp_id ='" + EmpNumTxtBox.Text + "'";

            dclass.cmd();
            dclass.sqladapter();
            sqlselect();
            dclass.cmd();
            dclass.sqladapter();
            dclass.sqldataset();
            EmpDataGrid.DataSource = dclass.dset.Tables[0];
            cleartxtboxes();

            dclass.connection.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            dclass.connString();
            //SQL Query for editing data in the database//
            dclass.sql = "UPDATE EmployeeRegistrationTbl SET fname = '" + FNameTxtBox.Text + "', mname = '" + MNameTxtBox.Text + "', surname = '" + SNameTxtBox.Text + "', num_of_dependents = '" + NumOfDepTxtBox.Text + "', age = '" + AgeCmbBox.Text + "', gender = '" + GenderCmbBox.Text + "', SSS_NO = '" + SSSTxtBox.Text + "', TIN_NO = '" + TINTxtBox.Text + "', PhilHealth_NO = '" + PhilHealthTxtBox.Text + "', PAGIBIG_NO = '" + PagibigTxtBox.Text + "', status = '" + StatusCmbBox.Text + "', height = '" + HeightTxtBox.Text + "', weight = '" + WeightTxtBox.Text + "', current_yrs = '" + YearsTxtBox.Text + "', current_house_no = '" + HouseNumTxtBox.Text + "', current_sub_no = '" + SubdiviTxtBox.Text + "', current_phase_no = '" + PhaseTxtBox.Text + "', current_street = '" + StreetTxtBox.Text + "', current_barangay = '" + BarangayTxtBox.Text + "', current_municipality = '" + MuniTxtBox.Text + "', current_city = '" + CityTxtBox.Text + "', current_country = '" + CountryTxtBox.Text + "', current_province = '" + StateTxtBox.Text + "', current_Zipcode = '" + ZipTxtBox.Text + "', permanent_yrs = '" + PermYearsTxtBox.Text + "', permanent_house_no = '" + PermHouseNumTxtBox.Text + "', permanent_sub_no = '" + PermSubdiviTxtBox.Text + "', permanent_phase_no = '" + PermPhaseTxtBox.Text + "', permanent_street = '" + PermStreetTxtBox.Text + "', permanent_barangay = '" + PermBarangayTxtBox.Text + "', permanent_municipality = '" + PermMuniTxtBox.Text + "', permanent_city = '" + PermCityTxtBox.Text + "', permanent_country = '" + PermCountryTxtBox.Text + "', permanent_province = '" + PermStateTxtBox.Text + "', permanent_Zipcode = '" + PermZipTxtBox.Text + "', elem_name = '" + ElemSchoolTxtBox.Text + "', elem_address = '" + ElemAddTxtBox.Text + "', elem_yr_grad = '" + ElemGradYearDateTime.Text + "', elem_award = '" + ElemAwardTxtBox.Text + "', sec_name = '" + SecondSchoolTxtBox.Text + "', sec_address = '" + SecondAddTxtBox.Text + "', sec_yr_grad = '" + SecondGradYearDateTime.Text + "', sec_award = '" + SecondAwardTxtBox.Text + "', ter_name = '" + TertSchoolTxtBox.Text + "', ter_address = '" + TertAddTxtBox.Text + "', ter_course = '" + TertCourseTxtBox.Text + "', ter_yr_grad = '" + TertGradYearDateTime.Text + "', ter_award = '" + TertAwardTxtBox.Text + "', grad_name = '" + GradSchoolTxtBox.Text + "', grad_address = '" + GradAddTxtBox.Text + "', grad_degree = '" + GradDegTxtBox.Text + "', grad_yr_grad = '" + GradGradYearDateTime.Text + "', grad_award = '" + GradAwardTxtBox.Text + "', others = '" + OthersTxtBox.Text + "', position = '" + PosTxtBox.Text + "', dependent = '" + DependTxtBox.Text + "', date_hired = '" + HireDateTime.Text + "', department = '" + DeptTxtBox.Text + "', picpath = '" + PicPathTxtBox.Text + "' WHERE emp_id = '" + EmpNumTxtBox.Text + "'";

            dclass.cmd();
            dclass.sqladapter();
            sqlselect();
            dclass.cmd();
            dclass.sqladapter();
            dclass.sqldataset();
            EmpDataGrid.DataSource = dclass.dset.Tables[0];
            cleartxtboxes();

            dclass.connection.Close();
        }
        
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            dclass.connString();
            //Selects data to be displayed//
            dclass.sql = "SELECT * FROM EmployeeRegistrationTbl WHERE emp_id = '" + EmpNumTxtBox.Text + "'";

            dclass.cmd();
            dclass.sqladapter();
            dclass.sqldataset(); //Puts selected data in a dataset//

            //Calls the dataset to display data//
            FNameTxtBox.Text = dclass.dset.Tables[0].Rows[0][1].ToString();
            MNameTxtBox.Text = dclass.dset.Tables[0].Rows[0][2].ToString();
            SNameTxtBox.Text = dclass.dset.Tables[0].Rows[0][3].ToString();
            NumOfDepTxtBox.Text = dclass.dset.Tables[0].Rows[0][4].ToString();
            AgeCmbBox.Text = dclass.dset.Tables[0].Rows[0][5].ToString(); ;
            GenderCmbBox.Text = dclass.dset.Tables[0].Rows[0][6].ToString();
            SSSTxtBox.Text = dclass.dset.Tables[0].Rows[0][7].ToString();
            TINTxtBox.Text = dclass.dset.Tables[0].Rows[0][8].ToString();
            PhilHealthTxtBox.Text = dclass.dset.Tables[0].Rows[0][9].ToString();
            PagibigTxtBox.Text = dclass.dset.Tables[0].Rows[0][10].ToString();
            StatusCmbBox.Text = dclass.dset.Tables[0].Rows[0][11].ToString();
            HeightTxtBox.Text = dclass.dset.Tables[0].Rows[0][12].ToString();
            WeightTxtBox.Text = dclass.dset.Tables[0].Rows[0][13].ToString();
            YearsTxtBox.Text = dclass.dset.Tables[0].Rows[0][14].ToString();
            HouseNumTxtBox.Text = dclass.dset.Tables[0].Rows[0][15].ToString();
            SubdiviTxtBox.Text = dclass.dset.Tables[0].Rows[0][16].ToString();
            PhaseTxtBox.Text = dclass.dset.Tables[0].Rows[0][17].ToString();
            StreetTxtBox.Text = dclass.dset.Tables[0].Rows[0][18].ToString();
            BarangayTxtBox.Text = dclass.dset.Tables[0].Rows[0][19].ToString();
            MuniTxtBox.Text = dclass.dset.Tables[0].Rows[0][20].ToString();
            CityTxtBox.Text = dclass.dset.Tables[0].Rows[0][21].ToString();
            CountryTxtBox.Text = dclass.dset.Tables[0].Rows[0][22].ToString();
            StateTxtBox.Text = dclass.dset.Tables[0].Rows[0][23].ToString();
            ZipTxtBox.Text = dclass.dset.Tables[0].Rows[0][24].ToString();
            PermYearsTxtBox.Text = dclass.dset.Tables[0].Rows[0][25].ToString();
            PermHouseNumTxtBox.Text = dclass.dset.Tables[0].Rows[0][26].ToString();
            PermSubdiviTxtBox.Text = dclass.dset.Tables[0].Rows[0][27].ToString();
            PermPhaseTxtBox.Text = dclass.dset.Tables[0].Rows[0][28].ToString();
            PermStreetTxtBox.Text = dclass.dset.Tables[0].Rows[0][29].ToString();
            PermBarangayTxtBox.Text = dclass.dset.Tables[0].Rows[0][30].ToString();
            PermMuniTxtBox.Text = dclass.dset.Tables[0].Rows[0][31].ToString();
            PermCityTxtBox.Text = dclass.dset.Tables[0].Rows[0][32].ToString();
            PermCountryTxtBox.Text = dclass.dset.Tables[0].Rows[0][33].ToString();
            PermStateTxtBox.Text = dclass.dset.Tables[0].Rows[0][34].ToString();
            PermZipTxtBox.Text = dclass.dset.Tables[0].Rows[0][35].ToString();
            ElemSchoolTxtBox.Text = dclass.dset.Tables[0].Rows[0][36].ToString();
            ElemAddTxtBox.Text = dclass.dset.Tables[0].Rows[0][37].ToString();
            ElemGradYearDateTime.Text = dclass.dset.Tables[0].Rows[0][38].ToString();
            ElemAwardTxtBox.Text = dclass.dset.Tables[0].Rows[0][39].ToString();
            SecondSchoolTxtBox.Text = dclass.dset.Tables[0].Rows[0][40].ToString();
            SecondAddTxtBox.Text = dclass.dset.Tables[0].Rows[0][41].ToString();
            SecondGradYearDateTime.Text = dclass.dset.Tables[0].Rows[0][42].ToString();
            SecondAwardTxtBox.Text = dclass.dset.Tables[0].Rows[0][43].ToString();
            TertSchoolTxtBox.Text = dclass.dset.Tables[0].Rows[0][44].ToString();
            TertAddTxtBox.Text = dclass.dset.Tables[0].Rows[0][45].ToString();
            TertCourseTxtBox.Text = dclass.dset.Tables[0].Rows[0][46].ToString();
            TertGradYearDateTime.Text = dclass.dset.Tables[0].Rows[0][47].ToString();
            TertAwardTxtBox.Text = dclass.dset.Tables[0].Rows[0][48].ToString();
            GradSchoolTxtBox.Text = dclass.dset.Tables[0].Rows[0][49].ToString();
            GradAddTxtBox.Text = dclass.dset.Tables[0].Rows[0][50].ToString();
            GradDegTxtBox.Text = dclass.dset.Tables[0].Rows[0][51].ToString();
            GradGradYearDateTime.Text = dclass.dset.Tables[0].Rows[0][52].ToString();
            GradAwardTxtBox.Text = dclass.dset.Tables[0].Rows[0][53].ToString();
            OthersTxtBox.Text = dclass.dset.Tables[0].Rows[0][54].ToString();
            PosTxtBox.Text = dclass.dset.Tables[0].Rows[0][55].ToString();
            DependTxtBox.Text = dclass.dset.Tables[0].Rows[0][56].ToString();
            HireDateTime.Text = dclass.dset.Tables[0].Rows[0][57].ToString();
            DeptTxtBox.Text = dclass.dset.Tables[0].Rows[0][58].ToString();
            PicPathTxtBox.Text = dclass.dset.Tables[0].Rows[0][59].ToString();
            try
            {
                EmpPicBox.Image = Image.FromFile(PicPathTxtBox.Text);
            }
            catch 
            {
 
            }

            dclass.connection.Close();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            //Sets the file dialog to only accept image files//
            openFileDialog1.Filter = "Image Files(*.JPEG;*.JPG;*.PNG;*.IMG)|*.JPEG;*.JPG;*.PNG;*.IMG|All files (*.*)|*.*";

            //Opens File Dialog for picture selection
            DialogResult result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK) //If FileDialog returns OK, displays picture and puts the filepath in a temporary textbox//
            {
                string file = openFileDialog1.FileName;

                PicPathTxtBox.Text = file;
                EmpPicBox.Image = Image.FromFile(PicPathTxtBox.Text);
            }
        }
    }
}
