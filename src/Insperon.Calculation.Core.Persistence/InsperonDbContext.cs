using Insperon.Calculation.Core.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Insperon.Calculation.Core.Persistence
{
    public class InsperonDbContext : DbContext
    {
        public InsperonDbContext(DbContextOptions<InsperonDbContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PrimeNumber>(ConfigurePrimeNumber);
        }

        private void ConfigurePrimeNumber(EntityTypeBuilder<PrimeNumber> builder)
        {
            builder.ToTable("Calculation_Core_PrimeNumber");
        }

        public DbSet<PrimeNumber> PrimeNumber {get; set;}
    }
}
