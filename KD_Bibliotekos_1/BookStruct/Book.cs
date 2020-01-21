using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStruct
{
    public struct Book
    {
        private string _name;
        private string _id;

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public string Id
        {
            get { return _id; }
            set 
            {
                if(value != "")
                {
                    _id = value;
                }              
            }
        }

        public string LocalId {
            get { return _name  + _id; }
            private set { }
        }
    }
}
