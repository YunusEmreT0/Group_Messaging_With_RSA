namespace GroupMessage
{
    partial class FormCreateGroup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreate = new Button();
            btnCancel = new Button();
            tboxGroupName = new TextBox();
            lblHeader = new Label();
            lblGroupName = new Label();
            lblError = new Label();
            lblPassword = new Label();
            tboxPassword = new TextBox();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(0, 51, 102);
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.ForeColor = Color.FromArgb(240, 242, 243);
            btnCreate.Location = new Point(96, 468);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(145, 40);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 51, 102);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(240, 242, 243);
            btnCancel.Location = new Point(259, 468);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // tboxGroupName
            // 
            tboxGroupName.BackColor = Color.FromArgb(240, 242, 243);
            tboxGroupName.Location = new Point(96, 284);
            tboxGroupName.Name = "tboxGroupName";
            tboxGroupName.Size = new Size(308, 31);
            tboxGroupName.TabIndex = 2;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.Location = new Point(96, 237);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(308, 32);
            lblHeader.TabIndex = 3;
            lblHeader.Text = "Enter the Group Name";
            // 
            // lblGroupName
            // 
            lblGroupName.AutoSize = true;
            lblGroupName.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblGroupName.Location = new Point(128, 128);
            lblGroupName.Name = "lblGroupName";
            lblGroupName.Size = new Size(243, 39);
            lblGroupName.TabIndex = 4;
            lblGroupName.Text = "Create Group";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(96, 533);
            lblError.Name = "lblError";
            lblError.Size = new Size(15, 23);
            lblError.TabIndex = 5;
            lblError.Text = " ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(177, 357);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(145, 32);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // tboxPassword
            // 
            tboxPassword.BackColor = Color.FromArgb(240, 242, 243);
            tboxPassword.Location = new Point(96, 404);
            tboxPassword.Name = "tboxPassword";
            tboxPassword.PasswordChar = '*';
            tboxPassword.Size = new Size(308, 31);
            tboxPassword.TabIndex = 6;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 230, 239);
            ClientSize = new Size(494, 753);
            Controls.Add(lblPassword);
            Controls.Add(tboxPassword);
            Controls.Add(lblError);
            Controls.Add(lblGroupName);
            Controls.Add(lblHeader);
            Controls.Add(tboxGroupName);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Group";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnCancel;
        private TextBox tboxGroupName;
        private Label lblHeader;
        private Label lblGroupName;
        private Label lblError;
        private Label lblPassword;
        private TextBox tboxPassword;
    }
}