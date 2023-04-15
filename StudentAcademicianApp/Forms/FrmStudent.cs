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
    public partial class FrmStudent : Form,IMap
    {
        public FrmStudent()
        {
            InitializeComponent();
        }
        StudentManager studentManager = new StudentManager();

        public FrmMaps Map {  set { map = value; } }
        private FrmMaps map;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student student = studentManager.GetStudent(int.Parse(txtId.Text));
            student.OgrDurum = false;
            studentManager.StudentUpdate();
            List();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = studentManager.GetStudent(int.Parse(txtId.Text));
            student.OgrAd = txtAdi.Text;
            student.OgrSoyad = txtSoyadi.Text;
            student.OgrNumara = int.Parse(txtNumara.Text);
            student.OgrSifre=txtSifre.Text;
            studentManager.StudentUpdate();
            List();
        }

        private void btnList_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNumara.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtResim.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtMail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboBoxBolum.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[7].Value;

        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            List();
        
        }
        void List()
        {
           

            var students = studentManager.GetList();

            var selectedColumnsDataGrid = from student in students
                                  select new
                                  {
                                      student.Id,
                                      student.OgrAd,
                                      student.OgrSoyad,
                                      student.OgrNumara,
                                      student.OgrSifre,
                                      student.OgrResim,
                                      student.OgrMail,
                                      student.OgrBolum,
                                      student.Departmant.BolumAd,
                                      student.OgrDurum
                                  };

            dataGridView1.DataSource = selectedColumnsDataGrid.Where(x => x.OgrDurum == true).ToList();
            comboBoxBolum.ValueMember = "Id";
            comboBoxBolum.DisplayMember = "BolumAd";

            var selectedColumnsCombobox = from student in students
                                  select new
                                  {

                                      student.Departmant.Id,
                                      student.Departmant.BolumAd
                                  };
            comboBoxBolum.DataSource= selectedColumnsCombobox.ToList();    
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
