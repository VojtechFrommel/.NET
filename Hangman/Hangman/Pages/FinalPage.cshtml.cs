using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangman.Models;
using Hangman.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hangman.Pages
{
    public class FinalPageModel : PageModel
    {
        public HangmanService hg;
        public FinalPageModel(HangmanService hangman)
        {
            this.hg = hangman;
            hg.Load();
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            hg.NewGame();
            hg.Save();
            return RedirectToPage("Index");
        }
    }
}