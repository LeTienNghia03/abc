using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Main : Form
    {
        bool quanlidanhmuc,quanliphong,quantrihethong,baocaothongke,quanlidichvukhachsan;
        public Form_Main()
        {
            InitializeComponent();
        }
        private Form currentForChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentForChild != null)
            {
                currentForChild.Close();
            }
            currentForChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }



        private void linkLabelDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using(Form_dang_nhap s =  new Form_dang_nhap())
            {
                this.Hide();
                s.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer_quanlidanhmuc.Start();
            if (currentForChild != null)
            {
                currentForChild.Close();   
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void timer_quanliphong_Tick(object sender, EventArgs e)
        {
            if (quanliphong)
            {
                panel_Quanliphong.Height += 10;
                if (panel_Quanliphong.Height == panel_Quanliphong.MaximumSize.Height)
                {
                    quanliphong = false;
                    timer_quanliphong.Stop();
                }
            }
            else
            {
                panel_Quanliphong.Height -= 10;
                if (panel_Quanliphong.Height == panel_Quanliphong.MinimumSize.Height)
                {
                    quanliphong = true;
                    timer_quanliphong.Stop();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer_quanliphong.Start();
            if (currentForChild != null)
            {
                currentForChild.Close();
            }
        }

        private void panel_Quanliphong_Click(object sender, EventArgs e)
        {
            
        }

        private void timer_quantrihethong_Tick(object sender, EventArgs e)
        {
            if (quantrihethong)
            {
                panel_Quantrihethong.Height += 10;
                if (panel_Quantrihethong.Height == panel_Quantrihethong.MaximumSize.Height)
                {
                    quantrihethong = false;
                    timer_quantrihethong.Stop();
                }
            }
            else
            {
                panel_Quantrihethong.Height -= 10;
                if (panel_Quantrihethong.Height == panel_Quantrihethong.MinimumSize.Height)
                {
                    quantrihethong = true;
                    timer_quantrihethong.Stop();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer_quantrihethong.Start();
            if (currentForChild != null)
            {
                currentForChild.Close();
            }
        }

        private void timer_baocaothongke_Tick(object sender, EventArgs e)
        {
            if (baocaothongke)
            {
                panel_Baocaothongke.Height += 10;
                if (panel_Baocaothongke.Height == panel_Baocaothongke.MaximumSize.Height)
                {
                    baocaothongke = false;
                    timer_baocaothongke.Stop();
                }
            }
            else
            {
                panel_Baocaothongke.Height -= 10;
                if (panel_Baocaothongke.Height == panel_Baocaothongke.MinimumSize.Height)
                {
                    baocaothongke = true;
                    timer_baocaothongke.Stop();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer_quanlidichvukhachsan.Start();
            if (currentForChild != null)
            {
                currentForChild.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer_baocaothongke.Start();
            if (currentForChild != null)
            {
                currentForChild.Close();
            }
        }

        private void timer_quanlidichvukhachsan_Tick(object sender, EventArgs e)
        {
            if (quanlidichvukhachsan)
            {
                panel_Quanlidichvukhachsan.Height += 10;
                if (panel_Quanlidichvukhachsan.Height == panel_Quanlidichvukhachsan.MaximumSize.Height)
                {
                    quanlidichvukhachsan = false;
                    timer_quanlidichvukhachsan.Stop();
                }
            }
            else
            {
                panel_Quanlidichvukhachsan.Height -= 10;
                if (panel_Quanlidichvukhachsan.Height == panel_Quanlidichvukhachsan.MinimumSize.Height)
                {
                    quanlidichvukhachsan = true;
                    timer_quanlidichvukhachsan.Stop();
                }
            }
        }

        private void Btn_Danhsachnhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_danhsachhanvien());
        }

        private void Btn_Danhsachphong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_danhsachphong());
        }

        private void Btn_Danhsachkhachhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_danhsachkhachhang());
        }

        private void Btn_Danhmucphong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_danhmucphong());
        }

        private void Btn_Danhmucnguoidung_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_danhmucnguoidung()); 
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_quanlidanhmuc_Tick(object sender, EventArgs e)
        {
            if (quanlidanhmuc)
            {
                panel_Quanlidanhmuc.Height += 10;
                if(panel_Quanlidanhmuc.Height == panel_Quanlidanhmuc.MaximumSize.Height)
                {
                    quanlidanhmuc = false;
                    timer_quanlidanhmuc.Stop();
                }
            }
            else
            {
                panel_Quanlidanhmuc.Height -= 10;
                if (panel_Quanlidanhmuc.Height == panel_Quanlidanhmuc.MinimumSize.Height)
                {
                    quanlidanhmuc = true;
                    timer_quanlidanhmuc.Stop();
                }
            }
        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
