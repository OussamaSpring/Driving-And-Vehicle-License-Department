namespace Core.DTOs
{
    public class DetainedRevenueDto
    {
        public string MonthName { get; set; } = string.Empty;

        public int DetainedLicensesCount { get; set; }

        public decimal Revenue { get; set; }
    }
}
