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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pomodoroTimer = new System.Windows.Forms.Timer(this.components);
            this.lblStateDebug = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSession = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnFocus = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
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
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(121, 343);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 51);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStartClick);
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
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(15, 343);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(80, 51);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPauseClick);
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
            // btnFocus
            // 
            this.btnFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnFocus.FlatAppearance.BorderSize = 0;
            this.btnFocus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFocus.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFocus.ForeColor = System.Drawing.Color.White;
            this.btnFocus.Location = new System.Drawing.Point(229, 343);
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(80, 51);
            this.btnFocus.TabIndex = 5;
            this.btnFocus.Text = "Focus";
            this.btnFocus.UseVisualStyleBackColor = false;
            this.btnFocus.Click += new System.EventHandler(this.btnFocusClick);
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
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(15, 422);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 51);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnResetClick);
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
            this.lblPomodoroStatus.Click += new System.EventHandler(this.btnFocusClick);
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
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnFocus);
            this.Controls.Add(this.btnPause);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(337, 526);
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
        private Button btnStart;
        private Label lblSession;
        private Button btnPause;
        private Label lblTime;
        private Button btnFocus;
        private Button btnSettings;
        private Button btnReset;
        private Label lblTimerStatus;
        private Label lblPomodoroStatus;
        private Panel panel1;
    }
}