using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = pa1.Models.Type;
using pa1.Models;
using System.IdentityModel.Metadata;


namespace pa1.DBContext
{
    public partial class pa1Context : DbContext
    {
        public pa1Context()
        {
        }
        public pa1Context(DbContextOptions<pa1Context> options) : base(options)
        {
        }
        public virtual DbSet<Perfume> Perfumes { get; set; } = null;
        public virtual DbSet<Role> Roles { get; set; } = null;
        public virtual DbSet<Type> Types { get; set; } = null;
        public virtual DbSet<User> Users { get; set; } = null;

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entity =>
              {
                  entity.HasKey(e => e.IDRole);

                  entity.Property(e => e.IDRole)
                  .ValueGeneratedNever()
                  .HasColumnName("ID_Role");

                  entity.Property(e => e.NameRole)
                  .HasMaxLength(50)
                  .IsUnicode(false)
                  .HasColumnName("Name_Role");
              });
            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("Type");

                entity.Property(e => e.ID)
                .HasMaxLength(50)
                .IsUnicode(false);

                entity.Property(e => e.Name)
                .HasMaxLength(100);
            });
            modelBuilder.Entity<User>(entity => {
                entity.HasKey(e => e.Username);

                entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);

                entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);

                entity.Property(e => e.RoleID).HasColumnName("ID_Role");

                entity.HasOne(d => d.Role)
                .WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Role");
            });
            //modelBuilder.Entity<Perfume>(entity =>
            //{
            //    entity.ToTable("Perfume");

            //    entity.Property(e => e.ID)
            //    .HasMaxLength(50)
            //    .IsUnicode(false);

            //    entity.Property(e => e.Name)
            //    .HasMaxLength(100)
            //    .IsUnicode(false);

            //    entity.Property(e => e.Price).HasColumnType("money");

                
            //});

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
