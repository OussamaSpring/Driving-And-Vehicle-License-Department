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
        public int ApplicationPersonId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string ApplicationStatus { get; set; }
        public DateTime? ApplicationDecisionDate { get; set; }

        public float? PaidFees { get; set; }
        public int CreatedByUserId { get; set; }
    }
}
