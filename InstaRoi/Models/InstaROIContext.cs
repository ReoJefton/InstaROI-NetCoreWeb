using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InstaRoi.Models
{
    public partial class InstaROIContext : DbContext
    {
        public virtual DbSet<Element> Element { get; set; }
        public virtual DbSet<Investment> Investment { get; set; }
        public virtual DbSet<MarketingElements> MarketingElements { get; set; }


        public InstaROIContext(DbContextOptions<InstaROIContext> options)
        : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Element>(entity =>
            {
                entity.HasKey(e => e.Type)
                    .HasName("PK__Element__F9B8A48A1BF64AE0");

                entity.Property(e => e.Type).HasMaxLength(255);

                entity.Property(e => e.InvestmentFieldId).HasColumnName("investmentFieldID");
            });

            modelBuilder.Entity<Investment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InvestmentType)
                    .IsRequired()
                    .HasColumnName("investmentType")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MarketingElements>(entity =>
            {
                entity.HasKey(e => e.ElementId)
                    .HasName("PK__Marketin__A4DA082A26D137C7");

                entity.Property(e => e.ElementId).HasColumnName("elementID");

                entity.Property(e => e.ConversionPercentage)
                    .HasColumnName("conversionPercentage")
                    .HasColumnType("decimal");

                entity.Property(e => e.ConversionValue).HasColumnName("conversionValue");

                entity.Property(e => e.ElementDescription)
                    .HasColumnName("elementDescription")
                    .HasMaxLength(255);

                entity.Property(e => e.ElementName)
                    .IsRequired()
                    .HasColumnName("elementName")
                    .HasMaxLength(255);

                entity.Property(e => e.ElementType)
                    .IsRequired()
                    .HasColumnName("elementType")
                    .HasMaxLength(255);

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("date");

                entity.Property(e => e.Investment1).HasColumnName("investment1");

                entity.Property(e => e.Investment2).HasColumnName("investment2");

                entity.Property(e => e.Investment3).HasColumnName("investment3");

                entity.Property(e => e.Investment4).HasColumnName("investment4");

                entity.Property(e => e.Investment5).HasColumnName("investment5");

                entity.Property(e => e.Investment6).HasColumnName("investment6");

                entity.Property(e => e.InvestmentField)
                    .HasColumnName("investmentField")
                    .HasMaxLength(255);

                entity.Property(e => e.NumberOfLeads).HasColumnName("numberOfLeads");

                entity.Property(e => e.Profit)
                    .HasColumnName("profit")
                    .HasColumnType("decimal");

                entity.Property(e => e.Roi)
                    .HasColumnName("roi")
                    .HasColumnType("decimal");

                entity.Property(e => e.RoiPercentage)
                    .HasColumnName("roiPercentage")
                    .HasColumnType("decimal");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(255);
            });
        }
    }
}