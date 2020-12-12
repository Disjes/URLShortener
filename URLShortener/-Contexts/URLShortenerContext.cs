using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using URLShortener.Models;

#nullable disable

namespace URLShortener.Contexts
{
    public partial class URLShortenerContext : DbContext
    {
        public URLShortenerContext()
        {
        }

        public URLShortenerContext(DbContextOptions<URLShortenerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Url> Urls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=URLShortener");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Url>(entity =>
            {
                entity.HasKey(e => e.UrlCode);

                entity.ToTable("urls");

                entity.Property(e => e.UrlCode)
                    .HasColumnName("url_code");

                entity.Property(e => e.UrlOriginal)
                    .IsUnicode(false)
                    .HasColumnName("url_original");

                entity.Property(e => e.UrlShortened)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("url_shortened");

                entity.Property(e => e.UrlTimesVisited).HasColumnName("url_times_visited");

                entity.Property(e => e.UrlTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("url_title");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
