using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Client
{
    class TestingExceptions
    {
        private TextBox ExTextBox { get; set; }

        public TestingExceptions(TextBox textBox)
        {
            ExTextBox = textBox;
        }

        public TestingExceptions()
        {
            ExTextBox = new TextBox();
        }

        public void Checking_RecipientEmail_ID(TextBox Your_Email_ID)
        {
            ExTextBox.Text = Your_Email_ID.Text;
            if (!ExTextBox.Text.Contains("@gmail.com"))
            {
                throw new RecipientEmail_ID_Exception(
                    "You must provide a gmail address\r\nin order for this to work.");
            }
        }

        public void Checking_RecipientEmail_ID()
        {
            if (!ExTextBox.Text.Contains("@gmail.com"))
            {
                throw new RecipientEmail_ID_Exception(
                    "You must provide a gmail address\r\nin order for this to work.");
            }
        }

        public void Checking_RecipientPassword(TextBox Your_Password)
        {
            ExTextBox.Text = Your_Password.Text;
            if (ExTextBox.Text == "")
            {
                throw new RecipientPassword_Exception(
                    "You must provide your account password\r\nin order for this to work.");
            }
        }

        public void Checking_RecipientPassword()
        {
            if (ExTextBox.Text == "")
            {
                throw new RecipientPassword_Exception(
                    "You must provide your account password\r\nin order for this to work.");
            }
        }

        public void Checking_RecieversEmail(TextBox Recievers_Email)
        {
            ExTextBox.Text = Recievers_Email.Text;
            if (ExTextBox.Text == "")
            {
                throw new RecieversEmail_Exception(
                    "You must provide at least one email address\r\nin order for this to work.");
            }
            if(!ExTextBox.Text.Contains("@gmail") && !ExTextBox.Text.Contains("@yahoo"))
            {
                throw new RecieversEmail_Exception(
                    "You must provide a gmail or yahoo address\r\nin order for this to work.");
            }
        }

        public void Checking_RecieversEmail()
        {
            if (ExTextBox.Text == "")
            {
                throw new RecieversEmail_Exception(
                    "You must provide at least one email address\r\nin order for this to work.");
            }
            if (!ExTextBox.Text.Contains("@gmail.com") || !ExTextBox.Text.Contains("@yahoo.com"))
            {
                throw new RecieversEmail_Exception(
                    "You must provide a gmail or yahoo address\r\nin order for this to work.");
            }
        }

    }
}
