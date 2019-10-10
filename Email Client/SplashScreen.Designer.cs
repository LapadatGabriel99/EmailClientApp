namespace Email_Client
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.Up_Panel = new System.Windows.Forms.Panel();
            this.Down_Panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IsLoading_Label = new System.Windows.Forms.Label();
            this.PleaseWait_Label = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.InnerBar_Rectangle = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.OuterBar_Rectangle = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.ProgressBar_timer = new System.Windows.Forms.Timer(this.components);
            this.PB_Lool_Right = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Lool_Right)).BeginInit();
            this.SuspendLayout();
            // 
            // Up_Panel
            // 
            this.Up_Panel.BackColor = System.Drawing.Color.DarkOrchid;
            this.Up_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Up_Panel.Location = new System.Drawing.Point(0, 0);
            this.Up_Panel.Name = "Up_Panel";
            this.Up_Panel.Size = new System.Drawing.Size(768, 5);
            this.Up_Panel.TabIndex = 0;
            this.Up_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Down_Panel
            // 
            this.Down_Panel.BackColor = System.Drawing.Color.DarkOrchid;
            this.Down_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Down_Panel.Location = new System.Drawing.Point(0, 411);
            this.Down_Panel.Name = "Down_Panel";
            this.Down_Panel.Size = new System.Drawing.Size(768, 3);
            this.Down_Panel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 406);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(765, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 406);
            this.panel2.TabIndex = 3;
            // 
            // IsLoading_Label
            // 
            this.IsLoading_Label.AutoSize = true;
            this.IsLoading_Label.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsLoading_Label.ForeColor = System.Drawing.Color.Indigo;
            this.IsLoading_Label.Location = new System.Drawing.Point(21, 18);
            this.IsLoading_Label.Name = "IsLoading_Label";
            this.IsLoading_Label.Size = new System.Drawing.Size(604, 79);
            this.IsLoading_Label.TabIndex = 4;
            this.IsLoading_Label.Text = "Email Client is loading ...";
            this.IsLoading_Label.Click += new System.EventHandler(this.IsLoading_Label_Click);
            // 
            // PleaseWait_Label
            // 
            this.PleaseWait_Label.AutoSize = true;
            this.PleaseWait_Label.BackColor = System.Drawing.Color.LightGray;
            this.PleaseWait_Label.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PleaseWait_Label.ForeColor = System.Drawing.Color.Indigo;
            this.PleaseWait_Label.Location = new System.Drawing.Point(358, 107);
            this.PleaseWait_Label.Name = "PleaseWait_Label";
            this.PleaseWait_Label.Size = new System.Drawing.Size(287, 57);
            this.PleaseWait_Label.TabIndex = 6;
            this.PleaseWait_Label.Text = "...Please wait...";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.InnerBar_Rectangle,
            this.OuterBar_Rectangle});
            this.shapeContainer1.Size = new System.Drawing.Size(768, 414);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // InnerBar_Rectangle
            // 
            this.InnerBar_Rectangle.BackColor = System.Drawing.Color.DarkViolet;
            this.InnerBar_Rectangle.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.InnerBar_Rectangle.BorderColor = System.Drawing.Color.DarkViolet;
            this.InnerBar_Rectangle.BorderWidth = 2;
            this.InnerBar_Rectangle.CornerRadius = 8;
            this.InnerBar_Rectangle.Location = new System.Drawing.Point(23, 371);
            this.InnerBar_Rectangle.Name = "InnerBar_Rectangle";
            this.InnerBar_Rectangle.Size = new System.Drawing.Size(17, 17);
            this.InnerBar_Rectangle.Click += new System.EventHandler(this.InnerBar_Rectangle_Click);
            // 
            // OuterBar_Rectangle
            // 
            this.OuterBar_Rectangle.BorderColor = System.Drawing.Color.Indigo;
            this.OuterBar_Rectangle.BorderWidth = 2;
            this.OuterBar_Rectangle.CornerRadius = 10;
            this.OuterBar_Rectangle.Location = new System.Drawing.Point(18, 367);
            this.OuterBar_Rectangle.Name = "OuterBar_Rectangle";
            this.OuterBar_Rectangle.Size = new System.Drawing.Size(731, 25);
            // 
            // ProgressBar_timer
            // 
            this.ProgressBar_timer.Tick += new System.EventHandler(this.ProgressTick);
            // 
            // PB_Lool_Right
            // 
            this.PB_Lool_Right.Image = ((System.Drawing.Image)(resources.GetObject("PB_Lool_Right.Image")));
            this.PB_Lool_Right.Location = new System.Drawing.Point(47, 193);
            this.PB_Lool_Right.Name = "PB_Lool_Right";
            this.PB_Lool_Right.Size = new System.Drawing.Size(679, 161);
            this.PB_Lool_Right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Lool_Right.TabIndex = 11;
            this.PB_Lool_Right.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(768, 414);
            this.Controls.Add(this.PB_Lool_Right);
            this.Controls.Add(this.PleaseWait_Label);
            this.Controls.Add(this.IsLoading_Label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Down_Panel);
            this.Controls.Add(this.Up_Panel);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Lool_Right)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Up_Panel;
        private System.Windows.Forms.Panel Down_Panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label IsLoading_Label;
        private System.Windows.Forms.Label PleaseWait_Label;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape OuterBar_Rectangle;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape InnerBar_Rectangle;
        private System.Windows.Forms.Timer ProgressBar_timer;
        private System.Windows.Forms.PictureBox PB_Lool_Right;
    }
}