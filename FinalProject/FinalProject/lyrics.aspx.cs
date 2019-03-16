using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class lyrics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnClk(object sender, EventArgs e)
        {
            LyricsDetails();
        }
        public void LyricsDetails()
        {
            Lyric_Info.Text = "";
            string artName = artistName.Value;
            string tlName = titleName.Value;
            string url = "https://api.lyrics.ovh/v1/" + artName + "/"+tlName;
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
                    Lyric_Info.Text = "<br/>" + "<font color=" + "black" + ">" + "<p style =" + "background-color:skyblue;" + "> <strong> Technical error occured! </br> Try again after sometime." +
                         "</strong> </p>" + "</font>";
                }
            }

            if (res == null)
            {
                Lyric_Info.Text = "<br/>" + "<font color=" + "black" + ">" + "<p style =" + "background-color:skyblue;" + "> <strong> Song not found! </br> Please verify artist name and song name" +
                         "</strong> </p>" + "</font>";
            }
            else
            {
                StreamReader streamReader = new StreamReader(res.GetResponseStream());
                String responseData = streamReader.ReadToEnd();

                LyricResult result_Obj = JsonConvert.DeserializeObject<LyricResult>(responseData);


                if (result_Obj == null)
                {
                    Lyric_Info.Text = "<br/>"+"<font color=" + "black" + ">" + "<p style =" + "background-color:skyblue;" + "> <strong> Song not found! </br> You have got unique taste." +
                        "</strong> </p>" + "</font>";
                }
                else
                {
                    Lyric_Info.Text = "<br/>"+"<font color=" + "black" + ">" + "<p style =" + "background-color:skyblue;" +"> <strong>" + result_Obj.lyrics +
                       "</strong>. </p>" + "</font>";

                }
            }

        }
    }
}