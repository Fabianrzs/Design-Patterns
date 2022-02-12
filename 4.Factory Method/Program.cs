using _4.Factory_Method;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Bebida = Creador.CreadorBebida((int)BEBIDA.CERVEZA);
            Console.WriteLine(Bebida.EmbriageHora());

            var Bebida1 = Creador.CreadorBebida((int)BEBIDA.CERVEZA);
            Console.WriteLine(Bebida1.EmbriageHora());
            Console.ReadKey();
        }

    }

    
}