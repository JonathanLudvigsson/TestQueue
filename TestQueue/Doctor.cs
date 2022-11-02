using System;
using System.Collections.Generic;
using System.Text;

namespace TestQueue
{
    public class Doctor : Person
    {
        public decimal Salary { get; set; }
        public float WorkTime { get; set; }

        public void WriteReceipt(Patient p)
        {
            p.HasReceipt = true;
        }
    }
}
