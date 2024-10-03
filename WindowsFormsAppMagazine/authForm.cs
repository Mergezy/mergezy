using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMagazine
{
    
    public partial class authForm : Form
    {
        public authForm()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(FormClosed_);
        }
        private void authBtnClick(object sender, EventArgs e)
        {
            string queryString = $"Select user_login, user_password, permission from users where user_login = '{loginTextBox.Text}'";
            //SELECT user_login, user_password, permission FROM users WHERE user_login = ;  
            //string queryString = $"insert into users (user_login,user_password,permission) values ('login','{md5.hashPassword("password")}','user')";
            try
            {
                using (SqlConnection conn = dbConnector.getConnect())
                {
                    SqlCommand command = new SqlCommand(queryString, conn);
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                md5 md5 = new md5();
                                string user_login = reader["user_login"].ToString();
                                string user_password = reader["user_password"].ToString();
                                string permission = reader["permission"].ToString();
                                if (user_password == md5.hashPassword(passTextBox.Text) && user_login == loginTextBox.Text && permission == "admin")
                                {
                                    mainMenuForm mmf = new mainMenuForm();
                                    mmf.Show();
                                    this.Hide();
                                }
                                else if(permission == "user"||permission!="admin")
                                {
                                    MessageBox.Show("Have no permission");
                                }
                                else
                                {
                                    MessageBox.Show("Wrong login or password");
                                }
                            }
                        }
                        else { MessageBox.Show("Wrong login or password"); }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
            //MessageBox.Show($"{ex}");
            //loginTextBox.Text = ex.ToString();
        }
        private void toRegisterLink(object sender, EventArgs e)
        {
            regForm rf = new regForm();
            this.Hide();
            rf.ShowDialog();
            this.Show();
        }

        private void passVisibility_CheckedChanged(object sender, EventArgs e)
        {
            if (passVisibility.Checked == true)
                passTextBox.UseSystemPasswordChar = false;
            if (passVisibility.Checked == false)
                passTextBox.UseSystemPasswordChar = true;
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void FormClosed_(object sender, FormClosedEventArgs e)
        {
            Application.Exit();  
        }
    }
}
