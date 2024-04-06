using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.Odbc;
using System.Data.Common;

namespace PassprotDeskApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean security = true;
            // Отримуємо логін користувача з текстового поля textBox1
            string loginUser = textBox1.Text;
            // Ініціалізуємо змінні для збереження спроб паролю та паролю користувача
            string tryPassword ="";
            string passwordUser="";
            // Створюємо екземпляр алгоритму SHA256 для хешування пароля користувача
            SHA256 shaPasswordUser = SHA256.Create();
            // Конвертуємо введений користувачем пароль з форми в масив байтів
            byte[] b = Encoding.ASCII.GetBytes(textBox2.Text);
            // Хешуємо пароль користувача за допомогою алгоритму SHA256
            byte[] hash = shaPasswordUser.ComputeHash(b);
            // Створюємо об'єкт StringBuilder для збереження хешу паролю у вигляді рядка шістнадцяткових чисел
            StringBuilder sb = new StringBuilder();
            foreach (var a in hash)
                sb.Append(a.ToString("X2"));
            // Конвертуємо отриманий хеш паролю у рядок і зберігаємо його у змінній 
            passwordUser = Convert.ToString(sb);

            string query = "SELECT `password` FROM passport_desk.`User` WHERE `login`=?";

            try
            {

                using (OdbcConnection DbConnection = new OdbcConnection("DSN=RailwayStation"))
                {

                    DbConnection.Open();
                    using (OdbcCommand command = new OdbcCommand(query, DbConnection))
                    {
                        command.Parameters.AddWithValue("@login", textBox1.Text);
                        OdbcDataReader DbReader = command.ExecuteReader();
                        while (DbReader.Read())
                        {
                            tryPassword = DbReader[0].ToString();
                        }
                            
                    }
                }

                
                query = "";
            }
            catch (OdbcException exp)
            {
                MessageBox.Show(exp.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if ((loginUser == "admin") && (passwordUser.ToLower() == tryPassword))
            {
                security = false;
                
                Home homeWindow = new Home(security);
                homeWindow.Show();
                this.Hide();
            }
            else if((loginUser != "admin") && (passwordUser.ToLower() == tryPassword))
            {
                Home homeWindow = new Home(security);
                homeWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Дані не підходять", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Sign_Up signUpWindow = new Sign_Up();
            signUpWindow.Show();
            this.Hide();
        }
    }
}
