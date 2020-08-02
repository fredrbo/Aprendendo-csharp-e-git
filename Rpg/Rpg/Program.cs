using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    class Program
    {
        static string name;
        static void Main(string[] args)
        {
           
            Console.WriteLine("Começando o RPG.\nDigite o nome do personagem: ");
            Personagem p1 = new Personagem("Indefinido");
            Inimigo i1 =new Inimigo();
            Batalha b1 = new Batalha();
            
            name = Console.ReadLine();
            p1.setNome(name);
            




        }
    }
}
