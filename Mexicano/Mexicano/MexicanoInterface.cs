using System.Text.Json;

namespace Mexicano.Mexicano
{
    public static class MexicanoInterface
    {

        private static List<Player> DeserializePlayerList(String PlayerString)
        {
            // TODO: Create correct exception
            return JsonSerializer.Deserialize<List<Player>>(PlayerString) ?? throw new Exception();
        }

        // Must have a list of players with id, names (and points)
        public static String StartMexicano(String PlayerString)
        {
            return JsonSerializer.Serialize(Driver.NewGame(DeserializePlayerList(PlayerString)));
        }

        // Must have a list of players with id, names (and points)
        public static String StartNewRound(String PlayerString) 
        {
            return JsonSerializer.Serialize(Driver.NewRound(DeserializePlayerList(PlayerString))); 
        }

    }
}
