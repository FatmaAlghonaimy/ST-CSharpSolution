
using System.Drawing;
using Common;
using Day4.Encapsulation;
using Day4.Enum;
namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class Library
            Class1 class1 = new Class1();
            #endregion

            #region Access Modifiers [Private - Internal - Public]
            // TypeA typeA = new TypeA();
            ////typeA.x = 1;// Invalid  // X is private [assessable within its Scope Only ]
            ////typeA.y = 1; // Invalid // Y is Internal [assessable within its Scope and in Same Project Only] 
            //typeA.z = 1; // Valid // Z is Public [assessable within its Scope , in Same Project and outside project]
            #endregion

            #region Struct 
            #region Example 01
            //Point p1; //not reference 
            //// Declare variable | Object From Type 'Point' 
            //// CLR Will Allocate 8 Unitintialized Bytes At Stack 


            //p1 = new Point();
            //Console.WriteLine(p1);
            //// New Is Just For Constructor Selection That Will Used To Initialize P1 Attribute 

            //p1 = new(5, 6); //default constructor //syntax suger

            //Console.WriteLine($"Point p1: x = {p1.x}, y = {p1.y}"); // Point p1: x = 0, y = 0

            //Point p2 = new Point(10, 20); //parameterized constructor
            //Console.WriteLine($"Point p2: x = {p2.x}, y = {p2.y}"); // Point p2: x = 10, y = 20
            //Point p3 = new Point(30); //constructor with one parameter
            //Console.WriteLine($"Point p3: x = {p3.x}, y = {p3.y}"); // Point p3: x = 30, y = 30

            #endregion

            #region Example 02
            //constructor selection
            //Point p1 = new Point(1,2);
            //Point p2 = new Point(10,20); //not reference 16 bytes in stack

            //p1 = p2;
            //Console.WriteLine($"Point p1: x = {p1.x}, y = {p1.y}"); // Point p1: x = 10, y = 20
            //Console.WriteLine($"Point p2: x = {p2.x}, y = {p2.y}"); // Point p2: x = 10, y = 20

            //p1.x = 100; //change p1.x
            //Console.WriteLine($"Point p1: x = {p1.x}, y = {p1.y}"); // Point p1: x = 100, y = 20
            //Console.WriteLine($"Point p2: x = {p2.x}, y = {p2.y}"); // Point p2: x = 10, y = 20


            #endregion

            #endregion

            #region Encapsulation

            #region Example 01 
            //Employee emp01 = new(10, "Ahmed");

            ////Console.WriteLine($"Employee ID: {emp01.Id}, Name: {emp01.Name}"); // Employee ID: 10, Name: Ahmed
            ////emp01.Id = 20;
            ////emp01.Name = "Ali";

            ////emp01.GetId(); //10
            ////emp01.SetId(20); //set id to 20

            //Console.WriteLine(emp01.Id); //property , readablitiy 

            ////emp01.SetName("Ahmed Mohamed ALi");
            ////Console.WriteLine(emp01.Name); // Ahmed M

            //Employee emp02 = new(20, "Ahmed Mohamed ALi");
            //Console.WriteLine(emp02.Name); // Ahmed M

            //Employee emp03 = new(30, "Ali", 5000);
            //emp03.Age = 30; 

            #endregion

            #region Example 02

            //PhoneNoteBook note01;
            //note01 = new(new string[] { "Ali", "Ahmed" }, new int[] { 123, 456 }, 2);

            //PhoneNoteBook note02 = new PhoneNoteBook(2); //create phone note book with size 5
            //note02.AdddPerson(0, "Ali", 1234567890);
            //note02.AdddPerson(1, "Ahmed", 987654310);
            //note02.AdddPerson(2, "Mohamed", 1234567890); //invalid, index out of range

            //Console.WriteLine($"Name: {note02.Names?[0]}, Number: {note02.Numbers?[0]}"); // Name: Ali, Number: 1234567890
            //Console.WriteLine($"Name: {note02.Names?[1]}, Number: {note02.Numbers?[1]}"); // Name: Ahmed, Number: 987654310
            //Console.WriteLine($"Name: {note02.names[2]}, Number: {note02.numbers[2]}"); //invalid, index out of range

            // Ali ===> number
            // number ===> ALi


            //Console.WriteLine($"Number of Ali: {note02.GetNumber("Ali")}"); // Number of Ali: 1234567890
            //note02.SetNumber("Ali", 1111111111); //change number of Ali
            //Console.WriteLine($"Number of Ali: {note02.GetNumber("Ali")}"); // Number of Ali: 1111111111

            //note02["Ali"] = 22222222; //change number of Ali using indexer
            //Console.WriteLine($"Number of Ali: {note02["Ali"]}"); // Number of Ali: 22222222

            /// note02[222222] ====>  ahmed
            /// 
            //for (int i = 0; i < note01.Size; i++)
            //{
            //    Console.WriteLine(note01[i]);
            //}

            //foreach (var item in note01) //get enumenator, get cuurent, move next, dispose
            //{
            //    Console.WriteLine(item);
            //}

            //PhoneNotebook[] notebooks = new PhoneNotebook[3];
            //foreach (var item in notebooks)
            //{
            //    Console.WriteLine(item);
            //}
            //Point[] p1 = new Point[] {
            //};
            //foreach (var item in p1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region Objects
            #region ToString()
            //value type
            // user defind, //built in
            //Point point = new Point(5, 10);
            //Console.WriteLine(point.ToString()); // demo.Point fully qualified name
            //Console.WriteLine(point); //to string
            //int x= 50;
            //Console.WriteLine(x); // 50

            //int[] arr = new int[] { 1, 2, 3 };
            //Console.WriteLine(arr); // System.Int32[] fully qualified name


            ////static and dynamic binding
            //object name = "Fatma";   //(string inherit object)  //sydtem.String  
            //Console.WriteLine(name); // Fatma   name.tostring tostring of child

            //object num = 15; //boxing    int = 15
            //Console.WriteLine(num); // 15 system.stuct32

            //object pointObj = new Point(3, 4); //(demo.point)
            //Console.WriteLine(pointObj); //override tostring

            #endregion

            #region Equals()
            //value type 

            //int x = 0;
            //int y = 0;
            //Console.WriteLine(x.Equals(y)); //x==y?  //values, stack , shallow equivalence

            //refernce 

            //int[] arr = { 1, 2, 3 };
            //int[] arr2 = { 1, 2, 3 };
            //Console.WriteLine(arr.Equals(arr2)); //references, in stack
            //string name1 = "Fatma"; 
            //string name2 = "fatma";
            ////string name2 = "Ali"; //new instance
            //Console.WriteLine(name1.Equals(name2)); // False, because values are not equal

            //user defined
            //sallow equivalence
            //Point point1 = new Point() { x = 10, y = 15 };
            //Point point2 = new Point() { x = 10, y = 15 };
            //Console.WriteLine(point1.Equals(point2)); // True, because values are equal
            ////refernce from parent, object from child, last override
            //object obj1 = new Point(1, 2); //
            ////Console.WriteLine(obj1.GetHashCode()); //the same behaviour , dynamic polymoriohism as value type

            //object obj2 = new Point(1, 2); //override Equals of object , values
            ////Console.WriteLine(obj2.GetHashCode());
            //Console.WriteLine(obj1.Equals(obj2)); //True //override, dynamic polymprphism
            ////values inside heap -- instances of objects

            //obj2 = obj1; // only one object in heap-- shallow copy
            //Console.WriteLine(obj2.Equals(obj1));

            #endregion

            #region GetHashCode()

            //value 
            //int x = 10;
            //Console.WriteLine(x.GetHashCode()); // 10

            //Point point1 = new Point() { x = 10, y = 15 };
            //Console.WriteLine(point1.GetHashCode()); // hash code of point1

            //refernce        static vs dynamic binding
            //object num1 = 123;  //boxing
            //Console.WriteLine(num1.GetHashCode()); // hash code of num1 123
            //object num2 = 123;
            //Console.WriteLine(num2.GetHashCode()); // hash code of num2 123

            //object name = "Fatma";
            //Console.WriteLine(name.GetHashCode()); // hash code of name Fatma
            //object name2 = "Fatma";
            //Console.WriteLine(name2.GetHashCode()); // hash code of name2 Fatma


            #endregion

            #region GetType()

            //fully qualified name
            //Point point = new Point(5, 10);
            //Console.WriteLine(point.GetType()); // Day4OOP.Point

            //int[] arr = new int[] { 1, 2, 3 };
            //Console.WriteLine(arr.GetType()); // System.Int32[]

            //object name = 123; 
            //Console.WriteLine(name.GetType()); // System.Int32

            #endregion

            #region Example 
            //object obj = new object();
            //obj = new string("Fatma");

            //obj = "Ali"; //boxing
            //int number = (int)obj; 
            #endregion
            #endregion

            #region Enum

            #region Example 01
            //Employee employee = new Employee(1, "Ahmed", 5000);

            ////employee.Gender = Enums.Gender.Male; 
            //employee.Gender = 0;
            //employee.Gender = (Gender)20;
            //Console.WriteLine(employee.Gender);

            #endregion

            #endregion

        }
    }
}
