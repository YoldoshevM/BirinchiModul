using _6._2_Dars.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Runtime.ConstrainedExecution;

namespace _6._2_Dars.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {


        builder.HasKey(x => x.Id);

        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.Group)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(x => x.Age)
            .IsRequired();


        builder
            .HasMany(x => x.Teachers)
            .WithMany(x => x.Students)
            .UsingEntity(j => j.ToTable("StudentTeachers"));




    }



}
