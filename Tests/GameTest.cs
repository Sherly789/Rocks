using Xunit;
using System;
namespace Rock
{
  public class GameTest
  {
    // [Fact]
    // public void Game_2PlayerInput_true()
    // {
    //   // Arrange
    //   string player1 = "Rock";
    //   string player2 = "Scissors";
    //   Game testGame = new Game(player1, player2);
    //   // Act
    //   string testPlayer1 = testGame.GetPlayer1();
    //   string testPlayer2 = testGame.GetPlayer2();
    //   // Assert
    //   Assert.Equal(player1, testPlayer1);
    //   Assert.Equal(player2, testPlayer2);
    // }

    [Fact]
    public void Compare_2PlayerInput_true()
    {
      // Arrange
      string player1 = "Rock";
      string player2 = "Scissors";
      Game testGame = new Game(player1, player2);
      string testCompare = "player1 wins with Rock";
      // Act
      string comparePlayers =testGame.Compare(player1,player2);
      // Assert
      Assert.Equal(testCompare, comparePlayers);
    }
  }
}
