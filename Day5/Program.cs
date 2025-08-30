using Day5.Inheritance;
using Day5.OperatorOveloading;

namespace Day5
{
    internal class Program
    {
        #region Method Overloading
        static int Sum(int a, int b)
        {
            return a + b;
        }
        // Cant overload by changing return type only
        //static double Sum(int a, int b)
        //{
        //    return (double)(a + b);
        //}
        static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        // not overloading because the same logic
        static double Sum(double x, int y)
        {
            return x + y;
        }
        static double Sum(int x, double y)
        {
            return x + y;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Continue Enum
            #region Example 02 TryParse Enum
            //take data from user
            //print

            //Employee employee = new Employee();
            //employee.Id = 1;
            //employee.Name = "John Doe";
            //bool isParsed;
            //object? branchValue;
            //Branch branch; //valuetype

            //do
            //{
            //    Console.WriteLine("Enter Branch (HR, IT, Finance, Marketing): ");
            //    isParsed = Enum.TryParse(typeof(Branch), Console.ReadLine() ?? "0", out branchValue); //employee.Branch invalid because not ref
            //} while (!isParsed || branchValue is null);
            //employee.Branch = (Branch)branchValue;

            //Console.WriteLine(employee);

            //do
            //{
            //    Console.WriteLine("Enter Branch (HR, IT, Finance, Marketing): ");
            //    isParsed = Enum.TryParse(Console.ReadLine() ?? "0", out branch);
            //} while (!isParsed);
            //employee.Branch = branch;

            //Console.WriteLine(employee);


            #endregion

            #region Example 03 - Permissions
            //Employee employee = new Employee(1, "John Doe", Branch.IT);
            //employee.Permissions[0] = true; //read
            //employee.Permissions[1] = false; //write
            //employee.Permissions[2] = true; //update
            //employee.Permissions[3] = true; //delete        //16 byte

            //employee.Permissions = (Permission)3;  //0011
            //Console.WriteLine(employee);
            //employee.Permissions = (Permission)16;  //0011
            //Console.WriteLine(employee);

            //add permission 

            //employee.Permissions = Permission.Read | Permission.Write; //0001
            //                                                           //0010 =
            //                                                           //0011 

            //employee.Permissions |= Permission.Update;                   //0100 ( 0111  | 0010)

            //employee.Permissions |= Permission.Write;
            //Console.WriteLine(employee);

            ////and ,
            //// Deny All Permissions to User Except Write
            //employee.Permissions = employee.Permissions & Permission.Write;
            //Console.WriteLine(employee);


            //if ((employee.Permissions & Permission.Delete) == Permission.Delete) {
            //    Console.WriteLine("Employee has delete Permission");
            //}
            //else
            //{
            //    Console.WriteLine("Employee does not have delete Permission");

            //}
            //Console.WriteLine(employee);

            //employee.Permissions = (Permission)10; //delete , write 
            ////Console.WriteLine(employee);

            //employee.Permissions = employee.Permissions ^ Permission.Delete; //removed delete
            ////Console.WriteLine(employee);

            //employee.Permissions = employee.Permissions ^ Permission.Update; //write , update
            ////Console.WriteLine(employee);
            ////employee.Permissions = employee.Permissions ^ Permission.Update; //write , update
            //Console.WriteLine(employee);


            //// Check is User Has Permission Delete Permission or not if not add it to him/her
            //if((employee.Permissions & Permission.Delete) == Permission.Delete) {
            //    Console.WriteLine("Employee has delete Permission");
            //}
            //else
            //{
            //    employee.Permissions |= Permission.Delete;
            //}
            //Console.WriteLine(employee);


            #endregion
            #endregion

            #region Class

            #region Example 01 
            //Car car1;
            //reference , stack  4 byte  = null
            // object from its type , object mn ay class inheried mny

            //car1 = new Car(); //default constructor
            //constructor sleection //struct
            //1- 16 byte in heap
            //2- call defualt constructor -- if exist

            //car1 = new Car(10,"BMW", 300); 

            //Console.WriteLine(car1);
            #endregion

            #region Constructor Overloading - Constructor Chaining
            //Car car2 = new Car(20, "Audi", 250);

            //Car car3 = new Car(30, "Mercedes");
            //Console.WriteLine(car3);

            //Car car4 = new Car(40);
            //Console.WriteLine(car4);

            #endregion

            #endregion

            #region Inheritance 
            //Parent parent = new Parent(10, 20);
            //Console.WriteLine(parent);
            //Console.WriteLine(parent.Product());


            //Parent p2 = new Child(10, 20, 30); //upcasting

            //Child child = new Child(10, 20, 30); 
            //Console.WriteLine(child);
            //Console.WriteLine(child.Product());
            #endregion

            #region Continue Access Mofidiers 

            #region Type A 
            //TypeA typeA = new TypeA();
            //typeA.x = 10; //invalid -- x is private in TypeA
            //typeA.y = 10; //invalid -- y is internal in TypeA
            //typeA.z = 10; //valid -- public in TypeA
            //typeA.a = 10; //invalid -- a is private protected in TypeA
            //typeA.b = 10; //invalid -- b is protected in TypeA
            //typeA.c = 10; //invalid -- c is internal protected in TypeA
            #endregion

            #region Type B
            #region Type B Attributes
            //x = 1; //invalid 
            //y = 2;  [internal]
            //z = 3;  [public]
            //a = 4;  [private] 
            //b = 5;  [private]
            //c = 6;  [internal]
            #endregion
            //TypeB typeB = new TypeB();
            //typeB.x = 1; //invalid
            //typeB.y = 2; //invalid
            //typeB.z = 3; //valid
            //typeB.a = 4; //invalid
            //typeB.b = 5; //invalid
            //typeB.c = 6; //invalid
            #endregion

            #region Type D
            #region Type D Attributes
            //x = 1; //invalid -- not inherited
            //y = 2; //invalid -- not inherited outside assembly
            //z = 3; //valid //inherited as [public] anywhere

            //a = 1; //invalid -- not inherited outside assembly
            //b = 2; //valid -- inherited as private anywhere
            //c = 3; //valid -- inherited as private outside assembly
            #endregion

            //TypeD typeD = new TypeD();
            //typeD.x = 1; //invalid
            //typeD.y = 1; //invalid 
            //typeD.z = 1; //valid -- public
            //typeD.a = 1; //invalid 
            //typeD.b = 1; //invalid 
            //typeD.c = 1; //invalid
            #endregion

            #endregion

            #region Method Overloading
            //int A = 5;
            //int B = 10;
            //int result = Sum(A, B);
            //Console.WriteLine($"Sum of {A} and {B} is {result}");

            //result = Sum(A, B, 15);
            //double x = 10.5;
            //result = (int)Sum(x, B);


            //Console.WriteLine() //habe built in overloads
            #endregion

            #region Operator Overloading

            #region Binary Operators
            //Complex c1 = new Complex() {Real = 2, Imag = 3 }; // 2 + 3i
            //Complex c2 = new Complex() { Real = 4, Imag = 5 }; // 4 + 5i
            ////Complex c1 = null;

            //Complex c3 = c1 + c2; //class  Complex
            ////Console.WriteLine($"c1 + c2 = {c3}"); // 6 + 8i

            //Complex c4 = c1 - c2;

            #endregion

            #region Unary Operators
            /////c1++; ++c1; --c1; // increment operator overloading
            //c1 = c1 + 1;

            //Console.WriteLine($"c1 = {++c1}"); // 3 + 3i  prefix
            //Console.WriteLine($"c1 = {c1++}"); // 4 + 3i  postfix

            #endregion

            #region Relational Operators  
            //Complex c1 = new Complex() { Real = 2, Imag = 3 }; // 2 + 3i
            //Complex c2 = new Complex() { Real = 4, Imag = 5 }; // 4 + 5i
            //if (c1 > c2)
            //{
            //    Console.WriteLine("c1 is greater than c2");
            //}
            //else if (c1 < c2)
            //{
            //    Console.WriteLine("c1 is less than c2");
            //}
            //else
            //{
            //    Console.WriteLine("c1 is equal to c2");
            //}

            #endregion

            #region Casting Operator Overloading 

            //Complex C1 = new Complex() { Real = 2, Imag = 3 }; // 2 + 3i
            //int x = (int)C1; //explicit ,
            //Console.WriteLine(x);
            ////int x = C1; 

            ////string str = C1;
            //string str = (string)C1;  //implicit can be used as explicit

            //Console.WriteLine(str); // "2 + 3i"

            #endregion

            #region User Defined Datatype Casting Operator overloading [Mapping]
            //User user = new User()
            //{
            //    Id = 10,
            //    FullName = "John Doe",
            //    Email = "email",
            //    Password = "password",
            //    SecurityStamp = Guid.NewGuid(),
            //};

            //UserViewModel userViewModel1 = (UserViewModel) user;
            //Console.WriteLine(userViewModel1);

            //automapper
            #endregion
            #endregion
        }
    }
}
