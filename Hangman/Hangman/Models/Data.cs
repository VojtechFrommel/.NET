using Hangman.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman.Models
{
    public class Data : IData
    {
        private string _wordToGuess { get; set; }
        public string WordToGuess { get { return _wordToGuess; } set { _wordToGuess = value; } }
        private string _winner { get; set; }
        public string Winner { get { return _winner; } set { _winner = value; } }
        private int _numOfPlayers { get; set; }
        public int NumOfPlayers { get { return _numOfPlayers; } set { _numOfPlayers = value; } }
        private int _playerIndex { get; set; }// = 0;
        public int PlayerIndex { get { return _playerIndex; } set { _playerIndex = value; } }
        private List<char> _triedChars { get; set; }
        public List<char> TriedChars { get { return _triedChars; } set { _triedChars = value; } }
        private List<Player> _players { get; set; }
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public Data()
        {
            _wordToGuess = WordToGuess;
            _numOfPlayers = NumOfPlayers;
            _players = new List<Player>();
        }
    }
}
