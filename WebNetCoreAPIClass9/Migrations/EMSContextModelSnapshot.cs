﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebNetCoreAPIClass9.Models;

namespace WebNetCoreAPIClass9.Migrations
{
    [DbContext(typeof(EMSContext))]
    partial class EMSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebNetCoreAPIClass9.Models.Employee", b =>
                {
                    b.Property<int>("Employee_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email_Id");

                    b.Property<string>("First_Name");

                    b.Property<string>("Last_Name");

                    b.Property<string>("PhoneNo");

                    b.HasKey("Employee_Id");

                    b.ToTable("TBL_NETCORE_EMPLOYEE");
                });

            modelBuilder.Entity("WebNetCoreAPIClass9.Models.EmployeeLeave", b =>
                {
                    b.Property<int>("Leave_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Employee_Id");

                    b.Property<int?>("Total_Leaves");

                    b.HasKey("Leave_Id");

                    b.ToTable("TBL_NETCORE_EMPLOYEE_LEAVES");
                });
#pragma warning restore 612, 618
        }
    }
}