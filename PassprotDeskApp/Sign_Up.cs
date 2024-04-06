using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace PassprotDeskApp
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdbcConnection DbConnection = new OdbcConnection("DSN=passport_desk");
            int a;
            string query = "INSERT INTO passport_desk.`User` (`login`,`password`) VALUES (?, SHA2(?,256));";
            OdbcCommand command = new OdbcCommand(query, DbConnection);
            try
            {

                using (DbConnection)
                {

                    DbConnection.Open();
                    using (command)
                    {
                        command.Parameters.AddWithValue("@login", textBox1.Text);
                        command.Parameters.AddWithValue("@password", textBox2.Text);
                        command.ExecuteNonQuery();
                    }

                }
                query = "";
                Form ifrm = Application.OpenForms[0];
                ifrm.Show();
                this.Hide();

            }
            catch (OdbcException exp)
            {
                MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
