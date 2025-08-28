using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day4.Encapsulation
{
    internal struct PhoneNoteBook //: IEnumerable
    {
        #region Attributes -- Properties
        public string[]? Names { get; set; } //private name
        public int[]? Numbers { get; set; }
        public int Size { get; set; }

        #endregion

        #region Constructor
        public PhoneNoteBook(string[]? names, int[]? numbers, int size)
        {
            Names = names;
            Numbers = numbers;
            Size = Size;
        }
        public PhoneNoteBook(int size)
        {
            Names = new string[size];
            Numbers = new int[size];
            Size = size;
        }
        #endregion

        #region Methods

        public void AdddPerson(int position, string name, int number)
        {
            if (Names is not null && Numbers is not null)
            {
                if (position < Size && position >= 0)
                {
                    Names[position] = name;
                    Numbers[position] = number;

                }
                else
                {
                    Console.WriteLine("Invalid position.");
                    return;
                }
            }
        }
        #endregion

        #region Setter and Getter
        public int GetNumber(string name)
        {
            if (Names is not null && Numbers is not null)
            {
                for (int i = 0; i < Size; i++)
                {
                    if (name == Names[i])
                        return Numbers[i];
                }
            }
            return -1; //not found
        }
        public void SetNumber(string name, int NewNumber)
        {
            if (Names is not null && Numbers is not null)
            {
                for (int i = 0; i < Size; i++)
                {
                    if (name == Names[i])
                    {
                        Numbers[i] = NewNumber;
                        return;
                    }
                }
            }
            Console.WriteLine("Name not found.");
        }

        #endregion

        #region Properties (indexer)
        /// <summary>
        /// Is a Special Property [Named With Keyword This and Can Take Parameters]
        /// </summary>
        public string this[int number]
        {
            get
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < Size; i++)
                    {
                        if (number == Numbers[i])
                            return Names[i];
                    }
                }
                return "";
            }
            set
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < Size; i++)
                    {
                        if (number == Numbers[i])
                        {
                            Names[i] = value;
                            return;
                        }
                    }
                }
            }
        }
        public int this[string Name]
        {
            get
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < Size; i++)
                    {
                        if (Name == Names[i])
                            return Numbers[i];
                    }
                }
                return -1; //not found } //return empty array if numbers is null
            }
            set
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < Size; i++)
                    {
                        if (Name == Names[i])
                        {
                            Numbers[i] = value;
                            return;
                        }
                    }
                }
            }
        }
        //public string this[int index]
        //{
        //    get
        //    {
        //        return "position: " + index + ", name: " + Names[index] + ", number: " + Numbers[index];
        //    }
        //}
        #endregion

        #region IEnumerable Implementation
        //public IEnumerator GetEnumerator()
        //{
        //    if (Names is not null && Numbers is not null)
        //    {
        //        for (int i = 0; i < Size; i++)
        //        {
        //            yield return $"Name: {Names[i]}, Number: {Numbers[i]}";
        //        }
        //    }
        //}

        //public IEnumerator GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
        #endregion
    }
}

