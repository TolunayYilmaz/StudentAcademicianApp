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
    public partial class FrmDepartmantList : Form
    {
        public FrmDepartmantList()
        {
            InitializeComponent();
        }

        private void FrmDepartmantList_Load(object sender, EventArgs e)
        {
            DepartmantManager departmantManager = new DepartmantManager();
            var list = departmantManager.GetList();
            dataGridView1.DataSource=list;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Students"].Visible = false;
        }
    }
}
