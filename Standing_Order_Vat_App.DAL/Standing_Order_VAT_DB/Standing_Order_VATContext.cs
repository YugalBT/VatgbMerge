using Microsoft.EntityFrameworkCore;

namespace Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB
{
    public partial class Standing_Order_VATContext : DbContext
    {
        public Standing_Order_VATContext()
        {
        }

        public Standing_Order_VATContext(DbContextOptions<Standing_Order_VATContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CoreBranch> CoreBranches { get; set; } = null!;
        public virtual DbSet<CurrencyAcct> CurrencyAccts { get; set; } = null!;
        public virtual DbSet<Ddascj> Ddascjs { get; set; } = null!;
        public virtual DbSet<FileLocation> FileLocations { get; set; } = null!;
        public virtual DbSet<LoanCharge> LoanCharges { get; set; } = null!;
        public virtual DbSet<ReportType> ReportTypes { get; set; } = null!;
        public virtual DbSet<SafeKeepingPayment> SafeKeepingPayments { get; set; } = null!;
        public virtual DbSet<StandingOrder> StandingOrders { get; set; } = null!;
        public virtual DbSet<StopCharge> StopCharges { get; set; } = null!;
        public virtual DbSet<TansferCharge> TansferCharges { get; set; } = null!;
        public virtual DbSet<Testtable> Testtables { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SYS60\\SQLEXPRESS;Database=Standing_Order_VAT;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoreBranch>(entity =>
            {
                entity.HasKey(e => e.BranchId);

                entity.Property(e => e.BranchId)
                    .ValueGeneratedNever()
                    .HasColumnName("BranchID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CurrencyAcct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Currency_Accts");

                entity.Property(e => e.AcctNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_Number");

                entity.Property(e => e.Cif)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIF");

                entity.Property(e => e.CurrencyBalance).HasColumnName("Currency_Balance");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Currency_code");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_Name");

                entity.Property(e => e.Ddacurid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DDACURID");

                entity.Property(e => e.RptDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Rpt_Date");
            });

            modelBuilder.Entity<Ddascj>(entity =>
            {
                entity.ToTable("DDASCJ");

                entity.Property(e => e.DdascjId).HasColumnName("DDASCJ_ID");

                entity.Property(e => e.Acct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACCT");

                entity.Property(e => e.BranchNumber)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Branch_number")
                    .IsFixedLength();

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_Name");

                entity.Property(e => e.NationalFees).HasColumnName("National_Fees");

                entity.Property(e => e.RptDate).HasColumnType("datetime");

                entity.Property(e => e.Vat).HasColumnName("VAT");
            });

            modelBuilder.Entity<FileLocation>(entity =>
            {
                entity.ToTable("FileLocation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoanCharge>(entity =>
            {
                entity.ToTable("Loan_Charges");

                entity.Property(e => e.LoanChargeId).HasColumnName("LoanChargeID");

                entity.Property(e => e.Acct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("acct");

                entity.Property(e => e.Branch)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dateactive)
                    .HasColumnType("datetime")
                    .HasColumnName("dateactive");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nationalfees).HasColumnName("nationalfees");

                entity.Property(e => e.Totalfees).HasColumnName("totalfees");
            });

            modelBuilder.Entity<ReportType>(entity =>
            {
                entity.HasKey(e => e.RepId);

                entity.Property(e => e.RepId).HasColumnName("RepID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportName)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SafeKeepingPayment>(entity =>
            {
                entity.HasKey(e => e.SafeKeepingId);

                entity.ToTable("SafeKeeping_Payments");

                entity.Property(e => e.SafeKeepingId).HasColumnName("SafeKeepingID");

                entity.Property(e => e.Acct)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cif)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIF");

                entity.Property(e => e.Dateactive)
                    .HasColumnType("datetime")
                    .HasColumnName("dateactive");

                entity.Property(e => e.ProofSequence)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transamt).HasColumnName("transamt");

                entity.Property(e => e.Transcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transcode");

                entity.Property(e => e.Vat).HasColumnName("VAT");
            });

            modelBuilder.Entity<StandingOrder>(entity =>
            {
                entity.HasKey(e => e.Snid)
                    .HasName("PK_Standing_orders1");

                entity.ToTable("Standing_orders");

                entity.Property(e => e.Snid).HasColumnName("SNID");

                entity.Property(e => e.Acct)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNumber)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Branch_Number")
                    .IsFixedLength();

                entity.Property(e => e.DateActive)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Active");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NationalFees).HasColumnName("National_Fees");

                entity.Property(e => e.OffsetAcctNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Offset_Acct_Number");

                entity.Property(e => e.SequenceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sequence_Number");

                entity.Property(e => e.SusTc)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SUS_TC")
                    .IsFixedLength();

                entity.Property(e => e.SuspenseDescr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Suspense_Descr");

                entity.Property(e => e.TotalFees).HasColumnName("Total_Fees");

                entity.Property(e => e.TotalTransactionAmt).HasColumnName("Total_Transaction_Amt");

                entity.Property(e => e.TrCd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TR_CD")
                    .IsFixedLength();

                entity.Property(e => e.TransactionAmt).HasColumnName("Transaction_Amt");

                entity.Property(e => e.Vat).HasColumnName("VAT");
            });

            modelBuilder.Entity<StopCharge>(entity =>
            {
                entity.ToTable("Stop_Charge");

                entity.Property(e => e.StopchargeId).HasColumnName("StopchargeID");

                entity.Property(e => e.Acct)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cif)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIF");

                entity.Property(e => e.Dateactive)
                    .HasColumnType("datetime")
                    .HasColumnName("dateactive");

                entity.Property(e => e.ProofSequence)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransAmt).HasColumnName("transAmt");

                entity.Property(e => e.Transcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transcode");

                entity.Property(e => e.Vat).HasColumnName("VAT");
            });

            modelBuilder.Entity<TansferCharge>(entity =>
            {
                entity.HasKey(e => e.TransferChargeId);

                entity.ToTable("TansferCharge");

                entity.Property(e => e.TransferChargeId).HasColumnName("TransferChargeID");

                entity.Property(e => e.Acct)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("checkNumber");

                entity.Property(e => e.Cif)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIF");

                entity.Property(e => e.Dateactive)
                    .HasColumnType("datetime")
                    .HasColumnName("dateactive");

                entity.Property(e => e.ProffSequence)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransAmt).HasColumnName("transAmt");

                entity.Property(e => e.Trasncode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trasncode");

                entity.Property(e => e.Vat).HasColumnName("VAT");
            });

            modelBuilder.Entity<Testtable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testtable");

                entity.Property(e => e.Acct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACCT");

                entity.Property(e => e.BranchNumber)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Branch_number")
                    .IsFixedLength();

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_Name");

                entity.Property(e => e.DdascjId).HasColumnName("DDASCJ_ID");

                entity.Property(e => e.NationalFees).HasColumnName("National_Fees");

                entity.Property(e => e.RptDate).HasColumnType("datetime");

                entity.Property(e => e.Vat).HasColumnName("VAT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
