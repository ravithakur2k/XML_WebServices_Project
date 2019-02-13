using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project
{

    public class Coord
    {
        [JsonProperty("lon")]
        private string lon;
        [JsonProperty("lat")]
        private string lat;
  


        public string Lon { get => lon; set => lon = value; }
        public string Lat { get => lat; set => lat = value; }
    

    }
    //public class Weather
    //{
    //    private List<WeatherObj> weatherObjs;

    //    public List<WeatherObj> WeatherObjs { get => weatherObjs; set => weatherObjs = value; }

    //}
    public class Weather
    {
        [JsonProperty("id")]
        private string id;
        [JsonProperty("main")]
        private string main;
        [JsonProperty("description")]
        private string description;
        [JsonProperty("icon")]
        private string icon;


        public string Id { get => id; set => id = value; }
        public string Main { get => main; set => main = value; }
        public string Description { get => description; set => description = value; }
        public string Icon { get => icon; set => icon = value; }

    }
    //public class Base
    //{
    //    [JsonProperty("base")]
    //    private string baseVal;
 



    //    public string BaseVal { get => baseVal; set => baseVal = value; }



    //}
    public class Main
    {
        [JsonProperty("temp")]
        private string temp;
        [JsonProperty("pressure")]
        private string pressure;
        [JsonProperty("humidity")]
        private string humidity;
        [JsonProperty("temp_min")]
        private string temp_min;
        [JsonProperty("temp_max")]
        private string temp_max;
       

        public string Temp { get => temp; set => temp = value; }
        public string Pressure { get => pressure; set => pressure = value; }
        public string Humidity { get => humidity; set => humidity = value; }
        public string Temp_min { get => temp_min; set => temp_min = value; }
        public string Temp_max { get => temp_max; set => temp_max = value; }
  
    }
    //public class Visibility
    //{
    //    [JsonProperty("visibility")]
    //    private string visibilityVal;




    //    public string VisibilityVal { get => visibilityVal; set => visibilityVal = value; }



    //}
    public class Wind
    {
        [JsonProperty("speed")]
        private string speed;
        [JsonProperty("deg")]
        private string deg;



        public string Speed { get => speed; set => speed = value; }
        public string Deg { get => deg; set => deg = value; }


    }
    public class Clouds
    {
        [JsonProperty("all")]
        private string all;




        public string All { get => all; set => all = value; }



    }
    //public class Dt
    //{
    //    [JsonProperty("dt")]
    //    private string dtValue;




    //    public string DtValue { get => dtValue; set => dtValue = value; }



    //}
    public class Sys
    {
        [JsonProperty("type")]
        private string type;
        [JsonProperty("id")]
        private string id;
        [JsonProperty("message")]
        private string message;
        [JsonProperty("country")]
        private string country;
        [JsonProperty("sunrise")]
        private string sunrise;
        [JsonProperty("sunset")]
        private string sunset;


        public string Type { get => type; set => type = value; }
        public string Id { get => id; set => id = value; }
        public string Message { get => message; set => message = value; }
        public string Country { get => country; set => country = value; }
        public string Sunrise { get => sunrise; set => sunrise = value; }
        public string Sunset { get => sunset; set => sunset = value; }

    }
    //public class Id
    //{
    //    [JsonProperty("id")]
    //    private string idVal;




    //    public string IdVal { get => idVal; set => idVal = value; }



    //}
    //public class Name
    //{
    //    [JsonProperty("name")]
    //    private string nameValue;




    //    public string NameValue { get => nameValue; set => nameValue = value; }



    //}
    //public class Cod
    //{
    //    [JsonProperty("cod")]
    //    private string codValue;




    //    public string CodValue { get => codValue; set => codValue = value; }



    //}
    public class RootObject
    {
        [JsonProperty("coord")]
        public Coord Coord { get; set; }

        [JsonProperty("weather")]
        public List<Weather> Weathers { get; set; }

        [JsonProperty("base")]
        public String BaseValue { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("visibility")]
        public String Visibility { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty("dt")]
        public String Dt { get; set; }

        [JsonProperty("sys")]
        public Sys Sys { get; set; }

        [JsonProperty("id")]
        public String Id { get; set; }

        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonProperty("cod")]
        public String Cod { get; set; }

    }
}