using BE.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace VirtualMindTestService.Returns.Base
{
    //Base return type that will hold elements in common between every return data type
    [DataContract]
    public class BaseReturn
    {
        private Error _error;

        [DataMember]
        public Error error
        {
            get { return _error; }
            set { _error = value; }
        }

        public BaseReturn()
        {
            error = new Error();
            error.code = 0;
            error.message = string.Empty;

        }
    }
}