using ApiFramework.RequestObjects;
using ApiFramework.ResponseObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Script.Serialization;

namespace ApiFramework
{
    class Utilities
    {
        public List<int> GetEventIdList(int amountOfEvents)
        {
            GetGroupResponse myjob;
            List<int> toReturn = new List<int>();
            string uri = "https://sports.betway.com/api/Events/V2/GetGroup";
            HttpWebRequest request;
            request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "POST";
            request.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                GetGroupRequest request2 = new GetGroupRequest();

                var json = new JavaScriptSerializer().Serialize(request2);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                JavaScriptSerializer js = new JavaScriptSerializer();
                 myjob = (GetGroupResponse)js.Deserialize(result, typeof(GetGroupResponse));
            }

            for (int i = 0; i < amountOfEvents; i++)
            {
                toReturn.Add(myjob.Categories.First().Events[i]);
            }

            return toReturn;
        }
    }
}
