using System;

namespace Singleton
{
    public  class Program
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine(Singleton.Instance.mensaje);
            Console.ReadKey();
        }
    }
}

//Una solo instancia del objeto cuando se manejan muchos ususarios o transacciones 