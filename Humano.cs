using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Humano : Mamifero
    {
        public string Cpf { get; protected set; }

        public void sorri ()
        {
            Console.WriteLine("Humanos fazem um gesto com a boca quando estão felizes ex: :D");
        }
        public Humano(int idade, string som, float v, float p, string cpf)
        {
            Idade = idade;
            Som = som;
            Velocidade = v;
            Peso = p;
            Cpf = cpf;
        }
    }
}
