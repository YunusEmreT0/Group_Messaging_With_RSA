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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GroupMessage
{
    public partial class FormMain : Form
    {
        SqlConnection conn = new SqlConnection(Helpers.sqlConnPath);
        List<string> filenames = new List<string>();
        private int userid;
        private int selectedgroup;
        public static bool refreshGroups = false;
        public static bool refreshMessages = false;

        public FormMain(int userid, string username)
        {
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.userid = userid;
            lblGroups.Text = username + "'s Groups";

            conn.Open();
            SqlDataReader reader = Helpers.SqlReader("select g.groupname from members m, groups g where m.userid = '"
                + userid + "' and m.groupid = g.groupid;", conn);

            while (reader.Read())
            {
                lboxGroups.Items.Add(reader.GetString(0));
            }
            reader.Close();

            Thread thread1 = new Thread(RefreshGroups);
            thread1.Start();

            Thread thread2 = new Thread(RefreshMessages);
            thread2.Start();
        }

        private void RefreshGroups()
        {
            while (true)
            {
                if (refreshGroups)
                {
                    btnSendMessage.Hide(); btnAddMember.Hide(); btnLeaveGroup.Hide(); btnMembers.Hide();
                    tboxMessage.Clear(); lboxMessages.Items.Clear();
                    lblMessageList.Text = "Group's Messages"; lblMessage.Text = "Message";

                    SqlDataReader reader = Helpers.SqlReader("select g.groupname from members m, groups g where m.userid = '"
                        + userid + "' and m.groupid = g.groupid;", conn);

                    lboxGroups.Items.Clear();
                    while (reader.Read())
                    {
                        lboxGroups.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                    refreshGroups = false;
                }
                Thread.Sleep(1000);
            }
        }
        private void RefreshMessages()
        {
            while (true)
            {
                if (refreshMessages)
                {
                    tboxMessage.Clear(); lblMessage.Text = "Message"; filenames.Clear();

                    SqlDataReader reader = Helpers.SqlReader("select m.topic, m.filenames, u.username " +
                        "from messagestxt m, users u where m.groupid = " + selectedgroup + " and m.userid = u.userid;", conn);

                    lboxMessages.Items.Clear();
                    while (reader.Read())
                    {
                        lboxMessages.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(2).ToString());
                        filenames.Add(reader.GetValue(1).ToString());
                    }
                    reader.Close();
                    refreshMessages = false;
                }
                Thread.Sleep(1000);
            }
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogIn form = new FormLogIn();
            form.Show();
            this.Dispose();
        }
        private void btnMembers_Click(object sender, EventArgs e)
        {
            FormMembers form = new FormMembers(selectedgroup);
            form.Show();
        }
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            FormAddMember form = new FormAddMember(selectedgroup);
            form.Show();
        }
        private void btnLeaveGroup_Click(object sender, EventArgs e)
        {
            FormLeaveGroup form = new FormLeaveGroup(userid, selectedgroup);
            form.Show();
        }
        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            FormCreateGroup form = new FormCreateGroup(userid);
            form.Show();
        }
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            FormSendMessage form = new FormSendMessage(userid, selectedgroup);
            form.Show();
        }
        private void lboxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "Message"; tboxMessage.Clear();
            lboxMessages.Items.Clear();
            filenames.Clear();

            SqlDataReader reader1 = Helpers.SqlReader("select * from groups where groupname = '"
                + lboxGroups.SelectedItem.ToString() + "';", conn);
            reader1.Read();

            if (Convert.ToUInt32(reader1.GetValue(3)) == userid)
                btnAddMember.Visible = true;
            else
                btnAddMember.Visible = false;

            selectedgroup = Convert.ToInt32(reader1.GetValue(0));
            lblMessageList.Text = reader1.GetValue(1).ToString() + "'s Messages";
            reader1.Close();

            btnSendMessage.Visible = true;
            btnLeaveGroup.Visible = true;
            btnMembers.Visible = true;

            SqlDataReader reader2 = Helpers.SqlReader("select m.topic, m.filenames, u.username from messagestxt m, " +
                "users u where m.groupid = " + selectedgroup + " and m.userid = u.userid;", conn);

            while (reader2.Read())
            {
                lboxMessages.Items.Add(reader2.GetValue(0).ToString() + " - " + reader2.GetValue(2).ToString());
                filenames.Add(reader2.GetValue(1).ToString());
            }
            reader2.Close();
        }
        private void lboxMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMessage.Text = lboxMessages.SelectedItem.ToString();

            SqlDataReader reader = Helpers.SqlReader("select groupname,tokenpassword from groups where groupid = " + selectedgroup + ";", conn);
            reader.Read();
            string label = reader.GetValue(0).ToString();
            string password = reader.GetValue(1).ToString();
            reader.Close();

            tboxMessage.Text = Helpers.Pkcs11RSADecrypter(label, password, filenames, lboxMessages.SelectedIndex);
        }
    }
}