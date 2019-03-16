using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace FinalProject
{
    public partial class BandDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();
            // change the content typ
            Response.ContentType = "application/json; charset=utf-8";

            // get a list of Songs
            List<Music> music = GetMusic();

            // Convert to JSON
            string musicJson = JsonConvert.SerializeObject(music);

            Response.Write(musicJson);

            Response.End();

        }

        private List<Music> GetMusic()
        {
            List<Music> allArtist = new List<Music>();

            Music beatles = new Music();
            beatles.Artist = "The Beatles";
            beatles.YearStarted = "1960";
            beatles.YearQuit = "1970";
            allArtist.Add(beatles);

            Music pinkFloyd = new Music();
            pinkFloyd.Artist = "The Pink Floyd";
            pinkFloyd.YearStarted = "1964";
            pinkFloyd.YearQuit = "1995";
            allArtist.Add(pinkFloyd);

            Music ledZeppelin = new Music();
            ledZeppelin.Artist = "Led Zeppelin";
            ledZeppelin.YearStarted = "1968";
            ledZeppelin.YearQuit = "1980";
            allArtist.Add(ledZeppelin);

            Music beeGees = new Music();
            beeGees.Artist = "Bee Gees";
            beeGees.YearStarted = "1958";
            beeGees.YearQuit = "2012";
            allArtist.Add(beeGees);

            Music davidBowie = new Music();
            davidBowie.Artist = "David Bowie";
            davidBowie.YearStarted = "1962";
            davidBowie.YearQuit = "2016";
            allArtist.Add(davidBowie);

            return allArtist;

        }
    }
}