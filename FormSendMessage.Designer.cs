namespace GroupMessage
{
    partial class FormSendMessage
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
            lblHeader = new Label();
            lblTopic = new Label();
            lblFile = new Label();
            lblMessage = new Label();
            lblError = new Label();
            btnSend = new Button();
            btnCancel = new Button();
            tboxTopic = new TextBox();
            tboxFile = new TextBox();
            tboxMessage = new TextBox();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.Location = new Point(391, 50);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(205, 32);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Send Message";
            // 
            // lblTopic
            // 
            lblTopic.AutoSize = true;
            lblTopic.Location = new Point(461, 120);
            lblTopic.Name = "lblTopic";
            lblTopic.Size = new Size(65, 23);
            lblTopic.TabIndex = 1;
            lblTopic.Text = "Topic";
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Location = new Point(441, 208);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(106, 23);
            lblFile.TabIndex = 2;
            lblFile.Text = "File Name";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(445, 299);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(98, 23);
            lblMessage.TabIndex = 3;
            lblMessage.Text = "Message";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(294, 666);
            lblError.Name = "lblError";
            lblError.Size = new Size(15, 23);
            lblError.TabIndex = 4;
            lblError.Text = " ";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(0, 51, 102);
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.ForeColor = Color.FromArgb(240, 242, 243);
            btnSend.Location = new Point(306, 591);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(145, 40);
            btnSend.TabIndex = 5;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 51, 102);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(240, 242, 243);
            btnCancel.Location = new Point(537, 591);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // tboxTopic
            // 
            tboxTopic.BackColor = Color.FromArgb(240, 242, 243);
            tboxTopic.Location = new Point(335, 146);
            tboxTopic.Name = "tboxTopic";
            tboxTopic.Size = new Size(308, 31);
            tboxTopic.TabIndex = 7;
            // 
            // tboxFile
            // 
            tboxFile.BackColor = Color.FromArgb(240, 242, 243);
            tboxFile.Location = new Point(335, 234);
            tboxFile.Name = "tboxFile";
            tboxFile.Size = new Size(308, 31);
            tboxFile.TabIndex = 8;
            // 
            // tboxMessage
            // 
            tboxMessage.BackColor = Color.FromArgb(240, 242, 243);
            tboxMessage.Location = new Point(294, 325);
            tboxMessage.Multiline = true;
            tboxMessage.Name = "tboxMessage";
            tboxMessage.Size = new Size(400, 260);
            tboxMessage.TabIndex = 9;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 230, 239);
            ClientSize = new Size(988, 753);
            Controls.Add(tboxMessage);
            Controls.Add(tboxFile);
            Controls.Add(tboxTopic);
            Controls.Add(btnCancel);
            Controls.Add(btnSend);
            Controls.Add(lblError);
            Controls.Add(lblMessage);
            Controls.Add(lblFile);
            Controls.Add(lblTopic);
            Controls.Add(lblHeader);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Send Message";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblTopic;
        private Label lblFile;
        private Label lblMessage;
        private Label lblError;
        private Button btnSend;
        private Button btnCancel;
        private TextBox tboxTopic;
        private TextBox tboxFile;
        private TextBox tboxMessage;
    }
}