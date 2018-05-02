using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAM_P_PROGII
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static bool optionCheck = true;

        private void loginButton_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\data_base\noliktavasDB.mdb";

            conn.Open();
            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = conn;

            var loginType = optionCheck ? "LoginAdmin" : "loginParzinis";

            cmd.CommandText = "SELECT[username] ,[password] FROM[" + loginType + "]";
            OleDbDataReader reader = cmd.ExecuteReader();

            reader.Read();

            var inputUser = (reader["Username"].ToString());
            var inputPass = (reader["Password"].ToString());

            if (username.Text == inputUser && password.Text == inputPass)
            {
                if (loginType == "loginParzinis")
                {
                    var parzinis = new ParzinisForm();
                    parzinis.Show();
                    Hide();
                }
                else
                {
                    var admin = new AdminForm();
                    admin.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Enter valid user data");
            }

            conn.Close();
        }

        private void loginCheck_CheckedChanged(object sender, EventArgs e)
        {
            optionCheck = loginCheck.Checked;
        }
    }
}
