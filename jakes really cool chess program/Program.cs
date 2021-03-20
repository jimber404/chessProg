using System;

namespace jakes_really_cool_chess_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Player myObj = new Player("JakeI", 1500);
        }
    }

    static void CalculateELO(ref Player playerOne, ref Player playerTwo, GameOutcome outcome)
    {
        int eloK = 32;

        int delta = (int)(eloK * ((int)outcome - playerOne.ExpectationToWin(playerTwo.Elo));

        playerOne.Elo += delta;
        playerTwo.Elo -= delta;
    }

    public class Player
    {
        private int gamesWon;
        private int gamesLost;
        private int elo;
        public string name;
        public Player(string nameIn,int eloIN)
        {
            name = nameIn;
            elo = eloIN;
        }

        public int Elo
        { get; set; }

        public double ExpectationToWin(int playerTwoRating)
        {
            return 1 / (1 + Math.Pow(10, (playerTwoRating - elo) / 400.0));
        }
    }
}
