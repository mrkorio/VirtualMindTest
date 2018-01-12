using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Models.Base
{
    public class Error
    {

        private int _code;

        public int code
        {
            get { return _code; }
            set { _code = value; }
        }


        private string _message;

        public string message
        {
            get { return _message; }
            set { _message = value; }
        }

        public Error()
        {
            this.code = 0;
            this.message = string.Empty;
        }

    }
}
