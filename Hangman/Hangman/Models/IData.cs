using Hangman.ViewModels;
using System;
using System.Collections.Generic;

namespace Hangman.Models
{
    public interface IData
    {
        List<string> WordsToGuess { get; set; }
    }
}
