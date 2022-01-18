using System;
using Builder_Pattern_Diego.Diagrama;

namespace Builder_Pattern_Diego
{
    class Program
    {
        static void Main(string[] args)
        {
            CarroBuilder builder;

            // Create shop with vehicle builders
            Concecionaria concecionaria = new Concecionaria();

            // Construct and display vehicles
            builder = new ScooterBuilder();
            concecionaria.Construct(builder);
            builder.Carro.Show();

            builder = new EnduroBuilder();
            concecionaria.Construct(builder);
            builder.Carro.Show();

            builder = new PisteroBuilder();
            concecionaria.Construct(builder);
            builder.Carro.Show();

            // Wait for user
            Console.ReadKey();

        }
    }
}
