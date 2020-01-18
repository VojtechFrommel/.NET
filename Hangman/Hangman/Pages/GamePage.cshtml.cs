using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangman.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hangman.Services;

namespace Hangman.Pages
{
    public class GamePageModel : PageModel
    {
        public HangmanService hg;
        private int index;
        private bool guessed;
        private bool redirect;
        [BindProperty]
        public string Guess { get; set; }
        
        public GamePageModel(HangmanService hangman)
        {
            this.hg = hangman;
            hg.Load();
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            hg.data.Tried.Add(Guess);
            redirect = hg.Guess(hg,Guess,guessed,index);
            hg.Save();
            if (redirect == true) return RedirectToPage("FinalPage");
            else return RedirectToPage("GamePage");
        }
    }
}