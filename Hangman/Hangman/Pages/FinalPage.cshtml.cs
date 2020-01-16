using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangman.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hangman.Pages
{
    public class FinalPageModel : PageModel
    {
        public IData data;
        public FinalPageModel(IData data)
        {
            this.data = data;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            data.HelpGuessArray = new bool[0];
            data.NumOfPlayers = 0;
            data.PlayerIndex = 0;
            data.Players.Clear();
            data.TriedChars.Clear();
            data.TriedWords.Clear();
            data.Winner = null;
            data.WordToGuess = null;

            return RedirectToPage("Index");
        }
    }
}