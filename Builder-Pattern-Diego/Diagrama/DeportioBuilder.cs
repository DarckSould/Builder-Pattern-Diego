using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern_Diego.Diagrama
{
    class DeportioBuilder : CarroBuilder
    {
        public DeportioBuilder()
        {
            carro = new Carro("Enduro");
        }

        public override void construirCarroceria()
        {
            carro["carroceria"] = "Aluminio";
        }

        public override void construirMotor()
        {
            carro["motor"] = "250cc";
        }

        public override void construirRuedas()
        {
            carro["ruedas"] = "Rodado 22";
        }
    }
}