namespace TestWinForms_2
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
            CheckBoxCheckMe = new CheckBox();
            ButtonClick = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            LabelTimeGame = new Label();
            LabelCountClicks = new Label();
            ButtonRestart = new Button();
            LabelRestart = new Label();
            SuspendLayout();
            // 
            // CheckBoxCheckMe
            // 
            CheckBoxCheckMe.AutoSize = true;
            CheckBoxCheckMe.BackColor = SystemColors.Control;
            CheckBoxCheckMe.Location = new Point(444, 269);
            CheckBoxCheckMe.Name = "CheckBoxCheckMe";
            CheckBoxCheckMe.Size = new Size(249, 36);
            CheckBoxCheckMe.TabIndex = 0;
            CheckBoxCheckMe.Text = "Check Me For Start";
            CheckBoxCheckMe.TextAlign = ContentAlignment.TopCenter;
            CheckBoxCheckMe.UseVisualStyleBackColor = false;
            CheckBoxCheckMe.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ButtonClick
            // 
            ButtonClick.Enabled = false;
            ButtonClick.Location = new Point(25, 293);
            ButtonClick.Name = "ButtonClick";
            ButtonClick.Size = new Size(200, 160);
            ButtonClick.TabIndex = 1;
            ButtonClick.Text = "Click";
            ButtonClick.UseVisualStyleBackColor = true;
            ButtonClick.Visible = false;
            ButtonClick.Click += button1_Click;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // LabelTimeGame
            // 
            LabelTimeGame.AutoSize = true;
            LabelTimeGame.Location = new Point(25, 9);
            LabelTimeGame.Name = "LabelTimeGame";
            LabelTimeGame.Size = new Size(188, 32);
            LabelTimeGame.TabIndex = 4;
            LabelTimeGame.Text = "Time of game: 0";
            // 
            // LabelCountClicks
            // 
            LabelCountClicks.AutoSize = true;
            LabelCountClicks.Location = new Point(25, 58);
            LabelCountClicks.Name = "LabelCountClicks";
            LabelCountClicks.Size = new Size(167, 32);
            LabelCountClicks.TabIndex = 5;
            LabelCountClicks.Text = "Count clicks: 0";
            // 
            // ButtonRestart
            // 
            ButtonRestart.Location = new Point(469, 217);
            ButtonRestart.Margin = new Padding(3, 3, 20, 3);
            ButtonRestart.Name = "ButtonRestart";
            ButtonRestart.Size = new Size(150, 46);
            ButtonRestart.TabIndex = 6;
            ButtonRestart.Text = "Restart";
            ButtonRestart.UseVisualStyleBackColor = true;
            ButtonRestart.Click += ButtonRestart_Click;
            // 
            // LabelRestart
            // 
            LabelRestart.AutoSize = true;
            LabelRestart.Location = new Point(431, 139);
            LabelRestart.Name = "LabelRestart";
            LabelRestart.Size = new Size(262, 32);
            LabelRestart.TabIndex = 7;
            LabelRestart.Text = "The time is off! Results:";
            LabelRestart.TextAlign = ContentAlignment.MiddleCenter;
            LabelRestart.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 629);
            Controls.Add(LabelRestart);
            Controls.Add(ButtonRestart);
            Controls.Add(LabelCountClicks);
            Controls.Add(LabelTimeGame);
            Controls.Add(ButtonClick);
            Controls.Add(CheckBoxCheckMe);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ClientSizeChanged += Form1_ClientSizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox CheckBoxCheckMe;
        private Button ButtonClick;
        private System.Windows.Forms.Timer Timer;
        private TextBox TextBoxTime;
        private TextBox TextBoxCount;
        private Label LabelTimeGame;
        private Label LabelCountClicks;
        private Button ButtonRestart;
        private Label LabelRestart;
    }
}
