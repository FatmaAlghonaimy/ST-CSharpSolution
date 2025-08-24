//using Day1.A;
//using Day1.B;
//using Test0A = Day1.A.Test;
//using System;

namespace Day1
{
    /// <summary>
    /// The main class for any application.
    /// msh lazm yb2a esmo program.cs lakn hya naming convention
    /// </summary>
    class Program //PascalCase
    {
        /// <summary>
        /// Main entry point for the application.
        /// clr looks for a function with this signature 
        /// jitting from here 
        /// </summary>
        static void Main()
        {
            #region namespace
            ////Day1.A.Test
            ////Test0A
            //Test  
            // from the new versions of .net we have global imports .net 6
            #endregion

            #region Debugging
            //Console.WriteLine("Hello, World!");
            //Test2();
            //Console.WriteLine("Hello, ITI!");
            //Console.WriteLine("Fatma");

            #endregion

            #region Errors
            //int a;
            //a = 5;
            //Console.WriteLine(a);
            #region Syntax Errors
            ////This is a syntax error example
            //Console.WriteLine("This is a syntax error example.");// Missing closing parenthesis
            #endregion
            #region Runtime Errors
            // This is a runtime error example
            //int x = 10;
            //int y = 0;
            //int result = x / y; // Division by zero will cause a runtime error
            //                    //acces sing an index out of range in an array
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(numbers[5]); // This will cause an IndexOutOfRangeException
            //Console.WriteLine("This is a runtime error example.");
            #endregion
            #region Logical Errors
            //This is a logical error example
            //int a2 = 5;
            //int b = 10;
            //int sum = a - b; // This should be addition, but it's subtraction
            #endregion
            #endregion

            #region DataTypes
            //int number = 10; // Integer stored at stack
            //double price, g = 19.99; // Double
            //char grade = 'A'; // Character
            //bool isActive = true; // Boolean
            //string message = "Hello, World!"; // Stored at heap 

            //long number = 50; //ClR allocate 8 bytes for long
            //string text = "Hello, World!";

            //int[] arr1;
            //arr1 = new int[3]; // Array of integers with 5 elements  0 1 2

            //int[] arr2 = new int[4];    //0 1 2 3

            //arr2 = arr1; //shallow copy   0 1 2

            //arr2[3] = 5;  //arr1[3] = 5; // This will cause an IndexOutOfRangeException because arr1 has only 3 elements
            //arr1[0] = 2;

            //Console.WriteLine(arr2[0]);
            #endregion

            #region variables and Consts
            // Variables  //camelCase
            //int age; // Declaration
            //age = 30; // Initialization


            // Constants
            //const double Pi = 3.14; // Declaration and initialization of a constant
            //Pi = 5; // Constants must be initialized at the time of declaration

            #region Fractions And Discard
            //// float, double , decimal   
            //float x = 12.1234567891f; //4bytes 7 digits of precision
            //Console.WriteLine(x);
            //double z = 10.123_456_789_123_456_789;
            //Console.WriteLine(z); // 8 bytes 15-16 digits of precision
            //decimal y = 10.5m; // 128 bit , 16 bytes

            #endregion

            #endregion

            #region Operators 

            #region Unary Operators [ ++ , -- ]
            //int X = 10;

            //1. ++
            // 1.1 PreFix [Increment and Then Print]
            //Console.WriteLine(++X); // 11
            //Console.WriteLine(X); // 11

            // 1.2 PostFix [Print and Then Increment]
            //Console.WriteLine(X++); // 10 
            //Console.WriteLine(X); // 11


            ////2. --
            //// 2.1 PreFix [Decrement and Then Print]
            //Console.WriteLine(--X); // 9
            //Console.WriteLine(X); // 9

            //// 2.2 PostFix [Print and Then Decrement]
            //Console.WriteLine(X--); // 10 
            //Console.WriteLine(X); // 9
            #endregion

            #region Binary | Arithmetic Operators [+ , - , * , / , %]

            //int sumResult, subResult, mulResult, divResult, modResult;
            //int number01 = 7, number02 = 2;
            //sumResult = number01 + number02; // 8 
            //subResult = number01 - number02; // 4
            //mulResult = number01 * number02; // 12
            //divResult = number01 / number02; // 3
            //modResult = number01 % number02; // 0
            //Console.WriteLine($"Sum: {sumResult}, Subtraction: {subResult}, Multiplication: {mulResult}, Division: {divResult}, Modulus: {modResult}");

            #endregion

            #region Assignment Operators [= , += , -= , *= , /= , %=]

            //int X;
            //X = 4;
            //X += 2; // X = X + 2
            //X -= 2; // X = X - 2
            //X *= 2; // X = X * 2
            //X /= 2; // X = X / 2
            //X %= 2; // X = X % 2

            #endregion

            #region Relational | Comparsion Operators [== , != , < , > , <=, >=]
            //int X = 10, Y = 10;

            //Console.WriteLine(X == Y); // True
            //Console.WriteLine(X != Y); // False 
            //Console.WriteLine(X > Y); // False 
            //Console.WriteLine(X < Y); // False
            //Console.WriteLine(X >= Y); // True 
            //Console.WriteLine(X <= Y); // True

            #endregion

            #region Logical Operators [! , && , ||]
            ////// Short Circuit
            //Console.WriteLine(!true); // False
            //Console.WriteLine(false && true); // False
            //Console.WriteLine(false || true); // True 

            ////Console.WriteLine(1 && 2); // True

            //Console.WriteLine(4 < 5 && 7 < 9); // True
            //Console.WriteLine(4 < 5 && 7 > 9); // False
            //Console.WriteLine(4 > 5 && 7 < 9); // False

            #endregion

            #region BitWise Operator [& , | , ^ , ~ , << , >> ]
            //// Long Circuit
            //Console.WriteLine(false & true); // False
            //Console.WriteLine(true | false); // True 
            //Console.WriteLine(false ^ true); // True 

            //int X = 5, Y = 3; // X = 0101 , Y = 0011
            //Console.WriteLine(X & Y);  // 1 (0101 & 0011 = 0001)
            //Console.WriteLine(X | Y);  // 7 (0101 | 0011 = 0111)
            //Console.WriteLine(X ^ Y);  // 6 (0101 ^ 0011 = 0110)
            //Console.WriteLine(~X);     // -6 (complement of 0101 is 1010) 
            //Console.WriteLine(X << 2); // 10 (1010)    1010 = 10  // *2 *2   1010  10100 = 20
            //Console.WriteLine(X >> 2); // 2  (0010)   0101   = 0010 = 2  /2  1 /2
            #endregion

            #region Terany Operator [Conditional Operator] [?:]

            //int X = 10, Y = 5;

            //string Message = X > Y ? "X > Y" : "X < Y";

            //Console.WriteLine(Message);
            #endregion

            #region Operators Priority and Associativity

            //int a = 20;
            //int b = 15;
            //int c = 10;
            //int d = 5;
            //int Result;

            //Result = (a + b) * c / d; // ( 20 + 15 ) * 10 / 5 = 70  
            //Result = ((a + b) * c) / d; // (( 20 + 15 ) * 10 ) / 5 = 70
            //Result = (a + b) * (c / d); // ( 20 + 15 ) * ( 10 / 5 ) = 70
            //Result = a + (b * c) / d; // 20 + ( 15 * 10 ) / 5 = 50

            #endregion
            #endregion

            #region  Console in/out + basic Parsing
            //Console.WriteLine("Enter your name: ");

            //string name = Console.ReadLine(); // Wait for user input before closing the console window

            //Console.WriteLine("Hello, " + name + "!");

            //Console.Write("Enter your age: ");

            //string ageInput = Console.ReadLine(); // Read user input as a string  
            //int result = Console.Read(); // Read a single character from the console (not used here, but can be useful for other purposes)


            ////Parsing 
            //int age = int.Parse(ageInput); // Convert the string input to an integer
            //Console.WriteLine(age);

            //Console.Write("Ahmed");
            //Console.WriteLine("Ali");


            //Read Readlint
            #endregion

            #region String Formatting 
            //// Equation : 10 + 5 = 15
            //int x = 10, y =5 ;
            //int result = x + y;

            //1- String Interpolation
            //Console.WriteLine($"Equation : 10 + 5 = 15");
            //$ // manipulating opeerator
            //Console.WriteLine($"Equation : {x} + {y} = {result}");

            //2- String.Format Method  //placeholder
            //string message;
            //message = string.Format("Equation : {0} + {1} = {2}",x,y,result);
            //Console.WriteLine(message);

            //3- Composite Formatting
            //Console.WriteLine("Equation : {0} + {1} = {2}",x,y,result);
            //Console.WriteLine(string.Format("Equation : {0} + {1} = {2}", x, y, result));

            //4- String Concatenation //not recommended  immutable
            //Console.WriteLine("Equation : " + x + " + " + y + " = " + result);

            //unreachable object
            //Equation : 
            //Equation : 10
            //Equation : 10 + 
            //Equation : 10 + 5
            //Equation : 10 + 5 =
            //Equation : 10 + 5 = 15

            #region Format Specifiers
            //long x = 10000000000;
            //Console.WriteLine($"{x:c}"); // 10000000000
            //Console.WriteLine($"{x:X}"); // 2540be4000
            //Console.WriteLine($"{x:n}");
            //Console.WriteLine($"{Number:c}"); // $10,000,000,000.00
            // c => format specifier is used to format numbers as currency.
            // x => format specifier is used to format numbers as hexadecimal.
            // n => format specifier is used to format numbers with thousands separators.
            #endregion

            #endregion


        }

        #region Documentation and Comments
        //single line
        /*
         *multiline
         *
         *
         */

        /// <summary>
        /// This function calculates the sum of two integers.
        /// </summary>
        /// <param name="a">First Num</param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            // This is a comment explaining the purpose of the function
            /* */
            return a + b;
        }
        #endregion

        #region Debugging

        static void Test2()
        {
            Console.WriteLine("Hello from Test2");
        }
        #endregion
    }
    #region Stanalone Functions
    //standalone function --invalid

    //    static void Test1()
    //{
    //    // This is a test method
    //    Console.WriteLine("Test1 method called.");
    //}
    #endregion
}




