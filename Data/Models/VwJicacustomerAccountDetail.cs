﻿using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class VwJicacustomerAccountDetail
    {
        public int PersonPkid { get; set; }
        public string TransactionId { get; set; }
        public string AccountNumber { get; set; }
        public string Jicanumber { get; set; }
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
        public bool? IsDeleted { get; set; }
        public bool? PersonRecordEdited { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? AccountSummaryPkid { get; set; }
        public string AccountStatus { get; set; }
        public string LastBalance { get; set; }
        public string LastBalanceFromAdt { get; set; }
        public string AmountUpdatedDate { get; set; }
        public bool? AccountRecordEdited { get; set; }
    }
}
