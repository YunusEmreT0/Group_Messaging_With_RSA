namespace GroupMessage
{
    partial class FormMembers
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
            lboxMembers = new ListBox();
            lblHeader = new Label();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lboxMembers
            // 
            lboxMembers.BackColor = Color.FromArgb(240, 242, 243);
            lboxMembers.FormattingEnabled = true;
            lboxMembers.ItemHeight = 23;
            lboxMembers.Location = new Point(0, 100);
            lboxMembers.Name = "lboxMembers";
            lboxMembers.Size = new Size(494, 487);
            lboxMembers.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.Location = new Point(179, 35);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(136, 32);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Members";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 51, 102);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(240, 242, 243);
            btnCancel.Location = new Point(147, 650);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(200, 40);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 230, 239);
            ClientSize = new Size(494, 753);
            Controls.Add(btnCancel);
            Controls.Add(lblHeader);
            Controls.Add(lboxMembers);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Members";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lboxMembers;
        private Label lblHeader;
        private Button btnCancel;
    }
}