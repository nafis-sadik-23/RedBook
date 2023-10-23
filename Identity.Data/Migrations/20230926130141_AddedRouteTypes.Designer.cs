﻿// <auto-generated />
using System;
using Identity.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Identity.Data.Migrations
{
    [DbContext(typeof(RedbookIdentityContext))]
    [Migration("20230926130141_AddedRouteTypes")]
    partial class AddedRouteTypes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Identity.Data.Entities.Application", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationId"));

                    b.Property<string>("ApplicationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ApplicationUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.HasKey("ApplicationId")
                        .HasName("PK__Applicat__3214EC07D6504A6D");

                    b.HasIndex(new[] { "OrganizationId" }, "IX_Applications_OrganizationId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("Identity.Data.Entities.Organization", b =>
                {
                    b.Property<int>("OrganizationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrganizationId"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatededBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganizationId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("Identity.Data.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRetailer")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSystemAdmin")
                        .HasColumnType("bit");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("RoleId");

                    b.HasIndex(new[] { "OrganizationId" }, "IX_Roles_OrganizationId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Identity.Data.Entities.RoleRouteMapping", b =>
                {
                    b.Property<int>("MappingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MappingId"));

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("RouteId")
                        .HasColumnType("int");

                    b.HasKey("MappingId");

                    b.HasIndex(new[] { "RoleId" }, "IX_RoleRouteMapping_RoleId");

                    b.HasIndex(new[] { "RouteId" }, "IX_RoleRouteMapping_RouteId");

                    b.ToTable("RoleRouteMapping", (string)null);
                });

            modelBuilder.Entity("Identity.Data.Entities.Route", b =>
                {
                    b.Property<int>("RouteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RouteId"));

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("ParentRouteId")
                        .HasColumnType("int");

                    b.Property<string>("Route1")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("Route");

                    b.Property<string>("RouteName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("RouteTypeId")
                        .HasColumnType("int");

                    b.Property<int>("RouteTypesId")
                        .HasColumnType("int");

                    b.HasKey("RouteId");

                    b.HasIndex("ParentRouteId");

                    b.HasIndex("RouteTypeId");

                    b.HasIndex(new[] { "ApplicationId" }, "IX_Routes_ApplicationId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("Identity.Data.Entities.RouteType", b =>
                {
                    b.Property<int>("RouteTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RouteTypeId"));

                    b.Property<string>("RouteTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RouteTypeId");

                    b.ToTable("RouteTypes");
                });

            modelBuilder.Entity("Identity.Data.Entities.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("AccountBalance")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("UserId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Identity.Data.Entities.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserRoleId"));

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("UserRoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Identity.Data.Entities.Application", b =>
                {
                    b.HasOne("Identity.Data.Entities.Organization", "Organization")
                        .WithMany("Applications")
                        .HasForeignKey("OrganizationId")
                        .IsRequired()
                        .HasConstraintName("FK_Applications_Organizations");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Identity.Data.Entities.Role", b =>
                {
                    b.HasOne("Identity.Data.Entities.Organization", "Organization")
                        .WithMany("Roles")
                        .HasForeignKey("OrganizationId")
                        .IsRequired()
                        .HasConstraintName("FK_Roles_Organizations");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Identity.Data.Entities.RoleRouteMapping", b =>
                {
                    b.HasOne("Identity.Data.Entities.Role", "Role")
                        .WithMany("RoleRouteMappings")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK_RoleRouteMapping_Roles");

                    b.HasOne("Identity.Data.Entities.Route", "Route")
                        .WithMany("RoleRouteMappings")
                        .HasForeignKey("RouteId")
                        .IsRequired()
                        .HasConstraintName("FK_RoleRouteMapping_Routes");

                    b.Navigation("Role");

                    b.Navigation("Route");
                });

            modelBuilder.Entity("Identity.Data.Entities.Route", b =>
                {
                    b.HasOne("Identity.Data.Entities.Application", "Application")
                        .WithMany("Routes")
                        .HasForeignKey("ApplicationId")
                        .IsRequired()
                        .HasConstraintName("FK_Routes_Applications");

                    b.HasOne("Identity.Data.Entities.Route", "ParentRoute")
                        .WithMany()
                        .HasForeignKey("ParentRouteId");

                    b.HasOne("Identity.Data.Entities.RouteType", "RouteType")
                        .WithMany("Routes")
                        .HasForeignKey("RouteTypeId");

                    b.Navigation("Application");

                    b.Navigation("ParentRoute");

                    b.Navigation("RouteType");
                });

            modelBuilder.Entity("Identity.Data.Entities.User", b =>
                {
                    b.HasOne("Identity.Data.Entities.Organization", null)
                        .WithMany("Users")
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("Identity.Data.Entities.UserRole", b =>
                {
                    b.HasOne("Identity.Data.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Identity.Data.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Identity.Data.Entities.Application", b =>
                {
                    b.Navigation("Routes");
                });

            modelBuilder.Entity("Identity.Data.Entities.Organization", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("Roles");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Identity.Data.Entities.Role", b =>
                {
                    b.Navigation("RoleRouteMappings");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Identity.Data.Entities.Route", b =>
                {
                    b.Navigation("RoleRouteMappings");
                });

            modelBuilder.Entity("Identity.Data.Entities.RouteType", b =>
                {
                    b.Navigation("Routes");
                });

            modelBuilder.Entity("Identity.Data.Entities.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}