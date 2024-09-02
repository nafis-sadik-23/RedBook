﻿// <auto-generated />
using System;
using Inventory.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inventory.Data.Migrations
{
    [DbContext(typeof(RedbookInventoryContext))]
    partial class RedbookInventoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Inventory.Data.Entities.Bank", b =>
                {
                    b.Property<int>("BankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BankId"));

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BankId");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("Inventory.Data.Entities.BankAccount", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.HasKey("AccountId");

                    b.HasIndex("BranchId");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("Inventory.Data.Entities.BankBranch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BranchId"));

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranchId");

                    b.HasIndex("BankId");

                    b.ToTable("BankBranches");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CatagoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Inventory.Data.Entities.CommonAttribute", b =>
                {
                    b.Property<int>("AttributeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AttributeId"));

                    b.Property<string>("AttributeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AttributeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<int?>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AttributeId");

                    b.ToTable("CommonAttributes");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("QuantityAttributeId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("QuantityAttributeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Inventory.Data.Entities.PurchaseInvoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"));

                    b.Property<DateTime>("ChalanDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ChalanNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Terms")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<decimal>("TotalPurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("InvoiceId");

                    b.HasIndex("VendorId");

                    b.ToTable("PurchaseInvoices");
                });

            modelBuilder.Entity("Inventory.Data.Entities.PurchasePaymentRecord", b =>
                {
                    b.Property<int>("PurchasePaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchasePaymentId"));

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionReference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PurchasePaymentId");

                    b.HasIndex("AccountId");

                    b.HasIndex("InvoiceId");

                    b.ToTable("PurchasePaymentRecords");
                });

            modelBuilder.Entity("Inventory.Data.Entities.PurchaseRecords", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordId"));

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductName")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("RecordId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ProductId");

                    b.ToTable("PurchaseRecords");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Sale", b =>
                {
                    b.Property<int>("SalesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesId"));

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SalesId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ProductId");

                    b.HasIndex("PurchaseId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Inventory.Data.Entities.SalesInvoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"));

                    b.Property<string>("ChalanNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SalesDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoldBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("InvoiceId");

                    b.ToTable("SalesInvoices");
                });

            modelBuilder.Entity("Inventory.Data.Entities.SalesPaymentRecord", b =>
                {
                    b.Property<int>("SalesPaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesPaymentId"));

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int?>("PaidBy")
                        .HasColumnType("int");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RecievedBy")
                        .HasColumnType("int");

                    b.HasKey("SalesPaymentId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("PaidBy");

                    b.ToTable("SalesPaymentRecords");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Vendor", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendorId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VendorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VendorId");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("Inventory.Data.Entities.BankAccount", b =>
                {
                    b.HasOne("Inventory.Data.Entities.BankBranch", "Branch")
                        .WithMany("BankAccounts")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Inventory.Data.Entities.BankBranch", b =>
                {
                    b.HasOne("Inventory.Data.Entities.Bank", "Bank")
                        .WithMany("BankBranches")
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Category", b =>
                {
                    b.HasOne("Inventory.Data.Entities.Category", "ParentCategory")
                        .WithMany("InverseParentCategory")
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Product", b =>
                {
                    b.HasOne("Inventory.Data.Entities.CommonAttribute", "BrandAttribute")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Data.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Data.Entities.CommonAttribute", "QuantityAttribute")
                        .WithMany()
                        .HasForeignKey("QuantityAttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BrandAttribute");

                    b.Navigation("Category");

                    b.Navigation("QuantityAttribute");
                });

            modelBuilder.Entity("Inventory.Data.Entities.PurchaseInvoice", b =>
                {
                    b.HasOne("Inventory.Data.Entities.Vendor", "Vendor")
                        .WithMany("PurchaseInvoices")
                        .HasForeignKey("VendorId");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("Inventory.Data.Entities.PurchasePaymentRecord", b =>
                {
                    b.HasOne("Inventory.Data.Entities.BankAccount", "BankAccount")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("Inventory.Data.Entities.PurchaseInvoice", "Invoice")
                        .WithMany("PurchasePaymentRecords")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BankAccount");

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("Inventory.Data.Entities.PurchaseRecords", b =>
                {
                    b.HasOne("Inventory.Data.Entities.PurchaseInvoice", "Invoice")
                        .WithMany("Purchases")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Data.Entities.Product", "Product")
                        .WithMany("Purchases")
                        .HasForeignKey("ProductId");

                    b.Navigation("Invoice");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Sale", b =>
                {
                    b.HasOne("Inventory.Data.Entities.SalesInvoice", "Invoice")
                        .WithMany("Sales")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Data.Entities.Product", "Product")
                        .WithMany("Sales")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Data.Entities.PurchaseInvoice", "PurchaseInvoice")
                        .WithMany()
                        .HasForeignKey("PurchaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Product");

                    b.Navigation("PurchaseInvoice");
                });

            modelBuilder.Entity("Inventory.Data.Entities.SalesPaymentRecord", b =>
                {
                    b.HasOne("Inventory.Data.Entities.SalesInvoice", "Invoice")
                        .WithMany("SalesPaymentRecords")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Data.Entities.Customer", "Customer")
                        .WithMany("SalesPaymentRecords")
                        .HasForeignKey("PaidBy");

                    b.Navigation("Customer");

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Bank", b =>
                {
                    b.Navigation("BankBranches");
                });

            modelBuilder.Entity("Inventory.Data.Entities.BankBranch", b =>
                {
                    b.Navigation("BankAccounts");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Category", b =>
                {
                    b.Navigation("InverseParentCategory");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Customer", b =>
                {
                    b.Navigation("SalesPaymentRecords");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Product", b =>
                {
                    b.Navigation("Purchases");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Inventory.Data.Entities.PurchaseInvoice", b =>
                {
                    b.Navigation("PurchasePaymentRecords");

                    b.Navigation("Purchases");
                });

            modelBuilder.Entity("Inventory.Data.Entities.SalesInvoice", b =>
                {
                    b.Navigation("Sales");

                    b.Navigation("SalesPaymentRecords");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Vendor", b =>
                {
                    b.Navigation("PurchaseInvoices");
                });
#pragma warning restore 612, 618
        }
    }
}
