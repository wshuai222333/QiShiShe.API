using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Travel.DDD.Config;

namespace Travel.Entity.CGTLOGModels
{
    public partial class cgt_logContext : DbContext
    {
        public virtual DbSet<AccountInterfaceLog> AccountInterfaceLog { get; set; }
        public virtual DbSet<AliCheckTicketLog> AliCheckTicketLog { get; set; }
        public virtual DbSet<ApiexceptionLog> ApiexceptionLog { get; set; }
        public virtual DbSet<ApiNotifyLog> ApiNotifyLog { get; set; }
        public virtual DbSet<BillLog> BillLog { get; set; }
        public virtual DbSet<CheckTicketModuleLog> CheckTicketModuleLog { get; set; }
        public virtual DbSet<HpcheckTicketResultLog> HpcheckTicketResultLog { get; set; }
        public virtual DbSet<InterFaceApimonitorLog> InterFaceApimonitorLog { get; set; }
        public virtual DbSet<MessageEmailInfo> MessageEmailInfo { get; set; }
        public virtual DbSet<MessageSend> MessageSend { get; set; }
        public virtual DbSet<PhoneMessageLog> PhoneMessageLog { get; set; }
        public virtual DbSet<TradeLog> TradeLog { get; set; }
        public virtual DbSet<TranferLogs> TranferLogs { get; set; }
        public virtual DbSet<UserLog> UserLog { get; set; }
        public virtual DbSet<XhinterFaceCheckTicketResultLog> XhinterFaceCheckTicketResultLog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(JsonConfig.JsonRead("cgtLogConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountInterfaceLog>(entity =>
            {
                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Interface).HasMaxLength(50);

                entity.Property(e => e.Method).HasMaxLength(50);
            });

            modelBuilder.Entity<AliCheckTicketLog>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.RequestTime).HasColumnType("datetime");

                entity.Property(e => e.ReturnMessage)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnResult).HasColumnType("text");

                entity.Property(e => e.ReturnTime).HasColumnType("datetime");

                entity.Property(e => e.TikcetNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApiexceptionLog>(entity =>
            {
                entity.ToTable("APIExceptionLog");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("IDX_CreateTime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasMaxLength(1000);

                entity.Property(e => e.MessageCode).HasMaxLength(50);

                entity.Property(e => e.ReturnParams).IsUnicode(false);

                entity.Property(e => e.SubmitParams).IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApiNotifyLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MerchantCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NodifyParameter)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReNodifyParameter).IsUnicode(false);

                entity.Property(e => e.ReapayMerchantNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BillLog>(entity =>
            {
                entity.Property(e => e.BillAmount).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillTime).HasColumnType("datetime");

                entity.Property(e => e.PerformContent).IsUnicode(false);

                entity.Property(e => e.PerformMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PerformResult).IsUnicode(false);

                entity.Property(e => e.RepayAmount).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CheckTicketModuleLog>(entity =>
            {
                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MerchantCode).HasMaxLength(100);

                entity.Property(e => e.PayCenterCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TravelBatchId).HasMaxLength(50);
            });

            modelBuilder.Entity<HpcheckTicketResultLog>(entity =>
            {
                entity.ToTable("HPCheckTicketResultLog");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.CheckStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.TicketNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InterFaceApimonitorLog>(entity =>
            {
                entity.ToTable("InterFaceAPIMonitorLog");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage).HasColumnType("text");

                entity.Property(e => e.InterFaceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LogType).HasDefaultValueSql("((0))");

                entity.Property(e => e.MonitorNumber).HasMaxLength(50);

                entity.Property(e => e.RequestJson)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.RequestTime).HasColumnType("datetime");

                entity.Property(e => e.ResponseJson).HasColumnType("text");

                entity.Property(e => e.ResponseTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MessageEmailInfo>(entity =>
            {
                entity.HasKey(e => e.EmailId);

                entity.Property(e => e.MsgTitle).IsUnicode(false);
            });

            modelBuilder.Entity<MessageSend>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ExecuteTime).HasColumnType("datetime");

                entity.Property(e => e.FormUserName).HasMaxLength(200);

                entity.Property(e => e.FormUserPwd).HasMaxLength(200);

                entity.Property(e => e.FromUser).IsUnicode(false);

                entity.Property(e => e.MsgContent).IsUnicode(false);

                entity.Property(e => e.ToUser).IsUnicode(false);
            });

            modelBuilder.Entity<PhoneMessageLog>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MessageContent).HasMaxLength(500);

                entity.Property(e => e.MessageType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TradeLog>(entity =>
            {
                entity.Property(e => e.InTradeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutTradeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerformContent).IsUnicode(false);

                entity.Property(e => e.PerformMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PerformResult).IsUnicode(false);

                entity.Property(e => e.TradeTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TranferLogs>(entity =>
            {
                entity.ToTable("Tranfer_Logs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName).HasColumnType("nchar(50)");

                entity.Property(e => e.CompanyOrderId)
                    .HasMaxLength(3600)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PayAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReapalNo)
                    .HasColumnName("ReapalNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDecryptParams)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseDecryptParams)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnErrorMessage)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.StepNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserLog>(entity =>
            {
                entity.Property(e => e.LoginIp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.PerformContent).IsUnicode(false);

                entity.Property(e => e.PerformMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PerformResult).IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XhinterFaceCheckTicketResultLog>(entity =>
            {
                entity.ToTable("XHInterFaceCheckTicketResultLog");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BatchNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.RegisterStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.TicketNum)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
        }
    }
}
