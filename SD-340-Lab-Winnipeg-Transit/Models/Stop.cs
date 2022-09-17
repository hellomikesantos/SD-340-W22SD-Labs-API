namespace SD_340_Lab_Winnipeg_Transit.Models
{
    public class Stop
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public Direction Direction { get; set; }
        public List<Stop> StopSchedules { get; set; }
    }
}
