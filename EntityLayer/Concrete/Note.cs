using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Note
    {
        public int Id { get; set; }
        public Nullable<int> Sinav1 { get; set; }
        public Nullable<int> Sinav2 { get; set; }
        public Nullable<int> Sinav3 { get; set; }
        public Nullable<int> Quiz1 { get; set; }
        public Nullable<int> Quiz2 { get; set; }
        public Nullable<decimal> Ortalama { get; set; }
        public Nullable<int> Proje { get; set; }
        public Nullable<int> Ders { get; set; }
        public Nullable<int> Ogrenci { get; set; }
     
    }
}
