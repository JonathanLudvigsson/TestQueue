using System;
using System.Collections.Generic;
using System.Text;

namespace TestQueue
{
    public class Patient : Person
    {
        public string Sickness { get; set; }
        public DateTime TimeOfReg { get; set; }
        public DateTime TimeOfDepart { get; set; }
        public bool HasReceipt { get; set; }

    }
}
