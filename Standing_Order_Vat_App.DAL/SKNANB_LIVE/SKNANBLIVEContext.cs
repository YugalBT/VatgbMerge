using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class SKNANBLIVEContext : DbContext
    {
        public SKNANBLIVEContext()
        {
        }

        public SKNANBLIVEContext(DbContextOptions<SKNANBLIVEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActiveEmp> ActiveEmps { get; set; } = null!;
        public virtual DbSet<ActiveEmps2013> ActiveEmps2013s { get; set; } = null!;
        public virtual DbSet<ActiveUser> ActiveUsers { get; set; } = null!;
        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<ArchivePayment> ArchivePayments { get; set; } = null!;
        public virtual DbSet<AtmCustomerActivity> AtmCustomerActivities { get; set; } = null!;
        public virtual DbSet<AtmDescription> AtmDescriptions { get; set; } = null!;
        public virtual DbSet<AtmMachine> AtmMachines { get; set; } = null!;
        public virtual DbSet<AtmSupervisorLog> AtmSupervisorLogs { get; set; } = null!;
        public virtual DbSet<Atmaudit> Atmaudits { get; set; } = null!;
        public virtual DbSet<AtmcassetteInfo> AtmcassetteInfos { get; set; } = null!;
        public virtual DbSet<AttSecurity> AttSecurities { get; set; } = null!;
        public virtual DbSet<Attendance> Attendances { get; set; } = null!;
        public virtual DbSet<AttendanceAcctual> AttendanceAcctuals { get; set; } = null!;
        public virtual DbSet<AttendanceBakact> AttendanceBakacts { get; set; } = null!;
        public virtual DbSet<AttendanceBkup301103> AttendanceBkup301103s { get; set; } = null!;
        public virtual DbSet<AttendanceModified> AttendanceModifieds { get; set; } = null!;
        public virtual DbSet<AttendanceSummary> AttendanceSummaries { get; set; } = null!;
        public virtual DbSet<Attendancetest> Attendancetests { get; set; } = null!;
        public virtual DbSet<Audit> Audits { get; set; } = null!;
        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<BankHoliday> BankHolidays { get; set; } = null!;
        public virtual DbSet<BankersPayment> BankersPayments { get; set; } = null!;
        public virtual DbSet<BasseterreDept> BasseterreDepts { get; set; } = null!;
        public virtual DbSet<Branch> Branches { get; set; } = null!;
        public virtual DbSet<CallAccount> CallAccounts { get; set; } = null!;
        public virtual DbSet<CallSession> CallSessions { get; set; } = null!;
        public virtual DbSet<CardCustomReport> CardCustomReports { get; set; } = null!;
        public virtual DbSet<CardNumberHistory> CardNumberHistories { get; set; } = null!;
        public virtual DbSet<CardType> CardTypes { get; set; } = null!;
        public virtual DbSet<Cifhistory> Cifhistories { get; set; } = null!;
        public virtual DbSet<Cifnumber> Cifnumbers { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<CompanyHrmap> CompanyHrmaps { get; set; } = null!;
        public virtual DbSet<CurrSal> CurrSals { get; set; } = null!;
        public virtual DbSet<Currency> Currencies { get; set; } = null!;
        public virtual DbSet<DepartmentHrmap> DepartmentHrmaps { get; set; } = null!;
        public virtual DbSet<DivisionHrmap> DivisionHrmaps { get; set; } = null!;
        public virtual DbSet<Draft> Drafts { get; set; } = null!;
        public virtual DbSet<EarningType> EarningTypes { get; set; } = null!;
        public virtual DbSet<EmpRep> EmpReps { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeGroup> EmployeeGroups { get; set; } = null!;
        public virtual DbSet<EmployeeHistory> EmployeeHistories { get; set; } = null!;
        public virtual DbSet<EmployeeListing> EmployeeListings { get; set; } = null!;
        public virtual DbSet<EmployeePerformance> EmployeePerformances { get; set; } = null!;
        public virtual DbSet<EmployeePerformanceHistory> EmployeePerformanceHistories { get; set; } = null!;
        public virtual DbSet<EmployeePic> EmployeePics { get; set; } = null!;
        public virtual DbSet<EntitlementBf> EntitlementBfs { get; set; } = null!;
        public virtual DbSet<EntitlementBfBk> EntitlementBfBks { get; set; } = null!;
        public virtual DbSet<EntitlementBfold> EntitlementBfolds { get; set; } = null!;
        public virtual DbSet<GetBfwdInfo> GetBfwdInfos { get; set; } = null!;
        public virtual DbSet<Glaccount> Glaccounts { get; set; } = null!;
        public virtual DbSet<Horizon55> Horizon55s { get; set; } = null!;
        public virtual DbSet<InactiveAtt> InactiveAtts { get; set; } = null!;
        public virtual DbSet<ManagerType> ManagerTypes { get; set; } = null!;
        public virtual DbSet<ManagersCheque> ManagersCheques { get; set; } = null!;
        public virtual DbSet<MstrType> MstrTypes { get; set; } = null!;
        public virtual DbSet<MyItem> MyItems { get; set; } = null!;
        public virtual DbSet<MyOrder> MyOrders { get; set; } = null!;
        public virtual DbSet<NationalCallsCustomReport> NationalCallsCustomReports { get; set; } = null!;
        public virtual DbSet<OtherImage> OtherImages { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<PaymentSetting> PaymentSettings { get; set; } = null!;
        public virtual DbSet<PaymentType> PaymentTypes { get; set; } = null!;
        public virtual DbSet<Payments001> Payments001s { get; set; } = null!;
        public virtual DbSet<Payments14102011> Payments14102011s { get; set; } = null!;
        public virtual DbSet<Payments2008T02010> Payments2008T02010s { get; set; } = null!;
        public virtual DbSet<Payments2008To2010Bk> Payments2008To2010Bks { get; set; } = null!;
        public virtual DbSet<PaymentsCopyToNov2015FrstHlf> PaymentsCopyToNov2015FrstHlves { get; set; } = null!;
        public virtual DbSet<PaymentsDec09> PaymentsDec09s { get; set; } = null!;
        public virtual DbSet<PaymentsJan2012> PaymentsJan2012s { get; set; } = null!;
        public virtual DbSet<PaymentsJan82011> PaymentsJan82011s { get; set; } = null!;
        public virtual DbSet<PaymentsJan92011ToAug232017> PaymentsJan92011ToAug232017s { get; set; } = null!;
        public virtual DbSet<PaymentsTemp2014> PaymentsTemp2014s { get; set; } = null!;
        public virtual DbSet<PaymentsTemp2016> PaymentsTemp2016s { get; set; } = null!;
        public virtual DbSet<PaymentsTmp> PaymentsTmps { get; set; } = null!;
        public virtual DbSet<PaymentsToDec2017> PaymentsToDec2017s { get; set; } = null!;
        public virtual DbSet<PaymentsUpToDec2011> PaymentsUpToDec2011s { get; set; } = null!;
        public virtual DbSet<PayrollCustomReport> PayrollCustomReports { get; set; } = null!;
        public virtual DbSet<Profile> Profiles { get; set; } = null!;
        public virtual DbSet<Rate> Rates { get; set; } = null!;
        public virtual DbSet<Result> Results { get; set; } = null!;
        public virtual DbSet<Savdrm> Savdrms { get; set; } = null!;
        public virtual DbSet<Ssb> Ssbs { get; set; } = null!;
        public virtual DbSet<Ssb3d> Ssb3ds { get; set; } = null!;
        public virtual DbSet<StaffEnt> StaffEnts { get; set; } = null!;
        public virtual DbSet<StaffLogin> StaffLogins { get; set; } = null!;
        public virtual DbSet<StaffPerformanceHistory> StaffPerformanceHistories { get; set; } = null!;
        public virtual DbSet<StaffTimeLog> StaffTimeLogs { get; set; } = null!;
        public virtual DbSet<StaffVacation> StaffVacations { get; set; } = null!;
        public virtual DbSet<SubType> SubTypes { get; set; } = null!;
        public virtual DbSet<SupportFilterMap> SupportFilterMaps { get; set; } = null!;
        public virtual DbSet<SwiftMessage> SwiftMessages { get; set; } = null!;
        public virtual DbSet<TPlog> TPlogs { get; set; } = null!;
        public virtual DbSet<TPlogin> TPlogins { get; set; } = null!;
        public virtual DbSet<TestLogin> TestLogins { get; set; } = null!;
        public virtual DbSet<TestView> TestViews { get; set; } = null!;
        public virtual DbSet<TestVw> TestVws { get; set; } = null!;
        public virtual DbSet<TransitItem> TransitItems { get; set; } = null!;
        public virtual DbSet<TravellersCheque> TravellersCheques { get; set; } = null!;
        public virtual DbSet<Unit> Units { get; set; } = null!;
        public virtual DbSet<UnitType> UnitTypes { get; set; } = null!;
        public virtual DbSet<View1> View1s { get; set; } = null!;
        public virtual DbSet<View2> View2s { get; set; } = null!;
        public virtual DbSet<View3> View3s { get; set; } = null!;
        public virtual DbSet<View4> View4s { get; set; } = null!;
        public virtual DbSet<VisaCard> VisaCards { get; set; } = null!;
        public virtual DbSet<VwActAb> VwActAbs { get; set; } = null!;
        public virtual DbSet<VwAllEmp> VwAllEmps { get; set; } = null!;
        public virtual DbSet<VwAttLegend> VwAttLegends { get; set; } = null!;
        public virtual DbSet<VwBank> VwBanks { get; set; } = null!;
        public virtual DbSet<VwBranch> VwBranches { get; set; } = null!;
        public virtual DbSet<VwCompany> VwCompanies { get; set; } = null!;
        public virtual DbSet<VwDepartment> VwDepartments { get; set; } = null!;
        public virtual DbSet<VwDivision> VwDivisions { get; set; } = null!;
        public virtual DbSet<VwEmpDetDate> VwEmpDetDates { get; set; } = null!;
        public virtual DbSet<VwEmpDetailsContract> VwEmpDetailsContracts { get; set; } = null!;
        public virtual DbSet<VwEmpDetailsPaydatum> VwEmpDetailsPaydata { get; set; } = null!;
        public virtual DbSet<VwEmpDetailsPersonal> VwEmpDetailsPersonals { get; set; } = null!;
        public virtual DbSet<VwEmpDetailsTrainingHist> VwEmpDetailsTrainingHists { get; set; } = null!;
        public virtual DbSet<VwEmployee> VwEmployees { get; set; } = null!;
        public virtual DbSet<VwEmployeeDetail> VwEmployeeDetails { get; set; } = null!;
        public virtual DbSet<VwGetEmpInfo> VwGetEmpInfos { get; set; } = null!;
        public virtual DbSet<VwGetEmpsSocial> VwGetEmpsSocials { get; set; } = null!;
        public virtual DbSet<VwHorizon55> VwHorizon55s { get; set; } = null!;
        public virtual DbSet<VwLegend> VwLegends { get; set; } = null!;
        public virtual DbSet<VwLocalBank> VwLocalBanks { get; set; } = null!;
        public virtual DbSet<VwNationalCall> VwNationalCalls { get; set; } = null!;
        public virtual DbSet<VwPayType> VwPayTypes { get; set; } = null!;
        public virtual DbSet<VwPayslip> VwPayslips { get; set; } = null!;
        public virtual DbSet<VwPayslipsAdj> VwPayslipsAdjs { get; set; } = null!;
        public virtual DbSet<VwReason> VwReasons { get; set; } = null!;
        public virtual DbSet<VwSsb> VwSsbs { get; set; } = null!;
        public virtual DbSet<VwTempPay> VwTempPays { get; set; } = null!;
        public virtual DbSet<VwTotalAbsent> VwTotalAbsents { get; set; } = null!;
        public virtual DbSet<VwUser> VwUsers { get; set; } = null!;
        public virtual DbSet<VwempInfo> VwempInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SYS82\\SYS82G,1433;Database=SKNANB LIVE;user id=sa;password=bt123;TrustServerCertificate=true;Integrated Security=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActiveEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ActiveEmps");

                entity.Property(e => e.IdCompany).HasColumnName("ID_COMPANY");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InInactive)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IN_INACTIVE");

                entity.Property(e => e.NmFull)
                    .HasMaxLength(101)
                    .IsUnicode(false)
                    .HasColumnName("NM_FULL");
            });

            modelBuilder.Entity<ActiveEmps2013>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ActiveEmps2013");

                entity.Property(e => e.IdBranch).HasColumnName("ID_BRANCH");

                entity.Property(e => e.IdCompany).HasColumnName("ID_COMPANY");

                entity.Property(e => e.IdSocialSec).HasColumnName("ID_SOCIAL_SEC");

                entity.Property(e => e.InInactive)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IN_INACTIVE");

                entity.Property(e => e.NmFirst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_FIRST");

                entity.Property(e => e.NmLast)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_LAST");
            });

            modelBuilder.Entity<ActiveUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ActiveUsers");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_Address");

                entity.Property(e => e.LoginDate).HasColumnType("datetime");

                entity.Property(e => e.LoginStatus).HasColumnName("Login_Status");

                entity.Property(e => e.MachineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.IdAddress)
                    .IsClustered(false);

                entity.HasIndex(e => e.InDelFlg, "Addresses1")
                    .IsClustered();

                entity.Property(e => e.IdAddress).HasColumnName("ID_ADDRESS");

                entity.Property(e => e.CdZip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CD_ZIP");

                entity.Property(e => e.IdProfile).HasColumnName("ID_PROFILE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.NmCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_CITY");

                entity.Property(e => e.NmCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_COUNTRY");

                entity.Property(e => e.PhPhone1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PH_PHONE1")
                    .IsFixedLength();

                entity.Property(e => e.PhPhone2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PH_PHONE2")
                    .IsFixedLength();

                entity.Property(e => e.TxAddr1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TX_ADDR1")
                    .IsFixedLength();

                entity.Property(e => e.TxAddr2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TX_ADDR2")
                    .IsFixedLength();

                entity.HasOne(d => d.IdProfileNavigation)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.IdProfile)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Addresses_Profiles");
            });

            modelBuilder.Entity<ArchivePayment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DtBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_BEGIN");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END");

                entity.Property(e => e.DtLastModified)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_LAST_MODIFIED");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.GlOvertime).HasColumnName("GL_OVERTIME");

                entity.Property(e => e.GlRegularPay).HasColumnName("GL_REGULAR_PAY");

                entity.Property(e => e.GlSlEmpee).HasColumnName("GL_SL_EMPEE");

                entity.Property(e => e.GlSlExps).HasColumnName("GL_SL_EXPS");

                entity.Property(e => e.GlSlLiable).HasColumnName("GL_SL_LIABLE");

                entity.Property(e => e.GlSsEmpee).HasColumnName("GL_SS_EMPEE");

                entity.Property(e => e.GlSsExps).HasColumnName("GL_SS_EXPS");

                entity.Property(e => e.GlSsLiable).HasColumnName("GL_SS_LIABLE");

                entity.Property(e => e.GlSwExps).HasColumnName("GL_SW_EXPS");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdPayment).HasColumnName("ID_PAYMENT");

                entity.Property(e => e.IdRegPayment).HasColumnName("ID_REG_PAYMENT");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InOverride)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_OVERRIDE")
                    .IsFixedLength();

                entity.Property(e => e.InPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_PAID")
                    .IsFixedLength();

                entity.Property(e => e.InSentToSsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_SENT_TO_SSB")
                    .IsFixedLength();

                entity.Property(e => e.MnyEmpeeSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SL");

                entity.Property(e => e.MnyEmpeeSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SS");

                entity.Property(e => e.MnyEmperSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL");

                entity.Property(e => e.MnyEmperSlSev)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL_SEV");

                entity.Property(e => e.MnyEmperSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS");

                entity.Property(e => e.MnyEmperSsInj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS_INJ");

                entity.Property(e => e.MnyGrossPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_GROSS_PAY");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.MnyOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_OVRTIME");

                entity.Property(e => e.MnyRegPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_REG_PAY");

                entity.Property(e => e.MnyTotAdj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_TOT_ADJ");

                entity.Property(e => e.MnyYtdGross)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_GROSS");

                entity.Property(e => e.MnyYtdSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SL");

                entity.Property(e => e.MnyYtdSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SS");

                entity.Property(e => e.TxComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_COMMENT");
            });

            modelBuilder.Entity<AtmCustomerActivity>(entity =>
            {
                entity.HasKey(e => e.TranId);

                entity.ToTable("ATM_Customer_Activity");

                entity.Property(e => e.TranId).HasColumnName("TranID");

                entity.Property(e => e.Activity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.AtmNumber).HasColumnName("ATM_Number");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_And_Time");

                entity.Property(e => e.Error)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("From_Account");

                entity.Property(e => e.Machine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecSolution)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Rec_Solution");

                entity.Property(e => e.ToAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("To_Account");

                entity.Property(e => e.TransactionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AtmDescription>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ATM_Description");

                entity.Property(e => e.CommAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Comm_Add");

                entity.Property(e => e.Driver)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Function)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MessageMode).HasColumnName("Message_Mode");

                entity.Property(e => e.OperationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Operation_Date");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Serial_Number");

                entity.Property(e => e.TerminalName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Terminal_Name");
            });

            modelBuilder.Entity<AtmMachine>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ATM_Machines");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_Address");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Machine_Name");

                entity.Property(e => e.NetworkName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Network_Name");
            });

            modelBuilder.Entity<AtmSupervisorLog>(entity =>
            {
                entity.HasKey(e => e.LogEntry);

                entity.ToTable("ATM_Supervisor_Log");

                entity.Property(e => e.Activity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AtmNumber).HasColumnName("ATM_Number");

                entity.Property(e => e.DateAndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_And_Time");

                entity.Property(e => e.Machine)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Atmaudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ATMAudit");

                entity.Property(e => e.AtmNumber).HasColumnName("ATM_Number");

                entity.Property(e => e.AuditDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Audit_Date");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Machine)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AtmcassetteInfo>(entity =>
            {
                entity.HasKey(e => e.EntryId);

                entity.ToTable("ATMCassetteInfo");

                entity.Property(e => e.EntryId).HasColumnName("entryID");

                entity.Property(e => e.AtmNumber).HasColumnName("ATM_Number");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastCleared).HasColumnType("datetime");

                entity.Property(e => e.Machine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type1).HasColumnName("Type_1");

                entity.Property(e => e.Type2).HasColumnName("Type_2");

                entity.Property(e => e.Type3).HasColumnName("Type_3");

                entity.Property(e => e.Type4).HasColumnName("Type_4");
            });

            modelBuilder.Entity<AttSecurity>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_AttSEcurity");

                entity.ToTable("Att_Security");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.InDelete).HasColumnName("IN_Delete");

                entity.Property(e => e.InRead).HasColumnName("IN_Read");

                entity.Property(e => e.InWrite).HasColumnName("IN_Write");
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_Attendance_1");

                entity.ToTable("Attendance");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Added_By");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Added");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_End");

                entity.Property(e => e.DtInformed)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Informed");

                entity.Property(e => e.DtMod)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_mod");

                entity.Property(e => e.DtStart)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Start");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdMonth).HasColumnName("ID_Month");

                entity.Property(e => e.InAppvd).HasColumnName("IN_Appvd");

                entity.Property(e => e.InDelFlg).HasColumnName("IN_DEL_FLG");

                entity.Property(e => e.InNtappvd).HasColumnName("IN_NTAppvd");

                entity.Property(e => e.InTdAm).HasColumnName("IN_TD_AM");

                entity.Property(e => e.InTdPm).HasColumnName("IN_TD_PM");

                entity.Property(e => e.InTobeAppvd).HasColumnName("IN_TobeAppvd");

                entity.Property(e => e.NmAppvdAb).HasColumnName("NM_AppvdAb");

                entity.Property(e => e.NmInterval).HasColumnName("NM_Interval");

                entity.Property(e => e.NmModBy)
                    .HasMaxLength(128)
                    .HasColumnName("NM_ModBy");

                entity.Property(e => e.NmSpecialDays).HasColumnName("NM_SpecialDays");

                entity.Property(e => e.NmUnAppvdAb).HasColumnName("NM_UnAppvdAb");

                entity.Property(e => e.SocialSecurity).HasColumnName("Social_Security");

                entity.Property(e => e.TmInformed)
                    .HasColumnType("datetime")
                    .HasColumnName("TM_Informed");

                entity.Property(e => e.TotalDays).HasColumnName("Total_Days");

                entity.Property(e => e.TxGmrec)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_GMRec");

                entity.Property(e => e.TxInformedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_InformedBy");

                entity.Property(e => e.TxMemo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_Memo");

                entity.Property(e => e.TxReasons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_Reasons");

                entity.Property(e => e.YrPaid).HasColumnName("yr_paid");
            });

            modelBuilder.Entity<AttendanceAcctual>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_Acctual");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_End");

                entity.Property(e => e.DtInformed)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Informed");

                entity.Property(e => e.DtMod)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_mod");

                entity.Property(e => e.DtStart)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Start");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdMonth).HasColumnName("ID_Month");

                entity.Property(e => e.InAppvd).HasColumnName("IN_Appvd");

                entity.Property(e => e.InDelFlg).HasColumnName("IN_DEL_FLG");

                entity.Property(e => e.InNtappvd).HasColumnName("IN_NTAppvd");

                entity.Property(e => e.InTdAm).HasColumnName("IN_TD_AM");

                entity.Property(e => e.InTdPm).HasColumnName("IN_TD_PM");

                entity.Property(e => e.InTobeAppvd).HasColumnName("IN_TobeAppvd");

                entity.Property(e => e.Key)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("key");

                entity.Property(e => e.NmAppvdAb).HasColumnName("NM_AppvdAb");

                entity.Property(e => e.NmInterval).HasColumnName("NM_Interval");

                entity.Property(e => e.NmModBy)
                    .HasMaxLength(128)
                    .HasColumnName("NM_ModBy");

                entity.Property(e => e.NmSpecialDays).HasColumnName("NM_SpecialDays");

                entity.Property(e => e.NmUnAppvdAb).HasColumnName("NM_UnAppvdAb");

                entity.Property(e => e.SocialSecurity).HasColumnName("Social_Security");

                entity.Property(e => e.TmInformed)
                    .HasColumnType("datetime")
                    .HasColumnName("TM_Informed");

                entity.Property(e => e.TotalDays).HasColumnName("Total_Days");

                entity.Property(e => e.TxGmrec)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_GMRec");

                entity.Property(e => e.TxInformedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_InformedBy");

                entity.Property(e => e.TxMemo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_Memo");

                entity.Property(e => e.TxReasons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_Reasons");

                entity.Property(e => e.YrPaid).HasColumnName("yr_paid");
            });

            modelBuilder.Entity<AttendanceBakact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AttendanceBAKACT");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_End");

                entity.Property(e => e.DtInformed)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Informed");

                entity.Property(e => e.DtMod)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_mod");

                entity.Property(e => e.DtStart)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Start");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdMonth).HasColumnName("ID_Month");

                entity.Property(e => e.InAppvd).HasColumnName("IN_Appvd");

                entity.Property(e => e.InDelFlg).HasColumnName("IN_DEL_FLG");

                entity.Property(e => e.InNtappvd).HasColumnName("IN_NTAppvd");

                entity.Property(e => e.InTdAm).HasColumnName("IN_TD_AM");

                entity.Property(e => e.InTdPm).HasColumnName("IN_TD_PM");

                entity.Property(e => e.InTobeAppvd).HasColumnName("IN_TobeAppvd");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.NmAppvdAb).HasColumnName("NM_AppvdAb");

                entity.Property(e => e.NmInterval).HasColumnName("NM_Interval");

                entity.Property(e => e.NmModBy)
                    .HasMaxLength(128)
                    .HasColumnName("NM_ModBy");

                entity.Property(e => e.NmSpecialDays).HasColumnName("NM_SpecialDays");

                entity.Property(e => e.NmUnAppvdAb).HasColumnName("NM_UnAppvdAb");

                entity.Property(e => e.SocialSecurity).HasColumnName("Social_Security");

                entity.Property(e => e.TmInformed)
                    .HasColumnType("datetime")
                    .HasColumnName("TM_Informed");

                entity.Property(e => e.TotalDays).HasColumnName("Total_Days");

                entity.Property(e => e.TxGmrec)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_GMRec");

                entity.Property(e => e.TxInformedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_InformedBy");

                entity.Property(e => e.TxMemo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_Memo");

                entity.Property(e => e.TxReasons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_Reasons");

                entity.Property(e => e.YrPaid).HasColumnName("yr_paid");
            });

            modelBuilder.Entity<AttendanceBkup301103>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AttendanceBKUP301103");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_End");

                entity.Property(e => e.DtInformed)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Informed");

                entity.Property(e => e.DtMod)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_mod");

                entity.Property(e => e.DtStart)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Start");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdMonth).HasColumnName("ID_Month");

                entity.Property(e => e.InAppvd).HasColumnName("IN_Appvd");

                entity.Property(e => e.InDelFlg).HasColumnName("IN_DEL_FLG");

                entity.Property(e => e.InNtappvd).HasColumnName("IN_NTAppvd");

                entity.Property(e => e.InTdAm).HasColumnName("IN_TD_AM");

                entity.Property(e => e.InTdPm).HasColumnName("IN_TD_PM");

                entity.Property(e => e.InTobeAppvd).HasColumnName("IN_TobeAppvd");

                entity.Property(e => e.Key)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("key");

                entity.Property(e => e.NmAppvdAb).HasColumnName("NM_AppvdAb");

                entity.Property(e => e.NmInterval).HasColumnName("NM_Interval");

                entity.Property(e => e.NmModBy)
                    .HasMaxLength(128)
                    .HasColumnName("NM_ModBy");

                entity.Property(e => e.NmSpecialDays).HasColumnName("NM_SpecialDays");

                entity.Property(e => e.NmUnAppvdAb).HasColumnName("NM_UnAppvdAb");

                entity.Property(e => e.SocialSecurity).HasColumnName("Social_Security");

                entity.Property(e => e.TmInformed)
                    .HasColumnType("datetime")
                    .HasColumnName("TM_Informed");

                entity.Property(e => e.TotalDays).HasColumnName("Total_Days");

                entity.Property(e => e.TxGmrec)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_GMRec");

                entity.Property(e => e.TxInformedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_InformedBy");

                entity.Property(e => e.TxMemo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_Memo");

                entity.Property(e => e.TxReasons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_Reasons");

                entity.Property(e => e.YrPaid).HasColumnName("yr_paid");
            });

            modelBuilder.Entity<AttendanceModified>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance_Modified");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Added_By");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Added");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_End");

                entity.Property(e => e.DtInformed)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Informed");

                entity.Property(e => e.DtMod)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_mod");

                entity.Property(e => e.DtStart)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Start");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdMonth).HasColumnName("ID_Month");

                entity.Property(e => e.InAppvd).HasColumnName("IN_Appvd");

                entity.Property(e => e.InDelFlg).HasColumnName("IN_DEL_FLG");

                entity.Property(e => e.InNtappvd).HasColumnName("IN_NTAppvd");

                entity.Property(e => e.InTdAm).HasColumnName("IN_TD_AM");

                entity.Property(e => e.InTdPm).HasColumnName("IN_TD_PM");

                entity.Property(e => e.InTobeAppvd).HasColumnName("IN_TobeAppvd");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.NmAppvdAb).HasColumnName("NM_AppvdAb");

                entity.Property(e => e.NmInterval).HasColumnName("NM_Interval");

                entity.Property(e => e.NmModBy)
                    .HasMaxLength(128)
                    .HasColumnName("NM_ModBy");

                entity.Property(e => e.NmSpecialDays).HasColumnName("NM_SpecialDays");

                entity.Property(e => e.NmUnAppvdAb).HasColumnName("NM_UnAppvdAb");

                entity.Property(e => e.SocialSecurity).HasColumnName("Social_Security");

                entity.Property(e => e.TmInformed)
                    .HasColumnType("datetime")
                    .HasColumnName("TM_Informed");

                entity.Property(e => e.TotalDays).HasColumnName("Total_Days");

                entity.Property(e => e.TxGmrec)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_GMRec");

                entity.Property(e => e.TxInformedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_InformedBy");

                entity.Property(e => e.TxMemo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_Memo");

                entity.Property(e => e.TxReasons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_Reasons");

                entity.Property(e => e.YrPaid).HasColumnName("yr_paid");
            });

            modelBuilder.Entity<AttendanceSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AttendanceSummary");

                entity.Property(e => e.AvailableSd).HasColumnName("AvailableSD");

                entity.Property(e => e.AvailableVac).HasColumnName("AvailableVAC");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.ProdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Attendancetest>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_Attendance");

                entity.ToTable("Attendancetest");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_End");

                entity.Property(e => e.DtInformed)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Informed");

                entity.Property(e => e.DtMod)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_mod");

                entity.Property(e => e.DtStart)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Start");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdMonth)
                    .HasColumnName("ID_Month")
                    .HasComputedColumnSql("(datepart(month,[DT_Start]))", false);

                entity.Property(e => e.InAppvd).HasColumnName("IN_Appvd");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .HasDefaultValueSql("('F')")
                    .IsFixedLength();

                entity.Property(e => e.InNtappvd).HasColumnName("IN_NTAppvd");

                entity.Property(e => e.InTdAm).HasColumnName("IN_TD_AM");

                entity.Property(e => e.InTdPm).HasColumnName("IN_TD_PM");

                entity.Property(e => e.InTobeAppvd)
                    .HasColumnName("IN_TobeAppvd")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.NmAppvdAb).HasColumnName("NM_AppvdAb");

                entity.Property(e => e.NmInterval)
                    .HasColumnName("NM_Interval")
                    .HasComputedColumnSql("(datediff(day,[DT_Start],[Dt_End]) + 1)", false);

                entity.Property(e => e.NmModBy)
                    .HasMaxLength(128)
                    .HasColumnName("NM_ModBy")
                    .HasComputedColumnSql("(suser_sname())", false);

                entity.Property(e => e.NmSpecialDays).HasColumnName("NM_SpecialDays");

                entity.Property(e => e.NmUnAppvdAb).HasColumnName("NM_UnAppvdAb");

                entity.Property(e => e.SocialSecurity).HasColumnName("Social_Security");

                entity.Property(e => e.TmInformed)
                    .HasColumnType("datetime")
                    .HasColumnName("TM_Informed");

                entity.Property(e => e.TxGmrec)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_GMRec");

                entity.Property(e => e.TxInformedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_InformedBy");

                entity.Property(e => e.TxMemo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_Memo");

                entity.Property(e => e.TxReasons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_Reasons");
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.ToTable("Audit");

                entity.Property(e => e.AuditId).HasColumnName("audit_id");

                entity.Property(e => e.AuditAction)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("audit_action");

                entity.Property(e => e.AuditApplication)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("audit_application")
                    .HasDefaultValueSql("(app_name())");

                entity.Property(e => e.AuditField)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("audit_field");

                entity.Property(e => e.AuditNewVal)
                    .HasMaxLength(3500)
                    .IsUnicode(false)
                    .HasColumnName("audit_new_val");

                entity.Property(e => e.AuditOldVal)
                    .HasMaxLength(3500)
                    .IsUnicode(false)
                    .HasColumnName("audit_old_val");

                entity.Property(e => e.AuditTable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("audit_table");

                entity.Property(e => e.AuditTableRow)
                    .HasColumnName("audit_table_row")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.AuditTimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("audit_timestamp")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AuditUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("audit_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.AuditWorkstation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("audit_workstation")
                    .HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalBank).HasColumnName("Local_Bank");

                entity.Property(e => e.Name)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BankHoliday>(entity =>
            {
                entity.HasKey(e => e.KeyRow);

                entity.ToTable("Bank_Holidays");

                entity.Property(e => e.KeyRow).HasColumnName("keyRow");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_End");

                entity.Property(e => e.DtStart)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Start");
            });

            modelBuilder.Entity<BankersPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BankersPayment");

                entity.Property(e => e.Balance)
                    .HasColumnType("money")
                    .HasComputedColumnSql("([Debit] - [Credit])", false);

                entity.Property(e => e.Bank)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCleared).HasColumnType("datetime");

                entity.Property(e => e.Debit).HasColumnType("money");

                entity.Property(e => e.DeleteFlg).HasDefaultValueSql("(0)");

                entity.Property(e => e.Key)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("key");

                entity.Property(e => e.Payee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TheUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserMachine)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BasseterreDept>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Basseterre_Depts");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Unit_Name");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoreId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CoreID");
            });

            modelBuilder.Entity<CallAccount>(entity =>
            {
                entity.HasKey(e => e.AccountCode)
                    .HasName("PK_EmployeeCallAccounts");

                entity.HasIndex(e => e.AccountCode, "IX_EmployeeCallAccounts")
                    .IsUnique();

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("name used non-employee accounts");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("ID_EMPLOYEE")
                    .HasComment("ID joined with Employees table.");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.CallAccounts)
                    .HasForeignKey(d => d.IdEmployee)
                    .HasConstraintName("FK_EmployeeCallAccounts_Employees");
            });

            modelBuilder.Entity<CallSession>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.SessionId, "IX_EmployeeCallSessions")
                    .IsUnique();

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("name used for non-employee accounts");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.HasOne(d => d.IdHistoryNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdHistory)
                    .HasConstraintName("FK_EmployeeCallSessions_EmployeeHistory");
            });

            modelBuilder.Entity<CardCustomReport>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportSp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ReportSP");
            });

            modelBuilder.Entity<CardNumberHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CardNumberHistory");

                entity.HasIndex(e => e.CardNumber, "IX_CardNumberHistory")
                    .IsUnique();

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumberId).HasColumnName("CardNumberID");
            });

            modelBuilder.Entity<CardType>(entity =>
            {
                entity.HasKey(e => e.IdType)
                    .HasName("PK_CardType");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.IdBin).HasColumnName("ID_BIN");

                entity.Property(e => e.NmType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_TYPE");
            });

            modelBuilder.Entity<Cifhistory>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK_CIFRecords_1");

                entity.ToTable("CIFHistory");

                entity.Property(e => e.CifacctFname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctFName")
                    .IsFixedLength();

                entity.Property(e => e.CifacctInitial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctInitial")
                    .IsFixedLength();

                entity.Property(e => e.CifacctLname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctLName")
                    .IsFixedLength();

                entity.Property(e => e.CifacctNum1)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctNum1")
                    .IsFixedLength();

                entity.Property(e => e.CifacctNum10)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctNum10")
                    .IsFixedLength();

                entity.Property(e => e.CifacctNum2)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctNum2")
                    .IsFixedLength();

                entity.Property(e => e.CifacctNum3)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctNum3")
                    .IsFixedLength();

                entity.Property(e => e.CifacctNum4)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctNum4")
                    .IsFixedLength();

                entity.Property(e => e.CifacctNum5)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctNum5")
                    .IsFixedLength();

                entity.Property(e => e.CifacctNum6)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctNum6")
                    .IsFixedLength();

                entity.Property(e => e.CifacctNum7)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctNum7")
                    .IsFixedLength();

                entity.Property(e => e.CifacctNum8)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctNum8")
                    .IsFixedLength();

                entity.Property(e => e.CifacctNum9)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctNum9")
                    .IsFixedLength();

                entity.Property(e => e.CifacctType1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctType1")
                    .IsFixedLength();

                entity.Property(e => e.CifacctType10)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctType10")
                    .IsFixedLength();

                entity.Property(e => e.CifacctType2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctType2")
                    .IsFixedLength();

                entity.Property(e => e.CifacctType3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctType3")
                    .IsFixedLength();

                entity.Property(e => e.CifacctType4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctType4")
                    .IsFixedLength();

                entity.Property(e => e.CifacctType5)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctType5")
                    .IsFixedLength();

                entity.Property(e => e.CifacctType6)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctType6")
                    .IsFixedLength();

                entity.Property(e => e.CifacctType7)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctType7")
                    .IsFixedLength();

                entity.Property(e => e.CifacctType8)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctType8")
                    .IsFixedLength();

                entity.Property(e => e.CifacctType9)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CIFAcctType9")
                    .IsFixedLength();

                entity.Property(e => e.CifcardStat)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIFCardStat")
                    .IsFixedLength();

                entity.Property(e => e.Cifcifcity)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CIFCIFCity")
                    .IsFixedLength();

                entity.Property(e => e.Cifcifctry)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CIFCIFCtry")
                    .IsFixedLength();

                entity.Property(e => e.Cifcifcur)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CIFCIFCur")
                    .IsFixedLength();

                entity.Property(e => e.Cifcifphone)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CIFCIFPhone")
                    .IsFixedLength();

                entity.Property(e => e.Cifcifstate)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CIFCIFState")
                    .IsFixedLength();

                entity.Property(e => e.Cifcifstreet)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CIFCIFStreet")
                    .IsFixedLength();

                entity.Property(e => e.Cifcifzip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIFCIFZip")
                    .IsFixedLength();

                entity.Property(e => e.CifcurAct1)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CIFCurAct1")
                    .IsFixedLength();

                entity.Property(e => e.CifcurAct2)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CIFCurAct2")
                    .IsFixedLength();

                entity.Property(e => e.CifcurAct3)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CIFCurAct3")
                    .IsFixedLength();

                entity.Property(e => e.CifcurAct4)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CIFCurAct4")
                    .IsFixedLength();

                entity.Property(e => e.CifcycleDate)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CIFCycleDate")
                    .IsFixedLength();

                entity.Property(e => e.CifcycleLength)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIFCycleLength")
                    .IsFixedLength();

                entity.Property(e => e.CifcycleStart)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CIFCycleStart")
                    .IsFixedLength();

                entity.Property(e => e.CifentryNumber)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIFEntryNumber")
                    .IsFixedLength();

                entity.Property(e => e.CifexpDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIFExpDate")
                    .IsFixedLength();

                entity.Property(e => e.Ciffname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CIFFName")
                    .IsFixedLength();

                entity.Property(e => e.CifgroupId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CIFGroupId")
                    .IsFixedLength();

                entity.Property(e => e.CifholdDate)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CIFHoldDate")
                    .IsFixedLength();

                entity.Property(e => e.CifholdLength)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIFHoldLength")
                    .IsFixedLength();

                entity.Property(e => e.Cifinitial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CIFInitial")
                    .IsFixedLength();

                entity.Property(e => e.Ciflimit1)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CIFLimit1")
                    .IsFixedLength();

                entity.Property(e => e.Ciflimit2)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CIFLimit2")
                    .IsFixedLength();

                entity.Property(e => e.Ciflimit3)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CIFLimit3")
                    .IsFixedLength();

                entity.Property(e => e.Ciflimit4)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CIFLimit4")
                    .IsFixedLength();

                entity.Property(e => e.Ciflname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CIFLName")
                    .IsFixedLength();

                entity.Property(e => e.CifmemNum)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CIFMemNum")
                    .IsFixedLength();

                entity.Property(e => e.CifoffsetCaptured)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CIFOffsetCaptured")
                    .IsFixedLength();

                entity.Property(e => e.Cifpan)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("CIFPan")
                    .IsFixedLength();

                entity.Property(e => e.CifpinOffset)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CIFPinOffset")
                    .IsFixedLength();

                entity.Property(e => e.CifpinTryCount1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIFPinTryCount1")
                    .IsFixedLength();

                entity.Property(e => e.CifpinTryLimit1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIFPinTryLimit1")
                    .IsFixedLength();

                entity.Property(e => e.Cifreserved1)
                    .HasMaxLength(56)
                    .IsUnicode(false)
                    .HasColumnName("CIFReserved1")
                    .IsFixedLength();

                entity.Property(e => e.CifserviceCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CIFServiceCode")
                    .IsFixedLength();

                entity.Property(e => e.CiftotalHolds)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CIFTotalHolds")
                    .IsFixedLength();

                entity.Property(e => e.CifupdateActivity)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CIFUpdateActivity")
                    .IsFixedLength();

                entity.Property(e => e.CifupdateDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIFUpdateDate")
                    .IsFixedLength();

                entity.Property(e => e.CifupdateTime)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CIFUpdateTime")
                    .IsFixedLength();

                entity.Property(e => e.CifupdateType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CIFUpdateType")
                    .IsFixedLength();

                entity.Property(e => e.CifuserId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CIFUserId")
                    .IsFixedLength();

                entity.Property(e => e.CifvelCount0)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIFVelCount0")
                    .IsFixedLength();

                entity.Property(e => e.CifvelCount1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIFVelCount1")
                    .IsFixedLength();

                entity.Property(e => e.CifvelCount2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIFVelCount2")
                    .IsFixedLength();

                entity.Property(e => e.CifvelCount3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIFVelCount3")
                    .IsFixedLength();

                entity.Property(e => e.CifvelCount4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIFVelCount4")
                    .IsFixedLength();

                entity.Property(e => e.CifvelLimit0)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIFVelLimit0")
                    .IsFixedLength();

                entity.Property(e => e.CifvelLimit1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIFVelLimit1")
                    .IsFixedLength();

                entity.Property(e => e.CifvelLimit2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIFVelLimit2")
                    .IsFixedLength();

                entity.Property(e => e.CifvelLimit3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIFVelLimit3")
                    .IsFixedLength();

                entity.Property(e => e.CifvelLimit4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIFVelLimit4")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cifnumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIFNumbers");

                entity.Property(e => e.Acct).HasColumnName("ACCT");

                entity.Property(e => e.Cif).HasColumnName("CIF");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.IdCompany);

                entity.Property(e => e.IdCompany).HasColumnName("ID_COMPANY");

                entity.Property(e => e.IdDefaultGrp).HasColumnName("ID_DEFAULT_GRP");

                entity.Property(e => e.IdManager).HasColumnName("ID_MANAGER");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.NmCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_COMPANY");

                entity.Property(e => e.NmNickname)
                    .HasMaxLength(20)
                    .HasColumnName("NM_NICKNAME")
                    .IsFixedLength();

                entity.Property(e => e.NmRegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_REG_NO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NmTrade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_TRADE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TxDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TX_DESC")
                    .IsFixedLength();
            });

            modelBuilder.Entity<CompanyHrmap>(entity =>
            {
                entity.ToTable("CompanyHRMap");

                entity.Property(e => e.CompanyHrmapId).HasColumnName("CompanyHRMapId");

                entity.Property(e => e.DivisioncodeI)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("DIVISIONCODE_I")
                    .IsFixedLength();
            });

            modelBuilder.Entity<CurrSal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Curr_Sal");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.NmFirst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_FIRST");

                entity.Property(e => e.NmLast)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_LAST");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Currency");

                entity.Property(e => e.Currency1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Currency")
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DepartmentHrmap>(entity =>
            {
                entity.ToTable("DepartmentHRMap");

                entity.Property(e => e.DepartmentHrmapId).HasColumnName("DepartmentHRMapId");

                entity.Property(e => e.Deprtmnt)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("DEPRTMNT")
                    .IsFixedLength();
            });

            modelBuilder.Entity<DivisionHrmap>(entity =>
            {
                entity.ToTable("DivisionHRMap");

                entity.Property(e => e.DivisionHrmapId).HasColumnName("DivisionHRMapId");

                entity.Property(e => e.Deprtmnt)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("DEPRTMNT")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Draft>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BanKdrawnOn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BanKDrawnOn");

                entity.Property(e => e.Currency)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeleteFlg).HasDefaultValueSql("(0)");

                entity.Property(e => e.Payee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Purchaser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TheUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("theUser");

                entity.Property(e => e.UserMachine)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("userMachine")
                    .IsFixedLength();
            });

            modelBuilder.Entity<EarningType>(entity =>
            {
                entity.Property(e => e.EarningTypeId).HasColumnName("EarningTypeID");

                entity.Property(e => e.AccountType).HasDefaultValueSql("((105))");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.AmountType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DepositAccount)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EarningTypes)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EarningTypes_Employees");
            });

            modelBuilder.Entity<EmpRep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmpRep");

                entity.Property(e => e.Apr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Aug)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Day).HasColumnName("DAY");

                entity.Property(e => e.Dec)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmpId).HasColumnName("empID");

                entity.Property(e => e.Feb)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FEb")
                    .IsFixedLength();

                entity.Property(e => e.Jan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Jul)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Jun)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mar)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.May)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nov)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oct)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sep)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TheYear).HasColumnName("theYear");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee);

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.AcPay)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("AC_PAY");

                entity.Property(e => e.DtEndProb)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END_PROB");

                entity.Property(e => e.DtHired)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_HIRED");

                entity.Property(e => e.DtTerm)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_TERM");

                entity.Property(e => e.IdAcctType).HasColumnName("ID_ACCT_TYPE");

                entity.Property(e => e.IdAlt).HasColumnName("ID_ALT");

                entity.Property(e => e.IdBranch).HasColumnName("ID_BRANCH");

                entity.Property(e => e.IdCompany).HasColumnName("ID_COMPANY");

                entity.Property(e => e.IdDept).HasColumnName("ID_DEPT");

                entity.Property(e => e.IdDivision).HasColumnName("ID_DIVISION");

                entity.Property(e => e.IdEmpMngr).HasColumnName("ID_EMP_MNGR");

                entity.Property(e => e.IdEmpType).HasColumnName("ID_EMP_TYPE");

                entity.Property(e => e.IdGrade).HasColumnName("ID_GRADE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdProfile).HasColumnName("ID_PROFILE");

                entity.Property(e => e.IdStaffNo)
                    .HasMaxLength(7)
                    .HasColumnName("ID_STAFF_NO")
                    .IsFixedLength();

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InInactive)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IN_INACTIVE");

                entity.Property(e => e.InIsStaff)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_IS_STAFF")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength();

                entity.Property(e => e.MnyPayMonth)
                    .HasColumnType("money")
                    .HasColumnName("MNY_PAY_MONTH");

                entity.Property(e => e.MnyPayReg)
                    .HasColumnType("money")
                    .HasColumnName("MNY_PAY_REG");

                entity.Property(e => e.MnyRtOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_RT_OVRTIME");

                entity.Property(e => e.NmEmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_EMPLOYEE_CODE");

                entity.Property(e => e.TxJobDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_JOB_DESC");

                entity.Property(e => e.TxJobTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_JOB_TITLE");

                entity.HasOne(d => d.IdCompanyNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdCompany)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_Companies");

                entity.HasOne(d => d.IdEmpTypeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdEmpType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_EmployeeGroups");

                entity.HasOne(d => d.IdProfileNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdProfile)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_Profiles");
            });

            modelBuilder.Entity<EmployeeGroup>(entity =>
            {
                entity.HasKey(e => e.IdEmpGroup);

                entity.Property(e => e.IdEmpGroup).HasColumnName("ID_EMP_GROUP");

                entity.Property(e => e.CyPayment).HasColumnName("CY_PAYMENT");

                entity.Property(e => e.GlOvertime).HasColumnName("GL_OVERTIME");

                entity.Property(e => e.GlRegularPay).HasColumnName("GL_REGULAR_PAY");

                entity.Property(e => e.GlSlEmpee).HasColumnName("GL_SL_EMPEE");

                entity.Property(e => e.GlSlExps).HasColumnName("GL_SL_EXPS");

                entity.Property(e => e.GlSlLiable)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GL_SL_LIABLE")
                    .IsFixedLength();

                entity.Property(e => e.GlSsEmpee).HasColumnName("GL_SS_EMPEE");

                entity.Property(e => e.GlSsExps)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GL_SS_EXPS")
                    .IsFixedLength();

                entity.Property(e => e.GlSsLiable).HasColumnName("GL_SS_LIABLE");

                entity.Property(e => e.GlSwExps).HasColumnName("GL_SW_EXPS");

                entity.Property(e => e.IdCompany).HasColumnName("ID_COMPANY");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.NmEmpGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_EMP_GROUP");
            });

            modelBuilder.Entity<EmployeeHistory>(entity =>
            {
                entity.HasKey(e => e.IdHistory);

                entity.ToTable("EmployeeHistory");

                entity.HasIndex(e => new { e.InIsStaff, e.IdCompany, e.IdEmployee }, "IX_EmployeeHistory_ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.AcPay)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("AC_PAY");

                entity.Property(e => e.DtHired)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_HIRED");

                entity.Property(e => e.DtTerm)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_TERM");

                entity.Property(e => e.HistoryTimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("history_timestamp")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HistoryUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("history_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.IdAcctType).HasColumnName("ID_ACCT_TYPE");

                entity.Property(e => e.IdBranch).HasColumnName("ID_BRANCH");

                entity.Property(e => e.IdCompany).HasColumnName("ID_COMPANY");

                entity.Property(e => e.IdDept).HasColumnName("ID_DEPT");

                entity.Property(e => e.IdDivision).HasColumnName("ID_DIVISION");

                entity.Property(e => e.IdEmpMngr).HasColumnName("ID_EMP_MNGR");

                entity.Property(e => e.IdEmpType).HasColumnName("ID_EMP_TYPE");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdGrade).HasColumnName("ID_GRADE");

                entity.Property(e => e.IdProfile).HasColumnName("ID_PROFILE");

                entity.Property(e => e.InIsStaff)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_IS_STAFF")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength();

                entity.Property(e => e.MnyPayMonth)
                    .HasColumnType("money")
                    .HasColumnName("MNY_PAY_MONTH");

                entity.Property(e => e.MnyPayReg)
                    .HasColumnType("money")
                    .HasColumnName("MNY_PAY_REG");

                entity.Property(e => e.MnyRtOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_RT_OVRTIME");

                entity.Property(e => e.TxJobDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_JOB_DESC");

                entity.Property(e => e.TxJobTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_JOB_TITLE");

                entity.HasOne(d => d.IdCompanyNavigation)
                    .WithMany(p => p.EmployeeHistories)
                    .HasForeignKey(d => d.IdCompany)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeHistory_Companies");

                entity.HasOne(d => d.IdEmpTypeNavigation)
                    .WithMany(p => p.EmployeeHistories)
                    .HasForeignKey(d => d.IdEmpType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeHistory_EmployeeGroups");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.EmployeeHistories)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeHistory_Employees");

                entity.HasOne(d => d.IdProfileNavigation)
                    .WithMany(p => p.EmployeeHistories)
                    .HasForeignKey(d => d.IdProfile)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeHistory_Profiles");
            });

            modelBuilder.Entity<EmployeeListing>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmployeeListing");

                entity.Property(e => e.CdZip).HasColumnName("CD_ZIP");

                entity.Property(e => e.DtDob)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_DOB");

                entity.Property(e => e.IdSocialSec).HasColumnName("ID_SOCIAL_SEC");

                entity.Property(e => e.Name)
                    .HasMaxLength(102)
                    .IsUnicode(false);

                entity.Property(e => e.NmCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_CITY");

                entity.Property(e => e.NmCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_COMPANY");

                entity.Property(e => e.NmCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_COUNTRY");

                entity.Property(e => e.PhPhone1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PH_PHONE1")
                    .IsFixedLength();

                entity.Property(e => e.TxAddr1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TX_ADDR1")
                    .IsFixedLength();

                entity.Property(e => e.TxAddr2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TX_ADDR2")
                    .IsFixedLength();

                entity.Property(e => e.TxJobTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_JOB_TITLE");
            });

            modelBuilder.Entity<EmployeePerformance>(entity =>
            {
                entity.Property(e => e.EmployeePerformanceId).HasColumnName("EmployeePerformanceID");

                entity.Property(e => e.EmployeeHistoryId).HasColumnName("EmployeeHistoryID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeePerformances)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeePerformances_Employees");
            });

            modelBuilder.Entity<EmployeePerformanceHistory>(entity =>
            {
                entity.HasKey(e => e.PerformanceHistoryId)
                    .HasName("PK_EmployeePerformanceHIstory");

                entity.ToTable("EmployeePerformanceHistory");

                entity.Property(e => e.PerformanceHistoryId).HasColumnName("PerformanceHistoryID");

                entity.Property(e => e.EmployeeHistoryId).HasColumnName("EmployeeHistoryID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeePerformanceId).HasColumnName("EmployeePerformanceID");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeePerformanceHistories)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerformanceHistory_Employees");
            });

            modelBuilder.Entity<EmployeePic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmployeePic");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.IdSocialSec).HasColumnName("ID_Social_Sec");

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.ImageId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ImageID");
            });

            modelBuilder.Entity<EntitlementBf>(entity =>
            {
                entity.HasKey(e => e.KeyId)
                    .HasName("PK_EntitlementBF_1");

                entity.ToTable("EntitlementBF");

                entity.Property(e => e.KeyId).HasColumnName("keyID");

                entity.Property(e => e.AbsentType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Absent_Type")
                    .IsFixedLength();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.User)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EntitlementBfBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EntitlementBF_BK");

                entity.Property(e => e.AbsentType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Absent_Type")
                    .IsFixedLength();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.KeyId).HasColumnName("keyID");

                entity.Property(e => e.User)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EntitlementBfold>(entity =>
            {
                entity.HasKey(e => e.KeyId)
                    .HasName("PK_EntitlementBF");

                entity.ToTable("EntitlementBFOld");

                entity.Property(e => e.KeyId).HasColumnName("keyID");

                entity.Property(e => e.AbsentType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Absent_Type")
                    .IsFixedLength();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.User)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GetBfwdInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("getBfwdInfo");

                entity.Property(e => e.AbsentType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Absent_Type")
                    .IsFixedLength();

                entity.Property(e => e.NmFirst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_FIRST");

                entity.Property(e => e.NmLast)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_LAST");
            });

            modelBuilder.Entity<Glaccount>(entity =>
            {
                entity.HasKey(e => e.IdGl);

                entity.ToTable("GLAccounts");

                entity.Property(e => e.IdGl).HasColumnName("ID_GL");

                entity.Property(e => e.AcGl).HasColumnName("AC_GL");

                entity.Property(e => e.IdCompany).HasColumnName("ID_COMPANY");

                entity.Property(e => e.IdGlMstrtyp).HasColumnName("ID_GL_MSTRTYP");

                entity.Property(e => e.IdGlSubtyp).HasColumnName("ID_GL_SUBTYP");

                entity.Property(e => e.IdGroup).HasColumnName("ID_GROUP");

                entity.HasOne(d => d.IdCompanyNavigation)
                    .WithMany(p => p.Glaccounts)
                    .HasForeignKey(d => d.IdCompany)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GLAccounts_Companies");

                entity.HasOne(d => d.IdGroupNavigation)
                    .WithMany(p => p.Glaccounts)
                    .HasForeignKey(d => d.IdGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GLAccounts_EmployeeGroups");
            });

            modelBuilder.Entity<Horizon55>(entity =>
            {
                entity.HasKey(e => e.IdCard)
                    .IsClustered(false);

                entity.ToTable("Horizon55");

                entity.Property(e => e.IdCard).HasColumnName("ID_CARD");

                entity.Property(e => e.Account1)
                    .HasMaxLength(50)
                    .HasColumnName("Account #1");

                entity.Property(e => e.Account2)
                    .HasMaxLength(50)
                    .HasColumnName("Account # 2");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(50)
                    .HasColumnName("Account Type");

                entity.Property(e => e.CardIssued).HasColumnName("Card Issued");

                entity.Property(e => e.DateLoaded)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Date Loaded");

                entity.Property(e => e.IdProfile).HasColumnName("ID_PROFILE");

                entity.Property(e => e.MemberName).HasMaxLength(50);

                entity.HasOne(d => d.IdProfileNavigation)
                    .WithMany(p => p.Horizon55s)
                    .HasForeignKey(d => d.IdProfile)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Horizon55_Profiles");
            });

            modelBuilder.Entity<InactiveAtt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("InactiveAtt");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.InInactive)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IN_INACTIVE");

                entity.Property(e => e.NmFull)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_FULL");
            });

            modelBuilder.Entity<ManagerType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Manager_Types");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsValid).HasColumnName("isValid");

                entity.Property(e => e.NumKey)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("numKey");
            });

            modelBuilder.Entity<ManagersCheque>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BankFirstPresented)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId)
                    .HasColumnName("branchID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCleared).HasColumnType("datetime");

                entity.Property(e => e.DeleteFlg)
                    .HasColumnName("deleteFlg")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MPmntId).HasColumnName("mPmntID");

                entity.Property(e => e.Payee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Purchaser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TheMachine)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("theMachine");

                entity.Property(e => e.TheUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("theUser");
            });

            modelBuilder.Entity<MstrType>(entity =>
            {
                entity.HasKey(e => e.IdMstrTyp)
                    .HasName("PK_DIVISION");

                entity.Property(e => e.IdMstrTyp).HasColumnName("ID_MSTR_TYP");

                entity.Property(e => e.IdMstrTypMngr).HasColumnName("ID_MSTR_TYP_MNGR");

                entity.Property(e => e.NmMstrTyp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_MSTR_TYP");

                entity.Property(e => e.TxDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TX_DESC")
                    .IsFixedLength();
            });

            modelBuilder.Entity<MyItem>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ItemNo).HasColumnName("Item_No");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Order_No");

                entity.Property(e => e.UniqueId).HasColumnName("Unique_ID");
            });

            modelBuilder.Entity<MyOrder>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Order_No");

                entity.Property(e => e.UniqueId).HasColumnName("Unique_ID");
            });

            modelBuilder.Entity<NationalCallsCustomReport>(entity =>
            {
                entity.HasKey(e => e.ReportSp);

                entity.Property(e => e.ReportSp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ReportSP");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OtherImage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateAded).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.ImageId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ImageID");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.IdPayment);

                entity.HasIndex(e => e.DtPaid, "IX_DT_PAID");

                entity.HasIndex(e => e.IdHistory, "IX_ID_HISTORY");

                entity.Property(e => e.IdPayment).HasColumnName("ID_PAYMENT");

                entity.Property(e => e.DtBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_BEGIN");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END");

                entity.Property(e => e.DtLastModified)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_LAST_MODIFIED");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.GlOvertime).HasColumnName("GL_OVERTIME");

                entity.Property(e => e.GlRegularPay).HasColumnName("GL_REGULAR_PAY");

                entity.Property(e => e.GlSlEmpee).HasColumnName("GL_SL_EMPEE");

                entity.Property(e => e.GlSlExps).HasColumnName("GL_SL_EXPS");

                entity.Property(e => e.GlSlLiable).HasColumnName("GL_SL_LIABLE");

                entity.Property(e => e.GlSsEmpee).HasColumnName("GL_SS_EMPEE");

                entity.Property(e => e.GlSsExps).HasColumnName("GL_SS_EXPS");

                entity.Property(e => e.GlSsLiable).HasColumnName("GL_SS_LIABLE");

                entity.Property(e => e.GlSwExps).HasColumnName("GL_SW_EXPS");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdRegPayment).HasColumnName("ID_REG_PAYMENT");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InOverride)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_OVERRIDE")
                    .IsFixedLength();

                entity.Property(e => e.InPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_PAID")
                    .IsFixedLength();

                entity.Property(e => e.InSentToSsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_SENT_TO_SSB")
                    .IsFixedLength();

                entity.Property(e => e.MnyEmpeeSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SL");

                entity.Property(e => e.MnyEmpeeSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SS");

                entity.Property(e => e.MnyEmperSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL");

                entity.Property(e => e.MnyEmperSlSev)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL_SEV");

                entity.Property(e => e.MnyEmperSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS");

                entity.Property(e => e.MnyEmperSsInj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS_INJ");

                entity.Property(e => e.MnyGrossPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_GROSS_PAY");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.MnyOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_OVRTIME");

                entity.Property(e => e.MnyRegPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_REG_PAY");

                entity.Property(e => e.MnyTotAdj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_TOT_ADJ");

                entity.Property(e => e.MnyYtdGross)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_GROSS");

                entity.Property(e => e.MnyYtdSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SL");

                entity.Property(e => e.MnyYtdSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SS");

                entity.Property(e => e.TxComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_COMMENT");
            });

            modelBuilder.Entity<PaymentSetting>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LowerLimit)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("LOWER_LIMIT");

                entity.Property(e => e.UpperLimit)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("UPPER_LIMIT");
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.HasKey(e => e.IdPaymentType);

                entity.Property(e => e.IdPaymentType).HasColumnName("ID_PAYMENT_TYPE");

                entity.Property(e => e.Abbrev)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ABBREV")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdCompany)
                    .HasColumnName("ID_COMPANY")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.LwrLimit)
                    .IsRequired()
                    .HasColumnName("LWR_LIMIT")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.NmPaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_PAYMENT_TYPE");

                entity.Property(e => e.Slee)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("SLEE")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Sler)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("SLER")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Ssb)
                    .IsRequired()
                    .HasColumnName("SSB")
                    .HasDefaultValueSql("(1)")
                    .HasComment("Indicates if this payment type should be in SSB report");

                entity.Property(e => e.Ssee)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("SSEE")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Sser)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("SSER")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.UprLimit)
                    .IsRequired()
                    .HasColumnName("UPR_LIMIT")
                    .HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<Payments001>(entity =>
            {
                entity.HasKey(e => e.IdPayment)
                    .HasName("PK_Payments_1");

                entity.ToTable("Payments_001");

                entity.Property(e => e.IdPayment)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_PAYMENT");

                entity.Property(e => e.DtBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_BEGIN");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END");

                entity.Property(e => e.DtLastModified)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_LAST_MODIFIED");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.GlOvertime).HasColumnName("GL_OVERTIME");

                entity.Property(e => e.GlRegularPay).HasColumnName("GL_REGULAR_PAY");

                entity.Property(e => e.GlSlEmpee).HasColumnName("GL_SL_EMPEE");

                entity.Property(e => e.GlSlExps).HasColumnName("GL_SL_EXPS");

                entity.Property(e => e.GlSlLiable).HasColumnName("GL_SL_LIABLE");

                entity.Property(e => e.GlSsEmpee).HasColumnName("GL_SS_EMPEE");

                entity.Property(e => e.GlSsExps).HasColumnName("GL_SS_EXPS");

                entity.Property(e => e.GlSsLiable).HasColumnName("GL_SS_LIABLE");

                entity.Property(e => e.GlSwExps).HasColumnName("GL_SW_EXPS");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdRegPayment).HasColumnName("ID_REG_PAYMENT");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InOverride)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_OVERRIDE")
                    .IsFixedLength();

                entity.Property(e => e.InPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_PAID")
                    .IsFixedLength();

                entity.Property(e => e.InSentToSsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_SENT_TO_SSB")
                    .IsFixedLength();

                entity.Property(e => e.MnyEmpeeSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SL");

                entity.Property(e => e.MnyEmpeeSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SS");

                entity.Property(e => e.MnyEmperSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL");

                entity.Property(e => e.MnyEmperSlSev)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL_SEV");

                entity.Property(e => e.MnyEmperSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS");

                entity.Property(e => e.MnyEmperSsInj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS_INJ");

                entity.Property(e => e.MnyGrossPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_GROSS_PAY");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.MnyOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_OVRTIME");

                entity.Property(e => e.MnyRegPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_REG_PAY");

                entity.Property(e => e.MnyTotAdj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_TOT_ADJ");

                entity.Property(e => e.MnyYtdGross)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_GROSS");

                entity.Property(e => e.MnyYtdSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SL");

                entity.Property(e => e.MnyYtdSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SS");

                entity.Property(e => e.TxComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_COMMENT");
            });

            modelBuilder.Entity<Payments14102011>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payments_14102011");

                entity.Property(e => e.DtBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_BEGIN");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END");

                entity.Property(e => e.DtLastModified)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_LAST_MODIFIED");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.GlOvertime).HasColumnName("GL_OVERTIME");

                entity.Property(e => e.GlRegularPay).HasColumnName("GL_REGULAR_PAY");

                entity.Property(e => e.GlSlEmpee).HasColumnName("GL_SL_EMPEE");

                entity.Property(e => e.GlSlExps).HasColumnName("GL_SL_EXPS");

                entity.Property(e => e.GlSlLiable).HasColumnName("GL_SL_LIABLE");

                entity.Property(e => e.GlSsEmpee).HasColumnName("GL_SS_EMPEE");

                entity.Property(e => e.GlSsExps).HasColumnName("GL_SS_EXPS");

                entity.Property(e => e.GlSsLiable).HasColumnName("GL_SS_LIABLE");

                entity.Property(e => e.GlSwExps).HasColumnName("GL_SW_EXPS");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdPayment).HasColumnName("ID_PAYMENT");

                entity.Property(e => e.IdRegPayment).HasColumnName("ID_REG_PAYMENT");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InOverride)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_OVERRIDE")
                    .IsFixedLength();

                entity.Property(e => e.InPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_PAID")
                    .IsFixedLength();

                entity.Property(e => e.InSentToSsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_SENT_TO_SSB")
                    .IsFixedLength();

                entity.Property(e => e.MnyEmpeeSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SL");

                entity.Property(e => e.MnyEmpeeSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SS");

                entity.Property(e => e.MnyEmperSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL");

                entity.Property(e => e.MnyEmperSlSev)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL_SEV");

                entity.Property(e => e.MnyEmperSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS");

                entity.Property(e => e.MnyEmperSsInj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS_INJ");

                entity.Property(e => e.MnyGrossPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_GROSS_PAY");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.MnyOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_OVRTIME");

                entity.Property(e => e.MnyRegPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_REG_PAY");

                entity.Property(e => e.MnyTotAdj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_TOT_ADJ");

                entity.Property(e => e.MnyYtdGross)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_GROSS");

                entity.Property(e => e.MnyYtdSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SL");

                entity.Property(e => e.MnyYtdSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SS");

                entity.Property(e => e.TxComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_COMMENT");
            });

            modelBuilder.Entity<Payments2008T02010>(entity =>
            {
                entity.HasKey(e => e.IdPayment)
                    .HasName("PK_Payments_2008_To_2010");

                entity.ToTable("Payments_2008_T0_2010");

                entity.Property(e => e.IdPayment).HasColumnName("ID_PAYMENT");

                entity.Property(e => e.DtBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_BEGIN");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END");

                entity.Property(e => e.DtLastModified)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_LAST_MODIFIED");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.GlOvertime).HasColumnName("GL_OVERTIME");

                entity.Property(e => e.GlRegularPay).HasColumnName("GL_REGULAR_PAY");

                entity.Property(e => e.GlSlEmpee).HasColumnName("GL_SL_EMPEE");

                entity.Property(e => e.GlSlExps).HasColumnName("GL_SL_EXPS");

                entity.Property(e => e.GlSlLiable).HasColumnName("GL_SL_LIABLE");

                entity.Property(e => e.GlSsEmpee).HasColumnName("GL_SS_EMPEE");

                entity.Property(e => e.GlSsExps).HasColumnName("GL_SS_EXPS");

                entity.Property(e => e.GlSsLiable).HasColumnName("GL_SS_LIABLE");

                entity.Property(e => e.GlSwExps).HasColumnName("GL_SW_EXPS");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdRegPayment).HasColumnName("ID_REG_PAYMENT");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InOverride)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_OVERRIDE")
                    .IsFixedLength();

                entity.Property(e => e.InPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_PAID")
                    .IsFixedLength();

                entity.Property(e => e.InSentToSsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_SENT_TO_SSB")
                    .IsFixedLength();

                entity.Property(e => e.MnyEmpeeSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SL");

                entity.Property(e => e.MnyEmpeeSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SS");

                entity.Property(e => e.MnyEmperSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL");

                entity.Property(e => e.MnyEmperSlSev)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL_SEV");

                entity.Property(e => e.MnyEmperSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS");

                entity.Property(e => e.MnyEmperSsInj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS_INJ");

                entity.Property(e => e.MnyGrossPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_GROSS_PAY");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.MnyOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_OVRTIME");

                entity.Property(e => e.MnyRegPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_REG_PAY");

                entity.Property(e => e.MnyTotAdj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_TOT_ADJ");

                entity.Property(e => e.MnyYtdGross)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_GROSS");

                entity.Property(e => e.MnyYtdSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SL");

                entity.Property(e => e.MnyYtdSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SS");

                entity.Property(e => e.TxComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_COMMENT");
            });

            modelBuilder.Entity<Payments2008To2010Bk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payments2008_TO_2010_BK");

                entity.Property(e => e.DtBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_BEGIN");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END");

                entity.Property(e => e.DtLastModified)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_LAST_MODIFIED");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.GlOvertime).HasColumnName("GL_OVERTIME");

                entity.Property(e => e.GlRegularPay).HasColumnName("GL_REGULAR_PAY");

                entity.Property(e => e.GlSlEmpee).HasColumnName("GL_SL_EMPEE");

                entity.Property(e => e.GlSlExps).HasColumnName("GL_SL_EXPS");

                entity.Property(e => e.GlSlLiable).HasColumnName("GL_SL_LIABLE");

                entity.Property(e => e.GlSsEmpee).HasColumnName("GL_SS_EMPEE");

                entity.Property(e => e.GlSsExps).HasColumnName("GL_SS_EXPS");

                entity.Property(e => e.GlSsLiable).HasColumnName("GL_SS_LIABLE");

                entity.Property(e => e.GlSwExps).HasColumnName("GL_SW_EXPS");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdPayment).HasColumnName("ID_PAYMENT");

                entity.Property(e => e.IdRegPayment).HasColumnName("ID_REG_PAYMENT");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InOverride)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_OVERRIDE")
                    .IsFixedLength();

                entity.Property(e => e.InPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_PAID")
                    .IsFixedLength();

                entity.Property(e => e.InSentToSsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_SENT_TO_SSB")
                    .IsFixedLength();

                entity.Property(e => e.MnyEmpeeSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SL");

                entity.Property(e => e.MnyEmpeeSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SS");

                entity.Property(e => e.MnyEmperSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL");

                entity.Property(e => e.MnyEmperSlSev)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL_SEV");

                entity.Property(e => e.MnyEmperSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS");

                entity.Property(e => e.MnyEmperSsInj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS_INJ");

                entity.Property(e => e.MnyGrossPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_GROSS_PAY");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.MnyOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_OVRTIME");

                entity.Property(e => e.MnyRegPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_REG_PAY");

                entity.Property(e => e.MnyTotAdj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_TOT_ADJ");

                entity.Property(e => e.MnyYtdGross)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_GROSS");

                entity.Property(e => e.MnyYtdSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SL");

                entity.Property(e => e.MnyYtdSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SS");

                entity.Property(e => e.TxComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_COMMENT");
            });

            modelBuilder.Entity<PaymentsCopyToNov2015FrstHlf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payments_Copy_TO_Nov2015_frstHlf");

                entity.Property(e => e.DtBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_BEGIN");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END");

                entity.Property(e => e.DtLastModified)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_LAST_MODIFIED");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.GlOvertime).HasColumnName("GL_OVERTIME");

                entity.Property(e => e.GlRegularPay).HasColumnName("GL_REGULAR_PAY");

                entity.Property(e => e.GlSlEmpee).HasColumnName("GL_SL_EMPEE");

                entity.Property(e => e.GlSlExps).HasColumnName("GL_SL_EXPS");

                entity.Property(e => e.GlSlLiable).HasColumnName("GL_SL_LIABLE");

                entity.Property(e => e.GlSsEmpee).HasColumnName("GL_SS_EMPEE");

                entity.Property(e => e.GlSsExps).HasColumnName("GL_SS_EXPS");

                entity.Property(e => e.GlSsLiable).HasColumnName("GL_SS_LIABLE");

                entity.Property(e => e.GlSwExps).HasColumnName("GL_SW_EXPS");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdPayment).HasColumnName("ID_PAYMENT");

                entity.Property(e => e.IdRegPayment).HasColumnName("ID_REG_PAYMENT");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InOverride)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_OVERRIDE")
                    .IsFixedLength();

                entity.Property(e => e.InPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_PAID")
                    .IsFixedLength();

                entity.Property(e => e.InSentToSsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_SENT_TO_SSB")
                    .IsFixedLength();

                entity.Property(e => e.MnyEmpeeSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SL");

                entity.Property(e => e.MnyEmpeeSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SS");

                entity.Property(e => e.MnyEmperSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL");

                entity.Property(e => e.MnyEmperSlSev)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL_SEV");

                entity.Property(e => e.MnyEmperSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS");

                entity.Property(e => e.MnyEmperSsInj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS_INJ");

                entity.Property(e => e.MnyGrossPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_GROSS_PAY");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.MnyOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_OVRTIME");

                entity.Property(e => e.MnyRegPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_REG_PAY");

                entity.Property(e => e.MnyTotAdj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_TOT_ADJ");

                entity.Property(e => e.MnyYtdGross)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_GROSS");

                entity.Property(e => e.MnyYtdSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SL");

                entity.Property(e => e.MnyYtdSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SS");

                entity.Property(e => e.TxComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_COMMENT");
            });

            modelBuilder.Entity<PaymentsDec09>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payments_Dec09");

                entity.Property(e => e.DtBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_BEGIN");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END");

                entity.Property(e => e.DtLastModified)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_LAST_MODIFIED");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.GlOvertime).HasColumnName("GL_OVERTIME");

                entity.Property(e => e.GlRegularPay).HasColumnName("GL_REGULAR_PAY");

                entity.Property(e => e.GlSlEmpee).HasColumnName("GL_SL_EMPEE");

                entity.Property(e => e.GlSlExps).HasColumnName("GL_SL_EXPS");

                entity.Property(e => e.GlSlLiable).HasColumnName("GL_SL_LIABLE");

                entity.Property(e => e.GlSsEmpee).HasColumnName("GL_SS_EMPEE");

                entity.Property(e => e.GlSsExps).HasColumnName("GL_SS_EXPS");

                entity.Property(e => e.GlSsLiable).HasColumnName("GL_SS_LIABLE");

                entity.Property(e => e.GlSwExps).HasColumnName("GL_SW_EXPS");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdPayment).HasColumnName("ID_PAYMENT");

                entity.Property(e => e.IdRegPayment).HasColumnName("ID_REG_PAYMENT");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InOverride)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_OVERRIDE")
                    .IsFixedLength();

                entity.Property(e => e.InPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_PAID")
                    .IsFixedLength();

                entity.Property(e => e.InSentToSsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_SENT_TO_SSB")
                    .IsFixedLength();

                entity.Property(e => e.MnyEmpeeSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SL");

                entity.Property(e => e.MnyEmpeeSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SS");

                entity.Property(e => e.MnyEmperSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL");

                entity.Property(e => e.MnyEmperSlSev)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL_SEV");

                entity.Property(e => e.MnyEmperSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS");

                entity.Property(e => e.MnyEmperSsInj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS_INJ");

                entity.Property(e => e.MnyGrossPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_GROSS_PAY");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.MnyOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_OVRTIME");

                entity.Property(e => e.MnyRegPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_REG_PAY");

                entity.Property(e => e.MnyTotAdj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_TOT_ADJ");

                entity.Property(e => e.MnyYtdGross)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_GROSS");

                entity.Property(e => e.MnyYtdSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SL");

                entity.Property(e => e.MnyYtdSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SS");

                entity.Property(e => e.TxComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_COMMENT");
            });

            modelBuilder.Entity<PaymentsJan2012>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payments_Jan2012");

                entity.Property(e => e.DtBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_BEGIN");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END");

                entity.Property(e => e.DtLastModified)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_LAST_MODIFIED");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.GlOvertime).HasColumnName("GL_OVERTIME");

                entity.Property(e => e.GlRegularPay).HasColumnName("GL_REGULAR_PAY");

                entity.Property(e => e.GlSlEmpee).HasColumnName("GL_SL_EMPEE");

                entity.Property(e => e.GlSlExps).HasColumnName("GL_SL_EXPS");

                entity.Property(e => e.GlSlLiable).HasColumnName("GL_SL_LIABLE");

                entity.Property(e => e.GlSsEmpee).HasColumnName("GL_SS_EMPEE");

                entity.Property(e => e.GlSsExps).HasColumnName("GL_SS_EXPS");

                entity.Property(e => e.GlSsLiable).HasColumnName("GL_SS_LIABLE");

                entity.Property(e => e.GlSwExps).HasColumnName("GL_SW_EXPS");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdPayment)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_PAYMENT");

                entity.Property(e => e.IdRegPayment).HasColumnName("ID_REG_PAYMENT");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InOverride)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_OVERRIDE")
                    .IsFixedLength();

                entity.Property(e => e.InPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_PAID")
                    .IsFixedLength();

                entity.Property(e => e.InSentToSsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_SENT_TO_SSB")
                    .IsFixedLength();

                entity.Property(e => e.MnyEmpeeSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SL");

                entity.Property(e => e.MnyEmpeeSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SS");

                entity.Property(e => e.MnyEmperSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL");

                entity.Property(e => e.MnyEmperSlSev)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL_SEV");

                entity.Property(e => e.MnyEmperSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS");

                entity.Property(e => e.MnyEmperSsInj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS_INJ");

                entity.Property(e => e.MnyGrossPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_GROSS_PAY");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.MnyOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_OVRTIME");

                entity.Property(e => e.MnyRegPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_REG_PAY");

                entity.Property(e => e.MnyTotAdj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_TOT_ADJ");

                entity.Property(e => e.MnyYtdGross)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_GROSS");

                entity.Property(e => e.MnyYtdSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SL");

                entity.Property(e => e.MnyYtdSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SS");

                entity.Property(e => e.TxComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_COMMENT");
            });

            modelBuilder.Entity<PaymentsJan82011>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payments_jan8_2011");

                entity.Property(e => e.DtBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_BEGIN");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END");

                entity.Property(e => e.DtLastModified)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_LAST_MODIFIED");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.GlOvertime).HasColumnName("GL_OVERTIME");

                entity.Property(e => e.GlRegularPay).HasColumnName("GL_REGULAR_PAY");

                entity.Property(e => e.GlSlEmpee).HasColumnName("GL_SL_EMPEE");

                entity.Property(e => e.GlSlExps).HasColumnName("GL_SL_EXPS");

                entity.Property(e => e.GlSlLiable).HasColumnName("GL_SL_LIABLE");

                entity.Property(e => e.GlSsEmpee).HasColumnName("GL_SS_EMPEE");

                entity.Property(e => e.GlSsExps).HasColumnName("GL_SS_EXPS");

                entity.Property(e => e.GlSsLiable).HasColumnName("GL_SS_LIABLE");

                entity.Property(e => e.GlSwExps).HasColumnName("GL_SW_EXPS");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdPayment).HasColumnName("ID_PAYMENT");

                entity.Property(e => e.IdRegPayment).HasColumnName("ID_REG_PAYMENT");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InOverride)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_OVERRIDE")
                    .IsFixedLength();

                entity.Property(e => e.InPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_PAID")
                    .IsFixedLength();

                entity.Property(e => e.InSentToSsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_SENT_TO_SSB")
                    .IsFixedLength();

                entity.Property(e => e.MnyEmpeeSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SL");

                entity.Property(e => e.MnyEmpeeSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SS");

                entity.Property(e => e.MnyEmperSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL");

                entity.Property(e => e.MnyEmperSlSev)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL_SEV");

                entity.Property(e => e.MnyEmperSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS");

                entity.Property(e => e.MnyEmperSsInj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS_INJ");

                entity.Property(e => e.MnyGrossPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_GROSS_PAY");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.MnyOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_OVRTIME");

                entity.Property(e => e.MnyRegPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_REG_PAY");

                entity.Property(e => e.MnyTotAdj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_TOT_ADJ");

                entity.Property(e => e.MnyYtdGross)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_GROSS");

                entity.Property(e => e.MnyYtdSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SL");

                entity.Property(e => e.MnyYtdSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SS");

                entity.Property(e => e.TxComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_COMMENT");
            });

            modelBuilder.Entity<PaymentsJan92011ToAug232017>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payments_Jan92011_To_Aug232017");

                entity.Property(e => e.DtBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_BEGIN");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END");

                entity.Property(e => e.DtLastModified)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_LAST_MODIFIED");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.GlOvertime).HasColumnName("GL_OVERTIME");

                entity.Property(e => e.GlRegularPay).HasColumnName("GL_REGULAR_PAY");

                entity.Property(e => e.GlSlEmpee).HasColumnName("GL_SL_EMPEE");

                entity.Property(e => e.GlSlExps).HasColumnName("GL_SL_EXPS");

                entity.Property(e => e.GlSlLiable).HasColumnName("GL_SL_LIABLE");

                entity.Property(e => e.GlSsEmpee).HasColumnName("GL_SS_EMPEE");

                entity.Property(e => e.GlSsExps).HasColumnName("GL_SS_EXPS");

                entity.Property(e => e.GlSsLiable).HasColumnName("GL_SS_LIABLE");

                entity.Property(e => e.GlSwExps).HasColumnName("GL_SW_EXPS");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdPayment).HasColumnName("ID_PAYMENT");

                entity.Property(e => e.IdRegPayment).HasColumnName("ID_REG_PAYMENT");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InOverride)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_OVERRIDE")
                    .IsFixedLength();

                entity.Property(e => e.InPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_PAID")
                    .IsFixedLength();

                entity.Property(e => e.InSentToSsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_SENT_TO_SSB")
                    .IsFixedLength();

                entity.Property(e => e.MnyEmpeeSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SL");

                entity.Property(e => e.MnyEmpeeSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SS");

                entity.Property(e => e.MnyEmperSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL");

                entity.Property(e => e.MnyEmperSlSev)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL_SEV");

                entity.Property(e => e.MnyEmperSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS");

                entity.Property(e => e.MnyEmperSsInj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS_INJ");

                entity.Property(e => e.MnyGrossPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_GROSS_PAY");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.MnyOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_OVRTIME");

                entity.Property(e => e.MnyRegPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_REG_PAY");

                entity.Property(e => e.MnyTotAdj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_TOT_ADJ");

                entity.Property(e => e.MnyYtdGross)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_GROSS");

                entity.Property(e => e.MnyYtdSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SL");

                entity.Property(e => e.MnyYtdSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SS");

                entity.Property(e => e.TxComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_COMMENT");
            });

            modelBuilder.Entity<PaymentsTemp2014>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payments_Temp2014");

                entity.Property(e => e.DtBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_BEGIN");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END");

                entity.Property(e => e.DtLastModified)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_LAST_MODIFIED");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.GlOvertime).HasColumnName("GL_OVERTIME");

                entity.Property(e => e.GlRegularPay).HasColumnName("GL_REGULAR_PAY");

                entity.Property(e => e.GlSlEmpee).HasColumnName("GL_SL_EMPEE");

                entity.Property(e => e.GlSlExps).HasColumnName("GL_SL_EXPS");

                entity.Property(e => e.GlSlLiable).HasColumnName("GL_SL_LIABLE");

                entity.Property(e => e.GlSsEmpee).HasColumnName("GL_SS_EMPEE");

                entity.Property(e => e.GlSsExps).HasColumnName("GL_SS_EXPS");

                entity.Property(e => e.GlSsLiable).HasColumnName("GL_SS_LIABLE");

                entity.Property(e => e.GlSwExps).HasColumnName("GL_SW_EXPS");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdPayment).HasColumnName("ID_PAYMENT");

                entity.Property(e => e.IdRegPayment).HasColumnName("ID_REG_PAYMENT");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InOverride)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_OVERRIDE")
                    .IsFixedLength();

                entity.Property(e => e.InPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_PAID")
                    .IsFixedLength();

                entity.Property(e => e.InSentToSsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_SENT_TO_SSB")
                    .IsFixedLength();

                entity.Property(e => e.MnyEmpeeSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SL");

                entity.Property(e => e.MnyEmpeeSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SS");

                entity.Property(e => e.MnyEmperSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL");

                entity.Property(e => e.MnyEmperSlSev)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL_SEV");

                entity.Property(e => e.MnyEmperSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS");

                entity.Property(e => e.MnyEmperSsInj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS_INJ");

                entity.Property(e => e.MnyGrossPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_GROSS_PAY");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.MnyOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_OVRTIME");

                entity.Property(e => e.MnyRegPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_REG_PAY");

                entity.Property(e => e.MnyTotAdj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_TOT_ADJ");

                entity.Property(e => e.MnyYtdGross)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_GROSS");

                entity.Property(e => e.MnyYtdSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SL");

                entity.Property(e => e.MnyYtdSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SS");

                entity.Property(e => e.TxComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_COMMENT");
            });

            modelBuilder.Entity<PaymentsTemp2016>(entity =>
            {
                entity.HasKey(e => e.IdPayment);

                entity.ToTable("Payments_Temp_2016");

                entity.Property(e => e.IdPayment).HasColumnName("ID_PAYMENT");

                entity.Property(e => e.DtBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_BEGIN");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END");

                entity.Property(e => e.DtLastModified)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_LAST_MODIFIED");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.GlOvertime).HasColumnName("GL_OVERTIME");

                entity.Property(e => e.GlRegularPay).HasColumnName("GL_REGULAR_PAY");

                entity.Property(e => e.GlSlEmpee).HasColumnName("GL_SL_EMPEE");

                entity.Property(e => e.GlSlExps).HasColumnName("GL_SL_EXPS");

                entity.Property(e => e.GlSlLiable).HasColumnName("GL_SL_LIABLE");

                entity.Property(e => e.GlSsEmpee).HasColumnName("GL_SS_EMPEE");

                entity.Property(e => e.GlSsExps).HasColumnName("GL_SS_EXPS");

                entity.Property(e => e.GlSsLiable).HasColumnName("GL_SS_LIABLE");

                entity.Property(e => e.GlSwExps).HasColumnName("GL_SW_EXPS");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdRegPayment).HasColumnName("ID_REG_PAYMENT");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InOverride)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_OVERRIDE")
                    .IsFixedLength();

                entity.Property(e => e.InPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_PAID")
                    .IsFixedLength();

                entity.Property(e => e.InSentToSsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_SENT_TO_SSB")
                    .IsFixedLength();

                entity.Property(e => e.MnyEmpeeSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SL");

                entity.Property(e => e.MnyEmpeeSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SS");

                entity.Property(e => e.MnyEmperSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL");

                entity.Property(e => e.MnyEmperSlSev)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL_SEV");

                entity.Property(e => e.MnyEmperSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS");

                entity.Property(e => e.MnyEmperSsInj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS_INJ");

                entity.Property(e => e.MnyGrossPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_GROSS_PAY");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.MnyOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_OVRTIME");

                entity.Property(e => e.MnyRegPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_REG_PAY");

                entity.Property(e => e.MnyTotAdj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_TOT_ADJ");

                entity.Property(e => e.MnyYtdGross)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_GROSS");

                entity.Property(e => e.MnyYtdSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SL");

                entity.Property(e => e.MnyYtdSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SS");

                entity.Property(e => e.TxComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_COMMENT");
            });

            modelBuilder.Entity<PaymentsTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PaymentsTMP");

                entity.Property(e => e.DtBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_BEGIN");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END");

                entity.Property(e => e.DtLastModified)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_LAST_MODIFIED");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.GlOvertime).HasColumnName("GL_OVERTIME");

                entity.Property(e => e.GlRegularPay).HasColumnName("GL_REGULAR_PAY");

                entity.Property(e => e.GlSlEmpee).HasColumnName("GL_SL_EMPEE");

                entity.Property(e => e.GlSlExps).HasColumnName("GL_SL_EXPS");

                entity.Property(e => e.GlSlLiable).HasColumnName("GL_SL_LIABLE");

                entity.Property(e => e.GlSsEmpee).HasColumnName("GL_SS_EMPEE");

                entity.Property(e => e.GlSsExps).HasColumnName("GL_SS_EXPS");

                entity.Property(e => e.GlSsLiable).HasColumnName("GL_SS_LIABLE");

                entity.Property(e => e.GlSwExps).HasColumnName("GL_SW_EXPS");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdPayment).HasColumnName("ID_PAYMENT");

                entity.Property(e => e.IdRegPayment).HasColumnName("ID_REG_PAYMENT");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InOverride)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_OVERRIDE")
                    .IsFixedLength();

                entity.Property(e => e.InPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_PAID")
                    .IsFixedLength();

                entity.Property(e => e.InSentToSsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_SENT_TO_SSB")
                    .IsFixedLength();

                entity.Property(e => e.MnyEmpeeSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SL");

                entity.Property(e => e.MnyEmpeeSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SS");

                entity.Property(e => e.MnyEmperSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL");

                entity.Property(e => e.MnyEmperSlSev)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL_SEV");

                entity.Property(e => e.MnyEmperSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS");

                entity.Property(e => e.MnyEmperSsInj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS_INJ");

                entity.Property(e => e.MnyGrossPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_GROSS_PAY");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.MnyOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_OVRTIME");

                entity.Property(e => e.MnyRegPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_REG_PAY");

                entity.Property(e => e.MnyTotAdj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_TOT_ADJ");

                entity.Property(e => e.MnyYtdGross)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_GROSS");

                entity.Property(e => e.MnyYtdSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SL");

                entity.Property(e => e.MnyYtdSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SS");

                entity.Property(e => e.TxComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_COMMENT");
            });

            modelBuilder.Entity<PaymentsToDec2017>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payments_ToDec2017");

                entity.Property(e => e.DtBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_BEGIN");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END");

                entity.Property(e => e.DtLastModified)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_LAST_MODIFIED");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.GlOvertime).HasColumnName("GL_OVERTIME");

                entity.Property(e => e.GlRegularPay).HasColumnName("GL_REGULAR_PAY");

                entity.Property(e => e.GlSlEmpee).HasColumnName("GL_SL_EMPEE");

                entity.Property(e => e.GlSlExps).HasColumnName("GL_SL_EXPS");

                entity.Property(e => e.GlSlLiable).HasColumnName("GL_SL_LIABLE");

                entity.Property(e => e.GlSsEmpee).HasColumnName("GL_SS_EMPEE");

                entity.Property(e => e.GlSsExps).HasColumnName("GL_SS_EXPS");

                entity.Property(e => e.GlSsLiable).HasColumnName("GL_SS_LIABLE");

                entity.Property(e => e.GlSwExps).HasColumnName("GL_SW_EXPS");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdPayment).HasColumnName("ID_PAYMENT");

                entity.Property(e => e.IdRegPayment).HasColumnName("ID_REG_PAYMENT");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InOverride)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_OVERRIDE")
                    .IsFixedLength();

                entity.Property(e => e.InPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_PAID")
                    .IsFixedLength();

                entity.Property(e => e.InSentToSsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_SENT_TO_SSB")
                    .IsFixedLength();

                entity.Property(e => e.MnyEmpeeSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SL");

                entity.Property(e => e.MnyEmpeeSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SS");

                entity.Property(e => e.MnyEmperSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL");

                entity.Property(e => e.MnyEmperSlSev)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL_SEV");

                entity.Property(e => e.MnyEmperSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS");

                entity.Property(e => e.MnyEmperSsInj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS_INJ");

                entity.Property(e => e.MnyGrossPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_GROSS_PAY");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.MnyOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_OVRTIME");

                entity.Property(e => e.MnyRegPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_REG_PAY");

                entity.Property(e => e.MnyTotAdj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_TOT_ADJ");

                entity.Property(e => e.MnyYtdGross)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_GROSS");

                entity.Property(e => e.MnyYtdSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SL");

                entity.Property(e => e.MnyYtdSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SS");

                entity.Property(e => e.TxComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_COMMENT");
            });

            modelBuilder.Entity<PaymentsUpToDec2011>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payments_Up_To_Dec2011");

                entity.Property(e => e.DtBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_BEGIN");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END");

                entity.Property(e => e.DtLastModified)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_LAST_MODIFIED");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.GlOvertime).HasColumnName("GL_OVERTIME");

                entity.Property(e => e.GlRegularPay).HasColumnName("GL_REGULAR_PAY");

                entity.Property(e => e.GlSlEmpee).HasColumnName("GL_SL_EMPEE");

                entity.Property(e => e.GlSlExps).HasColumnName("GL_SL_EXPS");

                entity.Property(e => e.GlSlLiable).HasColumnName("GL_SL_LIABLE");

                entity.Property(e => e.GlSsEmpee).HasColumnName("GL_SS_EMPEE");

                entity.Property(e => e.GlSsExps).HasColumnName("GL_SS_EXPS");

                entity.Property(e => e.GlSsLiable).HasColumnName("GL_SS_LIABLE");

                entity.Property(e => e.GlSwExps).HasColumnName("GL_SW_EXPS");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdPayment).HasColumnName("ID_PAYMENT");

                entity.Property(e => e.IdRegPayment).HasColumnName("ID_REG_PAYMENT");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InOverride)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_OVERRIDE")
                    .IsFixedLength();

                entity.Property(e => e.InPaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_PAID")
                    .IsFixedLength();

                entity.Property(e => e.InSentToSsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_SENT_TO_SSB")
                    .IsFixedLength();

                entity.Property(e => e.MnyEmpeeSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SL");

                entity.Property(e => e.MnyEmpeeSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPEE_SS");

                entity.Property(e => e.MnyEmperSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL");

                entity.Property(e => e.MnyEmperSlSev)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SL_SEV");

                entity.Property(e => e.MnyEmperSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS");

                entity.Property(e => e.MnyEmperSsInj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_EMPER_SS_INJ");

                entity.Property(e => e.MnyGrossPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_GROSS_PAY");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.MnyOvrtime)
                    .HasColumnType("money")
                    .HasColumnName("MNY_OVRTIME");

                entity.Property(e => e.MnyRegPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_REG_PAY");

                entity.Property(e => e.MnyTotAdj)
                    .HasColumnType("money")
                    .HasColumnName("MNY_TOT_ADJ");

                entity.Property(e => e.MnyYtdGross)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_GROSS");

                entity.Property(e => e.MnyYtdSl)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SL");

                entity.Property(e => e.MnyYtdSs)
                    .HasColumnType("money")
                    .HasColumnName("MNY_YTD_SS");

                entity.Property(e => e.TxComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_COMMENT");
            });

            modelBuilder.Entity<PayrollCustomReport>(entity =>
            {
                entity.HasKey(e => e.ReportSp);

                entity.Property(e => e.ReportSp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ReportSP");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasKey(e => e.IdProfile);

                entity.HasIndex(e => new { e.InDelFlg, e.IdProfile, e.IdSocialSec, e.NmFirst, e.NmLast, e.InGender, e.TxSalutation, e.DtDob, e.NmSpouse, e.PhPrimaryNo, e.TxEmail }, "Profiles8");

                entity.Property(e => e.IdProfile).HasColumnName("ID_PROFILE");

                entity.Property(e => e.DtDob)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_DOB");

                entity.Property(e => e.IdAddress).HasColumnName("ID_ADDRESS");

                entity.Property(e => e.IdCif).HasColumnName("ID_CIF");

                entity.Property(e => e.IdCompany).HasColumnName("ID_COMPANY");

                entity.Property(e => e.IdSocialSec).HasColumnName("ID_SOCIAL_SEC");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InGender)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IN_GENDER");

                entity.Property(e => e.InMaritalStatus)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IN_MARITAL_STATUS")
                    .IsFixedLength();

                entity.Property(e => e.NmFirst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_FIRST");

                entity.Property(e => e.NmFull)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_FULL");

                entity.Property(e => e.NmLast)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_LAST");

                entity.Property(e => e.NmSpouse)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_SPOUSE");

                entity.Property(e => e.PhPrimaryNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PH_PRIMARY_NO");

                entity.Property(e => e.TxEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_EMAIL");

                entity.Property(e => e.TxSalutation)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TX_SALUTATION")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Rate>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.CurrencyType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EcRate)
                    .HasColumnType("money")
                    .HasColumnName("EC_Rate");

                entity.Property(e => e.TheUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("theUser");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_End");

                entity.Property(e => e.DtInformed)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Informed");

                entity.Property(e => e.DtStart)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Start");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.InAppvd).HasColumnName("IN_Appvd");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InNtappvd).HasColumnName("IN_NTAppvd");

                entity.Property(e => e.InTdAm).HasColumnName("IN_TD_AM");

                entity.Property(e => e.InTdPm).HasColumnName("IN_TD_PM");

                entity.Property(e => e.InTobeAppvd).HasColumnName("IN_TobeAppvd");

                entity.Property(e => e.NmAppvdAb).HasColumnName("NM_AppvdAb");

                entity.Property(e => e.NmSpecialDays).HasColumnName("NM_SpecialDays");

                entity.Property(e => e.NmUnAppvdAb).HasColumnName("NM_UnAppvdAb");

                entity.Property(e => e.TmInformed)
                    .HasColumnType("datetime")
                    .HasColumnName("TM_Informed");

                entity.Property(e => e.TxGmrec)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_GMRec");

                entity.Property(e => e.TxInformedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_InformedBy");

                entity.Property(e => e.TxMemo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_Memo");

                entity.Property(e => e.TxReasons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_Reasons");
            });

            modelBuilder.Entity<Savdrm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SAVDRM$");

                entity.Property(e => e.AccountNumber).HasColumnName("Account Number");

                entity.Property(e => e.AccrInt1stMonth).HasColumnName("ACCR Int 1st Month");

                entity.Property(e => e.AccrInt2ndMonth).HasColumnName("ACCR Int 2nd Month");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .HasColumnName("Address 1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .HasColumnName("Address 2");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.DateIntrestLastPaid)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Date Intrest Last Paid");

                entity.Property(e => e.DateOpened)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Date Opened");

                entity.Property(e => e.DateReActivated)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Date ReActivated");

                entity.Property(e => e.DormantDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Dormant Date");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("First Name");

                entity.Property(e => e.InactiveDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Inactive Date");

                entity.Property(e => e.InterestAccrued).HasColumnName("Interest Accrued");

                entity.Property(e => e.InterestLastPaid).HasColumnName("Interest Last Paid");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("Last Name");

                entity.Property(e => e.ReactivateOp)
                    .HasMaxLength(50)
                    .HasColumnName("Reactivate Op");

                entity.Property(e => e.State).HasMaxLength(255);
            });

            modelBuilder.Entity<Ssb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SSB");

                entity.Property(e => e.Ctdate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CTDate");

                entity.Property(e => e.Cycle)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Eesl)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("EESL");

                entity.Property(e => e.Eess)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("EESS");

                entity.Property(e => e.Ersl)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("ERSL");

                entity.Property(e => e.Ersldt)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("ERSLDT");

                entity.Property(e => e.Erslv)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("ERSLV");

                entity.Property(e => e.Erss)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("ERSS");

                entity.Property(e => e.Erssj)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("ERSSJ");

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn).HasColumnName("SSN");

                entity.Property(e => e.Sw1)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SW1");

                entity.Property(e => e.Sw2)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SW2");

                entity.Property(e => e.Sw3)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SW3");

                entity.Property(e => e.Sw4)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SW4");

                entity.Property(e => e.Sw5)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SW5");

                entity.Property(e => e.Swt)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SWT");

                entity.Property(e => e.X1)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.X2)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.X3)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.X4)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.X5)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ssb3d>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SSB3D");

                entity.Property(e => e.Eesl)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("EESL");

                entity.Property(e => e.Ersl)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("ERSL");

                entity.Property(e => e.Erslv)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("ERSLV");

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn).HasColumnName("SSN");

                entity.Property(e => e.Sw1)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SW1");

                entity.Property(e => e.Sw2)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SW2");

                entity.Property(e => e.Sw3)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SW3");

                entity.Property(e => e.Sw4)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SW4");

                entity.Property(e => e.Sw5)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SW5");

                entity.Property(e => e.Swt)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SWT");
            });

            modelBuilder.Entity<StaffEnt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StaffEnt");

                entity.Property(e => e.DtHired)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_HIRED");

                entity.Property(e => e.IdGrade).HasColumnName("ID_GRADE");

                entity.Property(e => e.IdSocialSec).HasColumnName("ID_Social_Sec");

                entity.Property(e => e.NmFull)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("NM_Full");
            });

            modelBuilder.Entity<StaffLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Staff_Login");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.PassWord)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResetPw).HasColumnName("ResetPW");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StaffPerformanceHistory>(entity =>
            {
                entity.HasKey(e => e.IdPerformance);

                entity.ToTable("StaffPerformanceHistory");

                entity.Property(e => e.IdPerformance).HasColumnName("ID_Performance");

                entity.Property(e => e.AssessmentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Assessment_Date");

                entity.Property(e => e.AssessmentQuarter).HasColumnName("Assessment_Quarter");

                entity.Property(e => e.AssessmentYear).HasColumnName("Assessment_Year");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.JobFactorsScore)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Job_Factors_Score");

                entity.Property(e => e.OverallRating)
                    .HasMaxLength(10)
                    .HasColumnName("Overall_Rating")
                    .IsFixedLength();

                entity.Property(e => e.OverallScore)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Overall_Score");

                entity.Property(e => e.PerformanceFactorsScore)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Performance_Factors_Score");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.StaffPerformanceHistories)
                    .HasForeignKey(d => d.IdEmployee)
                    .HasConstraintName("FK_StaffPerformanceHistory_Employees");
            });

            modelBuilder.Entity<StaffTimeLog>(entity =>
            {
                entity.HasKey(e => e.LogKey);

                entity.ToTable("StaffTimeLog");

                entity.Property(e => e.LogKey).HasColumnName("logKey");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogInTime)
                    .HasColumnType("datetime")
                    .HasColumnName("logInTime");

                entity.Property(e => e.LogOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("logOutTime");

                entity.Property(e => e.LoginDate)
                    .HasColumnType("datetime")
                    .HasColumnName("loginDate");

                entity.Property(e => e.MachineName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("machineName");

                entity.Property(e => e.ServerTime)
                    .HasColumnType("smalldatetime")
                    .HasComment("time of data entry");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<StaffVacation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("staff_Vacation");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_End");

                entity.Property(e => e.DtStart)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Start");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.InAppvd).HasColumnName("IN_Appvd");

                entity.Property(e => e.InNtappvd).HasColumnName("IN_NTAppvd");

                entity.Property(e => e.InTobeAppvd).HasColumnName("IN_TobeAppvd");

                entity.Property(e => e.KeyId).HasColumnName("KeyID");

                entity.Property(e => e.NmAnnualEnt).HasColumnName("NM_AnnualEnt");
            });

            modelBuilder.Entity<SubType>(entity =>
            {
                entity.HasKey(e => new { e.IdMstrTyp, e.IdSubTyp });

                entity.Property(e => e.IdMstrTyp).HasColumnName("ID_MSTR_TYP");

                entity.Property(e => e.IdSubTyp).HasColumnName("ID_SUB_TYP");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG")
                    .IsFixedLength();

                entity.Property(e => e.InNonTax)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IN_NON_TAX");

                entity.Property(e => e.NmSubTyp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_SUB_TYP");

                entity.Property(e => e.TxDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TX_DESC");

                entity.HasOne(d => d.IdMstrTypNavigation)
                    .WithMany(p => p.SubTypes)
                    .HasForeignKey(d => d.IdMstrTyp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubTypes_MstrTypes");
            });

            modelBuilder.Entity<SupportFilterMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SupportFilterMap");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.FilterId).HasColumnName("FilterID");

                entity.Property(e => e.Permission)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<SwiftMessage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BeneficiaryBank)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiaryCustomer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateEntryPassed).HasColumnType("datetime");

                entity.Property(e => e.Direction)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MessageType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderingCustomer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Particulars)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TPlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T&PLog");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_Address");

                entity.Property(e => e.LoginDate).HasColumnType("datetime");

                entity.Property(e => e.LoginStatus).HasColumnName("Login_Status");

                entity.Property(e => e.MachineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPlogin>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.ToTable("T&PLogin");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccessLevel)
                    .HasDefaultValueSql("(3)")
                    .HasComment("There are three levels, 1 (Admin), 2(User), 3(Viewer)");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestLogin>(entity =>
            {
                entity.ToTable("TestLogin");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UsersName)
                    .HasMaxLength(10)
                    .HasColumnName("Users_Name")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TestView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("testView");

                entity.Property(e => e.AcPay).HasColumnName("AC_PAY");

                entity.Property(e => e.DtDob)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_DOB");

                entity.Property(e => e.DtHired)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_HIRED");

                entity.Property(e => e.IdGrade).HasColumnName("ID_GRADE");

                entity.Property(e => e.InInactive)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IN_INACTIVE");

                entity.Property(e => e.MnyPayMonth)
                    .HasColumnType("money")
                    .HasColumnName("MNY_PAY_MONTH");

                entity.Property(e => e.MnyPayReg)
                    .HasColumnType("money")
                    .HasColumnName("MNY_PAY_REG");

                entity.Property(e => e.NmFirst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_FIRST");

                entity.Property(e => e.NmLast)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_LAST");
            });

            modelBuilder.Entity<TestVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("testVw");

                entity.Property(e => e.DepName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtHired)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_HIRED");

                entity.Property(e => e.IdSocialSec).HasColumnName("ID_SOCIAL_SEC");

                entity.Property(e => e.NmFirst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_FIRST");

                entity.Property(e => e.NmLast)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_LAST");
            });

            modelBuilder.Entity<TransitItem>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Balance)
                    .HasColumnType("money")
                    .HasComputedColumnSql("([Debit_EC_Equivalent] - [Credit_EC_Equivalent])", false);

                entity.Property(e => e.Bank)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CreditEcEquivalent)
                    .HasColumnType("money")
                    .HasColumnName("Credit_EC_Equivalent");

                entity.Property(e => e.CreditForeignAmount)
                    .HasColumnType("money")
                    .HasColumnName("Credit_ForeignAmount");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCleared).HasColumnType("datetime");

                entity.Property(e => e.DebitEcEquivalent)
                    .HasColumnType("money")
                    .HasColumnName("Debit_EC_Equivalent");

                entity.Property(e => e.DebitForeignAmount)
                    .HasColumnType("money")
                    .HasColumnName("Debit_ForeignAmount");

                entity.Property(e => e.DeleteFlg).HasDefaultValueSql("(0)");

                entity.Property(e => e.Payee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("recID");

                entity.Property(e => e.TheMachine)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("theMachine");

                entity.Property(e => e.TheUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("theUser");
            });

            modelBuilder.Entity<TravellersCheque>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeleteFlg).HasColumnName("deleteFlg");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Purchaser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaserFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaserLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TheMachine)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("theMachine");

                entity.Property(e => e.TheUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("theUser");
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");

                entity.HasOne(d => d.UnitType)
                    .WithMany(p => p.Units)
                    .HasForeignKey(d => d.UnitTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Units_UnitTypes");
            });

            modelBuilder.Entity<UnitType>(entity =>
            {
                entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");

                entity.Property(e => e.UnitTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW1");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.InInactive)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IN_INACTIVE");

                entity.Property(e => e.NmFirst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_FIRST");

                entity.Property(e => e.NmLast)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_LAST");
            });

            modelBuilder.Entity<View2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW2");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_End");

                entity.Property(e => e.DtStart)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Start");

                entity.Property(e => e.SocialSecurity).HasColumnName("Social_Security");

                entity.Property(e => e.TotalDays).HasColumnName("Total_Days");

                entity.Property(e => e.TxReasons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_Reasons");
            });

            modelBuilder.Entity<View3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW3");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_End");

                entity.Property(e => e.DtStart)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Start");

                entity.Property(e => e.InTdAm).HasColumnName("IN_TD_AM");

                entity.Property(e => e.InTdPm).HasColumnName("IN_TD_PM");

                entity.Property(e => e.TotalDays).HasColumnName("Total_Days");

                entity.Property(e => e.TxReasons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_Reasons");
            });

            modelBuilder.Entity<View4>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW4");

                entity.Property(e => e.DtDob)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_DOB");

                entity.Property(e => e.DtEndProb)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END_PROB");

                entity.Property(e => e.IdCompany).HasColumnName("ID_COMPANY");

                entity.Property(e => e.IdSocialSec).HasColumnName("ID_SOCIAL_SEC");

                entity.Property(e => e.NmFirst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_FIRST");

                entity.Property(e => e.NmLast)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_LAST");
            });

            modelBuilder.Entity<VisaCard>(entity =>
            {
                entity.HasKey(e => e.IdCard)
                    .HasName("PK_VisaCard")
                    .IsClustered(false);

                entity.HasIndex(e => e.IdType, "VisaCards2")
                    .IsClustered();

                entity.Property(e => e.IdCard).HasColumnName("ID_CARD");

                entity.Property(e => e.AcUser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AC_USER")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DtActivated)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_ACTIVATED");

                entity.Property(e => e.DtIssued)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_ISSUED");

                entity.Property(e => e.DtReceived)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_RECEIVED");

                entity.Property(e => e.DtValidThru)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VALID_THRU");

                entity.Property(e => e.IdBin)
                    .HasColumnName("ID_BIN")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.IdCardNum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ID_CARD_NUM")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IdCardholder).HasColumnName("ID_CARDHOLDER");

                entity.Property(e => e.IdCheckDigit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ID_CheckDigit")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.IdCif).HasColumnName("ID_CIF");

                entity.Property(e => e.IdMemberNum)
                    .HasColumnName("ID_MemberNum")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.IdPrimCard).HasColumnName("ID_PRIM_CARD");

                entity.Property(e => e.IdType)
                    .HasColumnName("ID_Type")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.InActive).HasColumnName("IN_ACTIVE");

                entity.Property(e => e.InDelFlg)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IN_DEL_FLG");

                entity.Property(e => e.InPayMthd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IN_PAY_MTHD")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.MnyCreditline)
                    .HasColumnType("money")
                    .HasColumnName("MNY_CREDITLINE");

                entity.Property(e => e.MnyWdLimit)
                    .HasColumnType("money")
                    .HasColumnName("MNY_WD_LIMIT")
                    .HasDefaultValueSql("(1500)");

                entity.Property(e => e.NmByWhom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_BY_WHOM");

                entity.Property(e => e.NmNameoncard)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_NAMEONCARD");

                entity.Property(e => e.TxC)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TX_C");

                entity.Property(e => e.TxCvv)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TX_CVV");

                entity.Property(e => e.TxIfLost)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TX_IF_LOST");

                entity.Property(e => e.TxTelecodeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_TELECODE_NO");

                entity.HasOne(d => d.IdCardholderNavigation)
                    .WithMany(p => p.VisaCards)
                    .HasForeignKey(d => d.IdCardholder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisaCards_Profiles");
            });

            modelBuilder.Entity<VwActAb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwActAb");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_End");

                entity.Property(e => e.DtInformed)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Informed");

                entity.Property(e => e.DtMod)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_mod");

                entity.Property(e => e.DtStart)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Start");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.InTdAm).HasColumnName("IN_TD_AM");

                entity.Property(e => e.InTdPm).HasColumnName("IN_TD_PM");

                entity.Property(e => e.NmSpecialDays).HasColumnName("NM_SpecialDays");

                entity.Property(e => e.TmInformed)
                    .HasColumnType("datetime")
                    .HasColumnName("TM_Informed");

                entity.Property(e => e.TxInformedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_InformedBy");

                entity.Property(e => e.TxReasons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_Reasons");
            });

            modelBuilder.Entity<VwAllEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAllEmps");

                entity.Property(e => e.IdCompany).HasColumnName("ID_COMPANY");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.InInactive)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IN_INACTIVE");

                entity.Property(e => e.NmFull)
                    .HasMaxLength(101)
                    .IsUnicode(false)
                    .HasColumnName("NM_FULL");

                entity.Property(e => e.TxJobTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_JOB_TITLE");
            });

            modelBuilder.Entity<VwAttLegend>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_attLegend");

                entity.Property(e => e.NmSubTyp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_SUB_TYP");

                entity.Property(e => e.TxDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TX_DESC");
            });

            modelBuilder.Entity<VwBank>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwBanks");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BankID");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalBank).HasColumnName("Local_Bank");

                entity.Property(e => e.Name)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwBranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwBranches");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCompanies");

                entity.Property(e => e.TypeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TypeID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwDepartments");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwDivision>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwDivisions");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwEmpDetDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpDetDates");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DateOfJoin).HasColumnType("datetime");

                entity.Property(e => e.DateOfLeaving).HasColumnType("datetime");

                entity.Property(e => e.EndOfContract)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EndOfProbation).HasColumnType("datetime");

                entity.Property(e => e.PensionSchemeJoin).HasColumnType("datetime");

                entity.Property(e => e.StaffNo)
                    .HasMaxLength(7)
                    .HasColumnName("Staff_No")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwEmpDetailsContract>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpDetails_Contract");

                entity.Property(e => e.Assistant)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullPartTime)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NoticePeriod)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Satus)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StaffNo)
                    .HasMaxLength(7)
                    .HasColumnName("Staff_No")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwEmpDetailsPaydatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpDetails_Paydata");

                entity.Property(e => e.ContractualHours)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.OverTime).HasColumnType("money");

                entity.Property(e => e.Pay).HasColumnType("money");

                entity.Property(e => e.PayBasis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayPeriod).HasColumnType("datetime");

                entity.Property(e => e.StaffNo)
                    .HasMaxLength(7)
                    .HasColumnName("Staff_No")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwEmpDetailsPersonal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpDetailsPersonal");

                entity.Property(e => e.DrivingLicence)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ethnicity)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.HomeTel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mobile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Mobile #");

                entity.Property(e => e.StaffNo)
                    .HasMaxLength(7)
                    .HasColumnName("Staff_No")
                    .IsFixedLength();

                entity.Property(e => e.VehicleNumber)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WorkNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwEmpDetailsTrainingHist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmpDetailsTrainingHist");

                entity.Property(e => e.Assesment)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cost)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Course)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Identifier)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Passed)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Provider)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StaffNo)
                    .HasMaxLength(7)
                    .HasColumnName("Staff_No")
                    .IsFixedLength();

                entity.Property(e => e.Subject)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmployees");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdBranch).HasColumnName("ID_BRANCH");

                entity.Property(e => e.IdCompany).HasColumnName("ID_COMPANY");

                entity.Property(e => e.IdDept).HasColumnName("ID_DEPT");

                entity.Property(e => e.IdDivision).HasColumnName("ID_DIVISION");

                entity.Property(e => e.IdEmpMngr).HasColumnName("ID_EMP_MNGR");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdGrade).HasColumnName("ID_GRADE");

                entity.Property(e => e.IdSocialSec).HasColumnName("ID_SOCIAL_SEC");

                entity.Property(e => e.NmFirst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_FIRST");

                entity.Property(e => e.NmLast)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_LAST");

                entity.Property(e => e.TxJobTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TX_JOB_TITLE");
            });

            modelBuilder.Entity<VwEmployeeDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEmployeeDetails");

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address5)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KnownAs)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StaffNo)
                    .HasMaxLength(7)
                    .HasColumnName("Staff_No")
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwGetEmpInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwGetEmpInfo");

                entity.Property(e => e.DtEndProb)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END_PROB");

                entity.Property(e => e.DtHired)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_HIRED");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdSocialSec).HasColumnName("ID_SOCIAL_SEC");

                entity.Property(e => e.InInactive)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IN_INACTIVE");

                entity.Property(e => e.InIsStaff)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_IS_STAFF")
                    .IsFixedLength();

                entity.Property(e => e.NmCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_COMPANY");

                entity.Property(e => e.NmFirst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_FIRST");

                entity.Property(e => e.NmLast)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_LAST");
            });

            modelBuilder.Entity<VwGetEmpsSocial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwGetEmpsSocial");

                entity.Property(e => e.IdSocialSec).HasColumnName("ID_SOCIAL_SEC");
            });

            modelBuilder.Entity<VwHorizon55>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwHorizon55");

                entity.Property(e => e.Account1)
                    .HasMaxLength(50)
                    .HasColumnName("Account #1");

                entity.Property(e => e.Account2)
                    .HasMaxLength(50)
                    .HasColumnName("Account # 2");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(50)
                    .HasColumnName("Account Type");

                entity.Property(e => e.CardIssued).HasColumnName("Card Issued");

                entity.Property(e => e.DateLoaded)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Date Loaded");

                entity.Property(e => e.IdCard)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_CARD");

                entity.Property(e => e.IdProfile).HasColumnName("ID_PROFILE");

                entity.Property(e => e.MemberName).HasMaxLength(50);
            });

            modelBuilder.Entity<VwLegend>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLegend");

                entity.Property(e => e.NmSubTyp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_SUB_TYP");

                entity.Property(e => e.TxDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TX_DESC");
            });

            modelBuilder.Entity<VwLocalBank>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLocalBanks");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwNationalCall>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwNationalCalls");

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CallerName)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.CallerNum)
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("First Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Last Name");

                entity.Property(e => e.RingDurationS).HasColumnName("Ring Duration(s)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TalkDurationMin).HasColumnName("Talk Duration(min)");

                entity.Property(e => e.TargetName)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.TargetNum)
                    .HasMaxLength(41)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwPayType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPayTypes");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.DtBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_BEGIN");

                entity.Property(e => e.DtEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_END");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("First Name");

                entity.Property(e => e.IdSocialSec).HasColumnName("ID_SOCIAL_SEC");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Last Name");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwPayslip>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPayslips");

                entity.Property(e => e.ActualPay).HasColumnType("money");

                entity.Property(e => e.Adjustments).HasColumnType("money");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FullName)
                    .HasMaxLength(103)
                    .IsUnicode(false);

                entity.Property(e => e.GrossPay).HasColumnType("money");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IsOverride)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.OvertimeGl).HasColumnName("OvertimeGL");

                entity.Property(e => e.OvertimePay).HasColumnType("money");

                entity.Property(e => e.Paid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PayBegin).HasColumnType("datetime");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PayEnd).HasColumnType("datetime");

                entity.Property(e => e.PayTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.RegularExpsGl).HasColumnName("RegularExpsGL");

                entity.Property(e => e.RegularGl).HasColumnName("RegularGL");

                entity.Property(e => e.RegularPay).HasColumnType("money");

                entity.Property(e => e.SentToSsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SentToSSB")
                    .IsFixedLength();

                entity.Property(e => e.Slemployee)
                    .HasColumnType("money")
                    .HasColumnName("SLEmployee");

                entity.Property(e => e.SlemployeeGl).HasColumnName("SLEmployeeGL");

                entity.Property(e => e.Slemployer)
                    .HasColumnType("money")
                    .HasColumnName("SLEmployer");

                entity.Property(e => e.SlemployerExpsGl).HasColumnName("SLEmployerExpsGL");

                entity.Property(e => e.SlemployerGl).HasColumnName("SLEmployerGL");

                entity.Property(e => e.SlemployerSev)
                    .HasColumnType("money")
                    .HasColumnName("SLEmployerSev");

                entity.Property(e => e.Ssemployee)
                    .HasColumnType("money")
                    .HasColumnName("SSEmployee");

                entity.Property(e => e.SsemployeeGl).HasColumnName("SSEmployeeGL");

                entity.Property(e => e.Ssemployer)
                    .HasColumnType("money")
                    .HasColumnName("SSEmployer");

                entity.Property(e => e.SsemployerExpsGl).HasColumnName("SSEmployerExpsGL");

                entity.Property(e => e.SsemployerGl).HasColumnName("SSEmployerGL");

                entity.Property(e => e.SsemployerInj)
                    .HasColumnType("money")
                    .HasColumnName("SSEmployerInj");

                entity.Property(e => e.Ssn).HasColumnName("SSN");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.YtdgrossPay)
                    .HasColumnType("money")
                    .HasColumnName("YTDGrossPay");

                entity.Property(e => e.Ytdslemployee)
                    .HasColumnType("money")
                    .HasColumnName("YTDSLEmployee");

                entity.Property(e => e.Ytdssemployee)
                    .HasColumnType("money")
                    .HasColumnName("YTDSSEmployee");
            });

            modelBuilder.Entity<VwPayslipsAdj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPayslipsAdj");

                entity.Property(e => e.AdjPmtId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AdjPmtID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnType("money");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.SourceGl).HasColumnName("SourceGL");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<VwReason>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwReason");

                entity.Property(e => e.NmSubTyp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_SUB_TYP");
            });

            modelBuilder.Entity<VwSsb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSSB");

                entity.Property(e => e.Ctdate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CTDate");

                entity.Property(e => e.Cycle)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Eesl)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("EESL");

                entity.Property(e => e.Eess)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("EESS");

                entity.Property(e => e.Ersl)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("ERSL");

                entity.Property(e => e.Ersldt)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("ERSLDT");

                entity.Property(e => e.Erslv)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("ERSLV");

                entity.Property(e => e.Erss)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("ERSS");

                entity.Property(e => e.Erssj)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("ERSSJ");

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn).HasColumnName("SSN");

                entity.Property(e => e.Sw1)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SW1");

                entity.Property(e => e.Sw2)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SW2");

                entity.Property(e => e.Sw3)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SW3");

                entity.Property(e => e.Sw4)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SW4");

                entity.Property(e => e.Sw5)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SW5");

                entity.Property(e => e.Swt)
                    .HasColumnType("decimal(28, 2)")
                    .HasColumnName("SWT");

                entity.Property(e => e.X1)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.X2)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.X3)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.X4)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.X5)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwTempPay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTempPay");

                entity.Property(e => e.AcPay)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("AC_PAY");

                entity.Property(e => e.DtPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_PAID");

                entity.Property(e => e.IdAcctType).HasColumnName("ID_ACCT_TYPE");

                entity.Property(e => e.IdCompany).HasColumnName("ID_COMPANY");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdHistory).HasColumnName("ID_HISTORY");

                entity.Property(e => e.IdPayment).HasColumnName("ID_PAYMENT");

                entity.Property(e => e.IdSocialSec).HasColumnName("ID_SOCIAL_SEC");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.MnyNetPay)
                    .HasColumnType("money")
                    .HasColumnName("MNY_NET_PAY");

                entity.Property(e => e.TxComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TX_COMMENT");
            });

            modelBuilder.Entity<VwTotalAbsent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTotalAbsent");

                entity.Property(e => e.Df).HasColumnName("DF");

                entity.Property(e => e.Ex).HasColumnName("EX");

                entity.Property(e => e.Ml).HasColumnName("ML");

                entity.Property(e => e.Ns).HasColumnName("NS");

                entity.Property(e => e.Sf).HasColumnName("SF");

                entity.Property(e => e.Sw).HasColumnName("SW");
            });

            modelBuilder.Entity<VwUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwUsers");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_Address");

                entity.Property(e => e.LoginDate).HasColumnType("datetime");

                entity.Property(e => e.LoginStatus).HasColumnName("Login_Status");

                entity.Property(e => e.MachineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwempInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwempInfo");

                entity.Property(e => e.DtHired)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_HIRED");

                entity.Property(e => e.IdSocialSec).HasColumnName("ID_SOCIAL_SEC");

                entity.Property(e => e.InInactive)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IN_INACTIVE");

                entity.Property(e => e.InIsStaff)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_IS_STAFF")
                    .IsFixedLength();

                entity.Property(e => e.NmFirst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_FIRST");

                entity.Property(e => e.NmLast)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NM_LAST");

                entity.Property(e => e.TheYear).HasColumnName("theYear");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
