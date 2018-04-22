using System;
using System.Collections.Generic;

namespace MyHobbies
{
    public class Band
    {
        public string Naam { get; set; }
        public int Jaar { get; set; }
        public List <BandLid> Leden { get; set; }
    }
}
