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

    // a method that returns a random string from a list of three strings
    public string Random1() {
      string[] randomStrings1 = { "Rock", "Paper", "Scissors" };
      string randomReturn1 = randomStrings1[new Random().Next(0,randomStrings1.Length)];
      return randomReturn1;
    }

    // a method that returns a random string from a list of three strings
    public string Random2() {
      string[] randomStrings2 = { "Paper", "Scissors", "Rock"  };
      string randomReturn2 = randomStrings2[new Random().Next(0,randomStrings2.Length)];
      return randomReturn2;
    }

    // a method that compares two strings and returns a winner
    public string Compare(string player1, string player2) {
      if (player1 == "Rock" && player2 == "Scissors")
      {
        return "player1 wins with Rock";
      }
      else if (player1 == "Rock" && player2 == "Paper")
      {
        return "player2 wins with Paper";
      }
      else if (player1 == "Paper" && player2 == "Scissors")
      {
        return "player2 wins with Scissors";
      }
      else if (player1 == player2 )
      {
        return "It's a draw";
      }
      return "This dropped through";
    }
  }
}
