using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Calculator_lab2.Lab5
{
    public class PhotographContext: DbContext
    {
        public DbSet<Photograph> Photographs { get; set; }

        public DbSet<PhotographFullImage> PhotographFullImages { get; set; }

        public PhotographContext() : base()
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Photograph>()
            .HasRequired(p => p.PhotographFullImage)
            .WithRequiredPrincipal(p => p.Photograph);
            modelBuilder.Entity<Photograph>()
            .ToTable("Photograph", "BazaDeDate");
            modelBuilder.Entity<PhotographFullImage>()
            .ToTable("Photograph", "BazaDeDate");
        }

    }
}
