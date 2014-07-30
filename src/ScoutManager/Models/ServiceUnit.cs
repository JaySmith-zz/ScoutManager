using System;

namespace ScoutManager.Models
{
    public class ServiceUnit
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public DateTime Created { get; set; }
    }
}