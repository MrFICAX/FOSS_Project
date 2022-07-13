﻿// <auto-generated />
using System;
using Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend.Migrations
{
    [DbContext(typeof(fossContext))]
    [Migration("20210630151840_foss_v6")]
    partial class foss_v6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdminTournir", b =>
                {
                    b.Property<int>("AdminsIDadmin")
                        .HasColumnType("int");

                    b.Property<int>("TournirsIDtournir")
                        .HasColumnType("int");

                    b.HasKey("AdminsIDadmin", "TournirsIDtournir");

                    b.HasIndex("TournirsIDtournir");

                    b.ToTable("AdminTournir");
                });

            modelBuilder.Entity("Backend.Models.Admin", b =>
                {
                    b.Property<int>("IDadmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDadmin")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AdminName");

                    b.Property<string>("AdminSurname")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AdminSurname");

                    b.Property<string>("EnterKey")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EnterKey");

                    b.Property<int?>("GiveAccessByIDperson")
                        .HasColumnType("int");

                    b.HasKey("IDadmin");

                    b.HasIndex("GiveAccessByIDperson");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("Backend.Models.Club", b =>
                {
                    b.Property<int>("IDclub")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDclub")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClubName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClubName");

                    b.Property<int?>("TrainerIDperson")
                        .HasColumnType("int");

                    b.HasKey("IDclub");

                    b.HasIndex("TrainerIDperson");

                    b.ToTable("Club");
                });

            modelBuilder.Entity("Backend.Models.ClubStatistic", b =>
                {
                    b.Property<int>("IDcstatistic")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDcstatistic")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClubStatIDclub")
                        .HasColumnType("int");

                    b.Property<int>("Draws")
                        .HasColumnType("int")
                        .HasColumnName("Draws");

                    b.Property<int>("GoalsDifference")
                        .HasColumnType("int")
                        .HasColumnName("GoalsDifference");

                    b.Property<int>("Loses")
                        .HasColumnType("int")
                        .HasColumnName("Loses");

                    b.Property<int?>("TournirStatCIDtournir")
                        .HasColumnType("int");

                    b.Property<int>("Wins")
                        .HasColumnType("int")
                        .HasColumnName("Wins");

                    b.HasKey("IDcstatistic");

                    b.HasIndex("ClubStatIDclub");

                    b.HasIndex("TournirStatCIDtournir");

                    b.ToTable("ClubStatistic");
                });

            modelBuilder.Entity("Backend.Models.Person", b =>
                {
                    b.Property<int>("IDperson")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDperson")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BornDate")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BornDate");

                    b.Property<string>("PersonName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PersonName");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Surname");

                    b.HasKey("IDperson");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Backend.Models.PlayerStatistic", b =>
                {
                    b.Property<int>("IDpstatistic")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDpstatistic")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cards")
                        .HasColumnType("int")
                        .HasColumnName("Cards");

                    b.Property<int>("Goals")
                        .HasColumnType("int")
                        .HasColumnName("Goals");

                    b.Property<int?>("PlayerStatIDperson")
                        .HasColumnType("int");

                    b.Property<int?>("TournirStatPIDtournir")
                        .HasColumnType("int");

                    b.HasKey("IDpstatistic");

                    b.HasIndex("PlayerStatIDperson");

                    b.HasIndex("TournirStatPIDtournir");

                    b.ToTable("PlayerStatistic");
                });

            modelBuilder.Entity("Backend.Models.TMatch", b =>
                {
                    b.Property<int>("IDmatch")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDmatch")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AwayGoals")
                        .HasColumnType("int")
                        .HasColumnName("AwayGoals");

                    b.Property<int?>("Club1IDclub")
                        .HasColumnType("int");

                    b.Property<int?>("Club2IDclub")
                        .HasColumnType("int");

                    b.Property<int>("HomeGoals")
                        .HasColumnType("int")
                        .HasColumnName("HomeGoals");

                    b.Property<bool>("Live")
                        .HasColumnType("bit")
                        .HasColumnName("Live");

                    b.Property<DateTime>("MatchDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MatchDate");

                    b.Property<string>("MatchPhase")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MatchPhase");

                    b.Property<int?>("RefereeeIDperson")
                        .HasColumnType("int");

                    b.Property<string>("SpecificNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SpecificNumber");

                    b.Property<int?>("TournirMIDtournir")
                        .HasColumnType("int");

                    b.Property<int?>("WinnerIDclub")
                        .HasColumnType("int");

                    b.HasKey("IDmatch");

                    b.HasIndex("Club1IDclub");

                    b.HasIndex("Club2IDclub");

                    b.HasIndex("RefereeeIDperson");

                    b.HasIndex("TournirMIDtournir");

                    b.HasIndex("WinnerIDclub");

                    b.ToTable("TMatch");
                });

            modelBuilder.Entity("Backend.Models.Tournir", b =>
                {
                    b.Property<int>("IDtournir")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDtournir")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("City");

                    b.Property<string>("Form")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Form");

                    b.Property<int>("NumOfTeamsPerGroup")
                        .HasColumnType("int")
                        .HasColumnName("NumOfTeamsPerGroup");

                    b.Property<DateTime>("TournirDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("TournirDate");

                    b.Property<string>("TournirName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TournirName");

                    b.Property<int?>("TournirOrganisatorIDperson")
                        .HasColumnType("int");

                    b.Property<string>("TournirWinner")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TournirWinner");

                    b.Property<int>("WinnersPerGroup")
                        .HasColumnType("int")
                        .HasColumnName("WinnersPerGroup");

                    b.HasKey("IDtournir");

                    b.HasIndex("TournirOrganisatorIDperson");

                    b.ToTable("Tournir");
                });

            modelBuilder.Entity("ClubTournir", b =>
                {
                    b.Property<int>("ClubsIDclub")
                        .HasColumnType("int");

                    b.Property<int>("TournirsPlayingInIDtournir")
                        .HasColumnType("int");

                    b.HasKey("ClubsIDclub", "TournirsPlayingInIDtournir");

                    b.HasIndex("TournirsPlayingInIDtournir");

                    b.ToTable("ClubTournir");
                });

            modelBuilder.Entity("Backend.Models.Organisator", b =>
                {
                    b.HasBaseType("Backend.Models.Person");

                    b.Property<string>("Pass")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Pass");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Username");

                    b.ToTable("Organisator");
                });

            modelBuilder.Entity("Backend.Models.Player", b =>
                {
                    b.HasBaseType("Backend.Models.Person");

                    b.Property<bool>("Captain")
                        .HasColumnType("bit")
                        .HasColumnName("Captain");

                    b.Property<int?>("ClubPlayingForIDclub")
                        .HasColumnType("int");

                    b.Property<int>("Num")
                        .HasColumnType("int")
                        .HasColumnName("Num");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Position");

                    b.HasIndex("ClubPlayingForIDclub");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("Backend.Models.Referee", b =>
                {
                    b.HasBaseType("Backend.Models.Person");

                    b.Property<int>("Quality")
                        .HasColumnType("int")
                        .HasColumnName("Quality");

                    b.ToTable("Referee");
                });

            modelBuilder.Entity("Backend.Models.Trainer", b =>
                {
                    b.HasBaseType("Backend.Models.Person");

                    b.ToTable("Trainer");
                });

            modelBuilder.Entity("AdminTournir", b =>
                {
                    b.HasOne("Backend.Models.Admin", null)
                        .WithMany()
                        .HasForeignKey("AdminsIDadmin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.Tournir", null)
                        .WithMany()
                        .HasForeignKey("TournirsIDtournir")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Backend.Models.Admin", b =>
                {
                    b.HasOne("Backend.Models.Organisator", "GiveAccessBy")
                        .WithMany("AdminsCreated")
                        .HasForeignKey("GiveAccessByIDperson");

                    b.Navigation("GiveAccessBy");
                });

            modelBuilder.Entity("Backend.Models.Club", b =>
                {
                    b.HasOne("Backend.Models.Trainer", "Trainer")
                        .WithMany()
                        .HasForeignKey("TrainerIDperson");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Backend.Models.ClubStatistic", b =>
                {
                    b.HasOne("Backend.Models.Club", "ClubStat")
                        .WithMany("EveryClubStatistics")
                        .HasForeignKey("ClubStatIDclub");

                    b.HasOne("Backend.Models.Tournir", "TournirStatC")
                        .WithMany("ClubsStatistics")
                        .HasForeignKey("TournirStatCIDtournir");

                    b.Navigation("ClubStat");

                    b.Navigation("TournirStatC");
                });

            modelBuilder.Entity("Backend.Models.PlayerStatistic", b =>
                {
                    b.HasOne("Backend.Models.Player", "PlayerStat")
                        .WithMany("PlayerStatistics")
                        .HasForeignKey("PlayerStatIDperson");

                    b.HasOne("Backend.Models.Tournir", "TournirStatP")
                        .WithMany("PlayerStatistics")
                        .HasForeignKey("TournirStatPIDtournir");

                    b.Navigation("PlayerStat");

                    b.Navigation("TournirStatP");
                });

            modelBuilder.Entity("Backend.Models.TMatch", b =>
                {
                    b.HasOne("Backend.Models.Club", "Club1")
                        .WithMany()
                        .HasForeignKey("Club1IDclub");

                    b.HasOne("Backend.Models.Club", "Club2")
                        .WithMany()
                        .HasForeignKey("Club2IDclub");

                    b.HasOne("Backend.Models.Referee", "Refereee")
                        .WithMany()
                        .HasForeignKey("RefereeeIDperson");

                    b.HasOne("Backend.Models.Tournir", "TournirM")
                        .WithMany("TMatches")
                        .HasForeignKey("TournirMIDtournir");

                    b.HasOne("Backend.Models.Club", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerIDclub");

                    b.Navigation("Club1");

                    b.Navigation("Club2");

                    b.Navigation("Refereee");

                    b.Navigation("TournirM");

                    b.Navigation("Winner");
                });

            modelBuilder.Entity("Backend.Models.Tournir", b =>
                {
                    b.HasOne("Backend.Models.Organisator", "TournirOrganisator")
                        .WithMany("TournirOrganised")
                        .HasForeignKey("TournirOrganisatorIDperson");

                    b.Navigation("TournirOrganisator");
                });

            modelBuilder.Entity("ClubTournir", b =>
                {
                    b.HasOne("Backend.Models.Club", null)
                        .WithMany()
                        .HasForeignKey("ClubsIDclub")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.Tournir", null)
                        .WithMany()
                        .HasForeignKey("TournirsPlayingInIDtournir")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Backend.Models.Organisator", b =>
                {
                    b.HasOne("Backend.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("Backend.Models.Organisator", "IDperson")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Backend.Models.Player", b =>
                {
                    b.HasOne("Backend.Models.Club", "ClubPlayingFor")
                        .WithMany("Players")
                        .HasForeignKey("ClubPlayingForIDclub");

                    b.HasOne("Backend.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("Backend.Models.Player", "IDperson")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("ClubPlayingFor");
                });

            modelBuilder.Entity("Backend.Models.Referee", b =>
                {
                    b.HasOne("Backend.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("Backend.Models.Referee", "IDperson")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Backend.Models.Trainer", b =>
                {
                    b.HasOne("Backend.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("Backend.Models.Trainer", "IDperson")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Backend.Models.Club", b =>
                {
                    b.Navigation("EveryClubStatistics");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("Backend.Models.Tournir", b =>
                {
                    b.Navigation("ClubsStatistics");

                    b.Navigation("PlayerStatistics");

                    b.Navigation("TMatches");
                });

            modelBuilder.Entity("Backend.Models.Organisator", b =>
                {
                    b.Navigation("AdminsCreated");

                    b.Navigation("TournirOrganised");
                });

            modelBuilder.Entity("Backend.Models.Player", b =>
                {
                    b.Navigation("PlayerStatistics");
                });
#pragma warning restore 612, 618
        }
    }
}
