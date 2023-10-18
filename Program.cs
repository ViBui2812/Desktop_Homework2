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
        private float _grade; //điểm
        private string _mssv; //mã số sinh viên
        public string TSV
        {
            get { return _tsv; }
            set { _tsv = value; }
        }
        public float GRADE
        {
            get { return _grade; }
            set { _grade = value; }
        }
        public string MSSV
        {
            get { return _mssv; }
            set { _mssv = value; }
        }
        public Sinhvien()
        {
            TSV = "";
            GRADE = 0;
            MSSV = "";
        }
        public Sinhvien(string x_init, float grade_init, string mssv_init)
        {
            TSV = x_init;
            GRADE = grade_init;
            MSSV = mssv_init;
        }
    }
    class Lop
    {
        private string _tl; //tên lớp
        private string[] _dssv;
        public string TL
        {
            get { return _tl; }
            set { _tl = value; }
        }
        public Lop()
        {
            
        }
    }
}