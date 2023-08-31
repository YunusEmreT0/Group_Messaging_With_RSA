namespace GroupMessage
{
    partial class FormMain
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
            pnlMessageList = new Panel();
            btnAddMember = new Button();
            lboxMessages = new ListBox();
            lblMessageList = new Label();
            btnSendMessage = new Button();
            pnlMessage = new Panel();
            btnLeaveGroup = new Button();
            btnMembers = new Button();
            lblMessage = new Label();
            tboxMessage = new TextBox();
            lboxGroups = new ListBox();
            btnLogOut = new Button();
            btnCreateGroup = new Button();
            lblGroups = new Label();
            pnlMessageList.SuspendLayout();
            pnlMessage.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMessageList
            // 
            pnlMessageList.BackColor = Color.FromArgb(113, 177, 197);
            pnlMessageList.Controls.Add(btnAddMember);
            pnlMessageList.Controls.Add(lboxMessages);
            pnlMessageList.Controls.Add(lblMessageList);
            pnlMessageList.Controls.Add(btnSendMessage);
            pnlMessageList.Location = new Point(494, 0);
            pnlMessageList.Name = "pnlMessageList";
            pnlMessageList.Size = new Size(494, 753);
            pnlMessageList.TabIndex = 0;
            // 
            // btnAddMember
            // 
            btnAddMember.BackColor = Color.FromArgb(0, 51, 102);
            btnAddMember.FlatAppearance.BorderSize = 0;
            btnAddMember.FlatStyle = FlatStyle.Flat;
            btnAddMember.ForeColor = Color.FromArgb(240, 242, 243);
            btnAddMember.Location = new Point(253, 12);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(229, 60);
            btnAddMember.TabIndex = 8;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = false;
            btnAddMember.Visible = false;
            btnAddMember.Click += btnAddMember_Click;
            // 
            // lboxMessages
            // 
            lboxMessages.BackColor = Color.FromArgb(240, 242, 243);
            lboxMessages.FormattingEnabled = true;
            lboxMessages.ItemHeight = 23;
            lboxMessages.Location = new Point(0, 154);
            lboxMessages.Name = "lboxMessages";
            lboxMessages.Size = new Size(494, 602);
            lboxMessages.TabIndex = 7;
            lboxMessages.SelectedIndexChanged += lboxMessages_SelectedIndexChanged;
            // 
            // lblMessageList
            // 
            lblMessageList.AutoSize = true;
            lblMessageList.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessageList.Location = new Point(12, 110);
            lblMessageList.Name = "lblMessageList";
            lblMessageList.Size = new Size(256, 32);
            lblMessageList.TabIndex = 6;
            lblMessageList.Text = "Group's Messages";
            // 
            // btnSendMessage
            // 
            btnSendMessage.BackColor = Color.FromArgb(0, 51, 102);
            btnSendMessage.FlatAppearance.BorderSize = 0;
            btnSendMessage.FlatStyle = FlatStyle.Flat;
            btnSendMessage.ForeColor = Color.FromArgb(240, 242, 243);
            btnSendMessage.Location = new Point(12, 12);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(229, 60);
            btnSendMessage.TabIndex = 4;
            btnSendMessage.Text = "Send Message";
            btnSendMessage.UseVisualStyleBackColor = false;
            btnSendMessage.Visible = false;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // pnlMessage
            // 
            pnlMessage.Controls.Add(btnLeaveGroup);
            pnlMessage.Controls.Add(btnMembers);
            pnlMessage.Controls.Add(lblMessage);
            pnlMessage.Controls.Add(tboxMessage);
            pnlMessage.Location = new Point(988, 0);
            pnlMessage.Name = "pnlMessage";
            pnlMessage.Size = new Size(494, 753);
            pnlMessage.TabIndex = 1;
            // 
            // btnLeaveGroup
            // 
            btnLeaveGroup.BackColor = Color.FromArgb(0, 51, 102);
            btnLeaveGroup.FlatAppearance.BorderSize = 0;
            btnLeaveGroup.FlatStyle = FlatStyle.Flat;
            btnLeaveGroup.ForeColor = Color.FromArgb(240, 242, 243);
            btnLeaveGroup.Location = new Point(253, 12);
            btnLeaveGroup.Name = "btnLeaveGroup";
            btnLeaveGroup.Size = new Size(229, 60);
            btnLeaveGroup.TabIndex = 10;
            btnLeaveGroup.Text = "Leave Group";
            btnLeaveGroup.UseVisualStyleBackColor = false;
            btnLeaveGroup.Visible = false;
            btnLeaveGroup.Click += btnLeaveGroup_Click;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = Color.FromArgb(0, 51, 102);
            btnMembers.FlatAppearance.BorderSize = 0;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.ForeColor = Color.FromArgb(240, 242, 243);
            btnMembers.Location = new Point(12, 12);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(229, 60);
            btnMembers.TabIndex = 9;
            btnMembers.Text = "See Members";
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Visible = false;
            btnMembers.Click += btnMembers_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.Location = new Point(12, 110);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(131, 32);
            lblMessage.TabIndex = 7;
            lblMessage.Text = "Message";
            // 
            // tboxMessage
            // 
            tboxMessage.BackColor = Color.FromArgb(240, 242, 243);
            tboxMessage.Location = new Point(0, 154);
            tboxMessage.Multiline = true;
            tboxMessage.Name = "tboxMessage";
            tboxMessage.Size = new Size(494, 602);
            tboxMessage.TabIndex = 0;
            // 
            // lboxGroups
            // 
            lboxGroups.BackColor = Color.FromArgb(240, 242, 243);
            lboxGroups.FormattingEnabled = true;
            lboxGroups.ItemHeight = 23;
            lboxGroups.Location = new Point(0, 154);
            lboxGroups.Name = "lboxGroups";
            lboxGroups.Size = new Size(494, 602);
            lboxGroups.TabIndex = 2;
            lboxGroups.SelectedIndexChanged += lboxGroups_SelectedIndexChanged;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(0, 51, 102);
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.ForeColor = Color.FromArgb(240, 242, 243);
            btnLogOut.Location = new Point(12, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(229, 60);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnCreateGroup
            // 
            btnCreateGroup.BackColor = Color.FromArgb(0, 51, 102);
            btnCreateGroup.FlatAppearance.BorderSize = 0;
            btnCreateGroup.FlatStyle = FlatStyle.Flat;
            btnCreateGroup.ForeColor = Color.FromArgb(240, 242, 243);
            btnCreateGroup.Location = new Point(253, 12);
            btnCreateGroup.Name = "btnCreateGroup";
            btnCreateGroup.Size = new Size(229, 60);
            btnCreateGroup.TabIndex = 4;
            btnCreateGroup.Text = "Create Group";
            btnCreateGroup.UseVisualStyleBackColor = false;
            btnCreateGroup.Click += btnCreateGroup_Click;
            // 
            // lblGroups
            // 
            lblGroups.AutoSize = true;
            lblGroups.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblGroups.Location = new Point(12, 110);
            lblGroups.Name = "lblGroups";
            lblGroups.Size = new Size(261, 32);
            lblGroups.TabIndex = 5;
            lblGroups.Text = "Groups You Joined";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 230, 239);
            ClientSize = new Size(1482, 753);
            Controls.Add(lblGroups);
            Controls.Add(btnCreateGroup);
            Controls.Add(btnLogOut);
            Controls.Add(lboxGroups);
            Controls.Add(pnlMessage);
            Controls.Add(pnlMessageList);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            pnlMessageList.ResumeLayout(false);
            pnlMessageList.PerformLayout();
            pnlMessage.ResumeLayout(false);
            pnlMessage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMessageList;
        private Panel pnlMessage;
        private ListBox lboxGroups;
        private Button btnLogOut;
        private Button btnCreateGroup;
        private Label lblGroups;
        private ListBox lboxMessages;
        private Label lblMessageList;
        private Button btnSendMessage;
        private Label lblMessage;
        private TextBox tboxMessage;
        private Button btnAddMember;
        private Button btnLeaveGroup;
        private Button btnMembers;
    }
}