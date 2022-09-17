namespace SD_340_Lab_Winnipeg_Transit.Models
{
    public class ScheduledStop
    {
        public int Id { get; set; }
        public Stop Stop { get; set; }
        public Route Route { get; set; }
        public DateTime ScheduledArrival { get; set; }
    }
}
