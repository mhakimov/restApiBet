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
    class GetGroup
    {
        string uri = "https://sports.betway.com/api/Events/V2/GetGroup";
        HttpWebRequest request;

        [OneTimeSetUp]
        public void Start()
        {
            request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "POST";
            request.ContentType = "application/json";

        }


        [Test]
        public void GetGroup_01()
        {
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
                GetGroupResponse myojb = (GetGroupResponse)js.Deserialize(result, typeof(GetGroupResponse));
            }
        }
    }

}
