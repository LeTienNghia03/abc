using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_dang_nhap : Form
    {
        public Form_dang_nhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Form_Main s = new Form_Main();
            this.Hide();
            s.ShowDialog();
            this.Close();
            /*if (txt_taikhoan.Text=="admin" && txt_matkhau.Text=="1234")
            {
                Form_Main s= new Form_Main();
                this.Hide();
                s.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập! Vui lòng kiểm tra lại.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}
