
namespace Day4
{
    public struct Point
    {
        # region Attriutes
        public int x;
        public int y;
        #endregion

        #region Constructor
        /// Is A Special Function 
        ///    1. Named As Struct
        ///    2. Has No Return Type 


        ///constructor overloading
        //public Point() //default //non-parameterized constructor
        //{
        //    x = default;
        //    y = default;
        //}
        //this refers to caller
        public Point(int _x, int _y) //parameterized constructor
        {
            //this.x private field
            x = _x;
            y = _y;
        }
        public Point(int _x)
        {
            x = _x;
            y = _x;
        }
        #endregion

        #region Methods Overriding
        public override string ToString()
        {
            return $"X:{x} , Y:{y}";
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
