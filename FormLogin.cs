using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace dnevnikApp
{
    public partial class FormLogin : Form
    {
        string connectionString =
            @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dnevnik.mdb;";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (login == "director" && password == "12345")
            {
                FormMain fm = new FormMain("директор", login);
                fm.Show();
                this.Hide();
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Роль FROM Пользователи WHERE Логин=@l AND Пароль=@p";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@l", login);
                    cmd.Parameters.AddWithValue("@p", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();
                        FormMain fm = new FormMain(role, login); 
                        fm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка базы данных: " + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister reg = new FormRegister();
            reg.ShowDialog();
        }
    }
}