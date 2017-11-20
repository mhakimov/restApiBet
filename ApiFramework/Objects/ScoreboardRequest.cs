using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFramework.Objects
{
    class ScoreboardRequest
    {
        public int ScoreboardType { get; set; }
        public List<int> IncidentRequest { get; set; }
    }
}
