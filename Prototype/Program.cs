namespace PrototypeShallow
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animals animals = new Animals() { Name = "pillous", Leg = 2};
            Animals animalsClone = animals.Clone() as Animals;
            animalsClone.Name = "opilos";
            animalsClone.Leg = 4;
            Console.WriteLine(animalsClone.ToString());
            Console.WriteLine(animals.ToString());
            Console.ReadKey();
        }
    }
}

//Clonar objetos superficialmente

