using Core.Enums;
using System;

namespace Core.Models
{
    public class LocalDrivingLicenseApplication
    {
        public int LDL_ApplicationId { get; set; }
        public LicenseClass LicenseClass { get; set; }
        public string NationalNumber { get; set; }
        public string FullName { get; set; }
        public int ApplicationId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public short PassedTest { get; set; }
        public ApplicationStatus Status { get; set; }
    }
}
