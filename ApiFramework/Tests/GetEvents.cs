using ApiFramework.Objects;
using ApiFramework.RequestObjects;
using ApiFramework.ResponseObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace ApiFramework
{
    class GetEvents
    {
        string uri = "https://sports.betway.com/api/Events/V2/GetEvents";
        HttpWebRequest request;
        List<int> eventIds = new List<int>();
        

        [OneTimeSetUp]
        public void Start()
        {
            request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "POST";
            request.ContentType = "application/json";
            
        }


        [Test]
        public void GetEvents_01()
        {
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                GetEventsRequest request2 = new GetEventsRequest()
                {
                    ApplicationId = 5,
                    ApplicationVersion = "",
                    BrandId = 3,
                    BrowserId = 3,
                    BrowserVersion = "61.0.3163.100",
                    ClientIntegratorId = 1,
                    ClientTypeId = 2,
                    ExternalIds = new Utilities().GetEventIdList(3),
                    JurisdictionId = 1,
                    LanguageId = 1,
                    MarketCName = "win-draw-win",
                    OsId = 3,
                    ScoreboardRequest = new ScoreboardRequest() { ScoreboardType = 3, IncidentRequest = null },
                    OsVersion = "10",
                    TerritoryId = 227
                };

            var json = new JavaScriptSerializer().Serialize(request2);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                JavaScriptSerializer js = new JavaScriptSerializer();
                GetEventsResponse myojb = (GetEventsResponse)js.Deserialize(result, typeof(GetEventsResponse));
            }

        }
    }

}
