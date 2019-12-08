using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_MouseHover(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.FromArgb(178, 8, 55);
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.DimGray;
        }

        private void buttonAddUser_MouseHover(object sender, EventArgs e)
        {
            buttonAddUser.BackColor = Color.FromArgb(178, 8, 55);
        }

        private void buttonAddUser_MouseLeave(object sender, EventArgs e)
        {
            buttonAddUser.BackColor = Color.DimGray;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            FormLoginAdd formLoginAdd = new FormLoginAdd();
            this.Hide();
            formLoginAdd.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                FormMain formMain = new FormMain();
                this.Hide();
                formMain.Show();
            }
            else
            {
                MessageBox.Show("Неверные имя пользователя или пароль!");
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
