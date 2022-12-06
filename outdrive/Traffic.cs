using System;
using System.Drawing;
using System.Windows.Forms;

namespace outdrive
{
    class Traffic
    {
        bool TrAlive = false;
        Point ulCorner;
        Image carImage;
        Rectangle rect;
        Random rand = new Random();
        int rando = 0;
        int speed;
        public void Draw(Graphics e, PictureBox pbox, int score)
        {
            carImage = Image.FromFile("../../Textures/Traffic/" + rando + ".png");
            speed = 10 + (score / 20);
            ulCorner = new Point(ulCorner.X - speed, ulCorner.Y);
            Size s = new Size((pbox.Height / 15) * 5, (pbox.Height / 30) * 5);
            rect = new Rectangle(ulCorner, s);
            if (ulCorner.X < -300)
            {
                TrAlive = false;
            }
            e.DrawImage(carImage, rect);
        }
        public void Spawn(Graphics e, PictureBox pbox)
        {
            rando = rand.Next(1, 13);
            carImage = Image.FromFile("../../Textures/Traffic/" + rando + ".png");
            ulCorner = new Point(pbox.Width, rand.Next(0, pbox.Height - 200));
            Size s = new Size(pbox.Height / 3, pbox.Height / 3);
            rect = new Rectangle(ulCorner, s);
            e.DrawImage(carImage, rect);
        }
        public bool Alive
        {
            get
            {
                return TrAlive;
            }
            set
            {
                TrAlive = value;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
        }
        public Rectangle Hitbox
        {
            get
            {
                return rect;
            }
        }
    }
}
