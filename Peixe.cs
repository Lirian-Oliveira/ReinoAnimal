using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Peixe : Animal
    {
        public int barbatanas { get; protected set; }

        public override void Locomove()
        {
            base.Locomove();
            Console.WriteLine("Peixes nadam como forma de locomoção");
        }
    }
}
