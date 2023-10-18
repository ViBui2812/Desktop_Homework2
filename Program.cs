using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Homework2
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Sinhvien
    {
        private string _tsv; //tên sinh viên
        private double _diem; //điểm
        private string _mssv; //mã số sinh viên
        public string TSV
        {
            get { return _tsv; }
            set { _tsv = value; }
        }
        public double DIEM
        {
            get { return _diem; }
            set { _diem = value; }
        }
        public string MSSV
        {
            get { return _mssv; }
            set { _mssv = value; }
        }

        public Sinhvien()
        {
            TSV = "";
            DIEM = 0;
            MSSV = "";
        }
        public Sinhvien(string tsv_init, float grade_init, string mssv_init)
        {
            TSV = tsv_init;
            DIEM = grade_init;
            MSSV = mssv_init;
        }
    }
    class Lop
    {
        private List<Sinhvien> _dssv;
        public List<Sinhvien> DSSV
        {
            get { return _dssv; }
            set { _dssv = value; }
        }
        public Lop()
        {
            DSSV = new List<Sinhvien>();
        }

        public Lop(List<Sinhvien> dssv_init)
        {
            DSSV = dssv_init;
        }
        public int Siso()
        {
            return DSSV.ToArray().Length;
        }
        public Sinhvien Top1()
        {
            double maxDiem = DSSV[0].DIEM;
            Sinhvien maxSinhvien = DSSV[0];
            for (int index = 1; index < DSSV.ToArray().Length; index++)
            {
                if (DSSV[index].DIEM >= maxDiem)
                {
                    maxDiem = DSSV[index].DIEM;
                    maxSinhvien = DSSV[index];
                }
            }
            return maxSinhvien;
        }
    }
}