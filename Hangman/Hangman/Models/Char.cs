using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman.Models
{
    public class Char
    {
        public char Pismeno { get; set; }
        public bool IsVisible { get; set; }

        public Char(char pismeno, bool isVisible)
        {
            Pismeno = pismeno;
            IsVisible = isVisible;
        }
    }
}
