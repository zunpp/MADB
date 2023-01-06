using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data.Models
{
    public partial class MADBSolutionContext : DbContext
    {
        public MADBSolutionContext()
        {
        }

        public MADBSolutionContext(DbContextOptions<MADBSolutionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAccountDetail> TbAccountDetail { get; set; }
        public virtual DbSet<TbAccountDetailTransaction> TbAccountDetailTransaction { get; set; }
        public virtual DbSet<TbAccountSummary> TbAccountSummary { get; set; }
        public virtual DbSet<TbDateSettingForRsdinterest> TbDateSettingForRsdinterest { get; set; }
        public virtual DbSet<TbFine> TbFine { get; set; }
        public virtual DbSet<TbForm7> TbForm7 { get; set; }
        public virtual DbSet<TbInterest> TbInterest { get; set; }
        public virtual DbSet<TbItemAndLoanPrice> TbItemAndLoanPrice { get; set; }
        public virtual DbSet<TbJicaloanMaster> TbJicaloanMaster { get; set; }
        public virtual DbSet<TbJicaloanReturnTransactionDetail> TbJicaloanReturnTransactionDetail { get; set; }
        public virtual DbSet<TbJoinAccount> TbJoinAccount { get; set; }
        public virtual DbSet<TbLoanGroup> TbLoanGroup { get; set; }
        public virtual DbSet<TbLoanInterestRate> TbLoanInterestRate { get; set; }
        public virtual DbSet<TbLoanMaster> TbLoanMaster { get; set; }
        public virtual DbSet<TbLoanProposal> TbLoanProposal { get; set; }
        public virtual DbSet<TbLoanReturnTransactionDetail> TbLoanReturnTransactionDetail { get; set; }
        public virtual DbSet<TbLoanTransaction> TbLoanTransaction { get; set; }
        public virtual DbSet<TbMachine> TbMachine { get; set; }
        public virtual DbSet<TbMeb2sloanMaster> TbMeb2sloanMaster { get; set; }
        public virtual DbSet<TbMeb2sloanReturnTransactionDetail> TbMeb2sloanReturnTransactionDetail { get; set; }
        public virtual DbSet<TbMeb2spersonalInformation> TbMeb2spersonalInformation { get; set; }
        public virtual DbSet<TbMessageBox> TbMessageBox { get; set; }
        public virtual DbSet<TbMessageContent> TbMessageContent { get; set; }
        public virtual DbSet<TbMoeInterestTransaction> TbMoeInterestTransaction { get; set; }
        public virtual DbSet<TbMoeKyoInterestTransaction> TbMoeKyoInterestTransaction { get; set; }
        public virtual DbSet<TbPersonalInformation> TbPersonalInformation { get; set; }
        public virtual DbSet<TbRegion> TbRegion { get; set; }
        public virtual DbSet<TbSaungInterestTransaction> TbSaungInterestTransaction { get; set; }
        public virtual DbSet<TbSavingMaster> TbSavingMaster { get; set; }
        public virtual DbSet<TbStaff> TbStaff { get; set; }
        public virtual DbSet<TbStateDivision> TbStateDivision { get; set; }
        public virtual DbSet<TbStatedivi> TbStatedivi { get; set; }
        public virtual DbSet<TbTownship> TbTownship { get; set; }
        public virtual DbSet<TbTransaction> TbTransaction { get; set; }
        public virtual DbSet<TbUser> TbUser { get; set; }
        public virtual DbSet<TbUserLogin> TbUserLogin { get; set; }
        public virtual DbSet<TbVillage> TbVillage { get; set; }
        public virtual DbSet<VwAccountDetailTransaction> VwAccountDetailTransaction { get; set; }
        public virtual DbSet<VwAccountDetailTransactionForBalancingChecking> VwAccountDetailTransactionForBalancingChecking { get; set; }
        public virtual DbSet<VwAccountDetailTransactionOnlineCheck> VwAccountDetailTransactionOnlineCheck { get; set; }
        public virtual DbSet<VwAccountDetailTransactionPassBookSelectByAccNo> VwAccountDetailTransactionPassBookSelectByAccNo { get; set; }
        public virtual DbSet<VwAccountSummaryOnlineCheck> VwAccountSummaryOnlineCheck { get; set; }
        public virtual DbSet<VwCustomerAccountDetail> VwCustomerAccountDetail { get; set; }
        public virtual DbSet<VwCustomerForm7Detail> VwCustomerForm7Detail { get; set; }
        public virtual DbSet<VwDateSettingForRsdinterest> VwDateSettingForRsdinterest { get; set; }
        public virtual DbSet<VwDebtPeopleTransactionDetail> VwDebtPeopleTransactionDetail { get; set; }
        public virtual DbSet<VwFine> VwFine { get; set; }
        public virtual DbSet<VwForm7OnlineCheck> VwForm7OnlineCheck { get; set; }
        public virtual DbSet<VwGetRegionSelectList> VwGetRegionSelectList { get; set; }
        public virtual DbSet<VwInterest> VwInterest { get; set; }
        public virtual DbSet<VwJicacustomerAccountDetail> VwJicacustomerAccountDetail { get; set; }
        public virtual DbSet<VwJicadebtPeopleTransactionDetail> VwJicadebtPeopleTransactionDetail { get; set; }
        public virtual DbSet<VwJicaloanMaster> VwJicaloanMaster { get; set; }
        public virtual DbSet<VwJicaloanMasterForBalancingChecking> VwJicaloanMasterForBalancingChecking { get; set; }
        public virtual DbSet<VwJicaloanMasterOnlineCheck> VwJicaloanMasterOnlineCheck { get; set; }
        public virtual DbSet<VwJicaloanMasterPassBookSelectByAccNo> VwJicaloanMasterPassBookSelectByAccNo { get; set; }
        public virtual DbSet<VwJicaloanReturnTransPeopleGroupByRegion> VwJicaloanReturnTransPeopleGroupByRegion { get; set; }
        public virtual DbSet<VwJicaloanReturnTransactionDetail> VwJicaloanReturnTransactionDetail { get; set; }
        public virtual DbSet<VwJicaloanReturnTransactionDetailOnlineCheck> VwJicaloanReturnTransactionDetailOnlineCheck { get; set; }
        public virtual DbSet<VwJicaloanReturnTransactionDetailPassBookSelectByAccNo> VwJicaloanReturnTransactionDetailPassBookSelectByAccNo { get; set; }
        public virtual DbSet<VwJicaloanReturnTransactionGroupByRegion> VwJicaloanReturnTransactionGroupByRegion { get; set; }
        public virtual DbSet<VwJicans7> VwJicans7 { get; set; }
        public virtual DbSet<VwLoanInterestDetailTransaction> VwLoanInterestDetailTransaction { get; set; }
        public virtual DbSet<VwLoanMaster> VwLoanMaster { get; set; }
        public virtual DbSet<VwLoanMasterOnlineCheck> VwLoanMasterOnlineCheck { get; set; }
        public virtual DbSet<VwLoanMasterPassBookSelectByAccNo> VwLoanMasterPassBookSelectByAccNo { get; set; }
        public virtual DbSet<VwLoanProposal> VwLoanProposal { get; set; }
        public virtual DbSet<VwLoanReturnDateList> VwLoanReturnDateList { get; set; }
        public virtual DbSet<VwLoanReturnTransPeopleGroupByRegion> VwLoanReturnTransPeopleGroupByRegion { get; set; }
        public virtual DbSet<VwLoanReturnTransactionDetail> VwLoanReturnTransactionDetail { get; set; }
        public virtual DbSet<VwLoanReturnTransactionDetailOnlineCheck> VwLoanReturnTransactionDetailOnlineCheck { get; set; }
        public virtual DbSet<VwLoanReturnTransactionDetailPassBookSelectByAccNo> VwLoanReturnTransactionDetailPassBookSelectByAccNo { get; set; }
        public virtual DbSet<VwLoanReturnTransactionGroupByRegion> VwLoanReturnTransactionGroupByRegion { get; set; }
        public virtual DbSet<VwMachine> VwMachine { get; set; }
        public virtual DbSet<VwMeb2sloanMaster> VwMeb2sloanMaster { get; set; }
        public virtual DbSet<VwMeb2sloanMasterForBalancingChecking> VwMeb2sloanMasterForBalancingChecking { get; set; }
        public virtual DbSet<VwMeb2sloanMasterForBalancingCheckingWithSaving> VwMeb2sloanMasterForBalancingCheckingWithSaving { get; set; }
        public virtual DbSet<VwMeb2sloanMasterOnlineCheck> VwMeb2sloanMasterOnlineCheck { get; set; }
        public virtual DbSet<VwMeb2sloanMasterPassBookSelectByAccNo> VwMeb2sloanMasterPassBookSelectByAccNo { get; set; }
        public virtual DbSet<VwMeb2sloanMasterWithSaving> VwMeb2sloanMasterWithSaving { get; set; }
        public virtual DbSet<VwMeb2sloanReturnTransactionDetail> VwMeb2sloanReturnTransactionDetail { get; set; }
        public virtual DbSet<VwMeb2sloanReturnTransactionDetailOnlineCheck> VwMeb2sloanReturnTransactionDetailOnlineCheck { get; set; }
        public virtual DbSet<VwMeb2sloanReturnTransactionDetailPassBookSelectByAccNo> VwMeb2sloanReturnTransactionDetailPassBookSelectByAccNo { get; set; }
        public virtual DbSet<VwMeb2sloanReturnTransactionDetailWithSaving> VwMeb2sloanReturnTransactionDetailWithSaving { get; set; }
        public virtual DbSet<VwMeb2smemberDetail> VwMeb2smemberDetail { get; set; }
        public virtual DbSet<VwMeb2spersonalInformationOnlineCheck> VwMeb2spersonalInformationOnlineCheck { get; set; }
        public virtual DbSet<VwMebtslns10> VwMebtslns10 { get; set; }
        public virtual DbSet<VwMebtslns10withSaving> VwMebtslns10withSaving { get; set; }
        public virtual DbSet<VwPassBookFrontSelectByAccNo> VwPassBookFrontSelectByAccNo { get; set; }
        public virtual DbSet<VwPersonalInformationOnlineCheck> VwPersonalInformationOnlineCheck { get; set; }
        public virtual DbSet<VwRegion> VwRegion { get; set; }
        public virtual DbSet<VwStateDivision> VwStateDivision { get; set; }
        public virtual DbSet<VwTownship> VwTownship { get; set; }
        public virtual DbSet<VwVillage> VwVillage { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=MKTMGR\\SQLEXPRESS;Database=MADBSolution;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAccountDetail>(entity =>
            {
                entity.HasKey(e => e.AccountDetailPkid);

                entity.ToTable("TB_AccountDetail");

                entity.Property(e => e.BasedAmount).HasMaxLength(50);

                entity.Property(e => e.ChalenNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExtraAmount).HasMaxLength(50);

                entity.Property(e => e.FineInterestInKyat).HasMaxLength(50);

                entity.Property(e => e.InterestInKyat).HasMaxLength(50);

                entity.Property(e => e.LoanSeason).HasMaxLength(50);

                entity.Property(e => e.LoanYear).HasMaxLength(50);

                entity.Property(e => e.OtherAmount).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.SavingAmount).HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalAmount).HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbAccountDetailTransaction>(entity =>
            {
                entity.HasKey(e => e.AccountDetailPkid);

                entity.ToTable("TB_AccountDetailTransaction");

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Amount).HasMaxLength(50);

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.ChalenNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.TotalBalance).HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionType).HasMaxLength(50);
            });

            modelBuilder.Entity<TbAccountSummary>(entity =>
            {
                entity.HasKey(e => e.AccountSummaryPkid);

                entity.ToTable("TB_AccountSummary");

                entity.Property(e => e.AccountStatus).HasMaxLength(50);

                entity.Property(e => e.AmountUpdatedDate).HasMaxLength(50);

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.LastBalance).HasMaxLength(50);

                entity.Property(e => e.RecordCreatedBy).HasMaxLength(50);

                entity.Property(e => e.RecordCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbDateSettingForRsdinterest>(entity =>
            {
                entity.HasKey(e => e.DateSettingPkid);

                entity.ToTable("TB_DateSettingForRSDInterest");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbFine>(entity =>
            {
                entity.HasKey(e => e.FinePkid);

                entity.ToTable("TB_Fine");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FineRate).HasMaxLength(50);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<TbForm7>(entity =>
            {
                entity.HasKey(e => e.Form7Pkid);

                entity.ToTable("TB_Form7");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.ConfirmLetterDate).HasMaxLength(50);

                entity.Property(e => e.ConfirmLetterNo).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FarmArea).HasMaxLength(50);

                entity.Property(e => e.FarmLocation).HasMaxLength(200);

                entity.Property(e => e.FarmName).HasMaxLength(200);

                entity.Property(e => e.FarmNo).HasMaxLength(50);

                entity.Property(e => e.FarmType).HasMaxLength(50);

                entity.Property(e => e.Township).HasMaxLength(50);

                entity.Property(e => e.UpaingNo)
                    .HasColumnName("UPaingNo")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbInterest>(entity =>
            {
                entity.HasKey(e => e.InterestPkid);

                entity.ToTable("TB_Interest");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.InterestRate).HasMaxLength(50);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<TbItemAndLoanPrice>(entity =>
            {
                entity.HasKey(e => e.ItemPkid);

                entity.ToTable("TB_ItemAndLoanPrice");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemDescription).HasMaxLength(500);

                entity.Property(e => e.ItemName).HasMaxLength(200);

                entity.Property(e => e.LoanPricePerAcre).HasMaxLength(50);
            });

            modelBuilder.Entity<TbJicaloanMaster>(entity =>
            {
                entity.HasKey(e => e.LoanReturnPkid);

                entity.ToTable("TB_JICALoanMaster");

                entity.Property(e => e.ActualFine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ActualInterest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ActualReturn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.ChassisNo).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomFine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomInterest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomReturn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Dealer).HasMaxLength(200);

                entity.Property(e => e.EngineNo).HasMaxLength(50);

                entity.Property(e => e.LoanAmount).HasMaxLength(50);

                entity.Property(e => e.LoanDate).HasColumnType("datetime");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.ProposalAmount).HasMaxLength(50);

                entity.Property(e => e.RemainingFine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemainingInterest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemainingReturn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbJicaloanReturnTransactionDetail>(entity =>
            {
                entity.HasKey(e => e.LoanReturnTransactionDetailPkid);

                entity.ToTable("TB_JICALoanReturnTransactionDetail");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.ActualFine).HasMaxLength(50);

                entity.Property(e => e.ActualInterest).HasMaxLength(50);

                entity.Property(e => e.ActualReturn).HasMaxLength(50);

                entity.Property(e => e.ChalenNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfInstallment).HasColumnType("datetime");

                entity.Property(e => e.FineAmount).HasMaxLength(50);

                entity.Property(e => e.FormPrice).HasMaxLength(50);

                entity.Property(e => e.InterestAmount).HasMaxLength(50);

                entity.Property(e => e.NoOfInstallment).HasMaxLength(50);

                entity.Property(e => e.Other).HasMaxLength(50);

                entity.Property(e => e.PaidStatus).HasMaxLength(50);

                entity.Property(e => e.ProfitSavingAmount).HasMaxLength(50);

                entity.Property(e => e.RemainingFine).HasMaxLength(50);

                entity.Property(e => e.RemainingInterest).HasMaxLength(50);

                entity.Property(e => e.RemainingReturn).HasMaxLength(50);

                entity.Property(e => e.ReturnAmount).HasMaxLength(50);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.SavingAmount).HasMaxLength(50);

                entity.Property(e => e.SerialNumber).HasMaxLength(50);

                entity.Property(e => e.ShareAmount).HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbJoinAccount>(entity =>
            {
                entity.HasKey(e => e.JoinAccountPkid);

                entity.ToTable("TB_JoinAccount");

                entity.Property(e => e.FirstAccountOwnerPkid).HasMaxLength(50);

                entity.Property(e => e.SecondAccountOwnerPkid).HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbLoanGroup>(entity =>
            {
                entity.HasKey(e => e.LoanGroupPkid);

                entity.ToTable("TB_LoanGroup");

                entity.Property(e => e.FirstAccount).HasMaxLength(50);

                entity.Property(e => e.SecondAccount).HasMaxLength(50);

                entity.Property(e => e.ThirdAccount).HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbLoanInterestRate>(entity =>
            {
                entity.HasKey(e => e.LoanInterestRatePkid);

                entity.ToTable("TB_LoanInterestRate");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InterestRate).HasMaxLength(50);

                entity.Property(e => e.LoanSeason).HasMaxLength(50);

                entity.Property(e => e.LoanYear).HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbLoanMaster>(entity =>
            {
                entity.HasKey(e => e.LoanReturnPkid)
                    .HasName("PK_TB_LoanReturnTransaction_1");

                entity.ToTable("TB_LoanMaster");

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LoanAmount).HasMaxLength(50);

                entity.Property(e => e.LoanDate).HasColumnType("datetime");

                entity.Property(e => e.LoanSeason).HasMaxLength(50);

                entity.Property(e => e.LoanYear).HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbLoanProposal>(entity =>
            {
                entity.HasKey(e => e.ApplyPkid);

                entity.ToTable("TB_LoanProposal");

                entity.Property(e => e.ApplyDate).HasColumnType("datetime");

                entity.Property(e => e.ApplyStatus).HasMaxLength(50);

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.LoanAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LoanName).HasMaxLength(50);

                entity.Property(e => e.LoanType).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.QueueNumber).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbLoanReturnTransactionDetail>(entity =>
            {
                entity.HasKey(e => e.LoanReturnTransactionDetailPkid);

                entity.ToTable("TB_LoanReturnTransactionDetail");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.ChalenNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FineInterestAmount).HasMaxLength(50);

                entity.Property(e => e.FormPrice).HasMaxLength(50);

                entity.Property(e => e.InterestAmount).HasMaxLength(50);

                entity.Property(e => e.LoanSeason).HasMaxLength(50);

                entity.Property(e => e.LoanYear).HasMaxLength(50);

                entity.Property(e => e.Other).HasMaxLength(50);

                entity.Property(e => e.ProfitSavingAmount).HasMaxLength(50);

                entity.Property(e => e.ReturnAmount).HasMaxLength(50);

                entity.Property(e => e.ReturnDate).HasMaxLength(50);

                entity.Property(e => e.SavingAmount).HasMaxLength(50);

                entity.Property(e => e.SerialNumber).HasMaxLength(50);

                entity.Property(e => e.ShareAmount).HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbLoanTransaction>(entity =>
            {
                entity.HasKey(e => e.LoanPkid);

                entity.ToTable("TB_LoanTransaction");

                entity.Property(e => e.Amount).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(50);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.InterestRate).HasMaxLength(50);

                entity.Property(e => e.LoanItem).HasMaxLength(50);

                entity.Property(e => e.LoanTransactionId)
                    .HasColumnName("LoanTransactionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType).HasMaxLength(50);
            });

            modelBuilder.Entity<TbMachine>(entity =>
            {
                entity.HasKey(e => e.MachinePkid);

                entity.ToTable("TB_Machine");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbMeb2sloanMaster>(entity =>
            {
                entity.HasKey(e => e.LoanReturnPkid)
                    .HasName("PK_TB_MEB2SLoanReturnTransaction");

                entity.ToTable("TB_MEB2SLoanMaster");

                entity.Property(e => e.ActualFine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ActualInterest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ActualReturn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomFine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomInterest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomReturn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FifthInstallment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FirstInstallment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FirstLoanAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FirstLoanDate).HasColumnType("datetime");

                entity.Property(e => e.FourthInstallment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LoanBusinessType).HasMaxLength(50);

                entity.Property(e => e.LoanDesc).HasMaxLength(200);

                entity.Property(e => e.LoanType).HasMaxLength(50);

                entity.Property(e => e.LoanYearType).HasMaxLength(50);

                entity.Property(e => e.MemberNumber).HasMaxLength(50);

                entity.Property(e => e.RemainingFine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemainingInterest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemainingReturn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SecondInstallment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SecondLoanAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SecondLoanDate).HasColumnType("datetime");

                entity.Property(e => e.SixthInstallment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ThirthInstallment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbMeb2sloanReturnTransactionDetail>(entity =>
            {
                entity.HasKey(e => e.LoanReturnTransactionDetailPkid);

                entity.ToTable("TB_MEB2SLoanReturnTransactionDetail");

                entity.Property(e => e.ActualFine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ActualInterest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ActualReturn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.ChalenNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfInstallment).HasColumnType("datetime");

                entity.Property(e => e.FineAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FormPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InterestAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LoanBusinessType).HasMaxLength(50);

                entity.Property(e => e.LoanType).HasMaxLength(50);

                entity.Property(e => e.LoanYearType).HasMaxLength(50);

                entity.Property(e => e.MemberNumber).HasMaxLength(50);

                entity.Property(e => e.NoOfInstallment).HasMaxLength(50);

                entity.Property(e => e.Other).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidStatus).HasMaxLength(50);

                entity.Property(e => e.ProfitSavingAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemainingFine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemainingInterest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemainingReturn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReturnAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.SavingAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SerialNumber).HasMaxLength(50);

                entity.Property(e => e.ShareAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbMeb2spersonalInformation>(entity =>
            {
                entity.HasKey(e => e.PersonPkid);

                entity.ToTable("TB_MEB2SPersonalInformation");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.MemberNumber).HasMaxLength(50);

                entity.Property(e => e.MemberType).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbMessageBox>(entity =>
            {
                entity.HasKey(e => e.MessagePkid);

                entity.ToTable("TB_MessageBox");

                entity.Property(e => e.MessageDate).HasColumnType("datetime");

                entity.Property(e => e.MessageFrom).HasMaxLength(50);

                entity.Property(e => e.MessageId)
                    .HasColumnName("MessageID")
                    .HasMaxLength(50);

                entity.Property(e => e.MessageStatus).HasMaxLength(50);

                entity.Property(e => e.MessageTo).HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbMessageContent>(entity =>
            {
                entity.HasKey(e => e.MessageContentPkid);

                entity.ToTable("TB_MessageContent");

                entity.Property(e => e.AttachFileId)
                    .HasColumnName("AttachFileID")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsUploaded).HasMaxLength(50);

                entity.Property(e => e.MessageId)
                    .HasColumnName("MessageID")
                    .HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbMoeInterestTransaction>(entity =>
            {
                entity.HasKey(e => e.MoeInterestPkid);

                entity.ToTable("TB_MoeInterestTransaction");

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.InterestAmount).HasMaxLength(50);

                entity.Property(e => e.InterestCalculationDate).HasMaxLength(50);

                entity.Property(e => e.InterestRate).HasMaxLength(50);

                entity.Property(e => e.LoanAmount).HasMaxLength(50);

                entity.Property(e => e.LoanSeason).HasMaxLength(50);

                entity.Property(e => e.LoanStartDate).HasMaxLength(50);

                entity.Property(e => e.LoanYear).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReturnAmount).HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbMoeKyoInterestTransaction>(entity =>
            {
                entity.HasKey(e => e.MoeKyoInterestPkid);

                entity.ToTable("TB_MoeKyoInterestTransaction");

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.InterestAmount).HasMaxLength(50);

                entity.Property(e => e.InterestCalculationDate).HasMaxLength(50);

                entity.Property(e => e.InterestRate).HasMaxLength(50);

                entity.Property(e => e.LoanAmount).HasMaxLength(50);

                entity.Property(e => e.LoanSeason).HasMaxLength(50);

                entity.Property(e => e.LoanStartDate).HasMaxLength(50);

                entity.Property(e => e.LoanYear).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReturnAmount).HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbPersonalInformation>(entity =>
            {
                entity.HasKey(e => e.PersonPkid);

                entity.ToTable("TB_PersonalInformation");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.Jicanumber)
                    .HasColumnName("JICANumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbRegion>(entity =>
            {
                entity.HasKey(e => e.RegionPkid);

                entity.ToTable("TB_Region");

                entity.Property(e => e.Region).HasMaxLength(500);

                entity.Property(e => e.RegionCode).HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbSaungInterestTransaction>(entity =>
            {
                entity.HasKey(e => e.SaungInterestPkid);

                entity.ToTable("TB_SaungInterestTransaction");

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.InterestAmount).HasMaxLength(50);

                entity.Property(e => e.InterestCalculationDate).HasMaxLength(50);

                entity.Property(e => e.InterestRate).HasMaxLength(50);

                entity.Property(e => e.LoanAmount).HasMaxLength(50);

                entity.Property(e => e.LoanSeason).HasMaxLength(50);

                entity.Property(e => e.LoanStartDate).HasMaxLength(50);

                entity.Property(e => e.LoanYear).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReturnAmount).HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbSavingMaster>(entity =>
            {
                entity.HasKey(e => e.SavingMasterPkid);

                entity.ToTable("TB_SavingMaster");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(50);

                entity.Property(e => e.SavingAmount).HasMaxLength(50);

                entity.Property(e => e.TotalAmount).HasMaxLength(50);

                entity.Property(e => e.TotalInterest).HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbStaff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TB_Staff");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.JoinedDate).HasColumnType("datetime");

                entity.Property(e => e.MotherName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.StaffId)
                    .HasColumnName("StaffID")
                    .HasMaxLength(50);

                entity.Property(e => e.StaffPkid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TbStateDivision>(entity =>
            {
                entity.HasKey(e => e.StateDivisionPkid);

                entity.ToTable("TB_StateDivision");

                entity.Property(e => e.StateDivision).HasMaxLength(50);

                entity.Property(e => e.StateDivisionCode).HasMaxLength(50);
            });

            modelBuilder.Entity<TbStatedivi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_statedivi");

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbTownship>(entity =>
            {
                entity.HasKey(e => e.TownshipPkid);

                entity.ToTable("TB_Township");

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.Township).HasMaxLength(500);

                entity.Property(e => e.TownshipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<TbTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionPkid);

                entity.ToTable("TB_Transaction");

                entity.Property(e => e.Amount).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(50);

                entity.Property(e => e.InterestRate).HasMaxLength(50);

                entity.Property(e => e.InterestTotal).HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionType).HasMaxLength(50);
            });

            modelBuilder.Entity<TbUser>(entity =>
            {
                entity.HasKey(e => e.UserPkid);

                entity.ToTable("TB_User");

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.TownshipId).HasMaxLength(6);

                entity.Property(e => e.Username).IsRequired();
            });

            modelBuilder.Entity<TbUserLogin>(entity =>
            {
                entity.HasKey(e => e.UserPkid);

                entity.ToTable("TB_UserLogin");

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Office)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.TownshipId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UsernameOrEmail)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbVillage>(entity =>
            {
                entity.HasKey(e => e.VillagePkid);

                entity.ToTable("TB_Village");

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.VillageCode).HasMaxLength(50);

                entity.Property(e => e.VillageName).HasMaxLength(500);
            });

            modelBuilder.Entity<VwAccountDetailTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAccountDetailTransaction");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.AccountTransCreatedBy).HasMaxLength(50);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Amount).HasMaxLength(50);

                entity.Property(e => e.ChalenNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasMaxLength(50);

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalBalance).HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionType).HasMaxLength(50);
            });

            modelBuilder.Entity<VwAccountDetailTransactionForBalancingChecking>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAccountDetailTransactionForBalancingChecking");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBalance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAccountDetailTransactionOnlineCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAccountDetailTransactionOnlineCheck");

                entity.Property(e => e.AccountDetailPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Amount).HasMaxLength(50);

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.ChalenNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.TotalBalance).HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionType).HasMaxLength(50);
            });

            modelBuilder.Entity<VwAccountDetailTransactionPassBookSelectByAccNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AccountDetailTransactionPassBook_SelectByAccNo");

                entity.Property(e => e.AccountDetailPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.Amount).HasMaxLength(50);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBalance).HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionShortDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType).HasMaxLength(50);
            });

            modelBuilder.Entity<VwAccountSummaryOnlineCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAccountSummaryOnlineCheck");

                entity.Property(e => e.AccountStatus).HasMaxLength(50);

                entity.Property(e => e.AccountSummaryPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.AmountUpdatedDate).HasMaxLength(50);

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.LastBalance).HasMaxLength(50);

                entity.Property(e => e.RecordCreatedBy).HasMaxLength(50);

                entity.Property(e => e.RecordCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwCustomerAccountDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCustomerAccountDetail");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.AccountStatus).HasMaxLength(50);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.AmountUpdatedDate).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.LastBalance).HasMaxLength(50);

                entity.Property(e => e.LastBalanceFromAdt)
                    .IsRequired()
                    .HasColumnName("LastBalanceFromADT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwCustomerForm7Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCustomerForm7Detail");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.ConfirmLetterDate).HasMaxLength(50);

                entity.Property(e => e.ConfirmLetterNo).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.FarmArea).HasMaxLength(50);

                entity.Property(e => e.FarmLocation).HasMaxLength(200);

                entity.Property(e => e.FarmName).HasMaxLength(200);

                entity.Property(e => e.FarmNo).HasMaxLength(50);

                entity.Property(e => e.FarmType).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.Form7CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.Township).HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);

                entity.Property(e => e.UpaingNo)
                    .HasColumnName("UPaingNo")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwDateSettingForRsdinterest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwDateSettingForRSDInterest");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateSettingPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.EntryDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwDebtPeopleTransactionDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwDebtPeopleTransactionDetail");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Balance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ChalenNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.FineInterestAmount).HasMaxLength(50);

                entity.Property(e => e.FormPrice).HasMaxLength(50);

                entity.Property(e => e.InterestAmount).HasMaxLength(50);

                entity.Property(e => e.LoanAmount).HasMaxLength(50);

                entity.Property(e => e.LoanDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LoanSeason).HasMaxLength(50);

                entity.Property(e => e.LoanYear).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.Other).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ProfitSavingAmount).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasMaxLength(50);

                entity.Property(e => e.ReturnAmount).HasMaxLength(50);

                entity.Property(e => e.ReturnDate).HasMaxLength(50);

                entity.Property(e => e.SavingAmount).HasMaxLength(50);

                entity.Property(e => e.ShareAmount).HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwFine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwFine");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FinePkid).ValueGeneratedOnAdd();

                entity.Property(e => e.FineRate).HasMaxLength(50);

                entity.Property(e => e.FromDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<VwForm7OnlineCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwForm7OnlineCheck");

                entity.Property(e => e.ConfirmLetterDate).HasMaxLength(50);

                entity.Property(e => e.ConfirmLetterNo).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FarmArea).HasMaxLength(50);

                entity.Property(e => e.FarmLocation).HasMaxLength(200);

                entity.Property(e => e.FarmName).HasMaxLength(200);

                entity.Property(e => e.FarmNo).HasMaxLength(50);

                entity.Property(e => e.FarmType).HasMaxLength(50);

                entity.Property(e => e.Form7Pkid).ValueGeneratedOnAdd();

                entity.Property(e => e.Township).HasMaxLength(50);

                entity.Property(e => e.UpaingNo)
                    .HasColumnName("UPaingNo")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwGetRegionSelectList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwGetRegion_SelectList");

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwInterest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInterest");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InterestPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.InterestRate).HasMaxLength(50);

                entity.Property(e => e.ToDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<VwJicacustomerAccountDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwJICACustomerAccountDetail");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.AccountStatus).HasMaxLength(50);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.AmountUpdatedDate).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.Jicanumber)
                    .HasColumnName("JICANumber")
                    .HasMaxLength(50);

                entity.Property(e => e.LastBalance).HasMaxLength(50);

                entity.Property(e => e.LastBalanceFromAdt)
                    .IsRequired()
                    .HasColumnName("LastBalanceFromADT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwJicadebtPeopleTransactionDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwJICADebtPeopleTransactionDetail");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Balance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ChalenNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.DateOfInstallment)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.FineAmount).HasMaxLength(50);

                entity.Property(e => e.FormPrice).HasMaxLength(50);

                entity.Property(e => e.InterestAmount).HasMaxLength(50);

                entity.Property(e => e.Jicanumber)
                    .HasColumnName("JICANumber")
                    .HasMaxLength(50);

                entity.Property(e => e.LoanAmount).HasMaxLength(50);

                entity.Property(e => e.LoanDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MachineType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NoOfInstallment).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.Other).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ProfitSavingAmount).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasMaxLength(50);

                entity.Property(e => e.ReturnAmount).HasMaxLength(50);

                entity.Property(e => e.ReturnDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SavingAmount).HasMaxLength(50);

                entity.Property(e => e.SerialNumber).HasMaxLength(50);

                entity.Property(e => e.ShareAmount).HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwJicaloanMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwJICALoanMaster");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.ActualFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Balance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ChassisNo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CustomFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CustomInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CustomReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.Dealer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EngineNo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.Jicanumber)
                    .IsRequired()
                    .HasColumnName("JICANumber")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ProposalAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RefundAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasMaxLength(50);

                entity.Property(e => e.RemainingFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwJicaloanMasterForBalancingChecking>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwJICALoanMasterForBalancingChecking");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Balance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ChassisNo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.Dealer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EngineNo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.Jicanumber)
                    .IsRequired()
                    .HasColumnName("JICANumber")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ProposalAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RefundAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasMaxLength(50);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwJicaloanMasterOnlineCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwJICALoanMasterOnlineCheck");

                entity.Property(e => e.ActualFine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ActualInterest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ActualReturn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.ChassisNo).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomFine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomInterest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomReturn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Dealer).HasMaxLength(200);

                entity.Property(e => e.EngineNo).HasMaxLength(50);

                entity.Property(e => e.LoanAmount).HasMaxLength(50);

                entity.Property(e => e.LoanDate).HasColumnType("datetime");

                entity.Property(e => e.LoanReturnPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.ProposalAmount).HasMaxLength(50);

                entity.Property(e => e.RemainingFine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemainingInterest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemainingReturn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwJicaloanMasterPassBookSelectByAccNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_JICALoanMasterPassBook_SelectByAccNo");

                entity.Property(e => e.LoanAmount).HasMaxLength(50);

                entity.Property(e => e.LoanDate).HasColumnType("datetime");

                entity.Property(e => e.LoanReturnPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.LoanShortDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBalance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwJicaloanReturnTransPeopleGroupByRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwJICALoanReturnTransPeopleGroupByRegion");

                entity.Property(e => e.DebtPeople)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DebtPeoplePercentage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MachineType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaidPeople)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PeoplePercentage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPeople)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .IsRequired()
                    .HasColumnName("TownshipID")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwJicaloanReturnTransactionDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwJICALoanReturnTransactionDetail");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.ActualFine).HasMaxLength(50);

                entity.Property(e => e.ActualInterest).HasMaxLength(50);

                entity.Property(e => e.ActualReturn).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.ChalenNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.DateOfInstallment)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.FineAmount).HasMaxLength(50);

                entity.Property(e => e.FormPrice).HasMaxLength(50);

                entity.Property(e => e.InterestAmount).HasMaxLength(50);

                entity.Property(e => e.Jicanumber)
                    .IsRequired()
                    .HasColumnName("JICANumber")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NoOfInstallment).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.Other).HasMaxLength(50);

                entity.Property(e => e.PaidStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ProfitSavingAmount).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasMaxLength(50);

                entity.Property(e => e.RemainingFine).HasMaxLength(50);

                entity.Property(e => e.RemainingInterest).HasMaxLength(50);

                entity.Property(e => e.RemainingReturn).HasMaxLength(50);

                entity.Property(e => e.ReturnAmount).HasMaxLength(50);

                entity.Property(e => e.ReturnDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnTransactionCreatedBy).HasMaxLength(50);

                entity.Property(e => e.SavingAmount).HasMaxLength(50);

                entity.Property(e => e.SerialNumber).HasMaxLength(50);

                entity.Property(e => e.ShareAmount).HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwJicaloanReturnTransactionDetailOnlineCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwJICALoanReturnTransactionDetailOnlineCheck");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.ActualFine).HasMaxLength(50);

                entity.Property(e => e.ActualInterest).HasMaxLength(50);

                entity.Property(e => e.ActualReturn).HasMaxLength(50);

                entity.Property(e => e.ChalenNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfInstallment).HasColumnType("datetime");

                entity.Property(e => e.FineAmount).HasMaxLength(50);

                entity.Property(e => e.FormPrice).HasMaxLength(50);

                entity.Property(e => e.InterestAmount).HasMaxLength(50);

                entity.Property(e => e.LoanReturnTransactionDetailPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.NoOfInstallment).HasMaxLength(50);

                entity.Property(e => e.Other).HasMaxLength(50);

                entity.Property(e => e.PaidStatus).HasMaxLength(50);

                entity.Property(e => e.ProfitSavingAmount).HasMaxLength(50);

                entity.Property(e => e.RemainingFine).HasMaxLength(50);

                entity.Property(e => e.RemainingInterest).HasMaxLength(50);

                entity.Property(e => e.RemainingReturn).HasMaxLength(50);

                entity.Property(e => e.ReturnAmount).HasMaxLength(50);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.SavingAmount).HasMaxLength(50);

                entity.Property(e => e.SerialNumber).HasMaxLength(50);

                entity.Property(e => e.ShareAmount).HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwJicaloanReturnTransactionDetailPassBookSelectByAccNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_JICALoanReturnTransactionDetailPassBook_SelectByAccNo");

                entity.Property(e => e.FineInterestAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InterestAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnShortDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SavingAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBalance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwJicaloanReturnTransactionGroupByRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwJICALoanReturnTransactionGroupByRegion");

                entity.Property(e => e.BalancePercentage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MachineType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnedPercentage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StateDivisionId)
                    .IsRequired()
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBalance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLoan)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .IsRequired()
                    .HasColumnName("TownshipID")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwJicans7>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwJICANS7");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.ActualFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Balance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ChassisNo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.Dealer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EngineNo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.FineAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InterestAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Jicanumber)
                    .IsRequired()
                    .HasColumnName("JICANumber")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ProposalAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RefundAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasMaxLength(50);

                entity.Property(e => e.RemainingFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwLoanInterestDetailTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLoanInterestDetailTransaction");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Balance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanSeason)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nrc)
                    .IsRequired()
                    .HasColumnName("NRC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PersonPkid).HasColumnName("PersonPKID");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StateDivisionId)
                    .IsRequired()
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .IsRequired()
                    .HasColumnName("TownshipID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .IsRequired()
                    .HasColumnName("TransactionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwLoanMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLoanMaster");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Balance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.LoanAmount).HasMaxLength(50);

                entity.Property(e => e.LoanDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LoanSeason).HasMaxLength(50);

                entity.Property(e => e.LoanYear).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasMaxLength(50);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwLoanMasterOnlineCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLoanMasterOnlineCheck");

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LoanAmount).HasMaxLength(50);

                entity.Property(e => e.LoanDate).HasColumnType("datetime");

                entity.Property(e => e.LoanReturnPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.LoanSeason).HasMaxLength(50);

                entity.Property(e => e.LoanYear).HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwLoanMasterPassBookSelectByAccNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_LoanMasterPassBook_SelectByAccNo");

                entity.Property(e => e.LoanAmount).HasMaxLength(50);

                entity.Property(e => e.LoanDate).HasColumnType("datetime");

                entity.Property(e => e.LoanReturnPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.LoanShortDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBalance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwLoanProposal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_LoanProposal");

                entity.Property(e => e.ApplyDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nrc)
                    .IsRequired()
                    .HasColumnName("NRC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.QueueNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StateDivisionId)
                    .IsRequired()
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .IsRequired()
                    .HasColumnName("TownshipID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .IsRequired()
                    .HasColumnName("TransactionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwLoanReturnDateList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLoanReturnDateList");

                entity.Property(e => e.LoanReturnTransactionDetailPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.ReturnDate).HasMaxLength(50);
            });

            modelBuilder.Entity<VwLoanReturnTransPeopleGroupByRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLoanReturnTransPeopleGroupByRegion");

                entity.Property(e => e.DebtPeople)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DebtPeoplePercentage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanSeason)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaidPeople)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PeoplePercentage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPeople)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .IsRequired()
                    .HasColumnName("TownshipID")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwLoanReturnTransactionDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLoanReturnTransactionDetail");

                entity.Property(e => e.AccountNumber).HasMaxLength(4000);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.ChalenNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.FineInterestAmount).HasMaxLength(50);

                entity.Property(e => e.FormPrice).HasMaxLength(50);

                entity.Property(e => e.InterestAmount).HasMaxLength(50);

                entity.Property(e => e.LoanDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LoanSeason).HasMaxLength(50);

                entity.Property(e => e.LoanYear).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.Other).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ProfitSavingAmount).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasMaxLength(50);

                entity.Property(e => e.ReturnAmount).HasMaxLength(50);

                entity.Property(e => e.ReturnDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnTransactionCreatedBy).HasMaxLength(50);

                entity.Property(e => e.SavingAmount).HasMaxLength(50);

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ShareAmount).HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwLoanReturnTransactionDetailOnlineCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLoanReturnTransactionDetailOnlineCheck");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.ChalenNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FineInterestAmount).HasMaxLength(50);

                entity.Property(e => e.FormPrice).HasMaxLength(50);

                entity.Property(e => e.InterestAmount).HasMaxLength(50);

                entity.Property(e => e.LoanReturnTransactionDetailPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.LoanSeason).HasMaxLength(50);

                entity.Property(e => e.LoanYear).HasMaxLength(50);

                entity.Property(e => e.Other).HasMaxLength(50);

                entity.Property(e => e.ProfitSavingAmount).HasMaxLength(50);

                entity.Property(e => e.ReturnAmount).HasMaxLength(50);

                entity.Property(e => e.ReturnDate).HasMaxLength(50);

                entity.Property(e => e.SavingAmount).HasMaxLength(50);

                entity.Property(e => e.SerialNumber).HasMaxLength(50);

                entity.Property(e => e.ShareAmount).HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwLoanReturnTransactionDetailPassBookSelectByAccNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_LoanReturnTransactionDetailPassBook_SelectByAccNo");

                entity.Property(e => e.FineInterestAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InterestAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate).HasMaxLength(50);

                entity.Property(e => e.ReturnShortDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SavingAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBalance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwLoanReturnTransactionGroupByRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLoanReturnTransactionGroupByRegion");

                entity.Property(e => e.BalancePercentage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanSeason)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnedPercentage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StateDivisionId)
                    .IsRequired()
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBalance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLoan)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .IsRequired()
                    .HasColumnName("TownshipID")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwMachine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMachine");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachinePkid).ValueGeneratedOnAdd();

                entity.Property(e => e.MachineType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwMeb2sloanMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMEB2SLoanMaster");

                entity.Property(e => e.ActualFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Balance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CustomFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CustomInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CustomReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.FifthInstallment)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstInstallment)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLoanDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FourthInstallment)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanBusinessType).HasMaxLength(50);

                entity.Property(e => e.LoanDesc).HasMaxLength(200);

                entity.Property(e => e.LoanType).HasMaxLength(50);

                entity.Property(e => e.LoanYearType).HasMaxLength(50);

                entity.Property(e => e.MemberNumber).HasMaxLength(50);

                entity.Property(e => e.MemberType).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.PendingYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RemainingFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SecondInstallment)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SecondLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SecondLoanDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SixthInstallment)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ThirthInstallment)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwMeb2sloanMasterForBalancingChecking>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMEB2SLoanMasterForBalancingChecking");

                entity.Property(e => e.Balance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.FirstLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLoanDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanBusinessType).HasMaxLength(50);

                entity.Property(e => e.LoanDesc).HasMaxLength(200);

                entity.Property(e => e.LoanType).HasMaxLength(50);

                entity.Property(e => e.LoanYearType).HasMaxLength(50);

                entity.Property(e => e.MemberNumber).HasMaxLength(50);

                entity.Property(e => e.MemberType).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.PendingYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SecondLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SecondLoanDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwMeb2sloanMasterForBalancingCheckingWithSaving>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMEB2SLoanMasterForBalancingCheckingWithSaving");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Balance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLoanDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanBusinessType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanDesc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanYearType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemberNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nrc)
                    .IsRequired()
                    .HasColumnName("NRC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PendingYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SecondLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SecondLoanDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .IsRequired()
                    .HasColumnName("TownshipID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .IsRequired()
                    .HasColumnName("TransactionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwMeb2sloanMasterOnlineCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMEB2SLoanMasterOnlineCheck");

                entity.Property(e => e.ActualFine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ActualInterest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ActualReturn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomFine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomInterest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomReturn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FifthInstallment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FirstInstallment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FirstLoanAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FirstLoanDate).HasColumnType("datetime");

                entity.Property(e => e.FourthInstallment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LoanBusinessType).HasMaxLength(50);

                entity.Property(e => e.LoanDesc).HasMaxLength(200);

                entity.Property(e => e.LoanReturnPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.LoanType).HasMaxLength(50);

                entity.Property(e => e.LoanYearType).HasMaxLength(50);

                entity.Property(e => e.MemberNumber).HasMaxLength(50);

                entity.Property(e => e.RemainingFine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemainingInterest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemainingReturn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SecondInstallment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SecondLoanAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SecondLoanDate).HasColumnType("datetime");

                entity.Property(e => e.SixthInstallment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ThirthInstallment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwMeb2sloanMasterPassBookSelectByAccNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_MEB2SLoanMasterPassBook_SelectByAccNo");

                entity.Property(e => e.LoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanDate).HasColumnType("datetime");

                entity.Property(e => e.LoanReturnPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.LoanShortDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBalance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwMeb2sloanMasterWithSaving>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMEB2SLoanMasterWithSaving");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Balance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CustomInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CustomReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FifthInstallment)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstInstallment)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLoanDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FourthInstallment)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanBusinessType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanDesc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanYearType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemberNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nrc)
                    .IsRequired()
                    .HasColumnName("NRC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PendingYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SecondInstallment)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SecondLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SecondLoanDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SixthInstallment)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ThirthInstallment)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .IsRequired()
                    .HasColumnName("TownshipID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .IsRequired()
                    .HasColumnName("TransactionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwMeb2sloanReturnTransactionDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMEB2SLoanReturnTransactionDetail");

                entity.Property(e => e.ActualFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ChalenNumber).HasMaxLength(50);

                entity.Property(e => e.DateOfInstallment)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.FineAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLoanDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FormPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InterestAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanBusinessType).HasMaxLength(50);

                entity.Property(e => e.LoanDesc).HasMaxLength(200);

                entity.Property(e => e.LoanType).HasMaxLength(50);

                entity.Property(e => e.LoanYearType).HasMaxLength(50);

                entity.Property(e => e.MemberNumber).HasMaxLength(50);

                entity.Property(e => e.MemberType).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NoOfInstallment).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Other)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaidStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitSavingAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RemainingFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnTransactionCreatedBy).HasMaxLength(50);

                entity.Property(e => e.SavingAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SecondLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SecondLoanDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber).HasMaxLength(50);

                entity.Property(e => e.ShareAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwMeb2sloanReturnTransactionDetailOnlineCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMEB2SLoanReturnTransactionDetailOnlineCheck");

                entity.Property(e => e.ActualFine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ActualInterest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ActualReturn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.ChalenNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfInstallment).HasColumnType("datetime");

                entity.Property(e => e.FineAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FormPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InterestAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LoanBusinessType).HasMaxLength(50);

                entity.Property(e => e.LoanReturnTransactionDetailPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.LoanType).HasMaxLength(50);

                entity.Property(e => e.LoanYearType).HasMaxLength(50);

                entity.Property(e => e.MemberNumber).HasMaxLength(50);

                entity.Property(e => e.NoOfInstallment).HasMaxLength(50);

                entity.Property(e => e.Other).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidStatus).HasMaxLength(50);

                entity.Property(e => e.ProfitSavingAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemainingFine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemainingInterest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemainingReturn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReturnAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.SavingAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SerialNumber).HasMaxLength(50);

                entity.Property(e => e.ShareAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwMeb2sloanReturnTransactionDetailPassBookSelectByAccNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_MEB2SLoanReturnTransactionDetailPassBook_SelectByAccNo");

                entity.Property(e => e.FineInterestAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InterestAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnShortDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SavingAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBalance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwMeb2sloanReturnTransactionDetailWithSaving>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMEB2SLoanReturnTransactionDetailWithSaving");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ChalenNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfInstallment)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FineAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLoanDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FormPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InterestAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanBusinessType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanDesc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanYearType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemberNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfInstallment)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nrc)
                    .IsRequired()
                    .HasColumnName("NRC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Other)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaidStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitSavingAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnTransactionCreatedBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SavingAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SecondLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SecondLoanDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ShareAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .IsRequired()
                    .HasColumnName("TownshipID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .IsRequired()
                    .HasColumnName("TransactionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwMeb2smemberDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMEB2SMemberDetail");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DateOfBirth)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.MemberNumber).HasMaxLength(50);

                entity.Property(e => e.MemberType).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.PersonPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwMeb2spersonalInformationOnlineCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMEB2SPersonalInformationOnlineCheck");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.MemberNumber).HasMaxLength(50);

                entity.Property(e => e.MemberType).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.PersonPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RegionCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.StateDivisionCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwMebtslns10>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMEBTSLNS10");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.ActualFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Balance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.FineAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InterestAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanBusinessType).HasMaxLength(50);

                entity.Property(e => e.LoanDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LoanDesc).HasMaxLength(200);

                entity.Property(e => e.LoanType).HasMaxLength(50);

                entity.Property(e => e.LoanYearType).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.RemainingFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwMebtslns10withSaving>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMEBTSLNS10WithSaving");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ActualReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Balance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FineAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InterestAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanBusinessType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanDesc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanYearType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemberNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nrc)
                    .IsRequired()
                    .HasColumnName("NRC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingFine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingInterest)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StateDivisionId)
                    .IsRequired()
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .IsRequired()
                    .HasColumnName("TownshipID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .IsRequired()
                    .HasColumnName("TransactionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwPassBookFrontSelectByAccNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPassBookFront_Select ByAccNo");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.AccountStatus).HasMaxLength(50);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstMemberFatherName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstMemberName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstNrc)
                    .IsRequired()
                    .HasColumnName("FirstNRC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstPhone)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NrcofAdan)
                    .IsRequired()
                    .HasColumnName("NRCOfAdan")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationDate).HasMaxLength(50);

                entity.Property(e => e.SecondMemberFatherName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SecondMemberName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SecondNrc)
                    .IsRequired()
                    .HasColumnName("SecondNRC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SecondPhone)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInstruction)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TodayDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwPersonalInformationOnlineCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPersonalInformationOnlineCheck");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.Jicanumber)
                    .HasColumnName("JICANumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nrc)
                    .HasColumnName("NRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.PersonPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RegionCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasMaxLength(50);

                entity.Property(e => e.StateDivisionCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwRegion");

                entity.Property(e => e.Region).HasMaxLength(500);

                entity.Property(e => e.RegionCode).HasMaxLength(50);

                entity.Property(e => e.Township).HasMaxLength(500);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwStateDivision>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwStateDivision");

                entity.Property(e => e.StateDivision).HasMaxLength(50);

                entity.Property(e => e.StateDivisionCode).HasMaxLength(50);

                entity.Property(e => e.StateDivisionPkid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTownship>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTownship");

                entity.Property(e => e.StateDivision).HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.Township).HasMaxLength(500);

                entity.Property(e => e.TownshipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<VwVillage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwVillage");

                entity.Property(e => e.Township).HasMaxLength(500);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.VillageCode).HasMaxLength(50);

                entity.Property(e => e.VillageName).HasMaxLength(500);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
