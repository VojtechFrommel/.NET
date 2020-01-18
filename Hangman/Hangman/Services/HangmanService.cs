using Hangman.Models;
using Hangman.Sessions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Char = Hangman.Models.Char;

namespace Hangman.Services
{
    public class HangmanService
    {
        static Random rnd = new Random();
        ISession session { get; set; }
        public HangmanData data { get; private set; }
        IData WordLibrary { get; set; }
        public HangmanService(IHttpContextAccessor context, IData idata)
        {
            session = context.HttpContext.Session;
            WordLibrary = idata;
        }

        public void Save()
        {
            session.Set("hangmanKey", data);
        }
        public void Load()
        {
            data = session.Get<HangmanData>("hangmanKey");
            if(data == null)
            {
                NewGame();
            }
        }

        public void NewGame()
        {
            data = new HangmanData();
            data.WordToGuess = WordLibrary.WordsToGuess[rnd.Next(0,WordLibrary.WordsToGuess.Count)];
            //data.chars = new List<Char>();

            for (int i = 0; i < data.WordToGuess.Length; i++)
            {
                data.chars.Add(new Char(data.WordToGuess[i], false));
            }

            data.Mistakes = 0;

            if (data.Tried == null) data.Tried = new List<string>();
        }

        public bool Guess(HangmanService hg, string Guess, bool guessed, int index)
        {
            //is char..
            if (Guess == null) return false;
            if (Guess.Length == 1)
            {
                //shoda písmene
                for (int i = 0; i < hg.data.chars.Count; i++)
                {
                    if (Guess == hg.data.chars[i].Pismeno.ToString())
                    {
                        hg.data.chars[i].IsVisible = true;
                        guessed = true;
                    }
                }
                //pokud neuhádl..
                if (guessed == false)
                {
                    hg.data.Mistakes++;
                    if (hg.data.Mistakes == 10) return true;
                }
                //kontrola výhry
                for (int i = 0; i < hg.data.chars.Count; i++)
                {
                    if (hg.data.chars[i].IsVisible == true) index++;
                }
                if (index == hg.data.chars.Count) return true;
            }
            //is string..
            if (Guess.Length > 1)
            {
                if (Guess == hg.data.WordToGuess) return true;
                else hg.data.Mistakes++;
            }

            return false;
        }

    }
}
