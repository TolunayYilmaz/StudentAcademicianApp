using LogicLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAcademicianApp.Forms
{
    public partial class FrmStudentPanel : Form
    {
        public FrmStudentPanel()
        {
            InitializeComponent();
        }
        NoteManager noteManager =new NoteManager();
        int studentId;
        public int StudentId { set { studentId = value; } }
        private void FrmStudentPanel_Load(object sender, EventArgs e)
        {
            StudentNotes(studentId);
        }
        private void StudentNotes(int id)
        {
            var student = from x in noteManager.GetList()
                          select new
                          {
                              x.Sinav1,
                              x.Sinav2,
                              x.Sinav3,
                              x.Quiz1,
                              x.Quiz2,
                              x.Proje,
                              x.Ortalama,
                              x.Students.OgrAd,
                              x.Lessons.DersAd,
                              x.Ogrenci

                          };
            dataGridView1.DataSource = student.Where(y => y.Ogrenci == id).ToList();
            dataGridView1.Columns["Ogrenci"].Visible = false;
        }
    }
}
