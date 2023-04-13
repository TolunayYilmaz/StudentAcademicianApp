using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityLayer.Concrete;
using System.Data.Entity.Infrastructure;

namespace DataAccessLayer
{
    public class OgrenciSinavContext:DbContext
    {

      
        public DbSet<Student> Students { get; set; }
        public DbSet<Note> Notes { get; set;}
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Academic> Academics { get; set; }
        public DbSet<Departmant> Departmants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Student sınıfındaki OgrBolumId alanı ile Departmant sınıfındaki Id alanı arasında bir ilişki tanımlıyoruz.
            //modelBuilder.Entity<Student>()
            //    .HasOptional(s => s.Departmant)
            //    .WithMany(d => d.Students)
            //    .HasForeignKey(s => s.OgrBolum);
            //modelBuilder.Entity<Note>()
            //   .HasOptional(s => s.Student)
            //   .WithMany(d => d.Notes)
            //   .HasForeignKey(s => s.Ogrenci);

            modelBuilder.Entity<Student>()
           .HasOptional(s => s.Departmant)
           .WithMany(d => d.Students)
           .HasForeignKey(s => s.OgrBolum);


            modelBuilder.Entity<Note>()
                .HasOptional(s => s.Students)
                .WithMany(d => d.Notes)
                .HasForeignKey(s => s.Ogrenci);

            modelBuilder.Entity<Note>()
               .HasOptional(s => s.Lessons)
               .WithMany(d => d.Notes)
               .HasForeignKey(s => s.Ders);
        }
       
    }
}
