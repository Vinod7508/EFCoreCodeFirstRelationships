﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;


//this is a better way of applying Configuration and Data Seed


namespace Entities.Configuration
{

    //This code is a little bit different from the old OnModelCreating code because we don’t have to use .Entity<Student> part anymore.
    //That’s because our builder object is already of type EntityTypeBuilder<Student>
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.Property(s => s.Age)
                .IsRequired(false);
            builder.Property(s => s.IsRegularStudent)
                .HasDefaultValue(true);
            builder.HasMany(e => e.Evaluations)
                   .WithOne(s => s.Student)
                   .HasForeignKey(s => s.StudentId)
                   .OnDelete(DeleteBehavior.Restrict);
            builder.HasData
            (
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "John Doe",
                    Age = 30
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Jane Doe",
                    Age = 25
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Mike Miles",
                    Age = 28
                }
            );
        }
    }
}
