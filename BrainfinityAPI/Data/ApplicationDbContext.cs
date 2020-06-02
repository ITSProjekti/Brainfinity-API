using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BrainfinityAPI.Models;

namespace BrainfinityAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Takmicenje> Takmicenjes { get; set; }

        public DbSet<GrupaZadataka> GrupaZadatakas { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<NivoSkole> NivoSkoles { get; set; }
    }
}