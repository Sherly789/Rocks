using System;
namespace Rock
{
  // a class that defines a Game object
  public class Game
  {
    // properties
    private string _player1;


    // constructors, getters and setters
    public Game(string player1)
    {
      _player1 = player1;
    }

    public string GetPlayer1()
    {
      return _player1;
    }

    public void SetPlayer1(string player1){
      _player1 = player1;
    }
    // other methods

  }
}
