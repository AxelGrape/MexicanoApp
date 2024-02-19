using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MexicanoFrontend.Models;
using Mexicano.Mexicano;

namespace MexicanoFrontent.Test.ModelTests
{
	public class PlayerModelUnitTest
	{
		[Fact]
		public void CopyPlayer_CopyOriginalPlayer_ReturnDifferentPlayer()
		{
			Player originalPlayer = new Player { Name = "Olle"};

			Player copyPlayer = originalPlayer.CopyPlayer();
			copyPlayer.Points = 10;

			Assert.False(copyPlayer.Equals(originalPlayer));	
		}
	}
}
