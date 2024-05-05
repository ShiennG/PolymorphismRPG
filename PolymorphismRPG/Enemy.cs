using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismRPG
{
    class Enemy : Character
    {
        public Enemy()
        {
            Health = 5;
        }
        
    }

    class Slime : Enemy 
    {
        public Slime()
        {
            health = 3;
            defenseStat = 5;
            agilityStat = 3;
        }
    }

    class Zombie : Enemy 
    { 
        public Zombie()
        {
            health = 4;
        }
    }

    class Skeleton : Enemy { }

    class Wolf : Enemy { }

}
