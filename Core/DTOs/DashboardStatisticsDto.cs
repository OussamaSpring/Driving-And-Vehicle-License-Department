using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class DashboardStatisticsDto
    {
        public int RegisteredDrivers { get; set; }
        public int ActiveLicenses { get; set; }
        public int PendingApplications { get; set; }
        public int ScheduledTests { get; set; }

    }
}
