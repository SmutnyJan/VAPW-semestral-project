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
            StreetLightRed = new RadioButton();
            StreetLightGreen = new RadioButton();
            CarLeavingButton = new Button();
            FrontDoor = new Panel();
            CarReadyButton = new Button();
            BackDoor = new Panel();
            CarPictureBox = new PictureBox();
            GoofCarButton = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)CarPictureBox).BeginInit();
            SuspendLayout();
            // 
            // CarEnteringButton
            // 
            CarEnteringButton.Enabled = false;
            CarEnteringButton.Location = new Point(130, 57);
            CarEnteringButton.Margin = new Padding(3, 2, 3, 2);
            CarEnteringButton.Name = "CarEnteringButton";
            CarEnteringButton.Size = new Size(82, 22);
            CarEnteringButton.TabIndex = 0;
            CarEnteringButton.Text = "->";
            CarEnteringButton.UseVisualStyleBackColor = true;
            CarEnteringButton.Click += CarEnteringButton_Click;
            // 
            // StreetLightRed
            // 
            StreetLightRed.AutoSize = true;
            StreetLightRed.BackColor = Color.Red;
            StreetLightRed.Checked = true;
            StreetLightRed.Enabled = false;
            StreetLightRed.Location = new Point(237, 32);
            StreetLightRed.Margin = new Padding(3, 2, 3, 2);
            StreetLightRed.Name = "StreetLightRed";
            StreetLightRed.Padding = new Padding(4);
            StreetLightRed.Size = new Size(22, 21);
            StreetLightRed.TabIndex = 2;
            StreetLightRed.TabStop = true;
            StreetLightRed.UseVisualStyleBackColor = false;
            // 
            // StreetLightGreen
            // 
            StreetLightGreen.AutoSize = true;
            StreetLightGreen.BackColor = Color.LawnGreen;
            StreetLightGreen.Enabled = false;
            StreetLightGreen.Location = new Point(237, 57);
            StreetLightGreen.Margin = new Padding(3, 2, 3, 2);
            StreetLightGreen.Name = "StreetLightGreen";
            StreetLightGreen.Padding = new Padding(4);
            StreetLightGreen.Size = new Size(22, 21);
            StreetLightGreen.TabIndex = 3;
            StreetLightGreen.UseVisualStyleBackColor = false;
            // 
            // CarLeavingButton
            // 
            CarLeavingButton.Enabled = false;
            CarLeavingButton.Location = new Point(556, 57);
            CarLeavingButton.Margin = new Padding(3, 2, 3, 2);
            CarLeavingButton.Name = "CarLeavingButton";
            CarLeavingButton.Size = new Size(82, 22);
            CarLeavingButton.TabIndex = 4;
            CarLeavingButton.Text = "->";
            CarLeavingButton.UseVisualStyleBackColor = true;
            CarLeavingButton.Click += CarLeavingButton_Click;
            // 
            // FrontDoor
            // 
            FrontDoor.BackColor = Color.Black;
            FrontDoor.Location = new Point(209, 115);
            FrontDoor.Margin = new Padding(3, 2, 3, 2);
            FrontDoor.Name = "FrontDoor";
            FrontDoor.Size = new Size(50, 200);
            FrontDoor.TabIndex = 5;
            // 
            // CarReadyButton
            // 
            CarReadyButton.Location = new Point(30, 57);
            CarReadyButton.Margin = new Padding(3, 2, 3, 2);
            CarReadyButton.Name = "CarReadyButton";
            CarReadyButton.Size = new Size(82, 22);
            CarReadyButton.TabIndex = 0;
            CarReadyButton.Text = "Car ready";
            CarReadyButton.UseVisualStyleBackColor = true;
            CarReadyButton.Click += CarReadyButton_Click;
            // 
            // BackDoor
            // 
            BackDoor.BackColor = Color.Black;
            BackDoor.Location = new Point(588, 115);
            BackDoor.Margin = new Padding(3, 2, 3, 2);
            BackDoor.Name = "BackDoor";
            BackDoor.Size = new Size(50, 200);
            BackDoor.TabIndex = 6;
            // 
            // CarPictureBox
            // 
            CarPictureBox.BackgroundImage = (Image)resources.GetObject("CarPictureBox.BackgroundImage");
            CarPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            CarPictureBox.Location = new Point(30, 264);
            CarPictureBox.Name = "CarPictureBox";
            CarPictureBox.Size = new Size(125, 51);
            CarPictureBox.TabIndex = 7;
            CarPictureBox.TabStop = false;
            // 
            // GoofCarButton
            // 
            GoofCarButton.Enabled = false;
            GoofCarButton.Location = new Point(373, 57);
            GoofCarButton.Name = "GoofCarButton";
            GoofCarButton.Size = new Size(75, 23);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(GoofCarButton);
            Controls.Add(CarPictureBox);
            Controls.Add(BackDoor);
            Controls.Add(CarReadyButton);
            Controls.Add(FrontDoor);
            Controls.Add(CarLeavingButton);
            Controls.Add(StreetLightGreen);
            Controls.Add(StreetLightRed);
            Controls.Add(CarEnteringButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)CarPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CarEnteringButton;
        private RadioButton StreetLightRed;
        private RadioButton StreetLightGreen;
        private Button CarLeavingButton;
        private Panel FrontDoor;
        private Button CarReadyButton;
        private Panel BackDoor;
        private PictureBox CarPictureBox;
        private Button GoofCarButton;
        private System.Windows.Forms.Timer Timer;
    }
}
