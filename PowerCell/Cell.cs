using System;
using System.Security.Authentication;


namespace PowerCell
{
    public class Cell
    {
        private float Charge;
        private readonly string Name;
    
        private readonly int Level = 1 + (int)Charge/40;


        public Cell(string name, int charge = 200)
        {
            this.Name = name;
            this.Charge = charge;
        }

        public void Consume(float amount)
        {
            this.Charge -= amount;
        }

        public void Restore()
        {
            this.Charge = 200;
        }
    }
}