using System.Collections;

namespace SD_340_Lab_Winnipeg_Transit.Models
{
    public class Route
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public Direction Direction { get; set; }
        public bool RampAccessible { get; set; }
        public bool BicycleAccessible { get; set; }
        public Queue StopSchedule { get; set; }
    }
}
