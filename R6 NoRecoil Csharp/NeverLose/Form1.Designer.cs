
namespace NeverLose
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.relyGroupBox1 = new RelyUI.Controls.RelyGroupBox();
            this.relyButton2 = new RelyUI.Controls.RelyButton();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.relyGroupBox2 = new RelyUI.Controls.RelyGroupBox();
            this.relyButton5 = new RelyUI.Controls.RelyButton();
            this.tbMax = new RelyUI.Controls.RelyTrackBar();
            this.lblMax = new RelyUI.Controls.RelyLabel();
            this.tbIncrease = new RelyUI.Controls.RelyTrackBar();
            this.lblIncrease = new RelyUI.Controls.RelyLabel();
            this.tbStep = new RelyUI.Controls.RelyTrackBar();
            this.lblStep = new RelyUI.Controls.RelyLabel();
            this.relyGroupBox3 = new RelyUI.Controls.RelyGroupBox();
            this.lblCheckProcess = new RelyUI.Controls.RelyLabel();
            this.relyLabel11 = new RelyUI.Controls.RelyLabel();
            this.lblState = new RelyUI.Controls.RelyLabel();
            this.relyLabel8 = new RelyUI.Controls.RelyLabel();
            this.relyLabel7 = new RelyUI.Controls.RelyLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.relyGroupBox1.SuspendLayout();
            this.relyGroupBox2.SuspendLayout();
            this.relyGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NeverLose.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // relyGroupBox1
            // 
            this.relyGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.relyGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.relyGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(1)))));
            this.relyGroupBox1.Controls.Add(this.relyButton2);
            this.relyGroupBox1.Controls.Add(this.pictureBox1);
            this.relyGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.relyGroupBox1.Location = new System.Drawing.Point(6, 53);
            this.relyGroupBox1.Name = "relyGroupBox1";
            this.relyGroupBox1.ShowText = true;
            this.relyGroupBox1.Size = new System.Drawing.Size(272, 346);
            this.relyGroupBox1.TabIndex = 2;
            this.relyGroupBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // relyButton2
            // 
            this.relyButton2.BackColor = System.Drawing.Color.Transparent;
            this.relyButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(1)))));
            this.relyButton2.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.relyButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.relyButton2.ForeColor = System.Drawing.Color.Black;
            this.relyButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.relyButton2.Location = new System.Drawing.Point(27, 294);
            this.relyButton2.Name = "relyButton2";
            this.relyButton2.Rounded = true;
            this.relyButton2.RoundRadius = 3;
            this.relyButton2.Size = new System.Drawing.Size(220, 34);
            this.relyButton2.TabIndex = 5;
            this.relyButton2.Text = "About Us";
            this.relyButton2.TextColor = System.Drawing.Color.Black;
            this.relyButton2.Click += new System.EventHandler(this.relyButton2_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 13;
            this.bunifuElipse1.TargetControl = this;
            // 
            // relyGroupBox2
            // 
            this.relyGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.relyGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.relyGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(1)))));
            this.relyGroupBox2.Controls.Add(this.relyButton5);
            this.relyGroupBox2.Controls.Add(this.tbMax);
            this.relyGroupBox2.Controls.Add(this.lblMax);
            this.relyGroupBox2.Controls.Add(this.tbIncrease);
            this.relyGroupBox2.Controls.Add(this.lblIncrease);
            this.relyGroupBox2.Controls.Add(this.tbStep);
            this.relyGroupBox2.Controls.Add(this.lblStep);
            this.relyGroupBox2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.relyGroupBox2.Location = new System.Drawing.Point(277, 53);
            this.relyGroupBox2.Name = "relyGroupBox2";
            this.relyGroupBox2.ShowText = true;
            this.relyGroupBox2.Size = new System.Drawing.Size(394, 244);
            this.relyGroupBox2.TabIndex = 3;
            this.relyGroupBox2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // relyButton5
            // 
            this.relyButton5.BackColor = System.Drawing.Color.Transparent;
            this.relyButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(1)))));
            this.relyButton5.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.relyButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.relyButton5.ForeColor = System.Drawing.Color.Black;
            this.relyButton5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.relyButton5.Location = new System.Drawing.Point(21, 190);
            this.relyButton5.Name = "relyButton5";
            this.relyButton5.Rounded = true;
            this.relyButton5.RoundRadius = 3;
            this.relyButton5.Size = new System.Drawing.Size(351, 34);
            this.relyButton5.TabIndex = 11;
            this.relyButton5.Text = "Reset Settings";
            this.relyButton5.TextColor = System.Drawing.Color.Black;
            this.relyButton5.Click += new System.EventHandler(this.relyButton5_Click);
            // 
            // tbMax
            // 
            this.tbMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.tbMax.Location = new System.Drawing.Point(21, 153);
            this.tbMax.Maximum = 30;
            this.tbMax.Minimum = 0;
            this.tbMax.Name = "tbMax";
            this.tbMax.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(1)))));
            this.tbMax.ShowValue = false;
            this.tbMax.Size = new System.Drawing.Size(351, 23);
            this.tbMax.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tbMax.Style = RelyUI.Controls.RelyTrackBar.Styles.Slider;
            this.tbMax.TabIndex = 1;
            this.tbMax.Text = "relyTrackBar1";
            this.tbMax.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tbMax.Value = 0;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.Transparent;
            this.lblMax.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lblMax.Location = new System.Drawing.Point(17, 126);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(98, 20);
            this.lblMax.TabIndex = 0;
            this.lblMax.Text = "● Max Inc (0):";
            // 
            // tbIncrease
            // 
            this.tbIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.tbIncrease.Location = new System.Drawing.Point(21, 99);
            this.tbIncrease.Maximum = 10;
            this.tbIncrease.Minimum = 0;
            this.tbIncrease.Name = "tbIncrease";
            this.tbIncrease.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(1)))));
            this.tbIncrease.ShowValue = false;
            this.tbIncrease.Size = new System.Drawing.Size(351, 23);
            this.tbIncrease.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tbIncrease.Style = RelyUI.Controls.RelyTrackBar.Styles.Slider;
            this.tbIncrease.TabIndex = 1;
            this.tbIncrease.Text = "relyTrackBar1";
            this.tbIncrease.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tbIncrease.Value = 0;
            // 
            // lblIncrease
            // 
            this.lblIncrease.AutoSize = true;
            this.lblIncrease.BackColor = System.Drawing.Color.Transparent;
            this.lblIncrease.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblIncrease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lblIncrease.Location = new System.Drawing.Point(17, 72);
            this.lblIncrease.Name = "lblIncrease";
            this.lblIncrease.Size = new System.Drawing.Size(101, 20);
            this.lblIncrease.TabIndex = 0;
            this.lblIncrease.Text = "● Increase (0):";
            // 
            // tbStep
            // 
            this.tbStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.tbStep.Location = new System.Drawing.Point(21, 46);
            this.tbStep.Maximum = 20;
            this.tbStep.Minimum = 1;
            this.tbStep.Name = "tbStep";
            this.tbStep.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(1)))));
            this.tbStep.ShowValue = false;
            this.tbStep.Size = new System.Drawing.Size(351, 23);
            this.tbStep.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tbStep.Style = RelyUI.Controls.RelyTrackBar.Styles.Slider;
            this.tbStep.TabIndex = 1;
            this.tbStep.Text = "relyTrackBar1";
            this.tbStep.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tbStep.Value = 1;
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.BackColor = System.Drawing.Color.Transparent;
            this.lblStep.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lblStep.Location = new System.Drawing.Point(17, 19);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(77, 20);
            this.lblStep.TabIndex = 0;
            this.lblStep.Text = "● Step (1):";
            // 
            // relyGroupBox3
            // 
            this.relyGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.relyGroupBox3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.relyGroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(1)))));
            this.relyGroupBox3.Controls.Add(this.lblCheckProcess);
            this.relyGroupBox3.Controls.Add(this.relyLabel11);
            this.relyGroupBox3.Controls.Add(this.lblState);
            this.relyGroupBox3.Controls.Add(this.relyLabel8);
            this.relyGroupBox3.Controls.Add(this.relyLabel7);
            this.relyGroupBox3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.relyGroupBox3.Location = new System.Drawing.Point(277, 296);
            this.relyGroupBox3.Name = "relyGroupBox3";
            this.relyGroupBox3.ShowText = true;
            this.relyGroupBox3.Size = new System.Drawing.Size(394, 103);
            this.relyGroupBox3.TabIndex = 4;
            this.relyGroupBox3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // lblCheckProcess
            // 
            this.lblCheckProcess.AutoSize = true;
            this.lblCheckProcess.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckProcess.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCheckProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblCheckProcess.Location = new System.Drawing.Point(119, 42);
            this.lblCheckProcess.Name = "lblCheckProcess";
            this.lblCheckProcess.Size = new System.Drawing.Size(82, 20);
            this.lblCheckProcess.TabIndex = 10;
            this.lblCheckProcess.Text = "Not Open !";
            // 
            // relyLabel11
            // 
            this.relyLabel11.AutoSize = true;
            this.relyLabel11.BackColor = System.Drawing.Color.Transparent;
            this.relyLabel11.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.relyLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.relyLabel11.Location = new System.Drawing.Point(17, 42);
            this.relyLabel11.Name = "relyLabel11";
            this.relyLabel11.Size = new System.Drawing.Size(106, 20);
            this.relyLabel11.TabIndex = 9;
            this.relyLabel11.Text = "● RainbowSix: ";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblState.Location = new System.Drawing.Point(79, 65);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(76, 20);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Disabled !";
            // 
            // relyLabel8
            // 
            this.relyLabel8.AutoSize = true;
            this.relyLabel8.BackColor = System.Drawing.Color.Transparent;
            this.relyLabel8.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.relyLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.relyLabel8.Location = new System.Drawing.Point(17, 64);
            this.relyLabel8.Name = "relyLabel8";
            this.relyLabel8.Size = new System.Drawing.Size(69, 20);
            this.relyLabel8.TabIndex = 1;
            this.relyLabel8.Text = "● Status: ";
            // 
            // relyLabel7
            // 
            this.relyLabel7.AutoSize = true;
            this.relyLabel7.BackColor = System.Drawing.Color.Transparent;
            this.relyLabel7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.relyLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.relyLabel7.Location = new System.Drawing.Point(17, 18);
            this.relyLabel7.Name = "relyLabel7";
            this.relyLabel7.Size = new System.Drawing.Size(223, 20);
            this.relyLabel7.TabIndex = 0;
            this.relyLabel7.Text = "● Activate / DeActivate Key: [F2]";
            // 
            // Form1
            // 
            this.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(1)))));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 406);
            this.ControlBoxColor = System.Drawing.Color.Black;
            this.Controls.Add(this.relyGroupBox3);
            this.Controls.Add(this.relyGroupBox2);
            this.Controls.Add(this.relyGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NeverLose (V1.8.1) ~ Developer: </SirProgrammER>";
            this.TextColor = System.Drawing.Color.Black;
            this.TitleText = "NeverLose (V1.8.1) ~ Developer: </SirProgrammER>";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.relyGroupBox1, 0);
            this.Controls.SetChildIndex(this.relyGroupBox2, 0);
            this.Controls.SetChildIndex(this.relyGroupBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.relyGroupBox1.ResumeLayout(false);
            this.relyGroupBox2.ResumeLayout(false);
            this.relyGroupBox2.PerformLayout();
            this.relyGroupBox3.ResumeLayout(false);
            this.relyGroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private RelyUI.Controls.RelyGroupBox relyGroupBox1;
        private ns1.BunifuElipse bunifuElipse1;
        private RelyUI.Controls.RelyGroupBox relyGroupBox2;
        private RelyUI.Controls.RelyButton relyButton2;
        private RelyUI.Controls.RelyTrackBar tbMax;
        private RelyUI.Controls.RelyLabel lblMax;
        private RelyUI.Controls.RelyTrackBar tbIncrease;
        private RelyUI.Controls.RelyLabel lblIncrease;
        private RelyUI.Controls.RelyTrackBar tbStep;
        private RelyUI.Controls.RelyLabel lblStep;
        private RelyUI.Controls.RelyGroupBox relyGroupBox3;
        private RelyUI.Controls.RelyLabel lblState;
        private RelyUI.Controls.RelyLabel relyLabel8;
        private RelyUI.Controls.RelyLabel relyLabel7;
        private RelyUI.Controls.RelyLabel lblCheckProcess;
        private RelyUI.Controls.RelyLabel relyLabel11;
        private RelyUI.Controls.RelyButton relyButton5;
    }
}

