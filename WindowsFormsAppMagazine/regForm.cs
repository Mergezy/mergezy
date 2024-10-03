using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMagazine
{
    public partial class regForm : Form
    {
        
        public regForm()
        {
            InitializeComponent();

            passTextBox1.UseSystemPasswordChar = true;
            passTextBox2.UseSystemPasswordChar = true;
        }
        private void regBtnClick(object sender, EventArgs e)
        {
            md5 md5 = new md5();
            string hash = md5.hashPassword(passTextBox1.Text);
            string queryString = $"insert into users (user_login,user_password,permission) values ('{loginTextBox.Text}','{hash}','user')";
            string queryStringLogin = $"Select user_login from users where user_login = '{loginTextBox.Text}'";
            if (passTextBox1.Text == passTextBox2.Text)
            {
                try
                {
                    using (SqlConnection conn = dbConnector.getConnect())
                    {
                        conn.Open();

                        SqlCommand commandL = new SqlCommand(queryStringLogin, conn);
                        using (SqlDataReader reader = commandL.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (loginTextBox.Text == reader["user_login"].ToString())
                                    {
                                        MessageBox.Show("This login is already in use");
                                        return;
                                    }
                                }
                            }
                        }
                        using (SqlCommand command = new SqlCommand(queryString, conn))
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Successfully registered");
                            }
                            else
                            {
                                MessageBox.Show("Something wrong error");
                            }
                        }

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }
            else
            {
                MessageBox.Show("Passwords don't match");
            }
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void passVisibility_CheckedChanged(object sender, EventArgs e)
        {
            if (passVisibility.Checked == false)
            {
                passTextBox1.UseSystemPasswordChar = true;
                passTextBox2.UseSystemPasswordChar = true;
            }
            else if (passVisibility.Checked == true)
            {
                passTextBox1.UseSystemPasswordChar = false;
                passTextBox2.UseSystemPasswordChar = false;
            }
        }
    }
}
