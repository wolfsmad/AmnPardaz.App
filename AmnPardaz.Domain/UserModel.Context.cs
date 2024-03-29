﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AmnPardaz.Domain
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class APDatabaseEntities : DbContext
    {
        public APDatabaseEntities()
            : base("name=APDatabaseEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cours>().HasKey(c => c.CourseId);
            modelBuilder.Entity<DayWeek>().HasKey(d => d.DayId);
            modelBuilder.Entity<Time>().HasKey(d => d.TimeId);
            modelBuilder.Entity<User>().HasKey(d => d.UserId);
            modelBuilder.Entity<UserWeek>().HasKey(d => d.UWID);
            modelBuilder.Entity<UserWeek>().ToTable("UserWeek", "dbo");
            modelBuilder.Entity<DayWeek>().ToTable("DayWeek", "dbo");
            modelBuilder.Entity<Cours>().ToTable("Courses", "dbo");


        }

        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<DayWeek> DayWeeks { get; set; }
        public virtual DbSet<Time> Times { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserWeek> UserWeeks { get; set; }
    }
}
