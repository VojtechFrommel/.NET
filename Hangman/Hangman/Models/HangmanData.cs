using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman.Models
{
    public class HangmanData
    {
        public string WordToGuess { get; set; }
        public List<Char> chars { get; set; } = new List<Char>();
        public int Mistakes { get; set; }
        public List<string> Tried { get; set; }
    }
}
