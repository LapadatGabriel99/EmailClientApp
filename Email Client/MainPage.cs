using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Client
{
    public partial class MainPage : Form
    {
        //Thread thread;
        //Clock newClock = new Clock();
        //LabelClock labelClock = new LabelClock();
        //CalendarLabel labelCalendar = new CalendarLabel();

        public MainPage()
        {
            InitializeComponent();
            //SetFormats();
            //thread = new Thread(ChangeLabels);
            //thread.Start();
            TimeFormat_Label.Text = DateTime.Now.ToString("HH:mm");
            TimeCalendar_Label.Text = DateTime.Now.ToString("M/d/yyyy");
            this.DateAndTime.Tick += new EventHandler(ChangeLabels);
            DateAndTime.Start();
        }

        public void ChangeLabels(object sender, EventArgs e)
        {
            TimeFormat_Label.Text = DateTime.Now.ToString("HH:mm");
            TimeCalendar_Label.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Closing App",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                DateAndTime.Stop();
                Environment.Exit(1);
            }
            //else if(dialog == DialogResult.No)
            //{
                
            //}
        }

        private void Right_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void Maximize_Button_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                Maximize_Button.Text = "❐";
                MainPage_ToolTip.SetToolTip(Maximize_Button, "Restore");
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                Maximize_Button.Text = "▱";
                MainPage_ToolTip.SetToolTip(Maximize_Button, "Maximize");
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Normal;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GoToWorkSpace_Button_Click(object sender, EventArgs e)
        {
            Form1 f1Form = new Form1();
            DateAndTime.Stop();
            this.Hide();
            f1Form.Show();
        }

        private void TimeCalendar_Label_Click(object sender, EventArgs e)
        {
            //!!!!!!\\use ChangeFormat here, with tooltip
        }

        public void SetFormats()
        {
           
            //labelClock.Subscribe(newClock);
            //labelCalendar.Subcribe(newClock);
            //newClock.RunClock();
            
        }
    }
}
