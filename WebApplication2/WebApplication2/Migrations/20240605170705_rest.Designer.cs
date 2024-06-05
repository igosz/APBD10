﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Contexts;

#nullable disable

namespace WebApplication2.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240605170705_rest")]
    partial class rest
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.4.24267.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication2.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_account");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)")
                        .HasColumnName("phone");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("FK_role");

                    b.HasKey("AccountId");

                    b.HasIndex("RoleId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountId = 1,
                            Email = "lllla",
                            FirstName = "ll",
                            LastName = "zz",
                            Phone = "999999999",
                            RoleId = 1
                        },
                        new
                        {
                            AccountId = 2,
                            Email = "lllla",
                            FirstName = "ll",
                            LastName = "zz",
                            Phone = "999999999",
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Categorie", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_category");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "222"
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_product");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<double>("Depth")
                        .HasPrecision(5, 2)
                        .HasColumnType("float(5)")
                        .HasColumnName("depth");

                    b.Property<double>("Height")
                        .HasPrecision(5, 2)
                        .HasColumnType("float(5)")
                        .HasColumnName("height");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<double>("Weight")
                        .HasPrecision(5, 2)
                        .HasColumnType("float(5)")
                        .HasColumnName("weight");

                    b.Property<double>("Width")
                        .HasPrecision(5, 2)
                        .HasColumnType("float(5)")
                        .HasColumnName("width");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Depth = 22.0,
                            Height = 23.0,
                            Name = "dfs",
                            Weight = 21.0,
                            Width = 11.0
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.ProductCategorie", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("FK_product");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("FK_category");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products_categories");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Role", b =>
                {
                    b.Property<int>("Role_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_role");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Role_Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Role_Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Role_Id = 1,
                            Name = "created"
                        },
                        new
                        {
                            Role_Id = 2,
                            Name = "finished"
                        },
                        new
                        {
                            Role_Id = 3,
                            Name = "removed"
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.ShoppingCart", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("FK_product");

                    b.Property<int>("AccountId")
                        .HasColumnType("int")
                        .HasColumnName("FK_account");

                    b.Property<int>("Amount")
                        .HasColumnType("int")
                        .HasColumnName("amount");

                    b.HasKey("ProductId", "AccountId");

                    b.HasIndex("AccountId");

                    b.ToTable("Shopping_Carts");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            AccountId = 1,
                            Amount = 20
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Account", b =>
                {
                    b.HasOne("WebApplication2.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WebApplication2.Models.ProductCategorie", b =>
                {
                    b.HasOne("WebApplication2.Models.Categorie", "Categorie")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication2.Models.Product", "Product")
                        .WithMany("ProductCategorie")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorie");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebApplication2.Models.ShoppingCart", b =>
                {
                    b.HasOne("WebApplication2.Models.Account", "Account")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication2.Models.Product", "Product")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebApplication2.Models.Account", b =>
                {
                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("WebApplication2.Models.Categorie", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("WebApplication2.Models.Product", b =>
                {
                    b.Navigation("ProductCategorie");

                    b.Navigation("ShoppingCarts");
                });
#pragma warning restore 612, 618
        }
    }
}
