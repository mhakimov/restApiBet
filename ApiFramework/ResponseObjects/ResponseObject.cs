using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFramework.ResponseObjects
{
    class ResponseObject
    {
        public string MethodName { get; set; }
        public string MethodResult { get; set; }
        public bool Success { get; set; }
    }
}
