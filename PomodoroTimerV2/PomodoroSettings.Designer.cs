namespace PomodoroTimerV2
{
    partial class PomodoroSettings
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
            this.lblFocusTime = new System.Windows.Forms.Label();
            this.btnMinusTimeFocus = new System.Windows.Forms.Button();
            this.btnAddTimeFocus = new System.Windows.Forms.Button();
            this.btnAddTimeBreak = new System.Windows.Forms.Button();
            this.lblBreakTime = new System.Windows.Forms.Label();
            this.btnMinusTimeBreak = new System.Windows.Forms.Button();
            this.lblTitleChangeFocus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFocusTime
            // 
            this.lblFocusTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFocusTime.Font = new System.Drawing.Font("Roboto Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFocusTime.ForeColor = System.Drawing.Color.White;
            this.lblFocusTime.Location = new System.Drawing.Point(153, 62);
            this.lblFocusTime.Name = "lblFocusTime";
            this.lblFocusTime.Size = new System.Drawing.Size(87, 33);
            this.lblFocusTime.TabIndex = 5;
            this.lblFocusTime.Text = "5";
            this.lblFocusTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinusTimeFocus
            // 
            this.btnMinusTimeFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnMinusTimeFocus.FlatAppearance.BorderSize = 0;
            this.btnMinusTimeFocus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusTimeFocus.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinusTimeFocus.ForeColor = System.Drawing.Color.White;
            this.btnMinusTimeFocus.Location = new System.Drawing.Point(83, 66);
            this.btnMinusTimeFocus.Name = "btnMinusTimeFocus";
            this.btnMinusTimeFocus.Size = new System.Drawing.Size(60, 26);
            this.btnMinusTimeFocus.TabIndex = 4;
            this.btnMinusTimeFocus.Text = "<";
            this.btnMinusTimeFocus.UseVisualStyleBackColor = false;
            this.btnMinusTimeFocus.Click += new System.EventHandler(this.btnChangeTime);
            // 
            // btnAddTimeFocus
            // 
            this.btnAddTimeFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnAddTimeFocus.FlatAppearance.BorderSize = 0;
            this.btnAddTimeFocus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTimeFocus.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddTimeFocus.ForeColor = System.Drawing.Color.White;
            this.btnAddTimeFocus.Location = new System.Drawing.Point(246, 66);
            this.btnAddTimeFocus.Name = "btnAddTimeFocus";
            this.btnAddTimeFocus.Size = new System.Drawing.Size(60, 26);
            this.btnAddTimeFocus.TabIndex = 6;
            this.btnAddTimeFocus.Text = ">";
            this.btnAddTimeFocus.UseVisualStyleBackColor = false;
            this.btnAddTimeFocus.Click += new System.EventHandler(this.btnChangeTime);
            // 
            // btnAddTimeBreak
            // 
            this.btnAddTimeBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnAddTimeBreak.FlatAppearance.BorderSize = 0;
            this.btnAddTimeBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTimeBreak.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddTimeBreak.ForeColor = System.Drawing.Color.White;
            this.btnAddTimeBreak.Location = new System.Drawing.Point(246, 156);
            this.btnAddTimeBreak.Name = "btnAddTimeBreak";
            this.btnAddTimeBreak.Size = new System.Drawing.Size(60, 26);
            this.btnAddTimeBreak.TabIndex = 9;
            this.btnAddTimeBreak.Text = ">";
            this.btnAddTimeBreak.UseVisualStyleBackColor = false;
            this.btnAddTimeBreak.Click += new System.EventHandler(this.btnChangeTime);
            // 
            // lblBreakTime
            // 
            this.lblBreakTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBreakTime.Font = new System.Drawing.Font("Roboto Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBreakTime.ForeColor = System.Drawing.Color.White;
            this.lblBreakTime.Location = new System.Drawing.Point(153, 152);
            this.lblBreakTime.Name = "lblBreakTime";
            this.lblBreakTime.Size = new System.Drawing.Size(87, 33);
            this.lblBreakTime.TabIndex = 8;
            this.lblBreakTime.Text = "10";
            this.lblBreakTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinusTimeBreak
            // 
            this.btnMinusTimeBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnMinusTimeBreak.FlatAppearance.BorderSize = 0;
            this.btnMinusTimeBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusTimeBreak.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinusTimeBreak.ForeColor = System.Drawing.Color.White;
            this.btnMinusTimeBreak.Location = new System.Drawing.Point(83, 156);
            this.btnMinusTimeBreak.Name = "btnMinusTimeBreak";
            this.btnMinusTimeBreak.Size = new System.Drawing.Size(60, 26);
            this.btnMinusTimeBreak.TabIndex = 7;
            this.btnMinusTimeBreak.Text = "<";
            this.btnMinusTimeBreak.UseVisualStyleBackColor = false;
            this.btnMinusTimeBreak.Click += new System.EventHandler(this.btnChangeTime);
            // 
            // lblTitleChangeFocus
            // 
            this.lblTitleChangeFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleChangeFocus.Font = new System.Drawing.Font("Roboto Thin", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleChangeFocus.ForeColor = System.Drawing.Color.White;
            this.lblTitleChangeFocus.Location = new System.Drawing.Point(117, 35);
            this.lblTitleChangeFocus.Name = "lblTitleChangeFocus";
            this.lblTitleChangeFocus.Size = new System.Drawing.Size(164, 27);
            this.lblTitleChangeFocus.TabIndex = 10;
            this.lblTitleChangeFocus.Text = "Focus Time";
            this.lblTitleChangeFocus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Roboto Thin", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Break Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PomodoroSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(405, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitleChangeFocus);
            this.Controls.Add(this.btnAddTimeBreak);
            this.Controls.Add(this.lblBreakTime);
            this.Controls.Add(this.btnMinusTimeBreak);
            this.Controls.Add(this.btnAddTimeFocus);
            this.Controls.Add(this.lblFocusTime);
            this.Controls.Add(this.btnMinusTimeFocus);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(421, 279);
            this.MinimumSize = new System.Drawing.Size(421, 279);
            this.Name = "PomodoroSettings";
            this.Text = "Time Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblFocusTime;
        private Button btnMinusTimeFocus;
        private Button btnAddTimeFocus;
        private Button btnAddTimeBreak;
        private Label lblBreakTime;
        private Button btnMinusTimeBreak;
        private Label lblTitleChangeFocus;
        private Label label1;
    }
}