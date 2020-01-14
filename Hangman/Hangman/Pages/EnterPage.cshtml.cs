using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangman.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hangman.Pages
{
    public class EnterPageModel : PageModel
    {
        private IData data;
        public EnterPageModel(IData data)
        {
            this.data = data;
        }
        public void OnGet()
        {

        }
    }
}