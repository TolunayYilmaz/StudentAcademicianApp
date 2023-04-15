using StudentAcademicianApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAcademicianApp.Abstract
{
    public interface IMap
    {
     
        FrmMaps Map {  set; }
        void BackMenu();
    }
}
