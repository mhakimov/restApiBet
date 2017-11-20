using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFramework.RequestObjects
{
    class RequestObject
    {
        public int ApplicationId { get; set; } = 5;
        public string ApplicationVersion { get; set; } = "";
        public int BrandId { get; set; } = 3;
        public int BrowserId { get; set; } = 3;
        public string BrowserVersion { get; set; } = "61.0.3163.100";
        public int ClientIntegratorId { get; set; } = 1;
        public int ClientTypeId { get; set; } = 2;
        public int JurisdictionId { get; set; } = 1;
        public int LanguageId { get; set; } = 1;
        public int OsId { get; set; } = 3;
        public string OsVersion { get; set; } = "10";
        public int TerritoryId { get; set; } = 227;
    }
}
