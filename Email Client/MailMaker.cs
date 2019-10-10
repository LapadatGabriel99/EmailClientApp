using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace Email_Stuff
{
    public class MailMaker :Form
    {
        private static TextBox Your_Email_ID_TextBox = new TextBox();
        private static TextBox Your_Password_TextBox = new TextBox();
        private static TextBox Subject_TextBox = new TextBox();
        private static TextBox Body_TextBox = new TextBox();
        private static TextBox Recievers_Email_TextBox = new TextBox();
        private static TextBox Add_Attachment_TextBox = new TextBox();

        MailMessage message = new MailMessage();
        

        public void EmailMsg()
        {
            MailAddress Recipient_address = new MailAddress(Your_Email_ID_TextBox.Text.ToString());
            message.From = Recipient_address;
            message.Subject = Subject_TextBox.Text.ToString();
            message.Body = Body_TextBox.Text.ToString();

            foreach (string address in Recievers_Email_TextBox.Text.Split(','))
            {
                message.To.Add(address);
            }
            if (Add_Attachment_TextBox.Text != "")
            {
                foreach (string attachment in Add_Attachment_TextBox.Text.Split(','))
                {
                    message.Attachments.Add(new Attachment(attachment));
                }
            }

        }

        public void EmailClient()
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(Your_Email_ID_TextBox.Text, Your_Password_TextBox.Text);
            client.Send(message);
        }

        public void Set_Your_Email_ID_TextBox(TextBox YourEmailIDTextBox)
        {
            Your_Email_ID_TextBox = YourEmailIDTextBox;
        }

        public TextBox Get_Your_Email_ID_TextBox()
        {
            return Your_Email_ID_TextBox;
        }

        public void Set_Your_Password_TextBox(TextBox YourPasswordTextBox)
        {
            Your_Password_TextBox = YourPasswordTextBox;
        }

        public TextBox Get_Your_Password_TextBox()
        {
            return Your_Password_TextBox;
        }

        public void Set_Subject_TextBox(TextBox SubjectTextBox)
        {
            Subject_TextBox = SubjectTextBox;
        }

        public TextBox Get_Subject_TextBox()
        {
            return Subject_TextBox;
        }

        public void Set_Body_TextBox(TextBox BodyTextBox)
        {
            Body_TextBox = BodyTextBox;
        }

        public TextBox Get_Body_TextBox()
        {
            return Body_TextBox;
        }
         
        public void Set_Add_Attachment_TextBox(TextBox AddAttachmentTextBox)
        {
            Add_Attachment_TextBox = AddAttachmentTextBox;
        }

        public TextBox Get_Add_Attachment_TextBox()
        {
            return Add_Attachment_TextBox;
        }

        public void Set_Recievers_Email_TextBox(TextBox RecieversEmailTextBox)
        {
            Recievers_Email_TextBox = RecieversEmailTextBox;
        }

        public TextBox Get_Recievers_Email_TextBox()
        {
            return Recievers_Email_TextBox;
        }

    }
}

