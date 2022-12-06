using System.Drawing;
using System.Windows.Forms;

namespace outdrive
{
    class Player
    {
        Rectangle rect;
        Image carImage;
        public void Draw(Graphics e, PictureBox pbox, bool[] cheat)
        {
            if (cheat[0])
            {
                carImage = Image.FromFile("../../Textures/Cars/car2.png");
            }
            else
            {
                carImage = Image.FromFile("../../Textures/Cars/car.png");
            }
            Point ulCorner = new Point(50, Cursor.Position.Y - pbox.Height / 10);
            Size s = new Size((pbox.Height / 15) * 5, (pbox.Height / 30) * 5);
            rect = new Rectangle(ulCorner, s);
            e.DrawImage(carImage, rect);
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
