﻿using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class VwMeb2sloanMasterForBalancingCheckingWithSaving
    {
        public int PersonPkid { get; set; }
        public string TransactionId { get; set; }
        public string AccountNumber { get; set; }
        public string MemberNumber { get; set; }
        public string AccountType { get; set; }
        public string Name { get; set; }
        public string Nrc { get; set; }
        public string FatherName { get; set; }
        public string RegionId { get; set; }
        public string TownshipId { get; set; }
        public bool? IsMainPerson { get; set; }
        public bool? IsActive { get; set; }
        public bool? PersonRecordDeleted { get; set; }
        public bool? PersonRecordEdited { get; set; }
        public int LoanReturnPkid { get; set; }
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
        public bool? LoanRecordDeleted { get; set; }
        public bool? LoanReturnEdited { get; set; }
        public string CreatedBy { get; set; }
    }
}
