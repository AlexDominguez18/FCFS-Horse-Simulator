using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace FCFS
{
    class Horse
    {
        public const int IMAGE_WIDTH = 100;
        public const int IMAGE_HEIGHT = 70;
        public const int VELOCITY = 30;

        private int id;
        private PictureBox imageGif;

        public Horse(int id, Point startPos)
        {
            this.id = id;
            imageGif = new PictureBox()
            {
                Location = startPos,
                ClientSize = new Size(IMAGE_WIDTH, IMAGE_HEIGHT),
                Image = Properties.Resources.caballo,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.DarkSeaGreen
            };
            imageGif.BringToFront();
            imageGif.Enabled = false;
        }
        
        public int GetId()
        {
            return id;
        }

        public PictureBox GetPictureBox()
        {
            return imageGif;
        }

        public int GetCurrentCoordX()
        {
            return imageGif.Location.X + imageGif.ClientSize.Width;
        }

        public void Move(int nPixels)
        {
            imageGif.Location = new Point(imageGif.Location.X + nPixels, imageGif.Location.Y);
            //Or imageGif.Left += nPixels;
        }
    }
}
