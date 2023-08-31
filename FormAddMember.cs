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

namespace GroupMessage
{
    public partial class FormAddMember : Form
    {
        SqlConnection conn = new SqlConnection(Helpers.sqlConnPath);
        private int groupid;

        public FormAddMember(int groupid)
        {
            InitializeComponent();
            this.groupid = groupid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblError.Text = " ";
            if (tboxUsername.Text.Length > 16 || tboxUsername.Text.Length < 4)
            {
                lblError.Text = "Username must be between 4-16 characters!";
            }
            else
            {
                conn.Open();

                SqlDataReader reader1 =
                    Helpers.SqlReader("select username from users where username = '" + tboxUsername.Text + "';", conn);

                if (!reader1.Read())
                {
                    reader1.Close();
                    lblError.Text = "User name doesn't exists!";
                }
                else
                {
                    int userid = Convert.ToInt32(reader1.GetValue(0));
                    reader1.Close();

                    SqlDataReader reader2 =
                        Helpers.SqlReader("select * from members where userid = " + userid + " and groupid = " + groupid + ";", conn);

                    if (reader2.Read())
                    {
                        reader2.Close();
                        lblError.Text = "This user is already a member!";
                    }
                    else
                    {
                        reader2.Close();
                        Helpers.SqlInserter("insert into members values(" + userid + ", " + groupid + ");", conn);
                        lblError.Text = "User successfully added.";
                    }
                }
                conn.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}