using ITIAcademy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITIAcademy.Data.Config
{
    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.SectionName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50).IsRequired();

            builder.HasOne(x => x.Course)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.CourseId)
                .IsRequired();

            builder.HasOne(x => x.Instructor)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.InstructorId)
                .IsRequired(false);

            builder.HasOne(x => x.Schedule)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.ScheduleId)
                .IsRequired();

            builder.HasMany(x => x.Students)
                .WithOne(x => x.Section)
                .HasForeignKey(x => x.SectionId)
                .IsRequired();

            //builder.HasData(LoadSections());
            builder.ToTable("Sections");
        }

        //private static List<Section> LoadSections()
        //{
        //    return new List<Section>
        //    {
        //        new Section { Id = 1, SectionName = "S_MA1", CourseId = 1, InstructorId = 1, ScheduleId = 1, },
        //        new Section { Id = 2, SectionName = "S_MA2", CourseId = 1, InstructorId = 2, ScheduleId = 3, },
        //        new Section { Id = 3, SectionName = "S_PH1", CourseId = 5, InstructorId = 1, ScheduleId = 4, },
        //        new Section { Id = 4, SectionName = "S_PH2", CourseId = 9, InstructorId = 4, ScheduleId = 1, },
        //        new Section { Id = 5, SectionName = "S_CH1", CourseId = 7, InstructorId = 6, ScheduleId = 1, },
        //        new Section { Id = 6, SectionName = "S_CH2", CourseId = 5, InstructorId = 7, ScheduleId = 2, },
        //        new Section { Id = 7, SectionName = "S_BI1", CourseId = 2, InstructorId = 9, ScheduleId = 3, },
        //        new Section { Id = 8, SectionName = "S_BI2", CourseId = 6, InstructorId = 5, ScheduleId = 4, },
        //        new Section { Id = 9, SectionName = "S_CS1", CourseId = 10, InstructorId = 8, ScheduleId = 4, },
        //        new Section { Id = 10, SectionName = "S_CS2", CourseId = 4, InstructorId = 10, ScheduleId = 3, },
        //        new Section { Id = 11, SectionName = "S_CS3", CourseId = 2, InstructorId = 9, ScheduleId = 5, }
        //    };
        //}
    }
}
