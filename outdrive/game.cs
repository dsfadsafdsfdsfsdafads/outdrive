using System;
using System.Drawing;
using System.Windows.Forms;

namespace outdrive
{
    public partial class game : Form
    {
        int score;

        World World = new World();
        Player PCar = new Player();
        Traffic Traffic = new Traffic();
        Form1 form = new Form1();
        bool[] cheat;



        public game(bool[] cMode)
        {
            InitializeComponent();
            cheat = cMode;
        }

        public void game_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            scoreTimer.Enabled = true;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawAll();
            Collision();
        }
        private void game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Escape):
                    ToMenu();
                    break;
                case (Keys.Z):
                    if (cheat[3])
                    {
                        if (timer1.Interval == 10 && scoreTimer.Interval == 100)
                        {
                            timer1.Interval = 2;
                            scoreTimer.Interval = 20;
                        }
                        else
                        {
                            timer1.Interval = 10;
                            scoreTimer.Interval = 100;
                        }
                    }
                    break;
                case (Keys.S):
                    if (cheat[3])
                    {
                        if (timer1.Interval == 10 && scoreTimer.Interval == 100)
                        {
                            timer1.Interval = 40;
                            scoreTimer.Interval = 400;
                        }
                        else
                        {
                            timer1.Interval = 10;
                            scoreTimer.Interval = 100;
                        }
                    }
                    break;
            }
        }

        private void DrawAll()
        {
            Graphics e = pictureBox1.CreateGraphics();
            pictureBox1.Invalidate();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            World.Draw(e.Graphics, pictureBox1);
            PCar.Draw(e.Graphics, pictureBox1, cheat);
            if (Traffic.Alive)
            {
                Traffic.Draw(e.Graphics, pictureBox1, score);
            }
            else
            {
                Traffic.Spawn(e.Graphics, pictureBox1);
                Traffic.Alive = true;
            }
        }
        public void ToMenu()
        {
            scoreTimer.Enabled = false;
            timer1.Enabled = false;
            kill kill = new kill(cheat, score);
            kill.Show();
            Cursor.Show();
            this.Close();
            kill.SFX();
        }
        public void SaveScore()
        {

        }
        public void Collision()
        {
            if (PCar.Hitbox.IntersectsWith(Traffic.Hitbox))
            {
                if (cheat[1])
                {

                }
                else
                {
                    ToMenu();
                }
            }
        }

        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            if (cheat[0])
            {
                score += 10;
            }
            else
            {
                score++;
            }
            label1.Text = score.ToString();
        }
    }
}
