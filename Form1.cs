using System;
using System.Net;
using System.Net.Mail;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit.Net.Smtp;
using MailKit.Search;
using MimeKit;


namespace EmailApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //su kien email
        private void btnSend_Click(object sender, EventArgs e)
        {
            string fromEmail = txtEmailFrom.Text;
            string toEmail = txtEmailTo.Text;
            string Subject = txtSubject.Text;
            string Body = txtBody.Text;
            string Password = txtPassword.Text;

            if (fromEmail == "" && toEmail == "" && Subject == "" && Body == "" && Password == "")
            {
                MessageBox.Show("Please fill in the information ! ");
                return;
            }
            try
            {
                SendEmail(fromEmail, toEmail, Subject, Body, Password);
                MessageBox.Show("Email send  successfully !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }
        }
        //su kien nhan email
        private void btnReceive_Click(object sender, EventArgs e)
        {
            string fromEmail = txtEmailFrom.Text;
            string Password = txtPassword.Text;


            if (fromEmail == "" && Password == "")
            {
                MessageBox.Show("Please enter valid email and password !");
                return;
            }

            try
            {
                ReceiveEmailsByPop3(fromEmail, Password);
                MessageBox.Show("Emails received successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error receiving emails: " + ex.Message);
            }
        }


        // phuong thuc gui email SMTP

        private void SendEmail(string fromemail, string toemail, string subject, string body, string password)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(fromemail, fromemail));
            message.To.Add(new MailboxAddress(toemail, toemail));
            message.Subject = subject;
            message.Body = new TextPart("plain")
            {
                Text = body
            };

            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 587, false);
                smtp.Authenticate(fromemail, password);
                smtp.Send(message);
                smtp.Disconnect(true);
            }

        }







        // Phuong thuc nhan email qua IMAP
        //private void ReceiveEmailsByImap(string email,string password)
        //{
        //    using (var client = new ImapClient())
        //    {
        //        client.Connect("imap.gmail.com", 993, true);
        //        client.Authenticate(email, password);

        //        client.Inbox.Open(MailKit.FolderAccess.ReadOnly);
        //        var uids = client.Inbox.Search(SearchQuery.All);

        //        Information.Items.Clear();
        //        foreach (var uid in uids)
        //        {
        //            var message = client.Inbox.GetMessage(uid);
        //            Information.Items.Add($"From: {message.From}, Subject: {message.Subject}");
        //        }

        //        client.Disconnect(true);
        //    }
        //}

        //Phuong thuc nhan email qua POP3


        private void ReceiveEmailsByPop3(string email, string password)
        {
            using (var client = new Pop3Client())
            {
                try
                {

                    client.Connect("pop.gmail.com", 995, true);


                    client.Authenticate(email, password);


                    Information.Items.Clear();

                    int messageCount = client.Count;

                    for (int i = 0; i < messageCount; i++)
                    {
                        var message = client.GetMessage(i);


                        Information.Items.Add($"From: {message.From}, Subject: {message.Subject}");
                    }

                    MessageBox.Show("Emails received successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error receiving emails: {ex.Message}");
                }
                finally
                {

                    client.Disconnect(true);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}