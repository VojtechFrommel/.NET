using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Hangman.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Hangman.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IData data;
        public int numOfPlayers = 2;

        public IndexModel(ILogger<IndexModel> logger, IData data)
        {
            _logger = logger;
            this.data = data;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            Debug.Write(numOfPlayers);
            //if (Convert.ToInt32(numOfPlayers) <= 0 || Convert.ToInt32(numOfPlayers) > 3) return RedirectToPage("Index");
            //else
            //{
            //    data.NumOfPlayers = Convert.ToInt32(numOfPlayers);
            //    return RedirectToPage("EnterPage");
            //} 
            data.NumOfPlayers = numOfPlayers;
            return RedirectToPage("EnterPage");
        }
    }
}
