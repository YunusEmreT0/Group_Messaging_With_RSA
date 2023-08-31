namespace GroupMessage
{
    partial class FormAddMember
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
            tboxUsername = new TextBox();
            lblHeader = new Label();
            lblUsername = new Label();
            lblError = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tboxUsername
            // 
            tboxUsername.BackColor = Color.FromArgb(240, 242, 243);
            tboxUsername.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tboxUsername.Location = new Point(92, 190);
            tboxUsername.Margin = new Padding(4, 3, 4, 3);
            tboxUsername.Name = "tboxUsername";
            tboxUsername.Size = new Size(308, 31);
            tboxUsername.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.Location = new Point(156, 45);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(181, 32);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Add Member";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(118, 140);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(257, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username of the Member";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(41, 322);
            lblError.Margin = new Padding(4, 0, 4, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(15, 23);
            lblError.TabIndex = 3;
            lblError.Text = " ";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 51, 102);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.FromArgb(240, 242, 243);
            btnAdd.Location = new Point(92, 250);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 40);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 51, 102);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(240, 242, 243);
            btnCancel.Location = new Point(255, 250);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 230, 239);
            ClientSize = new Size(494, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(lblError);
            Controls.Add(lblUsername);
            Controls.Add(lblHeader);
            Controls.Add(tboxUsername);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Member";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxUsername;
        private Label lblHeader;
        private Label lblUsername;
        private Label lblError;
        private Button btnAdd;
        private Button btnCancel;
    }
}