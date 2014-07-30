using System;

namespace ScoutManager.Models
{
    public class Troop
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public string MeetingLocation { get; set; }
        public string MeetingDay { get; set; }
        public string MeetingTime { get; set; }
        public string MeetingFrequency { get; set; }
    }
}