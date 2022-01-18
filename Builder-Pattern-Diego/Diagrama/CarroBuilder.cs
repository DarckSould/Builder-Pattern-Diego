using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern_Diego.Diagrama
{
    abstract class CarroBuilder

    {
        protected Carro carro;

        // Gets vehicle instance
        public Carro Carro
        {
            get { return carro; }
        }

        public abstract void construirMotor();
        public abstract void construirCarroceria();
        public abstract void construirRuedas();

    }
}