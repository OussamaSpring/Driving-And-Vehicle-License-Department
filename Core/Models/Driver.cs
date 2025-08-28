using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Driver
    {
        public int DriverId { get; set; }
        public int DriverPersonId { get; set; }
        public string NationalNumber { get; set; }
        public string FullName { get; set; }
        public DateTime CreateDate { get; set; }
        public short ActiveLicensesCount { get; set; }
        public int CreatedByUserId { get; set; }
    }
}
