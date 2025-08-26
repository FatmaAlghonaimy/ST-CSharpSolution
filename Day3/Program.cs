using System.Text;

namespace Day3
{
    // Struct - Class - Interface - Enum 
    internal class Program
    {
        // 1. Methods  Pascal case
        // 1.1 Class Member Method [Static Method] b esm el class
        // 1.2 Object Member Method [Non-Static Method] esm el object

        #region Methods  (dont forget to check on nulls on arrays and reference types in functions)
        //method overloading
        public static void PrintShape()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(":)");
            }
        }
        public static void PrintShape(string shape, int count = 7) //required , //optional parameters
        {
            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine(shape);
            }
        }

        //method overloading
        public static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        //public static int SumArray(int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        //public static int SumArray(ref int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}

        public static int SumArray(int[] arr)
        {
            int sum = 0;
            arr = new int[] { 1, 2, 3 };
            arr[0] = 100; // This will not affect the original array outside this method
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static int SumArray(ref int[] arr)
        {
            int sum = 0;
            arr = new int[] { 1, 2, 3 };
            arr[0] = 100; // This will not affect the original array outside this method
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static void SumSub(int x, int y, ref int sum, ref int sub)
        {
            //sum = x + y;
            //sub = x - y;
            //return sum;
            //return sub; 
            // return new int[] { sum, sub};
            //return [sum, sub];
            //DTO
            //return new DTO() { sum = sum, sub = sub }; // object initializer syntax
            //return new { sum, sub }; // anonymous type [Compiler in runtime create object]

        }

        public static void SumArray(out int sum, params int[] arr) //required ,default , params
        {
            //default value parmas must be the last parameter,  required, default, params
            //only one params parameter is allowed in a method signature.
            sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
        }

        public static void Concat<T>(params ReadOnlySpan<T> items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i]);
            }
        }

        #endregion
        static void Main(string[] args)
        {
            #region Functions 

            #region Function Prototype
            //Test test = new Test();
            //test.PrintShape();
            //PrintShape(10,"*"); //passing by order
            //PrintShape(count: 10, shape: "#"); //passing by name
            //PrintShape(); //passing by default value
            //int x = 10;
            //PrintShape("*");
            //PrintShape(@"/*\\");
            //PrintShape($"{{x}}");

            #endregion

            #region Function Parameters [Value Type]

            #region Passing by Value 
            //int a= 10, b = 20;
            //Swap(a, b); //passing by value
            //Console.WriteLine($"a = {a}, b = {b}");

            #endregion

            #region Passing By Reference 
            //int a = 10, b = 20;
            //Swap(ref a, ref b); //passing by reference
            //Console.WriteLine($"a = {a}, b = {b}");

            #endregion

            #endregion

            #region Function Parameters [Reference Type]

            #region Example 01 

            #region Passing By Value
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int result = SumArray(numbers);
            //Console.WriteLine($"Sum of array elements: {result}");
            //Console.WriteLine(numbers[0]);

            #endregion

            #region Passing by Reference 
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int result = SumArray(ref numbers);
            //Console.WriteLine($"Sum of array elements: {result}");
            //Console.WriteLine(numbers[0]);

            #endregion

            #endregion

            #region Example 02 

            #region Passing By Value
            //int[] numbers = { 1, 2, 3 };
            //int result = SumArray(numbers);
            //Console.WriteLine($"Sum of array elements: {result}");
            //Console.WriteLine(numbers[0]);

            #endregion

            #region Passing by Reference 
            //int[] numbers = { 1, 2, 3 };
            //int result = SumArray(ref numbers);
            //Console.WriteLine($"Sum of array elements: {result}");
            //Console.WriteLine(numbers[0]);

            #endregion

            #endregion

            #endregion

            #region Function Parameters [Passing By out]
            //elfunction btretuern 7aga wa7da bs as long as en ana msh mst5dma yield, ele hya bnst5dmha m3 foreach 
            //lazm  a initialze it inside function lakn 2bl msh lazm
            //int a = 10, b = 20;
            //int sum = 0, sub =0;
            //SumSub(a, b, ref sum, ref sub); 
            ////SumSub(a, b, out sum, out sub); 
            //Console.WriteLine($"Sum = {sum}, Sub = {sub}");
            //bool isparsed = int.TryParse("100000", out int result);

            #endregion

            #region Function Parameters [Params]

            #region Before C# 13
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //int result = SumArray(3, 4, 5, 6, 7, 8, 9, 10); //internally convert to array  //rest operator in js
            //Console.WriteLine($"Sum of array elements: {result}");
            #endregion

            #region After C# 13  .net 9
            //decimal y = 10.5m;
            //Concat<object>("Hello", 123, y, "Fatma", DateTime.Now);

            //string message = string.Format("Hello {0}, your balance is {1}", "Fatma", y);


            #endregion

            #endregion

            #endregion

            #region Arrays 

            #region 1D Array 

            #region Creation
            //string[] names = new string[5]; //fixed size array
            //int[] numbers = new int[4] {1,2,3,4 }; //fixed size array
            //int[] numbers02 = {1,2,3,4 }; //fixed size array
            //int[] arrv = new int[5];
            //Array array = new int[5]; //fixed size array
            //Array arr02 = new Array[5]; //fixed size array
            #endregion

            #region Initialization and Access

            //int[] numbers;
            /// Declare For Reference From Type Array "numbers"
            /// Reference "numbers" is Reffering To NULL
            /// Reference "numbers" Can Refer To An Object Of Type Array Of Int 
            /// CLR Will Allocate 4 Bytes At Stack For reference 
            /// 0 Bytes Allocated At Heap

            //Console.WriteLine(numbers[0]); // Invalid

            //numbers = new int[3];
            /// Allocate Required bytes At Heap [12 Bytes]
            /// Initialize Allocated bytes With Default Value [0 , 0 , 0]


            //Console.WriteLine("Length of array: " + numbers.Length);
            //Console.WriteLine("Rank:(Dimension of Array) " + numbers.Rank);

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //	Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine("=====================");

            //foreach (int item in numbers)
            //{
            //	Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region 2D Array [Rectangular]

            #region Creation
            //int[,] arr1 = new int[3, 4];
            /// CLR  Will Allocate 12 Bytes At Heap Initialized With Default Value 
            //int[,] arr2 = new int[2,3];
            //{ { 1, 2, 3 },
            //  { 4, 5, 6 } };
            #endregion

            #region Access
            ////length(0) rows, length(1) columns
            //Console.WriteLine("Length of array: " + arr2.Length +"Length(1) = " +  arr2.GetLength(1));
            //Console.WriteLine("Rank: " + arr2.Rank);

            //for (int i = 0; i < arr2.GetLength(0); i++ )
            //{
            //    Console.WriteLine($"Row {i}:");
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.Write($"arr[{i},{j}]" + " ");
            //        arr2[i,j] = int.Parse(Console.ReadLine()??"0");
            //    }
            //}
            #endregion


            #endregion

            #region Jagged Array  

            //int[][] jaggedArray = new int[3][];

            //rank 1 === one d array o

            //jaggedArray[0] = new int[2]; // First row with 2 elements
            //jaggedArray[1] = new int[3]; // Second row with 3 elements
            //jaggedArray[2] = new int[4]; // Third row with 4 elements

            //int[][] jaggedArray = new int[][]
            //{
            //    new int[]{1,2,3},
            //    new int[]{4,5,6,7},
            //    new int[]{8,9,10,11,12}
            //};

            //Console.WriteLine("Length of array: " + jaggedArray[0].Length );
            //Console.WriteLine("Rank: " + jaggedArray[0].Rank);

            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.WriteLine($"Row {i}:");
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write($"arr[{i},{j}]" + " ");
            //        jaggedArray[i][j] = int.Parse(Console.ReadLine() ?? "0");
            //    }
            //}

            #endregion

            #endregion

            #region Array Methods

            //int[] numbers1 = { 1, 5,8,3,9,2 };
            //int[] numbers2 = { 10, 20, 30 };
            ////Array.Sort(numbers);
            ////Array.Reverse(numbers);
            ////Array.Clear(numbers); //clear first two elements
            ////Array.Clear(numbers, 1, 3);
            ////Array.Resize(ref numbers, 10); //resize the array to 10 elements
            ////Array.Copy(numbers2, numbers1, 3); //copy first 3 elements from numbers1 to numbers2
            //Array.ConstrainedCopy(numbers2, 1, numbers1, 4, 2); //copy first 3 elements from numbers2 to numbers1
            //foreach (var item in numbers1)
            //{
            //    Console.WriteLine(item);

            //}
            ////Console.WriteLine("Arr[0] = " + numbers[2]);

            #endregion

            #region string 
            //string name01; 

            //name = new string("Fatma");

            //name01  = "Fatma"; //syntax suger
            //Console.WriteLine(name01.GetHashCode()); 
            //string name02 = "Amr";
            //Console.WriteLine(name02.GetHashCode());
            //Console.WriteLine("------------------------------");

            //name02 = name01;
            //Console.WriteLine(name01.GetHashCode());
            //Console.WriteLine(name02.GetHashCode());

            //Console.WriteLine("------------------------------");

            //name01 = "Ahmed";

            //Console.WriteLine(name01.GetHashCode());
            //Console.WriteLine(name02.GetHashCode());

            //string message =  "Hello";
            //Console.WriteLine(message.GetHashCode());
            //message += " World";
            //Console.WriteLine(message.GetHashCode());


            //string name02 = "Hello"; //  string literal 
            //						 //CLR Will checks if the string "Hello" already exists
            //						 //in the string pool (a memory cache of string literals).
            //						 //If it does, it reuses the same memory location;
            //						 //if not, it adds the string to the pool.

            //the same HashCode of message

            #endregion

            #region string Methods

            //string message =  "Hello ITI";
            //Console.WriteLine(message.Length);
            //Console.WriteLine(message.ToUpper()); //HRLLO 
            //Console.WriteLine(message.ToLower()); //hello
            //Console.WriteLine(message.Trim()); //remove leading and trailing spaces  //Hello
            //Console.WriteLine(message.TrimStart()); //remove leading spaces  //Hello
            //Console.WriteLine(message.TrimEnd()); //remove trailing spaces  //     Hello
            //Console.WriteLine(message.Substring(3));
            //Console.WriteLine(message.Substring(3, 2)); //lo
            //Console.WriteLine(message.Replace("e", "M")); //HMllo ITI
            //Console.WriteLine(message.Contains("M")); //true
            //Console.WriteLine(message.IndexOf("IT")); //4
            #endregion

            #region stringbuilder 

            //StringBuilder sb;
            /// Declare For a Reference From type StringBuilder "sb"
            /// Reference "sb" is Referring to Default Value Of Reference Type [Null]
            /// CLR Will Allocate 4 Bytes at Stack For Reference "sb"
            /// 0 Bytes Allocated At Heap 

            //sb = new StringBuilder()
            //sb.Append("Hello");
            //Console.WriteLine(sb.GetHashCode());//58225482
            //Console.WriteLine("------------------------------");

            //sb.Append(" World");
            //Console.WriteLine(sb.GetHashCode()); //58225482

            #endregion

            #region stringbuilder Methods
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hello");
            //sb.AppendLine(" World");
            //int age = 23;
            ////sb.AppendFormat("You age is {0}", age);
            //sb.AppendJoin("_", "Fatma", "Alaa", "Algonaimy");
            //Console.WriteLine(sb);
            //sb.Replace("World", "ITI");

            //Console.WriteLine(sb);

            ////sb.Clear(); 
            //sb.Remove(1, 3);
            //Console.WriteLine(sb);

            #endregion
        }
    }
}