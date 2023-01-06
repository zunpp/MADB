﻿using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class VwMeb2sloanMaster
    {
        public int PersonPkid { get; set; }
        public string TransactionId { get; set; }
        public string MemberNumber { get; set; }
        public string MemberType { get; set; }
        public string Name { get; set; }
        public string Nrc { get; set; }
        public string FatherName { get; set; }
        public string RegionId { get; set; }
        public string TownshipId { get; set; }
        public bool? IsMainPerson { get; set; }
        public bool? IsActive { get; set; }
        public bool? PersonRecordDeleted { get; set; }
        public bool? PersonRecordEdited { get; set; }
        public int? LoanReturnPkid { get; set; }
        public string LoanYearType { get; set; }
        public string LoanBusinessType { get; set; }
        public string LoanType { get; set; }
        public string LoanDesc { get; set; }
        public string Duration { get; set; }
        public string PendingYear { get; set; }
        public string FirstLoanDate { get; set; }
        public string FirstLoanAmount { get; set; }
        public string SecondLoanDate { get; set; }
        public string SecondLoanAmount { get; set; }
        public string TotalLoanAmount { get; set; }
        public string Balance { get; set; }
        public string ReturnAmount { get; set; }
        public string CustomReturn { get; set; }
        public string ActualReturn { get; set; }
        public string RemainingReturn { get; set; }
        public string CustomInterest { get; set; }
        public string ActualInterest { get; set; }
        public string RemainingInterest { get; set; }
        public string CustomFine { get; set; }
        public string ActualFine { get; set; }
        public string RemainingFine { get; set; }
        public string FirstInstallment { get; set; }
        public string SecondInstallment { get; set; }
        public string ThirthInstallment { get; set; }
        public string FourthInstallment { get; set; }
        public string FifthInstallment { get; set; }
        public string SixthInstallment { get; set; }
        public bool? LoanRecordDeleted { get; set; }
        public bool? LoanReturnEdited { get; set; }
        public string CreatedBy { get; set; }
    }
}
