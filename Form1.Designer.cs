namespace EmailApp
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmailFrom = new TextBox();
            txtEmailTo = new TextBox();
            txtSubject = new TextBox();
            Information = new ListBox();
            btnSendEmail = new Button();
            txtRecevieEmail = new Button();
            label5 = new Label();
            txtBody = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label6 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 97);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 36);
            label1.TabIndex = 0;
            label1.Text = "From :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 209);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 36);
            label2.TabIndex = 1;
            label2.Text = "To :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 272);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 36);
            label3.TabIndex = 2;
            label3.Text = "Subject :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 365);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 36);
            label4.TabIndex = 3;
            label4.Text = "Body :";
            // 
            // txtEmailFrom
            // 
            txtEmailFrom.Location = new Point(224, 89);
            txtEmailFrom.Margin = new Padding(4, 3, 4, 3);
            txtEmailFrom.Name = "txtEmailFrom";
            txtEmailFrom.PlaceholderText = "Enter email from here...";
            txtEmailFrom.Size = new Size(346, 44);
            txtEmailFrom.TabIndex = 4;
            // 
            // txtEmailTo
            // 
            txtEmailTo.Location = new Point(224, 201);
            txtEmailTo.Margin = new Padding(4, 3, 4, 3);
            txtEmailTo.Name = "txtEmailTo";
            txtEmailTo.PlaceholderText = "Enter email to here...";
            txtEmailTo.Size = new Size(346, 44);
            txtEmailTo.TabIndex = 5;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(224, 264);
            txtSubject.Margin = new Padding(4, 3, 4, 3);
            txtSubject.Name = "txtSubject";
            txtSubject.PlaceholderText = "Enter email subject...";
            txtSubject.Size = new Size(346, 44);
            txtSubject.TabIndex = 6;
            // 
            // Information
            // 
            Information.FormattingEnabled = true;
            Information.ItemHeight = 36;
            Information.Items.AddRange(new object[] { "Information" });
            Information.Location = new Point(604, 89);
            Information.Margin = new Padding(4, 3, 4, 3);
            Information.Name = "Information";
            Information.Size = new Size(848, 508);
            Information.TabIndex = 8;
            // 
            // btnSendEmail
            // 
            btnSendEmail.BackColor = SystemColors.ButtonShadow;
            btnSendEmail.FlatStyle = FlatStyle.Flat;
            btnSendEmail.ForeColor = SystemColors.Control;
            btnSendEmail.Location = new Point(224, 565);
            btnSendEmail.Margin = new Padding(4, 3, 4, 3);
            btnSendEmail.Name = "btnSendEmail";
            btnSendEmail.Size = new Size(146, 57);
            btnSendEmail.TabIndex = 9;
            btnSendEmail.Text = "Send";
            btnSendEmail.UseVisualStyleBackColor = false;
            btnSendEmail.Click += btnSend_Click;
            // 
            // txtRecevieEmail
            // 
            txtRecevieEmail.BackColor = Color.Green;
            txtRecevieEmail.FlatStyle = FlatStyle.Flat;
            txtRecevieEmail.ForeColor = SystemColors.Control;
            txtRecevieEmail.Location = new Point(424, 565);
            txtRecevieEmail.Margin = new Padding(4, 3, 4, 3);
            txtRecevieEmail.Name = "txtRecevieEmail";
            txtRecevieEmail.Size = new Size(146, 57);
            txtRecevieEmail.TabIndex = 10;
            txtRecevieEmail.Text = "Recevie";
            txtRecevieEmail.UseVisualStyleBackColor = false;
            txtRecevieEmail.Click += btnReceive_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.DarkOrange;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(1465, 50);
            label5.TabIndex = 11;
            label5.Text = "Email App";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBody
            // 
            txtBody.Location = new Point(224, 350);
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(346, 173);
            txtBody.TabIndex = 12;
            txtBody.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 150);
            label6.Name = "label6";
            label6.Size = new Size(152, 36);
            label6.TabIndex = 13;
            label6.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(224, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter password here...";
            txtPassword.Size = new Size(346, 44);
            txtPassword.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 674);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(txtBody);
            Controls.Add(label5);
            Controls.Add(txtRecevieEmail);
            Controls.Add(btnSendEmail);
            Controls.Add(Information);
            Controls.Add(txtSubject);
            Controls.Add(txtEmailTo);
            Controls.Add(txtEmailFrom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Email App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnSendEmail_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEmailFrom;
        private TextBox txtEmailTo;
        private TextBox txtSubject;
        private ListBox Information;
        private Button btnSendEmail;
        private Button txtRecevieEmail;
        private Label label5;
        private RichTextBox txtBody;
        private ContextMenuStrip contextMenuStrip1;
        private Label label6;
        private TextBox txtPassword;
    }
}
