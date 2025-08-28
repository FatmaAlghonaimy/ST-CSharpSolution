namespace Common
{
    public class Class1
    {
        public void Method()
        {
            TypeA typeA = new TypeA();
            typeA.x = 1; //public
            typeA.y = 2; //internal
            //typeA.z = 2; //private
        }
    }
}
