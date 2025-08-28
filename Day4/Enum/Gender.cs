using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Enum
{

    enum Gender : byte // 0:255
    {
        ///What You Can Write Inside?
        ///Set of named constants[Labels]
        ///
		///Access Modifier Allowed Inside?
		///No Access Modifiers Allowed inside Enum
        ///stored in stack 
        none = 0,
        Male = 10, Female = 20,
        A = 255,
        //B invalid
    }
}
