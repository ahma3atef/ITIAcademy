using ITIAcademy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace ITIAcademy.Data.Config
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.FName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50).IsRequired();

            builder.Property(x => x.LName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50).IsRequired();

            //builder.HasData(LoadStudents());
            builder.ToTable("Students");
        }
        //private static List<Student> LoadStudents()
        //{
        //    return new List<Student>
        //    {
        //        new Student {Id = 1, FName = "John"  , LName = "Doe", SectionId = 1},
        //        new Student {Id = 2, FName = "Jane"  , LName = "Smith", SectionId = 2},
        //        new Student {Id = 3, FName = "James" , LName = "Johnson", SectionId = 3},
        //        new Student {Id = 4, FName = "Emily" , LName = "Brown", SectionId = 4},
        //        new Student {Id = 5, FName = "Michal" ,LName = "Williams", SectionId = 11},
        //        new Student {Id = 6, FName = "Sarah",  LName = "Jones", SectionId = 6},
        //        new Student {Id = 7, FName = "Rober" , LName = "Garcia", SectionId = 7},
        //        new Student {Id = 8, FName = "David", LName = "Martinez", SectionId = 8},
        //        new Student {Id = 9, FName = "Sophi" , LName = "Davis", SectionId = 9},
        //        new Student {Id = 10, FName = "Ahmed", LName = "Salah", SectionId = 10},
        //        new Student {Id = 11, FName = "Sarah",  LName = "Jones", SectionId = 6},
        //        new Student {Id = 12, FName = "Jack" , LName = "Smith", SectionId = 7},
        //        new Student {Id = 13, FName = "Alfonso", LName = "Davis", SectionId = 8},
        //        new Student {Id = 14, FName = "Reece" , LName = "James", SectionId = 11},
        //        new Student {Id = 15, FName = "Karim", LName = "Benzema", SectionId = 11}
        //    };
        //}
    }
}

