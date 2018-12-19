using Microsoft.EntityFrameworkCore;
using QiShiShe.DDD.Config;

namespace QiShiShe.Entity.CGTModels {
    public partial class cgtContext : DbContext {
        public virtual DbSet<AbeerrorInfo> AbeerrorInfo {
            get; set;
        }
        public virtual DbSet<BankPayLimitInfo> BankPayLimitInfo {
            get; set;
        }
        public virtual DbSet<Bill> Bill {
            get; set;
        }
        public virtual DbSet<BillDetail> BillDetail {
            get; set;
        }
        public virtual DbSet<BillRepayDetail> BillRepayDetail {
            get; set;
        }
        public virtual DbSet<BillRepayLog> BillRepayLog {
            get; set;
        }
        public virtual DbSet<BindCard> BindCard {
            get; set;
        }
        public virtual DbSet<CompanyAccount> CompanyAccount {
            get; set;
        }
        public virtual DbSet<ErrorInfo> ErrorInfo {
            get; set;
        }
        public virtual DbSet<GuaranteeBill> GuaranteeBill {
            get; set;
        }
        public virtual DbSet<Guaranteetimes> Guaranteetimes {
            get; set;
        }
        public virtual DbSet<HangLog> HangLog {
            get; set;
        }
        public virtual DbSet<HistoryPartnerInfo> HistoryPartnerInfo {
            get; set;
        }
        public virtual DbSet<InsuranceCompany> InsuranceCompany {
            get; set;
        }
        public virtual DbSet<InterfaceAccount> InterfaceAccount {
            get; set;
        }
        public virtual DbSet<InterfaceAccountAndUserAccount> InterfaceAccountAndUserAccount {
            get; set;
        }
        public virtual DbSet<LoginTokenInfo> LoginTokenInfo {
            get; set;
        }
        public virtual DbSet<MessageManage> MessageManage {
            get; set;
        }
        public virtual DbSet<MessageTemplate> MessageTemplate {
            get; set;
        }
        public virtual DbSet<OfficeConfig> OfficeConfig {
            get; set;
        }
        public virtual DbSet<OfficeNoConfig> OfficeNoConfig {
            get; set;
        }
        public virtual DbSet<PartnerBusiness> PartnerBusiness {
            get; set;
        }
        public virtual DbSet<PartnerPermissions> PartnerPermissions {
            get; set;
        }
        public virtual DbSet<SunsuspendErrorInfo> SunsuspendErrorInfo {
            get; set;
        }
        public virtual DbSet<TicketDigitalPolicyRule> TicketDigitalPolicyRule {
            get; set;
        }
        public virtual DbSet<TicketOrderRefound> TicketOrderRefound {
            get; set;
        }
        public virtual DbSet<TicketPolicyRule> TicketPolicyRule {
            get; set;
        }
        public virtual DbSet<TicketPolicyRuleDetail> TicketPolicyRuleDetail {
            get; set;
        }
        public virtual DbSet<TicketRiskCabin> TicketRiskCabin {
            get; set;
        }
        public virtual DbSet<TicketRiskControlExc> TicketRiskControlExc {
            get; set;
        }
        public virtual DbSet<TicketRiskControlRule> TicketRiskControlRule {
            get; set;
        }
        public virtual DbSet<TicketRiskRefund> TicketRiskRefund {
            get; set;
        }
        public virtual DbSet<TicketRiskRoute> TicketRiskRoute {
            get; set;
        }
        public virtual DbSet<TicketScanInfo> TicketScanInfo {
            get; set;
        }
        public virtual DbSet<TicketScannedLog> TicketScannedLog {
            get; set;
        }
        public virtual DbSet<TicketUserInfo> TicketUserInfo {
            get; set;
        }
        public virtual DbSet<Trade> Trade {
            get; set;
        }
        public virtual DbSet<TradeAliPayOriginalMemberList> TradeAliPayOriginalMemberList {
            get; set;
        }
        public virtual DbSet<TradeCreditPayDetail> TradeCreditPayDetail {
            get; set;
        }
        public virtual DbSet<TradeNotify> TradeNotify {
            get; set;
        }
        public virtual DbSet<TradePassenger> TradePassenger {
            get; set;
        }
        public virtual DbSet<TradeReapalMemberList> TradeReapalMemberList {
            get; set;
        }
        public virtual DbSet<TradeSegment> TradeSegment {
            get; set;
        }
        public virtual DbSet<TradeTicketInfo> TradeTicketInfo {
            get; set;
        }
        public virtual DbSet<TradeTopUp> TradeTopUp {
            get; set;
        }
        public virtual DbSet<TradeWithdrawal> TradeWithdrawal {
            get; set;
        }
        public virtual DbSet<UserAccount> UserAccount {
            get; set;
        }
        public virtual DbSet<UserAutoRefund> UserAutoRefund {
            get; set;
        }
        public virtual DbSet<UserBalanceRefund> UserBalanceRefund {
            get; set;
        }
        public virtual DbSet<UserEterm> UserEterm {
            get; set;
        }
        public virtual DbSet<UserToLccemail> UserToLccemail {
            get; set;
        }
        public virtual DbSet<WithdrawalTrade> WithdrawalTrade {
            get; set;
        }

