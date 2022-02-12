using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Factory_Method
{
    public class Cerveza : BebidaEmbriagante
    {
        public override int EmbriageHora()
        {
            return 5;
        }
    }
}
