//#nullable disable

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Continue String Formatting 
            #region Escape Sequences
            //\n => New Line
            //\t => Tab   
            //Console.WriteLine("Hello,\tFatma\n" + "From ITI"); // Hello 

            // File Path 
            //F:\ST\C#\G03\Day1\CSharpSTSol\Day2\Day2.csproj 
            //string file = "F:\\ST\\C#\\G03\\Day1\\CSharpSTSol/Day2\\Day2.csproj\n";
            //string file02 = @"F:\ST\C#\G03\Day1\\tCSharpSTSol\Day2\Day2.csproj"; // @ => Verbatim String Literal
            //Console.WriteLine(file);
            //Console.WriteLine(file02); 
            #endregion
            #endregion

            #region Casting and conversion
            #region Implicit And Explicit Casting

            /// Casting is the process of converting a value from one data type to another.
            /// Casting mostly works between types in the same family(numeric or related classes).
            /// 1. Implicit Casting:
            ///  - It is safe and does not result in data loss.
            ///   - It is performed automatically by the compiler.
            /// 2. Explicit Casting:
            ///   - It may result in data loss or overflow.
            ///   - It requires the use of a casting operator
            ///   - Example: Converting a larger numeric type to a smaller numeric type (e.g., long to int).
            ///byte - short - int - long
            ///float - double - decimal
            ///


            //int x = 10; //safe cast, widening cast
            //long y = x;

            //long a = 10;
            //int b = a; //unsafe , narrowing cast

            //string num = "20";
            //int c = num; // explicit cast

            #region Example 01  [Same Data Types]
            //implicit cast
            //int x = 10; //safe cast, widening cast
            //long y = x;
            //Console.WriteLine(y);

            //explicit cast
            //long a = 10000000000000;
            //int b = (int)a; //unsafe , narrowing cast
            //Console.WriteLine(b); // unexpected result overflow - garbage value? - low 32 bit in a

            #endregion

            #region Example 02 [Different Data Types]
            //int x = 10;
            //float y = x; // Implicit Casting [Widening Conversion]

            //float y = 10.5f;   //same size , 4 byte
            //int x = (int)y;
            //Console.WriteLine(x); // 10 [Explicit Casting] [Narrowing Conversion] [May Cause Loss Of Data]


            //double y = 10000000000000.5;   //4 byte
            //int x = (int)y; //overflow
            //Console.WriteLine(x);

            #endregion

            #region Protective Code

            #region Checked
            //{
            //    long a = 10000000000000;
            //    int b = (int)a;
            //    Console.WriteLine(b);
            //}
            #endregion

            #region min - max values
            //long a = 10000000000000;
            //long a = 500;
            //if (a > int.MaxValue || a < int.MinValue) 
            //{
            //    Console.WriteLine("Value is out of range for int type.");
            //}
            //else
            //{
            //    int b = (int)a;
            //    Console.WriteLine(b); 
            //}
            #endregion

            #region object
            //object x = 40000;
            //int y;
            //int y = (int)x;

            //Console.WriteLine(typeof(long));
            ////typeof(long);
            //if (x.GetType() == typeof(int))
            //{
            //    y = (int)x; // Explicit Casting
            //    Console.WriteLine(y); // 40000
            //}
            //else
            //{
            //    y = 0;
            //    Console.WriteLine("Value is out of range for int type.");
            //}
            //Console.WriteLine("x is not an int type.");
            //y = x.GetType() == typeof(int) ? (int)x : 0;
            //Console.WriteLine(y); // 0
            #endregion

            #endregion


            #endregion

            #region Convert 
            //Console.Write("Enter you name:");
            //string name = Console.ReadLine() ?? "no name";

            //Console.Write("Enter your age:");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter YOur Salary:");
            //decimal Salary = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("Employee Data :");
            //Console.WriteLine("Name is " + name);
            //Console.WriteLine("Age is " + age);
            //Console.WriteLine("Salary is " + Salary);

            #endregion

            #region Parse()
            //Console.Write("Enter you name:");
            //string name = Console.ReadLine() ?? "no name";

            //Console.Write("Enter your age:");
            //int age = int.Parse(Console.ReadLine() ?? "0");

            //Console.Write("Enter Your Salary:");
            //decimal Salary = decimal.Parse(Console.ReadLine() ?? "0");

            //Console.Clear();

            //Console.WriteLine("Employee Data :");
            //Console.WriteLine("Name is " + name);
            //Console.WriteLine("Age is " + age);
            //Console.WriteLine("Salary is " + Salary);


            #endregion

            #region TryParse bool, out param  --safe
            //Console.Write("Enter you name:");
            //string name = Console.ReadLine() ?? "no name";

            //Console.Write("Enter your age:");

            //bool isParsed = int.TryParse(Console.ReadLine(),out int age);

            //Console.Write("Enter Your Salary:");
            //bool isParsed2 = decimal.TryParse(Console.ReadLine(), out decimal Salary);

            //Console.Clear();

            //Console.WriteLine("Employee Data :");
            //Console.WriteLine("Name is " + name);
            //Console.WriteLine("Age is " + age);
            //Console.WriteLine("Salary is " + Salary);

            #endregion

            #region Boxing , Unboxing 

            #region Boxing [Value Type => Reference Type]
            //int x = 10;
            //object obj = x; //Boxing - converting value type to reference type
            ////implicit cast by Compiler   // Safe Casting 

            //obj = 1.2;


            #endregion

            #region Unboxing [Reference Type => Value Type]
            //object obj2 = "Fatma"; //not boxing
            //obj2 = new int[] { 1, 2, 3, 4, 5 }; //not boxing

            //obj = 10;

            //int x = (int)obj; // unboxing
            //char input = (char)obj2; // unboxing

            //int X = (int)obj;      // Casting From  Object [Reference Type] => To int [ValueType] ----> Unboxing
            //char input = (char)obj; // Casting From  Object [Reference Type] => To char [ValueType] ----> Unboxing
            //bool flag = (bool)obj;  // Casting From  Object [Reference Type] => To bool [ValueType] ----> Unboxing
            //						// Explicit Casting
            //						// Unsafe Casting 


            //Console.WriteLine(flag); //InvalidCastException:
            #endregion

            #endregion
            #endregion

            #region Nullable Types

            #region Nullable value types

            #region Example 01
            //int x = 10;
            //x = null; invalid

            //Nullable<int> y = 20;
            //y = null;

            //int? z = 20;
            //z = null;
            #endregion

            #region Example 02 [Casting From nullable type to non-nullable type]
            //int? z = null; 
            //int x = (int)z; //explicit 

            //Console.WriteLine(x);  // unhandled excpetion , invalid operation

            #endregion

            #region Protective Code

            #region If null
            //if (z == null) // is null introduced in C#9
            //{
            //    Console.WriteLine("z is null, cannot cast to int.");
            //}
            //else
            //{
            //    x = (int)z; // explicit cast
            //    Console.WriteLine(x);
            //}
            #endregion

            #region HasValue, Value

            //int? z = null ;
            //int x = z.HasValue ? z.Value : 0;
            //Console.WriteLine(x);
            #endregion

            #region null colescing operator ??

            //int? z = null;
            ////int x = z.HasValue ? z.Value : 0;
            //int x = z ?? 20;#region GetValueOrDefault Method

            #endregion

            #region GetValueOrDefault Method
            //x = z.GetValueOrDefault();
            //Console.WriteLine(x);
            #endregion

            #endregion

            #endregion

            #region Nullable Reference Types   //compiler enhancement

            //#nullable disable
            //string name01 = null;
            //Console.WriteLine(name01);
            //#nullable enable

            //string? name02 = null; // Nullable Reference Type 
            //Console.WriteLine(name02);
            ////helped the developer

            ////null forgiving operator !

            //string name03 = null!; // Nullable Reference Type 
            //Console.WriteLine(name03);

            #endregion

            #region Null-Conditional | Propagation operator
            //int[] numbers = { 1, 2, 3, 4 };           
            //int[]? numbers = null; 

            //for (int i = 0; /*i<null*/i<numbers?.Length; i++) { 
            //    Console.WriteLine(numbers[i]);
            //}


            //int? z = 10;
            //int? z = 10;
            //int? x = z?.HasValue;    //nonnullable int     int?  Value Has  --invalid

            //int y = z ?? 0;
            //Console.WriteLine(x);
            #endregion

            #endregion

            #region Conditional Statements

            #region Example 01 [Year Quarter] - [If,Switch With Numeric type using Constant Pattern]
            //Console.Write("Please Enter A Month Number Existed in 1st Quarter : ");

            //int.TryParse(Console.ReadLine(), out int monthNumber);

            #region if else
            //if (monthNumber == 1) {
            //    Console.WriteLine("January is in 1st Quarter");
            //}
            //else if (monthNumber == 2)
            //{
            //    Console.WriteLine("February is in 1st Quarter");
            //}
            //else if (monthNumber == 3)
            //{
            //    Console.WriteLine("March is in 1st Quarter");
            //}
            //else
            //{
            //    Console.WriteLine("Month Number is not in 1st Quarter");
            //}

            #endregion

            #region switch
            ///Jump Table, branch
            ///copilation time, il , not created,
            ///law htsa3dni  performance , memory, complexity -- sequential comparison
            ///Jump Table sequential + const
            /// arkam b3eda aw ranges Binary Search / if-else
            /// strings Hash Table + Equals

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("January is in 1st Quarter");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb is in 1st Quarter");
            //        break;
            //    case 3:
            //        Console.WriteLine("March is in 1st Quarter");
            //        break;
            //    default:
            //        Console.WriteLine("not 1st Quarter");
            //        break;
            //}

            #endregion

            //Console.ReadKey();
            #endregion

            #region Example 02 [Student Age] - [If,Switch With Numeric type using Relational Pattern]
            /// Age is greater than 22 => Student Age Is greater than 22 
            /// Age is Less than 22 => Student Age Is Less than 22 
            /// Age is 22 => Student Age is 22 

            //Console.Write("Please Enter Student Age : ");
            //int.TryParse(Console.ReadLine(), out int age);
            #region if else
            //if (age > 22)
            //    Console.WriteLine("Student Age Is greater than 22 ");
            //if (age < 22)
            //    Console.WriteLine("Student Age Is less than 22 ");
            //else
            //    Console.WriteLine("Student Age Is 22 ");

            #endregion

            #region switch
            // No Jump Table Will be Created
            // = will ignore
            // binary search , hash table

            //switch (age)
            //{
            //    case > 22:
            //        Console.WriteLine("Student Age Is greater than 22 ");
            //        break;
            //    case < 22:
            //        Console.WriteLine("Student Age Is less than 22 ");
            //        break;
            //    default:
            //        Console.WriteLine("Student Age Is 22 ");
            //        break;

            //}

            #endregion


            #endregion

            #region Example 03 [Student Name] - [If,Switch With String type]
            /// name = Omar => Hello Omar 
            /// name = May => Hello May 
            /// name = Fatma => Hello Fatma 

            //Console.Write("Enter Student Name : ");
            //string name = Console.ReadLine() ?? "No Name Entered";

            #region if else 
            //if (name == "Omar")
            //    Console.WriteLine("Hello Omar");
            //else if (name == "May")
            //    Console.WriteLine("Hello May");
            //else if (name == "Fatma")
            //    Console.WriteLine("Hello Aliaa");

            #endregion
            #region switch 
            //// No Jump Table Will Be Created
            //// Compiler will generate a sequence of string comparisons   
            ///cant switch on null    --large gap --low cases, not intger const
            ///

            //switch (name)   
            //{
            //    case "Omar":
            //        Console.WriteLine("Hello Omar");
            //        break;
            //    case "May":
            //        Console.WriteLine("Hello May");
            //        break;
            //    case "Aliaa":
            //        Console.WriteLine("Hello Aliaa");
            //        break;
            //}
            #endregion
            #endregion

            #region Example 04 [Budget] - [Switch With Goto]
            /// Budget is 1000 => Option 01
            /// Budget is 2000 => Option 01 , Option 02
            /// Budget is 3000 => Option 01 , Option 02 , Option 03

            //Console.Write("Please Enter Your Budget : ");
            //int.TryParse(Console.ReadLine(), out int Budget);

            //switch (Budget)
            //{
            //    case 1000:
            //        Console.WriteLine("Option 01");
            //        break;
            //    case 2000:
            //        Console.WriteLine("Option 02");
            //        //break;
            //        goto case 1000;
            //    case 3000:
            //        //Console.WriteLine("Option 01");
            //        //Console.WriteLine("Option 02");
            //        Console.WriteLine("Option 03");
            //        goto case 2000; //goto case 1000;
            //        //break;
            //}

            #endregion

            #region Goto  //break, continue, return, goto   not recommended spagetti code
            //start:
            //Console.WriteLine("Start");
            //goto end;
            //middle:
            //Console.WriteLine("Middle");
            //end:
            //Console.WriteLine("End");
            //goto middle;

            #endregion

            #endregion

            #region Evolution of switch in C#

            #region C# 7.0 [pattern matching - Case Guards (When)]
            // object number = 5.6;
            #region Example 01 [pattern matching on types]
            // no jump table
            //switch(number)
            //{
            //    case int value: //unboxing
            //        Console.WriteLine($"Integer: {value}");
            //        break;
            //    case decimal value:
            //        Console.WriteLine($"Decimal: {value}");
            //        break;
            //    case double value:
            //        Console.WriteLine($"Double: {value}");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown type");
            //        break;
            //}


            #endregion

            #region Example 02 [Case Guards (When)]
            //object number = 5.6;
            //// no jump table
            //switch (number)
            //{
            //    case int value when value < 10: 
            //        Console.WriteLine($"Integer: {value}");
            //        break;
            //    case int value when value >= 10:
            //        Console.WriteLine($"Integer: {value} is greater than or equal to 10");
            //        break;
            //    case decimal value when value < 10:
            //        Console.WriteLine($"Decimal: {value}");
            //        break;
            //    case decimal value when value >= 10:
            //        Console.WriteLine($"Decimal: {value} is greater than or equal to 10");
            //        break;
            //    case double value:
            //        Console.WriteLine($"Double: {value}");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown type");
            //        break;
            //}

            #endregion
            #endregion

            #region C# 8.0 [Pattern matching without alias name - Switch Expressions - Nullable Type]

            #region Example 01 - Pattern matching without alias name 
            //object number = 5.6;

            //switch (number)
            //{
            //    case int when (int)number < 10: //unboxing
            //        Console.WriteLine($"Integer: {number}");
            //        break;
            //    case decimal when (int)number < 10 :
            //        Console.WriteLine($"Decimal: {number}");
            //        break;
            //    case double :
            //        Console.WriteLine($"Double: {number}");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown type");
            //        break;
            //}

            #endregion

            #region Switch Case Before Switch Expression

            //string option = Console.ReadLine() ?? "0";
            //string message;

            //switch (option) 
            //{ 
            //    case "0":
            //        message = "You selected option 0";
            //        break;
            //    case "1":
            //        message = "You selected option 1";
            //        break;
            //    case "2":
            //        message = "You selected option 2";
            //        break;
            //    default:
            //        message = "Invalid option selected";
            //        break;
            //}
            //Console.WriteLine(message);

            #endregion

            #region Example 02 Switch Expressions [Constant Pattern - Discard Pattern]
            //string option = Console.ReadLine() ?? "0";
            //string message = option switch 
            //{
            //    "0" => "You selected option 0",
            //    "1" => "You selected option 1",
            //    "2" => "You selected option 2",
            //    _ => "Invalid option selected" 
            //};
            //Console.WriteLine(message);

            #endregion

            #region Example 03 [Nullable Type]
            //int? num = 10;
            //string result = num switch
            //{
            //    0 => "Zero",
            //    int when num > 0 => "greater",
            //    int when num < 0 => "less",
            //    null => "null",
            //    _ => "unknown"
            //};

            #endregion

            #endregion

            #region C# 9.0 [Switch Expression With Relational Patterns - Logical Patterns]

            #region Example 01 [Relational Patterns, Logical Patterns]
            /// Number Between 1 and 9 
            /// Number Between 10 and 20
            /// Number is Zero
            /// Number Outside the range
            /// 
            //int num = 15;
            //string result = num switch
            //{
            //    > 1 and < 9 => "Number Between 1 and 9 ",
            //    >= 10 and <=20 => "Number Between 10 and 20",
            //    0 => "Number is Zero",
            //    _ => "unknown"
            //};


            #endregion

            #endregion

            #endregion

            #region Looping | Iteration Statements

            #region for - foreach  //compiler optimize for loop + maintainnce
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);
            //Console.WriteLine(numbers[4]);
            //Console.WriteLine(numbers[5]);
            //Console.WriteLine(numbers[6]);
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[0]);

            //for (int i = 0; i < 10; i++ ) 
            //{
            //    if(i == 3)
            //    {
            //        //continue; //skip current iteration
            //        break;
            //    }
            //    Console.WriteLine(numbers[i]);
            //    //i++;
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //dispose

            //foreach (int number in numbers)  //get eumenator , move next (true, false), getcurrent
            //{
            //    //number += 10; //readonly
            //}

            #endregion

            #region while - do while

            #region do-while
            /// Let User Enter an Even Number 
            /// if value is an odd number -> Enter value again
            /// if it's not a number -> Enter value again
            /// if value is an even number -> Print number 

            //bool isParsed;
            //int number;
            //do
            //{
            //	Console.Write("Please Enter an Even Number : ");
            //	isParsed = int.TryParse(Console.ReadLine(), out number);

            //} while (!isParsed || number % 2 == 1);
            //// isParsed = true -> !isParsed = false || number % 2 == 1
            //// isParsed = false -> !isParsed = True 

            //Console.WriteLine($"{number} is an Even number");
            #endregion

            #region while 
            /// Take a number from user and print 
            /// a sequence of number from Entered number to 10

            //Console.Write("Enter a Number : ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            //if (isParsed)
            //{
            //	while (/*isParsed &&*/ number <= 10)
            //	{
            //		Console.WriteLine(number);
            //		number++;
            //	}

            //}


            #endregion

            #endregion

            #endregion

        }
    }
}
