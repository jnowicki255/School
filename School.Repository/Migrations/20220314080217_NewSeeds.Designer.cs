// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School.Repository;

#nullable disable

namespace School.Repository.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20220314080217_NewSeeds")]
    partial class NewSeeds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DbSubjectDbTeacher", b =>
                {
                    b.Property<int>("SubjectsSubjectId")
                        .HasColumnType("int");

                    b.Property<int>("TeachersTeacherId")
                        .HasColumnType("int");

                    b.HasKey("SubjectsSubjectId", "TeachersTeacherId");

                    b.HasIndex("TeachersTeacherId");

                    b.ToTable("DbSubjectDbTeacher");
                });

            modelBuilder.Entity("School.Repository.Entities.DbClass", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int?>("TeacherId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ClassId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            ClassId = 1,
                            Name = "1A",
                            TeacherId = 1
                        },
                        new
                        {
                            ClassId = 2,
                            Name = "2B",
                            TeacherId = 2
                        },
                        new
                        {
                            ClassId = 3,
                            Name = "3C",
                            TeacherId = 3
                        },
                        new
                        {
                            ClassId = 4,
                            Name = "4D",
                            TeacherId = 4
                        });
                });

            modelBuilder.Entity("School.Repository.Entities.DbStudent", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<int?>("ClassId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("StudentId");

                    b.HasIndex("ClassId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            BirthDate = new DateTime(2010, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ClassId = 1,
                            FirstName = "Marcin",
                            LastName = "Amoniak",
                            Telephone = "123-123-123"
                        },
                        new
                        {
                            StudentId = 2,
                            BirthDate = new DateTime(2010, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ClassId = 1,
                            FirstName = "Andrzej",
                            LastName = "Mackiewicz",
                            Telephone = "123-123-123"
                        },
                        new
                        {
                            StudentId = 3,
                            BirthDate = new DateTime(2010, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ClassId = 2,
                            FirstName = "Zdzisław",
                            LastName = "Kasztan",
                            Telephone = "123-123-123"
                        },
                        new
                        {
                            StudentId = 4,
                            BirthDate = new DateTime(2010, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ClassId = 2,
                            FirstName = "Ryszard",
                            LastName = "Boguza",
                            Telephone = "123-123-123"
                        },
                        new
                        {
                            StudentId = 5,
                            BirthDate = new DateTime(2010, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ClassId = 3,
                            FirstName = "Maciej",
                            LastName = "Armani",
                            Telephone = "123-123-123"
                        },
                        new
                        {
                            StudentId = 6,
                            BirthDate = new DateTime(2010, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ClassId = 3,
                            FirstName = "Wioletta",
                            LastName = "Kamana",
                            Telephone = "123-123-123"
                        },
                        new
                        {
                            StudentId = 7,
                            BirthDate = new DateTime(2010, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ClassId = 4,
                            FirstName = "Rydygier",
                            LastName = "Węzał",
                            Telephone = "123-123-123"
                        },
                        new
                        {
                            StudentId = 8,
                            BirthDate = new DateTime(2010, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ClassId = 4,
                            FirstName = "Pola",
                            LastName = "Imola",
                            Telephone = "123-123-123"
                        });
                });

            modelBuilder.Entity("School.Repository.Entities.DbSubject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            SubjectId = 1,
                            Name = "Matematyka"
                        },
                        new
                        {
                            SubjectId = 2,
                            Name = "Język polski"
                        },
                        new
                        {
                            SubjectId = 3,
                            Name = "Język angielski"
                        },
                        new
                        {
                            SubjectId = 4,
                            Name = "Fizyka"
                        });
                });

            modelBuilder.Entity("School.Repository.Entities.DbTeacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            FirstName = "Jan",
                            LastName = "Nowak"
                        },
                        new
                        {
                            TeacherId = 2,
                            FirstName = "Anna",
                            LastName = "Kowalska"
                        },
                        new
                        {
                            TeacherId = 3,
                            FirstName = "Bogusław",
                            LastName = "Łęcina"
                        },
                        new
                        {
                            TeacherId = 4,
                            FirstName = "Władysław",
                            LastName = "Jagiełło"
                        });
                });

            modelBuilder.Entity("DbSubjectDbTeacher", b =>
                {
                    b.HasOne("School.Repository.Entities.DbSubject", null)
                        .WithMany()
                        .HasForeignKey("SubjectsSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Repository.Entities.DbTeacher", null)
                        .WithMany()
                        .HasForeignKey("TeachersTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("School.Repository.Entities.DbClass", b =>
                {
                    b.HasOne("School.Repository.Entities.DbTeacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("School.Repository.Entities.DbStudent", b =>
                {
                    b.HasOne("School.Repository.Entities.DbClass", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("School.Repository.Entities.DbClass", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
