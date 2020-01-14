﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Hangman.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public int numOfPlayers;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            if (numOfPlayers <= 0) return;
            if (numOfPlayers > 3) return;
            else
            {
                Models.Data.NumOfPlayers = numOfPlayers;
                RedirectToPage("EnterPage");
            }
        }
    }
}