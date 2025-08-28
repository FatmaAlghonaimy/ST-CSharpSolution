namespace Day4
{
    class GenericObject
    {
        //public void Print<T>(T item)
        //{
        //    Console.WriteLine(item);
        //}
        //public void Print(int message) { 
        //    Console.WriteLine(message);
        //}      
        //public void Print(double message) { 
        //    Console.WriteLine(message);
        //} 
        public void Print(object item) //boxing 
        {
            Console.WriteLine(item);
        }
        public void TestPrint()
        {
            Print(10); // T is int
            //Print<string>("Hello"); // T is string
            Print(3.14); // T is double
        }
    }

}
