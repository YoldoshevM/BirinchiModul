using _6._2_Dars.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Runtime.ConstrainedExecution;

namespace _6._2_Dars.Configurations;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{



    public void Configure(EntityTypeBuilder<Teacher> builder)
    {



        builder.HasKey(x => x.Id);

        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.Subject)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.ExperienceYears)
            .IsRequired();




    }


}
