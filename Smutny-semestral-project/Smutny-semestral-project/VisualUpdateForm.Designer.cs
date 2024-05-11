namespace Smutny_semestral_project
{
    partial class VisualUpdateForm
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
            groupBox1 = new GroupBox();
            TimerBasedButton = new RadioButton();
            EventBasedButton = new RadioButton();
            OKButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TimerBasedButton);
            groupBox1.Controls.Add(EventBasedButton);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose visual update ";
            // 
            // TimerBasedButton
            // 
            TimerBasedButton.AutoSize = true;
            TimerBasedButton.Location = new Point(6, 47);
            TimerBasedButton.Name = "TimerBasedButton";
            TimerBasedButton.Size = new Size(91, 19);
            TimerBasedButton.TabIndex = 1;
            TimerBasedButton.TabStop = true;
            TimerBasedButton.Text = "Timer-based";
            TimerBasedButton.UseVisualStyleBackColor = true;
            // 
            // EventBasedButton
            // 
            EventBasedButton.AutoSize = true;
            EventBasedButton.Checked = true;
            EventBasedButton.Location = new Point(6, 22);
            EventBasedButton.Name = "EventBasedButton";
            EventBasedButton.Size = new Size(90, 19);
            EventBasedButton.TabIndex = 0;
            EventBasedButton.TabStop = true;
            EventBasedButton.Text = "Event-based";
            EventBasedButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            OKButton.DialogResult = DialogResult.OK;
            OKButton.Location = new Point(137, 142);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 23);
            OKButton.TabIndex = 1;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            // 
            // VisualUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 177);
            Controls.Add(OKButton);
            Controls.Add(groupBox1);
            Name = "VisualUpdateForm";
            Text = "VisualUpdateForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton TimerBasedButton;
        private RadioButton EventBasedButton;
        private Button OKButton;
    }
}