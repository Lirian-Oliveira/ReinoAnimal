using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Mamifero : Animal

    {
        public override void Locomove()
        {
            base.Locomove();
            Console.WriteLine("Mamiferos se locomovem indo para frente, ou para trás");
        }
        public override void Comunica()
        {
            base.Comunica();
            Console.WriteLine("Mamiferos se comunicam fazendo barulho com a boca");

        }
        public void Amamenta ()
        {
            Console.WriteLine("Mamiferos são amamentados, até ter idade sucificiente para comerem sozinhos");
        }
    }
}
