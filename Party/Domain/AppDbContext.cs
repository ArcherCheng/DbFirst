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
        public virtual DbSet<PartyChat> PartyChat { get; set; }
        public virtual DbSet<PartyData> PartyData { get; set; }
        public virtual DbSet<PartyPhoto> PartyPhoto { get; set; }
        public virtual DbSet<PartySuggest> PartySuggest { get; set; }
        public virtual DbSet<PartyUser> PartyUser { get; set; }
        public virtual DbSet<PartyVote> PartyVote { get; set; }
        public virtual DbSet<UserChat> UserChat { get; set; }
        public virtual DbSet<UserCondition> UserCondition { get; set; }
        public virtual DbSet<UserData> UserData { get; set; }
        public virtual DbSet<UserMatch> UserMatch { get; set; }
        public virtual DbSet<UserPhoto> UserPhoto { get; set; }
        public virtual DbSet<ViewPartyChatSum> ViewPartyChatSum { get; set; }
        public virtual DbSet<ViewPartyMatchUser> ViewPartyMatchUser { get; set; }
        public virtual DbSet<ViewPartyMatches> ViewPartyMatches { get; set; }
        public virtual DbSet<ViewPartySumAll> ViewPartySumAll { get; set; }
        public virtual DbSet<ViewPartySumBoy> ViewPartySumBoy { get; set; }
        public virtual DbSet<ViewPartySumGirl> ViewPartySumGirl { get; set; }
        public virtual DbSet<ViewPartySummary> ViewPartySummary { get; set; }
        public virtual DbSet<ViewPartyVoteCount> ViewPartyVoteCount { get; set; }
        public virtual DbSet<ViewPartyVoteSum> ViewPartyVoteSum { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=(local)\\SqlExpress;database=partyModel;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppLogRequest>(entity =>
            {
                entity.Property(e => e.Destination).HasMaxLength(500);

                entity.Property(e => e.Method).HasMaxLength(500);

                entity.Property(e => e.QueryString).HasMaxLength(500);

                entity.Property(e => e.Refer).HasMaxLength(500);
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
            });

            modelBuilder.Entity<AppRolePermission>(entity =>
            {
                entity.HasIndex(e => new { e.RoleId, e.PermissionId })
                    .HasName("AppRolePermission_Index1")
                    .IsUnique();

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
                    .HasName("AppUser_Index2")
                    .IsUnique();

                entity.HasIndex(e => e.Phone)
                    .HasName("AppUser_Index1")
                    .IsUnique();

                entity.Property(e => e.Birthday).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsOnOff)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LoginDate).HasColumnType("datetime");

                entity.Property(e => e.LoginLastDate).HasColumnType("datetime");

                entity.Property(e => e.MainPhoto).HasMaxLength(250);

                entity.Property(e => e.PasswordHash).HasMaxLength(2000);

                entity.Property(e => e.PasswordSalt).HasMaxLength(2000);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserData).HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserRole).HasMaxLength(50);
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
            });

            modelBuilder.Entity<PartyChat>(entity =>
            {
                entity.HasIndex(e => new { e.PartyId, e.RecipientId })
                    .HasName("PartyChat_index2");

                entity.HasIndex(e => new { e.PartyId, e.SenderId })
                    .HasName("PartyChat_index1");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ReadDate).HasColumnType("datetime");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.PartyChat)
                    .HasForeignKey(d => d.PartyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PartyChat_PartyData");

                entity.HasOne(d => d.Recipient)
                    .WithMany(p => p.PartyChatRecipient)
                    .HasForeignKey(d => d.RecipientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PartyChat_Recipient");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.PartyChatSender)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PartyChat_Sender");
            });

            modelBuilder.Entity<PartyData>(entity =>
            {
                entity.HasKey(e => e.PartyId)
                    .HasName("PartyData_PKey");

                entity.HasIndex(e => e.PartyDate)
                    .HasName("PartyData_index1");

                entity.Property(e => e.AddressNo).HasMaxLength(120);

                entity.Property(e => e.BeginTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.BusNote).HasMaxLength(250);

                entity.Property(e => e.EarlyDate).HasColumnType("date");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.IsOnOff)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.PartyDate).HasColumnType("datetime");

                entity.Property(e => e.PartyName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PictureUrl).HasMaxLength(128);

                entity.Property(e => e.Restaurant).HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PartyPhoto>(entity =>
            {
                entity.HasIndex(e => new { e.PartyId, e.Id })
                    .HasName("PartyPhoto_index1");

                entity.Property(e => e.Descriptions).HasMaxLength(250);

                entity.Property(e => e.PhotoUrl).HasMaxLength(250);

                entity.Property(e => e.PublicId).HasMaxLength(250);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.PartyPhoto)
                    .HasForeignKey(d => d.PartyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PartyPhoto_PartyData");
            });

            modelBuilder.Entity<PartySuggest>(entity =>
            {
                entity.HasIndex(e => new { e.PartyId, e.UserId })
                    .HasName("PartySuggest_index1");

                entity.Property(e => e.Suggestion)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.PartySuggest)
                    .HasForeignKey(d => d.PartyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PartySuggest_PartyData");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PartySuggest)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PartySuggest_UserData");
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

                entity.Property(e => e.BankDate).HasMaxLength(50);

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.BankNote).HasMaxLength(50);

                entity.Property(e => e.BankNumber6).HasMaxLength(50);

                entity.Property(e => e.FriendsName).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.PartyUser)
                    .HasForeignKey(d => d.PartyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PartyUser_PartyData");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PartyUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PartyUser_UserData");
            });

            modelBuilder.Entity<PartyVote>(entity =>
            {
                entity.HasIndex(e => new { e.PartyId, e.VoteId, e.LikerId })
                    .HasName("PartyVote_index1")
                    .IsUnique();

                entity.Property(e => e.VoteDate).HasColumnType("datetime");

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Liker)
                    .WithMany(p => p.PartyVoteLiker)
                    .HasForeignKey(d => d.LikerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PartyVote_LikerId");

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.PartyVote)
                    .HasForeignKey(d => d.PartyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PartyVote_PartyData");

                entity.HasOne(d => d.Vote)
                    .WithMany(p => p.PartyVoteVote)
                    .HasForeignKey(d => d.VoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PartyVote_VoteId");
            });

            modelBuilder.Entity<UserChat>(entity =>
            {
                entity.HasIndex(e => new { e.RecipientId, e.SenderId })
                    .HasName("UserChat_index2");

                entity.HasIndex(e => new { e.SenderId, e.RecipientId })
                    .HasName("UserChat_index1");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ReadDate).HasColumnType("datetime");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Recipient)
                    .WithMany(p => p.UserChatRecipient)
                    .HasForeignKey(d => d.RecipientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UserChat_Recipient");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.UserChatSender)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UserChat_Sender");
            });

            modelBuilder.Entity<UserCondition>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("UserCondition_Key");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.BloodInclude).HasMaxLength(50);

                entity.Property(e => e.CityInclude).HasMaxLength(250);

                entity.Property(e => e.JobTypeInclude).HasMaxLength(250);

                entity.Property(e => e.ReligionInclude).HasMaxLength(250);

                entity.Property(e => e.StarInclude).HasMaxLength(250);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserCondition)
                    .HasForeignKey<UserCondition>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UserCondition_UserData");
            });

            modelBuilder.Entity<UserData>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("UserData_PKey");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Activities).HasMaxLength(50);

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.BankNumber6).HasMaxLength(50);

                entity.Property(e => e.Blood).HasMaxLength(2);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdPhoto11Url).HasMaxLength(250);

                entity.Property(e => e.IdPhoto12Url).HasMaxLength(250);

                entity.Property(e => e.Interest).HasMaxLength(50);

                entity.Property(e => e.Introduction).HasMaxLength(2000);

                entity.Property(e => e.IsOnOffData)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsOnOffPhoto)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JobPhotoUrl).HasMaxLength(250);

                entity.Property(e => e.JobType).HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LikeCondition).HasMaxLength(2000);

                entity.Property(e => e.MainPhotoUrl).HasMaxLength(250);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Personality).HasMaxLength(50);

                entity.Property(e => e.Religion).HasMaxLength(50);

                entity.Property(e => e.School).HasMaxLength(50);

                entity.Property(e => e.SchoolUrl).HasMaxLength(250);

                entity.Property(e => e.Star).HasMaxLength(50);

                entity.Property(e => e.Subjects).HasMaxLength(50);

                entity.Property(e => e.Technique).HasMaxLength(50);

                entity.Property(e => e.WorkType).HasMaxLength(50);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UserMatch>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.MatchId })
                    .HasName("UserMatch_Index1")
                    .IsUnique();

                entity.Property(e => e.WriteIp).HasMaxLength(32);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Match)
                    .WithMany(p => p.UserMatch)
                    .HasForeignKey(d => d.MatchId)
                    .HasConstraintName("UserMatch_MatchUser");
            });

            modelBuilder.Entity<UserPhoto>(entity =>
            {
                entity.Property(e => e.Descriptions).HasMaxLength(250);

                entity.Property(e => e.PhotoUrl).HasMaxLength(250);

                entity.Property(e => e.PublicId).HasMaxLength(250);

                entity.Property(e => e.WriteIp).HasMaxLength(50);

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPhoto)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UserPhoto_UserData");
            });

            modelBuilder.Entity<ViewPartyChatSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPartyChatSum");
            });

            modelBuilder.Entity<ViewPartyMatchUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPartyMatchUser");
            });

            modelBuilder.Entity<ViewPartyMatches>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPartyMatches");
            });

            modelBuilder.Entity<ViewPartySumAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPartySumAll");
            });

            modelBuilder.Entity<ViewPartySumBoy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPartySumBoy");
            });

            modelBuilder.Entity<ViewPartySumGirl>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPartySumGirl");
            });

            modelBuilder.Entity<ViewPartySummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPartySummary");

                entity.Property(e => e.PartyDate).HasColumnType("datetime");

                entity.Property(e => e.PartyName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Restaurant).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewPartyVoteCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPartyVoteCount");

                entity.Property(e => e.Likerid).HasColumnName("likerid");

                entity.Property(e => e.PartyId).HasColumnName("partyId");

                entity.Property(e => e.Sex).HasColumnName("sex");
            });

            modelBuilder.Entity<ViewPartyVoteSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPartyVoteSum");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
