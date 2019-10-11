using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Player : Character
    {
        public override bool IsAlive
        {
            get { return lifePoints > 0; }
        }

        public Player(int points, string name)
        {
            lifePoints = points;
            this.name = name;
        }

        public override void Attack (Character character)
        {
            Console.WriteLine("");
        }

        public override void SuddenDamage (int damage)
        {
            Console.WriteLine("");
        }

        public int GetBonus() 
        {
            return 100;    
        }
    }
}
