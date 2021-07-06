using System.Collections.Generic;

namespace ASPNETCoreDI.Data
{
    public class Team
    {
        public int Id { get; set; }
        public string Namn { get; set; }
        public int FoundedYear { get; set; }

        public List<Player> Players { get; set; }
    }
}