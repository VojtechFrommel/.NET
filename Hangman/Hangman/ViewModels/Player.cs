using Hangman.Models;
using System;
using System.Collections.Generic;

namespace Hangman.ViewModels
{
    public class Player
    {
        public Player(string nickname, int mistakes, IData data)
        {
            Nickname = nickname;
            Mistakes = mistakes;
        }
        public string Nickname { get; set; }
        public int Mistakes { get; set; }
    }
}