using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangman.Models;
using Hangman.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hangman.Pages
{
    public class EnterPageModel : PageModel
    {
        public IData data;
        private List<string> names = new List<string>();
        public EnterPageModel(IData data)
        {
            this.data = data;
        }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            //naplnit names

            //uložit players
            for (int i = 0; i < data.NumOfPlayers; i++)
            {
                data.Players.Add(new Player(names[i], 0));
            }
            //přepnout na game stránku
            RedirectToPage("GamePage");
        }
    }
}