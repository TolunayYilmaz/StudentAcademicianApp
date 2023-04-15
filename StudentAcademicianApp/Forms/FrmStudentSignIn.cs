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
    public partial class FrmStudentSignIn : Form, IMap
    {
        public FrmStudentSignIn()
        {
            InitializeComponent();
        }

        public FrmMaps Map { set { map = value; } }

        private FrmMaps map;


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
