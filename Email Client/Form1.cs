using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Email_Stuff;
using ControlResizing;

namespace Email_Client
{
    public partial class Form1 : Form
    {

        private Rectangle originalBodyPanelRight;
        private Rectangle originalBodyPanelLeft;
        private Rectangle originalBodyPanelUp;
        private Rectangle originalBodyPanelDown;
        private Rectangle originalBodyTextBox;
        private Size originalFormSize;
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(AskBeforeClosing);
            this.DateAndTime.Tick += new EventHandler(ChangeLabels);
            DateAndTime.Start();
        }
        
        public void ChangeLabels(object sender, EventArgs e)
        {
            TimeFormat_Label.Text = DateTime.Now.ToString("HH:mm");
            DateFormat_Label.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        public void AskBeforeClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Closing App",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    DateAndTime.Stop();
                    Environment.Exit(1);
                }
                else if(dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }

            }
        }

        private void InitializeRectangles()
        {
            originalFormSize = new Size(this.Size.Width, this.Size.Height);
            originalBodyPanelDown = new Rectangle(Body_panel_Down.Location.X, Body_panel_Down.Location.Y,
                                                  Body_panel_Down.Size.Width, Body_panel_Down.Size.Height);
            originalBodyPanelUp = new Rectangle(Body_panel_Up.Location.X, Body_panel_Up.Location.Y,
                                                Body_panel_Up.Size.Width, Body_panel_Up.Size.Height);
            originalBodyPanelLeft = new Rectangle(Body_panel_Left.Location.X, Body_panel_Left.Location.Y,
                                                  Body_panel_Left.Size.Width, Body_panel_Left.Size.Height);
            originalBodyPanelRight = new Rectangle(Body_panel_Right.Location.X, Body_panel_Right.Location.Y,
                                                   Body_panel_Right.Size.Width, Body_panel_Right.Size.Height);
            originalBodyTextBox = new Rectangle(Body_TextBox.Location.X, Body_TextBox.Location.Y,
                                                Body_TextBox.Size.Width,Body_TextBox.Size.Height);
        }

        private void ResizeChildrenControl()
        {
            ResizeControl AlterControl = new ResizeControl(originalBodyTextBox,originalFormSize);
           // AlterControl.ResizeAll(this.Size, Body_TextBox);
            AlterControl.AddRectangle = originalBodyPanelRight;
            AlterControl.AddSize = originalFormSize;
            AlterControl.ChangeHeightAndMoveLocation(this.Size, Body_panel_Right);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MailMaker ml = new MailMaker();
            //ml.Set_Subject_TextBox(Subject_TextBox);
            //MessageBox.Show(ml.Get_Subject_TextBox().Text);
            InitializeRectangles();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Send_Email_Button_Click(object sender, EventArgs e)
        {
            try
            {   //!!!!!!!!!!!!!!!!!!!!\\
                if (Add_Attachment_TextBox.Text != "" && Add_Attachment_TextBox.Text[Add_Attachment_TextBox.Text.Length - 1] == ',')
                {
                    Add_Attachment_TextBox.Text = Add_Attachment_TextBox.Text.Remove(Add_Attachment_TextBox.Text.Length - 1);
                }
                if (!Your_Email_ID_TextBox.Text.Contains("@gmail"))
                {
                    MessageBox.Show("You must provide a gmail address\r\nin order for this to work.", "Invalid Address Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Recievers_Email_TextBox.Text == "")
                {
                    MessageBox.Show("You must provide al least one email address\r\nin order for this to work.","Missing Recipient Address",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                Send_Email_Button.Enabled = false;

                //MailMessage message = new MailMessage();
                //MailAddress Recipient_address = new MailAddress(Your_Email_ID_TextBox.Text.ToString());
                //message.From = Recipient_address;
                //message.Subject = Subject_TextBox.Text.ToString();
                //message.Body = Body_TextBox.Text.ToString();

                //foreach(string address in Recievers_Email_TextBox.Text.Split(','))
                //{
                //    message.To.Add(address);
                //}

                ////if(Add_Attachment_TextBox.Text == "")
                ////{
                ////    Attachment att = new Attachment(Add_Attachment_TextBox.Text);
                ////    message.Attachments.Add(att);
                ////}
                //foreach(string attachment in Add_Attachment_TextBox.Text.Split(','))
                //{
                //    message.Attachments.Add(new Attachment(attachment));
                //}

                //SmtpClient client = new SmtpClient("smtp.gmail.com");
                //client.Port = 587;
                //client.EnableSsl = true;
                //client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //client.UseDefaultCredentials = false;
                //client.Credentials = new NetworkCredential(Your_Email_ID_TextBox.Text, Your_Password_TextBox.Text);
                //client.Send(message);

                TestingExceptions tester = new TestingExceptions();
                tester.Checking_RecipientEmail_ID(Your_Email_ID_TextBox);
                tester.Checking_RecipientPassword(Your_Password_TextBox);
                tester.Checking_RecieversEmail(Recievers_Email_TextBox);

                MailMaker mail = new MailMaker();

                mail.Set_Your_Email_ID_TextBox(Your_Email_ID_TextBox);

                mail.Set_Your_Password_TextBox(Your_Password_TextBox);

                mail.Set_Subject_TextBox(Subject_TextBox);

                mail.Set_Add_Attachment_TextBox(Add_Attachment_TextBox);

                mail.Set_Body_TextBox(Body_TextBox);

                mail.Set_Recievers_Email_TextBox(Recievers_Email_TextBox);

                mail.EmailMsg();
                mail.EmailClient();
            
                MessageBox.Show("Your mail was sent!","Sending Succesfull",MessageBoxButtons.OK);
            }
            catch (RecieversEmail_Exception ex)
            {
                MessageBox_MTBI mboxItems = new MessageBox_MTBI(ex.Message);
                mboxItems.Choose_MTBI();
                MessageBox.Show(mboxItems.Message, mboxItems.Title, mboxItems.Button, mboxItems.Icon);
            }
            catch (RecipientEmail_ID_Exception ex)
            {
                MessageBox_MTBI mboxItems = new MessageBox_MTBI(ex.Message);
                mboxItems.Choose_MTBI();
                MessageBox.Show(mboxItems.Message, mboxItems.Title, mboxItems.Button, mboxItems.Icon);
            }
            catch (RecipientPassword_Exception ex)
            {
                MessageBox_MTBI mboxItems = new MessageBox_MTBI(ex.Message);
                mboxItems.Choose_MTBI();
                MessageBox.Show(mboxItems.Message, mboxItems.Title, mboxItems.Button, mboxItems.Icon);
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Send_Email_Button.Enabled = true;
                if(Add_Attachment_TextBox.Text != "")
                   Add_Attachment_TextBox.Text += ",";
            }
        }


        private void Browse_Button_Click(object sender, EventArgs e)
        {
            if(Browse_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Add_Attachment_TextBox.Text += Browse_openFileDialog.FileName.ToString() + ",";
            }
        }

        private void Your_Password_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Your_Password_TextBox.Width = 775;
                Body_panel_Left.Height = Body_TextBox.Height;
                Body_panel_Up.Width = Body_TextBox.Width + Body_panel_Left.Width;
                Body_panel_Down.Width = Body_TextBox.Width + Body_panel_Left.Width;
                // Body_panel_Down.Location.X.Equals();
                ResizeChildrenControl();
            }

            if (WindowState == FormWindowState.Normal)
            {
                Your_Password_TextBox.Width = 192;
                Body_panel_Left.Height = Body_TextBox.Height;
                Body_panel_Up.Width = Body_TextBox.Width + Body_panel_Left.Width;
                Body_panel_Down.Width = Body_TextBox.Width + Body_panel_Left.Width;
                ResizeChildrenControl();
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Body_panel_Down_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
