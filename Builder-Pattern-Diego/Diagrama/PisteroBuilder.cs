using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern_Diego.Diagrama
{
    class PisteroBuilder : CarroBuilder
    {
        public PisteroBuilder()
        {
            carro = new Carro("Pistero");
        }

        public override void construirCarroceria()
        {
            carro["carroceria"] = "Carbono";
        }

        public override void construirMotor()
        {
            carro["motor"] = "500cc";
        }

        public override void construirRuedas()
        {
            carro["ruedas"] = "Rodado 19";
        }
    }
}
