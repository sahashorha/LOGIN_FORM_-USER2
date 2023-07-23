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
    public partial class Register_form : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BGCUAFMN\SQLEXPRESS;Initial Catalog=user2;Integrated Security=True");
        static SqlCommand scmd;
        public Register_form()
        {
            InitializeComponent();
        }

        private void RegisterBTn_Click(object sender, EventArgs e)
        {
            if (!Authenticate())
            {
                MessageBox.Show("Do not keep ant textBox Blank");
                NameTbox.Clear();
                PassTbox.Clear();
                UserTbox.Clear();
                return;
            }
            string query = ("INSERT INTO login VALUES(@USERNAME,@PASSCODE,@NAME_,@GENDER,@DOB)");
            con.Open();
            scmd = new SqlCommand(query, con);
            // adding parameters 


            scmd.Parameters.Add("@USERNAME", SqlDbType.VarChar);
            scmd.Parameters["@USERNAME"].Value = UserTbox.Text;

            scmd.Parameters.Add("@PASSCODE", SqlDbType.VarChar);
            scmd.Parameters["@PASSCODE"].Value = PassTbox.Text;

            scmd.Parameters.Add("@NAME_", SqlDbType.VarChar);
            scmd.Parameters["@NAME_"].Value = NameTbox.Text;

            scmd.Parameters.Add("@GENDER", SqlDbType.VarChar);
            scmd.Parameters["@GENDER"].Value = GenderCbox.Text;

            scmd.Parameters.Add("@DOB", SqlDbType.VarChar);
            scmd.Parameters["@DOB"].Value = dateTimePicker1.Text;
            scmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registration Successfully");
            Hide();
            Login1_form login1_Form = new Login1_form();
            login1_Form.ShowDialog();
            Close();


        }
        bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(UserTbox.Text) || string.IsNullOrWhiteSpace(NameTbox.Text)
                || string.IsNullOrWhiteSpace(PassTbox.Text)) { return false; }
            else { return true; }
        }

        private void Register_form_Load(object sender, EventArgs e)
        {

        }
    }
}
