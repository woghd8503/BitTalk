using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace teamproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Data1.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from USERINFO where USERNAME='"+ID_txt.Text+"' and PASSWORD= '"+Pw_txt.Text+"'", con);

            /* 데이버베이스 외 방법 if (ID_txt.Text == "3" && Pw_txt.Text == "123") {}*/

            DataTable newTable = new DataTable();

            sda.Fill(newTable);

            if (newTable.Rows[0][0].ToString() == "1")
            {  //로그인 성공인 경우
                this.Hide();

                MainForm mainForm1 = new MainForm();
                mainForm1.Show();
            }
            else
            {  //로그인 실패시
                SoundPlayer Break = new SoundPlayer(@"c:\Windows\Media\유리창_깨지는_소리.wav");
                Break.Play();
                MessageBox.Show("아이디와 비밀번호를 확인해주세요.");
            }




        }

        private void ID_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pw_txt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
