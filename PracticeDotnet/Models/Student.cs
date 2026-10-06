using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeDotnet.Models
{
    public class Student
    {
        public Guid Id { get; set; } = Guid.CreateVersion7();
        // public string Name { get; set; }
        // public string Department { get; set; }
        // public string Major { get; set; }
    }
}