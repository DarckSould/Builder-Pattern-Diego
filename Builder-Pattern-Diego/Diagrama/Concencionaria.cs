using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern_Diego.Diagrama
{
    class Concecionaria
    {
        public void Construct(CarroBuilder carroBuilder)
        {
            carroBuilder.construirMotor();
            carroBuilder.construirCarroceria();
            carroBuilder.construirRuedas();
        }
    }
}