﻿// <auto-generated />
using DesignPattern.Decorator.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DesignPattern.Decorator.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240422053748_mig3")]
    partial class mig3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DesignPattern.Decorator.DAL.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageID"), 1L, 1);

                    b.Property<string>("MessageContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageReceiver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageSender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageSubject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("DesignPattern.Decorator.DAL.Notifier", b =>
                {
                    b.Property<int>("NotifierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotifierID"), 1L, 1);

                    b.Property<string>("NotifierChannel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotifierCreator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotifierSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotifierType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotifierID");

                    b.ToTable("Notifiers");
                });
#pragma warning restore 612, 618
        }
    }
}
