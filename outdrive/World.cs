using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace outdrive
{
    class World
    {
        bool started = false;
        Image background = Image.FromFile("../../Textures/road_texture.png");
        Point ulCorner;
        Traffic Traffic = new Traffic();
        SoundPlayer BackSound;

        public void Draw(Graphics e, PictureBox pbox)
        {
            int speed = Traffic.Speed;
            if (started)
            {
                ulCorner = new Point(ulCorner.X - (speed / 2), 0);
                Size s = new Size(pbox.Width, pbox.Height);
                Rectangle rect = new Rectangle(ulCorner, s);
                e.DrawImage(background, rect);
            }
            else
            {
                ulCorner = new Point(0, 0);
                Size s = new Size(pbox.Width, pbox.Height);
                Rectangle rect = new Rectangle(ulCorner, s);
                e.DrawImage(background, rect);
                started = true;
            }
        }
        public void PlaySound(bool trap)
        {
            if (trap)
            {
                BackSound = new SoundPlayer("../../Audio/trap-game.wav");
            }
            else
            {
                BackSound = new SoundPlayer("../../Audio/parctis.wav");
            }
            BackSound.Play();
        }
    }
}
