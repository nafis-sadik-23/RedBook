﻿// <auto-generated />
using System;
using Identity.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Identity.Data.Migrations
{
    [DbContext(typeof(RedbookIdentityContext))]
    partial class RedbookIdentityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicationId");

                    b.ToTable("Applications", (string)null);
                });

            modelBuilder.Entity("Identity.Data.Entities.Organization", b =>
                {
                    b.Property<int>("OrganizationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrganizationId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("LogoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatededBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganizationId");

                    b.ToTable("Organizations", (string)null);
                });

            modelBuilder.Entity("Identity.Data.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<int?>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOwner")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRetailer")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSystemAdmin")
                        .HasColumnType("bit");

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Identity.Data.Entities.RoleRouteMapping", b =>
                {
                    b.Property<int>("MappingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MappingId"));

                    b.Property<bool>("HasCreateAccess")
                        .HasColumnType("bit");

                    b.Property<bool>("HasDeleteAccess")
                        .HasColumnType("bit");

                    b.Property<bool>("HasUpdateAccess")
                        .HasColumnType("bit");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("RouteId")
                        .HasColumnType("int");

                    b.HasKey("MappingId");

                    b.HasIndex("RoleId");

                    b.HasIndex("RouteId");

                    b.ToTable("RoleRouteMappings", (string)null);
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMenuRoute")
                        .HasColumnType("bit");

                    b.Property<int?>("ParentRouteId")
                        .HasColumnType("int");

                    b.Property<string>("RouteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoutePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RouteTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Sequence")
                        .HasColumnType("int");

                    b.HasKey("RouteId");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("ParentRouteId");

                    b.HasIndex("RouteTypeId");

                    b.ToTable("Routes", (string)null);
                });

            modelBuilder.Entity("Identity.Data.Entities.RouteType", b =>
                {
                    b.Property<int>("RouteTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RouteTypeId"));

                    b.Property<string>("RouteTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RouteTypeId");

                    b.ToTable("RouteTypes", (string)null);
                });

            modelBuilder.Entity("Identity.Data.Entities.Subscription", b =>
                {
                    b.Property<int>("SubscriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubscriptionId"));

                    b.Property<DateTime>("CurrentExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.Property<decimal>("SubscriptionFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("SubscriptionStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SubscriptionId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("PackageId");

                    b.ToTable("Subscriptions", (string)null);
                });

            modelBuilder.Entity("Identity.Data.Entities.SubscriptionPackage", b =>
                {
                    b.Property<int>("PackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PackageId"));

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<string>("PackageDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("SubscriptionFee")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PackageId");

                    b.HasIndex("ApplicationId");

                    b.ToTable("SubscriptionPackages", (string)null);
                });

            modelBuilder.Entity("Identity.Data.Entities.SubscriptionTransaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"));

                    b.Property<int>("PaidAmount")
                        .HasColumnType("int");

                    b.Property<int>("PaidBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SubscriptionId")
                        .HasColumnType("int");

                    b.HasKey("TransactionId");

                    b.HasIndex("PaidBy");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("SubscriptionTransactions", (string)null);
                });

            modelBuilder.Entity("Identity.Data.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int>("AccountBalance")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Identity.Data.Entities.UserRoleMapping", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserRoleId"));

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserRoleId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoleMappings", (string)null);
                });

            modelBuilder.Entity("Identity.Data.Entities.Role", b =>
                {
                    b.HasOne("Identity.Data.Entities.Application", "Application")
                        .WithMany("Roles")
                        .HasForeignKey("ApplicationId");

                    b.HasOne("Identity.Data.Entities.Organization", "Organization")
                        .WithMany("Roles")
                        .HasForeignKey("OrganizationId");

                    b.Navigation("Application");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Identity.Data.Entities.RoleRouteMapping", b =>
                {
                    b.HasOne("Identity.Data.Entities.Role", "Role")
                        .WithMany("RoleRouteMappings")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Identity.Data.Entities.Route", "Route")
                        .WithMany("RoleRouteMappings")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("Route");
                });

            modelBuilder.Entity("Identity.Data.Entities.Route", b =>
                {
                    b.HasOne("Identity.Data.Entities.Application", "Application")
                        .WithMany("Routes")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Identity.Data.Entities.Route", "ParentRoute")
                        .WithMany("InverseParentRoute")
                        .HasForeignKey("ParentRouteId");

                    b.HasOne("Identity.Data.Entities.RouteType", "RouteType")
                        .WithMany("Routes")
                        .HasForeignKey("RouteTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");

                    b.Navigation("ParentRoute");

                    b.Navigation("RouteType");
                });

            modelBuilder.Entity("Identity.Data.Entities.Subscription", b =>
                {
                    b.HasOne("Identity.Data.Entities.Organization", "Organization")
                        .WithMany("Subscriptions")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Identity.Data.Entities.SubscriptionPackage", "Package")
                        .WithMany("Subscriptions")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");

                    b.Navigation("Package");
                });

            modelBuilder.Entity("Identity.Data.Entities.SubscriptionPackage", b =>
                {
                    b.HasOne("Identity.Data.Entities.Application", "Application")
                        .WithMany("SubscriptionPackages")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");
                });

            modelBuilder.Entity("Identity.Data.Entities.SubscriptionTransaction", b =>
                {
                    b.HasOne("Identity.Data.Entities.User", "PaidByNavigation")
                        .WithMany("SubscriptionTransactions")
                        .HasForeignKey("PaidBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Identity.Data.Entities.Subscription", "Subscription")
                        .WithMany("SubscriptionTransactions")
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaidByNavigation");

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("Identity.Data.Entities.UserRoleMapping", b =>
                {
                    b.HasOne("Identity.Data.Entities.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Identity.Data.Entities.Role", "Role")
                        .WithMany("UserRoleMappings")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Identity.Data.Entities.User", "User")
                        .WithMany("UserRoleMappings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Identity.Data.Entities.Application", b =>
                {
                    b.Navigation("Roles");

                    b.Navigation("Routes");

                    b.Navigation("SubscriptionPackages");
                });

            modelBuilder.Entity("Identity.Data.Entities.Organization", b =>
                {
                    b.Navigation("Roles");

                    b.Navigation("Subscriptions");
                });

            modelBuilder.Entity("Identity.Data.Entities.Role", b =>
                {
                    b.Navigation("RoleRouteMappings");

                    b.Navigation("UserRoleMappings");
                });

            modelBuilder.Entity("Identity.Data.Entities.Route", b =>
                {
                    b.Navigation("InverseParentRoute");

                    b.Navigation("RoleRouteMappings");
                });

            modelBuilder.Entity("Identity.Data.Entities.RouteType", b =>
                {
                    b.Navigation("Routes");
                });

            modelBuilder.Entity("Identity.Data.Entities.Subscription", b =>
                {
                    b.Navigation("SubscriptionTransactions");
                });

            modelBuilder.Entity("Identity.Data.Entities.SubscriptionPackage", b =>
                {
                    b.Navigation("Subscriptions");
                });

            modelBuilder.Entity("Identity.Data.Entities.User", b =>
                {
                    b.Navigation("SubscriptionTransactions");

                    b.Navigation("UserRoleMappings");
                });
#pragma warning restore 612, 618
        }
    }
}
