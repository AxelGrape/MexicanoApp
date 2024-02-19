using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MexicanoFrontend.Models;
using MexicanoFrontent.Test.Mocks;

namespace MexicanoFrontent.Test
{
	public class CourtTest
	{
		[Fact]
		public void CourtsHaveUniqueIds()
		{
			//Arrange
			var courts = MockModels.GetSampleCourtList(2);
			// Act
			var courtId1 = courts[0].Id;
			var courtId2 = courts[1].Id;
			// Assert
			Assert.NotEqual(courtId1, courtId2);
		}

		[Fact]
		public void AddPlayersToCourt_WithFourPlayers_ReturnsTrue()
		{
			//Arrange
			var court = MockModels.GetSampleCourtList(1).First();
			var players = MockModels.GetSamplePlayerList(4);
			// Act
			var result = false;
			foreach (var player in players)
			{
				result = court.AddPlayersToCourt(player);
				if (result is false) break;
			}
			// Assert
			Assert.True(result);
		}

		[Fact]
		public void AddPlayersToCourt_WithFivePlayers_ReturnsFalse()
		{
			//Arrange
			var court = MockModels.GetSampleCourtList(1).First();
			var players = MockModels.GetSamplePlayerList(5);

			// Act
			var result = false;
			foreach (var player in players)
			{
				result = court.AddPlayersToCourt(player);
				if (result is false) break;
			}
			// Assert
			Assert.False(result);
		}


		[Fact]
		public void GetPlayers_WithPlayers_ReturnsListOfPlayers()
		{
			//Arrange
			var court = MockModels.GetSampleCourtList(1).First();
			var players = MockModels.GetSamplePlayerList(4);
			foreach (var player in players)
			{
				court.AddPlayersToCourt(player);
			}
			// Act
			var playersResult = court.GetPlayers();
			// Assert
			Assert.Equal(4, playersResult.Count);
		}

		[Fact]
		public void GetPlayers_NoPlayers_ReturnsEmptyListOfPlayers()
		{
			//Arrange
			var court = new Court();
			// Act
			var playersResult = court.GetPlayers();
			// Assert
			Assert.Empty(playersResult);
		}

		[Fact]
		public void ClearPlayers_WithPlayers_DoesClearPlayers()
		{
			//Arrange
			var court = MockModels.GetSampleCourtList(1).First();
			var players = MockModels.GetSamplePlayerList(4);
			foreach (var player in players)
			{
				court.AddPlayersToCourt(player);
			}
			// Act
			court.ClearPlayers();
			var playersResult = court.GetPlayers();
			// Assert
			Assert.Empty(playersResult);
		}
	}
}
