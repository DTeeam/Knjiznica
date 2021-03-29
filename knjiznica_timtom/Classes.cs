﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knjiznica_timtom
{
    public class Knjiga
    {
        public int inventarna_stevilka { get; set; }
        public string naslov { get; set; }
        public int pridobitev { get; set; }
        public string zapiski { get; set; }
        public int leto { get; set; }
        public string avtor { get; set; }
        public string zalozba { get; set; }
        public int izgubljena { get; set; }
        public int section_id { get; set; }
        public int zasedena { get; set; }
    }
    
    public class Clan
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string priimek { get; set; }
        public string telefon { get; set; }
        public string naslov { get; set; }
        public string email { get; set; }
        public string zapiski { get; set; }

    }
}
