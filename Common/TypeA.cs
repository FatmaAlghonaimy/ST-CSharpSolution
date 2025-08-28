using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    //by default internal
    public  struct TypeA
    {
        public int x;
        internal int y;
        private int z;

        public void MyMethod()
        {
            x = 10;
            y = 10;
            z = 10;
        }
    }
}
