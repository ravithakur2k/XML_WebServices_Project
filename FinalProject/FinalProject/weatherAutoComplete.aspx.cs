using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using Final_Project;
using System.IO;

namespace FinalProject
{
    public partial class weatherAutoComplete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // get the letters that the user typed 
            String term = Request.QueryString["term"];

            Response.Clear();
            // change the content type, so the browser knows it's JSON
            Response.ContentType = "application/json; charset=utf-8";
            using (var webClient = new WebClient())
            {

                string search_text = term;
                var path = Server.MapPath(@"~/city_list.json");
                StreamReader streamReader = new StreamReader(path);
                String responseData = streamReader.ReadToEnd();

                List<Results> result_Collection = JsonConvert.DeserializeObject<List<Results>>(responseData);

                List<String> matchedinfo = new List<String>();

                if (term != null && term.Length > 0)
                {

                    foreach (var resultObj in result_Collection)

                    {

                        if (!string.IsNullOrEmpty(resultObj.Name) && resultObj.Name.ToUpper().Contains(term.ToUpper()))

                        {
                            matchedinfo.Add(resultObj.Name);

                        }
                    }

                }
                string matchedJson = JsonConvert.SerializeObject(matchedinfo);

                Response.Write(matchedJson);

            }

            Response.End();
        }

    }
}