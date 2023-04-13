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
    public partial class FrmSubjectList : Form
    {
        public FrmSubjectList()
        {
            InitializeComponent();
        }

        private void FrmSubjectList_Load(object sender, EventArgs e)
        {
            LessonManager lessonManager = new LessonManager();
            dataGridView1.DataSource= lessonManager.GetList();
            dataGridView1.Columns["Id"].Visible = false;
        }
    }
}
