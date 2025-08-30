using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5OOP
{
    enum Branch : byte
    {
        noBranchYet,
        HR = 10,
        IT = 20,
        Finance = 30,
        Marketing = 40
    }
    [Flags]
    enum Permission : byte // byte 
    {
        Read = 1,   //00000001
        Write = 2,  //00000010
        Update = 4, //00000100
        Delete = 8, //00001000
                    // Test =16, //00010000 
    }
    struct Employee
    {
        public int Id { get; set; } // 4 byte
        public string? Name { get; set; } // 4 byte 
        public Branch Branch { get; set; } // byte
        //public bool[] Permissions { get; set; } = new bool[4]; //read write update delete  //4byte    16 byte
        //read write update delete   ^ & |
        // 1     0     1     1
        public Permission Permissions { get; set; } //byte    
        public Employee(int id, string name, Branch branch)
        {
            Id = id;
            Name = name;
            Branch = branch;

        }
        public override string ToString()
        {
            return $"ID :{Id}, Name {Name}, Branch {Branch}, Permissions {Permissions}";
        }
    }
}
