namespace Email_Client
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Your_Email_ID_Label = new System.Windows.Forms.Label();
            this.Recievers_Email_Label = new System.Windows.Forms.Label();
            this.Add_Attachment_Label = new System.Windows.Forms.Label();
            this.Subject_Label = new System.Windows.Forms.Label();
            this.Body_Label = new System.Windows.Forms.Label();
            this.Your_Email_ID_TextBox = new System.Windows.Forms.TextBox();
            this.Your_Password_Label = new System.Windows.Forms.Label();
            this.Your_Password_TextBox = new System.Windows.Forms.TextBox();
            this.Recievers_Email_TextBox = new System.Windows.Forms.TextBox();
            this.Add_Attachment_TextBox = new System.Windows.Forms.TextBox();
            this.Subject_TextBox = new System.Windows.Forms.TextBox();
            this.Body_TextBox = new System.Windows.Forms.TextBox();
            this.Browse_Button = new System.Windows.Forms.Button();
            this.Send_Email_Button = new System.Windows.Forms.Button();
            this.HelpfulltoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Browse_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Body_panel_Left = new System.Windows.Forms.Panel();
            this.Body_panel_Up = new System.Windows.Forms.Panel();
            this.Body_panel_Down = new System.Windows.Forms.Panel();
            this.Body_panel_Right = new System.Windows.Forms.Panel();
            this.TimeFormat_Label = new System.Windows.Forms.Label();
            this.DateFormat_Label = new System.Windows.Forms.Label();
            this.DateAndTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Your_Email_ID_Label
            // 
            this.Your_Email_ID_Label.AutoSize = true;
            this.Your_Email_ID_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Your_Email_ID_Label.Location = new System.Drawing.Point(23, 9);
            this.Your_Email_ID_Label.Name = "Your_Email_ID_Label";
            this.Your_Email_ID_Label.Size = new System.Drawing.Size(101, 16);
            this.Your_Email_ID_Label.TabIndex = 0;
            this.Your_Email_ID_Label.Text = "Your Email ID :";
            // 
            // Recievers_Email_Label
            // 
            this.Recievers_Email_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Recievers_Email_Label.AutoSize = true;
            this.Recievers_Email_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recievers_Email_Label.Location = new System.Drawing.Point(23, 52);
            this.Recievers_Email_Label.Name = "Recievers_Email_Label";
            this.Recievers_Email_Label.Size = new System.Drawing.Size(117, 16);
            this.Recievers_Email_Label.TabIndex = 1;
            this.Recievers_Email_Label.Text = "Reciever\'s Email :";
            // 
            // Add_Attachment_Label
            // 
            this.Add_Attachment_Label.AutoSize = true;
            this.Add_Attachment_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Attachment_Label.Location = new System.Drawing.Point(23, 94);
            this.Add_Attachment_Label.Name = "Add_Attachment_Label";
            this.Add_Attachment_Label.Size = new System.Drawing.Size(127, 16);
            this.Add_Attachment_Label.TabIndex = 2;
            this.Add_Attachment_Label.Text = "Add Attachment :";
            // 
            // Subject_Label
            // 
            this.Subject_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Subject_Label.AutoSize = true;
            this.Subject_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_Label.Location = new System.Drawing.Point(23, 143);
            this.Subject_Label.Name = "Subject_Label";
            this.Subject_Label.Size = new System.Drawing.Size(63, 16);
            this.Subject_Label.TabIndex = 3;
            this.Subject_Label.Text = "Subject :";
            // 
            // Body_Label
            // 
            this.Body_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Body_Label.AutoSize = true;
            this.Body_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Body_Label.Location = new System.Drawing.Point(23, 205);
            this.Body_Label.Name = "Body_Label";
            this.Body_Label.Size = new System.Drawing.Size(47, 16);
            this.Body_Label.TabIndex = 4;
            this.Body_Label.Text = "Body :";
            // 
            // Your_Email_ID_TextBox
            // 
            this.Your_Email_ID_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Your_Email_ID_TextBox.Location = new System.Drawing.Point(173, 8);
            this.Your_Email_ID_TextBox.MaximumSize = new System.Drawing.Size(700, 20);
            this.Your_Email_ID_TextBox.Name = "Your_Email_ID_TextBox";
            this.Your_Email_ID_TextBox.Size = new System.Drawing.Size(209, 20);
            this.Your_Email_ID_TextBox.TabIndex = 5;
            // 
            // Your_Password_Label
            // 
            this.Your_Password_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Your_Password_Label.AutoSize = true;
            this.Your_Password_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Your_Password_Label.Location = new System.Drawing.Point(408, 9);
            this.Your_Password_Label.Name = "Your_Password_Label";
            this.Your_Password_Label.Size = new System.Drawing.Size(109, 16);
            this.Your_Password_Label.TabIndex = 6;
            this.Your_Password_Label.Text = "Your Password :";
            this.Your_Password_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Your_Password_TextBox
            // 
            this.Your_Password_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Your_Password_TextBox.Location = new System.Drawing.Point(532, 8);
            this.Your_Password_TextBox.Name = "Your_Password_TextBox";
            this.Your_Password_TextBox.PasswordChar = '●';
            this.Your_Password_TextBox.Size = new System.Drawing.Size(192, 20);
            this.Your_Password_TextBox.TabIndex = 7;
            this.Your_Password_TextBox.TextChanged += new System.EventHandler(this.Your_Password_TextBox_TextChanged);
            // 
            // Recievers_Email_TextBox
            // 
            this.Recievers_Email_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Recievers_Email_TextBox.Location = new System.Drawing.Point(173, 51);
            this.Recievers_Email_TextBox.Name = "Recievers_Email_TextBox";
            this.Recievers_Email_TextBox.Size = new System.Drawing.Size(551, 20);
            this.Recievers_Email_TextBox.TabIndex = 8;
            this.HelpfulltoolTip.SetToolTip(this.Recievers_Email_TextBox, "If you desire to write multiple email addresses please separate them by a come \"," +
        "\".");
            // 
            // Add_Attachment_TextBox
            // 
            this.Add_Attachment_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_Attachment_TextBox.Location = new System.Drawing.Point(173, 93);
            this.Add_Attachment_TextBox.Name = "Add_Attachment_TextBox";
            this.Add_Attachment_TextBox.Size = new System.Drawing.Size(436, 20);
            this.Add_Attachment_TextBox.TabIndex = 9;
            // 
            // Subject_TextBox
            // 
            this.Subject_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Subject_TextBox.Location = new System.Drawing.Point(173, 142);
            this.Subject_TextBox.Name = "Subject_TextBox";
            this.Subject_TextBox.Size = new System.Drawing.Size(551, 20);
            this.Subject_TextBox.TabIndex = 10;
            // 
            // Body_TextBox
            // 
            this.Body_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Body_TextBox.Location = new System.Drawing.Point(173, 204);
            this.Body_TextBox.Multiline = true;
            this.Body_TextBox.Name = "Body_TextBox";
            this.Body_TextBox.Size = new System.Drawing.Size(551, 108);
            this.Body_TextBox.TabIndex = 11;
            // 
            // Browse_Button
            // 
            this.Browse_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse_Button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Browse_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse_Button.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse_Button.Image = ((System.Drawing.Image)(resources.GetObject("Browse_Button.Image")));
            this.Browse_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Browse_Button.Location = new System.Drawing.Point(642, 91);
            this.Browse_Button.Name = "Browse_Button";
            this.Browse_Button.Size = new System.Drawing.Size(82, 23);
            this.Browse_Button.TabIndex = 12;
            this.Browse_Button.Text = "Browse";
            this.Browse_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Browse_Button.UseVisualStyleBackColor = false;
            this.Browse_Button.Click += new System.EventHandler(this.Browse_Button_Click);
            // 
            // Send_Email_Button
            // 
            this.Send_Email_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Send_Email_Button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Send_Email_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send_Email_Button.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_Email_Button.Image = global::Email_Client.Properties.Resources.iconfinder_309_Email_Check_2124310;
            this.Send_Email_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Send_Email_Button.Location = new System.Drawing.Point(631, 334);
            this.Send_Email_Button.Name = "Send_Email_Button";
            this.Send_Email_Button.Size = new System.Drawing.Size(109, 29);
            this.Send_Email_Button.TabIndex = 13;
            this.Send_Email_Button.Text = "Send Email";
            this.Send_Email_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Send_Email_Button.UseVisualStyleBackColor = false;
            this.Send_Email_Button.Click += new System.EventHandler(this.Send_Email_Button_Click);
            // 
            // Browse_openFileDialog
            // 
            this.Browse_openFileDialog.FileName = "openFileDialog1";
            // 
            // Body_panel_Left
            // 
            this.Body_panel_Left.BackColor = System.Drawing.Color.Indigo;
            this.Body_panel_Left.Location = new System.Drawing.Point(163, 204);
            this.Body_panel_Left.Name = "Body_panel_Left";
            this.Body_panel_Left.Size = new System.Drawing.Size(10, 108);
            this.Body_panel_Left.TabIndex = 14;
            // 
            // Body_panel_Up
            // 
            this.Body_panel_Up.BackColor = System.Drawing.Color.Indigo;
            this.Body_panel_Up.Location = new System.Drawing.Point(163, 194);
            this.Body_panel_Up.Name = "Body_panel_Up";
            this.Body_panel_Up.Size = new System.Drawing.Size(571, 10);
            this.Body_panel_Up.TabIndex = 15;
            // 
            // Body_panel_Down
            // 
            this.Body_panel_Down.BackColor = System.Drawing.Color.Indigo;
            this.Body_panel_Down.CausesValidation = false;
            this.Body_panel_Down.Location = new System.Drawing.Point(163, 312);
            this.Body_panel_Down.Name = "Body_panel_Down";
            this.Body_panel_Down.Size = new System.Drawing.Size(571, 10);
            this.Body_panel_Down.TabIndex = 16;
            this.Body_panel_Down.Paint += new System.Windows.Forms.PaintEventHandler(this.Body_panel_Down_Paint);
            // 
            // Body_panel_Right
            // 
            this.Body_panel_Right.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Body_panel_Right.BackColor = System.Drawing.Color.Indigo;
            this.Body_panel_Right.Location = new System.Drawing.Point(724, 204);
            this.Body_panel_Right.Name = "Body_panel_Right";
            this.Body_panel_Right.Size = new System.Drawing.Size(10, 108);
            this.Body_panel_Right.TabIndex = 17;
            // 
            // TimeFormat_Label
            // 
            this.TimeFormat_Label.AutoSize = true;
            this.TimeFormat_Label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeFormat_Label.Location = new System.Drawing.Point(38, 284);
            this.TimeFormat_Label.Name = "TimeFormat_Label";
            this.TimeFormat_Label.Size = new System.Drawing.Size(45, 18);
            this.TimeFormat_Label.TabIndex = 18;
            this.TimeFormat_Label.Text = "00:00";
            // 
            // DateFormat_Label
            // 
            this.DateFormat_Label.AutoSize = true;
            this.DateFormat_Label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFormat_Label.Location = new System.Drawing.Point(38, 309);
            this.DateFormat_Label.Name = "DateFormat_Label";
            this.DateFormat_Label.Size = new System.Drawing.Size(64, 18);
            this.DateFormat_Label.TabIndex = 19;
            this.DateFormat_Label.Text = "0/0/0000";
            // 
            // DateAndTime
            // 
            this.DateAndTime.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 375);
            this.Controls.Add(this.DateFormat_Label);
            this.Controls.Add(this.TimeFormat_Label);
            this.Controls.Add(this.Body_panel_Right);
            this.Controls.Add(this.Body_panel_Down);
            this.Controls.Add(this.Body_panel_Up);
            this.Controls.Add(this.Body_panel_Left);
            this.Controls.Add(this.Send_Email_Button);
            this.Controls.Add(this.Browse_Button);
            this.Controls.Add(this.Body_TextBox);
            this.Controls.Add(this.Subject_TextBox);
            this.Controls.Add(this.Add_Attachment_TextBox);
            this.Controls.Add(this.Recievers_Email_TextBox);
            this.Controls.Add(this.Your_Password_TextBox);
            this.Controls.Add(this.Your_Password_Label);
            this.Controls.Add(this.Your_Email_ID_TextBox);
            this.Controls.Add(this.Body_Label);
            this.Controls.Add(this.Subject_Label);
            this.Controls.Add(this.Add_Attachment_Label);
            this.Controls.Add(this.Recievers_Email_Label);
            this.Controls.Add(this.Your_Email_ID_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Sender";
            this.MaximumSizeChanged += new System.EventHandler(this.Form1_MaximumSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Your_Email_ID_Label;
        private System.Windows.Forms.Label Recievers_Email_Label;
        private System.Windows.Forms.Label Add_Attachment_Label;
        private System.Windows.Forms.Label Subject_Label;
        private System.Windows.Forms.Label Body_Label;
        private System.Windows.Forms.TextBox Your_Email_ID_TextBox;
        private System.Windows.Forms.Label Your_Password_Label;
        private System.Windows.Forms.TextBox Your_Password_TextBox;
        private System.Windows.Forms.TextBox Recievers_Email_TextBox;
        private System.Windows.Forms.TextBox Add_Attachment_TextBox;
        private System.Windows.Forms.TextBox Subject_TextBox;
        private System.Windows.Forms.TextBox Body_TextBox;
        private System.Windows.Forms.Button Browse_Button;
        private System.Windows.Forms.Button Send_Email_Button;
        private System.Windows.Forms.ToolTip HelpfulltoolTip;
        private System.Windows.Forms.OpenFileDialog Browse_openFileDialog;
        private System.Windows.Forms.Panel Body_panel_Left;
        private System.Windows.Forms.Panel Body_panel_Up;
        private System.Windows.Forms.Panel Body_panel_Right;
        private System.Windows.Forms.Panel Body_panel_Down;
        private System.Windows.Forms.Label TimeFormat_Label;
        private System.Windows.Forms.Label DateFormat_Label;
        private System.Windows.Forms.Timer DateAndTime;
    }
}

