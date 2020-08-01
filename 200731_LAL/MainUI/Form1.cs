using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI {
    public partial class Form1 : Form {
        int leftTabSize = 100;
        int pageIndex = 0;
        public Form1() {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.Width = 1500;
            this.Height = 900;
            MakeButtons();
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            e.Graphics.DrawLine(new Pen(Brushes.YellowGreen,10), leftTabSize, 0, leftTabSize, ClientRectangle.Bottom);
            if(pageIndex == 0) {
                e.Graphics.DrawString("Main Page", new Font("맑은 고딕", 100), Brushes.Blue, 200, 0);
            }
            if(pageIndex == 1) {
                e.Graphics.DrawString("Login Page", new Font("맑은 고딕", 100), Brushes.Blue, 200, 0);
            }
            if(pageIndex == 2) {
                e.Graphics.DrawString("Register Page", new Font("맑은 고딕", 100), Brushes.Blue, 200, 0);
            }
            if(pageIndex == 3) {
                e.Graphics.DrawString("Matching Page", new Font("맑은 고딕", 100), Brushes.Blue, 200, 0);
            }
            if(pageIndex == 4) {
                e.Graphics.DrawString("Profile Page", new Font("맑은 고딕", 100), Brushes.Blue, 200, 0);
            }
        }

        private void MakeButtons() {
            int BUTTON_SIZE = 100;
            Button[] btn = new Button[5];
            string[] btnString = new string[5] { "Main", "Login", "Register", "Matching","Profile"};
            for(int i = 0; i < 5; i++) {
                btn[i] = new Button();
                btn[i].Left = 0;
                btn[i].Top = i* BUTTON_SIZE;
                btn[i].Width = BUTTON_SIZE;
                btn[i].Height = BUTTON_SIZE;
                btn[i].Margin = new Padding(0);
                btn[i].Text = btnString[i];
                btn[i].Font = new Font("맑은 고딕", 15, FontStyle.Bold);
                this.Controls.Add(btn[i]);
            }
            btn[0].Click += Btn_Main_Click;
            btn[3].Click += Btn_Matching_Click;
        }
        private void Btn_Main_Click(object sender, EventArgs e) {
            pageIndex = 0;
            Invalidate();
        }
        private void Btn_Matching_Click(object sender, EventArgs e) {
            pageIndex = 3;
            Invalidate();
        }
    }
}