using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Ukol.ViewModels;

namespace Ukol.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public Logik Data{get;set;}

        public void OnGet()
        {
            Data = new Logik { FromEntry = 0,ToEntry=0 };
        }
        public void OnGetRange(int from, int to)
        {
            Data = new Logik { FromEntry = from, ToEntry = to};
            Data.Secret = makeSecret(to);
        }

        public int makeSecret(int to)
        {
            Random rnd = new Random();
            int rndvalue = rnd.Next(1,to);
            return rndvalue;
        }
    }
}
