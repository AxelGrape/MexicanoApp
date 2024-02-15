using Mexicano.Mexicano;
using MexicanoFrontend.Models;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MexicanoFrontent.Test.Mocks
{
	internal class MockModels
	{

		public static List<Court> GetSampleCourtList(int amountOfCourts = 2)
		{
			var courts = Substitute.For<List<Court>>();
			for (int i = 0; i < amountOfCourts; i++)
			{
				var newCourt = Substitute.For<Court>();
				newCourt.Name = "court" + i.ToString();
				courts.Add(newCourt);
			}
			return courts;
		}

		public static List<Player> GetSamplePlayerList(int amountOfPlayers = 8)
		{
			var players = Substitute.For<List<Player>>();
			for (int i = 0; i < amountOfPlayers; i++)
			{
				var newPlayer = Substitute.For<Player>();
				newPlayer.Name = "player" + i.ToString();
				players.Add(newPlayer);
			}
			return players;
		}
	}
}
