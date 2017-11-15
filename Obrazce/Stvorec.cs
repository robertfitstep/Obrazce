using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazce
{
    partial class Stvorec:Obrazec, IKreslenie, IZmenRozmer
    {
        double strana;

        public Stvorec(double strana)
        {
            this.strana = strana;
        }

        public override double VypocitajObsah()
        {
            return strana * strana;
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
            strana = strana - rozdiel;
        }
    }
}
