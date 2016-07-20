using System;
using System.Collections.Generic;

namespace Rock
{
  // a class that defines a Game object
  public class Game
  {
    // properties
    private string _player1;
    private string _player2;

    // constructors, getters and setters
    public Game(string player1, string player2)
    {
      _player1 = player1;
      _player2 = player2;
    }

    public string GetPlayer1()
    {
      return _player1;
    }

    public void SetPlayer1(string player1){
      _player1 = player1;
    }

    public string GetPlayer2()
    {
      return _player2;
    }

    public void SetPlayer2(string player2){
      _player2 = player2;
    }
    // other methods
    public string Random(string player1) {
      string[] randomStrings = { "Rock", "Paper", "Scissors" };
      // string randomReturn = randomStrings[Math.floor(Math.random()*randomStrings.Length)];
      string randomReturn = randomStrings[2];
      return randomReturn;

    }


    // public string Compare(string player1, string player2) {
    //   if (_player1 == "Rock" && _player2 == "Scissors")
    //   {
    //     return "player1 wins with Rock";
    //   }
    //   else if (_player1 == "Rock" && _player2 == "Paper")
    //   {
    //     return "player2 wins with Paper";
    //   }
    //   else if (_player1 == "Paper" && _player2 == "Scissors")
    //   {
    //     return "player2 wins with Scissors";
    //   }
    //   else if (_player1 == _player2 )
    //   {
    //     return "It's a draw";
    //   }
    //
    //   return "";
    // }

  }
}
