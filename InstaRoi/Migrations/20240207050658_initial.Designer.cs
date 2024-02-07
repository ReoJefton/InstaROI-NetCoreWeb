using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using InstaRoi.Models;

namespace InstaRoi.Migrations
{
    [DbContext(typeof(InstaROIContext))]
    [Migration("20240207050658_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InstaRoi.Models.Element", b =>
                {
                    b.Property<string>("Type")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255);

                    b.Property<int>("InvestmentFieldId")
                        .HasColumnName("investmentFieldID");

                    b.HasKey("Type")
                        .HasName("PK__Element__F9B8A48A1BF64AE0");

                    b.ToTable("Element");
                });

            modelBuilder.Entity("InstaRoi.Models.Investment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int>("Field");

                    b.Property<string>("InvestmentType")
                        .IsRequired()
                        .HasColumnName("investmentType")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Investment");
                });

            modelBuilder.Entity("InstaRoi.Models.MarketingElements", b =>
                {
                    b.Property<int>("ElementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("elementID");

                    b.Property<decimal>("ConversionPercentage")
                        .HasColumnName("conversionPercentage")
                        .HasColumnType("decimal");

                    b.Property<int>("ConversionValue")
                        .HasColumnName("conversionValue");

                    b.Property<string>("ElementDescription")
                        .HasColumnName("elementDescription")
                        .HasMaxLength(255);

                    b.Property<string>("ElementName")
                        .IsRequired()
                        .HasColumnName("elementName")
                        .HasMaxLength(255);

                    b.Property<string>("ElementType")
                        .IsRequired()
                        .HasColumnName("elementType")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("EndDate")
                        .HasColumnName("endDate")
                        .HasColumnType("date");

                    b.Property<int?>("Investment1")
                        .HasColumnName("investment1");

                    b.Property<int?>("Investment2")
                        .HasColumnName("investment2");

                    b.Property<int?>("Investment3")
                        .HasColumnName("investment3");

                    b.Property<int?>("Investment4")
                        .HasColumnName("investment4");

                    b.Property<int?>("Investment5")
                        .HasColumnName("investment5");

                    b.Property<int?>("Investment6")
                        .HasColumnName("investment6");

                    b.Property<string>("InvestmentField")
                        .HasColumnName("investmentField")
                        .HasMaxLength(255);

                    b.Property<int>("NumberOfLeads")
                        .HasColumnName("numberOfLeads");

                    b.Property<decimal?>("Profit")
                        .HasColumnName("profit")
                        .HasColumnType("decimal");

                    b.Property<decimal?>("Roi")
                        .HasColumnName("roi")
                        .HasColumnType("decimal");

                    b.Property<decimal?>("RoiPercentage")
                        .HasColumnName("roiPercentage")
                        .HasColumnType("decimal");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnName("startDate")
                        .HasColumnType("date");

                    b.Property<int?>("UserId")
                        .HasColumnName("userID");

                    b.Property<string>("UserName")
                        .HasColumnName("userName")
                        .HasMaxLength(255);

                    b.HasKey("ElementId")
                        .HasName("PK__Marketin__A4DA082A26D137C7");

                    b.ToTable("MarketingElements");
                });
        }
    }
}
