using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Concrete
{
    public class AcademicManager
    {
        Repository<Academic> academic = new Repository<Academic>();
        //public List<Academic> GetList()
        //{
        //    AcademicDal academicDal = new AcademicDal();
        //    return academicDal.GetAll();
        //}
        public Academic LogIn(int s, string pas)
        {
            if (s>0&&pas.Length>2)
            {
                return academic.GetAll().FirstOrDefault(y => y.AkademisyenNumara == s && y.AkademisyenSifre == pas);
            }
            else
            {
                return null;
            }
              
        }
    }
}
