﻿// <auto-generated />
using Inventory.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Domain.Migrations
{
    [DbContext(typeof(RedBookInventoryContext))]
    [Migration("20230218160916_OrganizationAdded")]
    partial class OrganizationAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Inventory.Domain.Entities.Bank", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.BankBranch", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.ToTable("BankBranch");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Catagory", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CatagoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("ParentCategory")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategory");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.CommonAttribute", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("AttributeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("AttributeType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UpdateBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("CommonAttribute", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AttributeName = "Liter",
                            AttributeType = "Quantity",
                            CreateDate = new DateTime(2023, 2, 18, 16, 9, 15, 982, DateTimeKind.Utc).AddTicks(3655),
                            CreatedBy = "SystemAdmin",
                            UpdateBy = ""
                        },
                        new
                        {
                            Id = 2,
                            AttributeName = "Kg",
                            AttributeType = "Quantity",
                            CreateDate = new DateTime(2023, 2, 18, 16, 9, 15, 982, DateTimeKind.Utc).AddTicks(3661),
                            CreatedBy = "SystemAdmin",
                            UpdateBy = ""
                        },
                        new
                        {
                            Id = 3,
                            AttributeName = "Meter",
                            AttributeType = "Quantity",
                            CreateDate = new DateTime(2023, 2, 18, 16, 9, 15, 982, DateTimeKind.Utc).AddTicks(3663),
                            CreatedBy = "SystemAdmin",
                            UpdateBy = ""
                        });
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("ChalanNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int>("QuantityAttributeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChalanNumber");

                    b.HasIndex("ProductId");

                    b.ToTable("Inventory", (string)null);
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int>("QuantityAttributeId")
                        .HasColumnType("int");

                    b.Property<string>("UpdateBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Purchase", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CheckNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("FromBankBranchId")
                        .HasColumnType("int");

                    b.Property<int>("FromBankId")
                        .HasColumnType("int");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime");

                    b.Property<string>("PurchasedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("ToBankBranchId")
                        .HasColumnType("int");

                    b.Property<int>("ToBankId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPurchasePrice")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("Id");

                    b.HasIndex("FromBankBranchId");

                    b.HasIndex("FromBankId");

                    b.HasIndex("ToBankBranchId");

                    b.HasIndex("ToBankId");

                    b.ToTable("Purchase", (string)null);
                });

            modelBuilder.Entity("Inventory.Domain.Entities.PurchaseDetail", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("ChalanNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("Id");

                    b.HasIndex("ChalanNumber");

                    b.HasIndex("ProductId");

                    b.ToTable("PurchaseDetails");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.PurchasePaymentRecord", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("ChalanNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("ChalanNumber");

                    b.ToTable("PurchasePayments");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Sale", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SalesDate")
                        .HasColumnType("datetime");

                    b.Property<string>("SoldBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.SalesDetail", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("ChalanNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("MemoNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("Id");

                    b.HasIndex("ChalanNo");

                    b.HasIndex("MemoNumber");

                    b.HasIndex("ProductId");

                    b.ToTable("SalesDetails");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.SalesPaymentRecord", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("MemoNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("MemoNumber");

                    b.ToTable("SalesPaymentRecords");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.BankBranch", b =>
                {
                    b.HasOne("Inventory.Domain.Entities.Bank", "Bank")
                        .WithMany("BankBranches")
                        .HasForeignKey("BankId")
                        .IsRequired()
                        .HasConstraintName("FK_BankBranches_Banks");

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Catagory", b =>
                {
                    b.HasOne("Inventory.Domain.Entities.Catagory", "ParentCategoryNavigation")
                        .WithMany("InverseParentCategoryNavigation")
                        .HasForeignKey("ParentCategory")
                        .HasConstraintName("FK_Catagories_Catagories");

                    b.Navigation("ParentCategoryNavigation");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Inventory", b =>
                {
                    b.HasOne("Inventory.Domain.Entities.Purchase", "ChalanNumberNavigation")
                        .WithMany("Inventories")
                        .HasForeignKey("ChalanNumber")
                        .IsRequired()
                        .HasConstraintName("FK_Inventory_Purchase");

                    b.HasOne("Inventory.Domain.Entities.Product", "Product")
                        .WithMany("Inventories")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_Inventory_Products");

                    b.Navigation("ChalanNumberNavigation");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Purchase", b =>
                {
                    b.HasOne("Inventory.Domain.Entities.BankBranch", "FromBankBranch")
                        .WithMany("PurchaseFromBankBranches")
                        .HasForeignKey("FromBankBranchId")
                        .IsRequired()
                        .HasConstraintName("FK_Purchase_BankBranches1");

                    b.HasOne("Inventory.Domain.Entities.Bank", "FromBank")
                        .WithMany("PurchaseFromBanks")
                        .HasForeignKey("FromBankId")
                        .IsRequired()
                        .HasConstraintName("FK_Purchase_Banks1");

                    b.HasOne("Inventory.Domain.Entities.BankBranch", "ToBankBranch")
                        .WithMany("PurchaseToBankBranches")
                        .HasForeignKey("ToBankBranchId")
                        .IsRequired()
                        .HasConstraintName("FK_Purchase_BankBranches");

                    b.HasOne("Inventory.Domain.Entities.Bank", "ToBank")
                        .WithMany("PurchaseToBanks")
                        .HasForeignKey("ToBankId")
                        .IsRequired()
                        .HasConstraintName("FK_Purchase_Banks");

                    b.Navigation("FromBank");

                    b.Navigation("FromBankBranch");

                    b.Navigation("ToBank");

                    b.Navigation("ToBankBranch");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.PurchaseDetail", b =>
                {
                    b.HasOne("Inventory.Domain.Entities.Purchase", "ChalanNumberNavigation")
                        .WithMany("PurchaseDetails")
                        .HasForeignKey("ChalanNumber")
                        .IsRequired()
                        .HasConstraintName("FK_PurchaseDetails_Purchase1");

                    b.HasOne("Inventory.Domain.Entities.Product", "Product")
                        .WithMany("PurchaseDetails")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_PurchaseDetails_Products");

                    b.Navigation("ChalanNumberNavigation");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.PurchasePaymentRecord", b =>
                {
                    b.HasOne("Inventory.Domain.Entities.Purchase", "ChalanNumberNavigation")
                        .WithMany("PurchasePaymentRecords")
                        .HasForeignKey("ChalanNumber")
                        .IsRequired()
                        .HasConstraintName("FK_PurchasePaymentRecords_Purchase");

                    b.Navigation("ChalanNumberNavigation");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.SalesDetail", b =>
                {
                    b.HasOne("Inventory.Domain.Entities.Purchase", "ChalanNoNavigation")
                        .WithMany("SalesDetails")
                        .HasForeignKey("ChalanNo")
                        .IsRequired()
                        .HasConstraintName("FK_SalesDetails_Purchase");

                    b.HasOne("Inventory.Domain.Entities.Sale", "MemoNumberNavigation")
                        .WithMany("SalesDetails")
                        .HasForeignKey("MemoNumber")
                        .IsRequired()
                        .HasConstraintName("FK_SalesDetails_Sales");

                    b.HasOne("Inventory.Domain.Entities.Product", "Product")
                        .WithMany("SalesDetails")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_SalesDetails_Products");

                    b.Navigation("ChalanNoNavigation");

                    b.Navigation("MemoNumberNavigation");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.SalesPaymentRecord", b =>
                {
                    b.HasOne("Inventory.Domain.Entities.Sale", "MemoNumberNavigation")
                        .WithMany("SalesPaymentRecords")
                        .HasForeignKey("MemoNumber")
                        .IsRequired()
                        .HasConstraintName("FK_SalesPaymentRecords_Sales");

                    b.Navigation("MemoNumberNavigation");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Bank", b =>
                {
                    b.Navigation("BankBranches");

                    b.Navigation("PurchaseFromBanks");

                    b.Navigation("PurchaseToBanks");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.BankBranch", b =>
                {
                    b.Navigation("PurchaseFromBankBranches");

                    b.Navigation("PurchaseToBankBranches");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Catagory", b =>
                {
                    b.Navigation("InverseParentCategoryNavigation");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Product", b =>
                {
                    b.Navigation("Inventories");

                    b.Navigation("PurchaseDetails");

                    b.Navigation("SalesDetails");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Purchase", b =>
                {
                    b.Navigation("Inventories");

                    b.Navigation("PurchaseDetails");

                    b.Navigation("PurchasePaymentRecords");

                    b.Navigation("SalesDetails");
                });

            modelBuilder.Entity("Inventory.Domain.Entities.Sale", b =>
                {
                    b.Navigation("SalesDetails");

                    b.Navigation("SalesPaymentRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
