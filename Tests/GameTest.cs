using Xunit;
using System;
namespace Rock
{
  public class GameTest
  {
    [Fact]
    public void Game_PlayerOneInput_true()
    {
      // Arrange
      string player1 = "Rock";
      Game testGame = new Game(player1);
      // Act
      string testPlayer1 = testGame.GetPlayer1();
      // Assert
      Assert.Equal(player1, testPlayer1);
    }
  }
}
