using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Net.Pkcs11Interop.Common;
using Net.Pkcs11Interop.HighLevelAPI;
using System.Net.NetworkInformation;
using System.Security.Claims;

namespace GroupMessage
{
    public partial class FormCreateGroup : Form
    {
        SqlConnection conn = new SqlConnection(Helpers.sqlConnPath);
        private int userid;

        public FormCreateGroup(int userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tboxGroupName.Text.Length > 16 || tboxPassword.Text.Length > 16 || tboxGroupName.Text.Length < 4 || tboxPassword.Text.Length < 4)
            {
                lblError.Text = "Name and password should be in between 4-16 characters!";
            }
            else
            {
                conn.Open();
                SqlDataReader reader1 =
                    Helpers.SqlReader("select groupname from groups where groupname = '" + tboxGroupName.Text + "';", conn);

                if (!reader1.Read())
                {
                    reader1.Close();

                    Helpers.Pkcs11TokenGenerater(tboxPassword.Text, tboxGroupName.Text);
                    Helpers.Pkcs11RSAKeyGenerator(tboxPassword.Text, tboxGroupName.Text);

                    Helpers.SqlInserter("insert into groups values('" + tboxGroupName.Text
                        + "', '" + tboxGroupName.Text + "', '" + tboxPassword.Text + "', 'Public', 'Private', " + userid + ");", conn);

                    SqlDataReader reader2 =
                        Helpers.SqlReader("select groupid from groups where groupname = '" + tboxGroupName.Text + "';", conn);
                    reader2.Read();
                    int groupId = Convert.ToInt32(reader2.GetValue(0));
                    reader2.Close();

                    Helpers.SqlInserter("insert into members values(" + userid + ", " + groupId + ");", conn);

                    FormMain.refreshGroups = true;
                    this.Dispose();
                }
                else
                {
                    reader1.Close();
                    lblError.Text = "Group name is taken!";
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