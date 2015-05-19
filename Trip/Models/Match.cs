using System;

namespace Trip.Models
{
    public class Match
    {
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string FlightId { get; set; }
        public Guid PassengerId { get; set; }
    }
}

