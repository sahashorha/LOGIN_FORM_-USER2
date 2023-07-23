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

namespace User2
{
    public partial class Login1_form : Form
    {

        static SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BGCUAFMN\SQLEXPRESS;Initial Catalog=user2;Integrated Security=True");
        static SqlCommand scmd;
        public Login1_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterBTn_Click(object sender, EventArgs e)
        {
            Register_form frm = new Register_form();
            frm.ShowDialog();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            bool isUserOk = false, isPasswordOk = false;
            if (!Authenticate())
            {
                MessageBox.Show("Do not keep ant textBox Blank");
                PassTbox.Clear();
                UserTbox.Clear();
                return;
            }
            string query = ("SELECT * FROM login WHERE USERNAME = @USERNAME");
            con.Open();
            scmd = new SqlCommand(query, con);
            // adding parameters 


            scmd.Parameters.Add("@USERNAME", SqlDbType.VarChar);
            scmd.Parameters["@USERNAME"].Value = UserTbox.Text;
            SqlDataReader sda = scmd.ExecuteReader();

            if (sda.HasRows)
            {
                isUserOk = true;
            }

            con.Close();


            con.Open();
            query = "SELECT * FROM login WHERE USERNAME = @USERNAME AND PASSCODE=@PASSCODE";
            scmd = new SqlCommand(query, con);
            // adding parameters 


            scmd.Parameters.Add("@USERNAME", SqlDbType.VarChar);
            scmd.Parameters["@USERNAME"].Value = UserTbox.Text;

            scmd.Parameters.Add("@PASSCODE", SqlDbType.VarChar);
            scmd.Parameters["@PASSCODE"].Value = PassTbox.Text;
            sda = scmd.ExecuteReader();
            if (sda.HasRows)
            {
                isPasswordOk = true;
            }
            if (isUserOk == false)
            {
                MessageBox.Show("User Does Not Exist");
            }
            else if (isUserOk == true && isPasswordOk == false)
            {
                MessageBox.Show("Password Not Correct");
            }
            else
            {
                Hide();
                MessageBox.Show("Login Successfully");
                AppForm appForm = new AppForm();
                appForm.ShowDialog();
                Close();
            }
            con.Close();
        }
        bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(UserTbox.Text)
                || string.IsNullOrWhiteSpace(PassTbox.Text)) { return false; }
            else { return true; }
        }
    }
}
