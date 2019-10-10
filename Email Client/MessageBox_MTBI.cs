using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Client
{
    public class MessageBox_MTBI
    {
        public string Message { get; set; }
        public string Title { get; set; }
        public MessageBoxButtons Button { get; set; }
        public MessageBoxIcon Icon { get; set; }

        public MessageBox_MTBI()
        {
        }

        public MessageBox_MTBI(string message)
        {
            Message = message;
        }

        public void Choose_MTBI()
        {
            switch(Message)
            {
                case "You must provide a gmail address\r\nin order for this to work.":
                    Title = "Invalid Recipient Address Input";
                    Button = MessageBoxButtons.OK;
                    Icon = MessageBoxIcon.Exclamation;
                    break;
                case "You must provide your account password\r\nin order for this to work.":
                    Title = "Invalid Recipient Password Input";
                    Button = MessageBoxButtons.OK;
                    Icon = MessageBoxIcon.Exclamation;
                    break;
                case "You must provide at least one email address\r\nin order for this to work.":
                    Title = "Missing Reciever(s) Address(es)";
                    Button = MessageBoxButtons.OK;
                    Icon = MessageBoxIcon.Exclamation;
                    break;
                case "You must provide a gmail or yahoo address\r\nin order for this to work.":
                    Title = "Invalid Receiver Address Input";
                    Button = MessageBoxButtons.OK;
                    Icon = MessageBoxIcon.Exclamation;
                    break;
                default:
                    break;
            }
        }

        public void Choose_MTBI(string message)
        {
            Message = message;
            switch (Message)
            {
                case "You must provide a gmail address\r\nin order for this to work.":
                    Title = "Invalid Recipient Address Input";
                    Button = MessageBoxButtons.OK;
                    Icon = MessageBoxIcon.Exclamation;
                    break;
                case "You must provide your account password\r\nin order for this to work.":
                    Title = "Invalid Recipient Password Input";
                    Button = MessageBoxButtons.OK;
                    Icon = MessageBoxIcon.Exclamation;
                    break;
                case "You must provide at least one email address\r\nin order for this to work.":
                    Title = "Missing Reciever(s) Address(es)";
                    Button = MessageBoxButtons.OK;
                    Icon = MessageBoxIcon.Exclamation;
                    break;
                case "You must provide a gmail or yahoo address\r\nin order for this to work.":
                    Title = "Invalid Receiver Address Input";
                    Button = MessageBoxButtons.OK;
                    Icon = MessageBoxIcon.Exclamation;
                    break;
                default:
                    break;
            }
        }

    }
}
