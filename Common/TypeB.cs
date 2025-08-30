using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    // struct enum class interface record
    // public , internal
    // default internal
    public class TypeB : TypeA 
    {
        //int a; //private by default
        public TypeB()
        {
            #region A Attribures
            //private int x;
            //internal int y;
            //public int z;

            //private protected int a;
            //protected int b;
            //internal protected int c;
            #endregion

            #region before inheritance [Remove Protected Keyword and Check]
            TypeA typeA = new TypeA();
            //typeA.x = 1; // Invalid  // X is private [ assessable within its Scope Only ]
            typeA.y = 1; // Valid // Y is Internal [ assessable within its Scope and in Same Project Only] 
            typeA.z = 1; // Valid // Z is Public [ assessable anywhere]

            //typeA.a = 1; // Invalid // A is Private Protected -- Private
            //typeA.b = 1; // invlaid // B is Protected -- Private
            typeA.c = 1; // Valid // C is Protected Internal -- internal
            #endregion

            #region after inheritance [Remove Protected in Specifying Access Modifier After inheritance]
            //x = 1; //invalid // not inherited
            y = 2; //valid //internal is inherited inside the same project as [internal]
            z = 3; //valid //public is inherited anywhere [public]
            a = 4; //valid //private protected is inherited inside the same project [private] 
            b = 5; //valid //protected is inherited anywhere [private] 
            c = 6; //valid //internal protected is inherited inside the same project [internal] 
            #endregion
        }

    }
}

