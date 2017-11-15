using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazce
{
    sealed class Kruh:Obrazec, IKreslenie, IZmenRozmer
    {
        double polomer;

        public Kruh(double polomer)
        {
            this.polomer = polomer;
        }

        public override double VypocitajObsah()
        {
            return Math.PI * polomer * polomer;
        }

        public void Vykresli()
        {
            Console.WriteLine("Kreslím kruh");
        }
        
        public void Vytlac()
        {
            Console.WriteLine("Tlačím kruh");
        }

        public void ZmenRozmer(double rozdiel)
        {
            polomer = polomer - rozdiel;
        }

    }
}