        // Unable to generate entity type for table 'dbo.PersonIdCard'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TradeReapalOriginalMemberList'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TradeWalletPayOriginalMemberList'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer(JsonConfig.JsonRead("cgtConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<AbeerrorInfo>(entity => {
                entity.ToTable("ABEErrorInfo");

                entity.Property(e => e.Abedesc)
                    .IsRequired()
                    .HasColumnName("ABEDesc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyUser).HasMaxLength(50);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pnrcontent)
                    .HasColumnName("PNRContent")
                    .HasColumnType("text");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<BankPayLimitInfo>(entity => {
                entity.Property(e => e.BankCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardKind)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DayMoney)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).HasColumnType("text");

                entity.Property(e => e.SingleMoney)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Bill>(entity => {
                entity.Property(e => e.AllBalanceBillFreeAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.AllBillInterest).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceBillAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceBillFree).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceBillFreeAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceBillRefundAmount).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BillDate).HasColumnType("date");

                entity.Property(e => e.BillInterest).HasDefaultValueSql("((0))");

                entity.Property(e => e.BillType).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastBalanceBillAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefundAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.RepayAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.RepayStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.RepayType).HasDefaultValueSql("((5))");

                entity.Property(e => e.SettlementStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.SumPassengerNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<BillDetail>(entity => {
                entity.Property(e => e.AuthStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.BillDate).HasColumnType("date");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FreezeAmount).HasColumnType("money");

                entity.Property(e => e.GoldMasterName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'‘’')");

                entity.Property(e => e.Isrefundment).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderInterest)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderSource).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderTotalAmout).HasColumnType("money");

                entity.Property(e => e.OrderType).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlatformCode).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlatformName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RepayAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShouldRepayAmount).HasColumnType("money");

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BillRepayDetail>(entity => {
                entity.HasKey(e => e.RepayDetailId);

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<BillRepayLog>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RepayAmount).HasColumnType("money");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BindCard>(entity => {
                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.BankNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankOpenName).HasMaxLength(50);

                entity.Property(e => e.BranchBank).HasMaxLength(50);

                entity.Property(e => e.CenterBank).HasMaxLength(50);

                entity.Property(e => e.CertificateNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Province).HasMaxLength(50);

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserAgreementNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanyAccount>(entity => {
                entity.HasKey(e => e.CompanyId);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyAccountName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyReapalNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Czdjurl)
                    .IsRequired()
                    .HasColumnName("CZDJUrl")
                    .HasMaxLength(200);

                entity.Property(e => e.Iataurl)
                    .IsRequired()
                    .HasColumnName("IATAUrl")
                    .HasMaxLength(200);

                entity.Property(e => e.PartnerCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Swdjurl)
                    .IsRequired()
                    .HasColumnName("SWDJUrl")
                    .HasMaxLength(200);

                entity.Property(e => e.Yhkhurl)
                    .IsRequired()
                    .HasColumnName("YHKHUrl")
                    .HasMaxLength(200);

                entity.Property(e => e.Yyzzurl)
                    .IsRequired()
                    .HasColumnName("YYZZUrl")
                    .HasMaxLength(200);

                entity.Property(e => e.Zzjgurl)
                    .IsRequired()
                    .HasColumnName("ZZJGUrl")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ErrorInfo>(entity => {
                entity.HasKey(e => e.ErrorId);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlatformErrorCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlatformErrorMsg).HasColumnType("text");

                entity.Property(e => e.SyatemCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SyatemMsg).HasColumnType("text");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GuaranteeBill>(entity => {
                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GuaranteeCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.GuaranteeDate).HasColumnType("datetime");

                entity.Property(e => e.GuaranteeUserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Guaranteetimes>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsRecharge).HasDefaultValueSql("((0))");

                entity.Property(e => e.StepFourTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((13))");

                entity.Property(e => e.StepOneTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((7))");

                entity.Property(e => e.StepThreeTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((12))");

                entity.Property(e => e.StepTwoTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((11))");

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<HangLog>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HangOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HangTime).HasColumnType("datetime");

                entity.Property(e => e.Operation)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'(sys)')");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TradePassengerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TradeTicketNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoryPartnerInfo>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HisPartnerCode).HasMaxLength(50);

                entity.Property(e => e.MerchantName).HasMaxLength(50);

                entity.Property(e => e.Operation).HasMaxLength(50);

                entity.Property(e => e.PartnerCode).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(1000);

                entity.Property(e => e.UaccountId).HasColumnName("UAccountId");
            });

            modelBuilder.Entity<InsuranceCompany>(entity => {
                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InsuranceCompanyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<InterfaceAccount>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CertAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CertPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCheckPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantIp)
                    .HasColumnName("MerchantIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantPwd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('‘’')");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReapalMerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReapalUserKey)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReapayMerchantNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((2))");

                entity.Property(e => e.SuspendedServiceUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TableId)
                    .HasColumnName("TableID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.Property(e => e.UserKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InterfaceAccountAndUserAccount>(entity => {
                entity.Property(e => e.InterfaceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoginTokenInfo>(entity => {
                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ip).HasMaxLength(50);

                entity.Property(e => e.Mac).HasMaxLength(50);

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MessageManage>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MessageNote)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperationUserId).HasDefaultValueSql("((0))");

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MessageTemplate>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TemplateContent)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OfficeConfig>(entity => {
                entity.Property(e => e.B2bname)
                    .HasColumnName("B2BName")
                    .HasMaxLength(50);

                entity.Property(e => e.B2bpw)
                    .HasColumnName("B2BPw")
                    .HasMaxLength(50);

                entity.Property(e => e.Eterm).HasMaxLength(50);

                entity.Property(e => e.EtermPw).HasMaxLength(50);

                entity.Property(e => e.OfficeNo).HasMaxLength(50);

                entity.Property(e => e.Port).HasMaxLength(50);

                entity.Property(e => e.ServerAddress).HasMaxLength(50);

                entity.Property(e => e.Si)
                    .HasColumnName("SI")
                    .HasMaxLength(50);

                entity.Property(e => e.Type).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OfficeNoConfig>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AirCompanyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyUser).HasMaxLength(50);

                entity.Property(e => e.OfficeNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PartnerBusiness>(entity => {
                entity.Property(e => e.BusinessCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessRemark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PartnerPermissions>(entity => {
                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PartnerCode)
                    .IsRequired()
                    .HasColumnType("char(2)");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SunsuspendErrorInfo>(entity => {
                entity.HasKey(e => e.SunsuspendId);

                entity.ToTable("SUnsuspendErrorInfo");

                entity.Property(e => e.SunsuspendId).HasColumnName("SUnsuspendId");

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Amount).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ErrorDescript).HasColumnType("text");

                entity.Property(e => e.MerchantId).HasMaxLength(50);

                entity.Property(e => e.NotifyUrl).HasMaxLength(1000);

                entity.Property(e => e.NumberRefundRebate)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OperationUser)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PersonalMerchantNo).HasMaxLength(50);

                entity.Property(e => e.PlatformOrderId).HasMaxLength(100);

                entity.Property(e => e.ReMoneyName).HasMaxLength(50);

                entity.Property(e => e.ReturnAmountAccount).HasMaxLength(50);

                entity.Property(e => e.ServiceUrl).HasMaxLength(100);

                entity.Property(e => e.StartDate).HasMaxLength(50);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.SuStatus).HasDefaultValueSql("((2))");

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<TicketDigitalPolicyRule>(entity => {
                entity.Property(e => e.AirCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cabin)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeTicketRule)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefundTicketRule)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<TicketOrderRefound>(entity => {
                entity.HasKey(e => e.RefoundId);

                entity.Property(e => e.ApplyPnr)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayTradeNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefoundMoney).HasColumnType("money");

                entity.Property(e => e.Status).HasDefaultValueSql("((2))");

                entity.Property(e => e.SuccessPnr)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TicketPolicyRule>(entity => {
                entity.Property(e => e.AirCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cabin)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CabinDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Discount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseDateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasColumnType("text");
            });

            modelBuilder.Entity<TicketPolicyRuleDetail>(entity => {
                entity.Property(e => e.EndDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EndHourDesc).HasMaxLength(500);

                entity.Property(e => e.StartDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StartHourDesc).HasMaxLength(500);
            });

            modelBuilder.Entity<TicketRiskCabin>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Airline)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Cabin)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TicketRiskControlExc>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ExceptionDes).HasColumnType("text");

                entity.Property(e => e.MerchantCode).HasMaxLength(100);

                entity.Property(e => e.OrderId).HasMaxLength(50);

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TicketNo).HasMaxLength(100);
            });

            modelBuilder.Entity<TicketRiskControlRule>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Day).HasMaxLength(50);

                entity.Property(e => e.MerchantCode).HasMaxLength(50);

                entity.Property(e => e.MerchantName).HasMaxLength(50);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Proportion).HasMaxLength(50);

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<TicketRiskRefund>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Airline)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Cabin).HasColumnType("nchar(10)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Destination)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Origin)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Passengers)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlatformOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefundAmout).HasColumnType("money");

                entity.Property(e => e.RefundStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<TicketRiskRoute>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Destination)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Origin)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TicketScanInfo>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Airline).HasMaxLength(50);

                entity.Property(e => e.BackMerchantCode).HasMaxLength(50);

                entity.Property(e => e.BackUserName).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DepartureTime).HasMaxLength(50);

                entity.Property(e => e.FlightNo).HasMaxLength(50);

                entity.Property(e => e.MerchantCode).HasMaxLength(50);

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderId).HasMaxLength(50);

                entity.Property(e => e.PassengerName).HasMaxLength(50);

                entity.Property(e => e.RechargeStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ScanStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ScanTime).HasColumnType("datetime");

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TicketNo).HasMaxLength(50);
            });

            modelBuilder.Entity<TicketScannedLog>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackMerchantCode).HasMaxLength(100);

                entity.Property(e => e.BackTime).HasColumnType("datetime");

                entity.Property(e => e.BackUserName).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DepartureTime).HasColumnType("datetime");

                entity.Property(e => e.FlightNo).HasMaxLength(100);

                entity.Property(e => e.MerchantCode).HasMaxLength(100);

                entity.Property(e => e.MerchantName).HasMaxLength(100);

                entity.Property(e => e.OrderId).HasMaxLength(100);

                entity.Property(e => e.PassengerName).HasMaxLength(100);

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TicketNo).HasMaxLength(100);
            });

            modelBuilder.Entity<TicketUserInfo>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddUser)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'system')");

                entity.Property(e => e.AgentCode).HasMaxLength(50);

                entity.Property(e => e.CgtuserId).HasColumnName("CGTUserID");

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.InterfacePwd).HasMaxLength(50);

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyUser)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'system')");

                entity.Property(e => e.SafetyCode).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Trade>(entity => {
                entity.Property(e => e.BackStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.BillDate).HasColumnType("date");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditPayMoney)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnterpriseWhiteListId)
                    .HasColumnName("EnterpriseWhiteListID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GoldMasterName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GoldMasterType).HasDefaultValueSql("((0))");

                entity.Property(e => e.InTradeNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InterestRate)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsBill).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRemoney).HasDefaultValueSql("((0))");

                entity.Property(e => e.Isuspended).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderId).HasMaxLength(100);

                entity.Property(e => e.OutOrderPayType).HasDefaultValueSql("((0))");

                entity.Property(e => e.OutTradeNo).HasMaxLength(100);

                entity.Property(e => e.PayUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poundage)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReapalOutTradeNo).HasMaxLength(100);

                entity.Property(e => e.RedTradeNo).HasMaxLength(100);

                entity.Property(e => e.RefundAmout)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SolutionRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SuccessTime).HasColumnType("datetime");

                entity.Property(e => e.SupendedSet).HasDefaultValueSql("((0))");

                entity.Property(e => e.SuspendedStatus)
                    .HasColumnName("suspendedStatus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TradeSource).HasDefaultValueSql("((1))");

                entity.Property(e => e.TradeStatus).HasDefaultValueSql("((2))");

                entity.Property(e => e.TradeSumMoney).HasColumnType("money");

                entity.Property(e => e.TravelType).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnsupendedSet).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserPayMoney).HasColumnType("money");
            });

            modelBuilder.Entity<TradeAliPayOriginalMemberList>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BalancePayment).HasMaxLength(50);

                entity.Property(e => e.CounterParty).HasMaxLength(500);

                entity.Property(e => e.CreateTranTime).HasColumnType("datetime");

                entity.Property(e => e.FromUrl).HasMaxLength(500);

                entity.Property(e => e.MerchantOrderNo).HasMaxLength(100);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.PayTime).HasMaxLength(100);

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ServiceCharge).HasMaxLength(50);

                entity.Property(e => e.SuccessRefund)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TradeName).HasMaxLength(100);

                entity.Property(e => e.TradeStatusDes).HasMaxLength(50);

                entity.Property(e => e.TranSource).HasMaxLength(100);

                entity.Property(e => e.TransactionNo).HasMaxLength(100);

                entity.Property(e => e.TypeDes).HasMaxLength(100);
            });

            modelBuilder.Entity<TradeCreditPayDetail>(entity => {
                entity.HasKey(e => e.CreditPayDetailId);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayMoney)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TradeNotify>(entity => {
                entity.Property(e => e.Notify)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PerformData)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.PerformTime).HasColumnType("datetime");

                entity.Property(e => e.SuccessTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TradePassenger>(entity => {
                entity.Property(e => e.AirTicketNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PassengerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlatformOrderId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PsgIndexInPnr).HasColumnName("PsgIndexInPNR");

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TicketType).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TradeReapalMemberList>(entity => {
                entity.Property(e => e.CreateTime)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromAccountName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsBill).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsWallet).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsaLiPay).HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantOrderNo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlateCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefundTicketId).IsUnicode(false);

                entity.Property(e => e.Remark1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ToAccountName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TransAmount).HasColumnType("money");

                entity.Property(e => e.TransCreateTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TransNo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TradeSegment>(entity => {
                entity.Property(e => e.Airline)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArrivalDate).HasColumnType("datetime");

                entity.Property(e => e.Cabin)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureDate).HasColumnType("datetime");

                entity.Property(e => e.Destination)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Origin)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlatformOrderId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<TradeTicketInfo>(entity => {
                entity.HasKey(e => e.TradeInfoId);

                entity.Property(e => e.Agio).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ChannelOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChannelUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NotifyUrl)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NumberRefund)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberRefundRebate)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderPrice).HasColumnType("money");

                entity.Property(e => e.PartnerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassengerNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.PayPrice).HasColumnType("money");

                entity.Property(e => e.PayUrl).HasColumnType("text");

                entity.Property(e => e.PlatFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PlatformLoginPwd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlatformName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlatformOrderId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pnr)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rebate)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RebatePrice).HasColumnType("money");

                entity.Property(e => e.ReturnUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Tax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TicketPrice).HasColumnType("money");

                entity.Property(e => e.UserPwd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TradeTopUp>(entity => {
                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromUserId).HasDefaultValueSql("((0))");

                entity.Property(e => e.InTradeNo).HasMaxLength(100);

                entity.Property(e => e.OutTradeNo).HasMaxLength(100);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.SuccessTime).HasColumnType("datetime");

                entity.Property(e => e.TableId)
                    .HasColumnName("TableID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ToUserId).HasDefaultValueSql("((0))");

                entity.Property(e => e.TradeId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TradeWithdrawal>(entity => {
                entity.HasKey(e => e.WithdrawalId);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InTradeNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutTradeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReapalBindId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuccessTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserAccount>(entity => {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.BankCardNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BillLateFee)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.CreditAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FactoringInterestRate)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GraceBate)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0.0004))");

                entity.Property(e => e.GraceCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.GraceDay).HasDefaultValueSql("((7))");

                entity.Property(e => e.IdNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceBillDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsInsurance).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOnVip).HasDefaultValueSql("((0))");

                entity.Property(e => e.LccreceivesEmail)
                    .IsRequired()
                    .HasColumnName("LCCReceivesEmail")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MerchantCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnName("ModifyUserID");

                entity.Property(e => e.OverdueBate)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0.003))");

                entity.Property(e => e.OverdueCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartnerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00')");

                entity.Property(e => e.PayCenterCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RealName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReapalBindId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReapalMemberNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReapalMerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReapalUserKey)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status).HasDefaultValueSql("((2))");

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TicketDelayEmail).HasMaxLength(200);

                entity.Property(e => e.UserCompanyName)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserFactoringCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('951daab6-898a-4064-97d4-fb77dc8971e8')");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPwd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vip).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UserAutoRefund>(entity => {
                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Stauts).HasDefaultValueSql("((0))");

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UserBalanceRefund>(entity => {
                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UserEterm>(entity => {
                entity.Property(e => e.EtermUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayCenterCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserOffice)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserToLccemail>(entity => {
                entity.ToTable("UserToLCCEmail");

                entity.Property(e => e.UserToLccemailId).HasColumnName("UserToLCCEmailId");

                entity.Property(e => e.AirLineEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Airline)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('‘’')");

                entity.Property(e => e.AirlineName).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<WithdrawalTrade>(entity => {
                entity.Property(e => e.Amout).HasColumnType("money");

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.BankNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankOpenName).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MerchantOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TableId).HasDefaultValueSql("(newid())");
            });
        }
    }
}
