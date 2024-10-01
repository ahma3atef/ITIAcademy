using ITIAcademy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITIAcademy.Data.Config
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.CourseName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50).IsRequired();

            builder.ToTable("Courses");
            builder.HasData(LoadCourses());
        }

        private static List<Course> LoadCourses()
        {
            return new List<Course>
            {
                new Course {Id = 1 , CourseName = "Introduction to Computer Science" },
                new Course {Id = 2 , CourseName = "Web Development Fundamentals" },
                new Course {Id = 3 , CourseName = "Artificial Intelligence" },
                new Course {Id = 4 , CourseName = "Machine Learning Techniques" },
                new Course {Id = 5 , CourseName = "Software Engineering Principles" },
                new Course {Id = 6 , CourseName = "Cybersecurity Basics" },
                new Course {Id = 7 , CourseName = "Cloud Computing with Azure" },
                new Course {Id = 8 , CourseName = "Database Management Systems" },
                new Course {Id = 9 , CourseName = "Data Structures and Algorithms" },
                new Course {Id = 10 , CourseName = "Mobile App Development with Flutter" },
            };
        
        }
    }
}
