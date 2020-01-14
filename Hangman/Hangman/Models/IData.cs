using System;
using System.Collections.Generic;

namespace Hangman.Models
{
    public interface IData
    {
        string WordToGuess { get; set; }
        string Winner { get; set; }
        int NumOfPlayers { get; set; }
        List<char> TriedChars { get; set; }
    }
}
