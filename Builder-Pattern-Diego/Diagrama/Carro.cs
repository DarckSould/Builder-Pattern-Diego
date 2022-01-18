using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Builder_Pattern_Diego.Diagrama
{
    class Carro
    {
        private string _carroTipo;
        private Dictionary<string, string> _parts =
          new Dictionary<string, string>();

        // Constructor
        public Carro(string carroTipo)
        {
            this._carroTipo = carroTipo;
        }

        // Indexer
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Tipo de Carro : {0}", _carroTipo);
            Console.WriteLine(" Motor : {0}", _parts["motor"]);
            Console.WriteLine(" Ruedas: {0}", _parts["ruedas"]);
            Console.WriteLine(" Carroceria : {0}", _parts["carroceria"]);
        }
    }
}