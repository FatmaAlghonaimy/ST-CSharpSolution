using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.OperatorOveloading
{
    class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        #region Operator overloading
        #region Binary Operators
        public static Complex operator +(Complex left, Complex right)
        {
            //Complex result = new Complex
            //{
            //    Real = left.Real + right.Real,
            //    Imag = left.Imag + right.Imag
            //};
            //return result;
            return new Complex
            {
                //logical error
                //Proirity of + before ??
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) + (right?.Imag ??0)
            };
        }
        public static Complex operator -(Complex left, Complex right)
        {
            right = new Complex
            {
                Real = -right?.Real ?? 0,
                Imag = -right?.Imag ?? 0
            };
            return left + right;
            //return new Complex
            //{
            //    Real = (left?.Real ?? 0) - (right?.Real ?? 0),
            //    Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0)
            //};
        }
        #endregion

        #region Unary Operators
        public static Complex operator ++(Complex c)
        {
            return new Complex
            {
                Real = (c?.Real?? 0) + 1,
                Imag = c?.Imag?? 0
            };
        }
        public static Complex operator --(Complex c)
        {
            return new Complex
            {
                Real = (c?.Real??0) - 1,
                Imag = c?.Imag??0
            };
        }
        #endregion

        #region Relational Operators
        //requires overriding of Equals and GetHashCode methods , Reference or Values equality
        //public static bool operator == (Complex left, Complex right)
        //{
        //    if (left is null && right is null) return true;
        //    return left?.Real == right?.Real && left?.Imag == right?.Imag;
        //}
        //public static bool operator !=(Complex left, Complex right)
        //{
        //    return !(left == right);
        //}
        public static bool operator >(Complex left, Complex right)
        {
            // left.real > right.real -- true
            // left.Imag > right.Imag -- true
            
            if( left?.Real == right?.Real)
            {
                return left?.Imag > right?.Imag; 
            }
            else
            {
                return left?.Real > right?.Real; 
            }
        }
        public static bool operator <=(Complex left, Complex right)
        {
            return !(left > right); 
            //return left < right || left == right; //true
        }
        public static bool operator <(Complex left, Complex right)
        {
            if (left?.Real == right?.Real)
            {
                return left?.Imag < right?.Imag; 
            }
            else
            {
                return left?.Real < right?.Real; 
            }
        }
        public static bool operator >=(Complex left, Complex right)
        {
            return !(left < right);
        }
        #endregion

        #region Casting Operators
        public static explicit operator int(Complex C)
        {
            return C?.Real ?? 0;

        }
        public static implicit operator string(Complex C)
        {
            return C?.ToString() ?? string.Empty;
        }
        #endregion

        #endregion
    }
}
