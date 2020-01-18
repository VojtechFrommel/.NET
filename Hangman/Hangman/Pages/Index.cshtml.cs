using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Hangman.Models;
using Hangman.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Hangman.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public HangmanService hg;

        public IndexModel(ILogger<IndexModel> logger, HangmanService hangman)
        {
            _logger = logger;
            this.hg = hangman;
            hg.Load();
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            hg.Save();
            return RedirectToPage("GamePage");
        }
    }
}
