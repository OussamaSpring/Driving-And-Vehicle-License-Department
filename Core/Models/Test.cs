namespace Core.Models
{
    public class Test
    {
        public int Id { get; set; }
        public int TestAppointmentId { get; set; }
        public bool Result { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserId { get; set; }
    }
}
