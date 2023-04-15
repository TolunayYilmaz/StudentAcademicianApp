using EntityLayer.Concrete;
using LogicLayer.Concrete;
using StudentAcademicianApp.Abstract;
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
    public partial class FrmNotes : Form,IMap
    {
        public FrmNotes()
        {
            InitializeComponent();
        }
        NoteManager noteManager = new NoteManager(); 
        LessonManager lessonManager = new LessonManager();

        public FrmMaps Map { set { map = value; } }

        private FrmMaps map;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void FrmNotes_Load(object sender, EventArgs e)
        {
           // StudentNotes(1);
            LessonGet(comboBoxDers);
            LessonGet(comboBoxDersSec);

        }
        private void StudentNotes(int id)
        {
            var student = from x in noteManager.GetList()
                          select new
                          {
                              x.Id,
                              x.Students.OgrAd,
                              x.Students.OgrSoyad,
                              x.Lessons.DersAd,
                              x.Lessons.LessonId,
                              x.Sinav1,
                              x.Sinav2,
                              x.Sinav3,
                              x.Quiz1,
                              x.Quiz2,
                              x.Proje,
                              x.Ortalama,
                              x.Ogrenci

                          };
            dataGridView1.DataSource = student.Where(y => y.LessonId == id).ToList();

           // DataVisible("Ogrenci");
            DataVisible("LessonId");
         
           
        }
        private void LessonGet(ComboBox box)
        {
            box.DisplayMember = "DersAd";
            box.ValueMember = "LessonId";
            box.DataSource = lessonManager.GetList();
        }
        private void UpdateNote()
        {
            Note note = new Note();
            int findID = int.Parse(txtId.Text);
            note.Sinav1 = int.Parse(txtSinav1.Text);
            note.Sinav2 = int.Parse(txtSinav2.Text);
            note.Sinav3 = int.Parse(txtSinav3.Text);
            note.Quiz1 = int.Parse(txtQuiz1.Text);
            note.Quiz2 = int.Parse(txtQuiz2.Text);
            note.Proje = int.Parse(txtProject.Text);
            note.Ortalama = decimal.Parse(txtOrtalama.Text);
            noteManager.Update(findID,note);
            
        }

        private void comboBoxDersSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentNotes(int.Parse(comboBoxDersSec.SelectedValue.ToString()));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSinav1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtSinav2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtSinav3.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtQuiz1.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtQuiz2.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtProject.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtOrtalama.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtStudent.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
        }
        private void Calculate()
        {
            byte s1, s2, s3, q1, q2, p;
            s1 = byte.Parse(txtSinav1.Text);
            s2 = byte.Parse(txtSinav2.Text);
            s3 = byte.Parse(txtSinav3.Text);
            q1 = byte.Parse(txtQuiz1.Text);
            q2 = byte.Parse(txtQuiz2.Text);
            p = byte.Parse(txtProject.Text);
            int ortalama = ((s1 + s2 + s3 + q1 + q2 + p) / 6);
            txtOrtalama.Text = ortalama.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateNote();
            MessageBox.Show("Öğrenci not güncellemesi başarı ile yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var student = from x in noteManager.FindNote(txtOgrNo.Text, int.Parse(comboBoxDersSec.SelectedValue.ToString()))
                          select new
                          {
                              x.Id,
                              x.Students.OgrAd,
                              x.Students.OgrSoyad,
                              x.Lessons.DersAd,
                              x.Lessons.LessonId,
                              x.Sinav1,
                              x.Sinav2,
                              x.Sinav3,
                              x.Quiz1,
                              x.Quiz2,
                              x.Proje,
                              x.Ortalama,
                              x.Ogrenci,
                              x.Students.OgrNumara
                          };
            
            dataGridView1.DataSource=student.ToList();
            DataVisible("OgrNumara");
        }
        void DataVisible(string data)
        {
            dataGridView1.Columns[data].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] sinav = { txtSinav1.Text , txtSinav2.Text ,txtSinav3.Text };
            string[] quiz= { txtQuiz1.Text, txtQuiz2.Text};
            string project=txtProject.Text;
            string ort = txtOrtalama.Text;
            string LessonId = comboBoxDers.SelectedValue.ToString();
            string studentId = txtStudent.Text;
            noteManager.AddNote(sinav,quiz,project,ort,studentId,LessonId);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            BackMenu();
        }

        public void BackMenu()
        {
            map.Show();
            this.Hide();
        }
    }
}
