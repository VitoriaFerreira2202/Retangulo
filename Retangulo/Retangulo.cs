using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    class Retangulo
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }

        public  Retangulo(double ladoA,double ladoB)
        {
            LadoA = ladoA;
            LadoB = ladoB;
        }

        public double CalcArea()
        {

            return Math.Abs((LadoA * LadoA)+(LadoB*LadoB));
        }

        public double CalcPerimetro() 
        {
            return Math.Abs(LadoA + LadoB+LadoA+LadoB);
        }






    }
}
