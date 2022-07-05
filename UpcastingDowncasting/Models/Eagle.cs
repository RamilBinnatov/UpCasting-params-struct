using System;
using System.Collections.Generic;
using System.Text;

namespace UpcastingDowncasting.Models
{
     public class Eagle : Bird
    {
        public string Age { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eagle Eating");
        }

        
    }
}
