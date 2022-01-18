using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern_Diego.Diagrama
{
    class ScooterBuilder : CarroBuilder
    {
        public ScooterBuilder()
        {
            carro = new Carro("Scooter");
        }

        public override void construirCarroceria()
        {
            carro["carroceria"] = "Hierro";
        }

        public override void construirMotor()
        {
            carro["motor"] = "50cc";
        }

        public override void construirRuedas()
        {
            carro["ruedas"] = "Rodado 14";
        }
    }
}