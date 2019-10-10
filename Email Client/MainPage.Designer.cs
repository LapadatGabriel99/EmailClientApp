namespace Email_Client
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            this.TaskBar_Panel = new System.Windows.Forms.Panel();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.Maximize_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Left_Panel = new System.Windows.Forms.Panel();
            this.Right_Panel = new System.Windows.Forms.Panel();
            this.Down_Panel = new System.Windows.Forms.Panel();
            this.Welcome_Label = new System.Windows.Forms.Label();
            this.MainPage_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GoToWorkSpace_Button = new System.Windows.Forms.Button();
            this.PressButtonToContinue_Label = new System.Windows.Forms.Label();
            this.MainPage_DragControl = new Email_Client.DragControl();
            this.TimeFormat_Label = new System.Windows.Forms.Label();
            this.TimeCalendar_Label = new System.Windows.Forms.Label();
            this.DateAndTime = new System.Windows.Forms.Timer(this.components);
            this.TaskBar_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskBar_Panel
            // 
            this.TaskBar_Panel.BackColor = System.Drawing.Color.Indigo;
            this.TaskBar_Panel.Controls.Add(this.Minimize_Button);
            this.TaskBar_Panel.Controls.Add(this.Maximize_Button);
            this.TaskBar_Panel.Controls.Add(this.Close_Button);
            this.TaskBar_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TaskBar_Panel.Location = new System.Drawing.Point(0, 0);
            this.TaskBar_Panel.Name = "TaskBar_Panel";
            this.TaskBar_Panel.Size = new System.Drawing.Size(768, 37);
            this.TaskBar_Panel.TabIndex = 0;
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Minimize_Button.FlatAppearance.BorderSize = 0;
            this.Minimize_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Minimize_Button.Location = new System.Drawing.Point(642, 0);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Minimize_Button.Size = new System.Drawing.Size(42, 37);
            this.Minimize_Button.TabIndex = 2;
            this.Minimize_Button.Text = "▁";
            this.MainPage_ToolTip.SetToolTip(this.Minimize_Button, "Minimize");
            this.Minimize_Button.UseVisualStyleBackColor = true;
            this.Minimize_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Maximize_Button
            // 
            this.Maximize_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Maximize_Button.FlatAppearance.BorderSize = 0;
            this.Maximize_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximize_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Maximize_Button.Location = new System.Drawing.Point(684, 0);
            this.Maximize_Button.Name = "Maximize_Button";
            this.Maximize_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Maximize_Button.Size = new System.Drawing.Size(42, 37);
            this.Maximize_Button.TabIndex = 1;
            this.Maximize_Button.Text = "▱";
            this.MainPage_ToolTip.SetToolTip(this.Maximize_Button, "Maximize");
            this.Maximize_Button.UseVisualStyleBackColor = true;
            this.Maximize_Button.Click += new System.EventHandler(this.Maximize_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Close_Button.Location = new System.Drawing.Point(726, 0);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Close_Button.Size = new System.Drawing.Size(42, 37);
            this.Close_Button.TabIndex = 0;
            this.Close_Button.Text = "X";
            this.MainPage_ToolTip.SetToolTip(this.Close_Button, "Close");
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Left_Panel
            // 
            this.Left_Panel.BackColor = System.Drawing.Color.Indigo;
            this.Left_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Panel.Location = new System.Drawing.Point(0, 37);
            this.Left_Panel.Name = "Left_Panel";
            this.Left_Panel.Size = new System.Drawing.Size(3, 377);
            this.Left_Panel.TabIndex = 1;
            // 
            // Right_Panel
            // 
            this.Right_Panel.BackColor = System.Drawing.Color.Indigo;
            this.Right_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Right_Panel.Location = new System.Drawing.Point(765, 37);
            this.Right_Panel.Name = "Right_Panel";
            this.Right_Panel.Size = new System.Drawing.Size(3, 377);
            this.Right_Panel.TabIndex = 2;
            this.Right_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Right_Panel_Paint);
            // 
            // Down_Panel
            // 
            this.Down_Panel.BackColor = System.Drawing.Color.Indigo;
            this.Down_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Down_Panel.Location = new System.Drawing.Point(3, 411);
            this.Down_Panel.Name = "Down_Panel";
            this.Down_Panel.Size = new System.Drawing.Size(762, 3);
            this.Down_Panel.TabIndex = 3;
            this.Down_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Welcome_Label
            // 
            this.Welcome_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Welcome_Label.AutoSize = true;
            this.Welcome_Label.Font = new System.Drawing.Font("Ravie", 33.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Welcome_Label.Location = new System.Drawing.Point(6, 52);
            this.Welcome_Label.Name = "Welcome_Label";
            this.Welcome_Label.Size = new System.Drawing.Size(753, 59);
            this.Welcome_Label.TabIndex = 4;
            this.Welcome_Label.Text = "Welcome to Email Client";
            // 
            // GoToWorkSpace_Button
            // 
            this.GoToWorkSpace_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GoToWorkSpace_Button.FlatAppearance.BorderSize = 0;
            this.GoToWorkSpace_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToWorkSpace_Button.Font = new System.Drawing.Font("Script MT Bold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToWorkSpace_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GoToWorkSpace_Button.Location = new System.Drawing.Point(226, 208);
            this.GoToWorkSpace_Button.Name = "GoToWorkSpace_Button";
            this.GoToWorkSpace_Button.Size = new System.Drawing.Size(284, 64);
            this.GoToWorkSpace_Button.TabIndex = 6;
            this.GoToWorkSpace_Button.Text = "Go to next page ->";
            this.MainPage_ToolTip.SetToolTip(this.GoToWorkSpace_Button, "Press this button in order to go to the next page");
            this.GoToWorkSpace_Button.UseVisualStyleBackColor = true;
            this.GoToWorkSpace_Button.Click += new System.EventHandler(this.GoToWorkSpace_Button_Click);
            // 
            // PressButtonToContinue_Label
            // 
            this.PressButtonToContinue_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PressButtonToContinue_Label.AutoSize = true;
            this.PressButtonToContinue_Label.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressButtonToContinue_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PressButtonToContinue_Label.Location = new System.Drawing.Point(43, 128);
            this.PressButtonToContinue_Label.Name = "PressButtonToContinue_Label";
            this.PressButtonToContinue_Label.Size = new System.Drawing.Size(705, 36);
            this.PressButtonToContinue_Label.TabIndex = 5;
            this.PressButtonToContinue_Label.Text = "Press the button bellow to continue...";
            this.PressButtonToContinue_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainPage_DragControl
            // 
            this.MainPage_DragControl.SelectControl = this.TaskBar_Panel;
            // 
            // TimeFormat_Label
            // 
            this.TimeFormat_Label.AutoSize = true;
            this.TimeFormat_Label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeFormat_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimeFormat_Label.Location = new System.Drawing.Point(49, 321);
            this.TimeFormat_Label.Name = "TimeFormat_Label";
            this.TimeFormat_Label.Size = new System.Drawing.Size(45, 18);
            this.TimeFormat_Label.TabIndex = 7;
            this.TimeFormat_Label.Text = "00:00";
            // 
            // TimeCalendar_Label
            // 
            this.TimeCalendar_Label.AutoSize = true;
            this.TimeCalendar_Label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeCalendar_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimeCalendar_Label.Location = new System.Drawing.Point(49, 353);
            this.TimeCalendar_Label.Name = "TimeCalendar_Label";
            this.TimeCalendar_Label.Size = new System.Drawing.Size(64, 18);
            this.TimeCalendar_Label.TabIndex = 8;
            this.TimeCalendar_Label.Text = "0/0/0000";
            this.TimeCalendar_Label.Click += new System.EventHandler(this.TimeCalendar_Label_Click);
            // 
            // DateAndTime
            // 
            this.DateAndTime.Interval = 1000;
            this.DateAndTime.Tick += new System.EventHandler(this.ChangeLabels);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(768, 414);
            this.Controls.Add(this.TimeCalendar_Label);
            this.Controls.Add(this.TimeFormat_Label);
            this.Controls.Add(this.GoToWorkSpace_Button);
            this.Controls.Add(this.PressButtonToContinue_Label);
            this.Controls.Add(this.Welcome_Label);
            this.Controls.Add(this.Down_Panel);
            this.Controls.Add(this.Right_Panel);
            this.Controls.Add(this.Left_Panel);
            this.Controls.Add(this.TaskBar_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.TaskBar_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TaskBar_Panel;
        private System.Windows.Forms.Panel Left_Panel;
        private System.Windows.Forms.Panel Right_Panel;
        private System.Windows.Forms.Panel Down_Panel;
        private System.Windows.Forms.Label Welcome_Label;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button Maximize_Button;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.ToolTip MainPage_ToolTip;
        private System.Windows.Forms.Label PressButtonToContinue_Label;
        private System.Windows.Forms.Button GoToWorkSpace_Button;
        private DragControl MainPage_DragControl;
        public System.Windows.Forms.Label TimeFormat_Label;
        public System.Windows.Forms.Label TimeCalendar_Label;
        public System.Windows.Forms.Timer DateAndTime;
    }
}