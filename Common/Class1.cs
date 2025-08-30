namespace Common
{
    public class Class1
    {
        ///no main -- this is a class library 
        /// it does not have an entry point because it is not an executable program
        /// it doesnt jit  , only dll 
        ///

       
        public void Test()
        {
            #region B Attributes + Access modifiers after inheritance from A
            //x = 1; //invalid 
            //y = 2;  internal
            //z = 3;  public
            //a = 4;  private 
            //b = 5;  private
            //c = 6;  internal
            #endregion

            #region What To Access From B After Inheritance From A
            TypeB typeb = new TypeB();
            //typeb.x = 1; //invalid
            typeb.y = 2; //valid //internal accessible within the same project
            typeb.z = 3; //valid //public accessible anywhere
            //typeb.a = 4; //invalid //private
            //typeb.b = 5; //invalid //private
            typeb.c = 6; //valid //internal accessible within the same project
            #endregion
        }
    }
}
