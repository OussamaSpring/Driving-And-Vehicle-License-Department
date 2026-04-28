using System;
using Core.Enums;

namespace Core.Models
{
    public class TestAppointment
    {
        public int TestAppointmentId { get; set; }
        public TestTypes TestType { get; set; }
        public int LocalDrivingLicenseApplicationId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserId { get; set; }
        public bool isLocked { get; set; }
        public int RetakeApplicationId { get; set; }
    }
}
