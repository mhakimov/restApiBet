using ApiFramework.Objects;
using System;
using System.Collections.Generic;

namespace ApiFramework.ResponseObjects
{
    class GetEventsResponse : ResponseObject
    {
       
        public List<Event> Events { get; set; }
    }
}
