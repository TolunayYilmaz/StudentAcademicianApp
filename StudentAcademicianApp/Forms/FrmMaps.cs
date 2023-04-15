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
    public partial class FrmMaps : Form
    {
        public FrmMaps()
        {
            InitializeComponent();
        }

        private void pnlSubjectList_Click(object sender, EventArgs e)
        {
            FrmSubjectList frmSubjectList = new FrmSubjectList();
            frmSubjectList.Map = this;
            this.Hide();
            frmSubjectList.Show();
        }

        private void pnlStudentSignIn_Click(object sender, EventArgs e)
        {
            FrmStudentSignIn frmStudent = new FrmStudentSignIn();
            frmStudent.Map = this;
            this.Hide();
            frmStudent.Show();
        }

        private void pnlQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlDepartmant_Click(object sender, EventArgs e)
        {
            FrmDepartmantList frmDepartmant = new FrmDepartmantList();
            frmDepartmant.Map = this;
            this.Hide();
            frmDepartmant.Show();
        }

        private void pnlNewDepartmant_Click(object sender, EventArgs e)
        {
            FrmDepartmans frmDepartmans = new FrmDepartmans();
            frmDepartmans.Map = this;
            this.Hide();
            frmDepartmans.Show();
        }

        private void pnlNotes_Click(object sender, EventArgs e)
        {
            FrmNotes frmNotes = new FrmNotes();
            frmNotes.Map = this;
            this.Hide();
            frmNotes.Show();
        }


  
        private void pnlNewSubject_Click(object sender, EventArgs e)
        {
            FrmSubjectAdd frmSubjectAdd = new FrmSubjectAdd();
            frmSubjectAdd.Map = this;
            this.Hide();
            frmSubjectAdd.Show();
        }


        private void pnlStudent_Click(object sender, EventArgs e)
        {
            FrmStudent frmStudent = new FrmStudent();
            frmStudent.Map = this;
            this.Hide();
            frmStudent.Show();
        }
    }
}
