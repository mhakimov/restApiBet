using ApiFramework.RequestObjects;
using ApiFramework.ResponseObjects;
using ApiFramework.Tests;
using NUnit.Framework;
using System.Linq;

namespace ApiFramework
{
    class GetGroup : BaseTest
    {

        [Test]
        public void GetGroup_01()
        {
            GetGroupRequest request2 = new GetGroupRequest();
            GetGroupResponse response = DeserializeGetGroupResponse(SerializeGetGroupRequest(request2));          
            Assert.That(response.Categories.Any(c=>c.CategoryCName == "soccer"));
        }
    }

}
