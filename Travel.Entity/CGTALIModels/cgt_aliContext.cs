using Microsoft.EntityFrameworkCore;
using QiShiShe.DDD.Config;

namespace QiShiShe.Entity.CGTALIModels {
    public partial class cgt_aliContext : DbContext {
        public virtual DbSet<AliEnterpriseOrder> AliEnterpriseOrder { get; set; }
        public virtual DbSet<TravelBatch> TravelBatch { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer(JsonConfig.JsonRead("cgtAliConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<AliEnterpriseOrder>(entity => {
                entity.Property(e => e.Airline)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BackMessage)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BackTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DepartureCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureTime).HasColumnType("datetime");

                entity.Property(e => e.EnterpriseWhiteListId).HasColumnName("EnterpriseWhiteListID");

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderEnterpriseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasMaxLength(100);

                entity.Property(e => e.OrderTravelBatchId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassengerName).HasMaxLength(200);

                entity.Property(e => e.PassengerNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayCenterCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayCenterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pnr).HasMaxLength(8);

                entity.Property(e => e.ReachCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitMessage)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitTime).HasColumnType("datetime");

                entity.Property(e => e.TicketNo).HasMaxLength(200);

                entity.Property(e => e.TicketTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TravelBatch>(entity => {
                entity.HasKey(e => e.TravelBatchResultId);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EnterpriseName).HasMaxLength(50);

                entity.Property(e => e.PayCenterCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayCenterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TravelBatchId).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity => {
                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasDefaultValueSql("((0))");

                entity.Property(e => e.PayCenterCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPwd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
