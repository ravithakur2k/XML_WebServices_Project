using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Final_Project;
using Newtonsoft.Json;

namespace FinalProject
{
    public class Results
    {
        public class CoordData
        {
            [JsonProperty("lon")]
            private string lon;
            [JsonProperty("lat")]
            private string lat;



            public string Lon { get => lon; set => lon = value; }
            public string Lat { get => lat; set => lat = value; }


        }
        [JsonProperty("id")]
        public String Id { get; set; }

        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonProperty("country")]
        public String Country { get; set; }
        [JsonProperty("coord")]
        public CoordData Coord { get; set; }

    }
}