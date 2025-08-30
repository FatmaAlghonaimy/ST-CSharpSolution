using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 1- no inheritance 
    /// inside project , outside project
    /// 2- inheritance
    /// inside inherited class , inside project , outside project
    /// </summary>
  
    public class TypeA
    {
        private int x; 
        internal int y;
        public int z;

        private protected int a;
        protected int b;
        internal protected int c;
        public TypeA()
        {
            x = 1; // X is private [ assessable within its Scope ]
            y = 2; // Y is Internal [ assessable within the project ] 
            z = 3; // Z is Public [ assessable anywhere ]
        }
    }
}
