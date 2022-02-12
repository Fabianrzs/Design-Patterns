using System;

namespace PrototypeDeep
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animals animals = new Animals() { Name = "Doli", Leg = 4};
            animals.Detalle = new Detalle() {Color="Blanco", Raza = "Oo" };

            Animals animalsClone = animals.Clone() as Animals;

            Console.WriteLine(animalsClone.Name);
            Console.WriteLine(animalsClone.Leg);
            Console.WriteLine(animalsClone.Detalle.ToString());
            Console.WriteLine(animals.Name);
            Console.WriteLine(animals.Leg);
            Console.WriteLine(animals.Detalle.ToString());

        }
    }
}