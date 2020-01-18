using Hangman.ViewModels;
using System;
using System.Collections.Generic;

namespace Hangman.Models
{
    public interface IData
    {
        //string WordToGuess { get; set; }
        List<string> WordsToGuess { get; set; }
        //bool[] HelpGuessArray { get; set; }
        //string Winner { get; set; }
        //int NumOfPlayers { get; set; }
        //List<char> TriedChars { get; set; }
        //List<string> TriedWords { get; set; }
        //List<Player> Players { get; set; }
        //int PlayerIndex { get; set; }
    }
}
