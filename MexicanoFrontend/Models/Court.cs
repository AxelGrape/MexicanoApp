﻿namespace MexicanoFrontend.Models
{
    using Mexicano.Mexicano;

    public class Court
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;

        private List<Player> Players = new List<Player>();  

        public List<Player> GetPlayers() 
        {
            return Players;
        }    

        public bool ClearPlayers()
        {
			Players.Clear();
			return true;
		}

        public bool AddPlayersToCourt(Player p)
        {
            if(Players.Count < 4)
            {
                Players.Add(p);
                return true;
            }
            else { return false; }
            
        }
    }
}
