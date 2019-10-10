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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            this.ProgressBar_timer.Tick += new EventHandler(ProgressTick);
        }

        public void ProgressTick(object sender,EventArgs e)
        {
            if(InnerBar_Rectangle.Width < 721)
            {
                InnerBar_Rectangle.Width += 5;
            }
            else
            {
                ProgressBar_timer.Stop();
                this.Hide();
                MainPage mpForm = new MainPage();
                mpForm.Show();
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IsLoading_Label_Click(object sender, EventArgs e)
        {

        }

        private void InnerBar_Rectangle_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            ProgressBar_timer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
