﻿using Identity.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Identity.Data.Migrations
{
    [DbContext(typeof(UserManagementSystemContext))]
    partial class UserManagementSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Identity.Data.Entities.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("Identity.Data.Entities.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("OrganizationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrganizationName = "Blume Digital Corp."
                        });
                });

            modelBuilder.Entity("Identity.Data.Entities.OrganizationRoleMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("RoleId");

                    b.ToTable("OrganizationRoleMapping", (string)null);
                });

            modelBuilder.Entity("Identity.Data.Entities.Policy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Authorize")
                        .HasColumnType("bit");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("RouteId")
                        .HasColumnType("int");

                    b.Property<int>("UserGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "RoleId" }, "IX_Policies_RoleId");

                    b.HasIndex(new[] { "RouteId" }, "IX_Policies_RouteId");

                    b.HasIndex(new[] { "UserGroupId" }, "IX_Policies_UserGroupId");

                    b.ToTable("Policies");
                });

            modelBuilder.Entity("Identity.Data.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("IsGenericRole")
                        .HasColumnType("bit");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsGenericRole = true,
                            RoleName = "System Admin"
                        },
                        new
                        {
                            Id = 2,
                            IsGenericRole = true,
                            RoleName = "Admin"
                        });
                });

            modelBuilder.Entity("Identity.Data.Entities.Route", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Route1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Route");

                    b.Property<string>("RouteName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ApplicationId" }, "IX_Routes_ApplicationId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("Identity.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("AccountBalance")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("OrganizationId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex(new[] { "OrganizationId" }, "IX_Users_OrganizationId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "00000000-0000-0000-0000-000000000000",
                            AccountBalance = 2147483647,
                            FirstName = "Nafis",
                            LastName = "Sadik",
                            OrganizationId = 1,
                            Password = "$2a$11$HR1GYb17XH9zmD1lXE2dpugq0D5YuLz2ZF8b0fQNJQjkJZbywMQp6",
                            RoleId = 1,
                            Status = "A",
                            UserName = "nafis_sadik"
                        });
                });

            modelBuilder.Entity("Identity.Data.Entities.OrganizationRoleMapping", b =>
                {
                    b.HasOne("Identity.Data.Entities.Organization", "Organization")
                        .WithMany("OrganizationRoleMappings")
                        .HasForeignKey("OrganizationId")
                        .IsRequired()
                        .HasConstraintName("FK_OrganizationRoleMapping_Organizations");

                    b.HasOne("Identity.Data.Entities.Role", "Role")
                        .WithMany("OrganizationRoleMappings")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK_OrganizationRoleMapping_Roles");

                    b.Navigation("Organization");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Identity.Data.Entities.Policy", b =>
                {
                    b.HasOne("Identity.Data.Entities.Role", "Role")
                        .WithMany("Policies")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK_Policies_Roles");

                    b.HasOne("Identity.Data.Entities.Route", "Route")
                        .WithMany("Policies")
                        .HasForeignKey("RouteId")
                        .IsRequired()
                        .HasConstraintName("FK_Policies_Routes");

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

                    b.Navigation("Application");
                });

            modelBuilder.Entity("Identity.Data.Entities.User", b =>
                {
                    b.HasOne("Identity.Data.Entities.Organization", "Organization")
                        .WithMany("Users")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Users_Organizations");

                    b.HasOne("Identity.Data.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Users_Roles");

                    b.Navigation("Organization");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Identity.Data.Entities.Application", b =>
                {
                    b.Navigation("Routes");
                });

            modelBuilder.Entity("Identity.Data.Entities.Organization", b =>
                {
                    b.Navigation("OrganizationRoleMappings");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Identity.Data.Entities.Role", b =>
                {
                    b.Navigation("OrganizationRoleMappings");

                    b.Navigation("Policies");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Identity.Data.Entities.Route", b =>
                {
                    b.Navigation("Policies");
                });
#pragma warning restore 612, 618
        }
    }
}
