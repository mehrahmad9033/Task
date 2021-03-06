// <auto-generated />
using Assignment.Infrastructure.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment.Infrastructure.Migrations
{
    [DbContext(typeof(TaskContext))]
    [Migration("20220616173635_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment.Domain.Modals.Companies", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName");

                    b.HasKey("CompanyID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Assignment.Domain.Modals.Investor", b =>
                {
                    b.Property<int>("InvestorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(500);

                    b.Property<string>("City")
                        .HasMaxLength(100);

                    b.Property<string>("ContactNo")
                        .HasMaxLength(20);

                    b.Property<string>("Email");

                    b.Property<string>("IDType");

                    b.Property<string>("InvestorName")
                        .HasMaxLength(100);

                    b.Property<string>("Nationality");

                    b.Property<int>("SharePrice");

                    b.Property<int>("ShareValue");

                    b.HasKey("InvestorID");

                    b.ToTable("Investor");
                });
#pragma warning restore 612, 618
        }
    }
}
