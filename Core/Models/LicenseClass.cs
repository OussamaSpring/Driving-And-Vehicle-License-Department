

using System.Data.SqlTypes;

namespace Core.Models
{
    public class LicenseClass
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short MiminumAllowedAge { get; set; }
        public short DefaultValidityLength { get; set; } // Years
        public decimal ClassFees { get; set; }
    }
}
