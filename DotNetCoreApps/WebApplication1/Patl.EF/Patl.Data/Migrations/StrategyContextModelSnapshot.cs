﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Patl.Data;
using System;

namespace Patl.Data.Migrations
{
    [DbContext(typeof(StrategyContext))]
    partial class StrategyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Patl.Domain.Strategy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateEnd");

                    b.Property<DateTime>("DateStart");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("PriceEnd");

                    b.Property<decimal>("PriceStart");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Strategies");
                });

            modelBuilder.Entity("Patl.Domain.Trade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Close");

                    b.Property<string>("Description");

                    b.Property<string>("ImageThumbnailUrl");

                    b.Property<bool>("IsTradeOfTheMonth");

                    b.Property<string>("Name");

                    b.Property<DateTime>("Open");

                    b.Property<decimal>("PriceClose");

                    b.Property<decimal>("PriceOpen");

                    b.Property<int>("StrategyId");

                    b.Property<string>("Symbol");

                    b.Property<string>("TransactionType");

                    b.HasKey("Id");

                    b.HasIndex("StrategyId");

                    b.ToTable("Trades");
                });

            modelBuilder.Entity("Patl.Domain.Trade", b =>
                {
                    b.HasOne("Patl.Domain.Strategy")
                        .WithMany("Trades")
                        .HasForeignKey("StrategyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
