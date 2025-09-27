

using System;
using Core.Enums;

namespace Core.Models
{
    public class License
    {
        public int LicenseId { get; set; }
        public int ApplicationId { get; set; }
        public int DriverId { get; set; }
        public short ClassId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public float PaidFees { get; set; }
        public bool IsActive { get; set; }
        public LicenseIsssueReasons enIssuesReason { get; set; }
        public int IssuedByUserId { get; set; }
    }
}
