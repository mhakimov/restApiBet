using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFramework.RequestObjects
{
    class GetGroupRequest : RequestObject
    {
        public string CategoryCName { get; set; } = "soccer";
        public string GroupCName { get; set; } = "premier-league";
        public bool PremiumOnly { get; set; } = false;
        public string SubCategoryCName { get; set; } = "england";
    }
}
