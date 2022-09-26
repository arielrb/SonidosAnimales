using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SonidosAnimales.Animales;
namespace SonidosAnimales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimales> bichos = new List<IAnimales>
            {
                new Perro(),
                new Gato(),
                new Zorro()
            };

            foreach (var bicho in bichos)
            {
                Console.WriteLine(bicho.EmitirSonido());
            }
        }
    }
}
