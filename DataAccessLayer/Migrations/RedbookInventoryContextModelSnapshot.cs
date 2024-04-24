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
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("BankId")
                        .HasName("PK__Bank__3214EC07A30FEA48");

                    b.ToTable("Bank", (string)null);
                });

            modelBuilder.Entity("Inventory.Data.Entities.BankAccount", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.HasKey("AccountId");

                    b.HasIndex(new[] { "BranchId" }, "IX_BankAccounts_BranchId");

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
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("BranchId");

                    b.HasIndex(new[] { "BankId" }, "IX_BankBranch_BankId");

                    b.ToTable("BankBranch", (string)null);
                });

            modelBuilder.Entity("Inventory.Data.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CatagoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CreateDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex(new[] { "ParentCategoryId" }, "IX_Categories_ParentCategoryId");

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
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("AttributeType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<int?>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.HasKey("AttributeId");

                    b.HasIndex(new[] { "AttributeId" }, "PK__CommonAt__3214EC0712D1E7C6")
                        .IsUnique();

                    b.ToTable("CommonAttribute", (string)null);
                });

            modelBuilder.Entity("Inventory.Data.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int>("QuantityAttributeId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.HasKey("ProductId");

                    b.HasIndex(new[] { "CategoryId" }, "IX_Products_CategoryId");

                    b.HasIndex(new[] { "QuantityAttributeId" }, "IX_Products_QuantityAttributeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseId"));

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("PurchaseId")
                        .HasName("PK_PurchaseDetails");

                    b.HasIndex("InvoiceId");

                    b.HasIndex(new[] { "ProductId" }, "IX_PurchaseDetails_ProductId");

                    b.ToTable("Purchase", (string)null);
                });

            modelBuilder.Entity("Inventory.Data.Entities.PurchaseInvoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"));

                    b.Property<string>("ChalanNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CheckNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<int>("PurchaseId")
                        .HasColumnType("int");

                    b.Property<int?>("PurchasedBy")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPurchasePrice")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("InvoiceId")
                        .HasName("PK_Purchase");

                    b.ToTable("PurchaseInvoice", (string)null);
                });

            modelBuilder.Entity("Inventory.Data.Entities.PurchasePaymentRecord", b =>
                {
                    b.Property<int>("PurchasePaymentId")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<DateTime>("PaymentDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.HasKey("PurchasePaymentId")
                        .HasName("PK_PurchasePayments");

                    b.HasIndex(new[] { "InvoiceId" }, "IX_PurchasePayments_PurchaseId");

                    b.ToTable("PurchasePaymentRecords");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Sale", b =>
                {
                    b.Property<int>("SalesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesId"));

                    b.Property<string>("ChalanNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("SalesId")
                        .HasName("PK_SalesDetails");

                    b.HasIndex(new[] { "ProductId" }, "IX_SalesDetails_ProductId");

                    b.HasIndex(new[] { "InvoiceId" }, "IX_SalesDetails_SalesId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Inventory.Data.Entities.SalesInvoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"));

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SalesDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<string>("SoldBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("InvoiceId")
                        .HasName("PK_Sales");

                    b.ToTable("SalesInvoice", (string)null);
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
                        .HasColumnType("decimal(18, 0)");

                    b.Property<DateTime>("PaymentDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.HasKey("SalesPaymentId");

                    b.HasIndex(new[] { "InvoiceId" }, "IX_SalesPaymentRecords_SalesId");

                    b.ToTable("SalesPaymentRecords");
                });

            modelBuilder.Entity("Inventory.Data.Entities.BankAccount", b =>
                {
                    b.HasOne("Inventory.Data.Entities.BankBranch", "Branch")
                        .WithMany("BankAccounts")
                        .HasForeignKey("BranchId")
                        .IsRequired()
                        .HasConstraintName("FK_BankAccounts_BankBranch");

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Inventory.Data.Entities.BankBranch", b =>
                {
                    b.HasOne("Inventory.Data.Entities.Bank", "Bank")
                        .WithMany("BankBranches")
                        .HasForeignKey("BankId")
                        .IsRequired()
                        .HasConstraintName("FK_BankBranches_Banks");

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Category", b =>
                {
                    b.HasOne("Inventory.Data.Entities.Category", "ParentCategory")
                        .WithMany("InverseParentCategory")
                        .HasForeignKey("ParentCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Product", b =>
                {
                    b.HasOne("Inventory.Data.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK_Products_Categories");

                    b.HasOne("Inventory.Data.Entities.CommonAttribute", "QuantityAttribute")
                        .WithMany("Products")
                        .HasForeignKey("QuantityAttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Products_CommonAttribute");

                    b.Navigation("Category");

                    b.Navigation("QuantityAttribute");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Purchase", b =>
                {
                    b.HasOne("Inventory.Data.Entities.PurchaseInvoice", "Invoice")
                        .WithMany("Purchases")
                        .HasForeignKey("InvoiceId")
                        .IsRequired()
                        .HasConstraintName("FK_Purchase_PurchaseInvoice");

                    b.HasOne("Inventory.Data.Entities.Product", "Product")
                        .WithMany("Purchases")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_PurchaseDetails_Products");

                    b.Navigation("Invoice");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Inventory.Data.Entities.PurchasePaymentRecord", b =>
                {
                    b.HasOne("Inventory.Data.Entities.PurchaseInvoice", "Invoice")
                        .WithMany("PurchasePaymentRecords")
                        .HasForeignKey("InvoiceId")
                        .IsRequired()
                        .HasConstraintName("FK_PurchasePayments_Purchase");

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("Inventory.Data.Entities.Sale", b =>
                {
                    b.HasOne("Inventory.Data.Entities.SalesInvoice", "Invoice")
                        .WithMany("Sales")
                        .HasForeignKey("InvoiceId")
                        .IsRequired()
                        .HasConstraintName("FK_SalesDetails_Sales");

                    b.HasOne("Inventory.Data.Entities.Product", "Product")
                        .WithMany("Sales")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_SalesDetails_Products");

                    b.Navigation("Invoice");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Inventory.Data.Entities.SalesPaymentRecord", b =>
                {
                    b.HasOne("Inventory.Data.Entities.SalesInvoice", "Invoice")
                        .WithMany("SalesPaymentRecords")
                        .HasForeignKey("InvoiceId")
                        .IsRequired()
                        .HasConstraintName("FK_SalesPaymentRecords_Sales");

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

            modelBuilder.Entity("Inventory.Data.Entities.CommonAttribute", b =>
                {
                    b.Navigation("Products");
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
#pragma warning restore 612, 618
        }
    }
}
