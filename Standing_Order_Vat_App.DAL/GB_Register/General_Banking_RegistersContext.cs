using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Standing_Order_Vat_App.DAL.GB_Register
{
    public partial class General_Banking_RegistersContext : DbContext
    {
        public General_Banking_RegistersContext()
        {
        }

        public General_Banking_RegistersContext(DbContextOptions<General_Banking_RegistersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountStatus> AccountStatuses { get; set; } = null!;
        public virtual DbSet<AccountType> AccountTypes { get; set; } = null!;
        public virtual DbSet<BulkTst> BulkTsts { get; set; } = null!;
        public virtual DbSet<Cd> Cds { get; set; } = null!;
        public virtual DbSet<CdKey> CdKeys { get; set; } = null!;
        public virtual DbSet<Cif> Cifs { get; set; } = null!;
        public virtual DbSet<CifKey> CifKeys { get; set; } = null!;
        public virtual DbSet<Comm> Comms { get; set; } = null!;
        public virtual DbSet<CommonKey> CommonKeys { get; set; } = null!;
        public virtual DbSet<DataStage> DataStages { get; set; } = null!;
        public virtual DbSet<DdaKey> DdaKeys { get; set; } = null!;
        public virtual DbSet<Ddatest> Ddatests { get; set; } = null!;
        public virtual DbSet<Ddum> Dda { get; set; } = null!;
        public virtual DbSet<DormantRegister> DormantRegisters { get; set; } = null!;
        public virtual DbSet<EntryStatus> EntryStatuses { get; set; } = null!;
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; } = null!;
        public virtual DbSet<FileStage> FileStages { get; set; } = null!;
        public virtual DbSet<ForeignChecksBatch> ForeignChecksBatches { get; set; } = null!;
        public virtual DbSet<ForeignChecksDetail> ForeignChecksDetails { get; set; } = null!;
        public virtual DbSet<ForeignChecksSettlement> ForeignChecksSettlements { get; set; } = null!;
        public virtual DbSet<ImportedFile> ImportedFiles { get; set; } = null!;
        public virtual DbSet<Loan> Loans { get; set; } = null!;
        public virtual DbSet<LoanKey> LoanKeys { get; set; } = null!;
        public virtual DbSet<Sav> Savs { get; set; } = null!;
        public virtual DbSet<SavKey> SavKeys { get; set; } = null!;
        public virtual DbSet<TblVatApply> TblVatApplys { get; set; } = null!;
        public virtual DbSet<TestTable> TestTables { get; set; } = null!;
        public virtual DbSet<VwEmp> VwEmps { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-9TAG556\\SQLEXPRESS;Database=General_Banking_Registers;user id=sa;password=bt123;TrustServerCertificate=true;Integrated Security=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountStatus>(entity =>
            {
                entity.HasKey(e => e.AcctStatId);

                entity.ToTable("AccountStatus");

                entity.Property(e => e.AcctStatusDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.HasKey(e => e.AcctTypeId);

                entity.ToTable("AccountType");

                entity.Property(e => e.AcctTypeDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkTst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BulkTst");

                entity.Property(e => e.BulkTest).IsUnicode(false);
            });

            modelBuilder.Entity<Cd>(entity =>
            {
                entity.HasKey(e => e.CdsId);

                entity.ToTable("CDS");

                entity.Property(e => e.CdsId).HasColumnName("CDS_ID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Account_Number")
                    .IsFixedLength();

                entity.Property(e => e.AccruedInter)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Accrued Inter")
                    .IsFixedLength();

                entity.Property(e => e.AchAccountNumber)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("ACH Account Number")
                    .IsFixedLength();

                entity.Property(e => e.AchRoutingNumber)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ACH Routing Number")
                    .IsFixedLength();

                entity.Property(e => e.AchTransacti)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ACH Transacti")
                    .IsFixedLength();

                entity.Property(e => e.AmountIntere)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Amount Intere")
                    .IsFixedLength();

                entity.Property(e => e.ApplyInterestCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Apply Interest Code")
                    .IsFixedLength();

                entity.Property(e => e.AprAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Apr Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.ApyCurrentPeriod)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("APY Current Period")
                    .IsFixedLength();

                entity.Property(e => e.ApyOfDigits)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("APY # of Digits")
                    .IsFixedLength();

                entity.Property(e => e.AugAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Aug Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.BalAtSplitRate)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Bal at Split Rate")
                    .IsFixedLength();

                entity.Property(e => e.BeginningBalToday)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Beginning Bal Today")
                    .IsFixedLength();

                entity.Property(e => e.CheckAdviceNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Check/Advice Number")
                    .IsFixedLength();

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Class Code")
                    .IsFixedLength();

                entity.Property(e => e.CompoundSimple)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Compound/Simple")
                    .IsFixedLength();

                entity.Property(e => e.CorrespondingAcct)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Corresponding Acct")
                    .IsFixedLength();

                entity.Property(e => e.CurrentBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Current Balance")
                    .IsFixedLength();

                entity.Property(e => e.DailyAccruedInt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Daily Accrued Int")
                    .IsFixedLength();

                entity.Property(e => e.DateInterestNext)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Interest Next")
                    .IsFixedLength();

                entity.Property(e => e.DateLastPaid)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Last Paid")
                    .IsFixedLength();

                entity.Property(e => e.DayInterestDue)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Day Interest Due")
                    .IsFixedLength();

                entity.Property(e => e.DaysYear)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Days/Year")
                    .IsFixedLength();

                entity.Property(e => e.DecAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Dec Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.EarlyWDPenalty)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Early W/D Penalty")
                    .IsFixedLength();

                entity.Property(e => e.EarlyWithPenalty)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Early With Penalty")
                    .IsFixedLength();

                entity.Property(e => e.EoyInterest)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EOY Interest")
                    .IsFixedLength();

                entity.Property(e => e.EqualPayment)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Equal Payment")
                    .IsFixedLength();

                entity.Property(e => e.FebAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Feb Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.ForfeitAmount)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Forfeit Amount")
                    .IsFixedLength();

                entity.Property(e => e.IntPtdAgg)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Int PTD Agg")
                    .IsFixedLength();

                entity.Property(e => e.IntRateAtRedempt)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Int Rate at Redempt")
                    .IsFixedLength();

                entity.Property(e => e.InterestFreqCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Interest Freq Code")
                    .IsFixedLength();

                entity.Property(e => e.InterestLast)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Interest Last")
                    .IsFixedLength();

                entity.Property(e => e.InterestPaid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Interest Paid")
                    .IsFixedLength();

                entity.Property(e => e.InterestRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Interest Rate")
                    .IsFixedLength();

                entity.Property(e => e.JanAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Jan Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.JulAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Jul Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.JunAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Jun Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.MarAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Mar Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.MaturityDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Maturity Date")
                    .IsFixedLength();

                entity.Property(e => e.MayAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("May Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.MonthDayFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Month/Day Flag")
                    .IsFixedLength();

                entity.Property(e => e.MtdAggregateBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("MTD Aggregate Bal")
                    .IsFixedLength();

                entity.Property(e => e.MultipleNotices)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Multiple Notices?")
                    .IsFixedLength();

                entity.Property(e => e.NonTeaserRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Non-Teaser Rate")
                    .IsFixedLength();

                entity.Property(e => e.NovAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Nov Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.NxtRnwlPenaltyCd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Nxt Rnwl Penalty Cd")
                    .IsFixedLength();

                entity.Property(e => e.OctAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Oct Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.Open)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrigInterestRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Orig Interest Rate")
                    .IsFixedLength();

                entity.Property(e => e.OriginalBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Original Balance")
                    .IsFixedLength();

                entity.Property(e => e.PenaltyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Penalty Code")
                    .IsFixedLength();

                entity.Property(e => e.PendingAchTran)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Pending ACH Tran")
                    .IsFixedLength();

                entity.Property(e => e.PrevInterestRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Prev Interest Rate")
                    .IsFixedLength();

                entity.Property(e => e.PrevMaturityDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Prev Maturity Date")
                    .IsFixedLength();

                entity.Property(e => e.PriorYearIn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Prior Year In")
                    .IsFixedLength();

                entity.Property(e => e.QtdHighBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("QTD High Balance")
                    .IsFixedLength();

                entity.Property(e => e.QtdInterest)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("QTD Interest")
                    .IsFixedLength();

                entity.Property(e => e.RateCodeAt)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Rate Code at")
                    .IsFixedLength();

                entity.Property(e => e.RenewCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Renew Code")
                    .IsFixedLength();

                entity.Property(e => e.RenewalBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Renewal Balance")
                    .IsFixedLength();

                entity.Property(e => e.RenewalClassCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Renewal Class Code")
                    .IsFixedLength();

                entity.Property(e => e.RenewalMoDayFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Renewal Mo/Day Flag")
                    .IsFixedLength();

                entity.Property(e => e.RenewalProductDef)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Renewal Product Def")
                    .IsFixedLength();

                entity.Property(e => e.RenewalTerm)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Renewal Term")
                    .IsFixedLength();

                entity.Property(e => e.Reprint)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Reprint?")
                    .IsFixedLength();

                entity.Property(e => e.RnwlPenaltyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Rnwl Penalty Code")
                    .IsFixedLength();

                entity.Property(e => e.RnwlTisDisclosure)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Rnwl TIS Disclosure")
                    .IsFixedLength();

                entity.Property(e => e.SepAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Sep Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.TeaserInt)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("# Teaser Int")
                    .IsFixedLength();

                entity.Property(e => e.Term)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ThresholdGLCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Threshold G/L Code")
                    .IsFixedLength();

                entity.Property(e => e.TimesInterestPd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("# Times Interest Pd")
                    .IsFixedLength();

                entity.Property(e => e.TotalHoldAm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Total Hold Am")
                    .IsFixedLength();

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Type Code")
                    .IsFixedLength();

                entity.Property(e => e.UsCurrency)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("US Currency")
                    .IsFixedLength();

                entity.Property(e => e.VarAdjustToRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Var Adjust to Rate")
                    .IsFixedLength();

                entity.Property(e => e.VariableRateCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Variable Rate Code")
                    .IsFixedLength();

                entity.Property(e => e.VariableRateNum)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Variable Rate Num")
                    .IsFixedLength();

                entity.Property(e => e.YtdAggregateBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("YTD Aggregate Bal")
                    .IsFixedLength();

                entity.Property(e => e.YtdAverageBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("YTD Average Balance")
                    .IsFixedLength();

                entity.Property(e => e._12MnthAverageBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("12 Mnth Average Bal")
                    .IsFixedLength();

                entity.Property(e => e._158SplitVariableRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("158 Split Variable Rate")
                    .IsFixedLength();
            });

            modelBuilder.Entity<CdKey>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CD_Key");

                entity.Property(e => e.ACType)
                    .HasMaxLength(255)
                    .HasColumnName("A/C Type ");

                entity.Property(e => e.AD)
                    .HasMaxLength(255)
                    .HasColumnName("A/D ");

                entity.Property(e => e.Chg).HasColumnName("CHG ");

                entity.Property(e => e.CrDb)
                    .HasMaxLength(255)
                    .HasColumnName("CR DB ");

                entity.Property(e => e.FieldDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Field Description  ");

                entity.Property(e => e.FldLen).HasColumnName("Fld Len ");

                entity.Property(e => e.FldNum).HasColumnName("Fld Num ");

                entity.Property(e => e.GLCol).HasColumnName("G/L Col ");

                entity.Property(e => e.GlClrFlg)
                    .HasMaxLength(255)
                    .HasColumnName("GL Clr Flg ");

                entity.Property(e => e.HelpDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Help Description");

                entity.Property(e => e.Inq).HasColumnName("INQ ");

                entity.Property(e => e.LastLocation).HasColumnName("Last location");

                entity.Property(e => e.Lc)
                    .HasMaxLength(255)
                    .HasColumnName("LC ");

                entity.Property(e => e.LmtCod).HasColumnName("Lmt Cod ");

                entity.Property(e => e.Upd).HasColumnName("UPD ");

                entity.Property(e => e.Usr)
                    .HasMaxLength(255)
                    .HasColumnName("USR ");

                entity.Property(e => e._1stMastLoc).HasColumnName(" 1st Mast Loc ");
            });

            modelBuilder.Entity<Cif>(entity =>
            {
                entity.ToTable("CIF");

                entity.Property(e => e.CifId).HasColumnName("CIF_ID");

                entity.Property(e => e.AdvanceEndingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Advance Ending Date")
                    .IsFixedLength();

                entity.Property(e => e.AffilOptOutCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Affil Opt Out Code")
                    .IsFixedLength();

                entity.Property(e => e.AffilOptOutDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Affil Opt Out Date")
                    .IsFixedLength();

                entity.Property(e => e.AffiliateExpDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Affiliate Exp Date")
                    .IsFixedLength();

                entity.Property(e => e.AltCtznshpCntry1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Alt Ctznshp Cntry 1")
                    .IsFixedLength();

                entity.Property(e => e.AltCtznshpCntry2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Alt Ctznshp Cntry 2")
                    .IsFixedLength();

                entity.Property(e => e.AltCtznshpCntry3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Alt Ctznshp Cntry 3")
                    .IsFixedLength();

                entity.Property(e => e.AltCtznshpCntry4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Alt Ctznshp Cntry 4")
                    .IsFixedLength();

                entity.Property(e => e.AmountDueAl)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Amount Due Al")
                    .IsFixedLength();

                entity.Property(e => e.AmountLastD)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Amount Last D")
                    .IsFixedLength();

                entity.Property(e => e.AmountOfFix)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Amount of Fix")
                    .IsFixedLength();

                entity.Property(e => e.AmountOrigCommit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Amount Orig Commit")
                    .IsFixedLength();

                entity.Property(e => e.AmtPDAllTiedLns)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Amt P/D All Tied Lns")
                    .IsFixedLength();

                entity.Property(e => e.AmtRemainToAdv)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Amt Remain to Adv")
                    .IsFixedLength();

                entity.Property(e => e.BalSheetDueDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Bal Sheet Due Date")
                    .IsFixedLength();

                entity.Property(e => e.BalSheetStmtDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Bal Sheet Stmt Date")
                    .IsFixedLength();

                entity.Property(e => e.BankDividend)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Bank Dividend")
                    .IsFixedLength();

                entity.Property(e => e.BankDivsExempt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Bank Divs Exempt?")
                    .IsFixedLength();

                entity.Property(e => e.BankSharsHe)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Bank Shars He")
                    .IsFixedLength();

                entity.Property(e => e.BankruptcyCaseNbr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Bankruptcy Case Nbr")
                    .IsFixedLength();

                entity.Property(e => e.BankruptcyStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Bankruptcy Status?")
                    .IsFixedLength();

                entity.Property(e => e.BankruptcyType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Bankruptcy Type")
                    .IsFixedLength();

                entity.Property(e => e.BirthMonthDate)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Birth Month & Date")
                    .IsFixedLength();

                entity.Property(e => e.Birthdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BkrptcyDischrgeDt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Bkrptcy Dischrge Dt")
                    .IsFixedLength();

                entity.Property(e => e.BrokerageAccount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Brokerage Account")
                    .IsFixedLength();

                entity.Property(e => e.CensusTract)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Census Tract")
                    .IsFixedLength();

                entity.Property(e => e.CheckIssueStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CHECK ISSUE STATUS")
                    .IsFixedLength();

                entity.Property(e => e.Cif1)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CIF")
                    .IsFixedLength();

                entity.Property(e => e.CifCdBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CIF CD Balance")
                    .IsFixedLength();

                entity.Property(e => e.CifCommittedUnsecr)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CIF Committed Unsecr")
                    .IsFixedLength();

                entity.Property(e => e.CifCreditLimit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CIF Credit Limit")
                    .IsFixedLength();

                entity.Property(e => e.CifDdaBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CIF DDA Balance")
                    .IsFixedLength();

                entity.Property(e => e.CifDepositBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CIF Deposit Balance")
                    .IsFixedLength();

                entity.Property(e => e.CifIraBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CIF IRA Balance")
                    .IsFixedLength();

                entity.Property(e => e.CifLoanBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CIF Loan Balance")
                    .IsFixedLength();

                entity.Property(e => e.CifMemoposteCrs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIF Memoposte Crs")
                    .IsFixedLength();

                entity.Property(e => e.CifMemoposteDrs)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIF Memoposte Drs")
                    .IsFixedLength();

                entity.Property(e => e.CifPayoffUnsecurd)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CIF Payoff Unsecurd")
                    .IsFixedLength();

                entity.Property(e => e.CifSavingsBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CIF Savings Balance")
                    .IsFixedLength();

                entity.Property(e => e.CifTotalCommitted)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CIF Total Committed")
                    .IsFixedLength();

                entity.Property(e => e.CifUnusedCommit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CIF Unused Commit")
                    .IsFixedLength();

                entity.Property(e => e.CipIdIssuer)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CIP ID Issuer")
                    .IsFixedLength();

                entity.Property(e => e.CipIdNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CIP ID Number")
                    .IsFixedLength();

                entity.Property(e => e.CipIdentType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CIP Ident. Type")
                    .IsFixedLength();

                entity.Property(e => e.ConvOf5Shares)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CONV OF $5 SHARES")
                    .IsFixedLength();

                entity.Property(e => e.CountryOfBirth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Country of Birth")
                    .IsFixedLength();

                entity.Property(e => e.CountryOfResidence)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Country of Residence")
                    .IsFixedLength();

                entity.Property(e => e.CountryOfWork)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Country of Work")
                    .IsFixedLength();

                entity.Property(e => e.CreditCardBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Credit Card Balance")
                    .IsFixedLength();

                entity.Property(e => e.CreditCardLimit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Credit Card Limit")
                    .IsFixedLength();

                entity.Property(e => e.CreditLine)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Credit Line")
                    .IsFixedLength();

                entity.Property(e => e.CurrentDivPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Current Div Paid")
                    .IsFixedLength();

                entity.Property(e => e.CustomerMarketing)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Customer Marketing")
                    .IsFixedLength();

                entity.Property(e => e.CustomerStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Customer Status")
                    .IsFixedLength();

                entity.Property(e => e.Date1)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date 1")
                    .IsFixedLength();

                entity.Property(e => e.Date1994DivCashed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Date 1994 Div Cashed")
                    .IsFixedLength();

                entity.Property(e => e.Date2)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date 2")
                    .IsFixedLength();

                entity.Property(e => e.Date3)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date 3")
                    .IsFixedLength();

                entity.Property(e => e.Date4)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date 4")
                    .IsFixedLength();

                entity.Property(e => e.Date5)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date 5")
                    .IsFixedLength();

                entity.Property(e => e.DateIdExpires)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date ID Expires")
                    .IsFixedLength();

                entity.Property(e => e.DateIdIssued)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date ID Issued")
                    .IsFixedLength();

                entity.Property(e => e.DateLastDividend)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Last Dividend")
                    .IsFixedLength();

                entity.Property(e => e.DateLstDevCashed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Date Lst Dev Cashed")
                    .IsFixedLength();

                entity.Property(e => e.DatePaid)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Date Paid")
                    .IsFixedLength();

                entity.Property(e => e.DealerFloorPlan)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Dealer Floor Plan?")
                    .IsFixedLength();

                entity.Property(e => e.DebtIncomeRatio)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Debt/Income Ratio")
                    .IsFixedLength();

                entity.Property(e => e.DepositWeightedAvg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Deposit Weighted Avg")
                    .IsFixedLength();

                entity.Property(e => e.Description1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Description 1")
                    .IsFixedLength();

                entity.Property(e => e.Description2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Description 2")
                    .IsFixedLength();

                entity.Property(e => e.Description3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Description 3")
                    .IsFixedLength();

                entity.Property(e => e.Description4)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Description 4")
                    .IsFixedLength();

                entity.Property(e => e.Description5)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Description 5")
                    .IsFixedLength();

                entity.Property(e => e.DivCorresAcct)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Div Corres Acct #")
                    .IsFixedLength();

                entity.Property(e => e.DivCorresAcctType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Div Corres Acct Type")
                    .IsFixedLength();

                entity.Property(e => e.DividendCheck)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Dividend Check#")
                    .IsFixedLength();

                entity.Property(e => e.DtLastAddrChange)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Dt Last Addr Change")
                    .IsFixedLength();

                entity.Property(e => e.EMailAddress)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("E-Mail Address")
                    .IsFixedLength();

                entity.Property(e => e.Education)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ElectronicStmts)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Electronic Stmts?")
                    .IsFixedLength();

                entity.Property(e => e.Employer)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Employer Name")
                    .IsFixedLength();

                entity.Property(e => e.EstIrsInRcvdYtd)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Est IRS In Rcvd YTD")
                    .IsFixedLength();

                entity.Property(e => e.EstIrsIntPdPyr)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Est IRS Int Pd PYr")
                    .IsFixedLength();

                entity.Property(e => e.EstIrsIntPdYtd)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Est IRS Int Pd YTD")
                    .IsFixedLength();

                entity.Property(e => e.EstIrsIntRcvdPyr)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Est IRS Int Rcvd PYr")
                    .IsFixedLength();

                entity.Property(e => e.ExcludeAutoDel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Exclude Auto Del")
                    .IsFixedLength();

                entity.Property(e => e.ExcludeFromSysGen)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Exclude from SysGen")
                    .IsFixedLength();

                entity.Property(e => e.ExpLvlOfAc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Exp Lvl of Ac")
                    .IsFixedLength();

                entity.Property(e => e.ExpensePerAnalysis)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Expense per Analysis")
                    .IsFixedLength();

                entity.Property(e => e.ExpensesPrevYr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Expenses Prev Yr")
                    .IsFixedLength();

                entity.Property(e => e.ExpensesPriorYear)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Expenses Prior Year")
                    .IsFixedLength();

                entity.Property(e => e.FamilyMemberName1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Family Member Name 1")
                    .IsFixedLength();

                entity.Property(e => e.FamilyMemberName2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Family Member Name 2")
                    .IsFixedLength();

                entity.Property(e => e.FamilyMemberName3)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Family Member Name 3")
                    .IsFixedLength();

                entity.Property(e => e.FamilyMemberName4)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Family Member Name 4")
                    .IsFixedLength();

                entity.Property(e => e.FamilyMemberName5)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Family Member Name 5")
                    .IsFixedLength();

                entity.Property(e => e.FatcaAccountType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("FATCA Account Type")
                    .IsFixedLength();

                entity.Property(e => e.FatcaCurrCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("FATCA Curr Code")
                    .IsFixedLength();

                entity.Property(e => e.FinancialPlanning)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Financial Planning?")
                    .IsFixedLength();

                entity.Property(e => e.FinancialStmtDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Financial Stmt Date")
                    .IsFixedLength();

                entity.Property(e => e.FirstDateNoRec)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("First Date No Rec")
                    .IsFixedLength();

                entity.Property(e => e.FmlyMbr1BDay)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Fmly Mbr 1 B-day")
                    .IsFixedLength();

                entity.Property(e => e.FmlyMbr2BDay)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Fmly Mbr 2 B-day")
                    .IsFixedLength();

                entity.Property(e => e.FmlyMbr3BDay)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Fmly Mbr 3 B-day")
                    .IsFixedLength();

                entity.Property(e => e.FmlyMbr4BDay)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Fmly Mbr 4 B-day")
                    .IsFixedLength();

                entity.Property(e => e.FmlyMbr5BDay)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Fmly Mbr 5 B-day")
                    .IsFixedLength();

                entity.Property(e => e.FpIntBillNotPd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("FP Int Bill Not Pd")
                    .IsFixedLength();

                entity.Property(e => e.FpPrinBillNotPd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("FP Prin Bill Not Pd")
                    .IsFixedLength();

                entity.Property(e => e.HCDivsExempt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("H/C Divs Exempt?")
                    .IsFixedLength();

                entity.Property(e => e.HighLoanBalance)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("High Loan Balance")
                    .IsFixedLength();

                entity.Property(e => e.HistCashDueDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Hist Cash Due Date")
                    .IsFixedLength();

                entity.Property(e => e.HistCashStmtDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Hist Cash Stmt Date")
                    .IsFixedLength();

                entity.Property(e => e.HoldCoDivF)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Hold Co Div F")
                    .IsFixedLength();

                entity.Property(e => e.IdAltCtzspCnty1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ID Alt Ctzsp Cnty 1")
                    .IsFixedLength();

                entity.Property(e => e.IdAltCtzspCnty2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ID Alt Ctzsp Cnty 2")
                    .IsFixedLength();

                entity.Property(e => e.IdAltCtzspCnty3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ID Alt Ctzsp Cnty 3")
                    .IsFixedLength();

                entity.Property(e => e.IdAltCtzspCnty4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ID Alt Ctzsp Cnty 4")
                    .IsFixedLength();

                entity.Property(e => e.IncStmtDueDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Inc Stmt Due Date")
                    .IsFixedLength();

                entity.Property(e => e.IncomeStmtDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Income Stmt Date")
                    .IsFixedLength();

                entity.Property(e => e.IndirectCommitted)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Indirect Committed")
                    .IsFixedLength();

                entity.Property(e => e.IndirectDepBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Indirect Dep Bal")
                    .IsFixedLength();

                entity.Property(e => e.IndirectLoanBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Indirect Loan Bal")
                    .IsFixedLength();

                entity.Property(e => e.IndirectUnusedCom)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Indirect Unused Com")
                    .IsFixedLength();

                entity.Property(e => e.IntReducesAvail)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Int Reduces Avail?")
                    .IsFixedLength();

                entity.Property(e => e.JhaBillPayUser)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("JHA Bill Pay User")
                    .IsFixedLength();

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Job Title")
                    .IsFixedLength();

                entity.Property(e => e.JobTitle2)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Job Title2")
                    .IsFixedLength();

                entity.Property(e => e.LoanRatingCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Loan Rating Code")
                    .IsFixedLength();

                entity.Property(e => e.LoanWeightedAvg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Loan Weighted Avg")
                    .IsFixedLength();

                entity.Property(e => e.LoansMadeThisYear)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Loans Made This Year")
                    .IsFixedLength();

                entity.Property(e => e.LowLoanBalance)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Low Loan Balance")
                    .IsFixedLength();

                entity.Property(e => e.LtChgReduceAvail)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Lt Chg Reduce Avail?")
                    .IsFixedLength();

                entity.Property(e => e.LtvTotalCalculatd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("LTV-Total Calculatd")
                    .IsFixedLength();

                entity.Property(e => e.LtvTotalManual)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("LTV-Total Manual")
                    .IsFixedLength();

                entity.Property(e => e.MajorCredLineFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Major Cred Line Flg")
                    .IsFixedLength();

                entity.Property(e => e.MajorLineSecured)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Major Line Secured?")
                    .IsFixedLength();

                entity.Property(e => e.MaritalStatu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Marital Statu")
                    .IsFixedLength();

                entity.Property(e => e.MessageNote1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Message/Note 1")
                    .IsFixedLength();

                entity.Property(e => e.MessageNote2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Message/Note 2")
                    .IsFixedLength();

                entity.Property(e => e.MessageNote3)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Message/Note 3")
                    .IsFixedLength();

                entity.Property(e => e.Nationality)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NatureOfBusiness)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Nature of Business")
                    .IsFixedLength();

                entity.Property(e => e.NetTellerUser)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NetTeller User?")
                    .IsFixedLength();

                entity.Property(e => e.NetWorth)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Net Worth")
                    .IsFixedLength();

                entity.Property(e => e.NtAoeAttempts)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NT AOE Attempts")
                    .IsFixedLength();

                entity.Property(e => e.NtCashMgmtUser)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NT Cash Mgmt User")
                    .IsFixedLength();

                entity.Property(e => e.NumRankingPrevYr)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Num Ranking Prev Yr")
                    .IsFixedLength();

                entity.Property(e => e.NumberOfVot)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Number of Vot")
                    .IsFixedLength();

                entity.Property(e => e.NumericalRankPyr)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Numerical Rank Pyr")
                    .IsFixedLength();

                entity.Property(e => e.NumericalRanking)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Numerical Ranking")
                    .IsFixedLength();

                entity.Property(e => e.Occupation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orig1SharesHeld)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("ORIG.$1 SHARES HELD")
                    .IsFixedLength();

                entity.Property(e => e.OrigCustomerDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Orig Customer Date")
                    .IsFixedLength();

                entity.Property(e => e.ParticCommitted)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Partic Committed")
                    .IsFixedLength();

                entity.Property(e => e.ParticLoanBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Partic Loan Bal")
                    .IsFixedLength();

                entity.Property(e => e.ParticUnusedCom)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Partic Unused Com")
                    .IsFixedLength();

                entity.Property(e => e.PassPortCustomer)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PassPort Customer")
                    .IsFixedLength();

                entity.Property(e => e.PastDue6090)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Past Due 60-90")
                    .IsFixedLength();

                entity.Property(e => e.PastDue90)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Past Due > 90")
                    .IsFixedLength();

                entity.Property(e => e.Pep)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PEP")
                    .IsFixedLength();

                entity.Property(e => e.PercentileRankPyr)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Percentile Rank Pyr")
                    .IsFixedLength();

                entity.Property(e => e.PercentileRanking)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Percentile Ranking")
                    .IsFixedLength();

                entity.Property(e => e.PersStmtDueDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Pers Stmt Due Date")
                    .IsFixedLength();

                entity.Property(e => e.PersonalStmtDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Personal Stmt Date")
                    .IsFixedLength();

                entity.Property(e => e.PhoneOrder)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Phone Order")
                    .IsFixedLength();

                entity.Property(e => e.PlaceOfBirt)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Place of Birt")
                    .IsFixedLength();

                entity.Property(e => e.PrcntRankPrevYr)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Prcnt Rank Prev Yr")
                    .IsFixedLength();

                entity.Property(e => e.PrimaryCifAccount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Primary CIF Account")
                    .IsFixedLength();

                entity.Property(e => e.PrivateActBondInt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Private Act Bond Int")
                    .IsFixedLength();

                entity.Property(e => e.ProfitFromAnalysis)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Profit from Analysis")
                    .IsFixedLength();

                entity.Property(e => e.ProfitPrevYr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Profit Prev Yr")
                    .IsFixedLength();

                entity.Property(e => e.ProfitPriorYear)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Profit Prior Year")
                    .IsFixedLength();

                entity.Property(e => e.ProjCashDueDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Proj Cash Due Date")
                    .IsFixedLength();

                entity.Property(e => e.ProjCashStmtDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Proj Cash Stmt Date")
                    .IsFixedLength();

                entity.Property(e => e.PyrIntEarnedDep)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("PYr Int Earned Dep")
                    .IsFixedLength();

                entity.Property(e => e.PyrIntEarnedLoan)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("PYr Int Earned Loan")
                    .IsFixedLength();

                entity.Property(e => e.PyrIntPaidDep)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("PYr Int Paid Dep")
                    .IsFixedLength();

                entity.Property(e => e.PyrIntPaidLoans)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("PYr Int Paid Loans")
                    .IsFixedLength();

                entity.Property(e => e.RelatedCifCommit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Related CIF Commit")
                    .IsFixedLength();

                entity.Property(e => e.RelatedDepositBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Related Deposit Bal")
                    .IsFixedLength();

                entity.Property(e => e.RelatedLoanBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Related Loan Bal")
                    .IsFixedLength();

                entity.Property(e => e.RelatedUnusedComm)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Related Unused Comm")
                    .IsFixedLength();

                entity.Property(e => e.Relationship1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Relationship 1")
                    .IsFixedLength();

                entity.Property(e => e.Relationship2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Relationship 2")
                    .IsFixedLength();

                entity.Property(e => e.Relationship3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Relationship 3")
                    .IsFixedLength();

                entity.Property(e => e.Relationship4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Relationship 4")
                    .IsFixedLength();

                entity.Property(e => e.Relationship5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Relationship 5")
                    .IsFixedLength();

                entity.Property(e => e.RevenuePerAnalysis)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Revenue per Analysis")
                    .IsFixedLength();

                entity.Property(e => e.RevenuePrevYr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Revenue Prev Yr")
                    .IsFixedLength();

                entity.Property(e => e.RevenuePriorYear)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Revenue Prior Year")
                    .IsFixedLength();

                entity.Property(e => e.RiskRating)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Risk Rating")
                    .IsFixedLength();

                entity.Property(e => e.Salary)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SharesAsOf)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Shares as of")
                    .IsFixedLength();

                entity.Property(e => e.SicCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SIC Code")
                    .IsFixedLength();

                entity.Property(e => e.TaxExemptInterest)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tax Exempt Interest")
                    .IsFixedLength();

                entity.Property(e => e.TaxId10SigDir)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tax ID 10 Sig/Dir")
                    .IsFixedLength();

                entity.Property(e => e.TaxId1SigDir)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tax ID 1 Sig/Dir")
                    .IsFixedLength();

                entity.Property(e => e.TaxId2SigDir)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tax ID 2 Sig/Dir")
                    .IsFixedLength();

                entity.Property(e => e.TaxId3SigDir)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tax ID 3 Sig/Dir")
                    .IsFixedLength();

                entity.Property(e => e.TaxId4SigDir)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tax ID 4 Sig/Dir")
                    .IsFixedLength();

                entity.Property(e => e.TaxId5SigDir)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tax ID 5 Sig/Dir")
                    .IsFixedLength();

                entity.Property(e => e.TaxId6SigDir)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tax ID 6 Sig/Dir")
                    .IsFixedLength();

                entity.Property(e => e.TaxId7SigDir)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tax ID 7 Sig/Dir")
                    .IsFixedLength();

                entity.Property(e => e.TaxId8SigDir)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tax ID 8 Sig/Dir")
                    .IsFixedLength();

                entity.Property(e => e.TaxId9SigDir)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tax ID 9 Sig/Dir")
                    .IsFixedLength();

                entity.Property(e => e.TaxReturnDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Tax Return Date")
                    .IsFixedLength();

                entity.Property(e => e.TaxReturnDueDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Tax Return Due Date")
                    .IsFixedLength();

                entity.Property(e => e.ThresholdAmount)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Threshold Amount")
                    .IsFixedLength();

                entity.Property(e => e.TiedLoanFirstDue)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Tied Loan First Due")
                    .IsFixedLength();

                entity.Property(e => e.TimePastDue3060)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Time Past Due 30-60")
                    .IsFixedLength();

                entity.Property(e => e.Tot1stBonusIssue)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("TOT. 1ST BONUS ISSUE")
                    .IsFixedLength();

                entity.Property(e => e.Tot2ndBonusIssue)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("TOT. 2ND BONUS ISSUE")
                    .IsFixedLength();

                entity.Property(e => e.Tot3rdBonusIssue)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("TOT. 3RD BONUS ISSUE")
                    .IsFixedLength();

                entity.Property(e => e.TotBalAllTiedLns)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Tot Bal All Tied Lns")
                    .IsFixedLength();

                entity.Property(e => e.TotIencTiedLoans)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Tot IENC Tied Loans")
                    .IsFixedLength();

                entity.Property(e => e.TotOriginalShares)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("TOT ORIGINAL SHARES")
                    .IsFixedLength();

                entity.Property(e => e.TotUnpaidLa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tot Unpaid La")
                    .IsFixedLength();

                entity.Property(e => e.TotalAssets)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Total Assets")
                    .IsFixedLength();

                entity.Property(e => e.TotalCollCalculatd)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Total Coll-Calculatd")
                    .IsFixedLength();

                entity.Property(e => e.TotalCollManual)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Total Coll-Manual")
                    .IsFixedLength();

                entity.Property(e => e.TransactionCount)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Transaction Count")
                    .IsFixedLength();

                entity.Property(e => e.USPowerOfAttny)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("U.S. Power of Attny?")
                    .IsFixedLength();

                entity.Property(e => e.USStandingOrder)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("U.S. Standing Order?")
                    .IsFixedLength();

                entity.Property(e => e.UsTaxIdCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("US Tax ID Code")
                    .IsFixedLength();

                entity.Property(e => e.UsTaxIdNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("US Tax ID Number")
                    .IsFixedLength();

                entity.Property(e => e.UsdCifAggDepBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("USD CIF Agg Dep Bal")
                    .IsFixedLength();

                entity.Property(e => e.UsdCifAggrAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("USD CIF Aggr Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.UsdCifAggrYtdInt)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("USD CIF Aggr YTD Int")
                    .IsFixedLength();

                entity.Property(e => e.WaiveTransFee)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Waive Trans Fee?")
                    .IsFixedLength();

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Work Phone")
                    .IsFixedLength();

                entity.Property(e => e.YearsAsCustomer)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Years as Customer")
                    .IsFixedLength();

                entity.Property(e => e.YtdBondInte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YTD Bond Inte")
                    .IsFixedLength();

                entity.Property(e => e.YtdCoupons)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YTD Coupons")
                    .IsFixedLength();

                entity.Property(e => e.YtdDivIntH)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YTD Div Int H")
                    .IsFixedLength();

                entity.Property(e => e.YtdDividend)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YTD Dividend")
                    .IsFixedLength();

                entity.Property(e => e.YtdHighCifAggBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("YTD High CIF Agg Bal")
                    .IsFixedLength();

                entity.Property(e => e.YtdIntEarnedDep)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("YTD Int Earned Dep")
                    .IsFixedLength();

                entity.Property(e => e.YtdIntEarnedLoan)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("YTD Int Earned Loan")
                    .IsFixedLength();

                entity.Property(e => e.YtdIntPaidDep)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("YTD Int Paid Dep")
                    .IsFixedLength();

                entity.Property(e => e.YtdIntPaidLoan)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("YTD Int Paid Loan")
                    .IsFixedLength();

                entity.Property(e => e._10Sharehold)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("10% Sharehold")
                    .IsFixedLength();

                entity.Property(e => e._2ndAddrIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("2nd Addr Indicator")
                    .IsFixedLength();

                entity.Property(e => e._2ndLoanOfficer)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("2nd Loan Officer")
                    .IsFixedLength();
            });

            modelBuilder.Entity<CifKey>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIF_Key");

                entity.Property(e => e.ACType)
                    .HasMaxLength(255)
                    .HasColumnName("A/C Type ");

                entity.Property(e => e.AD)
                    .HasMaxLength(255)
                    .HasColumnName("A/D ");

                entity.Property(e => e.Chg).HasColumnName("CHG ");

                entity.Property(e => e.CrDb)
                    .HasMaxLength(255)
                    .HasColumnName("CR DB ");

                entity.Property(e => e.FieldDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Field Description  ");

                entity.Property(e => e.FldLen).HasColumnName("Fld Len ");

                entity.Property(e => e.FldNum).HasColumnName("Fld Num ");

                entity.Property(e => e.GLCol).HasColumnName("G/L Col ");

                entity.Property(e => e.GlClrFlg)
                    .HasMaxLength(255)
                    .HasColumnName("GL Clr Flg ");

                entity.Property(e => e.HelpDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Help Description");

                entity.Property(e => e.Inq).HasColumnName("INQ ");

                entity.Property(e => e.LastLocation).HasColumnName("Last location");

                entity.Property(e => e.Lc)
                    .HasMaxLength(255)
                    .HasColumnName("LC ");

                entity.Property(e => e.LmtCod).HasColumnName("Lmt Cod ");

                entity.Property(e => e.Upd).HasColumnName("UPD ");

                entity.Property(e => e.Usr)
                    .HasMaxLength(255)
                    .HasColumnName("USR ");

                entity.Property(e => e._1stMastLoc).HasColumnName(" 1st Mast Loc ");
            });

            modelBuilder.Entity<Comm>(entity =>
            {
                entity.HasKey(e => e.ComId);

                entity.ToTable("Comm");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Account Number")
                    .IsFixedLength();

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Account Status")
                    .IsFixedLength();

                entity.Property(e => e.AdditionalAddress)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Additional Address")
                    .IsFixedLength();

                entity.Property(e => e.AdditionalNames)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Additional Names")
                    .IsFixedLength();

                entity.Property(e => e.AdditionalNames2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Additional Names2")
                    .IsFixedLength();

                entity.Property(e => e.Address)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddressCont)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Address Cont")
                    .IsFixedLength();

                entity.Property(e => e.AddressNames)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Address/Names")
                    .IsFixedLength();

                entity.Property(e => e.AtmAchStatement)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ATM/ACH Statement")
                    .IsFixedLength();

                entity.Property(e => e.AtmLocalWDLimit)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ATM Local W/D Limit")
                    .IsFixedLength();

                entity.Property(e => e.BalInBaseCurrency)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Bal in Base Currency")
                    .IsFixedLength();

                entity.Property(e => e.BegDayAccr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Beg. Day Accr")
                    .IsFixedLength();

                entity.Property(e => e.Birthdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BranchNumber)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Branch Number")
                    .IsFixedLength();

                entity.Property(e => e.CardAccoun)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Card Accoun")
                    .IsFixedLength();

                entity.Property(e => e.CensusTract)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Census Tract")
                    .IsFixedLength();

                entity.Property(e => e.ChildSupportColl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Child SupportColl")
                    .IsFixedLength();

                entity.Property(e => e.CifNumber)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CIF Number")
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClassificationCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClearFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Clear Flag")
                    .IsFixedLength();

                entity.Property(e => e.ClosingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Closing Date")
                    .IsFixedLength();

                entity.Property(e => e.CollateralType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Collateral Type")
                    .IsFixedLength();

                entity.Property(e => e.CombinedStmtCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Combined Stmt Code")
                    .IsFixedLength();

                entity.Property(e => e.ConsumerAcctFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Consumer Acct Flag")
                    .IsFixedLength();

                entity.Property(e => e.Countr)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateLastChange)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Last Change")
                    .IsFixedLength();

                entity.Property(e => e.DateLastCustCont)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Last CustCont")
                    .IsFixedLength();

                entity.Property(e => e.DateLoaded)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Loaded")
                    .IsFixedLength();

                entity.Property(e => e.DateOfDeath)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date of Death")
                    .IsFixedLength();

                entity.Property(e => e.DateOpened)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Opened")
                    .IsFixedLength();

                entity.Property(e => e.DateZeroed)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Zeroed")
                    .IsFixedLength();

                entity.Property(e => e.DeleteCod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Delete Cod")
                    .IsFixedLength();

                entity.Property(e => e.DormantDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Dormant Date")
                    .IsFixedLength();

                entity.Property(e => e.EccBs2Code)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ECC BS2 Code")
                    .IsFixedLength();

                entity.Property(e => e.EconomicCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Economic Code")
                    .IsFixedLength();

                entity.Property(e => e.EmployeeOperator)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Employee Operator #")
                    .IsFixedLength();

                entity.Property(e => e.EndDateToUseAddr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("End Date to Use Addr")
                    .IsFixedLength();

                entity.Property(e => e.EsiStatements)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESI Statements?")
                    .IsFixedLength();

                entity.Property(e => e.ExcludeCifValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Exclude CIF Value")
                    .IsFixedLength();

                entity.Property(e => e.FdicInsuranceCat)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FDIC Insurance Cat")
                    .IsFixedLength();

                entity.Property(e => e.FirstHistory)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("First History")
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("First Name")
                    .IsFixedLength();

                entity.Property(e => e.ForeignCurrCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Foreign Curr Code")
                    .IsFixedLength();

                entity.Property(e => e.GLCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("G/L Code")
                    .IsFixedLength();

                entity.Property(e => e.HmdaCountyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("HMDA County Code")
                    .IsFixedLength();

                entity.Property(e => e.HmdaStateCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("HMDA State Code")
                    .IsFixedLength();

                entity.Property(e => e.InactiveDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Inactive Date")
                    .IsFixedLength();

                entity.Property(e => e.IndirectRelCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Indirect Rel. Code")
                    .IsFixedLength();

                entity.Property(e => e.InterestWHCert)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Interest W/H Cert")
                    .IsFixedLength();

                entity.Property(e => e.InterestWHCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Interest W/H Code")
                    .IsFixedLength();

                entity.Property(e => e.IntrstAccruedMonth)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Intrst AccruedMonth")
                    .IsFixedLength();

                entity.Property(e => e.IntrstAccruedToday)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Intrst AccruedToday")
                    .IsFixedLength();

                entity.Property(e => e.IrsCorrection)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IRS Correction?")
                    .IsFixedLength();

                entity.Property(e => e.IrsNotice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IRS Notice #")
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("Last Name")
                    .IsFixedLength();

                entity.Property(e => e.LimitedTransa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Limited Transa")
                    .IsFixedLength();

                entity.Property(e => e.MailCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Mail Code")
                    .IsFixedLength();

                entity.Property(e => e.MajorTypeCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Major Type Code")
                    .IsFixedLength();

                entity.Property(e => e.MiscCode1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Misc. Code #1")
                    .IsFixedLength();

                entity.Property(e => e.MsaCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MSA Code")
                    .IsFixedLength();

                entity.Property(e => e.MultipleSignatures)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Multiple Signatures")
                    .IsFixedLength();

                entity.Property(e => e.NewBs1Code)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("New BS1 Code")
                    .IsFixedLength();

                entity.Property(e => e.NewBs2Code)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("New BS2 Code")
                    .IsFixedLength();

                entity.Property(e => e.NewEccbBs1Code)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("New ECCB BS1 Code")
                    .IsFixedLength();

                entity.Property(e => e.NewEccbBs2Code)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("New ECCB BS2 Code")
                    .IsFixedLength();

                entity.Property(e => e.NtellerLoginsCtd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("NTeller Logins CTD")
                    .IsFixedLength();

                entity.Property(e => e.NtellerLoginsYtd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("NTeller Logins YTD")
                    .IsFixedLength();

                entity.Property(e => e.OfacReportingFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OFAC ReportingFlag")
                    .IsFixedLength();

                entity.Property(e => e.OfficerInitials)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Officer Initials")
                    .IsFixedLength();

                entity.Property(e => e.PhoneExtension)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone Extension")
                    .IsFixedLength();

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone Number")
                    .IsFixedLength();

                entity.Property(e => e.PrintStateme)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Print Stateme")
                    .IsFixedLength();

                entity.Property(e => e.PriorYearInt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Prior Year Int")
                    .IsFixedLength();

                entity.Property(e => e.ProductDefinition)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Product Definition")
                    .IsFixedLength();

                entity.Property(e => e.ProductType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Product Type")
                    .IsFixedLength();

                entity.Property(e => e.RegPOptOutFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Reg P Opt Out Flag")
                    .IsFixedLength();

                entity.Property(e => e.RelatedPartyType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Related Party Type")
                    .IsFixedLength();

                entity.Property(e => e.ReportCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Report Code")
                    .IsFixedLength();

                entity.Property(e => e.ReservedForFuture)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Reserved for Future")
                    .IsFixedLength();

                entity.Property(e => e.RestrictedAcc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Restricted Acc")
                    .IsFixedLength();

                entity.Property(e => e.RestructuredLoans)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Restructured Loans")
                    .IsFixedLength();

                entity.Property(e => e.RiskRateCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Risk Rate Code")
                    .IsFixedLength();

                entity.Property(e => e.RiskRating)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Risk Rating")
                    .IsFixedLength();

                entity.Property(e => e.Salutation)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShortName)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("Short Name")
                    .IsFixedLength();

                entity.Property(e => e.SicCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SIC Code")
                    .IsFixedLength();

                entity.Property(e => e.SsnEin)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SSN/EIN")
                    .IsFixedLength();

                entity.Property(e => e.StartDtToUseAddr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Start Dt To Use Addr")
                    .IsFixedLength();

                entity.Property(e => e.SynergyExceptions)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Synergy Exceptions?")
                    .IsFixedLength();

                entity.Property(e => e.SynergySubType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Synergy Sub Type")
                    .IsFixedLength();

                entity.Property(e => e.SynergyTrackingId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Synergy Tracking Id")
                    .IsFixedLength();

                entity.Property(e => e.TaxId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Tax Id")
                    .IsFixedLength();

                entity.Property(e => e.TickerMessage1)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Ticker Message1")
                    .IsFixedLength();

                entity.Property(e => e.TickerMessage2)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Ticker Message2")
                    .IsFixedLength();

                entity.Property(e => e.TickerMessage3)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Ticker Message3")
                    .IsFixedLength();

                entity.Property(e => e.Unused)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unused2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateAddrDates)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Update Addr Dates")
                    .IsFixedLength();

                entity.Property(e => e.UtilityPaymen)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Utility Paymen")
                    .IsFixedLength();

                entity.Property(e => e.YesterdayBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Yesterday Balance")
                    .IsFixedLength();

                entity.Property(e => e.YtdInterestA)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YTD Interest A")
                    .IsFixedLength();

                entity.Property(e => e.YtdInterestWH)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("YTD Interest W/H")
                    .IsFixedLength();

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Zip-Code")
                    .IsFixedLength();

                entity.Property(e => e._1042SRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("1042-S Required?")
                    .IsFixedLength();

                entity.Property(e => e._2ndAddress)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("2nd Address")
                    .IsFixedLength();

                entity.Property(e => e._2ndCity)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("2nd City")
                    .IsFixedLength();

                entity.Property(e => e._2ndFirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("2nd First Name")
                    .IsFixedLength();

                entity.Property(e => e._2ndLastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("2nd Last Name")
                    .IsFixedLength();

                entity.Property(e => e._2ndNameDob)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("2nd Name DOB")
                    .IsFixedLength();

                entity.Property(e => e._2ndNameOwnership)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("2nd Name Ownership?")
                    .IsFixedLength();

                entity.Property(e => e._2ndNamePhone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("2nd Name Phone#")
                    .IsFixedLength();

                entity.Property(e => e._2ndPhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("2nd Phone Number")
                    .IsFixedLength();

                entity.Property(e => e._2ndSalutation)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("2nd Salutation")
                    .IsFixedLength();

                entity.Property(e => e._2ndSsnEin)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("2nd SSN/EIN")
                    .IsFixedLength();

                entity.Property(e => e._2ndState)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("2nd State")
                    .IsFixedLength();

                entity.Property(e => e._2ndTaxId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("2nd Tax ID")
                    .IsFixedLength();

                entity.Property(e => e._2ndUsageCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("2nd Usage Code")
                    .IsFixedLength();

                entity.Property(e => e._2ndZipCode)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("2nd Zip-Code")
                    .IsFixedLength();

                entity.Property(e => e._3rdFirstName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("3rd First Name")
                    .IsFixedLength();

                entity.Property(e => e._3rdLastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("3rd Last Name")
                    .IsFixedLength();

                entity.Property(e => e._3rdNameDob)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("3rd Name DOB")
                    .IsFixedLength();

                entity.Property(e => e._3rdNameOwnership)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("3rd Name Ownership?")
                    .IsFixedLength();

                entity.Property(e => e._3rdPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("3rd Phone#")
                    .IsFixedLength();

                entity.Property(e => e._3rdSalutation)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("3rd Salutation")
                    .IsFixedLength();

                entity.Property(e => e._3rdSsnEin)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("3rd SSN/EIN")
                    .IsFixedLength();

                entity.Property(e => e._3rdTaxIdCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("3rd Tax ID Code")
                    .IsFixedLength();

                entity.Property(e => e._4thFirstName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("4th First Name")
                    .IsFixedLength();

                entity.Property(e => e._4thLastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("4th Last Name")
                    .IsFixedLength();

                entity.Property(e => e._4thNameDob)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("4th Name DOB")
                    .IsFixedLength();

                entity.Property(e => e._4thNameOwnership)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("4th Name Ownership?")
                    .IsFixedLength();

                entity.Property(e => e._4thPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("4th Phone#")
                    .IsFixedLength();

                entity.Property(e => e._4thSalutation)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("4th Salutation")
                    .IsFixedLength();

                entity.Property(e => e._4thSsnEin)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("4th SSN/EIN")
                    .IsFixedLength();

                entity.Property(e => e._4thTaxIdCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("4th Tax ID Code")
                    .IsFixedLength();

                entity.Property(e => e._66)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("66")
                    .IsFixedLength();
            });

            modelBuilder.Entity<CommonKey>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Common_Key");

                entity.Property(e => e.AD)
                    .HasMaxLength(255)
                    .HasColumnName("A/D ");

                entity.Property(e => e.Chg).HasColumnName("CHG ");

                entity.Property(e => e.CrDb)
                    .HasMaxLength(255)
                    .HasColumnName("CR DB ");

                entity.Property(e => e.FieldDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Field Description  ");

                entity.Property(e => e.FldLen).HasColumnName("Fld Len ");

                entity.Property(e => e.FldNum).HasColumnName("Fld Num ");

                entity.Property(e => e.GLCol).HasColumnName("G/L Col ");

                entity.Property(e => e.GlClrFlg)
                    .HasMaxLength(255)
                    .HasColumnName("GL Clr Flg ");

                entity.Property(e => e.HelpDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Help Description");

                entity.Property(e => e.Inq).HasColumnName("INQ ");

                entity.Property(e => e.LastLocation).HasColumnName("Last location");

                entity.Property(e => e.Lc)
                    .HasMaxLength(255)
                    .HasColumnName("LC ");

                entity.Property(e => e.LmtCod).HasColumnName("Lmt Cod ");

                entity.Property(e => e.TableType)
                    .HasMaxLength(255)
                    .HasColumnName("Table Type ");

                entity.Property(e => e.Upd).HasColumnName("UPD ");

                entity.Property(e => e.Usr)
                    .HasMaxLength(255)
                    .HasColumnName("USR ");

                entity.Property(e => e._1stMastLoc).HasColumnName(" 1st Mast Loc ");
            });

            modelBuilder.Entity<DataStage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DataStage");

                entity.Property(e => e.AccountData)
                    .HasMaxLength(3450)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Account Number")
                    .IsFixedLength();

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Account Status")
                    .IsFixedLength();

                entity.Property(e => e.AdditionalAddress)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Additional Address")
                    .IsFixedLength();

                entity.Property(e => e.AdditionalNames)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Additional Names")
                    .IsFixedLength();

                entity.Property(e => e.AdditionalNames2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Additional Names2")
                    .IsFixedLength();

                entity.Property(e => e.Address)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddressCont)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Address Cont")
                    .IsFixedLength();

                entity.Property(e => e.AddressNames)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Address/Names")
                    .IsFixedLength();

                entity.Property(e => e.AtmAchStatement)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ATM/ACH Statement")
                    .IsFixedLength();

                entity.Property(e => e.AtmLocalWDLimit)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ATM Local W/D Limit")
                    .IsFixedLength();

                entity.Property(e => e.BalInBaseCurrency)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Bal in Base Currency")
                    .IsFixedLength();

                entity.Property(e => e.BegDayAccr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Beg. Day Accr")
                    .IsFixedLength();

                entity.Property(e => e.Birthdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BranchNumber)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Branch Number")
                    .IsFixedLength();

                entity.Property(e => e.CardAccoun)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Card Accoun")
                    .IsFixedLength();

                entity.Property(e => e.CensusTract)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Census Tract")
                    .IsFixedLength();

                entity.Property(e => e.ChildSupportColl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Child SupportColl")
                    .IsFixedLength();

                entity.Property(e => e.CifNumber)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CIF Number")
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClassificationCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClearFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Clear Flag")
                    .IsFixedLength();

                entity.Property(e => e.ClosingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Closing Date")
                    .IsFixedLength();

                entity.Property(e => e.CollateralType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Collateral Type")
                    .IsFixedLength();

                entity.Property(e => e.CombinedStmtCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Combined Stmt Code")
                    .IsFixedLength();

                entity.Property(e => e.ConsumerAcctFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Consumer Acct Flag")
                    .IsFixedLength();

                entity.Property(e => e.Countr)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateLastChange)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Last Change")
                    .IsFixedLength();

                entity.Property(e => e.DateLastCustCont)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Last CustCont")
                    .IsFixedLength();

                entity.Property(e => e.DateLoaded)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Loaded")
                    .IsFixedLength();

                entity.Property(e => e.DateOfDeath)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date of Death")
                    .IsFixedLength();

                entity.Property(e => e.DateOpened)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Opened")
                    .IsFixedLength();

                entity.Property(e => e.DateZeroed)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Zeroed")
                    .IsFixedLength();

                entity.Property(e => e.DeleteCod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Delete Cod")
                    .IsFixedLength();

                entity.Property(e => e.DormantDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Dormant Date")
                    .IsFixedLength();

                entity.Property(e => e.EccBs2Code)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ECC BS2 Code")
                    .IsFixedLength();

                entity.Property(e => e.EconomicCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Economic Code")
                    .IsFixedLength();

                entity.Property(e => e.EmployeeOperator)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Employee Operator #")
                    .IsFixedLength();

                entity.Property(e => e.EndDateToUseAddr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("End Date to Use Addr")
                    .IsFixedLength();

                entity.Property(e => e.EsiStatements)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESI Statements?")
                    .IsFixedLength();

                entity.Property(e => e.ExcludeCifValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Exclude CIF Value")
                    .IsFixedLength();

                entity.Property(e => e.FdicInsuranceCat)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FDIC Insurance Cat")
                    .IsFixedLength();

                entity.Property(e => e.FirstHistory)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("First History")
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("First Name")
                    .IsFixedLength();

                entity.Property(e => e.ForeignCurrCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Foreign Curr Code")
                    .IsFixedLength();

                entity.Property(e => e.GLCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("G/L Code")
                    .IsFixedLength();

                entity.Property(e => e.HmdaCountyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("HMDA County Code")
                    .IsFixedLength();

                entity.Property(e => e.HmdaStateCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("HMDA State Code")
                    .IsFixedLength();

                entity.Property(e => e.InactiveDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Inactive Date")
                    .IsFixedLength();

                entity.Property(e => e.IndirectRelCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Indirect Rel. Code")
                    .IsFixedLength();

                entity.Property(e => e.InterestWHCert)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Interest W/H Cert")
                    .IsFixedLength();

                entity.Property(e => e.InterestWHCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Interest W/H Code")
                    .IsFixedLength();

                entity.Property(e => e.IntrstAccruedMonth)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Intrst AccruedMonth")
                    .IsFixedLength();

                entity.Property(e => e.IntrstAccruedToday)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Intrst AccruedToday")
                    .IsFixedLength();

                entity.Property(e => e.IrsCorrection)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IRS Correction?")
                    .IsFixedLength();

                entity.Property(e => e.IrsNotice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IRS Notice #")
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("Last Name")
                    .IsFixedLength();

                entity.Property(e => e.LimitedTransa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Limited Transa")
                    .IsFixedLength();

                entity.Property(e => e.MailCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Mail Code")
                    .IsFixedLength();

                entity.Property(e => e.MajorTypeCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Major Type Code")
                    .IsFixedLength();

                entity.Property(e => e.MiscCode1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Misc. Code #1")
                    .IsFixedLength();

                entity.Property(e => e.MsaCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MSA Code")
                    .IsFixedLength();

                entity.Property(e => e.MultipleSignatures)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Multiple Signatures")
                    .IsFixedLength();

                entity.Property(e => e.NewBs1Code)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("New BS1 Code")
                    .IsFixedLength();

                entity.Property(e => e.NewBs2Code)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("New BS2 Code")
                    .IsFixedLength();

                entity.Property(e => e.NewEccbBs1Code)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("New ECCB BS1 Code")
                    .IsFixedLength();

                entity.Property(e => e.NewEccbBs2Code)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("New ECCB BS2 Code")
                    .IsFixedLength();

                entity.Property(e => e.NtellerLoginsCtd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("NTeller Logins CTD")
                    .IsFixedLength();

                entity.Property(e => e.NtellerLoginsYtd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("NTeller Logins YTD")
                    .IsFixedLength();

                entity.Property(e => e.OfacReportingFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OFAC ReportingFlag")
                    .IsFixedLength();

                entity.Property(e => e.OfficerInitials)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Officer Initials")
                    .IsFixedLength();

                entity.Property(e => e.PhoneExtension)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone Extension")
                    .IsFixedLength();

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone Number")
                    .IsFixedLength();

                entity.Property(e => e.PrintStateme)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Print Stateme")
                    .IsFixedLength();

                entity.Property(e => e.PriorYearInt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Prior Year Int")
                    .IsFixedLength();

                entity.Property(e => e.ProductDefinition)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Product Definition")
                    .IsFixedLength();

                entity.Property(e => e.ProductType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Product Type")
                    .IsFixedLength();

                entity.Property(e => e.RegPOptOutFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Reg P Opt Out Flag")
                    .IsFixedLength();

                entity.Property(e => e.RelatedPartyType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Related Party Type")
                    .IsFixedLength();

                entity.Property(e => e.ReportCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Report Code")
                    .IsFixedLength();

                entity.Property(e => e.ReservedForFuture)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Reserved for Future")
                    .IsFixedLength();

                entity.Property(e => e.RestrictedAcc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Restricted Acc")
                    .IsFixedLength();

                entity.Property(e => e.RestructuredLoans)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Restructured Loans")
                    .IsFixedLength();

                entity.Property(e => e.RiskRateCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Risk Rate Code")
                    .IsFixedLength();

                entity.Property(e => e.RiskRating)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Risk Rating")
                    .IsFixedLength();

                entity.Property(e => e.Salutation)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShortName)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("Short Name")
                    .IsFixedLength();

                entity.Property(e => e.SicCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SIC Code")
                    .IsFixedLength();

                entity.Property(e => e.SsnEin)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SSN/EIN")
                    .IsFixedLength();

                entity.Property(e => e.StartDtToUseAddr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Start Dt To Use Addr")
                    .IsFixedLength();

                entity.Property(e => e.SynergyExceptions)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Synergy Exceptions?")
                    .IsFixedLength();

                entity.Property(e => e.SynergySubType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Synergy Sub Type")
                    .IsFixedLength();

                entity.Property(e => e.SynergyTrackingId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Synergy Tracking Id")
                    .IsFixedLength();

                entity.Property(e => e.TaxId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Tax Id")
                    .IsFixedLength();

                entity.Property(e => e.TickerMessage1)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Ticker Message1")
                    .IsFixedLength();

                entity.Property(e => e.TickerMessage2)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Ticker Message2")
                    .IsFixedLength();

                entity.Property(e => e.TickerMessage3)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Ticker Message3")
                    .IsFixedLength();

                entity.Property(e => e.Unused)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unused2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateAddrDates)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Update Addr Dates")
                    .IsFixedLength();

                entity.Property(e => e.UtilityPaymen)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Utility Paymen")
                    .IsFixedLength();

                entity.Property(e => e.YesterdayBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Yesterday Balance")
                    .IsFixedLength();

                entity.Property(e => e.YtdInterestA)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YTD Interest A")
                    .IsFixedLength();

                entity.Property(e => e.YtdInterestWH)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("YTD Interest W/H")
                    .IsFixedLength();

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Zip-Code")
                    .IsFixedLength();

                entity.Property(e => e._1042SRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("1042-S Required?")
                    .IsFixedLength();

                entity.Property(e => e._2ndAddress)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("2nd Address")
                    .IsFixedLength();

                entity.Property(e => e._2ndCity)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("2nd City")
                    .IsFixedLength();

                entity.Property(e => e._2ndFirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("2nd First Name")
                    .IsFixedLength();

                entity.Property(e => e._2ndLastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("2nd Last Name")
                    .IsFixedLength();

                entity.Property(e => e._2ndNameDob)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("2nd Name DOB")
                    .IsFixedLength();

                entity.Property(e => e._2ndNameOwnership)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("2nd Name Ownership?")
                    .IsFixedLength();

                entity.Property(e => e._2ndNamePhone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("2nd Name Phone#")
                    .IsFixedLength();

                entity.Property(e => e._2ndPhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("2nd Phone Number")
                    .IsFixedLength();

                entity.Property(e => e._2ndSalutation)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("2nd Salutation")
                    .IsFixedLength();

                entity.Property(e => e._2ndSsnEin)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("2nd SSN/EIN")
                    .IsFixedLength();

                entity.Property(e => e._2ndState)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("2nd State")
                    .IsFixedLength();

                entity.Property(e => e._2ndTaxId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("2nd Tax ID")
                    .IsFixedLength();

                entity.Property(e => e._2ndUsageCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("2nd Usage Code")
                    .IsFixedLength();

                entity.Property(e => e._2ndZipCode)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("2nd Zip-Code")
                    .IsFixedLength();

                entity.Property(e => e._3rdFirstName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("3rd First Name")
                    .IsFixedLength();

                entity.Property(e => e._3rdLastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("3rd Last Name")
                    .IsFixedLength();

                entity.Property(e => e._3rdNameDob)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("3rd Name DOB")
                    .IsFixedLength();

                entity.Property(e => e._3rdNameOwnership)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("3rd Name Ownership?")
                    .IsFixedLength();

                entity.Property(e => e._3rdPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("3rd Phone#")
                    .IsFixedLength();

                entity.Property(e => e._3rdSalutation)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("3rd Salutation")
                    .IsFixedLength();

                entity.Property(e => e._3rdSsnEin)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("3rd SSN/EIN")
                    .IsFixedLength();

                entity.Property(e => e._3rdTaxIdCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("3rd Tax ID Code")
                    .IsFixedLength();

                entity.Property(e => e._4thFirstName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("4th First Name")
                    .IsFixedLength();

                entity.Property(e => e._4thLastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("4th Last Name")
                    .IsFixedLength();

                entity.Property(e => e._4thNameDob)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("4th Name DOB")
                    .IsFixedLength();

                entity.Property(e => e._4thNameOwnership)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("4th Name Ownership?")
                    .IsFixedLength();

                entity.Property(e => e._4thPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("4th Phone#")
                    .IsFixedLength();

                entity.Property(e => e._4thSalutation)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("4th Salutation")
                    .IsFixedLength();

                entity.Property(e => e._4thSsnEin)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("4th SSN/EIN")
                    .IsFixedLength();

                entity.Property(e => e._4thTaxIdCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("4th Tax ID Code")
                    .IsFixedLength();

                entity.Property(e => e._66)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("66")
                    .IsFixedLength();
            });

            modelBuilder.Entity<DdaKey>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DDA_Key");

                entity.Property(e => e.ACType)
                    .HasMaxLength(255)
                    .HasColumnName("A/C Type ");

                entity.Property(e => e.AD)
                    .HasMaxLength(255)
                    .HasColumnName("A/D ");

                entity.Property(e => e.Chg).HasColumnName("CHG ");

                entity.Property(e => e.CrDb)
                    .HasMaxLength(255)
                    .HasColumnName("CR DB ");

                entity.Property(e => e.FieldDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Field Description  ");

                entity.Property(e => e.FldLen).HasColumnName("Fld Len ");

                entity.Property(e => e.FldNum).HasColumnName("Fld Num ");

                entity.Property(e => e.GLCol).HasColumnName("G/L Col ");

                entity.Property(e => e.GlClrFlg)
                    .HasMaxLength(255)
                    .HasColumnName("GL Clr Flg ");

                entity.Property(e => e.HelpDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Help Description");

                entity.Property(e => e.Inq).HasColumnName("INQ ");

                entity.Property(e => e.LastLocation).HasColumnName("Last location");

                entity.Property(e => e.Lc)
                    .HasMaxLength(255)
                    .HasColumnName("LC ");

                entity.Property(e => e.LmtCod).HasColumnName("Lmt Cod ");

                entity.Property(e => e.Upd).HasColumnName("UPD ");

                entity.Property(e => e.Usr)
                    .HasMaxLength(255)
                    .HasColumnName("USR ");

                entity.Property(e => e._1stMastLoc).HasColumnName(" 1st Mast Loc ");
            });

            modelBuilder.Entity<Ddatest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DDATest");

                entity.Property(e => e.AcctAnalysisType).HasColumnName(" Acct# Analysis Type");

                entity.Property(e => e.AcctForInterest).HasColumnName(" Acct # for Interest");

                entity.Property(e => e.AcctToTrnsfrFrom).HasColumnName(" Acct to Trnsfr From");

                entity.Property(e => e.AcctTypeForIntr).HasColumnName(" Acct Type for Intr");

                entity.Property(e => e.AchAccountNumber).HasColumnName(" ACH Account Number");

                entity.Property(e => e.AchRoutingNumber).HasColumnName(" ACH Routing Number");

                entity.Property(e => e.AchTransactionCode).HasColumnName(" ACH Transaction Code");

                entity.Property(e => e.AggrDebits).HasColumnName(" Aggr Debits");

                entity.Property(e => e.AggregateCred).HasColumnName(" Aggregate Cred");

                entity.Property(e => e.AggregateFloatAmt).HasColumnName(" Aggregate Float Amt");

                entity.Property(e => e.AggregateOdBalance).HasColumnName(" Aggregate OD Balance");

                entity.Property(e => e.AmountOfPos).HasColumnName(" Amount of POS ");

                entity.Property(e => e.AmtChargedOff).HasColumnName(" Amt Charged Off");

                entity.Property(e => e.AnalysisAmounT1).HasColumnName(" Analysis Amoun-t #1");

                entity.Property(e => e.AnalysisAmounT10).HasColumnName(" Analysis Amoun-t #10");

                entity.Property(e => e.AnalysisAmounT2).HasColumnName(" Analysis Amoun-t #2");

                entity.Property(e => e.AnalysisAmounT3).HasColumnName(" Analysis Amoun-t #3");

                entity.Property(e => e.AnalysisAmounT4).HasColumnName(" Analysis Amoun-t #4");

                entity.Property(e => e.AnalysisAmounT5).HasColumnName(" Analysis Amoun-t #5");

                entity.Property(e => e.AnalysisAmounT6).HasColumnName(" Analysis Amoun-t #6");

                entity.Property(e => e.AnalysisAmounT7).HasColumnName(" Analysis Amoun-t #7");

                entity.Property(e => e.AnalysisAmounT8).HasColumnName(" Analysis Amoun-t #8");

                entity.Property(e => e.AnalysisAmounT9).HasColumnName(" Analysis Amoun-t #9");

                entity.Property(e => e.AnalysisCounter1).HasColumnName(" Analysis Counter #1");

                entity.Property(e => e.AnalysisCounter10).HasColumnName(" Analysis Counter #10");

                entity.Property(e => e.AnalysisCounter2).HasColumnName(" Analysis Counter #2");

                entity.Property(e => e.AnalysisCounter3).HasColumnName(" Analysis Counter #3");

                entity.Property(e => e.AnalysisCounter4).HasColumnName(" Analysis Counter #4");

                entity.Property(e => e.AnalysisCounter5).HasColumnName(" Analysis Counter #5");

                entity.Property(e => e.AnalysisCounter6).HasColumnName(" Analysis Counter #6");

                entity.Property(e => e.AnalysisCounter7).HasColumnName(" Analysis Counter #7");

                entity.Property(e => e.AnalysisCounter8).HasColumnName(" Analysis Counter #8");

                entity.Property(e => e.AnalysisCounter9).HasColumnName(" Analysis Counter #9");

                entity.Property(e => e.AnalysisPrimAcct).HasColumnName(" Analysis Prim Acct#");

                entity.Property(e => e.AnalysisSettleFrq).HasColumnName(" Analysis Settle Frq");

                entity.Property(e => e.AnalysisSettlmtMo).HasColumnName(" Analysis Settlmt Mo");

                entity.Property(e => e.AprAvgBal).HasColumnName(" Apr Avg Bal");

                entity.Property(e => e.AtmCreditsCtd).HasColumnName(" Atm Credits CTD");

                entity.Property(e => e.AtmCreditsPriorYr).HasColumnName(" ATM Credits Prior Yr");

                entity.Property(e => e.AugAvgBal).HasColumnName(" Aug Avg Bal");

                entity.Property(e => e.AutoClose).HasColumnName(" Auto-Close?   ");

                entity.Property(e => e.AvailCrSafetyChk).HasColumnName(" Avail Cr Safety Chk");

                entity.Property(e => e.AvailableBalance).HasColumnName(" Available Balance");

                entity.Property(e => e.BankClubChgAmt).HasColumnName(" Bank Club Chg Amt");

                entity.Property(e => e.BankClubCode).HasColumnName(" Bank Club Code");

                entity.Property(e => e.CalcSerChargeCtd).HasColumnName(" Calc Ser Charge CTD");

                entity.Property(e => e.CardholderNumber).HasColumnName(" Cardholder Number");

                entity.Property(e => e.CashMgmtRepoFlag).HasColumnName(" Cash Mgmt Repo Flag");

                entity.Property(e => e.CdXYSCCyclTd).HasColumnName(" Cd X,Y S/C Cycl TD");

                entity.Property(e => e.ChargeOffRecovery).HasColumnName(" Charge Off Recovery");

                entity.Property(e => e.ChargedOff).HasColumnName(" Charged Off?  ");

                entity.Property(e => e.CheckSizeCode).HasColumnName(" Check Size Code");

                entity.Property(e => e.CheckTruncation).HasColumnName(" Check Truncation?");

                entity.Property(e => e.ClearingDic).HasColumnName(" Clearing DIC");

                entity.Property(e => e.ClubChargeCode).HasColumnName(" Club Charge Code");

                entity.Property(e => e.ComtelBalance).HasColumnName(" COMTEL Balance");

                entity.Property(e => e.ConsecutiveDaysOd).HasColumnName(" Consecutive Days OD");

                entity.Property(e => e.CounterChecksCtd).HasColumnName(" Counter Checks CTD");

                entity.Property(e => e.CshMgtCollBalFlg).HasColumnName(" Csh Mgt Coll Bal Flg");

                entity.Property(e => e.CtdAtmWithdrawals).HasColumnName(" CTD ATM Withdrawals");

                entity.Property(e => e.CtdAverageBalance).HasColumnName(" CTD Average Balance");

                entity.Property(e => e.CtdAverageBalance1).HasColumnName(" CTD Average Balance1");

                entity.Property(e => e.CtdAverageFl).HasColumnName(" CTD Average Fl");

                entity.Property(e => e.CtdChecks).HasColumnName(" CTD Checks");

                entity.Property(e => e.CtdCredits).HasColumnName(" CTD Credits");

                entity.Property(e => e.CtdDaysOverdrawn).HasColumnName(" CTD Days Overdrawn");

                entity.Property(e => e.CtdDebits).HasColumnName(" CTD Debits");

                entity.Property(e => e.CtdLowestBalance).HasColumnName(" CTD Lowest Balance");

                entity.Property(e => e.CtdSerChgCredits).HasColumnName(" CTD Ser Chg Credits");

                entity.Property(e => e.CtdSerChgDebits).HasColumnName(" CTD Ser Chg Debits");

                entity.Property(e => e.CurMonthCarr).HasColumnName(" Cur Month Carr");

                entity.Property(e => e.CurrentBalance).HasColumnName(" Current Balance");

                entity.Property(e => e.CurrentViolation).HasColumnName(" Current Violation");

                entity.Property(e => e.DailyODAccrual).HasColumnName(" Daily O/D Accrual");

                entity.Property(e => e.DateChargedOff).HasColumnName(" Date Charged Off");

                entity.Property(e => e.DateLastCheque).HasColumnName(" Date Last Cheque");

                entity.Property(e => e.DateLastCycled).HasColumnName(" Date Last Cycled");

                entity.Property(e => e.DateLastDeposit).HasColumnName(" Date Last Deposit");

                entity.Property(e => e.DateLastOverdraft).HasColumnName(" Date Last Overdraft");

                entity.Property(e => e.DateODExpires).HasColumnName(" Date O/D Expires");

                entity.Property(e => e.DateOfRecovery).HasColumnName(" Date of Recovery");

                entity.Property(e => e.DatePreviousStmt).HasColumnName(" Date Previous Stmt");

                entity.Property(e => e.DdaMiscFld1).HasColumnName(" DDA Misc# Fld -1");

                entity.Property(e => e.DdaMiscFld2).HasColumnName(" DDA Misc# Fld -2");

                entity.Property(e => e.DecAvgBal).HasColumnName(" Dec Avg Bal");

                entity.Property(e => e.DiscountOnSerChg).HasColumnName(" Discount on Ser Chg");

                entity.Property(e => e.DownloadAcct).HasColumnName(" Download Acct?");

                entity.Property(e => e.DsiImageDrCr).HasColumnName(" DSI Image-Dr/Cr");

                entity.Property(e => e.DsiImageFrontBck).HasColumnName(" DSI Image-Front/Bck");

                entity.Property(e => e.DsiImageHorizontal).HasColumnName(" DSI Image/Horizontal");

                entity.Property(e => e.DsiImagePgFormat).HasColumnName(" DSI Image/Pg Format");

                entity.Property(e => e.DsiImageVertical).HasColumnName(" DSI Image/Vertical");

                entity.Property(e => e.DtLstODNsf5000).HasColumnName(" DT LST O/D-NSF >5000");

                entity.Property(e => e.ExemptChgBack).HasColumnName(" Exempt Chg Back?");

                entity.Property(e => e.ExemptForAtmSC).HasColumnName(" Exempt For ATM S/C?");

                entity.Property(e => e.ExemptFromPosChg).HasColumnName(" Exempt from POS chg?");

                entity.Property(e => e.ExemptOdNsfChrg).HasColumnName(" Exempt OD/NSF Chrg");

                entity.Property(e => e.ExemptSalesTax).HasColumnName(" Exempt Sales Tax");

                entity.Property(e => e.FebAvgBal).HasColumnName(" Feb Avg Bal");

                entity.Property(e => e.FieldNotUsed).HasColumnName("FIELD NOT USED ");

                entity.Property(e => e.FixedMoneyMktRate).HasColumnName(" Fixed Money Mkt Rate");

                entity.Property(e => e.FixedSerChgAmount).HasColumnName(" Fixed Ser Chg Amount");

                entity.Property(e => e.ForeignAtmCrCtd).HasColumnName(" Foreign ATM Cr CTD");

                entity.Property(e => e.ForeignAtmCrMtd).HasColumnName(" Foreign ATM Cr MTD");

                entity.Property(e => e.ForeignAtmCrPrYr).HasColumnName(" Foreign ATM Cr Pr Yr");

                entity.Property(e => e.ForeignAtmCrYtd).HasColumnName(" Foreign ATM Cr YTD");

                entity.Property(e => e.ForeignAtmWDMtd).HasColumnName(" Foreign ATM W/D MTD");

                entity.Property(e => e.ForeignAtmWDYtd).HasColumnName(" Foreign ATM W/D YTD");

                entity.Property(e => e.ForeignAtmWDs).HasColumnName(" Foreign ATM W/Ds");

                entity.Property(e => e.ForiegnAtmWDPrY).HasColumnName(" Foriegn ATM W/D Pr Y");

                entity.Property(e => e.HighBalanceAmount).HasColumnName(" High Balance Amount");

                entity.Property(e => e.InterestDispCode).HasColumnName(" Interest Disp Code");

                entity.Property(e => e.InterestEarned).HasColumnName(" Interest Earned");

                entity.Property(e => e.InterestRate).HasColumnName(" Interest Rate");

                entity.Property(e => e.IntrEarndNot).HasColumnName(" Intr Earnd Not");

                entity.Property(e => e.JanAvgBal).HasColumnName(" Jan Avg Bal");

                entity.Property(e => e.JulAvgBal).HasColumnName(" Jul Avg Bal");

                entity.Property(e => e.JunAvgBal).HasColumnName(" Jun Avg Bal");

                entity.Property(e => e.LastChequeAm).HasColumnName(" Last Cheque Am");

                entity.Property(e => e.LastDepositA).HasColumnName(" Last Deposit A");

                entity.Property(e => e.LastStmtBalance).HasColumnName(" Last Stmt Balance");

                entity.Property(e => e.LoanLossProv).HasColumnName(" Loan Loss Prov");

                entity.Property(e => e.LowBalanceAmount).HasColumnName(" Low Balance Amount");

                entity.Property(e => e.LowBalanceMtd).HasColumnName(" Low Balance MTD");

                entity.Property(e => e.LowCollectedBal).HasColumnName(" Low Collected Bal");

                entity.Property(e => e.MarAvgBal).HasColumnName(" Mar Avg Bal");

                entity.Property(e => e.MaximumServCharge).HasColumnName(" Maximum Serv Charge");

                entity.Property(e => e.MayAvgBal).HasColumnName(" May Avg Bal");

                entity.Property(e => e.MemoBalance).HasColumnName(" Memo Balance");

                entity.Property(e => e.MiscField2).HasColumnName(" Misc Field 2");

                entity.Property(e => e.MiscField3).HasColumnName(" Misc Field 3");

                entity.Property(e => e.MtdAggBal).HasColumnName(" MTD Agg Bal");

                entity.Property(e => e.MtdAggrBalan).HasColumnName(" MTD Aggr Balan");

                entity.Property(e => e.MtdCredCnt).HasColumnName(" MTD Cred#Cnt# ");

                entity.Property(e => e.MtdCreditTot).HasColumnName(" MTD Credit Tot");

                entity.Property(e => e.MtdHiBal).HasColumnName(" MTD Hi Bal");

                entity.Property(e => e.MultiStmtGrenada).HasColumnName(" Multi-Stmt(Grenada)");

                entity.Property(e => e.NovAvgBal).HasColumnName(" Nov Avg Bal");

                entity.Property(e => e.NsfItemFee).HasColumnName(" NSF Item Fee");

                entity.Property(e => e.NsfReversedPyr).HasColumnName(" NSF Reversed PYr");

                entity.Property(e => e.NsfReversedYtd).HasColumnName(" NSF Reversed YTD");

                entity.Property(e => e.NsfWaivedOperPyr).HasColumnName(" NSF Waived Oper PYr");

                entity.Property(e => e.NsfWaivedOperYtd).HasColumnName(" NSF Waived Oper YTD");

                entity.Property(e => e.NsfWaivedPyrAcct).HasColumnName(" NSF Waived PYr Acct");

                entity.Property(e => e.NsfWaivedYtdAcct).HasColumnName(" NSF Waived YTD Acct");

                entity.Property(e => e.NumberOfPosPrYr).HasColumnName(" Number of POS Pr Yr#");

                entity.Property(e => e.ODDaysLastYear).HasColumnName(" O/D Days Last Year");

                entity.Property(e => e.ODIntRateAdj).HasColumnName(" O/D Int Rate Adj");

                entity.Property(e => e.ODIntRateCode).HasColumnName(" O/D Int Rate Code");

                entity.Property(e => e.ODInterest).HasColumnName(" O/D Interest");

                entity.Property(e => e.ODInterestCode).HasColumnName(" O/D Interest Code");

                entity.Property(e => e.ODIntrstPai).HasColumnName(" O/D Intrst Pai");

                entity.Property(e => e.ODLimitWhole).HasColumnName(" O/D Limit (Whole $)");

                entity.Property(e => e.ODOrNsfCurMo).HasColumnName(" # O/D OR NSF CUR MO");

                entity.Property(e => e.ODOrNsfPrevMo).HasColumnName(" # O/D OR NSF PREV MO");

                entity.Property(e => e.ODOrNsfPrevMo2).HasColumnName(" #O/D OR NSF PREV MO2");

                entity.Property(e => e.ODOrNsfPrevMo3).HasColumnName(" #O/D OR NSF PREV MO3");

                entity.Property(e => e.ODOrNsfPrevMo4).HasColumnName(" #O/D OR NSF PREV MO4");

                entity.Property(e => e.ODOrNsfPrevMo5).HasColumnName(" #O/D OR NSF PREV MO5");

                entity.Property(e => e.ODOrNsfPrevMo6).HasColumnName(" #O/D OR NSF PREV MO6");

                entity.Property(e => e.ODPenaltyRate).HasColumnName(" O/D Penalty Rate");

                entity.Property(e => e.OctAvgBal).HasColumnName(" Oct Avg Bal");

                entity.Property(e => e.OdLoanPymtFlag).HasColumnName(" OD Loan Pymt Flag");

                entity.Property(e => e.OdType).HasColumnName(" OD Type");

                entity.Property(e => e.OnUsDic).HasColumnName(" On-Us DIC");

                entity.Property(e => e.OpenDepAmt).HasColumnName(" Open Dep Amt");

                entity.Property(e => e.Over15DayFl).HasColumnName(" Over 15 Day Fl");

                entity.Property(e => e.OverdraftRate).HasColumnName(" Overdraft Rate");

                entity.Property(e => e.PersMmdaTrans).HasColumnName(" Pers MMDA Trans");

                entity.Property(e => e.PosAmountLas).HasColumnName(" POS Amount Las");

                entity.Property(e => e.PosAmountMtd).HasColumnName(" POS Amount MTD");

                entity.Property(e => e.PosTransCtd).HasColumnName(" # POS TRANS CTD");

                entity.Property(e => e.PosTransactionsMtd).HasColumnName(" POS Transactions MTD");

                entity.Property(e => e.PosTransactionsYtd).HasColumnName(" POS Transactions YTD");

                entity.Property(e => e.PrevCycleCode).HasColumnName(" Prev Cycle Code");

                entity.Property(e => e.PrevExcessViol).HasColumnName(" Prev Excess Viol");

                entity.Property(e => e.PrevSerChgCode).HasColumnName(" Prev Ser Chg Code");

                entity.Property(e => e.PrevYearCredits).HasColumnName(" Prev Year Credits");

                entity.Property(e => e.PrevYearNsfChks).HasColumnName(" Prev Year NSF Chks");

                entity.Property(e => e.PrevYearNsfItems).HasColumnName(" Prev Year NSF Items");

                entity.Property(e => e.PrevYrAverageBal).HasColumnName(" Prev Yr Average Bal");

                entity.Property(e => e.PrevYrNsfReturns).HasColumnName(" Prev Yr NSF Returns");

                entity.Property(e => e.PreviousStmtBal).HasColumnName(" Previous Stmt Bal");

                entity.Property(e => e.PreviousYearDebits).HasColumnName(" Previous Year Debits");

                entity.Property(e => e.PriorDayUncollBal).HasColumnName(" Prior Day Uncoll Bal");

                entity.Property(e => e.PrvMonthCarr).HasColumnName(" Prv Month Carr");

                entity.Property(e => e.QtdHighBalance).HasColumnName(" QTD High Balance");

                entity.Property(e => e.QtdHighODBal).HasColumnName(" QTD High O/D Bal");

                entity.Property(e => e.QtdIntrstExp).HasColumnName(" QTD Intrst Exp-");

                entity.Property(e => e.QtdIntrstInc).HasColumnName(" QTD Intrst Inc-");

                entity.Property(e => e.RateCode).HasColumnName(" Rate Code");

                entity.Property(e => e.SChgsReversedPyr).HasColumnName(" S/Chgs Reversed PYr");

                entity.Property(e => e.SChgsReversedYtd).HasColumnName(" S/Chgs Reversed YTD");

                entity.Property(e => e.SecurityCodes).HasColumnName(" Security Codes");

                entity.Property(e => e.SecurityValue).HasColumnName(" Security Value");

                entity.Property(e => e.SepAvgBal).HasColumnName(" Sep Avg Bal");

                entity.Property(e => e.SerChgRunningBal).HasColumnName(" Ser Chg Running Bal");

                entity.Property(e => e.SerChgsWaivedLYr).HasColumnName(" Ser Chgs Waived L/YR");

                entity.Property(e => e.SerChgsWaivedYtd).HasColumnName(" Ser Chgs Waived YTD");

                entity.Property(e => e.SerChrgWaiveDate).HasColumnName(" Ser Chrg Waive Date");

                entity.Property(e => e.ServiceChargeCode).HasColumnName(" Service Charge Code");

                entity.Property(e => e.ServiceChgWaiveCd).HasColumnName(" Service Chg Waive Cd");

                entity.Property(e => e.SpecPostageSC).HasColumnName(" Spec Postage S/C?");

                entity.Property(e => e.SpecificProv).HasColumnName(" Specific Prov");

                entity.Property(e => e.StatementRequest).HasColumnName(" Statement Request");

                entity.Property(e => e.StatementSortCode).HasColumnName(" Statement Sort Code");

                entity.Property(e => e.StmtCycleCode).HasColumnName(" Stmt Cycle Code");

                entity.Property(e => e.StmtMessageCode).HasColumnName(" Stmt Message Code");

                entity.Property(e => e.StmtSrtPrAcctFlg).HasColumnName(" Stmt Srt Pr Acct Flg");

                entity.Property(e => e.StopPyAutoChgFlg).HasColumnName(" Stop Py Auto Chg Flg");

                entity.Property(e => e.StopPyNoticeFlag).HasColumnName(" Stop Py Notice Flag");

                entity.Property(e => e.TargetBalance).HasColumnName(" Target Balance");

                entity.Property(e => e.TotInclearings).HasColumnName(" Tot Inclearings");

                entity.Property(e => e.TotTransferDebits).HasColumnName(" Tot Transfer Debits");

                entity.Property(e => e.TotalAtmCreditMtd).HasColumnName(" Total ATM Credit MTD");

                entity.Property(e => e.TotalAtmWDMtd).HasColumnName(" Total ATM W/D MTD");

                entity.Property(e => e.TotalAtmWDPrYr).HasColumnName(" Total ATM W/D Pr Yr#");

                entity.Property(e => e.TotalAtmWDYtd).HasColumnName(" Total ATM W/D YTD");

                entity.Property(e => e.TotlAtmCreditsYtd).HasColumnName(" Totl ATM Credits YTD");

                entity.Property(e => e.TransferFromType).HasColumnName(" Transfer From Type");

                entity.Property(e => e.TransferOutAmount).HasColumnName(" Transfer Out Amount");

                entity.Property(e => e.TransferToAccount).HasColumnName(" Transfer To Account");

                entity.Property(e => e.TransferToType).HasColumnName(" Transfer To Type");

                entity.Property(e => e.TransitDic).HasColumnName(" Transit DIC");

                entity.Property(e => e.TrnsfrSCIn).HasColumnName(" Trnsfr S/C In");

                entity.Property(e => e.TrnsfrSCOut).HasColumnName(" Trnsfr S/C Out");

                entity.Property(e => e.TypeCode).HasColumnName(" Type Code");

                entity.Property(e => e.UncollectedBalance).HasColumnName(" Uncollected Balance");

                entity.Property(e => e.UnpostToday).HasColumnName(" UNPOST Today");

                entity.Property(e => e.ViolationHistory).HasColumnName(" Violation History");

                entity.Property(e => e.YtdAverageBalance).HasColumnName(" YTD Average Balance");

                entity.Property(e => e.YtdAverageBalance1).HasColumnName(" YTD Average Balance1");

                entity.Property(e => e.YtdAverageCo).HasColumnName(" YTD Average Co");

                entity.Property(e => e.YtdClringItemCnt).HasColumnName(" YTD Clring Item Cnt");

                entity.Property(e => e.YtdCredits).HasColumnName(" YTD Credits");

                entity.Property(e => e.YtdDebits).HasColumnName(" YTD Debits");

                entity.Property(e => e.YtdHiBal).HasColumnName(" YTD Hi Bal");

                entity.Property(e => e.YtdInterestP).HasColumnName(" YTD Interest P");

                entity.Property(e => e.YtdNsfChecks).HasColumnName(" YTD NSF Checks");

                entity.Property(e => e.YtdNsfPresented).HasColumnName(" YTD NSF Presented");

                entity.Property(e => e.YtdNsfReturns).HasColumnName(" YTD NSF Returns");

                entity.Property(e => e.YtdODDays).HasColumnName(" YTD O/D Days  ");

                entity.Property(e => e.YtdODIntEa).HasColumnName(" YTD O/D Int Ea");

                entity.Property(e => e.YtdServiceCh).HasColumnName(" YTD Service Ch");

                entity.Property(e => e.YtdTransitItmCnt).HasColumnName(" YTD Transit Itm Cnt");

                entity.Property(e => e._1115DayFloa).HasColumnName(" 11-15 Day Floa");

                entity.Property(e => e._1DayFloatAm).HasColumnName(" 1 Day Float Am");

                entity.Property(e => e._2DayFloatAm).HasColumnName(" 2 Day Float Am");

                entity.Property(e => e._2ndTransferToAcct).HasColumnName(" 2nd Transfer To Acct");

                entity.Property(e => e._2ndTransferToType).HasColumnName(" 2nd Transfer To Type");

                entity.Property(e => e._2ndTrfFromAcct).HasColumnName(" 2nd Trf From Acct");

                entity.Property(e => e._2ndTrfFromType).HasColumnName(" 2nd Trf From Type");

                entity.Property(e => e._3DayFloatAm).HasColumnName(" 3 Day Float Am");

                entity.Property(e => e._45DayFloat).HasColumnName(" 4-5 Day Float ");

                entity.Property(e => e._610DayFloat).HasColumnName(" 6-10 Day Float");
            });

            modelBuilder.Entity<Ddum>(entity =>
            {
                entity.HasKey(e => e.DdaId);

                entity.ToTable("DDA");

                entity.Property(e => e.DdaId).HasColumnName("DDA_ID");

                entity.Property(e => e.AccountBypassEip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Account Bypass EIP")
                    .IsFixedLength();

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Account_Number")
                    .IsFixedLength();

                entity.Property(e => e.AccrIntAtNonPerf)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Accr Int at Non-Perf")
                    .IsFixedLength();

                entity.Property(e => e.AcctAnalysisType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Acct. Analysis Type")
                    .IsFixedLength();

                entity.Property(e => e.AcctForInterest)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Acct # for Interest")
                    .IsFixedLength();

                entity.Property(e => e.AcctToTrnsfrFrom)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Acct to Trnsfr From")
                    .IsFixedLength();

                entity.Property(e => e.AcctTypeForIntr)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Acct Type for Intr")
                    .IsFixedLength();

                entity.Property(e => e.AchAccountNumber)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("ACH Account Number")
                    .IsFixedLength();

                entity.Property(e => e.AchPositivePay)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACH Positive Pay?")
                    .IsFixedLength();

                entity.Property(e => e.AchRoutingNumber)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ACH Routing Number")
                    .IsFixedLength();

                entity.Property(e => e.AchTransactionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ACH Transaction Code")
                    .IsFixedLength();

                entity.Property(e => e.AggrDebits)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Aggr Debits")
                    .IsFixedLength();

                entity.Property(e => e.AggregateCre)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Aggregate Cre")
                    .IsFixedLength();

                entity.Property(e => e.AggregateFloatAmt)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Aggregate Float Amt")
                    .IsFixedLength();

                entity.Property(e => e.AggregateOdBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Aggregate OD Balance")
                    .IsFixedLength();

                entity.Property(e => e.AmountOfPos)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Amount of POS")
                    .IsFixedLength();

                entity.Property(e => e.AmtChargedOff)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Amt Charged Off")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisAmounT1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Amoun-t #1")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisAmounT10)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Amoun-t #10")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisAmounT2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Amoun-t #2")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisAmounT3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Amoun-t #3")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisAmounT4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Amoun-t #4")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisAmounT5)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Amoun-t #5")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisAmounT6)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Amoun-t #6")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisAmounT7)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Amoun-t #7")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisAmounT8)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Amoun-t #8")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisAmounT9)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Amoun-t #9")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisCounter1)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Counter #1")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisCounter10)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Counter #10")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisCounter2)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Counter #2")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisCounter3)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Counter #3")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisCounter4)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Counter #4")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisCounter5)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Counter #5")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisCounter6)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Counter #6")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisCounter7)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Counter #7")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisCounter8)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Counter #8")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisCounter9)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Counter #9")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisPrimAcct)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Prim Acct#")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisSettleFrq)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Settle Frq")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisSettlmtMo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Analysis Settlmt Mo")
                    .IsFixedLength();

                entity.Property(e => e.AprAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Apr Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.AtmCreditsCtd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Atm Credits CTD")
                    .IsFixedLength();

                entity.Property(e => e.AtmCreditsPriorYr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ATM Credits Prior Yr")
                    .IsFixedLength();

                entity.Property(e => e.AtmUsageCreditCtd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ATM Usage Credit CTD")
                    .IsFixedLength();

                entity.Property(e => e.AugAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Aug Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.AutoClose)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Auto-Close?")
                    .IsFixedLength();

                entity.Property(e => e.AutoNonPerforming)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Auto Non-Performing")
                    .IsFixedLength();

                entity.Property(e => e.AvailCrSafetyChk)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Avail Cr Safety Chk")
                    .IsFixedLength();

                entity.Property(e => e.AvailableBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Available Balance")
                    .IsFixedLength();

                entity.Property(e => e.BankClubChgAmt)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Bank Club Chg Amt")
                    .IsFixedLength();

                entity.Property(e => e.BankClubCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Bank Club Code")
                    .IsFixedLength();

                entity.Property(e => e.BeginningBalToday)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Beginning Bal Today")
                    .IsFixedLength();

                entity.Property(e => e.BillPayEnrollDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Bill Pay Enroll Date")
                    .IsFixedLength();

                entity.Property(e => e.BillPaySCCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Bill Pay S/C Code")
                    .IsFixedLength();

                entity.Property(e => e.BillPaySCCycles)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Bill Pay S/C Cycles")
                    .IsFixedLength();

                entity.Property(e => e.BillPayTotalTrans)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Bill Pay Total Trans")
                    .IsFixedLength();

                entity.Property(e => e.BillPayTransCtd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Bill Pay Trans CTD")
                    .IsFixedLength();

                entity.Property(e => e.BncAmountNsfQtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BNC Amount NSF QTD")
                    .IsFixedLength();

                entity.Property(e => e.BncAmtNsfLastQtr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BNC AMt NSF Last Qtr")
                    .IsFixedLength();

                entity.Property(e => e.BncDateActivated)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BNC Date Activated")
                    .IsFixedLength();

                entity.Property(e => e.BncDaysODLife)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("BNC Days O/D Life")
                    .IsFixedLength();

                entity.Property(e => e.BncDaysODLstQtr)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BNC Days O/D Lst Qtr")
                    .IsFixedLength();

                entity.Property(e => e.BncDaysODQtd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BNC Days O/D QTD")
                    .IsFixedLength();

                entity.Property(e => e.BncDtLstExcLtr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BNC Dt Lst Exc Ltr")
                    .IsFixedLength();

                entity.Property(e => e.BncExcUseLtrPrt)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BNC Exc Use Ltr Prt")
                    .IsFixedLength();

                entity.Property(e => e.BncExcUseLtrs)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BNC # Exc Use Ltrs")
                    .IsFixedLength();

                entity.Property(e => e.BncForceLetter)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BNC Force Letter #")
                    .IsFixedLength();

                entity.Property(e => e.BncFsAccountNbr)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("BNC FS Account Nbr")
                    .IsFixedLength();

                entity.Property(e => e.BncFsAcctBalance)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BNC FS Acct Balance")
                    .IsFixedLength();

                entity.Property(e => e.BncLetter1Sent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BNC Letter 1 Sent")
                    .IsFixedLength();

                entity.Property(e => e.BncLetter2Sent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BNC Letter 2 Sent")
                    .IsFixedLength();

                entity.Property(e => e.BncLetter3Sent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BNC Letter 3 Sent")
                    .IsFixedLength();

                entity.Property(e => e.BncLetter4Sent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BNC Letter 4 Sent")
                    .IsFixedLength();

                entity.Property(e => e.BncLetter5Sent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BNC Letter 5 Sent")
                    .IsFixedLength();

                entity.Property(e => e.BncLetter6Sent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BNC Letter 6 Sent")
                    .IsFixedLength();

                entity.Property(e => e.BncLetter7Sent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BNC Letter 7 Sent")
                    .IsFixedLength();

                entity.Property(e => e.BncLetter8Sent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BNC Letter 8 Sent")
                    .IsFixedLength();

                entity.Property(e => e.BncLetter9Sent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BNC Letter 9 Sent")
                    .IsFixedLength();

                entity.Property(e => e.BncLockedLimit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BNC Locked Limit")
                    .IsFixedLength();

                entity.Property(e => e.BncLtrPrintToday)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BNC Ltr Print Today")
                    .IsFixedLength();

                entity.Property(e => e.BncMailLetters)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BNC Mail Letters?")
                    .IsFixedLength();

                entity.Property(e => e.BncMailNotices)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BNC Mail Notices?")
                    .IsFixedLength();

                entity.Property(e => e.BncNsfItemsLife)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BNC NSF Items Life")
                    .IsFixedLength();

                entity.Property(e => e.BncNsfItmsLstQtr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("BNC NSF Itms Lst Qtr")
                    .IsFixedLength();

                entity.Property(e => e.BncNsfItmsQtd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("BNC NSF Itms QTD")
                    .IsFixedLength();

                entity.Property(e => e.BncPlanCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BNC Plan Code")
                    .IsFixedLength();

                entity.Property(e => e.BncPortionDlyFee)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BNC Portion Dly Fee")
                    .IsFixedLength();

                entity.Property(e => e.BncPortionPdItems)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BNC Portion Pd Items")
                    .IsFixedLength();

                entity.Property(e => e.BncPortionSC)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BNC Portion S/C")
                    .IsFixedLength();

                entity.Property(e => e.BncPortionTrnFees)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BNC Portion Trn Fees")
                    .IsFixedLength();

                entity.Property(e => e.BncPostStatusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BNC Post Status Code")
                    .IsFixedLength();

                entity.Property(e => e.BncShowInNsfprc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BNC Show in NSFPRC")
                    .IsFixedLength();

                entity.Property(e => e.BncStatusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BNC Status Code")
                    .IsFixedLength();

                entity.Property(e => e.BncTimeODLstQtr)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BNC Time O/D Lst Qtr")
                    .IsFixedLength();

                entity.Property(e => e.BncTimesInFs)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BNC # Times in FS")
                    .IsFixedLength();

                entity.Property(e => e.BncTimesODQtd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BNC Times O/D QTD")
                    .IsFixedLength();

                entity.Property(e => e.BounceChgPriorYr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Bounce Chg Prior Yr")
                    .IsFixedLength();

                entity.Property(e => e.CalcSerChargeCtd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Calc Ser Charge CTD")
                    .IsFixedLength();

                entity.Property(e => e.CardholderNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Cardholder Number")
                    .IsFixedLength();

                entity.Property(e => e.CashMgmtOverdraw)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Cash Mgmt Overdraw")
                    .IsFixedLength();

                entity.Property(e => e.CashMgmtRepoFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Cash Mgmt Repo Flag")
                    .IsFixedLength();

                entity.Property(e => e.CashSecurity)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Cash Security")
                    .IsFixedLength();

                entity.Property(e => e.CdXYSCCyclTd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Cd X,Y S/C Cycl TD")
                    .IsFixedLength();

                entity.Property(e => e.ChargeOffRecovery)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Charge Off Recovery")
                    .IsFixedLength();

                entity.Property(e => e.ChargedOff)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Charged Off?")
                    .IsFixedLength();

                entity.Property(e => e.CheckNumberGap)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Check Number Gap?")
                    .IsFixedLength();

                entity.Property(e => e.CheckSizeCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Check Size Code")
                    .IsFixedLength();

                entity.Property(e => e.CheckTruncation)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Check Truncation?")
                    .IsFixedLength();

                entity.Property(e => e.ClearingDic)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Clearing DIC")
                    .IsFixedLength();

                entity.Property(e => e.ClubChargeCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Club Charge Code")
                    .IsFixedLength();

                entity.Property(e => e.CollectedBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Collected Balance")
                    .IsFixedLength();

                entity.Property(e => e.ComtelBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("COMTEL Balance")
                    .IsFixedLength();

                entity.Property(e => e.ConsecutiveDaysOd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Consecutive Days OD")
                    .IsFixedLength();

                entity.Property(e => e.CounterChecksCtd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Counter Checks CTD")
                    .IsFixedLength();

                entity.Property(e => e.CshMgmtFloatSweep)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Csh Mgmt Float Sweep")
                    .IsFixedLength();

                entity.Property(e => e.CshMgmtProcessLvl)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Csh Mgmt Process Lvl")
                    .IsFixedLength();

                entity.Property(e => e.CshMgtCollBalFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Csh Mgt Coll Bal Flg")
                    .IsFixedLength();

                entity.Property(e => e.CtdAchCredits)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CTD ACH Credits")
                    .IsFixedLength();

                entity.Property(e => e.CtdAchDebits)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CTD ACH Debits")
                    .IsFixedLength();

                entity.Property(e => e.CtdAtmWithdrawals)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CTD ATM Withdrawals")
                    .IsFixedLength();

                entity.Property(e => e.CtdAverageBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CTD Average Balance")
                    .IsFixedLength();

                entity.Property(e => e.CtdAverageBalanceYtd)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CTD Average Balance YTD")
                    .IsFixedLength();

                entity.Property(e => e.CtdAverageF)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CTD Average F")
                    .IsFixedLength();

                entity.Property(e => e.CtdChecks)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CTD Checks")
                    .IsFixedLength();

                entity.Property(e => e.CtdCredits)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CTD Credits")
                    .IsFixedLength();

                entity.Property(e => e.CtdDaysOverdrawn)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CTD Days Overdrawn")
                    .IsFixedLength();

                entity.Property(e => e.CtdDebits)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CTD Debits")
                    .IsFixedLength();

                entity.Property(e => e.CtdElectrncCredits)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CTD Electrnc Credits")
                    .IsFixedLength();

                entity.Property(e => e.CtdElectrncDebits)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CTD Electrnc Debits")
                    .IsFixedLength();

                entity.Property(e => e.CtdLowestBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CTD Lowest Balance")
                    .IsFixedLength();

                entity.Property(e => e.CtdPosPinBased)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CTD POS Pin Based")
                    .IsFixedLength();

                entity.Property(e => e.CtdPosSignature)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CTD POS Signature")
                    .IsFixedLength();

                entity.Property(e => e.CtdSerChgCredits)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CTD Ser Chg Credits")
                    .IsFixedLength();

                entity.Property(e => e.CtdSerChgDebits)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CTD Ser Chg Debits")
                    .IsFixedLength();

                entity.Property(e => e.CurMonthCar)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cur Month Car")
                    .IsFixedLength();

                entity.Property(e => e.CurrentBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Current Balance")
                    .IsFixedLength();

                entity.Property(e => e.CurrentViolation)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Current Violation")
                    .IsFixedLength();

                entity.Property(e => e.DailyODAccrual)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Daily O/D Accrual")
                    .IsFixedLength();

                entity.Property(e => e.DailyWireLi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Daily Wire Li")
                    .IsFixedLength();

                entity.Property(e => e.DatalinkMtdVceInq)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Datalink MTD Vce Inq")
                    .IsFixedLength();

                entity.Property(e => e.DatalinkYtdVceInq)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Datalink YTD Vce Inq")
                    .IsFixedLength();

                entity.Property(e => e.DateChargedOff)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Charged Off")
                    .IsFixedLength();

                entity.Property(e => e.DateLastCheque)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Last Cheque")
                    .IsFixedLength();

                entity.Property(e => e.DateLastCycled)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Last Cycled")
                    .IsFixedLength();

                entity.Property(e => e.DateLastDeposit)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Last Deposit")
                    .IsFixedLength();

                entity.Property(e => e.DateLastOverdraft)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Last Overdraft")
                    .IsFixedLength();

                entity.Property(e => e.DateLstEvaluation)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Lst Evaluation")
                    .IsFixedLength();

                entity.Property(e => e.DateLstStmPrinted)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Lst Stm Printed")
                    .IsFixedLength();

                entity.Property(e => e.DateODExpires)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date O/D Expires")
                    .IsFixedLength();

                entity.Property(e => e.DateOfRecovery)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date of Recovery")
                    .IsFixedLength();

                entity.Property(e => e.DatePreviousStmt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Previous Stmt")
                    .IsFixedLength();

                entity.Property(e => e.DaysPastMaturity)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Days Past Maturity")
                    .IsFixedLength();

                entity.Property(e => e.DdaMiscFld1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DDA Misc. Fld -1")
                    .IsFixedLength();

                entity.Property(e => e.DdaMiscFld2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DDA Misc. Fld -2")
                    .IsFixedLength();

                entity.Property(e => e.DecAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Dec Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.DiscountOnSerChg)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Discount on Ser Chg")
                    .IsFixedLength();

                entity.Property(e => e.DownloadAcct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Download Acct?")
                    .IsFixedLength();

                entity.Property(e => e.DsiImageDrCr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DSI Image-Dr/Cr")
                    .IsFixedLength();

                entity.Property(e => e.DsiImageFrontBck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DSI Image-Front/Bck")
                    .IsFixedLength();

                entity.Property(e => e.DsiImageHorizontal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DSI Image/Horizontal")
                    .IsFixedLength();

                entity.Property(e => e.DsiImagePgFormat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DSI Image/Pg Format")
                    .IsFixedLength();

                entity.Property(e => e.DsiImageVertical)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DSI Image/Vertical")
                    .IsFixedLength();

                entity.Property(e => e.DtLstODNsf5000)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DT LST O/D-NSF >5000")
                    .IsFixedLength();

                entity.Property(e => e.ExcludeCredBureau)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Exclude Cred Bureau")
                    .IsFixedLength();

                entity.Property(e => e.ExcludeFromPayall)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Exclude From Payall?")
                    .IsFixedLength();

                entity.Property(e => e.ExemptAutoChgOff)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Exempt Auto-Chg Off?")
                    .IsFixedLength();

                entity.Property(e => e.ExemptChgBack)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Exempt Chg Back?")
                    .IsFixedLength();

                entity.Property(e => e.ExemptForAtmSC)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Exempt For ATM S/C?")
                    .IsFixedLength();

                entity.Property(e => e.ExemptFromPosChg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Exempt from POS chg?")
                    .IsFixedLength();

                entity.Property(e => e.ExemptOdNsfChrg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Exempt OD/NSF Chrg")
                    .IsFixedLength();

                entity.Property(e => e.ExemptSalesTax)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Exempt Sales Tax")
                    .IsFixedLength();

                entity.Property(e => e.ExpandedSCCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Expanded S/C Code")
                    .IsFixedLength();

                entity.Property(e => e.FebAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Feb Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.FieldNotUsed)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("FIELD NOT USED")
                    .IsFixedLength();

                entity.Property(e => e.FixedMoneyMktRate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Fixed Money Mkt Rate")
                    .IsFixedLength();

                entity.Property(e => e.FixedSerChgAmount)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Fixed Ser Chg Amount")
                    .IsFixedLength();

                entity.Property(e => e.ForeignAtmCrCtd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Foreign ATM Cr CTD")
                    .IsFixedLength();

                entity.Property(e => e.ForeignAtmCrMtd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Foreign ATM Cr MTD")
                    .IsFixedLength();

                entity.Property(e => e.ForeignAtmCrPrYr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Foreign ATM Cr Pr Yr")
                    .IsFixedLength();

                entity.Property(e => e.ForeignAtmCrYtd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Foreign ATM Cr YTD")
                    .IsFixedLength();

                entity.Property(e => e.ForeignAtmWDMtd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Foreign ATM W/D MTD")
                    .IsFixedLength();

                entity.Property(e => e.ForeignAtmWDYtd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Foreign ATM W/D YTD")
                    .IsFixedLength();

                entity.Property(e => e.ForeignAtmWDs)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Foreign ATM W/Ds")
                    .IsFixedLength();

                entity.Property(e => e.ForiegnAtmWDPrY)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Foriegn ATM W/D Pr Y")
                    .IsFixedLength();

                entity.Property(e => e.FraudAlertFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Fraud Alert Flag")
                    .IsFixedLength();

                entity.Property(e => e.HighBalanceAmount)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("High Balance Amount")
                    .IsFixedLength();

                entity.Property(e => e.IncludeAchIndId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Include ACH Ind ID#")
                    .IsFixedLength();

                entity.Property(e => e.InterestDispCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Interest Disp Code")
                    .IsFixedLength();

                entity.Property(e => e.InterestEarned)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Interest Earned")
                    .IsFixedLength();

                entity.Property(e => e.InterestRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Interest Rate")
                    .IsFixedLength();

                entity.Property(e => e.InterestRateAdj)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Interest Rate Adj")
                    .IsFixedLength();

                entity.Property(e => e.IntrEarndNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Intr Earnd No")
                    .IsFixedLength();

                entity.Property(e => e.JanAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Jan Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.JulAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Jul Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.JunAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Jun Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.LastChequeA)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Last Cheque A")
                    .IsFixedLength();

                entity.Property(e => e.LastDeposit)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Last Deposit")
                    .IsFixedLength();

                entity.Property(e => e.LastStmtBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Last Stmt Balance")
                    .IsFixedLength();

                entity.Property(e => e.LoanLossProv)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Loan Loss Prov")
                    .IsFixedLength();

                entity.Property(e => e.LowBalanceAmount)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Low Balance Amount")
                    .IsFixedLength();

                entity.Property(e => e.LowBalanceMtd)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Low Balance MTD")
                    .IsFixedLength();

                entity.Property(e => e.LowCollectedBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Low Collected Bal")
                    .IsFixedLength();

                entity.Property(e => e.MarAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Mar Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.MaximumServCharge)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Maximum Serv Charge")
                    .IsFixedLength();

                entity.Property(e => e.MayAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("May Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.MemoBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Memo Balance")
                    .IsFixedLength();

                entity.Property(e => e.Metro2AddrIndic)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Metro 2 Addr Indic")
                    .IsFixedLength();

                entity.Property(e => e.Metro2CondCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Metro 2 Cond Code")
                    .IsFixedLength();

                entity.Property(e => e.Metro2EcoaCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Metro 2 ECOA Code")
                    .IsFixedLength();

                entity.Property(e => e.MiscField2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Misc Field 2")
                    .IsFixedLength();

                entity.Property(e => e.MiscField3)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Misc Field 3")
                    .IsFixedLength();

                entity.Property(e => e.MtdAggBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("MTD Agg Bal")
                    .IsFixedLength();

                entity.Property(e => e.MtdAggrBala)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("MTD Aggr Bala")
                    .IsFixedLength();

                entity.Property(e => e.MtdCredCnt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MTD Cred.Cnt.")
                    .IsFixedLength();

                entity.Property(e => e.MtdCreditTo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("MTD Credit To")
                    .IsFixedLength();

                entity.Property(e => e.MtdHiBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("MTD Hi Bal")
                    .IsFixedLength();

                entity.Property(e => e.MultiStmtGrenada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Multi-Stmt(Grenada)")
                    .IsFixedLength();

                entity.Property(e => e.MultipleStatements)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Multiple Statements?")
                    .IsFixedLength();

                entity.Property(e => e.NonPerformingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Non-Performing Date")
                    .IsFixedLength();

                entity.Property(e => e.NonPerformingDda)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Non-Performing DDA?")
                    .IsFixedLength();

                entity.Property(e => e.NovAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Nov Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.NsfItemFee)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NSF Item Fee")
                    .IsFixedLength();

                entity.Property(e => e.NsfReversedPyr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("NSF Reversed PYr")
                    .IsFixedLength();

                entity.Property(e => e.NsfReversedYtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("NSF Reversed YTD")
                    .IsFixedLength();

                entity.Property(e => e.NsfWaivedOperPyr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("NSF Waived Oper PYr")
                    .IsFixedLength();

                entity.Property(e => e.NsfWaivedOperYtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("NSF Waived Oper YTD")
                    .IsFixedLength();

                entity.Property(e => e.NsfWaivedPyrAcct)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("NSF Waived PYr Acct")
                    .IsFixedLength();

                entity.Property(e => e.NsfWaivedYtdAcct)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("NSF Waived YTD Acct")
                    .IsFixedLength();

                entity.Property(e => e.NumberOfPosPrYr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Number of POS Pr Yr.")
                    .IsFixedLength();

                entity.Property(e => e.ODChargesYtd1)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("O/D Charges YTD")
                    .IsFixedLength();

                entity.Property(e => e.ODChgsThisCycle)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("O/D Chgs this Cycle")
                    .IsFixedLength();

                entity.Property(e => e.ODDaysLastYear)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("O/D Days Last Year")
                    .IsFixedLength();

                entity.Property(e => e.ODIntRateAdj)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("O/D Int Rate Adj")
                    .IsFixedLength();

                entity.Property(e => e.ODIntRateCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("O/D Int Rate Code")
                    .IsFixedLength();

                entity.Property(e => e.ODInterest)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("O/D Interest")
                    .IsFixedLength();

                entity.Property(e => e.ODInterestCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("O/D Interest Code")
                    .IsFixedLength();

                entity.Property(e => e.ODIntrstPa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("O/D Intrst Pa")
                    .IsFixedLength();

                entity.Property(e => e.ODLimitWhole)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("O/D Limit (Whole $)")
                    .IsFixedLength();

                entity.Property(e => e.ODOrNsfCurMo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("# O/D OR NSF CUR MO")
                    .IsFixedLength();

                entity.Property(e => e.ODOrNsfPrevMo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("# O/D OR NSF PREV MO")
                    .IsFixedLength();

                entity.Property(e => e.ODOrNsfPrevMo2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("#O/D OR NSF PREV MO2")
                    .IsFixedLength();

                entity.Property(e => e.ODOrNsfPrevMo3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("#O/D OR NSF PREV MO3")
                    .IsFixedLength();

                entity.Property(e => e.ODOrNsfPrevMo4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("#O/D OR NSF PREV MO4")
                    .IsFixedLength();

                entity.Property(e => e.ODOrNsfPrevMo5)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("#O/D OR NSF PREV MO5")
                    .IsFixedLength();

                entity.Property(e => e.ODOrNsfPrevMo6)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("#O/D OR NSF PREV MO6")
                    .IsFixedLength();

                entity.Property(e => e.ODPenaltyRate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("O/D Penalty Rate")
                    .IsFixedLength();

                entity.Property(e => e.OctAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Oct Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.OdChargeLastYear)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("OD Charge Last Year")
                    .IsFixedLength();

                entity.Property(e => e.OdChargesYtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("OD Charges YTD")
                    .IsFixedLength();

                entity.Property(e => e.OdChgRefundedYtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("OD Chg Refunded YTD")
                    .IsFixedLength();

                entity.Property(e => e.OdChrgRefundLYr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("OD Chrg Refund L/Yr")
                    .IsFixedLength();

                entity.Property(e => e.OdLoanPymtFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OD Loan Pymt Flag")
                    .IsFixedLength();

                entity.Property(e => e.OdType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OD Type")
                    .IsFixedLength();

                entity.Property(e => e.OdpContactFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ODP Contact Flag")
                    .IsFixedLength();

                entity.Property(e => e.OdpContactType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ODP Contact Type")
                    .IsFixedLength();

                entity.Property(e => e.OdpCounterResets)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ODP # Counter Resets")
                    .IsFixedLength();

                entity.Property(e => e.OdpDateLastReset)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ODP Date Last Reset")
                    .IsFixedLength();

                entity.Property(e => e.OdpDtCntctFlagged)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ODP Dt Cntct Flagged")
                    .IsFixedLength();

                entity.Property(e => e.OdpLastContactDt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ODP Last Contact Dt")
                    .IsFixedLength();

                entity.Property(e => e.OdpNotifyFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ODP Notify Flag")
                    .IsFixedLength();

                entity.Property(e => e.OdpOccasCurPrv11)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ODP Occas-Cur+Prv 11")
                    .IsFixedLength();

                entity.Property(e => e.OdpOccasLifetime)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ODP Occas-Lifetime")
                    .IsFixedLength();

                entity.Property(e => e.OdpOccasPrv12Mo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ODP Occas-Prv 12 Mo")
                    .IsFixedLength();

                entity.Property(e => e.OdpOccasionCurrent)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ODP Occasion Current")
                    .IsFixedLength();

                entity.Property(e => e.OdpOccasn10MoAgo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ODP Occasn 10 Mo Ago")
                    .IsFixedLength();

                entity.Property(e => e.OdpOccasn11MoAgo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ODP Occasn 11 Mo Ago")
                    .IsFixedLength();

                entity.Property(e => e.OdpOccasn12MoAgo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ODP Occasn 12 Mo Ago")
                    .IsFixedLength();

                entity.Property(e => e.OdpOccasn1MoAgo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ODP Occasn 1 Mo Ago")
                    .IsFixedLength();

                entity.Property(e => e.OdpOccasn2MoAgo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ODP Occasn 2 Mo Ago")
                    .IsFixedLength();

                entity.Property(e => e.OdpOccasn3MoAgo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ODP Occasn 3 Mo Ago")
                    .IsFixedLength();

                entity.Property(e => e.OdpOccasn4MoAgo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ODP Occasn 4 Mo Ago")
                    .IsFixedLength();

                entity.Property(e => e.OdpOccasn5MoAgo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ODP Occasn 5 Mo Ago")
                    .IsFixedLength();

                entity.Property(e => e.OdpOccasn6MoAgo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ODP Occasn 6 Mo Ago")
                    .IsFixedLength();

                entity.Property(e => e.OdpOccasn7MoAgo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ODP Occasn 7 Mo Ago")
                    .IsFixedLength();

                entity.Property(e => e.OdpOccasn8MoAgo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ODP Occasn 8 Mo Ago")
                    .IsFixedLength();

                entity.Property(e => e.OdpOccasn9MoAgo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ODP Occasn 9 Mo Ago")
                    .IsFixedLength();

                entity.Property(e => e.OnUsDic)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("On-Us DIC")
                    .IsFixedLength();

                entity.Property(e => e.OpenDepAmt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Open Dep Amt")
                    .IsFixedLength();

                entity.Property(e => e.Over15DayF)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Over 15 Day F")
                    .IsFixedLength();

                entity.Property(e => e.OverdraftRate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Overdraft Rate")
                    .IsFixedLength();

                entity.Property(e => e.PersMmdaTrans)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Pers MMDA Trans")
                    .IsFixedLength();

                entity.Property(e => e.PosAmountLa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POS Amount La")
                    .IsFixedLength();

                entity.Property(e => e.PosAmountMt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POS Amount MT")
                    .IsFixedLength();

                entity.Property(e => e.PosTransCtd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("# POS TRANS CTD")
                    .IsFixedLength();

                entity.Property(e => e.PosTransactionsMtd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("POS Transactions MTD")
                    .IsFixedLength();

                entity.Property(e => e.PosTransactionsYtd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("POS Transactions YTD")
                    .IsFixedLength();

                entity.Property(e => e.PpEnrollmentFee)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PP Enrollment Fee")
                    .IsFixedLength();

                entity.Property(e => e.PrYrOdFeeWvTier)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Pr YR OD Fee Wv-Tier")
                    .IsFixedLength();

                entity.Property(e => e.PrYtdOdFeeWvBal)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Pr YTD OD Fee Wv-Bal")
                    .IsFixedLength();

                entity.Property(e => e.PrYtdOdWvItmLmt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Pr YTD OD Wv-ItmLmt")
                    .IsFixedLength();

                entity.Property(e => e.PrevCycleCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Prev Cycle Code")
                    .IsFixedLength();

                entity.Property(e => e.PrevExcessViol)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Prev Excess Viol")
                    .IsFixedLength();

                entity.Property(e => e.PrevSerChgCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Prev Ser Chg Code")
                    .IsFixedLength();

                entity.Property(e => e.PrevYearCredits)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Prev Year Credits")
                    .IsFixedLength();

                entity.Property(e => e.PrevYearNsfChks)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Prev Year NSF Chks")
                    .IsFixedLength();

                entity.Property(e => e.PrevYearNsfItems)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Prev Year NSF Items")
                    .IsFixedLength();

                entity.Property(e => e.PrevYrAverageBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Prev Yr Average Bal")
                    .IsFixedLength();

                entity.Property(e => e.PrevYrNsfReturns)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Prev Yr NSF Returns")
                    .IsFixedLength();

                entity.Property(e => e.PreviousStmtBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Previous Stmt Bal")
                    .IsFixedLength();

                entity.Property(e => e.PreviousYearDebits)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Previous Year Debits")
                    .IsFixedLength();

                entity.Property(e => e.PriorDayUncollBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Prior Day Uncoll Bal")
                    .IsFixedLength();

                entity.Property(e => e.PriorYrRegDdOD)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Prior Yr Reg DD O/D")
                    .IsFixedLength();

                entity.Property(e => e.PriorYrRetItmChg)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Prior Yr Ret Itm Chg")
                    .IsFixedLength();

                entity.Property(e => e.PrvMonthCar)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Prv Month Car")
                    .IsFixedLength();

                entity.Property(e => e.QtdHighBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("QTD High Balance")
                    .IsFixedLength();

                entity.Property(e => e.QtdHighODBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("QTD High O/D Bal")
                    .IsFixedLength();

                entity.Property(e => e.QtdIntrstExp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("QTD Intrst Exp-")
                    .IsFixedLength();

                entity.Property(e => e.QtdIntrstInc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("QTD Intrst Inc-")
                    .IsFixedLength();

                entity.Property(e => e.RateCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Rate Code")
                    .IsFixedLength();

                entity.Property(e => e.ReClassAmount)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Re-Class Amount")
                    .IsFixedLength();

                entity.Property(e => e.ReClassCntrOvrd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Re-Class Cntr Ovrd")
                    .IsFixedLength();

                entity.Property(e => e.ReClassCounter)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Re-Class Counter")
                    .IsFixedLength();

                entity.Property(e => e.ReClassFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Re-Class Flag")
                    .IsFixedLength();

                entity.Property(e => e.ReclasThrshl)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Reclas Thrshl")
                    .IsFixedLength();

                entity.Property(e => e.RegDdOdDisclosure)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Reg DD OD Disclosure")
                    .IsFixedLength();

                entity.Property(e => e.RegEAggOdBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Reg E Agg OD Bal")
                    .IsFixedLength();

                entity.Property(e => e.RegEConfirmDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Reg E Confirm Date")
                    .IsFixedLength();

                entity.Property(e => e.RegEDateRevoked)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Reg E Date Revoked")
                    .IsFixedLength();

                entity.Property(e => e.RegEItemsWvdLmth)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("RegE Items Wvd-LMth")
                    .IsFixedLength();

                entity.Property(e => e.RegEItemsWvdLyr)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("RegE Items Wvd-LYr")
                    .IsFixedLength();

                entity.Property(e => e.RegEItemsWvdMtd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("RegE Items Wvd-MTD")
                    .IsFixedLength();

                entity.Property(e => e.RegEItemsWvdYtd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("RegE Items Wvd-YTD")
                    .IsFixedLength();

                entity.Property(e => e.RegEOdBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Reg E OD Balance")
                    .IsFixedLength();

                entity.Property(e => e.RegEOdDays)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Reg E OD Days")
                    .IsFixedLength();

                entity.Property(e => e.RegEOptIn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Reg E Opt-In")
                    .IsFixedLength();

                entity.Property(e => e.RegEOptInDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Reg E Opt-In Date")
                    .IsFixedLength();

                entity.Property(e => e.RegEPrintFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Reg E Print Flag")
                    .IsFixedLength();

                entity.Property(e => e.ResFundsAcctType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Res Funds Acct Type")
                    .IsFixedLength();

                entity.Property(e => e.ResFundsSwpTime)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Res Funds Swp Time")
                    .IsFixedLength();

                entity.Property(e => e.ReserveFundBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Reserve Fund Balance")
                    .IsFixedLength();

                entity.Property(e => e.ReserveFundProduct)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Reserve Fund Product")
                    .IsFixedLength();

                entity.Property(e => e.ReserveFundsAip)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Reserve Funds AIP")
                    .IsFixedLength();

                entity.Property(e => e.RetChgsThisCycle)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Ret Chgs this Cycle")
                    .IsFixedLength();

                entity.Property(e => e.ReturnItemChgs)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Return Item Chgs")
                    .IsFixedLength();

                entity.Property(e => e.RewardCriteriaMet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Reward Criteria Met")
                    .IsFixedLength();

                entity.Property(e => e.RewardsPlanCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Rewards Plan Code")
                    .IsFixedLength();

                entity.Property(e => e.SChgsReversedPyr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("S/Chgs Reversed PYr")
                    .IsFixedLength();

                entity.Property(e => e.SChgsReversedYtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("S/Chgs Reversed YTD")
                    .IsFixedLength();

                entity.Property(e => e.SecByResCommMtg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sec.by Res/Comm Mtg")
                    .IsFixedLength();

                entity.Property(e => e.SecurityCodes)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Security Codes")
                    .IsFixedLength();

                entity.Property(e => e.SecurityValue)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Security Value")
                    .IsFixedLength();

                entity.Property(e => e.SepAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Sep Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.SerChgRunningBal)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Ser Chg Running Bal")
                    .IsFixedLength();

                entity.Property(e => e.SerChgsWaivedLYr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Ser Chgs Waived L/YR")
                    .IsFixedLength();

                entity.Property(e => e.SerChgsWaivedYtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Ser Chgs Waived YTD")
                    .IsFixedLength();

                entity.Property(e => e.SerChrgWaiveDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Ser Chrg Waive Date")
                    .IsFixedLength();

                entity.Property(e => e.ServiceChargeCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Service Charge Code")
                    .IsFixedLength();

                entity.Property(e => e.ServiceChgWaiveCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Service Chg Waive Cd")
                    .IsFixedLength();

                entity.Property(e => e.SpecPostageSC)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Spec Postage S/C?")
                    .IsFixedLength();

                entity.Property(e => e.SpecificProv)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Specific Prov")
                    .IsFixedLength();

                entity.Property(e => e.StatementFormat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Statement Format")
                    .IsFixedLength();

                entity.Property(e => e.StatementRequest)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Statement Request")
                    .IsFixedLength();

                entity.Property(e => e.StatementSortCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Statement Sort Code")
                    .IsFixedLength();

                entity.Property(e => e.StmtCycleCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Stmt Cycle Code")
                    .IsFixedLength();

                entity.Property(e => e.StmtMessageCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Stmt Message Code")
                    .IsFixedLength();

                entity.Property(e => e.StmtSrtPrAcctFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Stmt Srt Pr Acct Flg")
                    .IsFixedLength();

                entity.Property(e => e.StopPyAutoChgFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Stop Py Auto Chg Flg")
                    .IsFixedLength();

                entity.Property(e => e.StopPyNoticeFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Stop Py Notice Flag")
                    .IsFixedLength();

                entity.Property(e => e.SuppressNsfNotice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Suppress NSF Notice?")
                    .IsFixedLength();

                entity.Property(e => e.TargetBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Target Balance")
                    .IsFixedLength();

                entity.Property(e => e.TotInclearings)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Tot Inclearings")
                    .IsFixedLength();

                entity.Property(e => e.TotTransferDebits)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Tot Transfer Debits")
                    .IsFixedLength();

                entity.Property(e => e.TotalAtmCreditMtd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Total ATM Credit MTD")
                    .IsFixedLength();

                entity.Property(e => e.TotalAtmWDMtd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Total ATM W/D MTD")
                    .IsFixedLength();

                entity.Property(e => e.TotalAtmWDPrYr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Total ATM W/D Pr Yr.")
                    .IsFixedLength();

                entity.Property(e => e.TotalAtmWDYtd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Total ATM W/D YTD")
                    .IsFixedLength();

                entity.Property(e => e.TotalHoldAm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Total Hold Am")
                    .IsFixedLength();

                entity.Property(e => e.TotlAtmCreditsYtd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Totl ATM Credits YTD")
                    .IsFixedLength();

                entity.Property(e => e.TransferFromType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Transfer From Type")
                    .IsFixedLength();

                entity.Property(e => e.TransferInAmount)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Transfer In Amount")
                    .IsFixedLength();

                entity.Property(e => e.TransferOutAmount)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Transfer Out Amount")
                    .IsFixedLength();

                entity.Property(e => e.TransferToAccount)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Transfer To Account")
                    .IsFixedLength();

                entity.Property(e => e.TransferToType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Transfer To Type")
                    .IsFixedLength();

                entity.Property(e => e.TransitDic)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Transit DIC")
                    .IsFixedLength();

                entity.Property(e => e.TrnsfrSCIn)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Trnsfr S/C In")
                    .IsFixedLength();

                entity.Property(e => e.TrnsfrSCOut)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Trnsfr S/C Out")
                    .IsFixedLength();

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Type Code")
                    .IsFixedLength();

                entity.Property(e => e.UncollectedBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Uncollected Balance")
                    .IsFixedLength();

                entity.Property(e => e.UnpostToday)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UNPOST Today")
                    .IsFixedLength();

                entity.Property(e => e.UseAchFilters)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Use ACH Filters?")
                    .IsFixedLength();

                entity.Property(e => e.ValuationReportPrep)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Valuation Report Prep")
                    .IsFixedLength();

                entity.Property(e => e.ViolationHistory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Violation History")
                    .IsFixedLength();

                entity.Property(e => e.WaiveAtmUsageCr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Waive ATM Usage CR")
                    .IsFixedLength();

                entity.Property(e => e.WaiveIncWireFee)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Waive Inc Wire Fee?")
                    .IsFixedLength();

                entity.Property(e => e.WaiveOutgWireFee)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Waive Outg Wire Fee")
                    .IsFixedLength();

                entity.Property(e => e.YtdAverageBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("YTD Average Balance")
                    .IsFixedLength();

                entity.Property(e => e.YtdAverageBalanceYtd)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("YTD Average Balance YTD")
                    .IsFixedLength();

                entity.Property(e => e.YtdAverageC)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YTD Average C")
                    .IsFixedLength();

                entity.Property(e => e.YtdBounceCharges)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("YTD Bounce Charges")
                    .IsFixedLength();

                entity.Property(e => e.YtdClringItemCnt)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("YTD Clring Item Cnt")
                    .IsFixedLength();

                entity.Property(e => e.YtdCredits)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("YTD Credits")
                    .IsFixedLength();

                entity.Property(e => e.YtdDebits)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("YTD Debits")
                    .IsFixedLength();

                entity.Property(e => e.YtdHiBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("YTD Hi Bal")
                    .IsFixedLength();

                entity.Property(e => e.YtdInterest)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YTD Interest")
                    .IsFixedLength();

                entity.Property(e => e.YtdNsfChecks)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("YTD NSF Checks")
                    .IsFixedLength();

                entity.Property(e => e.YtdNsfPresented)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("YTD NSF Presented")
                    .IsFixedLength();

                entity.Property(e => e.YtdNsfReturns)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("YTD NSF Returns")
                    .IsFixedLength();

                entity.Property(e => e.YtdODDays)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("YTD O/D Days")
                    .IsFixedLength();

                entity.Property(e => e.YtdODIntE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YTD O/D Int E")
                    .IsFixedLength();

                entity.Property(e => e.YtdOdFeeWvItmLmt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("YTD OD Fee WvItmLmt")
                    .IsFixedLength();

                entity.Property(e => e.YtdOdFeeWvdBal)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("YTD OD Fee Wvd-Bal")
                    .IsFixedLength();

                entity.Property(e => e.YtdOdFeesWvdTier)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("YTD OD Fees Wvd-Tier")
                    .IsFixedLength();

                entity.Property(e => e.YtdServiceC)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YTD Service C")
                    .IsFixedLength();

                entity.Property(e => e.YtdTransitItmCnt)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("YTD Transit Itm Cnt")
                    .IsFixedLength();

                entity.Property(e => e._1115DayFlo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("11-15 Day Flo")
                    .IsFixedLength();

                entity.Property(e => e._12MnthAverageBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("12 Mnth Average Bal")
                    .IsFixedLength();

                entity.Property(e => e._1DayFloatA)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("1 Day Float A")
                    .IsFixedLength();

                entity.Property(e => e._2DayFloatA)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("2 Day Float A")
                    .IsFixedLength();

                entity.Property(e => e._2ndTransferToAcct)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("2nd Transfer To Acct")
                    .IsFixedLength();

                entity.Property(e => e._2ndTransferToType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("2nd Transfer To Type")
                    .IsFixedLength();

                entity.Property(e => e._2ndTrfFromAcct)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("2nd Trf From Acct")
                    .IsFixedLength();

                entity.Property(e => e._2ndTrfFromType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("2nd Trf From Type")
                    .IsFixedLength();

                entity.Property(e => e._3DayFloatA)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("3 Day Float A")
                    .IsFixedLength();

                entity.Property(e => e._45DayFloat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("4-5 Day Float")
                    .IsFixedLength();

                entity.Property(e => e._610DayFloa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("6-10 Day Floa")
                    .IsFixedLength();
            });

            modelBuilder.Entity<DormantRegister>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("DormantRegister");

                entity.HasIndex(e => e.RecordId, "IX_DormantRegister");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.AcctNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_Number");

                entity.Property(e => e.AcctStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AcctType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoreBranchNumber)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DatePerformed).HasColumnType("date");

                entity.Property(e => e.DateRequested).HasColumnType("date");

                entity.Property(e => e.InitialIdEmployee).HasColumnName("Initial_ID_Employee");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Particulars)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousBalance)
                    .HasColumnType("money")
                    .HasColumnName("Previous_Balance");

                entity.Property(e => e.ReactivateIdEmployee).HasColumnName("Reactivate_ID_Employee");

                entity.HasOne(d => d.AcctTypeNavigation)
                    .WithMany(p => p.DormantRegisters)
                    .HasForeignKey(d => d.AcctTypeId)
                    .HasConstraintName("FK_DormantRegister_AcctType");

                entity.HasOne(d => d.EntryStatus)
                    .WithMany(p => p.DormantRegisters)
                    .HasForeignKey(d => d.EntryStatusId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DormantRegister_EntryStatus");
            });

            modelBuilder.Entity<EntryStatus>(entity =>
            {
                entity.ToTable("EntryStatus");

                entity.Property(e => e.EntryStatusDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.HasKey(e => e.ErrId);

                entity.ToTable("ErrorLog");

                entity.Property(e => e.ErrId).HasColumnName("ErrID");

                entity.Property(e => e.Datereported).HasColumnType("datetime");

                entity.Property(e => e.ErrDesc).HasMaxLength(500);
            });

            modelBuilder.Entity<FileStage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FileStage");

                entity.Property(e => e.FileData)
                    .IsUnicode(false)
                    .HasColumnName("fileData");
            });

            modelBuilder.Entity<ForeignChecksBatch>(entity =>
            {
                entity.HasKey(e => e.BatchId);

                entity.Property(e => e.BatchTotal).HasColumnType("money");

                entity.Property(e => e.BranchNumber)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DatePaymentRequested).HasColumnType("date");

                entity.Property(e => e.DateProcessed).HasColumnType("date");

                entity.Property(e => e.DateReceived).HasColumnType("date");

                entity.Property(e => e.DateSettled).HasColumnType("date");

                entity.Property(e => e.ProcessedByIdEmployee).HasColumnName("ProcessedBy_ID_Employee");

                entity.Property(e => e.SettledByIdEmployee).HasColumnName("SettledBy_ID_Employee");

                entity.HasOne(d => d.BatchStatus)
                    .WithMany(p => p.ForeignChecksBatches)
                    .HasForeignKey(d => d.BatchStatusId)
                    .HasConstraintName("FK_ForeignChecksBatches_EntryStatus");
            });

            modelBuilder.Entity<ForeignChecksDetail>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.Property(e => e.CheckAmount).HasColumnType("money");

                entity.Property(e => e.CheckNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepositAcctName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepositAcctNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayerAcctName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayerAcctNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.ForeignChecksDetails)
                    .HasForeignKey(d => d.BatchId)
                    .HasConstraintName("FK_ForeignChecksDetails_ForeignChecksBatches");
            });

            modelBuilder.Entity<ForeignChecksSettlement>(entity =>
            {
                entity.HasKey(e => e.SettlementId);

                entity.ToTable("ForeignChecksSettlement");

                entity.Property(e => e.CheckNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorrespondentBankId).HasColumnName("CorrespondentBankID");

                entity.Property(e => e.DateSettled).HasColumnType("date");

                entity.Property(e => e.SettledByWire)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SettlementAmount).HasColumnType("money");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.ForeignChecksSettlements)
                    .HasForeignKey(d => d.BatchId)
                    .HasConstraintName("FK_ForeignChecksBatches_ForeignChecksSettlement");
            });

            modelBuilder.Entity<ImportedFile>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.FileId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FileID");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loan>(entity =>
            {
                entity.ToTable("Loan");

                entity.Property(e => e.LoanId).HasColumnName("Loan_ID");

                entity.Property(e => e.AHAdjustment)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("A&H Adjustment")
                    .IsFixedLength();

                entity.Property(e => e.AHCollected)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("A/H Collected")
                    .IsFixedLength();

                entity.Property(e => e.AHEarned)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("A/H Earned")
                    .IsFixedLength();

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Account_Number")
                    .IsFixedLength();

                entity.Property(e => e.AcctLevelMinInt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Acct Level Min Int")
                    .IsFixedLength();

                entity.Property(e => e.AchAccountNumber)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("ACH Account Number")
                    .IsFixedLength();

                entity.Property(e => e.AchRoutingNumber)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ACH Routing Number")
                    .IsFixedLength();

                entity.Property(e => e.AchTransactionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ACH Transaction Code")
                    .IsFixedLength();

                entity.Property(e => e.AddressIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Address Indicator")
                    .IsFixedLength();

                entity.Property(e => e.AdvDatesForRate)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Adv Dates for Rate")
                    .IsFixedLength();

                entity.Property(e => e.AdvanceBillingDays)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Advance Billing Days")
                    .IsFixedLength();

                entity.Property(e => e.AgencyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Agency Code")
                    .IsFixedLength();

                entity.Property(e => e.AggAccrualBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Agg Accrual Balance")
                    .IsFixedLength();

                entity.Property(e => e.AmortSchedLoanBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Amort Sched Loan Bal")
                    .IsFixedLength();

                entity.Property(e => e.Amortized)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Amortized?")
                    .IsFixedLength();

                entity.Property(e => e.AmountLastP)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Amount Last P")
                    .IsFixedLength();

                entity.Property(e => e.AmountPastD)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Amount Past D")
                    .IsFixedLength();

                entity.Property(e => e.AmtIntLast)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Amt Int Last")
                    .IsFixedLength();

                entity.Property(e => e.AmtMemoPostedTody)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("AMT MEMO POSTED TODY")
                    .IsFixedLength();

                entity.Property(e => e.AmtPrincLst)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Amt Princ Lst")
                    .IsFixedLength();

                entity.Property(e => e.AutoPayGraceDays)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Auto-Pay Grace Days")
                    .IsFixedLength();

                entity.Property(e => e.AutoPayment)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Auto Payment")
                    .IsFixedLength();

                entity.Property(e => e.AutoPmtFrequency)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Auto Pmt Frequency")
                    .IsFixedLength();

                entity.Property(e => e.AutomaticPmtDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Automatic Pmt Date")
                    .IsFixedLength();

                entity.Property(e => e.AutopayMemoPosted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Autopay Memo Posted")
                    .IsFixedLength();

                entity.Property(e => e.BalAfterLstAdv)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Bal After Lst Adv")
                    .IsFixedLength();

                entity.Property(e => e.BalDueAftrPaymnt)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Bal Due Aftr Paymnt")
                    .IsFixedLength();

                entity.Property(e => e.BalLastLoanStmt)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Bal Last Loan Stmt")
                    .IsFixedLength();

                entity.Property(e => e.BalLoanLastRenew)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Bal Loan Last Renew")
                    .IsFixedLength();

                entity.Property(e => e.BcalcMaturityDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("BCALC Maturity Date")
                    .IsFixedLength();

                entity.Property(e => e.BegMoIntPdToDt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Beg Mo Int Pd to Dt")
                    .IsFixedLength();

                entity.Property(e => e.BeginBalToday)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Begin Bal Today")
                    .IsFixedLength();

                entity.Property(e => e.BeginningYearBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Beginning Year Bal")
                    .IsFixedLength();

                entity.Property(e => e.BillingTypeCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Billing Type Code")
                    .IsFixedLength();

                entity.Property(e => e.BomLiability)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("BOM Liability")
                    .IsFixedLength();

                entity.Property(e => e.BoyInterestRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("BOY Interest Rate")
                    .IsFixedLength();

                entity.Property(e => e.CBDaysPastDue)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("C.B. Days Past Due")
                    .IsFixedLength();

                entity.Property(e => e.CashSecurity)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CASH SECURITY")
                    .IsFixedLength();

                entity.Property(e => e.CdForVarRateLn)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("CD# for Var Rate Ln")
                    .IsFixedLength();

                entity.Property(e => e.ChargeOffBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("ChargeOff Balance")
                    .IsFixedLength();

                entity.Property(e => e.ChargeOffReason)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Charge Off Reason")
                    .IsFixedLength();

                entity.Property(e => e.Class5IntrDay)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Class 5 Intr Day")
                    .IsFixedLength();

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Class Code")
                    .IsFixedLength();

                entity.Property(e => e.CollValueCalculatd)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Coll Value-Calculatd")
                    .IsFixedLength();

                entity.Property(e => e.CollValueManual)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Coll Value-Manual")
                    .IsFixedLength();

                entity.Property(e => e.Collateral)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CollateralFile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Collateral File")
                    .IsFixedLength();

                entity.Property(e => e.CollectionSrvcDay)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Collection Srvc Day")
                    .IsFixedLength();

                entity.Property(e => e.CollectorInitials)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Collector Initials")
                    .IsFixedLength();

                entity.Property(e => e.ComplianceCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Compliance Code")
                    .IsFixedLength();

                entity.Property(e => e.ConsumerInfo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Consumer Info")
                    .IsFixedLength();

                entity.Property(e => e.CorresAccountMod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Corres Account Mod")
                    .IsFixedLength();

                entity.Property(e => e.CorrespondingAcct)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Corresponding Acct")
                    .IsFixedLength();

                entity.Property(e => e.CouponTapeFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Coupon/Tape Flag")
                    .IsFixedLength();

                entity.Property(e => e.CouponsPerOrder)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Coupons per Order")
                    .IsFixedLength();

                entity.Property(e => e.CouponsPrinted)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Coupons Printed")
                    .IsFixedLength();

                entity.Property(e => e.CouponsRemaining)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Coupons Remaining")
                    .IsFixedLength();

                entity.Property(e => e.CrBurPayoffCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Cr/Bur Payoff Code")
                    .IsFixedLength();

                entity.Property(e => e.CrBureauBadHst)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Cr Bureau Bad Hst #")
                    .IsFixedLength();

                entity.Property(e => e.CrBureauDelHist2)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Cr Bureau Del Hist2")
                    .IsFixedLength();

                entity.Property(e => e.CrLifeExpireDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Cr/Life Expire Date")
                    .IsFixedLength();

                entity.Property(e => e.CreditBrPstMoDl)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Credit Br Pst Mo Dl")
                    .IsFixedLength();

                entity.Property(e => e.CreditLimit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Credit Limit")
                    .IsFixedLength();

                entity.Property(e => e.CumulDaysDelinq)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Cumul Days Delinq")
                    .IsFixedLength();

                entity.Property(e => e.CureNoticeFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Cure Notice Flag")
                    .IsFixedLength();

                entity.Property(e => e.CurePrintFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Cure Print Flag")
                    .IsFixedLength();

                entity.Property(e => e.CurrentBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Current Balance")
                    .IsFixedLength();

                entity.Property(e => e.CurrentBaseRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Current Base Rate")
                    .IsFixedLength();

                entity.Property(e => e.CurrentLtvRatio)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Current LTV Ratio")
                    .IsFixedLength();

                entity.Property(e => e.CycleStatement)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Cycle Statement?")
                    .IsFixedLength();

                entity.Property(e => e.DailyIntFactor)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Daily Int. Factor")
                    .IsFixedLength();

                entity.Property(e => e.DateChargedOff)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Charged Off")
                    .IsFixedLength();

                entity.Property(e => e.DateDeedTrustDue)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Deed Trust Due")
                    .IsFixedLength();

                entity.Property(e => e.DateDelinq30Days)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Delinq. 30 Days")
                    .IsFixedLength();

                entity.Property(e => e.DateFinancialStmt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Financial Stmt")
                    .IsFixedLength();

                entity.Property(e => e.DateInsurExpires)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Insur Expires")
                    .IsFixedLength();

                entity.Property(e => e.DateIntPaidTo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Int Paid To")
                    .IsFixedLength();

                entity.Property(e => e.DateInterestNext)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Interest Next")
                    .IsFixedLength();

                entity.Property(e => e.DateLastExtension)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Last Extension")
                    .IsFixedLength();

                entity.Property(e => e.DateLastPayment)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Last Payment")
                    .IsFixedLength();

                entity.Property(e => e.DateLoanLstRenew)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Loan Lst Renew")
                    .IsFixedLength();

                entity.Property(e => e.DateLstEvaluation)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Lst Evaluation")
                    .IsFixedLength();

                entity.Property(e => e.DateLstHomeEqSt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Lst Home Eq St")
                    .IsFixedLength();

                entity.Property(e => e.DateNonAccrual)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date NonAccrual")
                    .IsFixedLength();

                entity.Property(e => e.DatePriorIntPdTo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Prior Int Pd To")
                    .IsFixedLength();

                entity.Property(e => e.DaysBase)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Days Base")
                    .IsFixedLength();

                entity.Property(e => e.DaysLate)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Days Late")
                    .IsFixedLength();

                entity.Property(e => e.DaysSinceMatDate)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Days Since Mat Date")
                    .IsFixedLength();

                entity.Property(e => e.DaysToCure)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Days to Cure")
                    .IsFixedLength();

                entity.Property(e => e.DbCLColl)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DB C/L Coll")
                    .IsFixedLength();

                entity.Property(e => e.DbCrLifeEarned)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DB Cr Life Earned")
                    .IsFixedLength();

                entity.Property(e => e.DealerCollected)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Dealer Collected")
                    .IsFixedLength();

                entity.Property(e => e.DealerDiscountAdj)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Dealer Discount Adj")
                    .IsFixedLength();

                entity.Property(e => e.DealerEarned)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Dealer Earned")
                    .IsFixedLength();

                entity.Property(e => e.DealerFloorPlan)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Dealer Floor Plan?")
                    .IsFixedLength();

                entity.Property(e => e.DealerNumber)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("Dealer Number")
                    .IsFixedLength();

                entity.Property(e => e.DebtRestructure)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Debt Restructure")
                    .IsFixedLength();

                entity.Property(e => e.DecBalCrLifeDue)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Dec Bal Cr Life Due")
                    .IsFixedLength();

                entity.Property(e => e.DefaultRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Default Rate")
                    .IsFixedLength();

                entity.Property(e => e.DefaultRateDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Default Rate Date")
                    .IsFixedLength();

                entity.Property(e => e.DefaultRateFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Default Rate Flag")
                    .IsFixedLength();

                entity.Property(e => e.Delinquent30Days)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Delinquent >30 Days")
                    .IsFixedLength();

                entity.Property(e => e.Delinquent60Days)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Delinquent >60 Days")
                    .IsFixedLength();

                entity.Property(e => e.Delinquent90Days)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Delinquent >90 Days")
                    .IsFixedLength();

                entity.Property(e => e.DelinquentFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Delinquent Flag")
                    .IsFixedLength();

                entity.Property(e => e.DemandLoan)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Demand Loan?")
                    .IsFixedLength();

                entity.Property(e => e.DtArmRtChgNotice)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Dt ARM Rt Chg Notice")
                    .IsFixedLength();

                entity.Property(e => e.DueDateMoto)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Due Date Moto")
                    .IsFixedLength();

                entity.Property(e => e.DueDteLifePrem)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Due Dte. Life Prem.")
                    .IsFixedLength();

                entity.Property(e => e.DwellingIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Dwelling Indicator")
                    .IsFixedLength();

                entity.Property(e => e.EscrowBalance)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Escrow Balance-")
                    .IsFixedLength();

                entity.Property(e => e.EscrowFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Escrow Flag")
                    .IsFixedLength();

                entity.Property(e => e.EscrowIntPaidYtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Escrow Int. Paid YTD")
                    .IsFixedLength();

                entity.Property(e => e.EscrowIntPdLstYr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Escrow Int Pd Lst Yr")
                    .IsFixedLength();

                entity.Property(e => e.EscrowPastDue)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Escrow Past Due")
                    .IsFixedLength();

                entity.Property(e => e.EscrowPaymentAmt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Escrow Payment Amt")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedArmBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Estimated ARM Bal")
                    .IsFixedLength();

                entity.Property(e => e.ExtraPrincip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Extra Princip")
                    .IsFixedLength();

                entity.Property(e => e.Fas91CalcFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FAS91 Calc Flag")
                    .IsFixedLength();

                entity.Property(e => e.Fas91CostEarned)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAS91 Cost Earned")
                    .IsFixedLength();

                entity.Property(e => e.Fas91FeesEarned)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAS91 Fees Earned")
                    .IsFixedLength();

                entity.Property(e => e.Fasb91CostAccTod)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FASB91 Cost Acc Tod")
                    .IsFixedLength();

                entity.Property(e => e.Fasb91CostAccYtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FASB91 Cost Acc YTD")
                    .IsFixedLength();

                entity.Property(e => e.Fasb91FeeAccTod)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FASB91 Fee Acc Tod")
                    .IsFixedLength();

                entity.Property(e => e.Fasb91FeeAccYtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FASB91 Fee Acc YTD")
                    .IsFixedLength();

                entity.Property(e => e.Fasb91OrigCost)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FASB91 Orig Cost")
                    .IsFixedLength();

                entity.Property(e => e.Fasb91OrigCostErn)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FASB91 Orig Cost Ern")
                    .IsFixedLength();

                entity.Property(e => e.Fasb91OrigFeeColl)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FASB91 Orig Fee Coll")
                    .IsFixedLength();

                entity.Property(e => e.Fasb91OrigFeeErn)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FASB91 Orig Fee Ern")
                    .IsFixedLength();

                entity.Property(e => e.FasbMaturityDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FASB Maturity Date")
                    .IsFixedLength();

                entity.Property(e => e.FeesBilledN)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fees Billed N")
                    .IsFixedLength();

                entity.Property(e => e.FixPaymentA)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Fix Payment A")
                    .IsFixedLength();

                entity.Property(e => e.FraudAlertFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Fraud Alert Flag")
                    .IsFixedLength();

                entity.Property(e => e.FredMacFanMae)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fred. Mac/Fan. Mae")
                    .IsFixedLength();

                entity.Property(e => e.FreezeAdvances)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Freeze Advances?")
                    .IsFixedLength();

                entity.Property(e => e.FreshStartAccount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Fresh Start Account")
                    .IsFixedLength();

                entity.Property(e => e.FreshStrtLetter1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Fresh Strt Letter 1")
                    .IsFixedLength();

                entity.Property(e => e.FreshStrtLetter2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Fresh Strt Letter 2")
                    .IsFixedLength();

                entity.Property(e => e.FreshStrtLetter3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Fresh Strt Letter 3")
                    .IsFixedLength();

                entity.Property(e => e.FreshStrtLetter4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Fresh Strt Letter 4")
                    .IsFixedLength();

                entity.Property(e => e.FreshStrtLetter5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Fresh Strt Letter 5")
                    .IsFixedLength();

                entity.Property(e => e.FreshStrtLetter6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Fresh Strt Letter 6")
                    .IsFixedLength();

                entity.Property(e => e.FreshStrtLetter7)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Fresh Strt Letter 7")
                    .IsFixedLength();

                entity.Property(e => e.FreshStrtLetter8)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Fresh Strt Letter 8")
                    .IsFixedLength();

                entity.Property(e => e.FreshStrtLetter9)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Fresh Strt Letter 9")
                    .IsFixedLength();

                entity.Property(e => e.FsDlyFeeBalance)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FS Dly Fee Balance")
                    .IsFixedLength();

                entity.Property(e => e.FsForceLetter)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FS Force Letter #")
                    .IsFixedLength();

                entity.Property(e => e.FsLetterToday)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FS Letter # Today")
                    .IsFixedLength();

                entity.Property(e => e.FsOtherFeeBalance)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FS Other Fee Balance")
                    .IsFixedLength();

                entity.Property(e => e.FsPaidBalance)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FS Paid Balance")
                    .IsFixedLength();

                entity.Property(e => e.FsSCBalance)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FS S/C Balance")
                    .IsFixedLength();

                entity.Property(e => e.FsTrnFeeBalance)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FS Trn Fee Balance")
                    .IsFixedLength();

                entity.Property(e => e.FundingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Funding Date")
                    .IsFixedLength();

                entity.Property(e => e.GLIencAmou)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("G/L IENC Amou")
                    .IsFixedLength();

                entity.Property(e => e.GLPrincipalBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("G/L Principal Bal")
                    .IsFixedLength();

                entity.Property(e => e.GuaranteedPort)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Guaranteed Port %")
                    .IsFixedLength();

                entity.Property(e => e.InitialLoanOfficer)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Initial Loan Officer")
                    .IsFixedLength();

                entity.Property(e => e.InsuranceSta)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Insurance Sta")
                    .IsFixedLength();

                entity.Property(e => e.InsuranceTerm)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Insurance Term")
                    .IsFixedLength();

                entity.Property(e => e.IntBilledNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Int Billed No")
                    .IsFixedLength();

                entity.Property(e => e.IntPaidByO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Int Paid by O")
                    .IsFixedLength();

                entity.Property(e => e.IntPaidPast)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Int Paid Past")
                    .IsFixedLength();

                entity.Property(e => e.IntRebateCa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Int Rebate Ca")
                    .IsFixedLength();

                entity.Property(e => e.IntRoundingFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Int Rounding Flag")
                    .IsFixedLength();

                entity.Property(e => e.InterestAdju)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Interest Adju")
                    .IsFixedLength();

                entity.Property(e => e.InterestApplyCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Interest Apply Code")
                    .IsFixedLength();

                entity.Property(e => e.InterestBeginDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Interest Begin Date")
                    .IsFixedLength();

                entity.Property(e => e.InterestColl)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Interest Coll")
                    .IsFixedLength();

                entity.Property(e => e.InterestEarn)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Interest Earn")
                    .IsFixedLength();

                entity.Property(e => e.InterestFreqCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Interest Freq Code")
                    .IsFixedLength();

                entity.Property(e => e.InterestPaid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Interest Paid")
                    .IsFixedLength();

                entity.Property(e => e.InterestPaidTotal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Interest Paid Total")
                    .IsFixedLength();

                entity.Property(e => e.InterestRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Interest Rate")
                    .IsFixedLength();

                entity.Property(e => e.LateChargeAdj)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Late Charge Adj")
                    .IsFixedLength();

                entity.Property(e => e.LateChargeDay)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Late Charge Day")
                    .IsFixedLength();

                entity.Property(e => e.LateChargeNumber)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Late Charge Number")
                    .IsFixedLength();

                entity.Property(e => e.LateChrgePending)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Late Chrge Pending?")
                    .IsFixedLength();

                entity.Property(e => e.LateCounter)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Late Counter")
                    .IsFixedLength();

                entity.Property(e => e.LeaseGuarResid)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Lease Guar. Resid")
                    .IsFixedLength();

                entity.Property(e => e.LeasePersnlPtyTx)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Lease Persnl Pty Tx")
                    .IsFixedLength();

                entity.Property(e => e.LeasePurchOption)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Lease Purch Option")
                    .IsFixedLength();

                entity.Property(e => e.LeaseSalesTxRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Lease Sales Tx Rate")
                    .IsFixedLength();

                entity.Property(e => e.LeaseSecurityDep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Lease Security Dep")
                    .IsFixedLength();

                entity.Property(e => e.LeaseStateCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Lease State Code")
                    .IsFixedLength();

                entity.Property(e => e.LeaseType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Lease Type")
                    .IsFixedLength();

                entity.Property(e => e.LeaseUnguarResid)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Lease Unguar. Resid")
                    .IsFixedLength();

                entity.Property(e => e.LevelCrLifeColl)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Level Cr/Life Coll")
                    .IsFixedLength();

                entity.Property(e => e.LevelCrLifeDue)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Level Cr Life Due")
                    .IsFixedLength();

                entity.Property(e => e.LevelCrLifeEarnd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Level Cr/Life Earnd")
                    .IsFixedLength();

                entity.Property(e => e.LifeInsPol)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Life Ins. Pol")
                    .IsFixedLength();

                entity.Property(e => e.LineCommitment)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Line/Commitment")
                    .IsFixedLength();

                entity.Property(e => e.LoanAvailableBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Loan Available Bal")
                    .IsFixedLength();

                entity.Property(e => e.LoanFee1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Loan Fee #1")
                    .IsFixedLength();

                entity.Property(e => e.LoanFee2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Loan Fee #2")
                    .IsFixedLength();

                entity.Property(e => e.LoanFee3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Loan Fee #3")
                    .IsFixedLength();

                entity.Property(e => e.LoanFee4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Loan Fee #4")
                    .IsFixedLength();

                entity.Property(e => e.LoanFee5)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Loan Fee #5")
                    .IsFixedLength();

                entity.Property(e => e.LoanFeeColl)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Loan Fee Coll")
                    .IsFixedLength();

                entity.Property(e => e.LoanFeesAddToBal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Loan Fees Add to Bal")
                    .IsFixedLength();

                entity.Property(e => e.LoanFeesAny)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Loan Fees Any")
                    .IsFixedLength();

                entity.Property(e => e.LoanFeesAtOrig)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Loan Fees at Orig")
                    .IsFixedLength();

                entity.Property(e => e.LoanFeesAtPayoff)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Loan Fees at Payoff")
                    .IsFixedLength();

                entity.Property(e => e.LoanFeesBilled)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Loan Fees Billed")
                    .IsFixedLength();

                entity.Property(e => e.LoanFeesCol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Loan Fees Col")
                    .IsFixedLength();

                entity.Property(e => e.LoanFeesEarned)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Loan Fees Earned")
                    .IsFixedLength();

                entity.Property(e => e.LoanFeesErndToday)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Loan Fees Ernd Today")
                    .IsFixedLength();

                entity.Property(e => e.LoanLossProv)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Loan Loss Prov")
                    .IsFixedLength();

                entity.Property(e => e.LoanToValueRatio)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Loan to Value Ratio")
                    .IsFixedLength();

                entity.Property(e => e.LonfrmReportMthd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LONFRM Report Mthd")
                    .IsFixedLength();

                entity.Property(e => e.MajorLineNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Major Line Number")
                    .IsFixedLength();

                entity.Property(e => e.MatDateAtRenewal)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Mat. Date at Renewal")
                    .IsFixedLength();

                entity.Property(e => e.MaturityDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Maturity Date")
                    .IsFixedLength();

                entity.Property(e => e.MaxLifeDecrease)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Max Life Decrease")
                    .IsFixedLength();

                entity.Property(e => e.MaxLifeIncrease)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Max Life Increase")
                    .IsFixedLength();

                entity.Property(e => e.MaxRtDecEachOcc)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Max Rt Dec Each Occ")
                    .IsFixedLength();

                entity.Property(e => e.MaxRtIncEachOcc)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Max Rt Inc Each Occ")
                    .IsFixedLength();

                entity.Property(e => e.MaxYearlyDecrease)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Max Yearly Decrease")
                    .IsFixedLength();

                entity.Property(e => e.MaxYearlyIncrease)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Max Yearly Increase")
                    .IsFixedLength();

                entity.Property(e => e.MaximumLateCharge)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Maximum Late Charge")
                    .IsFixedLength();

                entity.Property(e => e.MinIntAmount)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Min Int Amount-")
                    .IsFixedLength();

                entity.Property(e => e.MinRateChgAllowd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Min Rate Chg Allowd")
                    .IsFixedLength();

                entity.Property(e => e.MinimumBillingAmt)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Minimum Billing Amt")
                    .IsFixedLength();

                entity.Property(e => e.MiscEscrowDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Misc Escrow Date")
                    .IsFixedLength();

                entity.Property(e => e.MiscLoanField)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Misc Loan Field")
                    .IsFixedLength();

                entity.Property(e => e.MiscUser2)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Misc User #2")
                    .IsFixedLength();

                entity.Property(e => e.MobAhBillUnpaid)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB AH Bill Unpaid")
                    .IsFixedLength();

                entity.Property(e => e.MobAhEarnedMtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB AH Earned MTD")
                    .IsFixedLength();

                entity.Property(e => e.MobAhEarnedToday)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB AH Earned Today")
                    .IsFixedLength();

                entity.Property(e => e.MobAhEndDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB AH End Date")
                    .IsFixedLength();

                entity.Property(e => e.MobAhLastBilled)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB AH Last Billed")
                    .IsFixedLength();

                entity.Property(e => e.MobAhMonthFactor)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MOB AH Month Factor")
                    .IsFixedLength();

                entity.Property(e => e.MobAhPaidMtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB AH Paid MTD")
                    .IsFixedLength();

                entity.Property(e => e.MobAhPlanCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MOB AH Plan Code")
                    .IsFixedLength();

                entity.Property(e => e.MobAhStartDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB AH Start Date")
                    .IsFixedLength();

                entity.Property(e => e.MobAhTotalEarned)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MOB AH Total Earned")
                    .IsFixedLength();

                entity.Property(e => e.MobAhTotalPaid)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB AH Total Paid")
                    .IsFixedLength();

                entity.Property(e => e.MobClBillUnpaid)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB CL Bill Unpaid")
                    .IsFixedLength();

                entity.Property(e => e.MobClEarnedMtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB CL Earned MTD")
                    .IsFixedLength();

                entity.Property(e => e.MobClEarnedToday)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB CL Earned Today")
                    .IsFixedLength();

                entity.Property(e => e.MobClEndDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB CL End Date")
                    .IsFixedLength();

                entity.Property(e => e.MobClLastBilled)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB CL Last Billed")
                    .IsFixedLength();

                entity.Property(e => e.MobClMonthFactor)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MOB CL Month Factor")
                    .IsFixedLength();

                entity.Property(e => e.MobClPaidMtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB CL Paid MTD")
                    .IsFixedLength();

                entity.Property(e => e.MobClPlanCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MOB CL Plan Code")
                    .IsFixedLength();

                entity.Property(e => e.MobClStartDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB CL Start Date")
                    .IsFixedLength();

                entity.Property(e => e.MobClTotalEarned)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MOB CL Total Earned")
                    .IsFixedLength();

                entity.Property(e => e.MobClTotalPaid)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB CL Total Paid")
                    .IsFixedLength();

                entity.Property(e => e.MobPremLastBilled)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB Prem Last Billed")
                    .IsFixedLength();

                entity.Property(e => e.MobPremiumAmount)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB Premium Amount")
                    .IsFixedLength();

                entity.Property(e => e.MobPremiumPdTotal)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB Premium Pd Total")
                    .IsFixedLength();

                entity.Property(e => e.MobPremiumUnpaid)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MOB Premium Unpaid")
                    .IsFixedLength();

                entity.Property(e => e.ModificationDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Modification Date")
                    .IsFixedLength();

                entity.Property(e => e.MortInterestRefund)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Mort Interest Refund")
                    .IsFixedLength();

                entity.Property(e => e.MortgageIns)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Mortgage Ins")
                    .IsFixedLength();

                entity.Property(e => e.MultipleNotices)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Multiple Notices?")
                    .IsFixedLength();

                entity.Property(e => e.NewPaymentA)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New Payment A")
                    .IsFixedLength();

                entity.Property(e => e.NewPaymentE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("New Payment E")
                    .IsFixedLength();

                entity.Property(e => e.NextBaseRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Next Base Rate")
                    .IsFixedLength();

                entity.Property(e => e.NextPaymentDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Next Payment Date")
                    .IsFixedLength();

                entity.Property(e => e.NextRepricingDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Next Repricing Date")
                    .IsFixedLength();

                entity.Property(e => e.NonAccrualChargoff)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NonAccrual/Chargoff")
                    .IsFixedLength();

                entity.Property(e => e.NonAccrualEa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NonAccrual Ea")
                    .IsFixedLength();

                entity.Property(e => e.NonAccrualI)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Non-Accrual I")
                    .IsFixedLength();

                entity.Property(e => e.NonAccrualIenc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Non-Accrual IENC")
                    .IsFixedLength();

                entity.Property(e => e.NonAccrualPa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NonAccrual Pa")
                    .IsFixedLength();

                entity.Property(e => e.NoticeNumber)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Notice Number")
                    .IsFixedLength();

                entity.Property(e => e.NumberOfRenewals)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Number of Renewals")
                    .IsFixedLength();

                entity.Property(e => e.OfBalForPymt)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("% Of Bal for Pymt")
                    .IsFixedLength();

                entity.Property(e => e.OfExtensions)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("# of Extensions")
                    .IsFixedLength();

                entity.Property(e => e.OnLineDelqPymnt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("On-line Delq Pymnt")
                    .IsFixedLength();

                entity.Property(e => e.OrigDivisio)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Orig. Divisio")
                    .IsFixedLength();

                entity.Property(e => e.OriginalCommitAmt)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Original Commit Amt")
                    .IsFixedLength();

                entity.Property(e => e.OriginalIntRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Original Int Rate")
                    .IsFixedLength();

                entity.Property(e => e.OriginalLoanAmt)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Original Loan Amt")
                    .IsFixedLength();

                entity.Property(e => e.OriginationFee)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Origination Fee")
                    .IsFixedLength();

                entity.Property(e => e.PDChgsCollected)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("P/D Chgs Collected")
                    .IsFixedLength();

                entity.Property(e => e.PIPayment)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("P&I Payment")
                    .IsFixedLength();

                entity.Property(e => e.ParChgOffI)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Par Chg Off I")
                    .IsFixedLength();

                entity.Property(e => e.ParChgOffIntTdy)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Par Chg-Off Int Tdy")
                    .IsFixedLength();

                entity.Property(e => e.PartChgOffIenc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Part Chg-Off IENC")
                    .IsFixedLength();

                entity.Property(e => e.PartMasterLoan)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Part. Master Loan #")
                    .IsFixedLength();

                entity.Property(e => e.PartialChgOffBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Partial Chg-Off Bal")
                    .IsFixedLength();

                entity.Property(e => e.PartialPayme)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Partial Payme")
                    .IsFixedLength();

                entity.Property(e => e.ParticipationCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Participation Code")
                    .IsFixedLength();

                entity.Property(e => e.PastDueChgsEarnd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Past Due Chgs Earnd")
                    .IsFixedLength();

                entity.Property(e => e.PayScheduleType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Pay Schedule Type")
                    .IsFixedLength();

                entity.Property(e => e.PaymentApplyCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Payment Apply Code")
                    .IsFixedLength();

                entity.Property(e => e.PaymentFrequency)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Payment Frequency")
                    .IsFixedLength();

                entity.Property(e => e.PaymentRating)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Payment Rating")
                    .IsFixedLength();

                entity.Property(e => e.PaymentRecalcDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Payment Recalc Date")
                    .IsFixedLength();

                entity.Property(e => e.PaymentRecalcFreq)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Payment Recalc Freq")
                    .IsFixedLength();

                entity.Property(e => e.PaymentScheduleFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Payment Schedule Flg")
                    .IsFixedLength();

                entity.Property(e => e.PaymentSourceCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Payment Source Code")
                    .IsFixedLength();

                entity.Property(e => e.PaymentToCalcAmt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Payment to CALC Amt")
                    .IsFixedLength();

                entity.Property(e => e.PaymentsReceived)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Payments Received")
                    .IsFixedLength();

                entity.Property(e => e.PaymtOnDelinquent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Paymt on Delinquent")
                    .IsFixedLength();

                entity.Property(e => e.PayoffAtMaturity)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Payoff at Maturity")
                    .IsFixedLength();

                entity.Property(e => e.PayoffReported)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Payoff Reported")
                    .IsFixedLength();

                entity.Property(e => e.PayrollPayme)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Payroll Payme")
                    .IsFixedLength();

                entity.Property(e => e.PendingAchTran)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Pending ACH Tran")
                    .IsFixedLength();

                entity.Property(e => e.PerilInsPo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Peril Ins. Po")
                    .IsFixedLength();

                entity.Property(e => e.PmtCalcDayOfMth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Pmt Calc Day of Mth")
                    .IsFixedLength();

                entity.Property(e => e.PmtChgNoticeTdy)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Pmt Chg Notice Tdy")
                    .IsFixedLength();

                entity.Property(e => e.PmtSplitPriorFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Pmt Split Prior Flg")
                    .IsFixedLength();

                entity.Property(e => e.PointsCollec)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Points Collec")
                    .IsFixedLength();

                entity.Property(e => e.PointsReportable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Points Reportable")
                    .IsFixedLength();

                entity.Property(e => e.PrePayPerCentage)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PrePay PerCentage")
                    .IsFixedLength();

                entity.Property(e => e.PrePayPnltyExpDt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PrePay Pnlty Exp Dt")
                    .IsFixedLength();

                entity.Property(e => e.PrepaymentPenalty)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Prepayment Penalty")
                    .IsFixedLength();

                entity.Property(e => e.PreviousBaseRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Previous Base Rate")
                    .IsFixedLength();

                entity.Property(e => e.PreviousBaseRate1)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Previous Base Rate1")
                    .IsFixedLength();

                entity.Property(e => e.PreviousIntRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Previous Int Rate")
                    .IsFixedLength();

                entity.Property(e => e.PrincBilled)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Princ Billed")
                    .IsFixedLength();

                entity.Property(e => e.PrincipalDue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Principal Due")
                    .IsFixedLength();

                entity.Property(e => e.PriorYearsI)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Prior Years I")
                    .IsFixedLength();

                entity.Property(e => e.PrntPayDueNotice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Prnt Pay Due Notice")
                    .IsFixedLength();

                entity.Property(e => e.PymntDayOfMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Pymnt Day of Month")
                    .IsFixedLength();

                entity.Property(e => e.PymtNoticeFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Pymt Notice Flag")
                    .IsFixedLength();

                entity.Property(e => e.QtdAggregateBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("QTD Aggregate Bal")
                    .IsFixedLength();

                entity.Property(e => e.QtdHighBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("QTD High Balance")
                    .IsFixedLength();

                entity.Property(e => e.QtdInterest)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("QTD Interest")
                    .IsFixedLength();

                entity.Property(e => e.RateAdjustment)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Rate Adjustment")
                    .IsFixedLength();

                entity.Property(e => e.RateChgNoticeTdy)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Rate Chg Notice Tdy")
                    .IsFixedLength();

                entity.Property(e => e.RatingCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Rating Code")
                    .IsFixedLength();

                entity.Property(e => e.RecalculateP)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Recalculate P")
                    .IsFixedLength();

                entity.Property(e => e.RegularPayme)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Regular Payme")
                    .IsFixedLength();

                entity.Property(e => e.RenewalCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Renewal Code")
                    .IsFixedLength();

                entity.Property(e => e.ReportToCrBureau)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Report to Cr Bureau?")
                    .IsFixedLength();

                entity.Property(e => e.RepossessionStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Repossession Status")
                    .IsFixedLength();

                entity.Property(e => e.ReservedForFuture)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Reserved for Future")
                    .IsFixedLength();

                entity.Property(e => e.RevolvCreditPlan)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Revolv Credit Plan#")
                    .IsFixedLength();

                entity.Property(e => e.RightToCureDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Right to Cure Date")
                    .IsFixedLength();

                entity.Property(e => e.RightToCureReset)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Right to Cure Reset")
                    .IsFixedLength();

                entity.Property(e => e.RiskBasedCap)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Risk Based Cap %")
                    .IsFixedLength();

                entity.Property(e => e.RlvCrIntLstStmt)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Rlv Cr Int Lst Stmt")
                    .IsFixedLength();

                entity.Property(e => e.RskBsCapGuar)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Rsk Bs Cap % Guar")
                    .IsFixedLength();

                entity.Property(e => e.RtChgDayOfMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Rt Chg Day of Month")
                    .IsFixedLength();

                entity.Property(e => e.SbaBasisPoints)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SBA Basis Points")
                    .IsFixedLength();

                entity.Property(e => e.SbaLatePmtDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SBA Late Pmt Date")
                    .IsFixedLength();

                entity.Property(e => e.SbaLoanStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SBA Loan Status")
                    .IsFixedLength();

                entity.Property(e => e.ScheduledRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Scheduled Rate")
                    .IsFixedLength();

                entity.Property(e => e.SecByResComMtg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Sec.by Res/Com Mtg.")
                    .IsFixedLength();

                entity.Property(e => e.SecondMktLoanTyp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Second Mkt Loan Typ")
                    .IsFixedLength();

                entity.Property(e => e.SecurityCodes)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Security Codes")
                    .IsFixedLength();

                entity.Property(e => e.SecurityValue)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Security Value")
                    .IsFixedLength();

                entity.Property(e => e.SimpIntDealType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Simp Int Deal Type")
                    .IsFixedLength();

                entity.Property(e => e.SimpleIntDealRte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Simple Int Deal Rte")
                    .IsFixedLength();

                entity.Property(e => e.SpecialInstruction)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Special Instruction")
                    .IsFixedLength();

                entity.Property(e => e.SpecificProv)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Specific Prov")
                    .IsFixedLength();

                entity.Property(e => e.SplitParticPymnt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Split Partic. Pymnt")
                    .IsFixedLength();

                entity.Property(e => e.StopPayChargeFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Stop Pay Charge Flag")
                    .IsFixedLength();

                entity.Property(e => e.StopPayNoticeFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Stop Pay Notice Flag")
                    .IsFixedLength();

                entity.Property(e => e.StudentAllowCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Student Allow Code")
                    .IsFixedLength();

                entity.Property(e => e.StudentBillCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Student Bill Code")
                    .IsFixedLength();

                entity.Property(e => e.StudentFeeCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Student Fee Code")
                    .IsFixedLength();

                entity.Property(e => e.StudentLoanReport)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Student Loan Report")
                    .IsFixedLength();

                entity.Property(e => e.StudentTypeCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Student Type Code")
                    .IsFixedLength();

                entity.Property(e => e.SweepPaysExempt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Sweep Pays Exempt")
                    .IsFixedLength();

                entity.Property(e => e.Term)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TitleDateDue)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Title Date Due")
                    .IsFixedLength();

                entity.Property(e => e.TitleInspectionDt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Title Inspection Dt")
                    .IsFixedLength();

                entity.Property(e => e.TodaySPayoff)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Today's Payoff")
                    .IsFixedLength();

                entity.Property(e => e.TotIntrPdL)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tot Intr Pd L")
                    .IsFixedLength();

                entity.Property(e => e.TotalAmountDue)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Total Amount Due")
                    .IsFixedLength();

                entity.Property(e => e.TotalHoldAm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Total Hold Am")
                    .IsFixedLength();

                entity.Property(e => e.TotalInsuranceAdj)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Total Insurance Adj")
                    .IsFixedLength();

                entity.Property(e => e.TrwLoanType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRW Loan Type")
                    .IsFixedLength();

                entity.Property(e => e.TrwStatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRW Status Code")
                    .IsFixedLength();

                entity.Property(e => e.TtlAnnFeesNotPd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Ttl Ann Fees Not Pd")
                    .IsFixedLength();

                entity.Property(e => e.TtlInsBilld)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Ttl Ins Billd")
                    .IsFixedLength();

                entity.Property(e => e.TypeAH)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Type A & H")
                    .IsFixedLength();

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Type Code")
                    .IsFixedLength();

                entity.Property(e => e.TypeCreditLife)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Type Credit Life")
                    .IsFixedLength();

                entity.Property(e => e.Ucc1ExpirationDte)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("UCC1 Expiration Dte")
                    .IsFixedLength();

                entity.Property(e => e.UnappliedPay)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Unapplied Pay")
                    .IsFixedLength();

                entity.Property(e => e.UnsecuredLoan)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Unsecured Loan?")
                    .IsFixedLength();

                entity.Property(e => e.UnusedCreditCommit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Unused Credit/Commit")
                    .IsFixedLength();

                entity.Property(e => e.ValuationReport)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Valuation Report")
                    .IsFixedLength();

                entity.Property(e => e.ValueLifeIns)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Value Life Ins.")
                    .IsFixedLength();

                entity.Property(e => e.ValueMotorIns)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Value Motor Ins.")
                    .IsFixedLength();

                entity.Property(e => e.ValuePerilIns)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Value Peril Ins.")
                    .IsFixedLength();

                entity.Property(e => e.VariableRateCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Variable Rate Code")
                    .IsFixedLength();

                entity.Property(e => e.VariableRateFreq)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Variable Rate Freq")
                    .IsFixedLength();

                entity.Property(e => e.WhoseAccount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Whose Account")
                    .IsFixedLength();

                entity.Property(e => e.YtdAggBalOnly)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("YTD Agg Bal ($only)")
                    .IsFixedLength();

                entity.Property(e => e.YtdIntCollOnExt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("YTD Int Coll on Ext")
                    .IsFixedLength();

                entity.Property(e => e.YtdInterest)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YTD Interest")
                    .IsFixedLength();

                entity.Property(e => e.YtdLateChgsPaid)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("YTD Late Chgs Paid")
                    .IsFixedLength();

                entity.Property(e => e.YtdReTaxes)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YTD RE Taxes")
                    .IsFixedLength();

                entity.Property(e => e._1098Required)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("1098 Required")
                    .IsFixedLength();

                entity.Property(e => e._416ApplyPrincipal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("416 Apply Principal")
                    .IsFixedLength();
            });

            modelBuilder.Entity<LoanKey>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Loan_Key");

                entity.Property(e => e.ACType)
                    .HasMaxLength(255)
                    .HasColumnName("A/C Type ");

                entity.Property(e => e.AD)
                    .HasMaxLength(255)
                    .HasColumnName("A/D ");

                entity.Property(e => e.Chg).HasColumnName("CHG ");

                entity.Property(e => e.CrDb)
                    .HasMaxLength(255)
                    .HasColumnName("CR DB ");

                entity.Property(e => e.FieldDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Field Description  ");

                entity.Property(e => e.FldLen).HasColumnName("Fld Len ");

                entity.Property(e => e.FldNum).HasColumnName("Fld Num ");

                entity.Property(e => e.GLCol).HasColumnName("G/L Col ");

                entity.Property(e => e.GlClrFlg)
                    .HasMaxLength(255)
                    .HasColumnName("GL Clr Flg ");

                entity.Property(e => e.HelpDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Help Description");

                entity.Property(e => e.Inq).HasColumnName("INQ ");

                entity.Property(e => e.LastLocation).HasColumnName("Last location");

                entity.Property(e => e.Lc)
                    .HasMaxLength(255)
                    .HasColumnName("LC ");

                entity.Property(e => e.LmtCod).HasColumnName("Lmt Cod ");

                entity.Property(e => e.Upd).HasColumnName("UPD ");

                entity.Property(e => e.Usr)
                    .HasMaxLength(255)
                    .HasColumnName("USR ");

                entity.Property(e => e._1stMastLoc).HasColumnName(" 1st Mast Loc ");
            });

            modelBuilder.Entity<Sav>(entity =>
            {
                entity.ToTable("SAV");

                entity.Property(e => e.SavId).HasColumnName("SAV_ID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Account_Number")
                    .IsFixedLength();

                entity.Property(e => e.AccrInt1st)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Accr Int 1st")
                    .IsFixedLength();

                entity.Property(e => e.AccrInt2nd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Accr Int 2nd")
                    .IsFixedLength();

                entity.Property(e => e.AcctForInterest)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Acct # for Interest")
                    .IsFixedLength();

                entity.Property(e => e.AcctToTrnsfrFrom)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Acct to Trnsfr From")
                    .IsFixedLength();

                entity.Property(e => e.AcctTypeForIntr)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Acct Type for Intr")
                    .IsFixedLength();

                entity.Property(e => e.AchAccountNumber)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("ACH Account Number")
                    .IsFixedLength();

                entity.Property(e => e.AchPositivePay)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACH Positive Pay?")
                    .IsFixedLength();

                entity.Property(e => e.AchRoutingNumber)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ACH Routing Number")
                    .IsFixedLength();

                entity.Property(e => e.AchTransactionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ACH Transaction Code")
                    .IsFixedLength();

                entity.Property(e => e.AggBalSinLstInt)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Agg Bal Sin Lst Int")
                    .IsFixedLength();

                entity.Property(e => e.AggDrsSince)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Agg Drs Since")
                    .IsFixedLength();

                entity.Property(e => e.AggFltSinL)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Agg Flt Sin L")
                    .IsFixedLength();

                entity.Property(e => e.AggODCollBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Agg O/D Coll Bal")
                    .IsFixedLength();

                entity.Property(e => e.AggODLedgerBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Agg O/D Ledger Bal")
                    .IsFixedLength();

                entity.Property(e => e.AggOdBalLstInt)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Agg OD Bal Lst Int")
                    .IsFixedLength();

                entity.Property(e => e.AggOdCollLstInt)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Agg OD Coll Lst Int")
                    .IsFixedLength();

                entity.Property(e => e.AggregateBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Aggregate Balance")
                    .IsFixedLength();

                entity.Property(e => e.AggregateFlo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Aggregate Flo")
                    .IsFixedLength();

                entity.Property(e => e.AggregateFloatLstStmt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Aggregate Float lst Stmt")
                    .IsFixedLength();

                entity.Property(e => e.AmountChargedOff)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Amount Charged Off")
                    .IsFixedLength();

                entity.Property(e => e.AmtIntErnL)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Amt Int Ern L")
                    .IsFixedLength();

                entity.Property(e => e.AprilAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("April Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.AtmAccountCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ATM Account Code")
                    .IsFixedLength();

                entity.Property(e => e.AtmCrPriorYear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ATM Cr Prior Year")
                    .IsFixedLength();

                entity.Property(e => e.AtmCrSinceSerChg)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ATM Cr Since Ser Chg")
                    .IsFixedLength();

                entity.Property(e => e.AtmCreditsMtd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ATM Credits MTD")
                    .IsFixedLength();

                entity.Property(e => e.AtmCreditsYtd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ATM Credits YTD")
                    .IsFixedLength();

                entity.Property(e => e.AtmUsageCreditCtd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ATM Usage Credit CTD")
                    .IsFixedLength();

                entity.Property(e => e.AtmWDSinLstSC)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ATM W/D Sin Lst S/C")
                    .IsFixedLength();

                entity.Property(e => e.AugustAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("August Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.Autoclose)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Autoclose?")
                    .IsFixedLength();

                entity.Property(e => e.AvailableBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Available Balance")
                    .IsFixedLength();

                entity.Property(e => e.BeginningBalToday)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Beginning Bal Today")
                    .IsFixedLength();

                entity.Property(e => e.ChargeOffRecovery)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Charge Off Recovery")
                    .IsFixedLength();

                entity.Property(e => e.ChargedOff)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Charged Off?")
                    .IsFixedLength();

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Class Code")
                    .IsFixedLength();

                entity.Property(e => e.ClubDenomAmount)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Club Denom Amount")
                    .IsFixedLength();

                entity.Property(e => e.CollectedBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Collected Balance")
                    .IsFixedLength();

                entity.Property(e => e.ComtelBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("COMTEL Balance")
                    .IsFixedLength();

                entity.Property(e => e.ConsecutiveDaysOd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Consecutive Days OD")
                    .IsFixedLength();

                entity.Property(e => e.CorrespondingAcct)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Corresponding Acct")
                    .IsFixedLength();

                entity.Property(e => e.CreditsSinceSC)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("# Credits Since S/C")
                    .IsFixedLength();

                entity.Property(e => e.CshMgmt2nd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Csh Mgmt 2nd")
                    .IsFixedLength();

                entity.Property(e => e.CshMgmt2ndToAcct)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Csh Mgmt 2nd to Acct")
                    .IsFixedLength();

                entity.Property(e => e.CshMgmtRepoFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Csh Mgmt Repo Flag")
                    .IsFixedLength();

                entity.Property(e => e.CshMgt2ndFrmAcct)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Csh Mgt 2nd Frm Acct")
                    .IsFixedLength();

                entity.Property(e => e.CshMgt2ndFromTyp)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Csh Mgt 2nd From Typ")
                    .IsFixedLength();

                entity.Property(e => e.CshMgtCollBalFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Csh Mgt Coll Bal Flg")
                    .IsFixedLength();

                entity.Property(e => e.CtdAverageBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CTD Average Balance")
                    .IsFixedLength();

                entity.Property(e => e.CtdAverageBalanceYtd)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CTD Average Balance YTD")
                    .IsFixedLength();

                entity.Property(e => e.CtdAverageF)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CTD Average F")
                    .IsFixedLength();

                entity.Property(e => e.CtdCredits)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CTD Credits")
                    .IsFixedLength();

                entity.Property(e => e.CtdDebits)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CTD Debits")
                    .IsFixedLength();

                entity.Property(e => e.CtdLowBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CTD Low Balance")
                    .IsFixedLength();

                entity.Property(e => e.CurrentBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Current Balance")
                    .IsFixedLength();

                entity.Property(e => e.CurrentViolation)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Current Violation")
                    .IsFixedLength();

                entity.Property(e => e.Cyc12IntErn1231)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CYC1-2 INT ERN 1231")
                    .IsFixedLength();

                entity.Property(e => e.CycleCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Cycle Code")
                    .IsFixedLength();

                entity.Property(e => e.DailyWireLi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Daily Wire Li")
                    .IsFixedLength();

                entity.Property(e => e.DatalinkMtdVceInq)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Datalink MTD Vce Inq")
                    .IsFixedLength();

                entity.Property(e => e.DatalinkYtdVceInq)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Datalink YTD Vce Inq")
                    .IsFixedLength();

                entity.Property(e => e.DateChargedOff)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Charged Off")
                    .IsFixedLength();

                entity.Property(e => e.DateIntLastPaid)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Int Last Paid")
                    .IsFixedLength();

                entity.Property(e => e.DateLastCycled)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Last Cycled")
                    .IsFixedLength();

                entity.Property(e => e.DateLastDeposit)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Last Deposit")
                    .IsFixedLength();

                entity.Property(e => e.DateLastServChg)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Last Serv Chg")
                    .IsFixedLength();

                entity.Property(e => e.DateLastWithdrawal)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Last Withdrawal")
                    .IsFixedLength();

                entity.Property(e => e.DateLstStmPrinted)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Lst Stm Printed")
                    .IsFixedLength();

                entity.Property(e => e.DateOfRecovery)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date of Recovery")
                    .IsFixedLength();

                entity.Property(e => e.DatePrevIntPymt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Prev Int Pymt")
                    .IsFixedLength();

                entity.Property(e => e.DatePrevSerCharge)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Prev Ser Charge")
                    .IsFixedLength();

                entity.Property(e => e.DatePrevStatement)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Date Prev Statement")
                    .IsFixedLength();

                entity.Property(e => e.DebitsSinceSC)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("# Debits Since S/C")
                    .IsFixedLength();

                entity.Property(e => e.DecemberAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("December Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.DiscountOnSC)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("% Discount on S/C")
                    .IsFixedLength();

                entity.Property(e => e.DsiImageFrBack)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DSI Image Fr/Back")
                    .IsFixedLength();

                entity.Property(e => e.DsiImageHorzPage)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DSI Image-Horz Page")
                    .IsFixedLength();

                entity.Property(e => e.DsiImagePgeFmt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DSI Image - Pge Fmt")
                    .IsFixedLength();

                entity.Property(e => e.DsiImageVerImage)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DSI Image-Ver Image")
                    .IsFixedLength();

                entity.Property(e => e.EarlyWDPenalty)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Early W/D Penalty")
                    .IsFixedLength();

                entity.Property(e => e.ExemptAutoChgOff)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Exempt Auto-Chg Off?")
                    .IsFixedLength();

                entity.Property(e => e.ExemptChargeback)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Exempt Chargeback?")
                    .IsFixedLength();

                entity.Property(e => e.ExemptForAtmSC)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Exempt For ATM S/C?")
                    .IsFixedLength();

                entity.Property(e => e.ExmpODNsfCharge)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Exmp O/D-NSF Charge")
                    .IsFixedLength();

                entity.Property(e => e.FebruaryAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("February Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.ForeignAtmCrMtd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Foreign ATM Cr MTD")
                    .IsFixedLength();

                entity.Property(e => e.ForeignAtmCrYtd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Foreign ATM Cr YTD")
                    .IsFixedLength();

                entity.Property(e => e.ForeignAtmWD)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Foreign ATM W/D")
                    .IsFixedLength();

                entity.Property(e => e.ForeignAtmWDMtd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Foreign ATM W/D MTD")
                    .IsFixedLength();

                entity.Property(e => e.ForeignAtmWDYtd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Foreign ATM W/D YTD")
                    .IsFixedLength();

                entity.Property(e => e.FrAtmCrSncSerCh)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Fr ATM Cr Snc Ser Ch")
                    .IsFixedLength();

                entity.Property(e => e.FraudAlertFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Fraud Alert Flag")
                    .IsFixedLength();

                entity.Property(e => e.FrgnAtmCrPrYear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Frgn ATM Cr Pr Year")
                    .IsFixedLength();

                entity.Property(e => e.FrnAtmWDPrYr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Frn ATM W/D Pr Yr")
                    .IsFixedLength();

                entity.Property(e => e.HighBalanceAmount)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("High-Balance Amount")
                    .IsFixedLength();

                entity.Property(e => e.IncludeAchIndId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Include ACH Ind ID#")
                    .IsFixedLength();

                entity.Property(e => e.InterestDispCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Interest Disp Code")
                    .IsFixedLength();

                entity.Property(e => e.InterestEarned)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Interest Earned")
                    .IsFixedLength();

                entity.Property(e => e.InterestPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Interest Paid")
                    .IsFixedLength();

                entity.Property(e => e.InterestRate)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Interest Rate")
                    .IsFixedLength();

                entity.Property(e => e.InterestRateAdj)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Interest Rate Adj")
                    .IsFixedLength();

                entity.Property(e => e.JanuaryAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("January Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.JulyAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("July Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.JuneAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("June Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.LastDeposit)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Last Deposit")
                    .IsFixedLength();

                entity.Property(e => e.LastInterest)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Last Interest")
                    .IsFixedLength();

                entity.Property(e => e.LastStmtBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Last Stmt Balance")
                    .IsFixedLength();

                entity.Property(e => e.LastWDAmou)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Last W/D Amou")
                    .IsFixedLength();

                entity.Property(e => e.LastYearOdDays)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Last Year OD Days")
                    .IsFixedLength();

                entity.Property(e => e.LowBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Low Balance")
                    .IsFixedLength();

                entity.Property(e => e.LowBalanceAmount)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Low Balance Amount")
                    .IsFixedLength();

                entity.Property(e => e.LowCollBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Low Coll Balance")
                    .IsFixedLength();

                entity.Property(e => e.LowCollectedBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Low Collected Bal")
                    .IsFixedLength();

                entity.Property(e => e.MarchAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("March Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.MayAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("May Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.MemoBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Memo Balance")
                    .IsFixedLength();

                entity.Property(e => e.MtdAggregateBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("MTD Aggregate Bal")
                    .IsFixedLength();

                entity.Property(e => e.MtdWithdrawals)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MTD Withdrawals")
                    .IsFixedLength();

                entity.Property(e => e.MultipleStatements)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Multiple Statements?")
                    .IsFixedLength();

                entity.Property(e => e.NbrAtmWDPriorYr)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Nbr ATM W/D Prior Yr")
                    .IsFixedLength();

                entity.Property(e => e.NovemberAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("November Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.NumberAtmWDMtd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Number ATM W/D MTD")
                    .IsFixedLength();

                entity.Property(e => e.NumberAtmWDYtd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Number ATM W/D YTD")
                    .IsFixedLength();

                entity.Property(e => e.ODChargesYtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("O/D Charges YTD")
                    .IsFixedLength();

                entity.Property(e => e.ODChgsThisCycle)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("O/D Chgs this Cycle")
                    .IsFixedLength();

                entity.Property(e => e.OctoberAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("October Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.OdNsfChgPrvYear)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("OD/NSF Chg Prv Year")
                    .IsFixedLength();

                entity.Property(e => e.OdNsfChgYtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("OD/NSF Chg YTD")
                    .IsFixedLength();

                entity.Property(e => e.OpeningDepA)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Opening Dep A")
                    .IsFixedLength();

                entity.Property(e => e.Over15DayF)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Over 15 Day F")
                    .IsFixedLength();

                entity.Property(e => e.PassbookBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Passbook Balance")
                    .IsFixedLength();

                entity.Property(e => e.PassbookDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Passbook Date")
                    .IsFixedLength();

                entity.Property(e => e.PassbookFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Passbook Flag")
                    .IsFixedLength();

                entity.Property(e => e.PrevExcessViol)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Prev Excess Viol")
                    .IsFixedLength();

                entity.Property(e => e.PrevServChgCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Prev Serv Chg Code")
                    .IsFixedLength();

                entity.Property(e => e.PrevStmtBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Prev Stmt Balance")
                    .IsFixedLength();

                entity.Property(e => e.PreviousCycleDate)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Previous Cycle Date")
                    .IsFixedLength();

                entity.Property(e => e.PrintDebitsCredit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Print Debits/Credit")
                    .IsFixedLength();

                entity.Property(e => e.PriorDayUncollBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Prior Day Uncoll Bal")
                    .IsFixedLength();

                entity.Property(e => e.PriorYrRegDdOD)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Prior Yr Reg DD O/D")
                    .IsFixedLength();

                entity.Property(e => e.PriorYrRetItmChg)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Prior Yr Ret Itm Chg")
                    .IsFixedLength();

                entity.Property(e => e.QtdHighBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("QTD High Balance")
                    .IsFixedLength();

                entity.Property(e => e.QtdInterest)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("QTD Interest")
                    .IsFixedLength();

                entity.Property(e => e.RateCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Rate Code")
                    .IsFixedLength();

                entity.Property(e => e.RetChgsThisCycle)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Ret Chgs this Cycle")
                    .IsFixedLength();

                entity.Property(e => e.ReturnItemChgsYtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Return Item Chgs YTD")
                    .IsFixedLength();

                entity.Property(e => e.SChgsReversedPyr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("S/Chgs Reversed PYr")
                    .IsFixedLength();

                entity.Property(e => e.SChgsReversedYtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("S/Chgs Reversed YTD")
                    .IsFixedLength();

                entity.Property(e => e.SeptemberAvgBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("September Avg Bal")
                    .IsFixedLength();

                entity.Property(e => e.SerChgsWaiv)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Ser Chgs Waiv")
                    .IsFixedLength();

                entity.Property(e => e.SerChgsWaivedYtd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Ser Chgs Waived YTD")
                    .IsFixedLength();

                entity.Property(e => e.SerChrgWaiveDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Ser Chrg Waive Date")
                    .IsFixedLength();

                entity.Property(e => e.ServChargeAssessed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Serv Charge Assessed")
                    .IsFixedLength();

                entity.Property(e => e.ServiceChargeCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Service Charge Code")
                    .IsFixedLength();

                entity.Property(e => e.ServiceChgWaiveCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Service Chg Waive Cd")
                    .IsFixedLength();

                entity.Property(e => e.StatementFormat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Statement Format")
                    .IsFixedLength();

                entity.Property(e => e.StatementMessCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Statement Mess Code")
                    .IsFixedLength();

                entity.Property(e => e.StmtRequestCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Stmt Request Code")
                    .IsFixedLength();

                entity.Property(e => e.StmtSrtPrAcctFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Stmt Srt Pr Acct Flg")
                    .IsFixedLength();

                entity.Property(e => e.StopPyAutoChgFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Stop Py Auto Chg Flg")
                    .IsFixedLength();

                entity.Property(e => e.StopPyNoticeFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Stop Py Notice Flag")
                    .IsFixedLength();

                entity.Property(e => e.SuppressNsfNotice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Suppress NSF Notice?")
                    .IsFixedLength();

                entity.Property(e => e.TotalHoldAm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Total Hold Am")
                    .IsFixedLength();

                entity.Property(e => e.TotalInclearings)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Total Inclearings")
                    .IsFixedLength();

                entity.Property(e => e.TransferFromType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Transfer From Type")
                    .IsFixedLength();

                entity.Property(e => e.TransferInAmount)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Transfer In Amount")
                    .IsFixedLength();

                entity.Property(e => e.TransferOutAmount)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Transfer Out Amount")
                    .IsFixedLength();

                entity.Property(e => e.TransferSerChgIn)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Transfer Ser Chg In")
                    .IsFixedLength();

                entity.Property(e => e.TransferSerChgOut)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Transfer Ser Chg Out")
                    .IsFixedLength();

                entity.Property(e => e.TransferToAccount)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Transfer to Account")
                    .IsFixedLength();

                entity.Property(e => e.TransferToType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Transfer to Type")
                    .IsFixedLength();

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Type Code")
                    .IsFixedLength();

                entity.Property(e => e.USEquivalent)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("U.S. Equivalent")
                    .IsFixedLength();

                entity.Property(e => e.UncollectedBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Uncollected Balance")
                    .IsFixedLength();

                entity.Property(e => e.UnpostToday)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UNPOST Today")
                    .IsFixedLength();

                entity.Property(e => e.UseAchFilters)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Use ACH Filters?")
                    .IsFixedLength();

                entity.Property(e => e.ViolationHistory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Violation History")
                    .IsFixedLength();

                entity.Property(e => e.WaiveAtmUsageCr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Waive ATM Usage CR")
                    .IsFixedLength();

                entity.Property(e => e.WaiveWireFee)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Waive Wire Fee")
                    .IsFixedLength();

                entity.Property(e => e.YtdAverageBalance)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("YTD Average Balance")
                    .IsFixedLength();

                entity.Property(e => e.YtdAverageBalanceYtd)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("YTD Average Balance YTD")
                    .IsFixedLength();

                entity.Property(e => e.YtdCreditCount)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("YTD Credit Count")
                    .IsFixedLength();

                entity.Property(e => e.YtdDebitCount)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("YTD Debit Count")
                    .IsFixedLength();

                entity.Property(e => e.YtdInterest)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("YTD Interest")
                    .IsFixedLength();

                entity.Property(e => e.YtdOverdrawnDays)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("YTD Overdrawn Days")
                    .IsFixedLength();

                entity.Property(e => e.YtdServiceCharge)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("YTD Service Charge")
                    .IsFixedLength();

                entity.Property(e => e._1115DayFloat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("11-15 Day Float")
                    .IsFixedLength();

                entity.Property(e => e._12MnthAverageBal)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("12 Mnth Average Bal")
                    .IsFixedLength();

                entity.Property(e => e._1DayFloat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("1-Day Float")
                    .IsFixedLength();

                entity.Property(e => e._2DayFloat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("2-Day Float")
                    .IsFixedLength();

                entity.Property(e => e._3DayFloat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("3-Day Float")
                    .IsFixedLength();

                entity.Property(e => e._45DayFloat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("4-5 Day Float")
                    .IsFixedLength();

                entity.Property(e => e._610DayFloa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("6-10 Day Floa")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SavKey>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SAV_Key");

                entity.Property(e => e.ACType)
                    .HasMaxLength(255)
                    .HasColumnName("A/C Type ");

                entity.Property(e => e.AD)
                    .HasMaxLength(255)
                    .HasColumnName("A/D ");

                entity.Property(e => e.Chg).HasColumnName("CHG ");

                entity.Property(e => e.CrDb)
                    .HasMaxLength(255)
                    .HasColumnName("CR DB ");

                entity.Property(e => e.FieldDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Field Description  ");

                entity.Property(e => e.FldLen).HasColumnName("Fld Len ");

                entity.Property(e => e.FldNum).HasColumnName("Fld Num ");

                entity.Property(e => e.GLCol).HasColumnName("G/L Col ");

                entity.Property(e => e.GlClrFlg)
                    .HasMaxLength(255)
                    .HasColumnName("GL Clr Flg ");

                entity.Property(e => e.HelpDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Help Description");

                entity.Property(e => e.Inq).HasColumnName("INQ ");

                entity.Property(e => e.LastLocation).HasColumnName("Last location");

                entity.Property(e => e.Lc)
                    .HasMaxLength(255)
                    .HasColumnName("LC ");

                entity.Property(e => e.LmtCod).HasColumnName("Lmt Cod ");

                entity.Property(e => e.Upd).HasColumnName("UPD ");

                entity.Property(e => e.Usr)
                    .HasMaxLength(255)
                    .HasColumnName("USR ");

                entity.Property(e => e._1stMastLoc).HasColumnName(" 1st Mast Loc ");
            });

            // Configure properties for 'VatApply' table
            modelBuilder.Entity<TblVatApply>(entity =>
            {
                entity.HasKey(e => e.Id); // Primary key
                entity.Property(e => e.Id).ValueGeneratedOnAdd(); // Auto-increment

                entity.Property(e => e.VatApplyValue)
                    .HasColumnType("decimal(10,2)") // Column type
                    .IsRequired(); // This field is required

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .IsRequired();

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .IsRequired();

                entity.Property(e => e.IsActive)
                    .HasDefaultValue(true) // Default value for IsActive is 1
                    .IsRequired();
            });

            modelBuilder.Entity<TestTable>(entity =>
            {
                entity.HasKey(e => e.ColId);

                entity.ToTable("TestTable");

                entity.Property(e => e.ColId)
                    .HasMaxLength(10)
                    .HasColumnName("colID")
                    .IsFixedLength();

                entity.Property(e => e.ColName)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmps");

                entity.Property(e => e.DatePerformed).HasColumnType("date");

                entity.Property(e => e.DateRequested).HasColumnType("date");

                entity.Property(e => e.InitName)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
