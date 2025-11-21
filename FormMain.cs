using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace dnevnikApp
{
    public partial class FormMain : Form
    {
        private string connectionString =
    @"Provider=Microsoft.ACE.OLEDB.12.0;
      Data Source=C:\Users\armyashka228\OneDrive\dnevnikApp — копия\dnevnik.accdb;";

        private OleDbDataAdapter adapter;
        private DataTable table;
        private string role;
        private string login;

        public FormMain(string userRole, string userLogin)
        {
            InitializeComponent();
            role = userRole;
            login = userLogin;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblRole.Text = "Роль: " + role;
            btnSave.Visible = role == "директор";
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query;

                    if (role == "директор")
                    {
                        query = "SELECT [id_записи], [Предмет], [Оценка], [Комментарий] FROM [Оценки]";
                        adapter = new OleDbDataAdapter(query, conn);
                    }
                    else
                    {
                        query = @"SELECT [Оценки].[id_записи],
                                         [Оценки].[Предмет],
                                         [Оценки].[Оценка],
                                         [Оценки].[Комментарий]
                                  FROM [Оценки]
                                  INNER JOIN [Пользователи]
                                    ON [Оценки].[id_пользователя] = [Пользователи].[id_пользователя]
                                  WHERE [Пользователи].[Логин] = @login";
                        OleDbCommand cmd = new OleDbCommand(query, conn);
                        cmd.Parameters.AddWithValue("@login", login);
                        adapter = new OleDbDataAdapter(cmd);
                    }

                    table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                    if (dataGridView1.Columns.Count > 0)
                        dataGridView1.Columns[0].Visible = false;

                    dataGridView1.ReadOnly = role != "директор";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (adapter == null || table == null)
            {
                MessageBox.Show("Нет данных для сохранения.");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    adapter.SelectCommand.Connection = conn;

                    OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                    adapter.Update(table);
                }

                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}