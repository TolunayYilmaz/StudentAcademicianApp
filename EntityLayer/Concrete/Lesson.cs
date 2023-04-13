using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Lesson
    {
        public Lesson()
        {
            this.Notes = new HashSet<Note>();
        }
        [Key]
        public int Id { get; set; }
        public string DersAd { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
