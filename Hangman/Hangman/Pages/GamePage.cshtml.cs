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
        private int winCharCounter;
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
            guessed = false;
            //index = 0;
            winCharCounter = 0;
            CharArray = Guess.ToCharArray();

            if (CharArray.Length == 0)
            {
                return;
            }

            //Logika-each
            foreach(char ch in CharArray)
            {
                //Pokud je to CHAR
                if (CharArray.Length == 1)
                {
                    //porovnání
                    foreach (char c in data.WordToGuess.ToCharArray())
                    {
                        if (ch == c)
                        {
                            data.HelpGuessArray[index] = true;
                            guessed = true;
                        }
                        index++;
                    }
                    //uhádl hráč už všechny?
                    for (int i = 0; i < data.HelpGuessArray.Length; i++)
                    {
                        if (data.HelpGuessArray[i] == true)
                        {
                            winCharCounter++;
                        } 
                    }
                    if (winCharCounter == data.HelpGuessArray.Length)
                    {
                        data.Winner = data.Players[data.PlayerIndex].Nickname;
                        guessed = true;
                    }
                    //přepni hráče
                    //if (data.PlayerIndex == data.Players.Count-1) data.PlayerIndex = 0;
                    //else if (data.PlayerIndex != data.Players.Count - 1) data.PlayerIndex++;
                }
                //Pokud je to STRING
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
                    //přičti chybu nebo odeber hráče
                    data.Players[data.PlayerIndex].Mistakes += 1;
                    if (data.Players[data.PlayerIndex].Mistakes == 10)
                    {
                        data.Players.RemoveAt(data.PlayerIndex);
                        data.NumOfPlayers -= 1;
                    } 
                }
            }
            //přepni hráče
            if (data.PlayerIndex == data.Players.Count - 1) data.PlayerIndex = 0;
            else data.PlayerIndex++;
            //přidání do alreadytried
            if (CharArray.Length == 1) data.TriedChars.Add(CharArray[0]);
            if (CharArray.Length > 1)
            {
                data.TriedWords.Add(Guess);
            }
            //
            //resetování hodnot
        }
    }
}