﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Email_Client
{
    class DragControl : Component
    {
        private Control handleControl;
        public Control SelectControl
        {
            get
            {
                return handleControl;
            }
            set
            {
                handleControl = value;
                handleControl.MouseDown += new MouseEventHandler(this.DragForm_MouseDown);
            }
        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr a,int msg,int wParam,int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            bool flag = e.Button == MouseButtons.Left;
            if(flag == true)
            {
                DragControl.ReleaseCapture();
                DragControl.SendMessage(this.SelectControl.FindForm().Handle,161,2,0);
            }
        }
       
    }
}
