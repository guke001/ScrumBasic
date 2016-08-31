﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ScrumBasic.Data;

namespace ScrumBasic.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160829073250_add_project_controller")]
    partial class add_project_controller
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ScrumBasic.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ScrumBasic.Models.Project", b =>
                {
                    b.Property<string>("ID")
                        .HasAnnotation("MaxLength", 32);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreatorId");

                    b.Property<string>("ModifierId");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("ID");

                    b.HasIndex("CreatorId");

                    b.HasIndex("ModifierId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("ScrumBasic.Models.StoryStatus", b =>
                {
                    b.Property<string>("Code");

                    b.Property<string>("ButtonDisplayName");

                    b.Property<int>("Order");

                    b.Property<string>("Text");

                    b.HasKey("Code");

                    b.ToTable("DM_StoryStatus");
                });

            modelBuilder.Entity("ScrumBasic.Models.UserStory", b =>
                {
                    b.Property<string>("ID")
                        .HasAnnotation("MaxLength", 32);

                    b.Property<string>("AssignToId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreatorId");

                    b.Property<int>("ItemTypeCode");

                    b.Property<string>("ListID");

                    b.Property<int>("Order");

                    b.Property<int>("Point");

                    b.Property<string>("ProjectID");

                    b.Property<string>("StatusCode");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("AssignToId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("ProjectID");

                    b.ToTable("UserStories");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ScrumBasic.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ScrumBasic.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ScrumBasic.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ScrumBasic.Models.Project", b =>
                {
                    b.HasOne("ScrumBasic.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("ScrumBasic.Models.ApplicationUser", "Modifier")
                        .WithMany()
                        .HasForeignKey("ModifierId");
                });

            modelBuilder.Entity("ScrumBasic.Models.UserStory", b =>
                {
                    b.HasOne("ScrumBasic.Models.ApplicationUser", "AssignTo")
                        .WithMany()
                        .HasForeignKey("AssignToId");

                    b.HasOne("ScrumBasic.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("ScrumBasic.Models.Project", "Project")
                        .WithMany("Stories")
                        .HasForeignKey("ProjectID");
                });
        }
    }
}