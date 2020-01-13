using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman.Models
{
    public static class Data
    {
        public static string WordToGuess { get; set; }
        public static string Winner { get; set; }
        public static List<char> TriedChars = new List<char>();
    }
}
