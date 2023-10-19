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
            
            A = new Lop();
        }
        private void txtTenSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            a = new Sinhvien(txtTenSV.Text,Double.Parse(txtDiem.Text),txtMSSV.Text);
            listBox3.Items.Clear();
            if (A.DSSV.Count > 0)
            {
                for (int i = 0; i < A.DSSV.Count; i++)
                {
                    if (a.MSSV == A.DSSV[i].MSSV)
                    {
                        listBox3.Items.Add($"Sinh viên có mã số {a.MSSV} vừa được cập nhật");
                        A.DSSV[i].TSV = a.TSV;
                        A.DSSV[i].DIEM = a.DIEM;
                    }
                    else
                    {
                        A.DSSV.Add(a);
                        break;
                    }
                }
            }
                
            else A.DSSV.Add(a); 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Sinhvien TopSV = A.Top1();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.Items.Add($"Tên Sinh Viên: {a.TSV}");
            listBox1.Items.Add($"Mã Số Sinh Viên: {a.MSSV}");
            listBox1.Items.Add($"Điểm: {a.DIEM}");
            listBox2.Items.Add($"{A.Siso()}"); // Sĩ số
            listBox1.Items.Add("-----------------");
            listBox1.Items.Add($"Top 1 là: {TopSV.TSV} - Điểm là: {TopSV.DIEM}");
        }

        private void errorProvider1_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Danh Sách Sinh Viên");
            listBox1.Items.Add("-------------------");
            for (int i = 0; i < A.DSSV.ToArray().Length; i++)
            {
                listBox1.Items.Add($"Tên: {A.DSSV[i].TSV} | MSSV: {A.DSSV[i].MSSV} | Điểm: {A.DSSV[i].DIEM}");
                
            }
        }
    }
}
