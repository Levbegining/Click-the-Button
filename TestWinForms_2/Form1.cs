using System;

namespace TestWinForms_2
{
    public partial class Form1 : Form
    {
        //private bool isGameStarted = false;
        private int timeGame = 0;
        private int countClicks = 0;
        private int prevCountClicks = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowOnly(CheckBoxCheckMe);
            Timer.Enabled = true;
            Timer.Stop();

            CheckBoxCheckMe.ForeColor = Color.Red;
            CheckBoxCheckMe.Location = new Point(ClientSize.Width / 2 - CheckBoxCheckMe.Width / 2,
                ClientSize.Height / 2 - CheckBoxCheckMe.Height / 2);


            Random rand = new Random();
            int newX = rand.Next(0, ClientSize.Width - ButtonClick.Width + 1);
            int newY = rand.Next(0, ClientSize.Height - ButtonClick.Height + 1);

            int red = rand.Next(0, 32) * 8; // Диапазон от 0 до 255
            int green = rand.Next(0, 32) * 8;
            int blue = rand.Next(0, 32) * 8;


            ButtonClick.Location = new Point(newX, newY);
            ButtonClick.BackColor = Color.FromArgb(red, green, blue);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxCheckMe.Checked)
            {

            

                CheckBoxCheckMe.ForeColor = Color.Green;

                ShowExcept(CheckBoxCheckMe, LabelRestart, ButtonRestart);
                Timer.Start();
                //Timer.Enabled = true;

                //isGameStarted = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Size Button: 200 * 160
            // Size window: 1000 * 700

            countClicks += 1;
            LabelCountClicks.Text = $"Count clicks: {countClicks}";

            Random rand = new Random();
            int newX = rand.Next(0, ClientSize.Width - ButtonClick.Width + 1);
            int newY = rand.Next(0, ClientSize.Height - ButtonClick.Height + 1);

            int red = rand.Next(0, 256); // Диапазон от 0 до 255
            int green = rand.Next(0, 256);
            int blue = rand.Next(0, 256);


            ButtonClick.Location = new Point(newX, newY);
            ButtonClick.BackColor = Color.FromArgb(red, green, blue);
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            //CheckBoxCheckMe.Location = new Point(ClientSize.Width / 2 - CheckBoxCheckMe.Width / 2,
            //    ClientSize.Height / 2 - CheckBoxCheckMe.Height / 2);
            LocateOnCenter(CheckBoxCheckMe);
            LocateOnCenter(LabelRestart);
            ButtonRestart.Location = new Point(ClientSize.Width / 2 - ButtonRestart.Width / 2,
                ClientSize.Height / 2 + LabelRestart.Height / 2 + 30);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeGame++;
            LabelTimeGame.Text = $"Time of game: {timeGame}";

            if (timeGame >= 30)
            {
                ShowOnly(ButtonRestart, LabelRestart);

                int maxCountClicks = Math.Max(prevCountClicks, countClicks);
                LabelRestart.Text = $"The time is off!\nBest result: {maxCountClicks}";
                LocateOnCenter(LabelRestart);
                //CheckBoxCheckMe.BackColor = Color.Red;
                ButtonRestart.Location = new Point(ClientSize.Width / 2 - ButtonRestart.Width / 2,
                    ClientSize.Height/2 + LabelRestart.Height/2 + 30);

                Timer.Stop();
                LabelTimeGame.Text = "Time of game: 0";
                LabelCountClicks.Text = "Count clicks: 0";
                CheckBoxCheckMe.ForeColor = Color.Red;
                CheckBoxCheckMe.Checked = false;

                prevCountClicks = maxCountClicks;

                timeGame = 0;
                countClicks = 0;
            }
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            ShowOnly(CheckBoxCheckMe);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // NOTHING TO DO
        }

        public void ShowOnly(params Control[] allowed)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (!allowed.Contains(ctrl))
                {
                    ctrl.Enabled = false;
                    ctrl.Visible = false;
                }
                else
                {
                    ctrl.Enabled = true;
                    ctrl.Visible = true;
                }
            }
        }

        public void ShowExcept(params Control[] notAllowed)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (notAllowed.Contains(ctrl))
                {
                    ctrl.Enabled = false;
                    ctrl.Visible = false;
                }
                else
                {
                    ctrl.Enabled = true;
                    ctrl.Visible = true;
                }
            }
        }

        public void LocateOnCenter(Control ctrl)
        {
            ctrl.Location = new Point(ClientSize.Width / 2 - ctrl.Width / 2,
                ClientSize.Height / 2 - ctrl.Height / 2);
        }
    }
}
