using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Monster : Character
    {
        public override bool IsAlive
        {
            get { return lifePoints > 0; }
        }

        public override void Attack(Character character)
        {
            throw new NotImplementedException();
        }

        public override void SuddenDamage(int damage)
        {
            throw new NotImplementedException();
        }
    }
}
