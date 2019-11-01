using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ukol.ViewModels
{
    public class Data
    {
        public int FromEntry { get; set; }
        public int ToEntry { get; set; }
        public int Range => ToEntry - FromEntry;

        //generování random čísla

    }
}
