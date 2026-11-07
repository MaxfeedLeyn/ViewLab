namespace ViewLab.Models;

public class TaskViewModel
{
    public class GreetingsViewModel
    {
        public string GreetingsName { get; set; }
        public string GreetingsMessage { get; set; }
        public DayOfWeek GreetingsDay { get; set; }
        public string TimeOfThePeriod {get; set;}
        public int Day {get; set;}
        public int Hour {get; set;}
        public int Minute {get; set;}
        public int Second {get; set;}
    }
}