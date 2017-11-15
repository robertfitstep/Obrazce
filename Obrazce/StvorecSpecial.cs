using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazce
{
    partial class Stvorec
    {
        public static bool Porovnaj(Stvorec stvorec1, Stvorec stvorec2)
        {
            return stvorec1.strana == stvorec2.strana;
        }
    }
}
