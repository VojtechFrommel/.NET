using Hangman.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman.Models
{
    public class Data : IData
    {

        #region Public fields
        public string WordToGuess { get { return _wordToGuess; } set { _wordToGuess = value; } }
        public string[] WordsToGuess { get { return _wordsToGuess; } set { _wordsToGuess = value; } }
        public bool[] HelpGuessArray { get { return _helpGuessArray; } set { _helpGuessArray = value; } }
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public List<char> TriedChars { get { return _triedChars; } set { _triedChars = value; } }
        public List<string> TriedWords { get { return _triedWords; } set { _triedWords = value; } }
        public int PlayerIndex { get { return _playerIndex; } set { _playerIndex = value; } }
        public int NumOfPlayers { get { return _numOfPlayers; } set { _numOfPlayers = value; } }
        public string Winner { get { return _winner; } set { _winner = value; } }
        #endregion Public fields

        #region Private fields
        private string _wordToGuess;
        private string[] _wordsToGuess;
        private bool[] _helpGuessArray;
        private string _winner;
        private int _numOfPlayers;
        private int _playerIndex;
        private List<char> _triedChars;
        private List<string> _triedWords;
        private List<Player> _players;
        #endregion Private fields

        public Data()
        {
            _players = new List<Player>();
            _wordsToGuess = new string[] { "abyss" };/*, "void", "soul", "boggle", "ivory", "fjord" };*/
            _triedChars = new List<char>();
            _triedWords = new List<string>();
            _players = new List<Player>();
        }
    }
}
