using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFramework.Objects
{
    class Category
    {
        public string DisplayName { get; set; }
        public string CategoryCName { get; set; }
        public List<int> Events { get; set; }
        public List<string> EventTablesKeys { get; set; }
    }
}
