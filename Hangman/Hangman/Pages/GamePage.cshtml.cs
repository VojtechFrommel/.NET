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
        private char[] CharArray;
        private int index;
        private bool guessed;
        [BindProperty]
        public string Guess { get; set; }
        
        public GamePageModel(IData data)
        {
            this.data = data;
        }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            Guess = "";
            guessed = false;
            index = 0;
            CharArray = Guess.ToCharArray();
            //foreach - porovnej chararray s hádaným slovem. Pokud je chararray.len > 1 a netrefí se, tak hráč vypadne
            foreach(char ch in CharArray)
            {
                if (CharArray.Length == 1)
                {
                    foreach (char c in data.WordToGuess.ToCharArray())
                    {
                        if (ch == c)
                        {
                            data.HelpGuessArray[index] = true;
                            guessed = true;
                        }
                    }
                }
                if (CharArray.Length > 1)
                {
                    if (Guess == data.WordToGuess)
                    {
                        data.Winner = data.Players[data.PlayerIndex].Nickname;
                        guessed = true;
                        //naplnění true hodnotami
                        for (int i = 0; i < data.HelpGuessArray.Length; i++)
                        {
                            data.HelpGuessArray[i] = true;
                        }
                    }
                }
                if (guessed == false)
                {
                    //přičti chybu
                    data.Players[data.PlayerIndex].Mistakes += 1;
                    //přepni hráče
                    if (data.PlayerIndex == data.Players.Count) data.PlayerIndex = 0;
                    else data.PlayerIndex++ ;
                }
                index++;
            }
            //přidání do alreadytried
            //if()
            //foreach(char )
            //data.TriedChars.Add(ch);
        }
    }
}