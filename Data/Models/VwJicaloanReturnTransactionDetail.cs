﻿using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class VwJicaloanReturnTransactionDetail
    {
        public int PersonPkid { get; set; }
        public string TransactionId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string Name { get; set; }
        public string Nrc { get; set; }
        public string DateOfBirth { get; set; }
        public string FatherName { get; set; }
        public string Occupation { get; set; }
        public string Address { get; set; }
        public string RegionId { get; set; }
        public string TownshipId { get; set; }
        public string Phone { get; set; }
        public string StateDivisionId { get; set; }
        public string RegistrationDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? PersonRecordEdited { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LoanReturnTransactionDetailPkid { get; set; }
        public int? LoanReturnPkid { get; set; }
        public string Jicanumber { get; set; }
        public string LoanDate { get; set; }
        public string NoOfInstallment { get; set; }
        public string DateOfInstallment { get; set; }
        public string SerialNumber { get; set; }
        public string ChalenNumber { get; set; }
        public string ReturnAmount { get; set; }
        public string ActualReturn { get; set; }
        public string RemainingReturn { get; set; }
        public string InterestAmount { get; set; }
        public string ActualInterest { get; set; }
        public string RemainingInterest { get; set; }
        public string FineAmount { get; set; }
        public string ActualFine { get; set; }
        public string RemainingFine { get; set; }
        public string ProfitSavingAmount { get; set; }
        public string SavingAmount { get; set; }
        public string ShareAmount { get; set; }
        public string FormPrice { get; set; }
        public string Other { get; set; }
        public string TotalAmount { get; set; }
        public string ReturnDate { get; set; }
        public string PaidStatus { get; set; }
        public bool? ReturnTransactionDeleted { get; set; }
        public bool? ReturnTransactionEdited { get; set; }
        public string ReturnTransactionCreatedBy { get; set; }
    }
}
