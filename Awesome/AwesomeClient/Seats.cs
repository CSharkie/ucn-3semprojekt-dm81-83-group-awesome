using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AwesomeClient.ServiceReference;

namespace AwesomeClient
{
    public partial class Seats : Form
    {
        ServiceClient client = new ServiceClient();

        public Seats()
        {
            InitializeComponent();
        }

        public Bitmap Draw(int width, int height)
        {
            var bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            var graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.FillRectangle(new SolidBrush(Color.Gray), 10, 10, 50, 50);

            return bitmap;
        }

        private void getRoom_btn_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            int roomId = Convert.ToInt32(txt_roomId.Text);
            room = client.getRoom(roomId);

            for (int i = 0; i <= room.Rows; i++)
            {


                seats_pictureBox.Image = Draw(seats_pictureBox.Width, seats_pictureBox.Height);
            }
                        
            //seats_pictureBox.Image = Draw(seats_pictureBox.Width, seats_pictureBox.Height);
        }
    }
}
