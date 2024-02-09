namespace Mexicano.Mexicano
{
    internal static class Driver
    {

        public static List<Player> NewGame(List<Player> players)
        {
            return GenerateNewGame(players);
        }

        public static List<Player> NewRound(List<Player> players)
        {
            return GenerateNewRound(players);
        }

        private static List<Player> GenerateNewGame(List<Player> players)
        {
            if (!ConfirmSize(players.Count))
            {
                //TODO: Add correct exception
                throw new Exception();
            }
            ShuffleMe<Player>(players);
            return players;
        }

        private static void ShuffleMe<T>(this IList<T> list)
        {
            Random random = new Random();
            int n = list.Count;

            for (int i = list.Count - 1; i > 1; i--)
            {
                int rnd = random.Next(i + 1);

                T value = list[rnd];
                list[rnd] = list[i];
                list[i] = value;
            }
        }

        private static bool ConfirmSize(int amountOfPlayers)
        {
            return amountOfPlayers % 4 == 0;
        }

        private static List<Player> GenerateNewRound(List<Player> currentScore)
        {
            if(!ConfirmSize(currentScore.Count))
            {
                //TODO: Add correct exception
                throw new Exception();
            }

            List<Player> sortedRound = currentScore.OrderByDescending(p => p.Points).ToList();
            List<Player> newRound = new List<Player>(); 
            for (int i = 0; i < currentScore.Count; i+=4)
            {
                newRound.Add(sortedRound[i]);
                newRound.Add(sortedRound[i+2]);
                newRound.Add(sortedRound[i + 1]);
                newRound.Add(sortedRound[i + 3]);
            }

            return newRound;
        }
    }
}
