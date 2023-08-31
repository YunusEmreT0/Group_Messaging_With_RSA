namespace GroupMessage
{
    partial class FormLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSignUp = new Button();
            lblHeader = new Label();
            btnLogin = new Button();
            lblPassword = new Label();
            lblUsername = new Label();
            tboxPassword = new TextBox();
            tboxUsername = new TextBox();
            lblError = new Label();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(0, 51, 102);
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.ForeColor = Color.FromArgb(240, 242, 243);
            btnSignUp.Location = new Point(747, 508);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(120, 40);
            btnSignUp.TabIndex = 18;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.Location = new Point(611, 204);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(261, 39);
            lblHeader.TabIndex = 17;
            lblHeader.Text = "Log In/Sign Up";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 51, 102);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.FromArgb(240, 242, 243);
            btnLogin.Location = new Point(617, 508);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 40);
            btnLogin.TabIndex = 16;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogIn_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(678, 417);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(107, 23);
            lblPassword.TabIndex = 15;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(677, 317);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(111, 23);
            lblUsername.TabIndex = 14;
            lblUsername.Text = "Username";
            // 
            // tboxPassword
            // 
            tboxPassword.BackColor = Color.FromArgb(240, 242, 243);
            tboxPassword.Location = new Point(617, 443);
            tboxPassword.Name = "tboxPassword";
            tboxPassword.PasswordChar = '*';
            tboxPassword.Size = new Size(250, 31);
            tboxPassword.TabIndex = 13;
            // 
            // tboxUsername
            // 
            tboxUsername.BackColor = Color.FromArgb(240, 242, 243);
            tboxUsername.Location = new Point(617, 343);
            tboxUsername.Name = "tboxUsername";
            tboxUsername.Size = new Size(250, 31);
            tboxUsername.TabIndex = 12;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(617, 570);
            lblError.Name = "lblError";
            lblError.Size = new Size(15, 23);
            lblError.TabIndex = 19;
            lblError.Text = " ";
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 230, 239);
            ClientSize = new Size(1482, 753);
            Controls.Add(lblError);
            Controls.Add(btnSignUp);
            Controls.Add(lblHeader);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(tboxPassword);
            Controls.Add(tboxUsername);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In/Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private Label lblHeader;
        private Button btnLogin;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox tboxPassword;
        private TextBox tboxUsername;
        private Label lblError;
    }
}