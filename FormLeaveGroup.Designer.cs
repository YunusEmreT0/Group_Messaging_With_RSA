namespace GroupMessage
{
    partial class FormLeaveGroup
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
            lblMessage = new Label();
            btnCancel = new Button();
            btnLeave = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(13, 9);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(15, 23);
            lblMessage.TabIndex = 0;
            lblMessage.Text = " ";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 51, 102);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(240, 242, 243);
            btnCancel.Location = new Point(224, 146);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLeave
            // 
            btnLeave.BackColor = Color.FromArgb(0, 51, 102);
            btnLeave.FlatAppearance.BorderSize = 0;
            btnLeave.FlatStyle = FlatStyle.Flat;
            btnLeave.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLeave.ForeColor = Color.FromArgb(240, 242, 243);
            btnLeave.Location = new Point(13, 146);
            btnLeave.Margin = new Padding(4, 3, 4, 3);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(145, 40);
            btnLeave.TabIndex = 2;
            btnLeave.Text = "Leave";
            btnLeave.UseVisualStyleBackColor = false;
            btnLeave.Click += btnLeave_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 230, 239);
            ClientSize = new Size(382, 253);
            Controls.Add(btnLeave);
            Controls.Add(btnCancel);
            Controls.Add(lblMessage);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Leave Group";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private Button btnCancel;
        private Button btnLeave;
    }
}