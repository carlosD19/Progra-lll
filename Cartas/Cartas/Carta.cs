﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas
{

    public class Carta
    {
        public bool success { get; set; }
        public Card[] cards { get; set; }
        public string deck_id { get; set; }
        public int remaining { get; set; }
    }

    public class Card
    {
        public string image { get; set; }
        public string value { get; set; }
        public string suit { get; set; }
        public string code { get; set; }
    }
    
}
