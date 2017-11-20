using ApiFramework.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFramework.ResponseObjects
{
    class GetGroupResponse : ResponseObject
    {
        public List<Category> Categories { get; set; }

    }
}
