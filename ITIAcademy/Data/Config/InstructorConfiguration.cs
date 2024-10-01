using ITIAcademy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITIAcademy.Data.Config
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.FName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50).IsRequired();

            builder.Property(x => x.LName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50).IsRequired();

            builder.HasData(LoadInstructors());
            builder.ToTable("Instructors");
        }

        private static List<Instructor> LoadInstructors()
        {
            return new List<Instructor>
            {
                new Instructor { Id = 1, FName = "Ahmed", LName = "Abdullah"},
                new Instructor { Id = 2, FName = "Yasmeen", LName = "Mohamed"},
                new Instructor { Id = 3, FName = "Khalid", LName = "Hassan"},
                new Instructor { Id = 4, FName = "Nadia", LName = "Ali"},
                new Instructor { Id = 5, FName = "Aya", LName = "Abdullah"},
                new Instructor { Id = 6, FName = "Ahmed", LName = "Atef"},
                new Instructor { Id = 7, FName = "ALi", LName = "Saad"},
                new Instructor { Id = 8, FName = "Essam", LName = "Abo"},
                new Instructor { Id = 9, FName = "Hamza", LName = "Ahmed"},
                new Instructor { Id = 10, FName = "Malak", LName = "Samir"},
            };
        }
    }
}

