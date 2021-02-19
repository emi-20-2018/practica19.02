using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica19._02.Models
{
    public class User
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
