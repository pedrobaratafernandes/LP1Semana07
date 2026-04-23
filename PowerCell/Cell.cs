using System;


namespace PowerCell
{
    public class Cell
    {
        private float charge;
        private readonly string Name;


        public Cell(string name, int charge = 200)
        {

        }

        public void Consume(float amount)
        {
            
        }

        public void Restore()
        {
            this.charge = 200;
        }
    }
}