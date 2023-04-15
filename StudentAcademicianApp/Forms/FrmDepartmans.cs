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
    public partial class FrmDepartmans : Form,IMap
    {
        public FrmDepartmans()
        {
            InitializeComponent();
        }

        DepartmantManager departmantManager = new DepartmantManager();

        public FrmMaps Map { set { map = value; } }

        private FrmMaps map;


        private void btnkaydet_Click(object sender, EventArgs e)
        {

            if (txtBolumAdi.Text == "" || txtBolumAdi.Text.Length < 5)
            {
                errorProvider1.SetError(txtBolumAdi, "Bölüm adı boş  veya 5 karakterden az olamaz ");

            }
            else
            {
                Departmant bolum = new Departmant();
                bolum.BolumAd = txtBolumAdi.Text;
                departmantManager.AddDepartmant(bolum);
               
                MessageBox.Show("Bölüm Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
