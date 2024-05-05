using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Pessoa
    {
        //Method 01
        public void apresentar()
        {
            Console.WriteLine("Olá");
        }
        //Method 02
        public void apresentar(string nome)
        {
            Console.WriteLine("Olá "+nome);
        }
        //Method 03
        public void apresentar(string nome,int idade)
        {
            Console.WriteLine("Olá " + nome + ", você tem " + idade + " Anos.");
        }
    }
}
