using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProductivityTools.ReleaseManagment.EF
{
    public partial class EcoVadisTMContext : DbContext
    {
        public EcoVadisTMContext()
        {
        }

        public EcoVadisTMContext(DbContextOptions<EcoVadisTMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DbUp> DbUp { get; set; }
        public virtual DbSet<DictValue> DictValue { get; set; }
        public virtual DbSet<Dictionary> Dictionary { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\sql2017;Initial Catalog=EcoVadisTM;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<DbUp>(entity =>
            {
                entity.ToTable("dbUp", "adm");

                entity.Property(e => e.Applied).HasColumnType("datetime");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DictValue>(entity =>
            {
                entity.ToTable("DictValue", "common");

                entity.Property(e => e.DictValueId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValueEn)
                    .IsRequired()
                    .HasColumnName("ValueEN")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValuePl)
                    .IsRequired()
                    .HasColumnName("ValuePL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dictionary)
                    .WithMany(p => p.DictValue)
                    .HasForeignKey(d => d.DictionaryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DictValue_Dictionary");
            });

            modelBuilder.Entity<Dictionary>(entity =>
            {
                entity.ToTable("Dictionary", "common");

                entity.Property(e => e.DictionaryId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule", "general");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduleTypeDvid).HasColumnName("ScheduleTypeDVId");

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.HasOne(d => d.ParentSchedule)
                    .WithMany(p => p.InverseParentSchedule)
                    .HasForeignKey(d => d.ParentScheduleId)
                    .HasConstraintName("FK_Schedule_Schedule");
            });
        }
    }
}
