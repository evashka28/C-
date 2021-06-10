using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
        public class Uzel
        {
            public Uzel parent;
            public Uzel left, right;
            public string value;
            public bool used;
            public Uzel( string value, Uzel parent, bool used)
            {
                
                this.value = value;
                this.parent = parent;
                this.used = used;
                left = null;
                right = null;
            }
        }
}
