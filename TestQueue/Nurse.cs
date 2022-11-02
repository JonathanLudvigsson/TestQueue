using System;
using System.Collections.Generic;
using System.Text;

namespace TestQueue
{
    public class Nurse : Person
    {
        public decimal Salary { get; set; }
        public float WorkTime { get; set; }
        public bool IsNurse { get; set; }

        public void TakeBloodTest()
        {
            Console.WriteLine($"{Name} tar ett blodtest");
        }
    }
}
