﻿// <auto-generated />
using System;
using Magazzino.Repository.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Magazzino.web.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20181006225628_ju")]
    partial class ju
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview2-35157")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Magazzino.Data.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("IdCustomer");

                    b.Property<string>("LastName");

                    b.Property<string>("Location");

                    b.Property<string>("Mail");

                    b.Property<string>("MetodoPago");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ModifyByUserId");

                    b.Property<string>("Name");

                    b.Property<string>("RowId");

                    b.HasKey("Id");

                    b.ToTable("Customer","dbo");
                });

            modelBuilder.Entity("Magazzino.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cal");

                    b.Property<string>("Category");

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Details");

                    b.Property<int>("IdProduct");

                    b.Property<int>("IdSellers");

                    b.Property<string>("Img");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ModifyByUserId");

                    b.Property<int>("Money");

                    b.Property<string>("ProductName");

                    b.Property<string>("RowId");

                    b.HasKey("Id");

                    b.ToTable("Product","dbo");
                });

            modelBuilder.Entity("Magazzino.Data.Entities.Sales", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalDate");

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("IdClient");

                    b.Property<int>("IdProduct");

                    b.Property<int>("IdSale");

                    b.Property<int>("IdSeller");

                    b.Property<string>("LocationClient");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ModifyByUserId");

                    b.Property<string>("Price");

                    b.Property<string>("ProductName");

                    b.Property<string>("RowId");

                    b.Property<DateTime>("ShoppingDate");

                    b.Property<string>("Status");

                    b.Property<string>("Transation");

                    b.HasKey("Id");

                    b.ToTable("Sales","dbo");
                });

            modelBuilder.Entity("Magazzino.Data.Entities.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cal");

                    b.Property<string>("Company");

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("IdSeller");

                    b.Property<string>("Location");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ModifyByUserId");

                    b.Property<string>("Policy");

                    b.Property<string>("Post");

                    b.Property<string>("RowId");

                    b.Property<string>("Tel");

                    b.HasKey("Id");

                    b.ToTable("Seller","dbo");
                });

            modelBuilder.Entity("Magazzino.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("IdUser");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ModifyByUserId");

                    b.Property<string>("Password");

                    b.Property<string>("RowId");

                    b.Property<string>("Type");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("User","dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
