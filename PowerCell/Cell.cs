using System;
using System.Security.Authentication;


namespace PowerCell
{
    public class Cell
    {
        public float Charge {get;set;}
        public readonly string Name;

        //public int Level = 1 + (int)(Charge / 20);


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

        public override string ToString()
        {
            return $"[{this.Name}] Level: {1 + (int)Charge / 40}: {this.Charge}/200";
        }
    }
}