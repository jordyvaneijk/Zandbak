using System;
using System.Collections.Generic;

namespace Trip.Models
{
    public class MatchContainer
    {
        public string FlightId { get; set; }
        public List<Match> Matches { get; set; }
        public DateTime DepartureDateTime { get; set; }
    }
}