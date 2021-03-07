using DeltaCenter.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaCenter.Infrastructure.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Diagnose> Diagnoses { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
    }
}
