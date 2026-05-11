using System;

namespace Core.DTOs
{
    public class RecentTestResultDto
    {
        public string ApplicantName { get; set; } = string.Empty;

        public string TestType { get; set; } = string.Empty;

        public string Result { get; set; } = string.Empty;

        public DateTime TestDate { get; set; }
    }
}
