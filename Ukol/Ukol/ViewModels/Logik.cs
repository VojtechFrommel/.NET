using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ukol.ViewModels
{
    public class Logik
    {
        public int FromEntry { get; set; }
        public int ToEntry { get; set; }
        public int Secret { get; set; }
        public int Guess { get; set; }
        public bool Win { get; set; } = false;
        public bool Restart { get; set; } = true;
    }
}
