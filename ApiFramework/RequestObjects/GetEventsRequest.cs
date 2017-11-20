using ApiFramework.Objects;
using System;
using System.Collections.Generic;


namespace ApiFramework.RequestObjects
{
    class GetEventsRequest : RequestObject
    {       
        public List<int> ExternalIds { get; set; }      
        public string MarketCName { get; set; }
        public ScoreboardRequest ScoreboardRequest { get; set; }
    }
}
