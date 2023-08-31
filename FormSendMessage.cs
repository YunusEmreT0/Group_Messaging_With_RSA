using Net.Pkcs11Interop.Common;
using Net.Pkcs11Interop.HighLevelAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupMessage
{
    public partial class FormSendMessage : Form
    {
        SqlConnection conn = new SqlConnection(Helpers.sqlConnPath);
        private int userid;
        private int groupid;

        public FormSendMessage(int userid, int groupid)
        {
            InitializeComponent();
            this.userid = userid;
            this.groupid = groupid;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            lblError.Text = " ";
            if (tboxTopic.Text.Length < 4 || tboxTopic.Text.Length > 32)
            {
                lblError.Text = "Topic must be between 4-16 characters!";
            }
            else if (tboxFile.Text.Length < 4 || tboxFile.Text.Length > 32)
            {
                lblError.Text = "Filename must be between 4-16 characters!";
            }
            else if (tboxMessage.Text.Length < 4)
            {
                lblError.Text = "Message must be minimum 4 characters!";
            }
            else
            {
                conn.Open();
                SqlDataReader reader1 =
                    Helpers.SqlReader("select filenames from messagestxt where filenames = '" + tboxFile.Text + ".txt';", conn);
                if (reader1.Read())
                {
                    reader1.Close();
                    lblError.Text = "Filename already exists!";
                }
                else
                {
                    reader1.Close();

                    SqlDataReader reader2 = Helpers.SqlReader("select groupname from groups where groupid = " + groupid + ";", conn);
                    reader2.Read();
                    string label = reader2.GetValue(0).ToString();
                    reader2.Close();

                    Helpers.Pkcs11RSAEncrypter(label, tboxMessage.Text, tboxFile.Text);

                    Helpers.SqlInserter("insert into messagestxt values(" + userid +
                        ", " + groupid + ", '" + tboxFile.Text + ".txt', '" + tboxTopic.Text + "');", conn);

                    FormMain.refreshMessages = true;
                    lblError.Text = "Message successfully sent!";
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