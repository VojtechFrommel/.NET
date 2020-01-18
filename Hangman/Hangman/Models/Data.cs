using Hangman.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman.Models
{
    public class Data : IData
    {

        public Data()
        {
            WordsToGuess = new List<string> { "abyss" , "void", "soul", "boggle", "ivory", "fjord" };
        }

        public List<string> WordsToGuess { get; set; }
    }
}
