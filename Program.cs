﻿using System;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.Start();
        }
    }

    class Game 
    {   
        string RockMove ="rock";
        string PaperMove ="paper";
        string ScissorsMove="scissors";
        public void Start()
        {
            Console.WriteLine("what is the name of the person playing the game?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            Console.WriteLine("Rock, Paper, or Scissors?");
            string userChoice = Console.ReadLine();
            Console.WriteLine($"You picked {userChoice}");

            var moveChooser = new GoodMoveChooser();
            string computerMove = moveChooser.ChooseMove();
            Console.WriteLine($"The computer picked {computerMove}");
            string result = CalculateGameResult(userChoice, computerMove);
            Console.WriteLine(result);
        }
        string CalculateGameResult(string humanMove, string computerMove)
        {

            string comparableHummanMove = ConvertToComparable(humanMove);
            string comparableComputerMove = ConvertToComparable(computerMove);

            if(comparableHummanMove == RockMove)
            {
                if (comparableComputerMove ==RockMove)
                {
                    return "Tie";
                }
                if (comparableComputerMove ==PaperMove)
                {
                    return "The computer wins!";
                }
                if (comparableComputerMove == ScissorsMove)
                {
                    return "You win!";
                }
            }
            if(comparableHummanMove ==PaperMove)
            {
                if (comparableComputerMove ==RockMove)
                {
                    return "You Win";
                }
                if (comparableComputerMove ==PaperMove)
                {
                    return "Tie";
                }
                if (comparableComputerMove == ScissorsMove)
                {
                    return "Computer wins";
                }
            }
            if(comparableHummanMove ==ScissorsMove)
            {
                if (comparableComputerMove ==RockMove)
                {
                    return "Computer wins";
                }
                if (comparableComputerMove ==PaperMove)
                {
                    return "You win";
                }
                if (comparableComputerMove == ScissorsMove)
                {
                    return "Tie";
                }
            }
            return $"Unknown move: {humanMove}";
        }
        string ConvertToComparable(string move)
        {
            return move.Trim().ToLower();
        }
    }
    class StupidMoveChooser
    {
        public string ChooseMove()
        {
            return "Rock";
        }
    }
    class GoodMoveChooser
    {
        public string ChooseMove()
        {
            var random = new Random();
            int randomNumber = random.Next(2);

            if(randomNumber== 0)
            {
                return "Rock";
            }
            if(randomNumber ==1)
            {
                return "Paper";
            }
            return "Scissors";
        }
    }
}
