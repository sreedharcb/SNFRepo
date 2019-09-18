using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AuthAPI.Models
{
    public partial class SNI_DIGITAL_PACKAGINGContext : DbContext
    {
        public SNI_DIGITAL_PACKAGINGContext()
        {
        }

        public SNI_DIGITAL_PACKAGINGContext(DbContextOptions<SNI_DIGITAL_PACKAGINGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<Buldings> Buldings { get; set; }
        public virtual DbSet<HeatSealTestLog> HeatSealTestLog { get; set; }
        public virtual DbSet<LidPouch> LidPouch { get; set; }
        public virtual DbSet<PcfReasonsForHold> PcfReasonsForHold { get; set; }
        public virtual DbSet<PcfReassignTypes> PcfReassignTypes { get; set; }
        public virtual DbSet<PcfStatusTypes> PcfStatusTypes { get; set; }
        public virtual DbSet<PcfSubReasonsForHold> PcfSubReasonsForHold { get; set; }
        public virtual DbSet<ProductWorkOrder> ProductWorkOrder { get; set; }
        public virtual DbSet<ReasonsforHold> ReasonsforHold { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<WorkStations> WorkStations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning        To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=INHYDNXGSRV03\\SQLSERVER2017;Database=SNI_DIGITAL_PACKAGING;User ID=SNIuser;Password=Yash@123$");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asset>(entity =>
            {
                entity.HasKey(e => e.AssetId);

                entity.Property(e => e.AssetId)
                    .HasColumnName("Asset_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BuildingId).HasColumnName("Building_ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.Asset)
                    .HasForeignKey(d => d.BuildingId)
                    .HasConstraintName("FK__Asset__Building___59063A47");
            });

            modelBuilder.Entity<Buldings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BuildingName)
                    .HasColumnName("Building_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Wsid).HasColumnName("WSID");

                entity.HasOne(d => d.Ws)
                    .WithMany(p => p.Buldings)
                    .HasForeignKey(d => d.Wsid)
                    .HasConstraintName("FK__Buldings__WSID__5629CD9C");
            });

            modelBuilder.Entity<HeatSealTestLog>(entity =>
            {
                entity.ToTable("Heat_Seal_Test_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.SuperWisorInitials)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LidPouch>(entity =>
            {
                entity.HasKey(e => e.LidPouchNumber);

                entity.ToTable("Lid_Pouch");

                entity.Property(e => e.LidPouchNumber)
                    .HasColumnName("Lid/Pouch Number")
                    .ValueGeneratedNever();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SealerPressure).HasColumnName("Sealer_Pressure");

                entity.Property(e => e.SealerTemp).HasColumnName("Sealer_Temp");

                entity.Property(e => e.SealerTime).HasColumnName("Sealer_Time");
            });

            modelBuilder.Entity<PcfReasonsForHold>(entity =>
            {
                entity.ToTable("PCF_ReasonsForHold");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PcfReassignTypes>(entity =>
            {
                entity.ToTable("PCF_Reassign_Types");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PcfStatusTypes>(entity =>
            {
                entity.ToTable("PCF_Status_Types");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PcfSubReasonsForHold>(entity =>
            {
                entity.ToTable("PCF_SubReasonsForHold");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonId).HasColumnName("ReasonID");

                entity.HasOne(d => d.Reason)
                    .WithMany(p => p.PcfSubReasonsForHold)
                    .HasForeignKey(d => d.ReasonId)
                    .HasConstraintName("FK__PCF_SubRe__Reaso__5FB337D6");
            });

            modelBuilder.Entity<ProductWorkOrder>(entity =>
            {
                entity.HasKey(e => e.OrderNumber);

                entity.Property(e => e.OrderNumber).ValueGeneratedNever();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ReasonsforHold>(entity =>
            {
                entity.HasKey(e => e.ReasonId);

                entity.Property(e => e.ReasonId)
                    .HasColumnName("Reason_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Userlogin)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Role)
                    .HasConstraintName("FK__Users__Role__534D60F1");
            });

            modelBuilder.Entity<WorkStations>(entity =>
            {
                entity.HasKey(e => e.Wsid);

                entity.Property(e => e.Wsid).HasColumnName("WSID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.StationType)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
