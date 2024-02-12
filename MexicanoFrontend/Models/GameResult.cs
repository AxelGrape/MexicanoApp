using Mexicano.Mexicano;
using Microsoft.AspNetCore.Components;

namespace MexicanoFrontend.Models
{
    public class GameResult(Player activePlayer, Player opponent, int maxScore)
    {
        public Player ActivePlayer { get; set; } = activePlayer;
        public Player Opponent { get; set; } = opponent;
        public int MaxScore { get; } = maxScore;
    }
}
