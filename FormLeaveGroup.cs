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
    public partial class FormLeaveGroup : Form
    {
        SqlConnection conn = new SqlConnection(Helpers.sqlConnPath);
        private int userid;
        private int groupid;

        public FormLeaveGroup(int userid, int groupid)
        {
            InitializeComponent();
            this.userid = userid;
            this.groupid = groupid;

            conn.Open();
            SqlDataReader reader = Helpers.SqlReader("select groupname from groups where groupid = " + groupid + ";", conn);
            reader.Read();

            lblMessage.Text = "Are you sure you want to leave \n    '" + reader.GetValue(0).ToString() + "'?";
            reader.Close();
            conn.Close();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            conn.Open();
            Helpers.SqlInserter("delete from members where userid = " + userid + " and groupid = " + groupid + ";", conn);

            FormMain.refreshGroups = true;
            this.Dispose();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}