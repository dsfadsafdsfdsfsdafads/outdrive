using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace outdrive
{
    public partial class kill : Form
    {
        SoundPlayer crash;
        bool[] cheat;

        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        MySqlConnection con;
        MySqlCommand cmd;
        string connectionString = @"Data Source=localhost;Initial Catalog=outdrivehighscores;User ID=root;Password=àààà";

        int R = 255, G = 0, B = 0;
        int score;

        public kill(bool[] cheats, int Score)
        {
            InitializeComponent();
            cheat = cheats;
            score = Score;
            if (cheats[2])
            {
                flash.Enabled = true;
            }
        }

        private void kill_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (naamDoos.Text == "")
            {
                MessageBox.Show("Please insert a name.");
            }
            else if (naamDoos.Text.Length < 3)
            {
                MessageBox.Show("Name must contain at least 3 characters.");
            }
            else if (naamDoos.Text.Contains(" "))
            {
                MessageBox.Show("Name cannot contain spaces.");
            }
            else
            {
                con = new MySqlConnection(connectionString);
                cmd = new MySqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO highscores (names, Score) VALUES('" + naamDoos.Text + "', " + score + "); ";
                cmd.ExecuteNonQuery();
                con.Close();

                flash.Enabled = false;
                MessageBox.Show("Welcome back, driver.");
                Form1 form = new Form1();
                form.Show();
                form.MenuSong();
                this.Close();
            }
        }

        public void SFX()
        {
            if (cheat[2])
            {
                crash = new SoundPlayer("../../Audio/crash trap.wav");
            }
            else
            {
                crash = new SoundPlayer("../../Audio/crash.wav");
            }
            crash.Play();
        }

        private void flash_Tick(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(R, G, B);
            if (R > 0 && B == 0)
            {
                R--;
                G++;
            }
            if (G > 0 && R == 0)
            {
                G--;
                B++;
            }
            if (B > 0 && G == 0)
            {
                B--;
                R--;
            }
        }
    }
}
