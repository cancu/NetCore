﻿// <auto-generated />
using System;
using CancuNetCore.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CancuNetCore.RazorUI.Migrations
{
    [DbContext(typeof(NorthwindContext))]
    partial class NorthwindContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CategoryID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Description")
                        .HasColumnType("ntext");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("image");

                    b.HasKey("CategoryId");

                    b.HasIndex("CategoryName")
                        .HasName("CategoryName");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.CustomerCustomerDemo", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnName("CustomerID")
                        .HasMaxLength(5);

                    b.Property<string>("CustomerTypeId")
                        .HasColumnName("CustomerTypeID")
                        .HasMaxLength(10);

                    b.HasKey("CustomerId", "CustomerTypeId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("CustomerTypeId");

                    b.ToTable("CustomerCustomerDemo");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.CustomerDemographics", b =>
                {
                    b.Property<string>("CustomerTypeId")
                        .HasColumnName("CustomerTypeID")
                        .HasMaxLength(10);

                    b.Property<string>("CustomerDesc")
                        .HasColumnType("ntext");

                    b.HasKey("CustomerTypeId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("CustomerDemographics");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Customers", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnName("CustomerID")
                        .HasMaxLength(5);

                    b.Property<string>("Address")
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .HasMaxLength(15);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ContactName")
                        .HasMaxLength(30);

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .HasMaxLength(15);

                    b.Property<string>("Fax")
                        .HasMaxLength(24);

                    b.Property<string>("Phone")
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasMaxLength(15);

                    b.HasKey("CustomerId");

                    b.HasIndex("City")
                        .HasName("City");

                    b.HasIndex("CompanyName")
                        .HasName("CompanyName");

                    b.HasIndex("PostalCode")
                        .HasName("PostalCode");

                    b.HasIndex("Region")
                        .HasName("Region");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Employees", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EmployeeID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(60);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime");

                    b.Property<string>("City")
                        .HasMaxLength(15);

                    b.Property<string>("Country")
                        .HasMaxLength(15);

                    b.Property<string>("Extension")
                        .HasMaxLength(4);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("datetime");

                    b.Property<string>("HomePhone")
                        .HasMaxLength(24);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Notes")
                        .HasColumnType("ntext");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("image");

                    b.Property<string>("PhotoPath")
                        .HasMaxLength(255);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasMaxLength(15);

                    b.Property<int?>("ReportsTo");

                    b.Property<string>("Title")
                        .HasMaxLength(30);

                    b.Property<string>("TitleOfCourtesy")
                        .HasMaxLength(25);

                    b.HasKey("EmployeeId");

                    b.HasIndex("LastName")
                        .HasName("LastName");

                    b.HasIndex("PostalCode")
                        .HasName("PostalCode");

                    b.HasIndex("ReportsTo");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.EmployeeTerritories", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnName("EmployeeID");

                    b.Property<string>("TerritoryId")
                        .HasColumnName("TerritoryID")
                        .HasMaxLength(20);

                    b.HasKey("EmployeeId", "TerritoryId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("TerritoryId");

                    b.ToTable("EmployeeTerritories");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.OrderDetails", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnName("OrderID");

                    b.Property<int>("ProductId")
                        .HasColumnName("ProductID");

                    b.Property<float>("Discount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(0)");

                    b.Property<short>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(1)");

                    b.Property<decimal>("UnitPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValueSql("(0)");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("OrderId")
                        .HasName("OrdersOrder_Details");

                    b.HasIndex("ProductId")
                        .HasName("ProductsOrder_Details");

                    b.ToTable("Order Details");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Orders", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrderID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerId")
                        .HasColumnName("CustomerID")
                        .HasMaxLength(5);

                    b.Property<int?>("EmployeeId")
                        .HasColumnName("EmployeeID");

                    b.Property<decimal?>("Freight")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValueSql("(0)");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("RequiredDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ShipAddress")
                        .HasMaxLength(60);

                    b.Property<string>("ShipCity")
                        .HasMaxLength(15);

                    b.Property<string>("ShipCountry")
                        .HasMaxLength(15);

                    b.Property<string>("ShipName")
                        .HasMaxLength(40);

                    b.Property<string>("ShipPostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("ShipRegion")
                        .HasMaxLength(15);

                    b.Property<int?>("ShipVia");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnType("datetime");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId")
                        .HasName("CustomersOrders");

                    b.HasIndex("EmployeeId")
                        .HasName("EmployeesOrders");

                    b.HasIndex("OrderDate")
                        .HasName("OrderDate");

                    b.HasIndex("ShipPostalCode")
                        .HasName("ShipPostalCode");

                    b.HasIndex("ShipVia")
                        .HasName("ShippersOrders");

                    b.HasIndex("ShippedDate")
                        .HasName("ShippedDate");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProductID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnName("CategoryID");

                    b.Property<bool?>("Discontinued")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(0)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("QuantityPerUnit")
                        .HasMaxLength(20);

                    b.Property<short?>("ReorderLevel")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(0)");

                    b.Property<int?>("SupplierId")
                        .HasColumnName("SupplierID");

                    b.Property<decimal?>("UnitPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValueSql("(0)");

                    b.Property<short?>("UnitsInStock")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(0)");

                    b.Property<short?>("UnitsOnOrder")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(0)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId")
                        .HasName("CategoryID");

                    b.HasIndex("ProductName")
                        .HasName("ProductName");

                    b.HasIndex("SupplierId")
                        .HasName("SuppliersProducts");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .HasColumnName("RegionID");

                    b.Property<string>("RegionDescription")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("RegionId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("Region");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Security.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("PermissionId");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Security.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Security.RolePermission", b =>
                {
                    b.Property<int>("RolePermissionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PermissionId");

                    b.Property<int>("RoleId");

                    b.HasKey("RolePermissionId");

                    b.ToTable("RolePermission");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Security.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Security.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId");

                    b.Property<int>("UserId");

                    b.HasKey("UserRoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Shippers", b =>
                {
                    b.Property<int>("ShipperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ShipperID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Phone")
                        .HasMaxLength(24);

                    b.HasKey("ShipperId");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Suppliers", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SupplierID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .HasMaxLength(15);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ContactName")
                        .HasMaxLength(30);

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .HasMaxLength(15);

                    b.Property<string>("Fax")
                        .HasMaxLength(24);

                    b.Property<string>("HomePage")
                        .HasColumnType("ntext");

                    b.Property<string>("Phone")
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasMaxLength(15);

                    b.HasKey("SupplierId");

                    b.HasIndex("CompanyName")
                        .HasName("CompanyName");

                    b.HasIndex("PostalCode")
                        .HasName("PostalCode");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Territories", b =>
                {
                    b.Property<string>("TerritoryId")
                        .HasColumnName("TerritoryID")
                        .HasMaxLength(20);

                    b.Property<int>("RegionId")
                        .HasColumnName("RegionID");

                    b.Property<string>("TerritoryDescription")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("TerritoryId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("RegionId");

                    b.ToTable("Territories");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.CustomerCustomerDemo", b =>
                {
                    b.HasOne("CancuNetCore.Domain.Entities.Customers", "Customer")
                        .WithMany("CustomerCustomerDemo")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_CustomerCustomerDemo_Customers");

                    b.HasOne("CancuNetCore.Domain.Entities.CustomerDemographics", "CustomerType")
                        .WithMany("CustomerCustomerDemo")
                        .HasForeignKey("CustomerTypeId")
                        .HasConstraintName("FK_CustomerCustomerDemo");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Employees", b =>
                {
                    b.HasOne("CancuNetCore.Domain.Entities.Employees", "ReportsToNavigation")
                        .WithMany("InverseReportsToNavigation")
                        .HasForeignKey("ReportsTo")
                        .HasConstraintName("FK_Employees_Employees");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.EmployeeTerritories", b =>
                {
                    b.HasOne("CancuNetCore.Domain.Entities.Employees", "Employee")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_EmployeeTerritories_Employees");

                    b.HasOne("CancuNetCore.Domain.Entities.Territories", "Territory")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("TerritoryId")
                        .HasConstraintName("FK_EmployeeTerritories_Territories");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.OrderDetails", b =>
                {
                    b.HasOne("CancuNetCore.Domain.Entities.Orders", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_Order_Details_Orders");

                    b.HasOne("CancuNetCore.Domain.Entities.Products", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Order_Details_Products");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Orders", b =>
                {
                    b.HasOne("CancuNetCore.Domain.Entities.Customers", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Orders_Customers");

                    b.HasOne("CancuNetCore.Domain.Entities.Employees", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_Orders_Employees");

                    b.HasOne("CancuNetCore.Domain.Entities.Shippers", "ShipViaNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("ShipVia")
                        .HasConstraintName("FK_Orders_Shippers");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Products", b =>
                {
                    b.HasOne("CancuNetCore.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Products_Categories");

                    b.HasOne("CancuNetCore.Domain.Entities.Suppliers", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .HasConstraintName("FK_Products_Suppliers");
                });

            modelBuilder.Entity("CancuNetCore.Domain.Entities.Territories", b =>
                {
                    b.HasOne("CancuNetCore.Domain.Entities.Region", "Region")
                        .WithMany("Territories")
                        .HasForeignKey("RegionId")
                        .HasConstraintName("FK_Territories_Region");
                });
#pragma warning restore 612, 618
        }
    }
}
