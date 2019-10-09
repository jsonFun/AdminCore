using System;
using AdminCore_Comm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AdminCore_Entity.Models
{
    public partial class AdminCoreContext : DbContext
    {
        public AdminCoreContext()
        {
        }

        public AdminCoreContext(DbContextOptions<AdminCoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChildrenMenu> ChildrenMenu { get; set; }
        public virtual DbSet<MainMenu> MainMenu { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Scaffold-DbContext "Data Source=.;Initial Catalog=AdminCore;Persist Security Info=True;User ID=sa;Password=8023" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force
            if (!optionsBuilder.IsConfigured)
            {
              optionsBuilder.UseSqlServer(SysConfig.SqlServerConfig);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<ChildrenMenu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTime).HasMaxLength(50);

                entity.Property(e => e.CreateUser).HasMaxLength(12);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasMaxLength(50);

                entity.Property(e => e.UpdateUser).HasMaxLength(12);
            });

            modelBuilder.Entity<MainMenu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTime).HasMaxLength(50);

                entity.Property(e => e.CreateUser).HasMaxLength(12);

                entity.Property(e => e.MenuName).HasMaxLength(30);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasMaxLength(50);

                entity.Property(e => e.UpdateUser).HasMaxLength(12);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTime).HasMaxLength(50);

                entity.Property(e => e.CreateUser).HasMaxLength(12);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.LoginName).HasMaxLength(12);

                entity.Property(e => e.Name).HasMaxLength(10);

                entity.Property(e => e.Password).HasMaxLength(20);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Qq)
                    .HasColumnName("QQ")
                    .HasMaxLength(20);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasMaxLength(50);

                entity.Property(e => e.UpdateUser).HasMaxLength(12);

                entity.Property(e => e.WeiXin).HasMaxLength(100);
            });
        }
    }
}
