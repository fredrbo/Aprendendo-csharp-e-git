using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg { 

   public class Personagem
    {
    private string nome;
    private int hp;
    private int mana;

    //getters
    public string getNome()
    {
        return nome;
    }
    public int getHp()
    {
        return hp;
    }
    public int getMana()
    {
        return mana;
    }
    public void setNome(string nome)
        {
            this.nome = nome;

        }   
    
    //construtor
    public Personagem(string nome)
    {
        this.nome = nome;
        mana = 100;
        hp = 100;
    }

    public void info()
    {
        Console.WriteLine("Nome:{0}\nHp:{1}\nMana:{2}\nSkills...", getNome(), getHp(), getMana());
    }
        

}
}
