using System;

namespace ScoutManager.Models
{
    public class Council
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
    }
}