using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting_Boxing_Unboxing.Models
{
    class Eagle : Bird
    {
        public string  Color { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eagle eating");
        }
    }
}
