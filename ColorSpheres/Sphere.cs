using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {

        private Color Cor { get; set; }
        private float Raio { get; set; }
        private int VezesAtirada { get; set; }

        public Sphere(Color cor, float raio)
        {
            Cor = cor;
            Raio = raio;
            VezesAtirada = 0;
        }

        public void Pop()
        {
            Raio = 0;
        }

        public void Throw()
        {
            if (Raio > 0)
            {
                VezesAtirada++;
            }
        }

        public int GetTimesThrown()
        {
            return VezesAtirada;
        }
    }
}