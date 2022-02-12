using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Factory_Method
{
    public class Creador
    {
        

        public static BebidaEmbriagante CreadorBebida(int opc)
        {
            switch (opc)
            {
                case (int)BEBIDA.VINO_TINTO:
                    return new VinoTinto();
                case (int)BEBIDA.CERVEZA:
                    return new Cerveza();
                default: throw new ArgumentOutOfRangeException();  
            }
        }

    }

    public enum BEBIDA
    {
        VINO_TINTO = 1,
            CERVEZA = 2
    }
}
