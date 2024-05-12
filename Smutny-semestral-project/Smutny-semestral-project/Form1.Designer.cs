namespace Smutny_semestral_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CarEnteringButton = new Button();
            InStreetLightRed = new RadioButton();
            InStreetLightGreen = new RadioButton();
            CarLeavingButton = new Button();
            FrontDoor = new Panel();
            CarReadyButton = new Button();
            BackDoor = new Panel();
            CarPictureBox = new PictureBox();
            GoofCarButton = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            OutStreetLightGreen = new RadioButton();
            OutStreetLightRed = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)CarPictureBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // CarEnteringButton
            // 
            CarEnteringButton.Enabled = false;
            CarEnteringButton.Location = new Point(144, 76);
            CarEnteringButton.Name = "CarEnteringButton";
            CarEnteringButton.Size = new Size(94, 29);
            CarEnteringButton.TabIndex = 0;
            CarEnteringButton.Text = "->";
            CarEnteringButton.UseVisualStyleBackColor = true;
            CarEnteringButton.Click += CarEnteringButton_Click;
            // 
            // InStreetLightRed
            // 
            InStreetLightRed.AutoSize = true;
            InStreetLightRed.BackColor = Color.Red;
            InStreetLightRed.Checked = true;
            InStreetLightRed.Enabled = false;
            InStreetLightRed.Location = new Point(0, 46);
            InStreetLightRed.Name = "InStreetLightRed";
            InStreetLightRed.Padding = new Padding(5);
            InStreetLightRed.Size = new Size(27, 26);
            InStreetLightRed.TabIndex = 2;
            InStreetLightRed.TabStop = true;
            InStreetLightRed.UseVisualStyleBackColor = false;
            // 
            // InStreetLightGreen
            // 
            InStreetLightGreen.AutoSize = true;
            InStreetLightGreen.BackColor = Color.LawnGreen;
            InStreetLightGreen.Enabled = false;
            InStreetLightGreen.Location = new Point(0, 14);
            InStreetLightGreen.Name = "InStreetLightGreen";
            InStreetLightGreen.Padding = new Padding(5);
            InStreetLightGreen.Size = new Size(27, 26);
            InStreetLightGreen.TabIndex = 3;
            InStreetLightGreen.UseVisualStyleBackColor = false;
            // 
            // CarLeavingButton
            // 
            CarLeavingButton.Enabled = false;
            CarLeavingButton.Location = new Point(531, 76);
            CarLeavingButton.Name = "CarLeavingButton";
            CarLeavingButton.Size = new Size(92, 31);
            CarLeavingButton.TabIndex = 4;
            CarLeavingButton.Text = "->";
            CarLeavingButton.UseVisualStyleBackColor = true;
            CarLeavingButton.Click += CarLeavingButton_Click;
            // 
            // FrontDoor
            // 
            FrontDoor.BackColor = Color.Black;
            FrontDoor.Location = new Point(239, 153);
            FrontDoor.Name = "FrontDoor";
            FrontDoor.Size = new Size(57, 267);
            FrontDoor.TabIndex = 5;
            // 
            // CarReadyButton
            // 
            CarReadyButton.Location = new Point(34, 76);
            CarReadyButton.Name = "CarReadyButton";
            CarReadyButton.Size = new Size(94, 29);
            CarReadyButton.TabIndex = 0;
            CarReadyButton.Text = "Car ready";
            CarReadyButton.UseVisualStyleBackColor = true;
            CarReadyButton.Click += CarReadyButton_Click;
            // 
            // BackDoor
            // 
            BackDoor.BackColor = Color.Black;
            BackDoor.Location = new Point(672, 153);
            BackDoor.Name = "BackDoor";
            BackDoor.Size = new Size(57, 267);
            BackDoor.TabIndex = 6;
            // 
            // CarPictureBox
            // 
            CarPictureBox.BackgroundImage = (Image)resources.GetObject("CarPictureBox.BackgroundImage");
            CarPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            CarPictureBox.Location = new Point(34, 352);
            CarPictureBox.Margin = new Padding(3, 4, 3, 4);
            CarPictureBox.Name = "CarPictureBox";
            CarPictureBox.Size = new Size(143, 68);
            CarPictureBox.TabIndex = 7;
            CarPictureBox.TabStop = false;
            // 
            // GoofCarButton
            // 
            GoofCarButton.Enabled = false;
            GoofCarButton.Location = new Point(426, 76);
            GoofCarButton.Margin = new Padding(3, 4, 3, 4);
            GoofCarButton.Name = "GoofCarButton";
            GoofCarButton.Size = new Size(86, 31);
            GoofCarButton.TabIndex = 8;
            GoofCarButton.Text = "Goof car";
            GoofCarButton.UseVisualStyleBackColor = true;
            GoofCarButton.Click += GoofCarButton_Click;
            // 
            // Timer
            // 
            Timer.Interval = 1;
            Timer.Tick += Timer_Tick;
            // 
            // OutStreetLightGreen
            // 
            OutStreetLightGreen.AutoSize = true;
            OutStreetLightGreen.BackColor = Color.Lime;
            OutStreetLightGreen.Enabled = false;
            OutStreetLightGreen.Location = new Point(0, 12);
            OutStreetLightGreen.Name = "OutStreetLightGreen";
            OutStreetLightGreen.Padding = new Padding(5);
            OutStreetLightGreen.Size = new Size(27, 26);
            OutStreetLightGreen.TabIndex = 9;
            OutStreetLightGreen.UseVisualStyleBackColor = false;
            // 
            // OutStreetLightRed
            // 
            OutStreetLightRed.AutoSize = true;
            OutStreetLightRed.BackColor = Color.Red;
            OutStreetLightRed.Checked = true;
            OutStreetLightRed.Enabled = false;
            OutStreetLightRed.Location = new Point(0, 44);
            OutStreetLightRed.Name = "OutStreetLightRed";
            OutStreetLightRed.Padding = new Padding(5);
            OutStreetLightRed.Size = new Size(27, 26);
            OutStreetLightRed.TabIndex = 10;
            OutStreetLightRed.TabStop = true;
            OutStreetLightRed.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(InStreetLightGreen);
            groupBox1.Controls.Add(InStreetLightRed);
            groupBox1.Location = new Point(244, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(29, 77);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(OutStreetLightGreen);
            groupBox2.Controls.Add(OutStreetLightRed);
            groupBox2.Location = new Point(672, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(30, 76);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(GoofCarButton);
            Controls.Add(CarPictureBox);
            Controls.Add(BackDoor);
            Controls.Add(CarReadyButton);
            Controls.Add(FrontDoor);
            Controls.Add(CarLeavingButton);
            Controls.Add(CarEnteringButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)CarPictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button CarEnteringButton;
        private RadioButton InStreetLightRed;
        private RadioButton InStreetLightGreen;
        private Button CarLeavingButton;
        private Panel FrontDoor;
        private Button CarReadyButton;
        private Panel BackDoor;
        private PictureBox CarPictureBox;
        private Button GoofCarButton;
        private System.Windows.Forms.Timer Timer;
        private RadioButton OutStreetLightGreen;
        private RadioButton OutStreetLightRed;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
