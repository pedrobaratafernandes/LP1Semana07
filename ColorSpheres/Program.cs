using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color cor = new Color(100, 150, 200);
            Console.WriteLine($"{cor.Red}, {cor.Green}, {cor.Blue}, {cor.Alpha}");
            Console.WriteLine($"{cor.GetGrey()}");
            Sphere bola1 = new Sphere(cor, 10);
            bola1.Throw();
            bola1.Throw();

            Console.WriteLine($"Vezes atirada: {bola1.GetTimesThrown()}");

            bola1.Pop();
            bola1.Throw();

            Console.WriteLine($"Vezes atirada após Pop: {bola1.GetTimesThrown()}");


        }
    }
}
