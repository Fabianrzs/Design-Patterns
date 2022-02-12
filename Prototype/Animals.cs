using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeShallow
{
    public class Animals: ICloneable
    {
        public string? Name { get; set; }
        public int Leg { get; set; }

        public Object Clone() 
        {
            return this.MemberwiseClone();
        }
    }
}
