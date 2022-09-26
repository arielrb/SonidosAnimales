using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonidosAnimales.Animales
{
    public class Perro : IAnimales
    {
        public string EmitirSonido() => "Guau!";
    }
}

