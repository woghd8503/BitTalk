using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

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
            e.Graphics.DrawString("(ง •̀_•́)ง 새로운 레전드 멘토를 고르세요 !!", new Font("Ryunji R", 21), Brushes.Black, 130, 12);
            e.Graphics.DrawString("\t선택 \n٩(๑• ₃ -๑)۶♥   Up key", new Font("Ryunji R", 18), Brushes.DarkGreen, 234, 116);
            e.Graphics.DrawString("      ◀◀\nLeft key", new Font("Ryunji R", 16), Brushes.Black, 20, 394);
            e.Graphics.DrawString("▶▶\n Right key", new Font("Ryunji R", 16), Brushes.Black, 640, 394);
            e.Graphics.DrawString("\t거절 \n(｡･ˇ_ˇ･｡)   Down key", new Font("Ryunji R", 18), Brushes.DarkRed, 234, 727);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                SoundPlayer clap = new SoundPlayer(@"c:\Windows\Media\clap.wav");
                clap.Play();
                this.Hide();

                ChatRoom chatRoom = new ChatRoom();
                chatRoom.Show();
            }

            if (e.KeyCode == Keys.Down)
            {
                SoundPlayer Break = new SoundPlayer(@"c:\Windows\Media\유리창_깨지는_소리.wav");
                Break.Play();
                MessageBox.Show("건방진 녀석이로군 감히!! 레전드를 거절하다니 \n 넌 레전드 멘토를 고를 자격이 없다. 당장 나가라~!!");
                Application.Exit();
            }

            if (e.KeyCode == Keys.Left)
            {
                SoundPlayer tank = new SoundPlayer(@"c:\Windows\Media\탱크2.wav");
                tank.Play();
                imageNum--;
                Console.WriteLine("Left");
                if (imageNum == 0) { imageNum = 6; }

            }
            if (e.KeyCode == Keys.Right)
            {
                SoundPlayer Yes = new SoundPlayer(@"c:\Windows\Media\닥템2.wav");
                Yes.Play();
                Console.WriteLine("Right");
                imageNum++;
                if (imageNum == image.Length) { imageNum = 1; }
            }
            Invalidate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SoundPlayer Break = new SoundPlayer(@"c:\Windows\Media\dragon.wav");
            Break.Play();
            this.DoubleBuffered = true;
            for (int i = 0; i < 7; i++)
            {
                string path = "../../A" + i + ".jpg";
                image[i] = Image.FromFile(path);
            }
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
