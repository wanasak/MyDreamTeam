using MyDreamTeam.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDreamTeam.Data
{
    public class MyDreamTeamSeedData : DropCreateDatabaseIfModelChanges<MyDreamTeamContext>
    {
        protected override void Seed(MyDreamTeamContext context)
        {
            GetClubs().ForEach(c => context.Clubs.Add(c));
            context.Commit();

            GetPositions().ForEach(p => context.Positions.Add(p));
            context.Commit();

            GetFootballers().ForEach(f => context.Footballers.Add(f));
            context.Commit();
        }

        private static List<Position> GetPositions()
        {
            return new List<Position>()
            {
                new Position
                {
                    Name = "Goal Keeper"
                },
                new Position
                {
                    Name = "Defender"
                },
                new Position
                {
                    Name = "Midfielder"
                },
                new Position
                {
                    Name = "Attacker"
                }
            };
        }

        private static List<Footballer> GetFootballers()
        {
            return new List<Footballer>()
            {
                new Footballer
                {
                    FirstName = "Manuel",
                    LastName = "Neuer",
                    Price = 30000000,
                    Image = "neuer.jpg",
                    PositionID = 1,
                    ClubID = 6
                },
                new Footballer
                {
                    FirstName = "David",
                    LastName = "Gea",
                    Price = 32500000,
                    Image = "gea.jpg",
                    PositionID = 1,
                    ClubID = 2
                },
                new Footballer
                {
                    FirstName = "Thibaut",
                    LastName = "Courtois",
                    Price = 27500000,
                    Image = "courtois.jpg",
                    PositionID = 1,
                    ClubID = 5
                },
                new Footballer
                {
                    FirstName = "David",
                    LastName = "Alaba",
                    Price = 35000000,
                    Image = "alaba.jpg",
                    PositionID = 2,
                    ClubID = 6
                },
                new Footballer
                {
                    FirstName = "Sergio",
                    LastName = "Ramos",
                    Price = 45000000,
                    Image = "ramos.jpg",
                    PositionID = 2,
                    ClubID = 9
                },
                new Footballer
                {
                    FirstName = "Diego",
                    LastName = "Godin",
                    Price = 30000000,
                    Image = "godin.jpg",
                    PositionID = 2,
                    ClubID = 8
                },
                new Footballer
                {
                    FirstName = "Thiago",
                    LastName = "Silva",
                    Price = 35000000,
                    Image = "silva.jpg",
                    PositionID = 2,
                    ClubID = 11
                },
                new Footballer
                {
                    FirstName = "Gerrard",
                    LastName = "Pique",
                    Price = 35000000,
                    Image = "pique.jpg",
                    PositionID = 2,
                    ClubID = 10
                },
                new Footballer
                {
                    FirstName = "Vincent",
                    LastName = "Kompany",
                    Price = 31000000,
                    Image = "kompany.jpg",
                    PositionID = 2,
                    ClubID = 1
                },
                new Footballer
                {
                    FirstName = "Dani",
                    LastName = "Alves",
                    Price = 25000000,
                    Image = "alves.jpg",
                    PositionID = 2,
                    ClubID = 10
                },
                new Footballer
                {
                    FirstName = "Mats",
                    LastName = "Hummels",
                    Price = 40000000,
                    Image = "hummels.jpg",
                    PositionID = 2,
                    ClubID = 6
                },
                new Footballer
                {
                    FirstName = "Jordi",
                    LastName = "Alba",
                    Price = 27000000,
                    Image = "alba.jpg",
                    PositionID = 2,
                    ClubID = 10
                },
                new Footballer
                {
                    FirstName = "Paul",
                    LastName = "Pogba",
                    Price = 99000000,
                    Image = "pogba.jpg",
                    PositionID = 3,
                    ClubID = 2
                },
                new Footballer
                {
                    FirstName = "Arturo",
                    LastName = "Vidal",
                    Price = 35000000,
                    Image = "vidal.jpg",
                    PositionID = 3,
                    ClubID = 6
                },
                new Footballer
                {
                    FirstName = "Yaya",
                    LastName = "Toure",
                    Price = 26000000,
                    Image = "toure.jpg",
                    PositionID = 3,
                    ClubID = 1
                },
                new Footballer
                {
                    FirstName = "Ivan",
                    LastName = "Rakitic",
                    Price = 25500000,
                    Image = "rakitic.jpg",
                    PositionID = 3,
                    ClubID = 10
                },
                new Footballer
                {
                    FirstName = "Sergio",
                    LastName = "Busquets",
                    Price = 31000000,
                    Image = "busquets.jpg",
                    PositionID = 3,
                    ClubID = 10
                },
                new Footballer
                {
                    FirstName = "Mesut",
                    LastName = "Ozil",
                    Price = 27000000,
                    Image = "ozil.jpg",
                    PositionID = 3,
                    ClubID = 4
                },
                new Footballer
                {
                    FirstName = "Marco",
                    LastName = "Reus",
                    Price = 34000000,
                    Image = "reus.jpg",
                    PositionID = 3,
                    ClubID = 7
                },
                new Footballer
                {
                    FirstName = "David",
                    LastName = "Silva",
                    Price = 28500000,
                    Image = "silva.jpg",
                    PositionID = 3,
                    ClubID = 1
                },
                new Footballer
                {
                    FirstName = "Philippe",
                    LastName = "Coutinho",
                    Price = 31500000,
                    Image = "coutinho.jpg",
                    PositionID = 3,
                    ClubID = 3
                },
                new Footballer
                {
                    FirstName = "Toni",
                    LastName = "Kroos",
                    Price = 35500000,
                    Image = "kroos.jpg",
                    PositionID = 3,
                    ClubID = 9
                },
                new Footballer
                {
                    FirstName = "Lionel",
                    LastName = "Messi",
                    Price = 100000000,
                    Image = "messi.jpg",
                    PositionID = 4,
                    ClubID = 10
                },
                new Footballer
                {
                    FirstName = "Cristiano",
                    LastName = "Ronaldo",
                    Price = 85000000,
                    Image = "ronaldo.jpg",
                    PositionID = 4,
                    ClubID = 9
                },
                new Footballer
                {
                    FirstName = "Neymar",
                    LastName = "Junior",
                    Price = 95000000,
                    Image = "junior.jpg",
                    PositionID = 4,
                    ClubID = 10
                },
                new Footballer
                {
                    FirstName = "Luis",
                    LastName = "Suarez",
                    Price = 70000000,
                    Image = "suarez.jpg",
                    PositionID = 4,
                    ClubID = 10
                },
                new Footballer
                {
                    FirstName = "Sergio",
                    LastName = "Aguero",
                    Price = 55000000,
                    Image = "aguero.jpg",
                    PositionID = 4,
                    ClubID = 1
                },
                new Footballer
                {
                    FirstName = "Alexis",
                    LastName = "sanchez",
                    Price = 60500000,
                    Image = "sanchez.jpg",
                    PositionID = 4,
                    ClubID = 4
                },
                new Footballer
                {
                    FirstName = "Gareth",
                    LastName = "Bele",
                    Price = 50500000,
                    Image = "bele.jpg",
                    PositionID = 4,
                    ClubID = 9
                },
            };
        }

        private static List<Club> GetClubs()
        {
            return new List<Club>()
            {
                new Club
                {
                    Name = "Manchester City", OfficialName = "Manchester City FC", City = "Manchester", Country = "England", League = "Premier League"
                },
                new Club
                {
                    Name = "Manchester United", OfficialName = "Manchester United FC", City = "Manchester", Country = "England", League = "Premier League"
                },
                new Club
                {
                    Name = "Liverpool", OfficialName = "Liverpool FC", City = "Liverpool", Country = "England", League = "Premier League"
                },
                new Club
                {
                    Name = "Arsenal", OfficialName = "Arsenal FC", City = "London", Country = "England", League = "Premier League"
                },
                new Club
                {
                    Name = "Chelsea", OfficialName = "Chelsea FC", City = "London", Country = "England", League = "Premier League"
                },
                new Club
                {
                    Name = "Bayern Munchen", OfficialName = "FC Bayern Munchen", City = "Munchen", Country = "German", League = "Bundesliga"
                },
                new Club
                {
                    Name = "Borussia Dortmund", OfficialName = "BV Borussia 09", City = "Dortmund", Country = "German", League = "Bundesliga"
                },
                new Club
                {
                    Name = "Atletico Madrid", OfficialName = "Club Atletico de Mardrid", City = "Madrid", Country = "Sapin", League = "Primera Division"
                },
                new Club
                {
                    Name = "Real Madrid", OfficialName = "Real Madrid Club de Futbol", City = "Madrid", Country = "Sapin", League = "Primera Division"
                },
                new Club
                {
                    Name = "Bacelona", OfficialName = "FC Bacelona", City = "Bacelona", Country = "Sapin", League = "Primera Division"
                },
                new Club
                {
                    Name = "PSG", OfficialName = "Paris Saint-Germain", City = "Paris", Country = "France", League = "Ligue 1"
                },
            };
        }
    }
}
