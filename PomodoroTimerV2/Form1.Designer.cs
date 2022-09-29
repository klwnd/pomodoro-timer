namespace PomodoroTimerV2
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
            this.components = new System.ComponentModel.Container();
            this.pomodoroTimer = new System.Windows.Forms.Timer(this.components);
            this.lblStateDebug = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.lblSession = new System.Windows.Forms.Label();
            this.ButtonPause = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTimerStatus = new System.Windows.Forms.Label();
            this.lblPomodoroStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pomodoroTimer
            // 
            this.pomodoroTimer.Interval = 1000;
            this.pomodoroTimer.Tick += new System.EventHandler(this.pomodoroTimerTick);
            // 
            // lblStateDebug
            // 
            this.lblStateDebug.AutoSize = true;
            this.lblStateDebug.Location = new System.Drawing.Point(0, 397);
            this.lblStateDebug.Name = "lblStateDebug";
            this.lblStateDebug.Size = new System.Drawing.Size(42, 15);
            this.lblStateDebug.TabIndex = 8;
            this.lblStateDebug.Text = "Debug";
            this.lblStateDebug.Visible = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(121, 343);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(80, 51);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.btnStartClick);
            // 
            // lblSession
            // 
            this.lblSession.Font = new System.Drawing.Font("Roboto Thin", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSession.ForeColor = System.Drawing.Color.White;
            this.lblSession.Location = new System.Drawing.Point(0, 136);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(321, 38);
            this.lblSession.TabIndex = 9;
            this.lblSession.Text = "Session: 1";
            this.lblSession.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonPause
            // 
            this.ButtonPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.ButtonPause.FlatAppearance.BorderSize = 0;
            this.ButtonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPause.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonPause.ForeColor = System.Drawing.Color.White;
            this.ButtonPause.Location = new System.Drawing.Point(15, 343);
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.Size = new System.Drawing.Size(80, 51);
            this.ButtonPause.TabIndex = 3;
            this.ButtonPause.Text = "Pause";
            this.ButtonPause.UseVisualStyleBackColor = false;
            this.ButtonPause.Click += new System.EventHandler(this.btnPauseClick);
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Roboto Black", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(0, 174);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(321, 57);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "05:45";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(229, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Focus";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(174, 422);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(135, 51);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Pomodoro";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettingsClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(15, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnResetClick);
            // 
            // lblTimerStatus
            // 
            this.lblTimerStatus.Font = new System.Drawing.Font("Roboto Thin", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimerStatus.ForeColor = System.Drawing.Color.White;
            this.lblTimerStatus.Location = new System.Drawing.Point(0, 231);
            this.lblTimerStatus.Name = "lblTimerStatus";
            this.lblTimerStatus.Size = new System.Drawing.Size(321, 38);
            this.lblTimerStatus.TabIndex = 2;
            this.lblTimerStatus.Text = "Minutes Left";
            this.lblTimerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPomodoroStatus
            // 
            this.lblPomodoroStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPomodoroStatus.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPomodoroStatus.ForeColor = System.Drawing.Color.White;
            this.lblPomodoroStatus.Location = new System.Drawing.Point(0, 0);
            this.lblPomodoroStatus.Name = "lblPomodoroStatus";
            this.lblPomodoroStatus.Size = new System.Drawing.Size(321, 100);
            this.lblPomodoroStatus.TabIndex = 4;
            this.lblPomodoroStatus.Text = "POMODORO TIMER";
            this.lblPomodoroStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPomodoroStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 100);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(321, 487);
            this.Controls.Add(this.lblTimerStatus);
            this.Controls.Add(this.lblStateDebug);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonPause);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(337, 526);
            this.Name = "Form1";
            this.Text = "Do your Job!";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer pomodoroTimer;
        private Label lblStateDebug;
        private Button buttonStart;
        private Label lblSession;
        private Button ButtonPause;
        private Label lblTime;
        private Button button1;
        private Button btnSettings;
        private Button button2;
        private Label lblTimerStatus;
        private Label lblPomodoroStatus;
        private Panel panel1;
    }
}