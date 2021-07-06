using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreDI.Data
{
    public class DataInitializer
    {
        public static void SeedData(ApplicationDbContext dbContext)
        {
            dbContext.Database.Migrate();
            SeedTeams(dbContext);
            SeedPlayers(dbContext);

        }

        private static void SeedPlayers(ApplicationDbContext dbContext)
        {
            var treKronor = dbContext.Teams.Include(r => r.Players).First(e => e.Namn == "Tre Kronor");
            var finland = dbContext.Teams.Include(r => r.Players).First(e => e.Namn == "Finland");
            if (!treKronor.Players.Any(r => r.Namn == "Mats Sundin"))
                treKronor.Players.Add(new Player
                {
                    Namn = "Mats Sundin",
                    JerseyNumber = 13,
                    Age = 49,
                    PlayerPosition = Player.Position.Forward
                });


            if (!treKronor.Players.Any(r => r.Namn == "Peter Forsberg"))
                treKronor.Players.Add(new Player
                {
                    Namn = "Peter Forsberg",
                    JerseyNumber = 21,
                    Age = 49,
                    PlayerPosition = Player.Position.Forward
                });

            if (!finland.Players.Any(r => r.Namn == "Jari Kurri"))
                finland.Players.Add(new Player
                {
                    Namn = "Jari Kurri",
                    JerseyNumber = 21,
                    Age = 49,
                    PlayerPosition = Player.Position.Forward
                });

            dbContext.SaveChanges();
        }

        private static void SeedTeams(ApplicationDbContext dbContext)
        {
            if (!dbContext.Teams.Any(r => r.Namn == "Tre Kronor"))
                dbContext.Teams.Add(new Team { FoundedYear = 1900, Namn = "Tre Kronor" });
            if (!dbContext.Teams.Any(r => r.Namn == "Finland"))
                dbContext.Teams.Add(new Team { FoundedYear = 1901, Namn = "Finland" });
            dbContext.SaveChanges();
        }

    }
}