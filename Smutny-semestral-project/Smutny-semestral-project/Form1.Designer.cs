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
            CarEnteringButton = new Button();
            StreetLightRed = new RadioButton();
            StreetLightGreen = new RadioButton();
            CarLeavingButton = new Button();
            FrontDoor = new Panel();
            CarReadyButton = new Button();
            SuspendLayout();
            // 
            // CarEnteringButton
            // 
            CarEnteringButton.Enabled = false;
            CarEnteringButton.Location = new Point(148, 76);
            CarEnteringButton.Name = "CarEnteringButton";
            CarEnteringButton.Size = new Size(94, 29);
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
            StreetLightRed.Location = new Point(271, 43);
            StreetLightRed.Name = "StreetLightRed";
            StreetLightRed.Padding = new Padding(5);
            StreetLightRed.Size = new Size(27, 26);
            StreetLightRed.TabIndex = 2;
            StreetLightRed.TabStop = true;
            StreetLightRed.UseVisualStyleBackColor = false;
            StreetLightRed.CheckedChanged += StreetLightRed_CheckedChanged;
            // 
            // StreetLightGreen
            // 
            StreetLightGreen.AutoSize = true;
            StreetLightGreen.BackColor = Color.LawnGreen;
            StreetLightGreen.Enabled = false;
            StreetLightGreen.Location = new Point(271, 76);
            StreetLightGreen.Name = "StreetLightGreen";
            StreetLightGreen.Padding = new Padding(5);
            StreetLightGreen.Size = new Size(27, 26);
            StreetLightGreen.TabIndex = 3;
            StreetLightGreen.UseVisualStyleBackColor = false;
            // 
            // CarLeavingButton
            // 
            CarLeavingButton.Enabled = false;
            CarLeavingButton.Location = new Point(636, 76);
            CarLeavingButton.Name = "CarLeavingButton";
            CarLeavingButton.Size = new Size(94, 29);
            CarLeavingButton.TabIndex = 4;
            CarLeavingButton.Text = "->";
            CarLeavingButton.UseVisualStyleBackColor = true;
            CarLeavingButton.Click += CarLeavingButton_Click;
            // 
            // FrontDoor
            // 
            FrontDoor.BackColor = Color.Black;
            FrontDoor.Location = new Point(196, 167);
            FrontDoor.Name = "FrontDoor";
            FrontDoor.Size = new Size(100, 200);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CarReadyButton);
            Controls.Add(FrontDoor);
            Controls.Add(CarLeavingButton);
            Controls.Add(StreetLightGreen);
            Controls.Add(StreetLightRed);
            Controls.Add(CarEnteringButton);
            Name = "Form1";
            Text = "Form1";
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
    }
}
