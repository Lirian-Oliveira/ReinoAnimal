using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Ave : Animal

    {
        public override void Comunica()
        {
            base.Comunica();
            Console.WriteLine("as aves se comunicam com barulhos");
        }
        public override void Locomove () {
            base.Locomove();
            Console.WriteLine("as aves voam para se locomover");
           
            }
        public void Migra ()
        {

        }
    }
}
