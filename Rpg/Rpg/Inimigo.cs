using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    class Inimigo
    {
        private string nome;
        private int hp = 100;
        private int atk;
        private bool vivo = true;

        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public int getHp()
        {
            return hp;
        }
        public void setHp(int hp)
        {
            this.hp = hp;
        }

        public int getAtk()
        {
            return atk;
        }
        public void setAtk(int atk)
        {
            this.atk = atk;
        }

        public bool getVivo()
        {
            return vivo;
        }
        public void setVivo(bool vivo)
        {
            this.vivo = vivo;
        }

        public void info()
        {
            Console.WriteLine("Nome:{0}\nHp:{1}\nAtk:{2}\nVivo: {3}\nSkills...",getNome(),getHp(), getAtk(),getVivo());
        }


    }


}

