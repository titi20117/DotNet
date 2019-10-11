using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public abstract class Character
    {
        public string name;
        public int lifePoints;
        public abstract void Attack(Character character);
        public abstract void SuddenDamage(int damage);
        public abstract bool IsAlive { get; }
    }
        
}
