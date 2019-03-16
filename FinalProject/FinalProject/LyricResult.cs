using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalProject
{
    public class LyricResult 
    {
        [JsonProperty("lyrics")]
        public String lyrics { get; set; }
    }
}