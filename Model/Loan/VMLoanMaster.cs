﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Loan
{
    public class VMLoanMaster
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
        public bool? IsMainPerson { get; set; }
        public bool? IsActive { get; set; }
        public bool? PersonRecordDeleted { get; set; }
        public bool? PersonRecordEdited { get; set; }
        public int? LoanReturnPkid { get; set; }
        public string LoanYear { get; set; }
        public string LoanSeason { get; set; }
        public string LoanAmount { get; set; }
        public string ReturnAmount { get; set; }
        public string Balance { get; set; }
        public string LoanDate { get; set; }
        public bool? LoanRecordDeleted { get; set; }
        public bool? LoanReturnEdited { get; set; }
        public string CreatedBy { get; set; }
    }
}
