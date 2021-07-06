namespace ASPNETCoreDI.Data
{
    public class Player
    {
        public int Id { get; set; }
        public string Namn { get; set; }
        public int JerseyNumber { get; set; }

        public int Age { get; set; }

        public Position PlayerPosition { get; set; }
        public enum Position
        {
            Goalie,
            Defence,
            Forward
        }
    }
}