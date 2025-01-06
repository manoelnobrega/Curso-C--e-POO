using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7 {
    internal class ConversorDeMoeda {
        
        public static double Iof = 0.06;

        public static double CalculoDolarReal(double cot, double dol) {
            return (cot * dol) + ((cot * dol) * Iof);
        }
    }
}
