using BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace VirtualMindTestService.Returns
{
    [DataContract]
    public class Return<T> : Base.BaseReturn
    {

        private List<T> _list;

        [DataMember]
        public List<T> list
        {
            get { return _list; }
            set { _list = value; }
        }


        private T _item;

        [DataMember]
        public T item
        {
            get { return _item; }
            set { _item = value; }
        }



    }
}