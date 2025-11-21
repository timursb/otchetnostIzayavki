using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace dnevnikApp
{
    public partial class FormRegister : Form
    {
        private string connectionString =
    @"Provider=Microsoft.ACE.OLEDB.12.0;
      Data Source=C:\Users\armyashka228\OneDrive\dnevnikApp — копия\dnevnik.accdb;";

        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string first = txtFirstName.Text.Trim();
            string last = txtLastName.Text.Trim();
            string login = txtLogin.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (first == "" || last == "" || login == "" || pass == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();

                string check = "SELECT COUNT(*) FROM Пользователи WHERE Логин=@l";
                OleDbCommand cmd = new OleDbCommand(check, conn);
                cmd.Parameters.AddWithValue("@l", login);
                int exists = (int)cmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("Такой логин уже есть!");
                    return;
                }

                string insert =
                    "INSERT INTO Пользователи (Логин, Пароль, Имя, Фамилия, Роль) " +
                    "VALUES (@l,@p,@f,@la,'ученик')";
                cmd = new OleDbCommand(insert, conn);
                cmd.Parameters.AddWithValue("@l", login);
                cmd.Parameters.AddWithValue("@p", pass);
                cmd.Parameters.AddWithValue("@f", first);
                cmd.Parameters.AddWithValue("@la", last);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Регистрация прошла успешно!");
                this.Close();
            }
        }
    }
}