using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormMembers : Form
    {
        SqlConnection conn = new SqlConnection(Helpers.sqlConnPath);
        private int groupid;
        public FormMembers(int groupid)
        {
            InitializeComponent();
            this.groupid = groupid;

            conn.Open();

            SqlDataReader reader = Helpers.SqlReader("select u.username from members m, " +
                "users u where m.userid = u.userid and m.groupid = " + groupid + ";", conn);

            while (reader.Read())
            {
                lboxMembers.Items.Add(reader.GetString(0));
            }
            reader.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}