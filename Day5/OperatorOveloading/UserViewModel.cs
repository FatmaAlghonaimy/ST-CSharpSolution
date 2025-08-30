using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.OperatorOveloading
{
    class UserViewModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public static implicit operator UserViewModel(User user)
        {

            string[]? names = user?.FullName?.Split(' ');
            return new UserViewModel
            {
                Id = user?.Id ?? 0,
                FirstName = names?[0] ?? string.Empty ,
                LastName = names?[1] ?? string.Empty,
                Email = user?.Email
            };
        }
        public override string ToString()
        {
            return $"Id{Id}, FirstName{FirstName}, Last{LastName}, Email{Email}";
        }
    }
}
