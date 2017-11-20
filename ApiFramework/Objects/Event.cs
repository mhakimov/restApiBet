using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFramework.Objects
{
    class Event
    {
        public int Version { get; set; }
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string SubCategoryName { get; set; }
        public string CategoryCName { get; set; }
        public string CategoryName { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
        public string EventName { get; set; }
        public long Milliseconds { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public List<int> Markets { get; set; }
        public int CouponMarketId { get; set; }
        //public string Time { get; set; }
    }
}
