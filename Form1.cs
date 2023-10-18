using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Homework2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Init();
        }
        Sinhvien a;
        Lop A;
        public void Init()
        {
            a = new Sinhvien();
            A = new Lop();
        }
        private void txtTenSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            a.TSV = txtTenSV.Text;
            a.MSSV = txtMSSV.Text;
            a.DIEM = Double.Parse(txtDiem.Text);
            /*for (int i = 0; i < A.DSSV.ToArray().Length; i++) //ý tưởng Check MSSV nếu trùng thì hiện thông báo
            {
                if (txtMSSV.Text == A.DSSV[i].MSSV)
                {
                    a.TSV = A.DSSV[i].TSV;
                    a.DIEM = A.DSSV[i].DIEM;
                    txtThongbao.Text = $"Sinh viên có MSSV là {A.DSSV[i].MSSV} vừa được cập nhật";
                }
            }*/
            A.DSSV.Add(a);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Sinhvien TopSV = A.Top1();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            /*if (txtThongbao.Text.Length != 0)
                listBox2.Items.Add($"Sỉ số: {(A.Siso() - 1)}");
            else listBox2.Items.Add($"Sỉ số: {A.Siso()}");*/
            listBox1.Items.Add($"Tên Sinh Viên: {a.TSV}");
            listBox1.Items.Add($"Mã Số Sinh Viên: {a.MSSV}");
            listBox1.Items.Add($"Điểm: {a.DIEM}");
            listBox2.Items.Add($"Sỉ số: {A.Siso()}");
            listBox1.Items.Add("-----------------");
            listBox1.Items.Add($"Top 1 là: {TopSV.TSV} - Điểm là: {TopSV.DIEM}");
        }

        private void errorProvider1_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
