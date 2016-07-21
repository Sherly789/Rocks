using Nancy;
using Rock.Objects;

public class HomeModule : NancyModule
{
  public HomeModule()
  {
    Get["/"] =_=> {
      return View["index.cshtml"];
    };

    Post["/results"] = _ => {
      Game testGame = new Game("player1","player2");
      string testRandomPlayer1 = testGame.Random1();
      string testRandomPlayer2 = testGame.Random2();
      testGame.SetPlayer1(testRandomPlayer1);
      testGame.SetPlayer2(testRandomPlayer2);
      // string resultCompare = testGame.Compare(testRandomPlayer1, testRandomPlayer2);

      return View["results.cshtml", testGame.Compare(testRandomPlayer1, testRandomPlayer2)];
    };

  }
}
