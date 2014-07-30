using System;
using System.Collections.Generic;

namespace ScoutManager.Models
{
    public class Leader
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastLogon { get; set; }
        public string Status { get; set; }

        public string Password { get; set; }
    }
}