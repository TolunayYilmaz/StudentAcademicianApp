using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Concrete
{
    public class LessonManager
    {
       
        public List<Lesson> GetList()
       
        {
       
            Repository<Lesson> lessonDal = new Repository<Lesson>();
            return lessonDal.GetAll();
       
        }
    }
}
