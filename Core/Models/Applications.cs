    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Applications
    {
        public int ApplicationId { get; set; }
        public int ApplicantPersonId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public ApplicationType ApplicationType { get; set; }
        public string ApplicationStatus { get; set; }
        public DateTime? LastStatusDate { get; set; }
        public float? PaidFees { get; set; }
        public int CreatedByUserId { get; set; }
    }
}
