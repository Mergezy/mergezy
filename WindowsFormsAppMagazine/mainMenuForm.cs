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
using System.Xml;

namespace WindowsFormsAppMagazine
{
    public partial class mainMenuForm : Form
    {
        dbConnector connector = new dbConnector();
        md5 md5 = new md5();
        authForm af = new authForm();
        DataTable dt = new DataTable();

        public mainMenuForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(FormClosing_);

            // Инициализация DataGridView
            dt.Columns.Add(new DataColumn("ID", typeof(string)));
            dt.Columns.Add(new DataColumn("login", typeof(string)));
            dt.Columns.Add(new DataColumn("password", typeof(string)));
            dt.Columns.Add(new DataColumn("permission", typeof(string)));
            dataGridDB.DataSource = dt;
            groupBox1.Text = " ";

            passVisibility_CheckedChanged();
        }

        private int _sliderCount = 1;
        private void FormClosing_(object sender, FormClosingEventArgs e)
        {
            authForm af = new authForm();
            af.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void authBtnClick(object sender, EventArgs e)
        {
        }
        private void toRegisterLink(object sender, EventArgs e)
        {

        }

        private void passVisibility_CheckedChanged()
        {
            string queryString = "SELECT id,user_login,user_password,permission FROM users";
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
                                dt.Rows.Add(
                                    reader["id"].ToString(),
                                    reader["user_login"].ToString(),
                                    reader["user_password"].ToString(),
                                    reader["permission"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
