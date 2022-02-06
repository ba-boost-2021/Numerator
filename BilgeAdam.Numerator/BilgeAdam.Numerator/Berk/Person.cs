using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Numerator.Berk
{
    internal class Person<T>
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public T userName { get; set; }
        public int age { get; set; }
        public DateTime birthDate { get; set; }
        public T Id { get; set; }
        public Gender gender { get; set; }
    }
    internal enum Gender
    {
        Male,
        Female
    }
}
