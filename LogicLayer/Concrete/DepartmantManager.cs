using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Concrete
{
    public class DepartmantManager
    {

        public List<Departmant> GetList()
        {
            Repository<Departmant> departmant = new Repository<Departmant>();   

            return departmant.GetAll();
        }
        public int AddDepartmant(Departmant departmant)
        {
            Repository<Departmant> departmantDAL = new Repository<Departmant>();
            
            return departmantDAL.Insert(departmant);
        }
    }
}
