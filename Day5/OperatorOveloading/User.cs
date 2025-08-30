using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.OperatorOveloading
{
    //Model Is a class that represents a user in the system from the database
    //poco , plain old CLR object
    class User
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Guid? SecurityStamp { get; set; }
    }
}
