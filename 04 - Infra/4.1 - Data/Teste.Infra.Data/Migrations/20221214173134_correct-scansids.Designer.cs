// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Teste.Infra.Data.Context;

#nullable disable

namespace Teste.Infra.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221214173134_correct-scansids")]
    partial class correctscansids
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Teste.Domain.Entities.CATQuickHeal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("detected")
                        .HasColumnType("bit");

                    b.Property<string>("result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("update")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CATQuickHeal");
                });

            modelBuilder.Entity("Teste.Domain.Entities.McAfee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("detected")
                        .HasColumnType("bit");

                    b.Property<string>("result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("update")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("McAfee");
                });

            modelBuilder.Entity("Teste.Domain.Entities.NProtect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("detected")
                        .HasColumnType("bit");

                    b.Property<string>("result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("update")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NProtect");
                });

            modelBuilder.Entity("Teste.Domain.Entities.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("md5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("permalink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("positives")
                        .HasColumnType("int");

                    b.Property<string>("resource")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("response_code")
                        .HasColumnType("int");

                    b.Property<string>("scan_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("scan_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("scansId")
                        .HasColumnType("int");

                    b.Property<string>("sha1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sha256")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("total")
                        .HasColumnType("int");

                    b.Property<string>("verbose_msg")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("scan_id")
                        .IsUnique()
                        .HasFilter("[scan_id] IS NOT NULL");

                    b.HasIndex("scansId");

                    b.ToTable("Report");
                });

            modelBuilder.Entity("Teste.Domain.Entities.Scan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Verboverbose_msgseMsg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("md5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("permalink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("resource")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("response_code")
                        .HasColumnType("int");

                    b.Property<string>("scan_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("sha1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sha256")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Scan");
                });

            modelBuilder.Entity("Teste.Domain.Entities.Scans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CATQuickHealId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("McAfeeId")
                        .HasColumnType("int");

                    b.Property<int?>("TheHackerId")
                        .HasColumnType("int");

                    b.Property<int?>("VirusBusterId")
                        .HasColumnType("int");

                    b.Property<int?>("nProtectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CATQuickHealId");

                    b.HasIndex("McAfeeId");

                    b.HasIndex("TheHackerId");

                    b.HasIndex("VirusBusterId");

                    b.HasIndex("nProtectId");

                    b.ToTable("Scans");
                });

            modelBuilder.Entity("Teste.Domain.Entities.TheHacker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("detected")
                        .HasColumnType("bit");

                    b.Property<string>("result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("update")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TheHacker");
                });

            modelBuilder.Entity("Teste.Domain.Entities.VirusBuster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("detected")
                        .HasColumnType("bit");

                    b.Property<string>("result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("update")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VirusBuster");
                });

            modelBuilder.Entity("Teste.Domain.Entities.Report", b =>
                {
                    b.HasOne("Teste.Domain.Entities.Scan", "scan")
                        .WithOne("report")
                        .HasForeignKey("Teste.Domain.Entities.Report", "scan_id")
                        .HasPrincipalKey("Teste.Domain.Entities.Scan", "scan_id");

                    b.HasOne("Teste.Domain.Entities.Scans", "scans")
                        .WithMany()
                        .HasForeignKey("scansId");

                    b.Navigation("scan");

                    b.Navigation("scans");
                });

            modelBuilder.Entity("Teste.Domain.Entities.Scans", b =>
                {
                    b.HasOne("Teste.Domain.Entities.CATQuickHeal", "CATQuickHeal")
                        .WithMany()
                        .HasForeignKey("CATQuickHealId");

                    b.HasOne("Teste.Domain.Entities.McAfee", "McAfee")
                        .WithMany()
                        .HasForeignKey("McAfeeId");

                    b.HasOne("Teste.Domain.Entities.TheHacker", "TheHacker")
                        .WithMany()
                        .HasForeignKey("TheHackerId");

                    b.HasOne("Teste.Domain.Entities.VirusBuster", "VirusBuster")
                        .WithMany()
                        .HasForeignKey("VirusBusterId");

                    b.HasOne("Teste.Domain.Entities.NProtect", "nProtect")
                        .WithMany()
                        .HasForeignKey("nProtectId");

                    b.Navigation("CATQuickHeal");

                    b.Navigation("McAfee");

                    b.Navigation("TheHacker");

                    b.Navigation("VirusBuster");

                    b.Navigation("nProtect");
                });

            modelBuilder.Entity("Teste.Domain.Entities.Scan", b =>
                {
                    b.Navigation("report");
                });
#pragma warning restore 612, 618
        }
    }
}
