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
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }
       
        StudentManager studentManager = new StudentManager();
        AcademicManager academicManager =new AcademicManager();
        private void btnGiris_Click(object sender, EventArgs e)
        {

            var acedemic=academicManager.LogIn(int.Parse(txtNumara.Text), txtSifre.Text);
            var student = studentManager.LogIn(int.Parse(txtNumara.Text),txtSifre.Text);
            if(student != null&&acedemic==null)
            {   
              //  txtSifre.Text = student.OgrAd;
                
                FrmStudentPanel frmStudentPanel = new FrmStudentPanel();
                frmStudentPanel.StudentId= student.Id;
                frmStudentPanel.Show();
                this.Hide();
                MessageBox.Show("Öğrenci Girişi Onaylandı.");
            }
            if (student == null && acedemic != null)
            {
                FrmMaps frmMaps = new FrmMaps();
                frmMaps.Show();
                this.Hide();
                MessageBox.Show("Akademisyen Girişi Onaylandı.");
            }

            else if (student == null&&acedemic==null)
            {
                MessageBox.Show("Giriş Onaylanmadı.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            
        }
    }
}
