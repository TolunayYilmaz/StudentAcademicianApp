using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using System.Data.Entity;

namespace LogicLayer.Concrete
{
    public class NoteManager
    {
        Repository<Note> noteDAL = new Repository<Note>();
        public List<Note> GetList()
       {
           return noteDAL.GetAll();
       }
        public void Update(int id,Note note)
        {
           Note noteData= noteDAL.GetByObj(id);
            noteData.Sinav1 = note.Sinav1;
            noteData.Sinav2 = note.Sinav2;
            noteData.Sinav3 = note.Sinav3;
            noteData.Quiz1= note.Quiz1;
            noteData.Quiz2 = note.Quiz2;
            noteData.Proje= note.Proje;
            noteData.Ortalama = note.Ortalama;
            noteDAL.Update();
        }
        public List<Note> FindNote(string FindNo,int LessonId)
        {
            if (FindNo == "")
            {
                FindNo = "1";
            }
            var student = from x in noteDAL.GetAll()
                          select new Note
                          {
                              Id = x.Id,
                              Ogrenci = x.Ogrenci,
                              Sinav1 = x.Sinav1,
                              Sinav2 = x.Sinav2,
                              Sinav3 = x.Sinav3,
                              Quiz1 = x.Quiz1,
                              Quiz2 = x.Quiz2,
                              Proje = x.Proje,
                              Ortalama = x.Ortalama,
                              Students = new Student
                              {
                                  OgrAd = x.Students.OgrAd,
                                  OgrSoyad = x.Students.OgrSoyad,
                                  OgrNumara = x.Students.OgrNumara
                              },
                              Lessons = new Lesson
                              {
                                  DersAd = x.Lessons.DersAd,
                                  LessonId = x.Lessons.LessonId
                              }
                          };
            return student.Where(y=>y.Students.OgrNumara==int.Parse(FindNo)&&y.Lessons.LessonId== LessonId).ToList();
        }

        public void AddNote(string[] sinav, string[] quiz,string project,string ortalama,string ogrId,string DersId)
        {
            Note note=new Note();
            note.Sinav1 = byte.Parse(sinav[0]);
            note.Sinav2 = byte.Parse(sinav[1]);
            note.Sinav3 = byte.Parse(sinav[2]);
            note.Quiz1 = byte.Parse(quiz[0]);
            note.Quiz2 = byte.Parse(quiz[0]);
            note.Proje = byte.Parse(project);
            note.Ogrenci = int.Parse(ogrId);
            note.Ortalama = decimal.Parse(ortalama);
            note.Ders = int.Parse(DersId);
            noteDAL.Insert(note);

         
        }
    }
}
