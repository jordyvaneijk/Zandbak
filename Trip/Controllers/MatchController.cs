using System;
using System.Collections.Generic;
using System.Web.Http;
using Trip.Models;

namespace Trip.Controllers
{
    public class MatchController : ApiController
    {
        [HttpGet]
        [ActionName("GetMatches")]
        public List<MatchContainer> GetMatches([FromUri]MatchRequest matchRequest)
        {
            var results = new List<MatchContainer>
                {
                    new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },new MatchContainer
                        {
                            FlightId = "KL736_2015.05.19",
                            DepartureDateTime = new DateTime(2015,5,19),
                            Matches = new List<Match>
                                {
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "eijk", GivenName = "jordy",PassengerId = Guid.NewGuid()},
                                    new Match{FlightId = "KL736_2015.05.19",Surname = "paragh", GivenName = "roger",PassengerId = Guid.NewGuid()},
                                }
                        },
                };

            return results;
        }
    }
}
