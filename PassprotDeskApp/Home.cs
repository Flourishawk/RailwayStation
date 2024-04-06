using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Windows.Forms;

namespace PassprotDeskApp
{
    public partial class Home : Form
    {
        Boolean security;
        public Home()
        {
            InitializeComponent();
        }
        public Home(Boolean flag)
        {
            InitializeComponent();
            security = flag;
            if (security == false)
            {
                //simpleButton3.Visible = true;
                //simpleButton4.Visible = true;
                //simpleButton9.Visible = true;
                //simpleButton11.Visible = true;
                //simpleButton12.Visible = true;
                //simpleButton13.Visible = true;

                //insert_registration.Visible = true;
                //simpleButton17.Visible = true;
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //--------------------------------------------------------Select international passport PASSPORT---------------------------------------------------------------------

        //private void simpleButton2_Click(object sender, EventArgs e)
        //{

        //    dataGridView1.Rows.Clear();
        //    string query = "SELECT * FROM international_passport WHERE ";
        //    string query_set = "";
        //    Boolean flag = false;

        //    if (textEdit1.Text != "" || textEdit2.Text != "" || textEdit3.Text != "" || textEdit4.Text != "" || textEdit5.Text != "" || textEdit6.Text != "")
        //    {
        //        if (textEdit1.Text != "")
        //        {
        //            query_set = "SET @id_international_passport =\"" + textEdit1.Text.Replace(" ", "") + "\"";
        //            query += ("id_international_passport=@id_international_passport ");
        //            flag = true;
        //        }

        //        if (textEdit2.Text != "" && flag == false)
        //        {
        //            query_set = "SET @issue_date =\"" + textEdit2.Text.Replace(" ", "") + "\"";
        //            query += ("issue_date=@issue_date ");
        //            flag = true;
        //        }
        //        else if (textEdit2.Text != "" && flag == true)
        //        {
        //            query_set += ", @issue_date =\"" + textEdit2.Text.Replace(" ", "") + "\"";
        //            query += ("AND issue_date=@issue_date ");
        //        }

        //        if (textEdit3.Text != "" && flag == false)
        //        {
        //            query_set = "SET @expiry_date =\"" + textEdit3.Text.Replace(" ", "") + "\"";
        //            query += ("expiry_date=@expiry_date ");
        //            flag = true;
        //        }
        //        else if (textEdit3.Text != "" && flag == true)
        //        {
        //            query_set += ", @expiry_date =\"" + textEdit3.Text.Replace(" ", "") + "\"";
        //            query += ("AND expiry_date=@expiry_date ");
        //        }

        //        if (textEdit4.Text != "" && flag == false)
        //        {
        //            query_set = "SET @type_international_passport =\"" + textEdit4.Text.Replace(" ", "") + "\"";
        //            query += ("type_international_passport = @type_international_passport ");
        //            flag = true;
        //        }
        //        else if (textEdit4.Text != "" && flag == true)
        //        {
        //            query_set += ", @type_international_passport =\"" + textEdit4.Text.Replace(" ", "") + "\"";
        //            query += ("AND type_international_passport = @type_international_passport ");
        //        }

        //        if (textEdit5.Text != "" && flag == false)
        //        {
        //            query_set = "SET @country_code =\"" + textEdit5.Text.Replace(" ", "") + "\"";
        //            query += ("country_code=@country_code ");
        //            flag = true;
        //        }
        //        else if (textEdit5.Text != "" && flag == true)
        //        {
        //            query_set += ", @country_code =\"" + textEdit5.Text.Replace(" ", "") + "\"";
        //            query += ("AND country_code=@country_code ");
        //        }

        //        if (textEdit6.Text != "" && flag == false)
        //        {
        //            query_set = "SET @verifed_by_tax_service =\"" + textEdit6.Text.Replace(" ", "") + "\"";
        //            query += ("verifed_by_tax_service=@verifed_by_tax_service ");
        //            flag = true;
        //        }
        //        else if (textEdit6.Text != "" && flag == true)
        //        {
        //            query_set += ", @verifed_by_tax_service =\"" + textEdit6.Text.Replace(" ", "") + "\"";
        //            query += ("AND verifed_by_tax_service=@verifed_by_tax_service ");
        //        }

        //        if (textEdit19.Text != "" && flag == false)
        //        {
        //            query_set = "SET @fk_passport =\"" + textEdit19.Text.Replace(" ", "") + "\"";
        //            query += ("fk_passport=@fk_passport ");
        //            flag = true;
        //        }
        //        else if (textEdit19.Text != "" && flag == true)
        //        {
        //            query_set += ", @fk_passport =\"" + textEdit19.Text.Replace(" ", "") + "\"";
        //            query += ("AND fk_passport=@fk_passport ");
        //        }

        //        query_set += ";";
        //        query += ";";
        //        try
        //        {

        //            using (OdbcConnection DbConnection = new OdbcConnection("DSN=passport_desk"))
        //            {

        //                DbConnection.Open();
        //                OdbcCommand DbCommand = DbConnection.CreateCommand();
        //                DbCommand.CommandText = query;
        //                OdbcCommand DbCommand2 = DbConnection.CreateCommand();
        //                DbCommand2.CommandText = query_set;
        //                DbCommand2.ExecuteNonQuery();
        //                OdbcDataReader DbReader = DbCommand.ExecuteReader();
        //                List<string[]> data = new List<string[]>();
        //                DateTime date;
        //                while (DbReader.Read())
        //                {
        //                    data.Add(new string[7]);

        //                    data[data.Count - 1][0] = DbReader[0].ToString();
        //                    date = (DateTime)DbReader[1];
        //                    data[data.Count - 1][1] = date.ToString("yyyy.MM.dd");
        //                    date = (DateTime)DbReader[2];
        //                    data[data.Count - 1][2] = date.ToString("yyyy.MM.dd");
        //                    data[data.Count - 1][3] = DbReader[3].ToString();
        //                    data[data.Count - 1][4] = DbReader[4].ToString();
        //                    data[data.Count - 1][5] = DbReader[5].ToString();
        //                    data[data.Count - 1][6] = DbReader[6].ToString();
        //                }

        //                foreach (string[] s in data)
        //                {
        //                    dataGridView1.Rows.Add(s);
        //                }
        //                DbReader.Close();
        //            }
        //            flag = false;
        //            query = "";
        //            query_set = "";
        //        }
        //        catch (OdbcException exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    return;
        //}

        ////--------------------------------------------------------Select Passsport---------------------------------------------------------------------

        //private void simpleButton5_Click(object sender, EventArgs e)
        //{
        //    dataGridView2.Rows.Clear();
        //    string query = "SELECT * FROM passport WHERE ";
        //    string query_set = "";
        //    Boolean flag = false;

        //    if (textEdit7.Text != "" || textEdit8.Text != "" || textEdit9.Text != "" || textEdit10.Text != "" || textEdit11.Text != "" || textEdit12.Text != ""
        //        || textEdit13.Text != "" || textEdit14.Text != "" || textEdit15.Text != "" || textEdit16.Text != "" || textEdit17.Text != "" || textEdit18.Text != "")
        //    {
        //        if (textEdit7.Text != "")
        //        {
        //            query_set = "SET @id_passport =\"" + textEdit7.Text.Replace(" ", "") + "\"";
        //            query += ("id_passport=@id_passport ");
        //            flag = true;
        //        }

        //        if (textEdit9.Text != "" && flag == false)
        //        {
        //            query_set = "SET @surname =\"" + textEdit9.Text.Replace(" ", "") + "\"";
        //            query += ("surname=@surname ");
        //            flag = true;
        //        }
        //        else if (textEdit9.Text != "" && flag == true)
        //        {
        //            query_set += ", @surname =\"" + textEdit9.Text.Replace(" ", "") + "\"";
        //            query += ("AND surname=@surname ");
        //        }

        //        if (textEdit8.Text != "" && flag == false)
        //        {
        //            query_set = "SET @name =\"" + textEdit8.Text.Replace(" ", "") + "\"";
        //            query += ("name=@name ");
        //            flag = true;
        //        }
        //        else if (textEdit8.Text != "" && flag == true)
        //        {
        //            query_set += ", @name =\"" + textEdit8.Text.Replace(" ", "") + "\"";
        //            query += ("AND name=@name ");
        //        }

        //        if (textEdit10.Text != "" && flag == false)
        //        {
        //            query_set = "SET @patronomyc =\"" + textEdit10.Text.Replace(" ", "") + "\"";
        //            query += ("patronomyc = @patronomyc ");
        //            flag = true;
        //        }
        //        else if (textEdit10.Text != "" && flag == true)
        //        {
        //            query_set += ", @patronomyc =\"" + textEdit10.Text.Replace(" ", "") + "\"";
        //            query += ("AND patronomyc = @patronomyc ");
        //        }

        //        if (textEdit11.Text != "" && flag == false)
        //        {
        //            query_set = "SET @gender =\"" + textEdit11.Text.Replace(" ", "") + "\"";
        //            query += ("gender=@gender ");
        //            flag = true;
        //        }
        //        else if (textEdit11.Text != "" && flag == true)
        //        {
        //            query_set += ", @gender =\"" + textEdit11.Text.Replace(" ", "") + "\"";
        //            query += ("AND gender=@gender ");
        //        }

        //        if (textEdit12.Text != "" && flag == false)
        //        {
        //            query_set = "SET @tax_number =\"" + textEdit12.Text.Replace(" ", "") + "\"";
        //            query += ("tax_number=@tax_number ");
        //            flag = true;
        //        }
        //        else if (textEdit12.Text != "" && flag == true)
        //        {
        //            query_set += ", @tax_number =\"" + textEdit12.Text.Replace(" ", "") + "\"";
        //            query += ("AND tax_number=@tax_number ");
        //        }

        //        if (textEdit13.Text != "" && flag == false)
        //        {
        //            query_set = "SET @birth_date =\"" + textEdit13.Text.Replace(" ", "") + "\"";
        //            query += ("birth_date=@birth_date ");
        //            flag = true;
        //        }
        //        else if (textEdit13.Text != "" && flag == true)
        //        {
        //            query_set += ", @birth_date =\"" + textEdit13.Text.Replace(" ", "") + "\"";
        //            query += ("AND birth_date=@birth_date ");
        //        }

        //        if (textEdit14.Text != "" && flag == false)
        //        {
        //            query_set = "SET @citizenship =\"" + textEdit14.Text.Replace(" ", "") + "\"";
        //            query += ("citizenship=@citizenship ");
        //            flag = true;
        //        }
        //        else if (textEdit14.Text != "" && flag == true)
        //        {
        //            query_set += ", @citizenship =\"" + textEdit14.Text.Replace(" ", "") + "\"";
        //            query += ("AND citizenship=@citizenship ");
        //        }

        //        if (textEdit15.Text != "" && flag == false)
        //        {
        //            query_set = "SET @expiry_date =\"" + textEdit15.Text.Replace(" ", "") + "\"";
        //            query += ("expiry_date=@expiry_date ");
        //            flag = true;
        //        }
        //        else if (textEdit15.Text != "" && flag == true)
        //        {
        //            query_set += ", @expiry_date =\"" + textEdit15.Text.Replace(" ", "") + "\"";
        //            query += ("AND expiry_date=@expiry_date ");
        //        }

        //        if (textEdit16.Text != "" && flag == false)
        //        {
        //            query_set = "SET @issue_date =\"" + textEdit16.Text.Replace(" ", "") + "\"";
        //            query += ("issue_date=@issue_date ");
        //            flag = true;
        //        }
        //        else if (textEdit16.Text != "" && flag == true)
        //        {
        //            query_set += ", @issue_date =\"" + textEdit16.Text.Replace(" ", "") + "\"";
        //            query += ("AND issue_date=@issue_date ");
        //        }

        //        if (textEdit17.Text != "" && flag == false)
        //        {
        //            query_set = "SET @authority =\"" + textEdit17.Text.Replace(" ", "") + "\"";
        //            query += ("authority=@authority ");
        //            flag = true;
        //        }
        //        else if (textEdit17.Text != "" && flag == true)
        //        {
        //            query_set += ", @authority =\"" + textEdit17.Text.Replace(" ", "") + "\"";
        //            query += ("AND authority=@authority ");
        //        }

        //        if (textEdit18.Text != "" && flag == false)
        //        {
        //            query_set = "SET @record =\"" + textEdit18.Text.Replace(" ", "") + "\"";
        //            query += ("record=@record ");
        //            flag = true;
        //        }
        //        else if (textEdit18.Text != "" && flag == true)
        //        {
        //            query_set += ", @record =\"" + textEdit18.Text.Replace(" ", "") + "\"";
        //            query += ("AND record=@record ");
        //        }

        //        query_set += ";";
        //        query += ";";
        //        try
        //        {

        //            using (OdbcConnection DbConnection = new OdbcConnection("DSN=passport_desk"))
        //            {

        //                DbConnection.Open();
        //                OdbcCommand DbCommand = DbConnection.CreateCommand();
        //                DbCommand.CommandText = query;
        //                OdbcCommand DbCommand2 = DbConnection.CreateCommand();
        //                DbCommand2.CommandText = query_set;
        //                DbCommand2.ExecuteNonQuery();
        //                OdbcDataReader DbReader = DbCommand.ExecuteReader();
        //                List<string[]> data = new List<string[]>();
        //                DateTime date;
        //                while (DbReader.Read())
        //                {
        //                    data.Add(new string[12]);

        //                    data[data.Count - 1][0] = DbReader[0].ToString();
        //                    data[data.Count - 1][1] = DbReader[1].ToString();
        //                    data[data.Count - 1][2] = DbReader[2].ToString();
        //                    data[data.Count - 1][3] = DbReader[3].ToString();
        //                    data[data.Count - 1][4] = DbReader[4].ToString();
        //                    data[data.Count - 1][5] = DbReader[5].ToString();
        //                    date = (DateTime)DbReader[6];
        //                    data[data.Count - 1][6] = date.ToString("yyyy.MM.dd");
        //                    data[data.Count - 1][7] = DbReader[7].ToString();
        //                    date = (DateTime)DbReader[8];
        //                    data[data.Count - 1][8] = date.ToString("yyyy.MM.dd");
        //                    date = (DateTime)DbReader[9];
        //                    data[data.Count - 1][9] = date.ToString("yyyy.MM.dd");
        //                    data[data.Count - 1][10] = DbReader[10].ToString();
        //                    data[data.Count - 1][11] = DbReader[11].ToString();
        //                }

        //                foreach (string[] s in data)
        //                {
        //                    dataGridView2.Rows.Add(s);
        //                }
        //                DbReader.Close();

        //            }

        //            flag = false;
        //            query = "";
        //            query_set = "";

        //        }
        //        catch (OdbcException exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    return;
        //}

        //private void simpleButton6_Click(object sender, EventArgs e)
        //{
        //    dataGridView3.Rows.Clear();
        //    string query = "SELECT * FROM Place_of_birth WHERE ";
        //    string query_set = "";
        //    Boolean flag = false;

        //    if (textEdit20.Text != "" || textEdit21.Text != "" || textEdit22.Text != "" || textEdit23.Text != "")
        //    {
        //        if (textEdit20.Text != "")
        //        {
        //            query_set = "SET @fk_passport =\"" + textEdit20.Text.Replace(" ", "") + "\"";
        //            query += ("fk_passport=@fk_passport ");
        //            flag = true;
        //        }

        //        if (textEdit21.Text != "" && flag == false)
        //        {
        //            query_set = "SET @settlement =\"" + textEdit21.Text.Replace(" ", "") + "\"";
        //            query += ("settlement=@settlement ");
        //            flag = true;
        //        }
        //        else if (textEdit21.Text != "" && flag == true)
        //        {
        //            query_set += ", @settlement =\"" + textEdit21.Text.Replace(" ", "") + "\"";
        //            query += ("AND settlement=@settlement ");
        //        }

        //        if (textEdit22.Text != "" && flag == false)
        //        {
        //            query_set = "SET @region =\"" + textEdit22.Text.Replace(" ", "") + "\"";
        //            query += ("region=@region ");
        //            flag = true;
        //        }
        //        else if (textEdit22.Text != "" && flag == true)
        //        {
        //            query_set += ", @region =\"" + textEdit22.Text.Replace(" ", "") + "\"";
        //            query += ("AND region=@region ");
        //        }

        //        if (textEdit23.Text != "" && flag == false)
        //        {
        //            query_set = "SET @country =\"" + textEdit23.Text.Replace(" ", "") + "\"";
        //            query += ("country = @country ");
        //            flag = true;
        //        }
        //        else if (textEdit23.Text != "" && flag == true)
        //        {
        //            query_set += ", @country =\"" + textEdit23.Text.Replace(" ", "") + "\"";
        //            query += ("AND country = @country ");
        //        }

        //        query_set += ";";
        //        query += ";";
        //        try
        //        {

        //            using (OdbcConnection DbConnection = new OdbcConnection("DSN=passport_desk"))
        //            {

        //                DbConnection.Open();
        //                OdbcCommand DbCommand = DbConnection.CreateCommand();
        //                DbCommand.CommandText = query;
        //                OdbcCommand DbCommand2 = DbConnection.CreateCommand();
        //                DbCommand2.CommandText = query_set;
        //                DbCommand2.ExecuteNonQuery();
        //                OdbcDataReader DbReader = DbCommand.ExecuteReader();
        //                List<string[]> data = new List<string[]>();
        //                DateTime date;
        //                while (DbReader.Read())
        //                {
        //                    data.Add(new string[4]);

        //                    data[data.Count - 1][0] = DbReader[0].ToString();
        //                    data[data.Count - 1][1] = DbReader[1].ToString();
        //                    data[data.Count - 1][2] = DbReader[2].ToString();
        //                    data[data.Count - 1][3] = DbReader[3].ToString();
        //                }

        //                foreach (string[] s in data)
        //                {
        //                    dataGridView3.Rows.Add(s);
        //                }
        //                DbReader.Close();

        //            }

        //            flag = false;
        //            query = "";
        //            query_set = "";

        //        }
        //        catch (OdbcException exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    return;
        //}

        //private void simpleButton7_Click(object sender, EventArgs e)
        //{
        //    dataGridView4.Rows.Clear();
        //    string query = "SELECT * FROM Place_of_registration WHERE ";
        //    string query_set = "";
        //    Boolean flag = false;

        //    if (textEdit24.Text != "" || textEdit25.Text != "" || textEdit26.Text != "" || textEdit27.Text != "" || textEdit28.Text != "" || textEdit29.Text != "" ||
        //        textEdit30.Text != "" || textEdit31.Text != "")
        //    {
        //        if (textEdit24.Text != "")
        //        {
        //            query_set = "SET @fk_passport =\"" + textEdit24.Text.Replace(" ", "") + "\"";
        //            query += ("fk_passport=@fk_passport ");
        //            flag = true;
        //        }

        //        if (textEdit25.Text != "" && flag == false)
        //        {
        //            query_set = "SET @country =\"" + textEdit25.Text.Replace(" ", "") + "\"";
        //            query += ("country=@country ");
        //            flag = true;
        //        }
        //        else if (textEdit25.Text != "" && flag == true)
        //        {
        //            query_set += ", @country =\"" + textEdit25.Text.Replace(" ", "") + "\"";
        //            query += ("AND country=@country ");
        //        }

        //        if (textEdit26.Text != "" && flag == false)
        //        {
        //            query_set = "SET @settlement =\"" + textEdit26.Text.Replace(" ", "") + "\"";
        //            query += ("settlement=@settlement ");
        //            flag = true;
        //        }
        //        else if (textEdit26.Text != "" && flag == true)
        //        {
        //            query_set += ", @settlement =\"" + textEdit26.Text.Replace(" ", "") + "\"";
        //            query += ("AND settlement=@settlement ");
        //        }

        //        if (textEdit27.Text != "" && flag == false)
        //        {
        //            query_set = "SET @region =\"" + textEdit27.Text.Replace(" ", "") + "\"";
        //            query += ("region = @region ");
        //            flag = true;
        //        }
        //        else if (textEdit27.Text != "" && flag == true)
        //        {
        //            query_set += ", @region =\"" + textEdit27.Text.Replace(" ", "") + "\"";
        //            query += ("AND region = @region ");
        //        }

        //        if (textEdit28.Text != "" && flag == false)
        //        {
        //            query_set = "SET @street =\"" + textEdit28.Text.Replace(" ", "") + "\"";
        //            query += ("street=@street ");
        //            flag = true;
        //        }
        //        else if (textEdit28.Text != "" && flag == true)
        //        {
        //            query_set += ", @street =\"" + textEdit28.Text.Replace(" ", "") + "\"";
        //            query += ("AND street=@street ");
        //        }

        //        if (textEdit29.Text != "" && flag == false)
        //        {
        //            query_set = "SET @house =\"" + textEdit29.Text.Replace(" ", "") + "\"";
        //            query += ("house=@house ");
        //            flag = true;
        //        }
        //        else if (textEdit29.Text != "" && flag == true)
        //        {
        //            query_set += ", @house =\"" + textEdit29.Text.Replace(" ", "") + "\"";
        //            query += ("AND house=@house ");
        //        }

        //        if (textEdit30.Text != "" && flag == false)
        //        {
        //            query_set = "SET @apartment =\"" + textEdit30.Text.Replace(" ", "") + "\"";
        //            query += ("apartment=@apartment ");
        //            flag = true;
        //        }
        //        else if (textEdit30.Text != "" && flag == true)
        //        {
        //            query_set += ", @apartment =\"" + textEdit30.Text.Replace(" ", "") + "\"";
        //            query += ("AND apartment=@apartment ");
        //        }

        //        if (textEdit31.Text != "" && flag == false)
        //        {
        //            query_set = "SET @registration_date =\"" + textEdit31.Text.Replace(" ", "") + "\"";
        //            query += ("registration_date=@registration_date ");
        //            flag = true;
        //        }
        //        else if (textEdit31.Text != "" && flag == true)
        //        {
        //            query_set += ", @registration_date =\"" + textEdit31.Text.Replace(" ", "") + "\"";
        //            query += ("AND registration_date=@registration_date ");
        //        }

        //        query_set += ";";
        //        query += ";";
        //        try
        //        {

        //            using (OdbcConnection DbConnection = new OdbcConnection("DSN=passport_desk"))
        //            {

        //                DbConnection.Open();
        //                OdbcCommand DbCommand = DbConnection.CreateCommand();
        //                DbCommand.CommandText = query;
        //                OdbcCommand DbCommand2 = DbConnection.CreateCommand();
        //                DbCommand2.CommandText = query_set;
        //                DbCommand2.ExecuteNonQuery();
        //                OdbcDataReader DbReader = DbCommand.ExecuteReader();
        //                List<string[]> data = new List<string[]>();
        //                DateTime date;
        //                while (DbReader.Read())
        //                {
        //                    data.Add(new string[8]);

        //                    data[data.Count - 1][0] = DbReader[0].ToString();
        //                    data[data.Count - 1][1] = DbReader[1].ToString();
        //                    data[data.Count - 1][2] = DbReader[2].ToString();
        //                    data[data.Count - 1][3] = DbReader[3].ToString();
        //                    data[data.Count - 1][4] = DbReader[4].ToString();
        //                    data[data.Count - 1][5] = DbReader[5].ToString();
        //                    data[data.Count - 1][6] = DbReader[6].ToString();
        //                    date = (DateTime)DbReader[7];
        //                    data[data.Count - 1][7] = date.ToString("yyyy.MM.dd");
        //                }

        //                foreach (string[] s in data)
        //                {
        //                    dataGridView4.Rows.Add(s);
        //                }
        //                DbReader.Close();

        //            }

        //            flag = false;
        //            query = "";
        //            query_set = "";

        //        }
        //        catch (OdbcException exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    return;
        //}

        ////--------------------------------------------------------INSERT Place_of_birth PASSPORT---------------------------------------------------------------------

        //private void simpleButton12_Click(object sender, EventArgs e)
        //{
        //    if (textEdit20.Text != "" && textEdit21.Text != "" && textEdit22.Text != "" && textEdit23.Text != "")
        //    {
        //        string query = "INSERT INTO passport_desk.Place_of_birth VALUES (?,?,?,?)";
        //        try
        //        {

        //            using (OdbcConnection DbConnection = new OdbcConnection("DSN=passport_desk"))
        //            {

        //                DbConnection.Open();
        //                using (OdbcCommand command = new OdbcCommand(query, DbConnection))
        //                {
        //                    command.Parameters.AddWithValue("@fk_passport", textEdit20.Text);
        //                    command.Parameters.AddWithValue("@settlement", textEdit21.Text);
        //                    command.Parameters.AddWithValue("@region", textEdit22.Text);
        //                    command.Parameters.AddWithValue("@country", textEdit23.Text);

        //                    command.ExecuteNonQuery();
        //                }

        //            }
        //            query = "";

        //        }
        //        catch (OdbcException exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        return;
        //    }
        //    else if (textEdit20.Text != "" && textEdit21.Text != "" && textEdit22.Text == "" && textEdit23.Text != "")
        //    {
        //        string query = "INSERT INTO passport_desk.Place_of_birth VALUES (?,?,\"\",?)";
        //        try
        //        {

        //            using (OdbcConnection DbConnection = new OdbcConnection("DSN=passport_desk"))
        //            {

        //                DbConnection.Open();
        //                using (OdbcCommand command = new OdbcCommand(query, DbConnection))
        //                {
        //                    command.Parameters.AddWithValue("@fk_passport", textEdit20.Text);
        //                    command.Parameters.AddWithValue("@settlement", textEdit21.Text);
        //                    command.Parameters.AddWithValue("@country", textEdit23.Text);

        //                    command.ExecuteNonQuery();
        //                }

        //            }
        //            query = "";

        //        }
        //        catch (OdbcException exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        return;
        //    }
        //    else { MessageBox.Show("Не всі значення введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
        //}

        ////--------------------------------------------------------INSERT INTERNATIONAL PASSPORT---------------------------------------------------------------------

        //private void simpleButton3_Click(object sender, EventArgs e)
        //{

        //    if (textEdit1.Text != "" && textEdit2.Text != "" && textEdit3.Text != "" && textEdit4.Text != "" && textEdit5.Text != "" && textEdit6.Text != ""
        //        && textEdit19.Text != "")
        //    {
        //        string query = "INSERT INTO passport_desk.International_passport VALUES (?,?,?,?,?,?,?)";
        //        try
        //        {

        //            using (OdbcConnection DbConnection = new OdbcConnection("DSN=passport_desk"))
        //            {

        //                DbConnection.Open();
        //                using (OdbcCommand command = new OdbcCommand(query, DbConnection))
        //                {
        //                    command.Parameters.AddWithValue("@id_international_passport", textEdit1.Text);
        //                    command.Parameters.AddWithValue("@issue_date", textEdit2.Text);
        //                    command.Parameters.AddWithValue("@expiry_date", textEdit3.Text);
        //                    command.Parameters.AddWithValue("@type_international_passport", textEdit4.Text);
        //                    command.Parameters.AddWithValue("@country_code", textEdit5.Text);
        //                    command.Parameters.AddWithValue("@verifed_by_tax_service", textEdit6.Text);
        //                    command.Parameters.AddWithValue("@fk_passport", textEdit19.Text);

        //                    command.ExecuteNonQuery();
        //                }

        //            }
        //            query = "";

        //        }
        //        catch (OdbcException exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else { MessageBox.Show("Не всі значення введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
        //    return;
        //}

        ////------------------------------------------------------------INSERT PASSPORT----------------------------------------------------------------------------

        //private void simpleButton4_Click(object sender, EventArgs e)
        //{
        //    if (textEdit7.Text != "" && textEdit8.Text != "" && textEdit9.Text != "" && textEdit10.Text == "" && textEdit11.Text != "" && textEdit12.Text != ""
        //        && textEdit13.Text != "" && textEdit14.Text != "" && textEdit15.Text != "" && textEdit16.Text != "" && textEdit17.Text != "" && textEdit18.Text != "")
        //    {

        //        string query = "INSERT INTO passport_desk.Passport VALUES (?,?,?,\"\",?,?,?,?,?,?,?,?)";
        //        try
        //        {

        //            using (OdbcConnection DbConnection = new OdbcConnection("DSN=passport_desk"))
        //            {

        //                DbConnection.Open();
        //                using (OdbcCommand command = new OdbcCommand(query, DbConnection))
        //                {
        //                    command.Parameters.AddWithValue("@id_passport", textEdit7.Text);
        //                    command.Parameters.AddWithValue("@name", textEdit8.Text);
        //                    command.Parameters.AddWithValue("@surname", textEdit9.Text);
        //                    command.Parameters.AddWithValue("@gender", textEdit11.Text);
        //                    command.Parameters.AddWithValue("@tax_number", textEdit12.Text);
        //                    command.Parameters.AddWithValue("@birth_date", textEdit13.Text);
        //                    command.Parameters.AddWithValue("@citizenship", textEdit14.Text);
        //                    command.Parameters.AddWithValue("@expiry_date", textEdit15.Text);
        //                    command.Parameters.AddWithValue("@issue_date", textEdit16.Text);
        //                    command.Parameters.AddWithValue("@authority", textEdit17.Text);
        //                    command.Parameters.AddWithValue("@record", textEdit18.Text);

        //                    command.ExecuteNonQuery();
        //                }

        //            }
        //            query = "";

        //        }
        //        catch (OdbcException exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        return;
        //    }
        //    else if (textEdit7.Text != "" && textEdit8.Text != "" && textEdit9.Text != "" && textEdit11.Text != "" && textEdit12.Text != ""
        //        && textEdit13.Text != "" && textEdit14.Text != "" && textEdit15.Text != "" && textEdit16.Text != "" && textEdit17.Text != "" && textEdit18.Text != ""
        //        && textEdit10.Text != "")
        //    {
        //        string query = "INSERT INTO passport_desk.Passport VALUES (?,?,?,?,?,?,?,?,?,?,?,?)";
        //        try
        //        {

        //            using (OdbcConnection DbConnection = new OdbcConnection("DSN=passport_desk"))
        //            {

        //                DbConnection.Open();
        //                using (OdbcCommand command = new OdbcCommand(query, DbConnection))
        //                {
        //                    command.Parameters.AddWithValue("@id_passport", textEdit7.Text);
        //                    command.Parameters.AddWithValue("@name", textEdit8.Text);
        //                    command.Parameters.AddWithValue("@surname", textEdit9.Text);
        //                    command.Parameters.AddWithValue("@patronomyc", textEdit10.Text);
        //                    command.Parameters.AddWithValue("@gender", textEdit11.Text);
        //                    command.Parameters.AddWithValue("@tax_number", textEdit12.Text);
        //                    command.Parameters.AddWithValue("@birth_date", textEdit13.Text);
        //                    command.Parameters.AddWithValue("@citizenship", textEdit14.Text);
        //                    command.Parameters.AddWithValue("@expiry_date", textEdit15.Text);
        //                    command.Parameters.AddWithValue("@issue_date", textEdit16.Text);
        //                    command.Parameters.AddWithValue("@authority", textEdit17.Text);
        //                    command.Parameters.AddWithValue("@record", textEdit18.Text);

        //                    command.ExecuteNonQuery();
        //                }

        //            }
        //            query = "";

        //        }
        //        catch (OdbcException exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        return;

        //    }
        //    else { MessageBox.Show("Не всі значення введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
        //}

        ////--------------------------------------------------------INSERT Place_of_registration---------------------------------------------------------------------
        ////Треба додати IF
        //private void simpleButton15_Click(object sender, EventArgs e)
        //{
        //    if (textEdit24.Text != "" && textEdit25.Text != "" && textEdit26.Text != "" && textEdit27.Text != "" && textEdit28.Text != "" && textEdit29.Text != "" &&
        //        textEdit30.Text != "" && textEdit31.Text != "")
        //    {
        //        string query = "INSERT INTO passport_desk.Place_of_registration VALUES (?,?,?,?,?,?,?,?)";
        //        try
        //        {

        //            using (OdbcConnection DbConnection = new OdbcConnection("DSN=passport_desk"))
        //            {

        //                DbConnection.Open();
        //                using (OdbcCommand command = new OdbcCommand(query, DbConnection))
        //                {
        //                    command.Parameters.AddWithValue("@fk_passport", textEdit24.Text);
        //                    command.Parameters.AddWithValue("@country", textEdit25.Text);
        //                    command.Parameters.AddWithValue("@settlement", textEdit26.Text);
        //                    command.Parameters.AddWithValue("@region", textEdit27.Text);
        //                    command.Parameters.AddWithValue("@street", textEdit28.Text);
        //                    command.Parameters.AddWithValue("@house", textEdit29.Text);
        //                    command.Parameters.AddWithValue("@apartment", textEdit30.Text);
        //                    command.Parameters.AddWithValue("@registration_date", textEdit31.Text);

        //                    command.ExecuteNonQuery();
        //                }

        //            }
        //            query = "";

        //        }
        //        catch (OdbcException exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        return;
        //    }
        //    else if (textEdit24.Text != "" && textEdit25.Text != "" && textEdit26.Text != "" && textEdit27.Text == "" && textEdit28.Text != "" && textEdit29.Text != ""
        //        && textEdit30.Text != "" || textEdit31.Text != "")
        //    {
        //        string query = "INSERT INTO passport_desk.Place_of_registration VALUES (?,?,?,\"\",?,?,?,?)";
        //        try
        //        {

        //            using (OdbcConnection DbConnection = new OdbcConnection("DSN=passport_desk"))
        //            {

        //                DbConnection.Open();
        //                using (OdbcCommand command = new OdbcCommand(query, DbConnection))
        //                {
        //                    command.Parameters.AddWithValue("@fk_passport", textEdit24.Text);
        //                    command.Parameters.AddWithValue("@country", textEdit25.Text);
        //                    command.Parameters.AddWithValue("@settlement", textEdit26.Text);
        //                    command.Parameters.AddWithValue("@street", textEdit28.Text);
        //                    command.Parameters.AddWithValue("@house", textEdit29.Text);
        //                    command.Parameters.AddWithValue("@apartment", textEdit30.Text);
        //                    command.Parameters.AddWithValue("@registration_date", textEdit31.Text);

        //                    command.ExecuteNonQuery();
        //                }

        //            }
        //            query = "";

        //        }
        //        catch (OdbcException exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        return;
        //    }
        //    else { MessageBox.Show("Не всі значення введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

        //}

        ////-------------------------------------------Видалення місця народження-------------------------------------------

        //private void simpleButton13_Click(object sender, EventArgs e)
        //{
        //    string query = "DELETE FROM passport_desk.Place_of_birth WHERE fk_passport = ?";
        //    if (!(dataGridView3.CurrentRow is null))
        //    {
        //        try
        //        {

        //            using (OdbcConnection DbConnection = new OdbcConnection("DSN=passport_desk"))
        //            {

        //                DbConnection.Open();
        //                using (OdbcCommand command = new OdbcCommand(query, DbConnection))
        //                {
        //                    command.Parameters.AddWithValue("@fk_passport", dataGridView3.SelectedRows[0].Cells[0].Value.ToString());
        //                    command.ExecuteNonQuery();
        //                }

        //            }
        //            query = "";

        //        }
        //        catch (OdbcException exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    return;
        //}

        //private void simpleButton17_Click(object sender, EventArgs e)
        //{
        //    string query = "DELETE FROM passport_desk.Place_of_registration WHERE fk_passport = ?";
        //    if (!(dataGridView4.CurrentRow is null))
        //    {
        //        try
        //        {

        //            using (OdbcConnection DbConnection = new OdbcConnection("DSN=passport_desk"))
        //            {

        //                DbConnection.Open();
        //                using (OdbcCommand command = new OdbcCommand(query, DbConnection))
        //                {
        //                    command.Parameters.AddWithValue("@fk_passport", dataGridView4.SelectedRows[0].Cells[0].Value.ToString());
        //                    command.ExecuteNonQuery();
        //                }

        //            }
        //            query = "";

        //        }
        //        catch (OdbcException exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    return;
        //}

        //private void simpleButton11_Click(object sender, EventArgs e)
        //{
        //    string query = "DELETE FROM passport_desk.International_passport WHERE id_international_passport = ?";
        //    if (!(dataGridView1.CurrentRow is null))
        //    {
        //        try
        //        {

        //            using (OdbcConnection DbConnection = new OdbcConnection("DSN=passport_desk"))
        //            {

        //                DbConnection.Open();
        //                using (OdbcCommand command = new OdbcCommand(query, DbConnection))
        //                {
        //                    command.Parameters.AddWithValue("@id_passport", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
        //                    command.ExecuteNonQuery();
        //                }

        //            }
        //            query = "";

        //        }
        //        catch (OdbcException exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    return;
        //}

        //private void simpleButton9_Click(object sender, EventArgs e)
        //{
        //    string query_passport = "DELETE FROM passport_desk.Passport WHERE id_passport = ?";
        //    string query_birth = "DELETE FROM passport_desk.Place_of_birth WHERE fk_passport = ?";
        //    string query_registration = "DELETE FROM passport_desk.Place_of_registration WHERE fk_passport = ?";
        //    if (!(dataGridView2.CurrentRow is null))
        //    {
        //        try
        //        {

        //            using (OdbcConnection DbConnection = new OdbcConnection("DSN=passport_desk"))
        //            {

        //                DbConnection.Open();
        //                using (OdbcCommand command2 = new OdbcCommand(query_birth, DbConnection))
        //                {
        //                    command2.Parameters.AddWithValue("@fk_passport", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
        //                    command2.ExecuteNonQuery();
        //                }
        //                using (OdbcCommand command3 = new OdbcCommand(query_registration, DbConnection))
        //                {
        //                    command3.Parameters.AddWithValue("@fk_passport", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
        //                    command3.ExecuteNonQuery();
        //                }
        //                using (OdbcCommand command = new OdbcCommand(query_passport, DbConnection))
        //                {
        //                    command.Parameters.AddWithValue("@id_passport", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
        //                    command.ExecuteNonQuery();
        //                }
        //            }
        //            query_passport = query_birth = query_registration = "";

        //        }
        //        catch (OdbcException exp)
        //        {
        //            MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    return;
        //}

        private void ticket_type_search_button_click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string query = "SELECT * FROM Ticket_type WHERE ";
            string query_set = "";

            if (ticket_type_id_text_box.Text != "")
            {
                query_set = "SET @ticket_type_id =\"" + ticket_type_id_text_box.Text.Replace(" ", "") + "\";";
                query += ("ticket_type_id = @ticket_type_id;");
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;
                        OdbcCommand DbCommand2 = DbConnection.CreateCommand();
                        DbCommand2.CommandText = query_set;
                        DbCommand2.ExecuteNonQuery();
                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[2]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                    query_set = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                query = "SELECT * FROM Ticket_type;";
                try
                {
                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;

                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[2]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string query = "SELECT * FROM Ticket WHERE ";
            string query_set = "";

            if (Ticket_ticket_id_textbox.Text != "")
            {
                query_set = "SET @ticket_id =\"" + Ticket_ticket_id_textbox.Text.Replace(" ", "") + "\";";
                query += ("ticket_id = @ticket_id;");
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;
                        OdbcCommand DbCommand2 = DbConnection.CreateCommand();
                        DbCommand2.CommandText = query_set;
                        DbCommand2.ExecuteNonQuery();
                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[5]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                            data[data.Count - 1][2] = DbReader[2].ToString();
                            data[data.Count - 1][3] = DbReader[3].ToString();
                            data[data.Count - 1][4] = DbReader[4].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                    query_set = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                query = "SELECT * FROM Ticket;";
                try
                {
                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;

                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[5]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                            data[data.Count - 1][2] = DbReader[2].ToString();
                            data[data.Count - 1][3] = DbReader[3].ToString();
                            data[data.Count - 1][4] = DbReader[4].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string query = "SELECT * FROM Customer WHERE ";
            string query_set = "";

            if (Customer_customer_id_textbox.Text != "")
            {
                query_set = "SET @customer_customer_id =\"" + Customer_customer_id_textbox.Text.Replace(" ", "") + "\";";
                query += ("customer_id = @customer_customer_id;");
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;
                        OdbcCommand DbCommand2 = DbConnection.CreateCommand();
                        DbCommand2.CommandText = query_set;
                        DbCommand2.ExecuteNonQuery();
                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[5]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                            data[data.Count - 1][2] = DbReader[2].ToString();
                            data[data.Count - 1][3] = DbReader[3].ToString();
                            data[data.Count - 1][4] = DbReader[4].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                    query_set = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                query = "SELECT * FROM Customer;";
                try
                {
                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;

                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[5]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                            data[data.Count - 1][2] = DbReader[2].ToString();
                            data[data.Count - 1][3] = DbReader[3].ToString();
                            data[data.Count - 1][4] = DbReader[4].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string query = "SELECT * FROM Wagon WHERE ";
            string query_set = "";

            if (Wagon_wagon_id_textbox.Text != "")
            {
                query_set = "SET @wagon_id =\"" + Wagon_wagon_id_textbox.Text.Replace(" ", "") + "\";";
                query += ("wagon_id = @wagon_id;");
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;
                        OdbcCommand DbCommand2 = DbConnection.CreateCommand();
                        DbCommand2.CommandText = query_set;
                        DbCommand2.ExecuteNonQuery();
                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[4]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                            data[data.Count - 1][2] = DbReader[2].ToString();
                            data[data.Count - 1][3] = DbReader[3].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                    query_set = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                query = "SELECT * FROM Wagon;";
                try
                {
                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;

                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[4]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                            data[data.Count - 1][2] = DbReader[2].ToString();
                            data[data.Count - 1][3] = DbReader[3].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string query = "SELECT * FROM wagon_type WHERE ";
            string query_set = "";

            if (Wagon_type_wagon_type_id_textbox.Text != "")
            {
                query_set = "SET @wagon_type_id =\"" + Wagon_type_wagon_type_id_textbox.Text.Replace(" ", "") + "\";";
                query += ("wagon_type_id = @wagon_type_id;");
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;
                        OdbcCommand DbCommand2 = DbConnection.CreateCommand();
                        DbCommand2.CommandText = query_set;
                        DbCommand2.ExecuteNonQuery();
                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[2]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                    query_set = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                query = "SELECT * FROM Wagon_type;";
                try
                {
                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;

                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[2]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string query = "SELECT * FROM Train WHERE ";
            string query_set = "";

            if (Train_train_id_textbox.Text != "")
            {
                query_set = "SET @train_id =\"" + Train_train_id_textbox.Text.Replace(" ", "") + "\";";
                query += ("train_id = @train_id;");
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;
                        OdbcCommand DbCommand2 = DbConnection.CreateCommand();
                        DbCommand2.CommandText = query_set;
                        DbCommand2.ExecuteNonQuery();
                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[4]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                            data[data.Count - 1][2] = DbReader[1].ToString();
                            data[data.Count - 1][3] = DbReader[1].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                    query_set = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                query = "SELECT * FROM Train;";
                try
                {
                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;

                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[4]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                            data[data.Count - 1][2] = DbReader[1].ToString();
                            data[data.Count - 1][3] = DbReader[1].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string query = "SELECT * FROM Train_type WHERE ";
            string query_set = "";

            if (Train_type_train_type_id_textbox.Text != "")
            {
                query_set = "SET @train_type_id =\"" + Train_type_train_type_id_textbox.Text.Replace(" ", "") + "\";";
                query += ("train_type_id = @train_type_id;");
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;
                        OdbcCommand DbCommand2 = DbConnection.CreateCommand();
                        DbCommand2.CommandText = query_set;
                        DbCommand2.ExecuteNonQuery();
                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[2]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                    query_set = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                query = "SELECT * FROM Train_type;";
                try
                {
                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;

                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[2]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string query = "SELECT * FROM Route WHERE ";
            string query_set1 = "";
            string query_set2 = "";

            if (Route_direction_fk_textbox.Text != "" && Route_railway_station_fk_textbox.Text != "")
            {
                query_set1 = "SET @direction_id =\"" + Route_direction_fk_textbox.Text.Replace(" ", "") + "\";";
                query_set2 = "SET @railway_station_id =\"" + Route_railway_station_fk_textbox.Text.Replace(" ", "") + "\";";
                query += ("direction_fk = @direction_id AND railway_station_fk = @railway_station_id;");
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;
                        OdbcCommand DbCommand2 = DbConnection.CreateCommand();
                        DbCommand2.CommandText = query_set1;
                        OdbcCommand DbCommand3 = DbConnection.CreateCommand();
                        DbCommand3.CommandText = query_set2;
                        DbCommand2.ExecuteNonQuery();
                        DbCommand3.ExecuteNonQuery();
                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        DateTime date;
                        while (DbReader.Read())
                        {
                            data.Add(new string[5]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                            if (DateTime.TryParse(DbReader[2].ToString(), out date))
                            {
                                data[data.Count - 1][2] = date.ToString("yyyy.MM.dd HH:mm");
                            }

                            if (DateTime.TryParse(DbReader[3].ToString(), out date))
                            {
                                data[data.Count - 1][3] = date.ToString("yyyy.MM.dd HH:mm");
                            }
                            data[data.Count - 1][4] = DbReader[4].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                    query_set1 = "";
                    query_set2 = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                query = "SELECT * FROM Route;";
                try
                {
                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;

                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        DateTime date;
                        while (DbReader.Read())
                        {
                            data.Add(new string[5]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                            if (DateTime.TryParse(DbReader[2].ToString(), out date))
                            {
                                data[data.Count - 1][2] = date.ToString("yyyy.MM.dd HH:mm");
                            }

                            if (DateTime.TryParse(DbReader[3].ToString(), out date))
                            {
                                data[data.Count - 1][3] = date.ToString("yyyy.MM.dd HH:mm");
                            }
                            data[data.Count - 1][4] = DbReader[4].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string query = "SELECT * FROM Direction WHERE ";
            string query_set = "";

            if (Direction_Direction_id_textbox.Text != "")
            {
                query_set = "SET @direction_id =\"" + Direction_Direction_id_textbox.Text.Replace(" ", "") + "\";";
                query += ("idDirection = @direction_id;");
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;
                        OdbcCommand DbCommand2 = DbConnection.CreateCommand();
                        DbCommand2.CommandText = query_set;
                        DbCommand2.ExecuteNonQuery();
                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[2]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                    query_set = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                query = "SELECT * FROM Direction;";
                try
                {
                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;

                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[2]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string query = "SELECT * FROM RailwayStation WHERE ";
            string query_set = "";

            if (Railway_station_Railway_station_id_textbox.Text != "")
            {
                query_set = "SET @railway_station_id =\"" + Railway_station_Railway_station_id_textbox.Text.Replace(" ", "") + "\";";
                query += ("railway_station_id = @railway_station_id;");
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;
                        OdbcCommand DbCommand2 = DbConnection.CreateCommand();
                        DbCommand2.CommandText = query_set;
                        DbCommand2.ExecuteNonQuery();
                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        DateTime date;
                        while (DbReader.Read())
                        {
                            data.Add(new string[3]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                            if (DateTime.TryParse(DbReader[1].ToString(), out date))
                            {
                                data[data.Count - 1][1] = date.ToString("yyyy.MM.dd HH:mm");
                            }

                            if (DateTime.TryParse(DbReader[2].ToString(), out date))
                            {
                                data[data.Count - 1][2] = date.ToString("yyyy.MM.dd HH:mm");
                            }
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                    query_set = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                query = "SELECT * FROM RailwayStation;";
                try
                {
                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;

                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        DateTime date;
                        while (DbReader.Read())
                        {
                            data.Add(new string[3]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                            if (DateTime.TryParse(DbReader[1].ToString(), out date))
                            {
                                data[data.Count - 1][1] = date.ToString("yyyy.MM.dd");
                            }

                            if (DateTime.TryParse(DbReader[2].ToString(), out date))
                            {
                                data[data.Count - 1][2] = date.ToString("yyyy.MM.dd");
                            }
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string query = "SELECT * FROM Employee WHERE ";
            string query_set = "";

            if (Employee_employee_id_texbox.Text != "")
            {
                query_set = "SET @employee_id =\"" + Employee_employee_id_texbox.Text.Replace(" ", "") + "\";";
                query += ("employee_id = @employee_id;");
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;
                        OdbcCommand DbCommand2 = DbConnection.CreateCommand();
                        DbCommand2.CommandText = query_set;
                        DbCommand2.ExecuteNonQuery();
                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[8]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                            data[data.Count - 1][2] = DbReader[2].ToString();
                            data[data.Count - 1][3] = DbReader[3].ToString();
                            data[data.Count - 1][4] = DbReader[4].ToString();
                            data[data.Count - 1][5] = DbReader[5].ToString();
                            data[data.Count - 1][6] = DbReader[6].ToString();
                            data[data.Count - 1][7] = DbReader[7].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                    query_set = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                query = "SELECT * FROM Employee;";
                try
                {
                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;

                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[8]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                            data[data.Count - 1][2] = DbReader[2].ToString();
                            data[data.Count - 1][3] = DbReader[3].ToString();
                            data[data.Count - 1][4] = DbReader[4].ToString();
                            data[data.Count - 1][5] = DbReader[5].ToString();
                            data[data.Count - 1][6] = DbReader[6].ToString();
                            data[data.Count - 1][7] = DbReader[7].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string query = "SELECT * FROM Position WHERE ";
            string query_set = "";

            if (Position_position_id_textbox.Text != "")
            {
                query_set = "SET @position_id =\"" + Position_position_id_textbox.Text.Replace(" ", "") + "\";";
                query += ("idPosition = @position_id;");
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;
                        OdbcCommand DbCommand2 = DbConnection.CreateCommand();
                        DbCommand2.CommandText = query_set;
                        DbCommand2.ExecuteNonQuery();
                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[2]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                    query_set = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                query = "SELECT * FROM Position;";
                try
                {
                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        OdbcCommand DbCommand = DbConnection.CreateCommand();
                        DbCommand.CommandText = query;

                        OdbcDataReader DbReader = DbCommand.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (DbReader.Read())
                        {
                            data.Add(new string[2]);
                            data[data.Count - 1][0] = DbReader[0].ToString();
                            data[data.Count - 1][1] = DbReader[1].ToString();
                        }

                        foreach (string[] s in data)
                        {
                            dataGridView2.Rows.Add(s);
                        }
                        DbReader.Close();
                    }
                    query = "";
                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.HeaderText = "";
            }

            dataGridView2.Columns[0].HeaderText = "Ticket_id";
            dataGridView2.Columns[1].HeaderText = "Seat";
            dataGridView2.Columns[2].HeaderText = "Customer_fk";
            dataGridView2.Columns[3].HeaderText = "Wagon_fk";
            dataGridView2.Columns[4].HeaderText = "Ticket_type_fk";
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.HeaderText = "";
            }
            dataGridView2.Columns[0].HeaderText = "Ticket_type_id";
            dataGridView2.Columns[1].HeaderText = "Description";
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.HeaderText = "";
            }
            dataGridView2.Columns[0].HeaderText = "Customer_id";
            dataGridView2.Columns[1].HeaderText = "Name";
            dataGridView2.Columns[2].HeaderText = "Surname";
            dataGridView2.Columns[3].HeaderText = "Telephone";
            dataGridView2.Columns[4].HeaderText = "Year";
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.HeaderText = "";
            }
            dataGridView2.Columns[0].HeaderText = "Wagon_id";
            dataGridView2.Columns[1].HeaderText = "Number_seats";
            dataGridView2.Columns[2].HeaderText = "Wagon_type_fk";
            dataGridView2.Columns[3].HeaderText = "Train_fk";
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.HeaderText = "";
            }
            dataGridView2.Columns[0].HeaderText = "Wagon_type_id";
            dataGridView2.Columns[1].HeaderText = "Description";
        }

        private void tabPage6_Enter(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.HeaderText = "";
            }
            dataGridView2.Columns[0].HeaderText = "Train_id";
            dataGridView2.Columns[1].HeaderText = "Load_capacity";
            dataGridView2.Columns[2].HeaderText = "Railway_station_fk";
            dataGridView2.Columns[3].HeaderText = "Train_type_fk";
        }

        private void tabPage7_Enter(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.HeaderText = "";
            }
            dataGridView2.Columns[0].HeaderText = "Train_type_id";
            dataGridView2.Columns[1].HeaderText = "Description";
        }

        private void tabPage8_Enter(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.HeaderText = "";
            }
            dataGridView2.Columns[0].HeaderText = "Direction_fk";
            dataGridView2.Columns[1].HeaderText = "Railway_station";
            dataGridView2.Columns[2].HeaderText = "Departure_time";
            dataGridView2.Columns[3].HeaderText = "Arrival_time";
            dataGridView2.Columns[4].HeaderText = "Train_fk";
        }

        private void tabPage9_Enter(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.HeaderText = "";
            }
            dataGridView2.Columns[0].HeaderText = "Direction_id";
            dataGridView2.Columns[1].HeaderText = "Description";
        }

        private void tabPage10_Enter(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.HeaderText = "";
            }
            dataGridView2.Columns[0].HeaderText = "Railway_station_id";
            dataGridView2.Columns[1].HeaderText = "Opening_time";
            dataGridView2.Columns[2].HeaderText = "Closing_time";
        }

        private void tabPage11_Enter(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.HeaderText = "";
            }
            dataGridView2.Columns[0].HeaderText = "Employee_id";
            dataGridView2.Columns[1].HeaderText = "Railway_station_fk";
            dataGridView2.Columns[2].HeaderText = "Position_fk";
            dataGridView2.Columns[3].HeaderText = "Name";
            dataGridView2.Columns[4].HeaderText = "Surname";
            dataGridView2.Columns[5].HeaderText = "Telephone";
            dataGridView2.Columns[6].HeaderText = "Year";
            dataGridView2.Columns[7].HeaderText = "Salary";
        }

        private void tabPage12_Enter(object sender, EventArgs e)
        {
            
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.HeaderText = "";
            }
            dataGridView2.Columns[0].HeaderText = "Position_id";
            dataGridView2.Columns[1].HeaderText = "Description";
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Ticket_type WHERE ticket_type_id = ?";

            if (dataGridView2.SelectedRows.Count == 1)
            {
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {
                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@ticket_type_id", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                            command.ExecuteNonQuery();
                        }

                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Customer WHERE customer_id = ?";

            if (dataGridView2.SelectedRows.Count == 1)
            {
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {
                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@customer_id", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                            command.ExecuteNonQuery();
                        }

                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Wagon WHERE wagon_id = ?";

            if (dataGridView2.SelectedRows.Count == 1)
            {
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {
                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@wagon_id", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                            command.ExecuteNonQuery();
                        }

                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Wagon_type WHERE wagon_type_id = ?";

            if (dataGridView2.SelectedRows.Count == 1)
            {
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {
                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@wagon_type_id", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                            command.ExecuteNonQuery();
                        }

                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Train WHERE train_id = ?";

            if (dataGridView2.SelectedRows.Count == 1)
            {
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {
                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@train_id", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                            command.ExecuteNonQuery();
                        }

                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Train_type WHERE train_type_id = ?";

            if (dataGridView2.SelectedRows.Count == 1)
            {
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {
                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@train_type_id", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                            command.ExecuteNonQuery();
                        }

                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Route WHERE direction_fk = ? AND railway_station_fk = ?";

            if (dataGridView2.SelectedRows.Count == 1)
            {
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {
                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@direction_fk", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                            command.Parameters.AddWithValue("@railway_station_fk", dataGridView2.SelectedRows[0].Cells[1].Value.ToString());
                            command.ExecuteNonQuery();
                        }

                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Direction WHERE idDirection = ?";

            if (dataGridView2.SelectedRows.Count == 1)
            {
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {
                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@idDirection", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                            command.ExecuteNonQuery();
                        }

                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Railway_station WHERE railway_station_id = ?";

            if (dataGridView2.SelectedRows.Count == 1)
            {
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {
                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@railway_station_id", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                            command.ExecuteNonQuery();
                        }

                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Employee WHERE employee_id = ?";

            if (dataGridView2.SelectedRows.Count == 1)
            {
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {
                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@employee_id", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                            command.ExecuteNonQuery();
                        }

                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Ticket WHERE ticket_id = ?";

            if (dataGridView2.SelectedRows.Count == 1)
            {
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {
                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@ticket_id", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                            command.ExecuteNonQuery();
                        }

                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Position WHERE position_id = ?";

            if (dataGridView2.SelectedRows.Count == 1)
            {
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {
                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@position_id", dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                            command.ExecuteNonQuery();
                        }

                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (ticket_type_id_text_box.Text != "" && decription_type_type_text_box.Text != "")
            {
                string query = "INSERT INTO Ticket_type VALUES (?,?)";
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@ticket_type_id", ticket_type_id_text_box.Text);
                            command.Parameters.AddWithValue("@description", decription_type_type_text_box.Text);

                            command.ExecuteNonQuery();
                        }
                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Не всі значення введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (Customer_customer_id_textbox.Text != "" && customer_name_textbox.Text != "" && customer_surname_textbox.Text != "" && customer_telephone_textbox.Text != "" && customer_year_textbox.Text != "")
            {
                string query = "INSERT INTO Customer VALUES (?,?,?,?,?)";
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@customer_id", Customer_customer_id_textbox.Text);
                            command.Parameters.AddWithValue("@name", customer_name_textbox.Text);
                            command.Parameters.AddWithValue("@surname", customer_surname_textbox.Text);
                            command.Parameters.AddWithValue("@telephone", customer_telephone_textbox.Text);
                            command.Parameters.AddWithValue("@year", customer_year_textbox.Text);

                            command.ExecuteNonQuery();
                        }
                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Не всі значення введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (Wagon_wagon_id_textbox.Text != "" && Wagon_number_seats_textbox.Text != "" && Wagon_wagon_type.Text != "" && Wagon_train_fk.Text != "")
            {
                string query = "INSERT INTO Wagon VALUES (?,?,?,?)";
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@wagon_id", Wagon_wagon_id_textbox.Text);
                            command.Parameters.AddWithValue("@number_seats", Wagon_number_seats_textbox.Text);
                            command.Parameters.AddWithValue("@wagon_type_fk", Wagon_wagon_type.Text);
                            command.Parameters.AddWithValue("@wagon_train_fk", Wagon_train_fk.Text);
                            command.ExecuteNonQuery();
                        }
                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Не всі значення введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (Wagon_type_wagon_type_id_textbox.Text != "" && Wagon_type_description_textbox.Text != "")
            {
                string query = "INSERT INTO Wagon_type VALUES (?,?)";
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@wagon_type_id", Wagon_type_wagon_type_id_textbox.Text);
                            command.Parameters.AddWithValue("@description", Wagon_type_description_textbox.Text);
                            command.ExecuteNonQuery();
                        }
                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Не всі значення введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (Train_train_id_textbox.Text != "" && Train_load_capacity_textbox.Text != "" && Train_railway_station_fk_textbox.Text != "" && Train_train_type_fk_textbox.Text != "")
            {
                string query = "INSERT INTO Train VALUES (?,?,?,?)";
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@train_id", Train_train_id_textbox.Text);
                            command.Parameters.AddWithValue("@load_capacity", Train_load_capacity_textbox.Text);
                            command.Parameters.AddWithValue("@railway_station_fk", Train_railway_station_fk_textbox.Text);
                            command.Parameters.AddWithValue("@train_type_fk", Train_train_type_fk_textbox.Text);
                            command.ExecuteNonQuery();
                        }
                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Не всі значення введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (Train_type_train_type_id_textbox.Text != "" && Train_type_description_textbox.Text != "")
            {
                string query = "INSERT INTO Train_type VALUES (?,?)";
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@train_type_id", Train_type_train_type_id_textbox.Text);
                            command.Parameters.AddWithValue("@description", Train_type_description_textbox.Text);
                            command.ExecuteNonQuery();
                        }
                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Не всі значення введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (Route_direction_fk_textbox.Text != "" && Route_railway_station_fk_textbox.Text != "" && Route_departure_time_textbox.Text != "" && Route_train_id_textbox.Text != "")
            {
                string query = "INSERT INTO Route VALUES (?,?,?,,?)";
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@direction_fk", Route_direction_fk_textbox.Text);
                            command.Parameters.AddWithValue("@railway_station_fk", Route_railway_station_fk_textbox.Text);
                            command.Parameters.AddWithValue("@departure_time", Route_departure_time_textbox.Text);
                            command.Parameters.AddWithValue("@train_id", Route_train_id_textbox.Text);
                            command.ExecuteNonQuery();
                        }
                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Route_direction_fk_textbox.Text != "" && Route_railway_station_fk_textbox.Text != "" && Route_arrival_time_textbox.Text != "" && Route_train_id_textbox.Text != "")
            {
                string query = "INSERT INTO Route VALUES (?,?,,?,?)";
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@direction_fk", Route_direction_fk_textbox.Text);
                            command.Parameters.AddWithValue("@railway_station_fk", Route_railway_station_fk_textbox.Text);
                            command.Parameters.AddWithValue("@arrival_time", Route_arrival_time_textbox.Text);
                            command.Parameters.AddWithValue("@train_id", Route_train_id_textbox.Text);
                            command.ExecuteNonQuery();
                        }
                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Не всі значення введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (Direction_Direction_id_textbox.Text != "" && Direction_description_textbox.Text != "")
            {
                string query = "INSERT INTO Direction VALUES (?,?)";
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@idDirection", Direction_Direction_id_textbox.Text);
                            command.Parameters.AddWithValue("@Description", Direction_description_textbox.Text);
                            command.ExecuteNonQuery();
                        }
                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Не всі значення введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (Railway_station_Railway_station_id_textbox.Text != "" && Railway_station_opening_time_textbox.Text != "" && Railway_station_closing_time_textbox.Text != "")
            {
                string query = "INSERT INTO RailwayStation VALUES (?,?,?)";
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@railway_station_id", Direction_Direction_id_textbox.Text);
                            command.Parameters.AddWithValue("@opening_time", Direction_description_textbox.Text);
                            command.Parameters.AddWithValue("@closing_time", Direction_description_textbox.Text);
                            command.ExecuteNonQuery();
                        }
                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Не всі значення введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (Employee_employee_id_texbox.Text != "" && Employee_railway_station_fk_textbox.Text != "" && Employee_position_fk_textbox.Text != "" && Employee_name_textbox.Text != ""
                 && Employee_surname_textbox.Text != "" && Employee_telephone_textbox.Text != "" && Employee_year_textbox.Text != "" && Employee_salary_textbox.Text != ""
                )
            {
                string query = "INSERT INTO Employee VALUES (?,?,?,?,?,?,?,?)";
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@employee_id", Employee_employee_id_texbox.Text);
                            command.Parameters.AddWithValue("@railway_station_fk", Employee_railway_station_fk_textbox.Text);
                            command.Parameters.AddWithValue("@position_fk", Employee_position_fk_textbox.Text);
                            command.Parameters.AddWithValue("@name", Employee_name_textbox.Text);
                            command.Parameters.AddWithValue("@surname", Employee_surname_textbox.Text);
                            command.Parameters.AddWithValue("@telephone", Employee_telephone_textbox.Text);
                            command.Parameters.AddWithValue("@year", Employee_year_textbox.Text);
                            command.Parameters.AddWithValue("@salary", Employee_salary_textbox.Text);
                            command.ExecuteNonQuery();
                        }
                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Не всі значення введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (Position_position_id_textbox.Text != "" && Position_description_textbox.Text != "")
            {
                string query = "INSERT INTO Position VALUES (?,?)";
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@idPosition", Position_position_id_textbox.Text);
                            command.Parameters.AddWithValue("@description", Position_description_textbox.Text);
                            command.ExecuteNonQuery();
                        }
                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Не всі значення введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (Ticket_ticket_id_textbox.Text != "" && Ticket_seat_textbox.Text != "" && Ticket_wagon_fk_text_box.Text != "" && Ticket_ticket_type_fk_textbox.Text != "" && Ticket_customer_fk_textbox.Text == "")
            {
                string query = "INSERT INTO Ticket VALUES (?,?,,?,?)";
                try
                {

                    using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                    {

                        DbConnection.Open();
                        using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                        {
                            command.Parameters.AddWithValue("@idPosition", Position_position_id_textbox.Text);
                            command.Parameters.AddWithValue("@description", Position_description_textbox.Text);
                            command.ExecuteNonQuery();
                        }
                    }
                    query = "";

                }
                catch (OdbcException exp)
                {
                    MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Не всі значення введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}

