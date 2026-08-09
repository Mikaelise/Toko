using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Toko.EFCore.Application.Context;
using Toko.EFCore.Domain.Entities.Illustrator;

namespace Toko.EFCore.Infrastructure
{
    public class TokoEFCoreDBContext : DbContext, ITokoEFCoreDBContext
    {
        public TokoEFCoreDBContext(DbContextOptions<TokoEFCoreDBContext> options) : base(options)
        {
        }

        public DbSet<Illustrator> Illustrators { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Apply configurations from the current assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TokoEFCoreDBContext).Assembly);
        }
    }
}
