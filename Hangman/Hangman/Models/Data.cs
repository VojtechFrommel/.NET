using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman.Models
{
    public class Data : IData
    {
        private string _wordToGuess { get; set; }
        private string _winner { get; set; }
        private int _numOfPlayers { get; set; }
        private List<char> _triedChars { get; set; }
        public Data()
        {

        }
        public string WordToGuess { get { return _wordToGuess; } set { _wordToGuess = value; } }
        public string Winner { get { return _winner; } set { _winner = value; } }
        public int NumOfPlayers { get { return _numOfPlayers; } set { _numOfPlayers = value; } }
        public List<char> TriedChars { get { return _triedChars; } set { _triedChars = value; } }
    }
}
