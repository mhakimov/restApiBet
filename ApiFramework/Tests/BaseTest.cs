using ApiFramework.RequestObjects;
using ApiFramework.ResponseObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Script.Serialization;

namespace ApiFramework.Tests
{
     class BaseTest
    {
        protected string uri = "https://sports.betway.com/api/";
        

        [OneTimeSetUp]
        public void Start()
        {
          

        }

        [SetUp]
        public void Setup()
        {

        }


        protected HttpWebRequest SerializeGetEventsRequest(GetEventsRequest request2)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri + "Events/V2/GetEvents");
            request.Method = "POST";
            request.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                var json = new JavaScriptSerializer().Serialize(request2);
                streamWriter.Write(json);
            }

            return request;
        }

        protected GetEventsResponse DeserializeGetEventsResponse(HttpWebRequest request)
        {
            var httpResponse = (HttpWebResponse)request.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                JavaScriptSerializer js = new JavaScriptSerializer();
                GetEventsResponse response = (GetEventsResponse)js.Deserialize(result, typeof(GetEventsResponse));
                return response;
            }
        }


        protected HttpWebRequest SerializeGetGroupRequest(GetGroupRequest request2)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri + "Events/V2/GetGroup");
            request.Method = "POST";
            request.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                var json = new JavaScriptSerializer().Serialize(request2);
                streamWriter.Write(json);
            }

            return request;
        }


        protected GetGroupResponse DeserializeGetGroupResponse(HttpWebRequest request)
        {
            var httpResponse = (HttpWebResponse)request.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                JavaScriptSerializer js = new JavaScriptSerializer();
                GetGroupResponse response = (GetGroupResponse)js.Deserialize(result, typeof(GetGroupResponse));
                return response;
            }
        }
    }
}
