using ApiFramework.Objects;
using System;
using System.Collections.Generic;


namespace ApiFramework.RequestObjects
{
    class GetEventsRequest : RequestObject
    {       
        public List<int> ExternalIds { get; set; }
        public string MarketCName { get; set; } = "win-draw-win";
        public ScoreboardRequest ScoreboardRequest { get; set; } = new ScoreboardRequest() { ScoreboardType = 3, IncidentRequest = null };
    }
}
