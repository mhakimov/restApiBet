using ApiFramework.Objects;
using ApiFramework.RequestObjects;
using ApiFramework.ResponseObjects;
using ApiFramework.Tests;
using NUnit.Framework;


namespace ApiFramework
{
    class GetEvents : BaseTest
    {

        [Test]
        public void GetEvents_01()
        {
            GetEventsRequest request2 = new GetEventsRequest();
            request2.ExternalIds = new Utilities().GetEventIdList(3);
            GetEventsResponse response = DeserializeGetEventsResponse(SerializeGetEventsRequest(request2));
            Assert.That(response.Events, Is.Not.Empty);
        }
    }

}
