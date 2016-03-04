using LooplessProgramming.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooplessProgramming
{
    public class SampleData
    {
        public const string QuickReactionFleet = "Quick reaction fleet";
        public const string HomeFleet = "Home fleet";
        public List<SpaceWarship> Ships { get; private set; }
        public Dictionary<string, Fleet> Fleets { get; private set; }
        public List<Person> Commanders { get; private set; }

        public SampleData()
        {
            #region creating ships
            Ships = new List<SpaceWarship>
            {
                new SpaceWarship
                {
                    Name = "Santa Maria",
                    Captain = new Person
                    {
                        Name = "Christopher Columbus",
                        YearsOfService = 35
                    },
                    ShipClass = WarshipClass.Scout,
                    Crew = 223,
                },

                new SpaceWarship
                {
                    Name = "New Cracow",
                    Captain = new Person
                    {
                        Name = "Zygmunt Wielki",
                        YearsOfService = 15,
                    },
                    ShipClass = WarshipClass.Cruiser,
                    Crew = 2088,
                },

                new SpaceWarship
                {
                    Name = "Steel Gingerbread",
                    Captain = new Person
                    {
                        Name = "Nicolaus Copernicus",
                        YearsOfService = 32,
                    },
                    ShipClass = WarshipClass.Cruiser,
                    Crew = 2217,
                },

                new SpaceWarship
                {
                    Name = "Radioactivity",
                    Captain = new Person
                    {
                        Name = "madam Curie",
                        YearsOfService = 22,
                    },
                    ShipClass = WarshipClass.Cruiser,
                    Crew = 1211,
                },

                new SpaceWarship
                {
                    Name = "The Martian",
                    Captain = new Person
                    {
                        Name = "Mark Watney",
                        YearsOfService = 14,
                    },
                    ShipClass = WarshipClass.Cruiser,
                    Crew = 1510,
                },


                new SpaceWarship
                {
                    Name = "Rama",
                    Captain = new Person
                    {
                        Name = "Arthur Clarke",
                        YearsOfService = 54,
                    },
                    ShipClass = WarshipClass.Battleship,
                    Crew = 5410,
                },

                new SpaceWarship
                {
                    Name = "The Foundation",
                    Captain = new Person
                    {
                        Name = "Isaac Asimov",
                        YearsOfService = 71
                    },
                    ShipClass = WarshipClass.Battleship,
                    Crew = 3111,
                },

                new SpaceWarship
                {
                    Name = "Clojure",
                    Captain = new Person
                    {
                        Name = "Rich Hickey",
                        YearsOfService = 27,
                    },
                    ShipClass = WarshipClass.Destroyer,
                    Crew = 410,
                },

                new SpaceWarship
                {
                    Name = "Scala",
                    Captain = new Person
                    {
                        Name = "Martin Odersky",
                        YearsOfService = 46,
                    },
                    ShipClass = WarshipClass.Destroyer,
                    Crew = 768,
                },

                new SpaceWarship
                {
                    Name = "Fsharp",
                    Captain = new Person
                    {
                        Name = "Don Syme",
                        YearsOfService = 31,
                    },
                    ShipClass = WarshipClass.Destroyer,
                    Crew = 512,
                },

                new SpaceWarship
                {
                    Name = "JavaScript",
                    Captain = new Person
                    {
                        Name = "Brendan Eich",
                        YearsOfService = 42,
                    },
                    ShipClass = WarshipClass.Destroyer,
                    Crew = 988,
                },

                new SpaceWarship
                {
                    Name = "Erlang",
                    Captain = new Person
                    {
                        Name = "Joe Armstrong",
                        YearsOfService = 50,
                    },
                    ShipClass = WarshipClass.Destroyer,
                    Crew = 579,
                },

                new SpaceWarship
                {
                    Name = "Perl",
                    Captain = new Person
                    {
                        Name = "Larry Wall",
                        YearsOfService = 47,
                    },
                    ShipClass = WarshipClass.Destroyer,
                    Crew = 373,
                }
            };
            #endregion
            #region creating fleets
            Fleets = new Dictionary<string,Fleet>();
            
            Fleets[HomeFleet] = 
                        new Fleet
                        {
                            Name = HomeFleet,
                            Commander = new Person
                            {
                                Name = "admiral Cro Magnon",
                                YearsOfService = 40000
                            },
                            Ships = this.Ships

                        };

            Fleets[QuickReactionFleet] = 
                        new Fleet
                        {
                            Name = QuickReactionFleet,
                            Commander = new Person
                            {
                                Name = "Deep Blue AI",
                                YearsOfService = 20
                            },
                            Ships = this.Ships.Where(s => s.Crew < 800)
                        };



            #endregion
            #region creating commanders

            //This collection contains all captains and fleet commanders in a single list
            Commanders =
                Ships.Select(ship => ship.Captain).ToList();
            Commanders.AddRange(Fleets.Select(pair => pair.Value.Commander));
            
            #endregion
        }

    }
}
