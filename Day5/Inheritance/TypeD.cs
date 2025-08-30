using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.Inheritance
{
    //Inheritance outside assembly
    class TypeD:TypeA
    {
        #region A Attributes
        //private int x;
        //internal int y;
        //public int z;
        //private protected int a; 
        //protected int b;
        //internal protected int c;
        #endregion

        public TypeD() {
            //x = 1; //invalid -- not inherited
            //y = 2; //invalid -- not inherited outside assembly
            z = 3; //valid //inherited as [public] anywhere

            //a = 1; //invalid -- not inherited outside assembly
            b = 2; //valid -- inherited as private anywhere
            c = 3; //valid -- inherited as private outside assembly
        }
    }
}
