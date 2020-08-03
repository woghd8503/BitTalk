using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teamproject
{
    public partial class MainForm : Form
    {
        Image[] image = new Image[7];
        int imageNum = 0;
        public MainForm()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 900;
            this.KeyDown += MainForm_KeyDown;
            this.Load += MainForm_Load;
            this.Paint += MainForm_Paint;
        }



        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image[imageNum], this.ClientRectangle.Right / 4,
                                                  this.ClientRectangle.Bottom / 4,
                                                  this.ClientRectangle.Width / 2,
                                                  this.ClientRectangle.Height / 2);
            e.Graphics.DrawString("(ง •̀_•́)ง 새로운 레전드 팀원을 고르세요 !!", new Font("Ryunji R", 21), Brushes.Black, 150, 12);
            e.Graphics.DrawString("선택 ٩(๑• ₃ -๑)۶♥   Up key", new Font("Ryunji R", 18), Brushes.DarkGreen, 234, 116);
            e.Graphics.DrawString("이전 사진\nLeft key", new Font("Ryunji R", 16), Brushes.Black, 20, 394);
            e.Graphics.DrawString("다음 사진\nRight key", new Font("Ryunji R", 16), Brushes.Black, 640, 394);
            e.Graphics.DrawString("거절 (｡･ˇ_ˇ･｡)   Down key", new Font("Ryunji R", 18), Brushes.DarkRed, 234, 727);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.Hide();

                ChatRoom chatRoom = new ChatRoom();
                chatRoom.Show();
            }

            if (e.KeyCode == Keys.Down)
            {

            }

            if (e.KeyCode == Keys.Left)
            {
                imageNum--;
                Console.WriteLine("Left");
                if (imageNum == 0) { imageNum = 6; }

            }
            if (e.KeyCode == Keys.Right)
            {
                Console.WriteLine("Right");
                imageNum++;
                if (imageNum == image.Length) { imageNum = 1; }
            }
            Invalidate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            for (int i = 0; i < 7; i++)
            {
                string path = "../../A" + i + ".jpg";
                image[i] = Image.FromFile(path);
            }
       
        }

    }
}
