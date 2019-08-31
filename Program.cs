using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano Mônica = new Humano (7, "Cebolinhaaaaa", 13, 45, "98754632456");
            Mônica.Cresce(3);
            Mônica.Nasce();
            Mônica.Reproduz();
            Mônica.Morre();
            Mônica.Locomove();
            Mônica.Comunica();
            Mônica.Amamenta();


            Tubarao CabeçaDeMartelo = new Tubarao();
            Cachorro Poodle = new Cachorro();
          
            Pato Donald = new Pato();
   
            Peixe Peixonalta = new Peixe();

            Console.ReadKey();

        }
    }
}
