﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using tuanntgcs18661ApplicationDev.Models;

namespace tuanntgcs18661ApplicationDev.Data
{
    public class ApplicationDbContext : IdentityDbContext<CUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ClassProfile> ClassProfiles { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<TraineeClassroom> TraineeClassrooms { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
    }
}
