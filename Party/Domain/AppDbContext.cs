﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JustDo.Party.Domain
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppLogRequest> AppLogRequest { get; set; }
        public virtual DbSet<AppLogTable> AppLogTable { get; set; }
        public virtual DbSet<AppPermission> AppPermission { get; set; }
        public virtual DbSet<AppRole> AppRole { get; set; }
        public virtual DbSet<AppRolePermission> AppRolePermission { get; set; }
        public virtual DbSet<AppRoleUser> AppRoleUser { get; set; }
        public virtual DbSet<AppUser> AppUser { get; set; }
        public virtual DbSet<KeyCode> KeyCode { get; set; }
        public virtual DbSet<KeySystem> KeySystem { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<PartyDate> PartyDate { get; set; }
        public virtual DbSet<PartyMsg> PartyMsg { get; set; }
        public virtual DbSet<PartyPhoto> PartyPhoto { get; set; }
        public virtual DbSet<PartySample> PartySample { get; set; }
        public virtual DbSet<PartyUser> PartyUser { get; set; }
        public virtual DbSet<PartyVote> PartyVote { get; set; }
        public virtual DbSet<ViewPartyUserMatchUser> ViewPartyUserMatchUser { get; set; }
        public virtual DbSet<ViewPartyUserMatches> ViewPartyUserMatches { get; set; }
        public virtual DbSet<ViewPartyUserSumAll> ViewPartyUserSumAll { get; set; }
        public virtual DbSet<ViewPartyUserSumBoy> ViewPartyUserSumBoy { get; set; }
        public virtual DbSet<ViewPartyUserSumGirl> ViewPartyUserSumGirl { get; set; }
        public virtual DbSet<ViewPartyUserSummary> ViewPartyUserSummary { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=(local)\\SqlExpress;database=party2021;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppLogRequest>(entity =>
            {
                entity.Property(e => e.Destination).HasMaxLength(250);

                entity.Property(e => e.Method).HasMaxLength(250);

                entity.Property(e => e.QueryString).HasMaxLength(250);

                entity.Property(e => e.Refer).HasMaxLength(250);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<AppLogTable>(entity =>
            {
                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AppPermission>(entity =>
            {
                entity.HasKey(e => e.PermissionId)
                    .HasName("AppPermission_Key");

                entity.HasIndex(e => new { e.ControllerName, e.ActionName })
                    .HasName("AppPermission_Index1")
                    .IsUnique();

                entity.HasIndex(e => new { e.HttpApi, e.HttpMethod })
                    .HasName("AppPermission_Index2")
                    .IsUnique();

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AreaName).HasMaxLength(50);

                entity.Property(e => e.ControllerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ExternalUrl).HasMaxLength(250);

                entity.Property(e => e.HttpApi)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.HttpMethod)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PermissionDesc).HasMaxLength(250);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<AppRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("AppRole_Key");

                entity.HasIndex(e => e.RoleName)
                    .HasName("AppRole_Index1")
                    .IsUnique();

                entity.Property(e => e.Note1).HasMaxLength(100);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<AppRolePermission>(entity =>
            {
                entity.HasIndex(e => new { e.RoleId, e.PermissionId })
                    .HasName("AppRolePermission_Index1")
                    .IsUnique();

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.AppRolePermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AppRolePermission_AppPermission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AppRolePermission)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AppRolePermission_AppRole");
            });

            modelBuilder.Entity<AppRoleUser>(entity =>
            {
                entity.HasIndex(e => new { e.RoleId, e.UserId })
                    .HasName("AppRoleUser_Index1")
                    .IsUnique();

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AppRoleUser)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AppRoleUser_AppRole");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppRoleUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AppRoleUser_AppUser");
            });

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("AppUser_Key");

                entity.HasIndex(e => e.Email)
                    .HasName("AppUser_Index1")
                    .IsUnique();

                entity.HasIndex(e => e.Phone)
                    .HasName("AppUser_Index2")
                    .IsUnique();

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.BankNumber6).HasMaxLength(50);

                entity.Property(e => e.Blood).HasMaxLength(2);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmailCode).HasMaxLength(250);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdPhoto11Url).HasMaxLength(250);

                entity.Property(e => e.IdPhoto12Url).HasMaxLength(250);

                entity.Property(e => e.Introduction).HasMaxLength(2000);

                entity.Property(e => e.IsOffUser).HasDefaultValueSql("((1))");

                entity.Property(e => e.JobPhotoUrl).HasMaxLength(250);

                entity.Property(e => e.JobType).HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LikeCondition).HasMaxLength(2000);

                entity.Property(e => e.LoginDate).HasColumnType("datetime");

                entity.Property(e => e.LoginLastDate).HasColumnType("datetime");

                entity.Property(e => e.MainPhotoUrl).HasMaxLength(250);

                entity.Property(e => e.PasswordHash).HasMaxLength(2000);

                entity.Property(e => e.PasswordSalt).HasMaxLength(2000);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneCode).HasMaxLength(50);

                entity.Property(e => e.Religion).HasMaxLength(50);

                entity.Property(e => e.School).HasMaxLength(50);

                entity.Property(e => e.SchoolUrl).HasMaxLength(250);

                entity.Property(e => e.Star).HasMaxLength(50);

                entity.Property(e => e.Subjects).HasMaxLength(50);

                entity.Property(e => e.UserData).HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<KeyCode>(entity =>
            {
                entity.HasIndex(e => new { e.CodeGroup, e.CodeValue })
                    .HasName("KeyCode_Index1")
                    .IsUnique();

                entity.Property(e => e.CodeGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodeLabel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodeValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<KeySystem>(entity =>
            {
                entity.HasIndex(e => e.SystemKey)
                    .HasName("KeySystem_Index1")
                    .IsUnique();

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.SystemGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SystemKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SystemLabel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SystemValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.HasIndex(e => new { e.RecipientId, e.SenderId })
                    .HasName("messages_index2");

                entity.HasIndex(e => new { e.SenderId, e.RecipientId })
                    .HasName("messages_index1");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ReadDate).HasColumnType("datetime");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.WriteIp).HasMaxLength(32);

                entity.Property(e => e.WriteTime).HasColumnType("datetime");

                entity.Property(e => e.WriteUser).HasMaxLength(32);

                entity.HasOne(d => d.Recipient)
                    .WithMany(p => p.MessagesRecipient)
                    .HasForeignKey(d => d.RecipientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Messages_Recipient");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.MessagesSender)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Message_Sender");
            });

            modelBuilder.Entity<PartyDate>(entity =>
            {
                entity.HasKey(e => e.PartyId)
                    .HasName("PartyDate_Key");

                entity.HasIndex(e => e.PartyDate1)
                    .HasName("PartyDate_index1");

                entity.Property(e => e.AddressNo).HasMaxLength(120);

                entity.Property(e => e.BeginTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.BusNote).HasMaxLength(250);

                entity.Property(e => e.EarlyDate).HasColumnType("date");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.PartyDate1)
                    .HasColumnName("PartyDate")
                    .HasColumnType("date");

                entity.Property(e => e.PartyName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PictureUrl).HasMaxLength(128);

                entity.Property(e => e.Restaurant).HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(32);

                entity.Property(e => e.WriteTime).HasColumnType("datetime");

                entity.Property(e => e.WriteUser).HasMaxLength(32);
            });

            modelBuilder.Entity<PartyMsg>(entity =>
            {
                entity.HasIndex(e => new { e.PartyId, e.UserId })
                    .HasName("PartyMsg_index1");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasColumnName("contents")
                    .HasMaxLength(2000);

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime).HasColumnType("datetime");

                entity.Property(e => e.WriteUser).HasMaxLength(50);
            });

            modelBuilder.Entity<PartyPhoto>(entity =>
            {
                entity.HasIndex(e => new { e.PartyId, e.Id })
                    .HasName("PartyPhoto_index1");

                entity.Property(e => e.Descriptions).HasMaxLength(250);

                entity.Property(e => e.PhotoUrl).HasMaxLength(250);

                entity.Property(e => e.PublicId).HasMaxLength(250);

                entity.Property(e => e.WriteIp).HasMaxLength(32);

                entity.Property(e => e.WriteTime).HasColumnType("datetime");

                entity.Property(e => e.WriteUser).HasMaxLength(32);

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.PartyPhoto)
                    .HasForeignKey(d => d.PartyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Photo_Party");
            });

            modelBuilder.Entity<PartySample>(entity =>
            {
                entity.HasKey(e => e.PartyName)
                    .HasName("PartySample_Key");

                entity.Property(e => e.PartyName).HasMaxLength(128);

                entity.Property(e => e.AddressNo).HasMaxLength(120);

                entity.Property(e => e.BeginTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.BusNote).HasMaxLength(250);

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.PictureUrl).HasMaxLength(128);

                entity.Property(e => e.Restaurant).HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(32);

                entity.Property(e => e.WriteTime).HasColumnType("datetime");

                entity.Property(e => e.WriteUser).HasMaxLength(32);
            });

            modelBuilder.Entity<PartyUser>(entity =>
            {
                entity.HasIndex(e => new { e.PartyId, e.UserId })
                    .HasName("PartyUser_index1")
                    .IsUnique();

                entity.HasIndex(e => new { e.UserId, e.PartyId })
                    .HasName("PartyUser_index2")
                    .IsUnique();

                entity.Property(e => e.ApplyDate).HasColumnType("datetime");

                entity.Property(e => e.BankDate).HasMaxLength(32);

                entity.Property(e => e.BankName).HasMaxLength(32);

                entity.Property(e => e.BankNumber6).HasMaxLength(32);

                entity.Property(e => e.FriendsName).HasMaxLength(32);

                entity.Property(e => e.Notes).HasMaxLength(128);

                entity.Property(e => e.RetrunNote).HasMaxLength(64);

                entity.Property(e => e.WriteIp).HasMaxLength(32);

                entity.Property(e => e.WriteTime).HasColumnType("datetime");

                entity.Property(e => e.WriteUser).HasMaxLength(32);

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.PartyUser)
                    .HasForeignKey(d => d.PartyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PartyUser_PartyDate");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PartyUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PartyUser_AppUser");
            });

            modelBuilder.Entity<PartyVote>(entity =>
            {
                entity.HasKey(e => new { e.PartyId, e.VoteId, e.LikerId })
                    .HasName("PartyVote_Key");

                entity.Property(e => e.VoteDate).HasColumnType("datetime");

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime).HasColumnType("datetime");

                entity.Property(e => e.WriteUser).HasMaxLength(50);

                entity.HasOne(d => d.Liker)
                    .WithMany(p => p.PartyVoteLiker)
                    .HasForeignKey(d => d.LikerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PartyVote_LikerId");

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.PartyVote)
                    .HasForeignKey(d => d.PartyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PartyVote_PartyDate");

                entity.HasOne(d => d.Vote)
                    .WithMany(p => p.PartyVoteVote)
                    .HasForeignKey(d => d.VoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PartyVote_VoteId");
            });

            modelBuilder.Entity<ViewPartyUserMatchUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPartyUserMatchUser");
            });

            modelBuilder.Entity<ViewPartyUserMatches>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPartyUserMatches");
            });

            modelBuilder.Entity<ViewPartyUserSumAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPartyUserSumAll");
            });

            modelBuilder.Entity<ViewPartyUserSumBoy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPartyUserSumBoy");
            });

            modelBuilder.Entity<ViewPartyUserSumGirl>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPartyUserSumGirl");
            });

            modelBuilder.Entity<ViewPartyUserSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPartyUserSummary");

                entity.Property(e => e.PartyDate).HasColumnType("date");

                entity.Property(e => e.PartyName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Restaurant).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
