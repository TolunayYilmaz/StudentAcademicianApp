﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using System.Data.Entity;

namespace LogicLayer.Concrete
{
    public class StudentManager
    {
        Repository<Student> studentDAL = new Repository<Student>();
        public List<Student> GetList()
        {
                return studentDAL.GetAll();
        }
        public Student GetStudent(int id)
        {
            return studentDAL.GetByObj(id);

        }
        public int StudentUpdate()   
        {
            return  studentDAL.Update();
        
        }
        public Student LogIn(int s,string pas)
        {
           return studentDAL.GetAll().FirstOrDefault(y => y.OgrNumara ==s && y.OgrSifre == pas);
        }
    }
}
