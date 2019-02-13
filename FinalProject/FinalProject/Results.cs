using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Final_Project;

namespace FinalProject
{
    public class Results 
    {
        private List<Main> weatherResults;

        public List<Main> WeatherResults { get => weatherResults; set => weatherResults = value; }
    }
}