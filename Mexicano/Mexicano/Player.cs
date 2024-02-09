namespace Mexicano.Mexicano
{
    public class Player
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = String.Empty;
        public int Points { get; set; } = 0;

        public Player CopyPlayer()
        {
            return new Player { Name = Name, Id = Id, Points = 0 };
        }
    }
}
