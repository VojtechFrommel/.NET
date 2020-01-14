﻿using System;
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
        public GamePageModel(IData data)
        {
            this.data = data;
        }
        public void OnGet()
        {

        }
        public void OnPost()
        { 
        
        }
    }
}