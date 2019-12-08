using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class FormLoginAdd : Form
    {
        public FormLoginAdd()
        {
            InitializeComponent();
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
            if (nameField.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля!");
                nameField.ForeColor = Color.Red;
                return;
            }
            else
                nameField.ForeColor = Color.Black;

            if (surnameField.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля!");
                surnameField.ForeColor = Color.Red;
                return;
            }
            else
                surnameField.ForeColor = Color.Black;

            if (profField.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля!");
                profField.ForeColor = Color.Red;
                return;
            }
            else
                profField.ForeColor = Color.Black;

            if (usernameField.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля!");
                usernameField.ForeColor = Color.Red;
                return;
            }
            else
                usernameField.ForeColor = Color.Black;

            if (emailField.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля!");
                emailField.ForeColor = Color.Red;
                return;
            }
            else
                emailField.ForeColor = Color.Black;

            if (passField.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля!");
                passField.ForeColor = Color.Red;
                return;
            }
            else
                passField.ForeColor = Color.Black;

            if (passField.Text != pass2Field.Text)
            {
                MessageBox.Show("Пароль не совпадает!");
                passField.ForeColor = Color.Red;
                pass2Field.ForeColor = Color.Red;
                return;
            }
            else
            {
                passField.ForeColor = Color.Black;
                pass2Field.ForeColor = Color.Black;
            }

            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`, `profession`, `email`) VALUES (@login, @pass, @name, @surname, @prof, @email)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = usernameField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnameField.Text;
            command.Parameters.Add("@prof", MySqlDbType.VarChar).Value = profField.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт добавлен!\nТеперь войдите в программу используя ваш логин и пароль.");
                FormLogin formLogin = new FormLogin();
                this.Hide();
                formLogin.Show();
            }
            else
                MessageBox.Show("Аккаунт не добавлен");

            db.closeConnection();
        }

        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = usernameField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже зарегестрирован!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void FormLoginAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.Show();
        }
    }
}
