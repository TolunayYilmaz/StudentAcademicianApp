using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Student
    {
       public Student()
       {
           this.Notes = new HashSet<Note>();
       }

        public int Id { get; set; }
        public string OgrAd { get; set; }
        public string OgrSoyad { get; set; }
        public int OgrNumara { get; set; }
        public string OgrSifre { get; set; }
        public string OgrMail { get; set; }
        public string OgrResim { get; set; }
        public Nullable<int> OgrBolum { get; set; } // Foreign key alanı
        public Nullable<bool> OgrDurum { get; set; }
        public virtual Departmant Departmant { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
