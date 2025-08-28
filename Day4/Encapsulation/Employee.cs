using Day4.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Encapsulation
{
    struct Employee
    {
        private int id; //PascalCase
        string? name;
        Gender gender;
        public Employee(int _id, string? _name, decimal salary)
        {
            id = _id;
            Name = _name;
            Salary = salary;
            gender = Gender.none;
        }

        /// <summary>
        /// Encapsulation 
        /// Separate Data Definition [Attributes] From Its Use [Getter Setter , Property]
        /// </summary>
        #region Setter and Getter
        public int GetId()
        {
            return Id;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public string? GetName()
        {
            return Name;
        }
        public void SetName(string? name)
        {
            Name = name?.Length > 5 ? name.Substring(0, 5) : name;
        }
        #endregion

        #region Properties

        //1-Full Property

        public Gender Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string? Name
        {
            get
            {
                return name;
            }
            set
            {
                //name = value;
                name = value?.Length > 5 ? value.Substring(0, 5) : value;
            }
        }
        // 2 - atuomatic property
        public decimal Salary { get; set; }

        public int Age { get; } //readonly
        //private int age;
        //private decimal salary;
        //backing field property private hidden attribute

        #endregion
    }
}
