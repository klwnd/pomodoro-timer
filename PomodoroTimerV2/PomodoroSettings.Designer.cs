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
            this.lblSetTimeFocus = new System.Windows.Forms.Label();
            this.btnMinusTimeFocus = new System.Windows.Forms.Button();
            this.btnAddTimeFocus = new System.Windows.Forms.Button();
            this.btnAddTimeBreak = new System.Windows.Forms.Button();
            this.lblSetTimeBreak = new System.Windows.Forms.Label();
            this.btnMinusTimeBreak = new System.Windows.Forms.Button();
            this.lblTitleChangeFocus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSetTimeFocus
            // 
            this.lblSetTimeFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSetTimeFocus.Font = new System.Drawing.Font("Roboto Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSetTimeFocus.Location = new System.Drawing.Point(153, 62);
            this.lblSetTimeFocus.Name = "lblSetTimeFocus";
            this.lblSetTimeFocus.Size = new System.Drawing.Size(87, 33);
            this.lblSetTimeFocus.TabIndex = 5;
            this.lblSetTimeFocus.Text = "5";
            this.lblSetTimeFocus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinusTimeFocus
            // 
            this.btnMinusTimeFocus.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinusTimeFocus.Location = new System.Drawing.Point(83, 66);
            this.btnMinusTimeFocus.Name = "btnMinusTimeFocus";
            this.btnMinusTimeFocus.Size = new System.Drawing.Size(60, 26);
            this.btnMinusTimeFocus.TabIndex = 4;
            this.btnMinusTimeFocus.Text = "<";
            this.btnMinusTimeFocus.UseVisualStyleBackColor = true;
            this.btnMinusTimeFocus.Click += new System.EventHandler(this.btnChangeTime);
            // 
            // btnAddTimeFocus
            // 
            this.btnAddTimeFocus.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddTimeFocus.Location = new System.Drawing.Point(246, 66);
            this.btnAddTimeFocus.Name = "btnAddTimeFocus";
            this.btnAddTimeFocus.Size = new System.Drawing.Size(60, 26);
            this.btnAddTimeFocus.TabIndex = 6;
            this.btnAddTimeFocus.Text = ">";
            this.btnAddTimeFocus.UseVisualStyleBackColor = true;
            this.btnAddTimeFocus.Click += new System.EventHandler(this.btnChangeTime);
            // 
            // btnAddTimeBreak
            // 
            this.btnAddTimeBreak.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddTimeBreak.Location = new System.Drawing.Point(246, 156);
            this.btnAddTimeBreak.Name = "btnAddTimeBreak";
            this.btnAddTimeBreak.Size = new System.Drawing.Size(60, 26);
            this.btnAddTimeBreak.TabIndex = 9;
            this.btnAddTimeBreak.Text = ">";
            this.btnAddTimeBreak.UseVisualStyleBackColor = true;
            this.btnAddTimeBreak.Click += new System.EventHandler(this.btnChangeTime);
            // 
            // lblSetTimeBreak
            // 
            this.lblSetTimeBreak.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSetTimeBreak.Font = new System.Drawing.Font("Roboto Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSetTimeBreak.Location = new System.Drawing.Point(153, 152);
            this.lblSetTimeBreak.Name = "lblSetTimeBreak";
            this.lblSetTimeBreak.Size = new System.Drawing.Size(87, 33);
            this.lblSetTimeBreak.TabIndex = 8;
            this.lblSetTimeBreak.Text = "10";
            this.lblSetTimeBreak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinusTimeBreak
            // 
            this.btnMinusTimeBreak.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinusTimeBreak.Location = new System.Drawing.Point(83, 156);
            this.btnMinusTimeBreak.Name = "btnMinusTimeBreak";
            this.btnMinusTimeBreak.Size = new System.Drawing.Size(60, 26);
            this.btnMinusTimeBreak.TabIndex = 7;
            this.btnMinusTimeBreak.Text = "<";
            this.btnMinusTimeBreak.UseVisualStyleBackColor = true;
            this.btnMinusTimeBreak.Click += new System.EventHandler(this.btnChangeTime);
            // 
            // lblTitleChangeFocus
            // 
            this.lblTitleChangeFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleChangeFocus.Font = new System.Drawing.Font("Roboto Thin", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.ClientSize = new System.Drawing.Size(405, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitleChangeFocus);
            this.Controls.Add(this.btnAddTimeBreak);
            this.Controls.Add(this.lblSetTimeBreak);
            this.Controls.Add(this.btnMinusTimeBreak);
            this.Controls.Add(this.btnAddTimeFocus);
            this.Controls.Add(this.lblSetTimeFocus);
            this.Controls.Add(this.btnMinusTimeFocus);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(421, 279);
            this.MinimumSize = new System.Drawing.Size(421, 279);
            this.Name = "PomodoroSettings";
            this.Text = "PomodoroSettings";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblSetTimeFocus;
        private Button btnMinusTimeFocus;
        private Button btnAddTimeFocus;
        private Button btnAddTimeBreak;
        private Label lblSetTimeBreak;
        private Button btnMinusTimeBreak;
        private Label lblTitleChangeFocus;
        private Label label1;
    }
}