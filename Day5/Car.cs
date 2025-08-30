namespace Day5
{
    //internal, public
    internal class Car
    {
        //attributes, methods, properties, events
        #region Attributes
        int id; //4 bytes
        string? name; //4 bytes fro reference
        double speed; //8 bytes  ===> // 16 bytes in total for the object in heap
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"ID:{Id}, Model :{Name}, Speed:{Speed}";
        }
        #endregion

        #region Constructors
        // compiler will generate default constructor
        //public Car() { } //Empty Parameterless Constructor
        //public Car()
        //{
        //    Id = default;
        //    Name = default;
        //    Speed = default;
        //}

        // any other ctor hide the default constructor
        // constructor overloading

        //constructor chaining using this keyword
        public Car(int id, string? name, double speed)
        {
            Id = id;
            Name = name;
            Speed = speed;

            Console.WriteLine("first constructor");
        }

        public Car(int id, string? name) : this(id, name, 200)
        {
            //Id = id;
            //Name = name;
            //Speed = 200; // default speed

            Console.WriteLine("second constructor");

        }
        public Car(int id) : this(id, "Default Model")
        {
            //Id = id;
            //Name = "Default Model"; // default name
            //Speed = 150; // default speed

            Console.WriteLine("third constructor");
        }

        #endregion

    }
}
