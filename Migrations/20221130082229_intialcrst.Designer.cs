﻿// <auto-generated />
using System;
using FnolApiVersion2.O.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FnolApiVersion2.O.Migrations
{
    [DbContext(typeof(FnolDbContext))]
    [Migration("20221130082229_intialcrst")]
    partial class intialcrst
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.DriverDetails", b =>
                {
                    b.Property<string>("DriverID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Driver_ID");

                    b.Property<string>("DriverLicenseNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DriverLicenseNumber");

                    b.Property<string>("DriverLicenseType")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DriverLicenseType");

                    b.Property<string>("DriverName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DriverName");

                    b.Property<string>("IncidentID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Incident_ID");

                    b.HasKey("DriverID");

                    b.HasIndex("IncidentID")
                        .IsUnique()
                        .HasFilter("[Incident_ID] IS NOT NULL");

                    b.ToTable("DriverDetails");
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.FnolDetails", b =>
                {
                    b.Property<string>("FnolID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Fnol_ID");

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("bit")
                        .HasColumnName("ActiveCase");

                    b.Property<string>("PolicyID")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Policy_ID");

                    b.Property<string>("ReportedDate")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ReportedDate");

                    b.Property<string>("ReporterName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Reporter_Name");

                    b.Property<Guid?>("UserID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UserID");

                    b.HasKey("FnolID");

                    b.HasIndex("UserID");

                    b.ToTable("FnolDetails");
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.IncidentDetails", b =>
                {
                    b.Property<string>("IncidentID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Incident_ID");

                    b.Property<string>("AddressOfIncident")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("AddressOfIncident");

                    b.Property<string>("CauseOfIncident")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CauseOfIncident");

                    b.Property<string>("DamagedParts")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PartsDamaged");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("Description");

                    b.Property<string>("FnolID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Fnol_ID");

                    b.Property<string>("IncidentDate")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IncidentDate");

                    b.Property<string>("Landmark")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("Landmark");

                    b.HasKey("IncidentID");

                    b.HasIndex("FnolID")
                        .IsUnique()
                        .HasFilter("[Fnol_ID] IS NOT NULL");

                    b.ToTable("IncidentDetails");
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.IncidentPicture", b =>
                {
                    b.Property<string>("PictureID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Picture_ID");

                    b.Property<byte[]>("BackImage")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("BackImage");

                    b.Property<byte[]>("FrontImage")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("FrontImage");

                    b.Property<string>("IncidentID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Incident_ID");

                    b.Property<byte[]>("LeftImage")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("LeftImage");

                    b.Property<byte[]>("RightImage")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("RightImage");

                    b.HasKey("PictureID");

                    b.HasIndex("IncidentID")
                        .IsUnique();

                    b.ToTable("IncidentPictures");
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.Role", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.User_Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleID");

                    b.HasIndex("UserID");

                    b.ToTable("User_Roles");
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.VehicleDetails", b =>
                {
                    b.Property<string>("VehicleID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Vehicle_ID");

                    b.Property<string>("DriverID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Driver_ID");

                    b.Property<string>("RCNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RegistrationCertificateNumber");

                    b.Property<string>("VehicleMaker")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VehicleMaker");

                    b.Property<string>("VehicleModel")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VehicleModel");

                    b.Property<string>("VehicleRegNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VehicleRegistrationNumber");

                    b.Property<string>("VehicleType")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VehicleType");

                    b.HasKey("VehicleID");

                    b.HasIndex("DriverID")
                        .IsUnique()
                        .HasFilter("[Driver_ID] IS NOT NULL");

                    b.ToTable("VehicleDetails");
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.DriverDetails", b =>
                {
                    b.HasOne("FnolApiVersion2.O.Models.Domains.IncidentDetails", "incidentDetails")
                        .WithOne("driverDetails")
                        .HasForeignKey("FnolApiVersion2.O.Models.Domains.DriverDetails", "IncidentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("incidentDetails");
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.FnolDetails", b =>
                {
                    b.HasOne("FnolApiVersion2.O.Models.Domains.User", "userDetails")
                        .WithMany("FnolDetails")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("userDetails");
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.IncidentDetails", b =>
                {
                    b.HasOne("FnolApiVersion2.O.Models.Domains.FnolDetails", "fnolDetails")
                        .WithOne("incidentDetails")
                        .HasForeignKey("FnolApiVersion2.O.Models.Domains.IncidentDetails", "FnolID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("fnolDetails");
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.IncidentPicture", b =>
                {
                    b.HasOne("FnolApiVersion2.O.Models.Domains.IncidentDetails", "incidentDetails")
                        .WithOne("incidentPicture")
                        .HasForeignKey("FnolApiVersion2.O.Models.Domains.IncidentPicture", "IncidentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("incidentDetails");
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.User_Role", b =>
                {
                    b.HasOne("FnolApiVersion2.O.Models.Domains.Role", "role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FnolApiVersion2.O.Models.Domains.User", "user")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("role");

                    b.Navigation("user");
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.VehicleDetails", b =>
                {
                    b.HasOne("FnolApiVersion2.O.Models.Domains.DriverDetails", "driverDetails")
                        .WithOne("vehicleDetails")
                        .HasForeignKey("FnolApiVersion2.O.Models.Domains.VehicleDetails", "DriverID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("driverDetails");
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.DriverDetails", b =>
                {
                    b.Navigation("vehicleDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.FnolDetails", b =>
                {
                    b.Navigation("incidentDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.IncidentDetails", b =>
                {
                    b.Navigation("driverDetails")
                        .IsRequired();

                    b.Navigation("incidentPicture")
                        .IsRequired();
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("FnolApiVersion2.O.Models.Domains.User", b =>
                {
                    b.Navigation("FnolDetails");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
