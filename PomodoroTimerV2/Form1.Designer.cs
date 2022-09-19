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
            this.lblTime = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.lblTimerStatus = new System.Windows.Forms.Label();
            this.ButtonPause = new System.Windows.Forms.Button();
            this.lblPomodoroStatus = new System.Windows.Forms.Label();
            this.pomodoroTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblStateDebug = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Roboto Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(111, 155);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(87, 33);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "05:45";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(128, 283);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(60, 60);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.btnStartClick);
            // 
            // lblTimerStatus
            // 
            this.lblTimerStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerStatus.Font = new System.Drawing.Font("Roboto Thin", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimerStatus.Location = new System.Drawing.Point(72, 203);
            this.lblTimerStatus.Name = "lblTimerStatus";
            this.lblTimerStatus.Size = new System.Drawing.Size(164, 41);
            this.lblTimerStatus.TabIndex = 2;
            this.lblTimerStatus.Text = "Minutes Left";
            this.lblTimerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonPause
            // 
            this.ButtonPause.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonPause.Location = new System.Drawing.Point(44, 283);
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.Size = new System.Drawing.Size(60, 60);
            this.ButtonPause.TabIndex = 3;
            this.ButtonPause.Text = "Pause";
            this.ButtonPause.UseVisualStyleBackColor = true;
            this.ButtonPause.Click += new System.EventHandler(this.btnPauseClick);
            // 
            // lblPomodoroStatus
            // 
            this.lblPomodoroStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPomodoroStatus.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPomodoroStatus.Location = new System.Drawing.Point(44, 89);
            this.lblPomodoroStatus.Name = "lblPomodoroStatus";
            this.lblPomodoroStatus.Size = new System.Drawing.Size(227, 41);
            this.lblPomodoroStatus.TabIndex = 4;
            this.lblPomodoroStatus.Text = "POMODORO TIMER";
            this.lblPomodoroStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pomodoroTimer
            // 
            this.pomodoroTimer.Interval = 1000;
            this.pomodoroTimer.Tick += new System.EventHandler(this.pomodoroTimerTick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(211, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Focus";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(44, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnResetClick);
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.Location = new System.Drawing.Point(165, 383);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(106, 60);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Pomodoro";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettingsClick);
            // 
            // lblStateDebug
            // 
            this.lblStateDebug.AutoSize = true;
            this.lblStateDebug.Location = new System.Drawing.Point(49, 31);
            this.lblStateDebug.Name = "lblStateDebug";
            this.lblStateDebug.Size = new System.Drawing.Size(42, 15);
            this.lblStateDebug.TabIndex = 8;
            this.lblStateDebug.Text = "Debug";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(327, 487);
            this.Controls.Add(this.lblStateDebug);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPomodoroStatus);
            this.Controls.Add(this.ButtonPause);
            this.Controls.Add(this.lblTimerStatus);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.lblTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTime;
        private Button buttonStart;
        private Label lblTimerStatus;
        private Button ButtonPause;
        private Label lblPomodoroStatus;
        private System.Windows.Forms.Timer pomodoroTimer;
        private Button button1;
        private Button button2;
        private Button btnSettings;
        private Label lblStateDebug;
    }
}