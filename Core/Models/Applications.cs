using Core.Enums;
using System;

namespace Core.Models
{
    public class Applications
    {
        public int ApplicationId { get; set; }
        public int ApplicantPersonId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public ApplicationType ApplicationType { get; set; }
        public ApplicationStatus enApplicationStatus { get; set; }
        public DateTime? LastStatusDate { get; set; }
        public decimal? PaidFees { get; set; }
        public int CreatedByUserId { get; set; }
    }
}
