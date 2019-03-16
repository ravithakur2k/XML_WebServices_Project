
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_Project;
using Newtonsoft.Json;

namespace FinalProject
{
    public partial class weather : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnClk(object sender, EventArgs e)
        {
            WeatherDetails();
        }
        public void WeatherDetails()
        {
            Weather_Info.Text = "";
            string cityName = CityName.Value;
            string url = "http://api.openweathermap.org/data/2.5/weather?q=" + cityName + "&units=imperial&appid=e6b20cdb29dd3e1271611dc84f374003";
            Console.WriteLine("URL is " + url);
            Uri uri = new Uri(@url);
            int statusNumber;
            HttpWebResponse res = null;
            try
            {
                WebRequest webRequest = WebRequest.Create(uri);
                res = (HttpWebResponse)webRequest.GetResponse();
                statusNumber = (int)res.StatusCode;
            }
            catch (WebException we)
            {
                statusNumber = (int)we.Status;
                if (statusNumber == 404)
                {
                    Weather_Info.Text = "<br/>" + "<font color=" + "white" + ">" + "<p>We could not recognize the city: <strong>" + cityName +
                        "</strong>. Oops! Something went wrong, please try again. </p>" + "</font>";
                }
            }

            if (res == null)
            {
                Weather_Info.Text = "<br/>" + "<font color=" + "white" + ">" + "<p>We could not recognize the city: <strong>" + cityName +
                    "</strong>. While we are continously trying to upgrade, we encourage you to contact us to include this city. </p>" + "</font>";
            }
            else
            {
                StreamReader streamReader = new StreamReader(res.GetResponseStream());
                String responseData = streamReader.ReadToEnd();

                RootObject result_Collection = JsonConvert.DeserializeObject<RootObject>(responseData);


                if (result_Collection == null)
                {
                    Weather_Info.Text = "<br/>" + "<font color=" + "white" + ">" + "<p>No search results found for <strong>" + cityName +
                        "</strong>. This movie seems to be not so famous. </p>" + "</font>";
                }
                else
                {

                    Weather_Info.Text = "<br/>" + "<font color=" + "white" + ">" + "<strong> Longitude: </strong>" + result_Collection.Coord.Lon + "<br/><strong> Lattitude: </strong>" + result_Collection.Coord.Lat
                        + " <br/><strong>Temperature: </strong>" + result_Collection.Main.Temp + " F <br/><strong>Pressure: </strong>" + result_Collection.Main.Pressure + " P<br/><strong>Humidity: </strong>"
                        + result_Collection.Main.Humidity + " %<br/><strong>Minimum Temperature: </strong>" + result_Collection.Main.Temp_min + " F<br/><strong> Maximum Temperature: </strong> " + result_Collection.Main.Temp_max +
                        " F<br/><strong> Speed of the wind: </strong> " + result_Collection.Wind.Speed + " km/hr<br/><strong> Deg of the wind: </strong> " + result_Collection.Wind.Deg + "</font>";

                }
            }

        }
    }
}