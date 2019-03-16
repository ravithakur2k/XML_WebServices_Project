using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject
{
    public class Music
    {
        private int id;
        private string artist;
        private string yearStarted;
        private string yearQuit;

        public int Id { get => id; set => id = value; }
        public string Artist { get => artist; set => artist = value; }
        public string YearStarted { get => yearStarted; set => yearStarted = value; }
        public string YearQuit { get => yearQuit; set => yearQuit = value; }
    }
}