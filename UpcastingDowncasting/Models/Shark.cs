using System;


namespace UpcastingDowncasting.Models
{
    class Shark : Fish
    {
        public int Weight { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Shark eating");
        }
    }
}
