using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Departmant
    {
         public Departmant()
        {
            this.Students = new HashSet<Student>();
        }
        public int Id { get; set; }
        public string BolumAd { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
