using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDeep
{
    public class Animals : ICloneable
    {
        public string? Name { get; set; }
        public int Leg { get; set; }
        public Detalle Detalle { get; set; }

        public Object Clone()
        {
            Animals animalsClone = (Animals)this.MemberwiseClone();
            Detalle d = new Detalle();    
            d.Raza = this.Detalle.Raza;
            d.Color = this.Detalle.Color;
            animalsClone.Detalle = d;
            return animalsClone;
        }
    }

    public class Detalle
    {
        public string Raza { get; set; }
        public string Color { get; set; }
    }
}