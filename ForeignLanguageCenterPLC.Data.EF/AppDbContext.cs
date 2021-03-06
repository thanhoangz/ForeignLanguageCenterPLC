﻿using ForeignLanguageCenterPLC.Data.Entities;
using ForeignLanguageCenterPLC.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ForeignLanguageCenterPLC.Data.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AttendanceSheet> AttendanceSheets { set; get; }

        public DbSet<AttendanceSheetDetail> AttendanceSheetDetails { set; get; }

        public DbSet<ClassRoom> ClassRooms { set; get; }

        public DbSet<Contact> Contacts { set; get; }

        public DbSet<Course> Courses { set; get; }

        public DbSet<EndingCoursePoint> EndingCoursePoints { set; get; }

        public DbSet<EndingCoursePointDetail> EndingCoursePointDetails { set; get; }

        public DbSet<Feedback> Feedbacks { set; get; }

        public DbSet<Footer> Footers { set; get; }

        public DbSet<GuestType> GuestTypes { set; get; }

        public DbSet<LanguageClass> LanguageClasses { set; get; }

        public DbSet<Learner> Learners { set; get; }

        public DbSet<Lecturer> Lecturers { set; get; }

        public DbSet<PaySlip> PaySlips { set; get; }

        public DbSet<PaySlipType> PaySlipTypes { set; get; }

        public DbSet<PeriodicPoint> PeriodicPoints { set; get; }

        public DbSet<PeriodicPointDetail> PeriodicPointDetails { set; get; }

        public DbSet<Personnel> Personnels { set; get; }

        public DbSet<Receipt> Receipts { set; get; }

        public DbSet<ReceiptDetail> ReceiptDetails { set; get; }

        public DbSet<ReceiptType> ReceiptTypes { set; get; }

        public DbSet<StudyProcess> StudyProcesses { set; get; }

        public DbSet<SystemConfig> SystemConfigs { set; get; }

        public DbSet<TeachingSchedule> TeachingSchedules { set; get; }

        public DbSet<Timesheet> Timesheets { set; get; }

        public DbSet<User> Users { set; get; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Identity Config

            //builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims").HasKey(x => x.Id);

            //builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims").HasKey(x => x.Id);

            //builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            //builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.RoleId, x.UserId });

            //builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => new { x.UserId });

            //#endregion Identity Config

            //builder.AddConfiguration(new TagConfiguration());
            //builder.AddConfiguration(new BlogTagConfiguration());
            //builder.AddConfiguration(new ContactDetailConfiguration());
            //builder.AddConfiguration(new FooterConfiguration());
            //builder.AddConfiguration(new PageConfiguration());
            //builder.AddConfiguration(new FooterConfiguration());
            //builder.AddConfiguration(new ProductTagConfiguration());
            //builder.AddConfiguration(new SystemConfigConfiguration());
            //builder.AddConfiguration(new AdvertistmentPositionConfiguration());
            //builder.AddConfiguration(new AdvertistmentPageConfiguration());
            //builder.AddConfiguration(new FunctionConfiguration());
            //builder.AddConfiguration(new AnnouncementConfiguration());
            #endregion
            //base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);
            foreach (EntityEntry item in modified)
            {
                var changedOrAddedItem = item.Entity as IDateTracking;
                if (changedOrAddedItem != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        changedOrAddedItem.DateCreated = DateTime.Now;
                    }
                    changedOrAddedItem.DateModified = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
    }
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        /// <summary>
        /// Method khởi tạo AppDbContext
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public AppDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new AppDbContext(builder.Options);
        }
    }
}
