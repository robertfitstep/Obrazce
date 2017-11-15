using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazce
{
    class Program
    {
        static void Main(string[] args)
        {
            Obrazec kruh = new Kruh(3.4);
            Console.WriteLine("Obsah kruhu = {0}", kruh.VypocitajObsah());

            Stvorec stvorec = new Stvorec(3.4);
            Console.WriteLine("Obsah štvorca = {0}", stvorec.VypocitajObsah());

            Stvorec stvorec2 = new Stvorec(3.4);

            Console.WriteLine("Strany dvoch štvorcou sú rovnaké = {0}", Stvorec.Porovnaj(stvorec,stvorec2));

            IKreslenie k = stvorec2;
            IKreslenie k1 = new Kruh(10.2);

            k.Vykresli();
            k1.Vytlac();

            Kruh kruh1 = new Kruh(2);
            IZmenRozmer zmenaKruhu = kruh1;
            zmenaKruhu.ZmenRozmer(2);
            Console.WriteLine(kruh1.VypocitajObsah());

            Stvorec stvorec3 = new Stvorec(4);
            IZmenRozmer zmenaStvorca = stvorec3;
            zmenaStvorca.ZmenRozmer(2);
            Console.WriteLine(stvorec3.VypocitajObsah());


            Console.ReadLine();
        }
    }
}
