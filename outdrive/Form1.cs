using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace outdrive
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private int ButtonSpace = 5;
        SoundPlayer menuMusic;
        World World = new World();
        bool[] cheats = { false, false, false, false };

        MySqlConnection con;
        MySqlCommand cmd;
        string connectionString = @"Data Source=localhost;Initial Catalog=outdrivehighscores;User ID=root;Password=àààà";

        public Form1()
        {
            InitializeComponent();
        }
        public void scoreRefresh()
        {
            con = new MySqlConnection(connectionString);
            cmd = new MySqlCommand();
            MySqlDataReader dr;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM highscores ORDER BY Score desc";
            dr = cmd.ExecuteReader();

            HSBox.Items.Clear();

            while (dr.Read())
            {
                string score = dr["Score"].ToString();
                string name = dr["names"].ToString();

                string item = score.PadRight(12 - score.Length) + " ---    " + name;

                HSBox.Items.Add(item);
            }
            con.Close();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            PlayB.Location = new Point(PlayB.Location.X, titleScreen.Height / 2);
            HSB.Location = new Point(HSB.Location.X, PlayB.Location.Y + PlayB.Height + ButtonSpace);
            QuitB.Location = new Point(QuitB.Location.X, HSB.Location.Y + HSB.Height + ButtonSpace);

            menuMusic = new SoundPlayer("../../Audio/mainmenu.wav");
            MenuSong();
            scoreRefresh();
        }
        public void MenuSong()
        {
            menuMusic.PlayLooping();
        }
        private void PlayB_Click(object sender, EventArgs e)
        {
            game Game = new game(cheats);
            Game.Show();
            Cursor.Hide();
            Hide();
            menuMusic.Stop();
            World.PlaySound(cheats[2]);
        }
        private void HSB_Click(object sender, EventArgs e)
        {
            if (HSBox.Visible)
            {
                HSBox.Visible = false;
            }
            else
            {
                HSBox.Visible = true;
            }
        }

        private void QuitB_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to quit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("See you next time");
                Application.Exit();
            }
        }

        private void cheatc_TextChanged(object sender, EventArgs e)
        {
            switch (cheatc.Text)
            {
                case ("420"): //snel
                    if (cheats[0])
                    {
                        cheats[0] = false;
                        cheated("-");
                    }
                    else
                    {
                        cheats[0] = true;
                        cheated("+");
                    }
                    break;

                case ("god"): //onsterfelijk
                    if (cheats[1])
                    {
                        cheats[1] = false;
                        cheated("-");
                    }
                    else
                    {
                        cheats[1] = true;
                        cheated("+");
                    }
                    break;
                case ("trap"): //verrandering van muzie
                    if (cheats[2])
                    {
                        cheats[2] = false;
                        menuMusic = new SoundPlayer("../../Audio/mainmenu.wav");
                        menuMusic.PlayLooping();
                        cheated("-");
                    }
                    else
                    {
                        cheats[2] = true;
                        menuMusic = new SoundPlayer("../../Audio/trap.wav");
                        menuMusic.PlayLooping();
                        cheated("+");
                    }
                    break;
                case ("timeman"): //bestuurbare snelheid
                    if (cheats[3])
                    {
                        cheats[3] = false;
                        cheated("-");
                    }
                    else
                    {
                        cheats[3] = true;
                        cheated("+");
                    }
                    break;
                case ("purge"): //database clearen
                    con = new MySqlConnection(connectionString);
                    cmd = new MySqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "DELETE FROM highscores;";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    scoreRefresh();
                    cheated("+");
                    break;
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "c")
            {
                if (cheatc.Visible)
                {
                    cheatc.Visible = false;
                    cheatList.Visible = false;
                }
                else
                {
                    cheatc.Visible = true;
                    cheatList.Visible = true;
                }
            }
        }
        private void cheated(string c)
        {
            switch (c)
            {
                case ("+"):
                    MessageBox.Show("Cheat activated.");
                    break;
                case ("-"):
                    MessageBox.Show("Cheat de-activated.");
                    break;
            }
            cheatc.Clear();
            cheatList.Items.Clear();
            if (cheats[0]) { cheatList.Items.Add("420"); }
            if (cheats[1]) { cheatList.Items.Add("god"); }
            if (cheats[2]) { cheatList.Items.Add("trap"); }
            if (cheats[3]) { cheatList.Items.Add("timeman"); }
        }
    }
}
