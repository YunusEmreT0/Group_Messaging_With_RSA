using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace GroupMessage
{
    public partial class FormLogIn : Form
    {
        SqlConnection conn = new SqlConnection(Helpers.sqlConnPath);
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (tboxUsername.Text.Length < 4 || tboxPassword.Text.Length < 4 || tboxUsername.Text.Length > 16 || tboxPassword.Text.Length > 16)
            {
                lblError.Text = "Username or password is very short or very long!\nEnter between 4-16 characters.";
            }
            else
            {
                conn.Open();

                SqlDataReader reader =
                    Helpers.SqlReader("select * from users where username = '" + tboxUsername.Text
                    + "' and userpassword = '" + Helpers.MD5Encrypter(tboxPassword.Text) + "';", conn);

                if (reader.Read())
                {
                    this.Hide();
                    FormMain form = new FormMain(Convert.ToInt32(reader.GetValue(0)), tboxUsername.Text);
                    form.Show();
                }
                else
                {
                    lblError.Text = "Username or password is wrong!";
                }
                reader.Close();
                conn.Close();
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tboxUsername.Text.Length < 4 || tboxPassword.Text.Length < 4 || tboxUsername.Text.Length > 16 || tboxPassword.Text.Length > 16)
            {
                lblError.Text = "Username or password is very short or very long!\nEnter between 4-16 characters.";
            }
            else
            {
                conn.Open();

                SqlDataReader reader1 =
                    Helpers.SqlReader("select userid from users where username = '" + tboxUsername.Text + "';", conn);

                if (!reader1.Read())
                {
                    reader1.Close();

                    Helpers.SqlInserter("insert into users values('" + tboxUsername.Text +
                        "', '" + Helpers.MD5Encrypter(tboxPassword.Text) + "');", conn);

                    SqlDataReader reader2 =
                        Helpers.SqlReader("select userid from users where username = '" + tboxUsername.Text + "';", conn);
                    reader2.Read();

                    FormMain form2 = new FormMain(Convert.ToInt32(reader2.GetValue(0)), tboxUsername.Text);
                    form2.Show();
                    reader2.Close();
                    this.Hide();
                }
                else
                {
                    reader1.Close();
                    lblError.Text = "Username is taken!";
                }
                conn.Close();
            }
        }
    }
}