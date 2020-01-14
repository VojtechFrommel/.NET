using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangman.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hangman.Pages
{
    public class GamePageModel : PageModel
    {
        public IData data;
        public string guess;
        private char[] charArray;
        public GamePageModel(IData data)
        {
            this.data = data;
        }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            charArray = guess.ToCharArray();
            //foreach - porovnej chararray s hádaným slovem. Pokud je chararray.len > 1 a netrefí se, tak hráč vypadne
            foreach(char ch in charArray)
            {

            }
        }
    }
}