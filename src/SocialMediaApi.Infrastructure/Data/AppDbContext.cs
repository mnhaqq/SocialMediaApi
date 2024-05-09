
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SocialMediaApi.Core.Entities;

namespace SocialMediaApi.Infrastructure.Data;
public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Following> Followings { get; set; }

    public virtual DbSet<Hashtag> Hashtags { get; set; }

    public virtual DbSet<Like> Likes { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("comments_pkey");

            entity.ToTable("comments");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Postid).HasColumnName("postid");
            entity.Property(e => e.Timecreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.Post).WithMany(p => p.Comments)
                .HasForeignKey(d => d.Postid)
                .HasConstraintName("comments_postid_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.Comments)
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("comments_userid_fkey");
        });

        modelBuilder.Entity<Following>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("followings_pkey");

            entity.ToTable("followings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Followinguserid).HasColumnName("followinguserid");
            entity.Property(e => e.Timecreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.Followinguser).WithMany(p => p.FollowingFollowingusers)
                .HasForeignKey(d => d.Followinguserid)
                .HasConstraintName("followings_followinguserid_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.FollowingUsers)
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("followings_userid_fkey");
        });

        modelBuilder.Entity<Hashtag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hashtags_pkey");

            entity.ToTable("hashtags");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content)
                .HasMaxLength(255)
                .HasColumnName("content");
            entity.Property(e => e.Postid).HasColumnName("postid");
            entity.Property(e => e.Timecreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timecreated");

            entity.HasOne(d => d.Post).WithMany(p => p.Hashtags)
                .HasForeignKey(d => d.Postid)
                .HasConstraintName("hashtags_postid_fkey");
        });

        modelBuilder.Entity<Like>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("likes_pkey");

            entity.ToTable("likes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Postid).HasColumnName("postid");
            entity.Property(e => e.Timecreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.Post).WithMany(p => p.Likes)
                .HasForeignKey(d => d.Postid)
                .HasConstraintName("likes_postid_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.Likes)
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("likes_userid_fkey");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("posts_pkey");

            entity.ToTable("posts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Hashtag)
                .HasMaxLength(255)
                .HasColumnName("hashtag");
            entity.Property(e => e.Timecreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.User).WithMany(p => p.Posts)
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("posts_userid_fkey");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bio).HasColumnName("bio");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Profilepic).HasColumnName("profilepic");
            entity.Property(e => e.Timecreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timecreated");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
