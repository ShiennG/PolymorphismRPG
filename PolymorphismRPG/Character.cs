using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismRPG
{
    class Character
    {
        public int maxHealth, agilityStat, attackStat, defenseStat, level;
        public double health;

        public virtual void PrimaryAttack(Enemy enemy) { Console.WriteLine("Character Primary Attack!"); }
        public virtual void SecondAttack(Enemy enemy) { Console.WriteLine("Character Second Attack!"); }
        public virtual void SpecialAttack(Enemy enemy) { Console.WriteLine("Character Special Attack!"); }


       
        public double Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public int DefenseStat
        {
            get { return this.defenseStat; }
            set { this.defenseStat = value;}
        }

        public int AttackStat;


    }



    class Player : Character
    {
        public int exp = 0;
        
        public Player()
        {
            level = 1;
        }


        public bool EnemyDodged(Enemy enemy) // each agility point = 10% dodge chance
        {
            Random rnd = new Random();
            if (rnd.Next(1, 11) < enemy.agilityStat) { return true; }
            return false;
        }
    }




    class Knight : Player {

        public Knight()
        {
            this.maxHealth   = 20;
            this.health = this.maxHealth;
            this.attackStat  = 4;
            this.defenseStat = 7;
            this.agilityStat = 0;
        }

        public override void PrimaryAttack(Enemy enemy) { Console.WriteLine("Knight Primary Attack!"); }
    }



    class Archer : Player
    {
        public Archer()
        {
            this.maxHealth = 10;
            this.health = this.maxHealth;
            this.attackStat = 9;
            this.defenseStat = 3;
            this.agilityStat = 5;
        }

        public override void PrimaryAttack(Enemy enemy)
        {
            Console.WriteLine("Regular Shot!");
            if (!EnemyDodged(enemy))
            {

                double damageDealt = (this.attackStat / 2) * (1 - (enemy.DefenseStat * 0.05)) * this.level / 2;
                enemy.Health -= damageDealt;
                Console.WriteLine("Regular shot dealt " + damageDealt);
                Console.Write("Enemy health: ");
                Console.WriteLine(enemy.Health.ToString("F2"));
                Console.WriteLine(enemy.Health);
            }
            else
            {
                Console.WriteLine("Enemy dodged!");
            }
        }

        public override void SecondAttack(Enemy enemy)
        {
            Console.WriteLine("Piercing Arrow!");
            if (!EnemyDodged(enemy))
            {
                double damageDealt = (this.attackStat / 2) * this.level / 2; // ignores defense
                enemy.Health -= damageDealt;
                Console.WriteLine("Piercing Arrow dealt " + damageDealt);
                Console.Write("Enemy health: ");
                Console.WriteLine(enemy.Health.ToString("F2"));
                Console.WriteLine(enemy.Health);
            }
            else
            {
                Console.WriteLine("Enemy dodged!");
            }
        }
    }



    class Mage : Player
    {
        public Mage()
        {
            this.maxHealth   = 13;
            this.health      = this.maxHealth;
            this.attackStat  = 7;
            this.defenseStat = 5;
            this.agilityStat = 3;
        }

        public override void PrimaryAttack(Enemy enemy) 
        {
            Console.WriteLine("Fireball!");
            if (!EnemyDodged(enemy))
            {
                double damageDealt = (this.attackStat / 1.75) * (1 - (enemy.DefenseStat * 0.05)) * this.level / 2;
                enemy.Health -= damageDealt;
                Console.WriteLine("Fireball dealt " + damageDealt);
                Console.Write("Enemy health: ");
                Console.WriteLine(enemy.Health.ToString("F2"));
                Console.WriteLine(enemy.Health);
            }
            else
            {
                Console.WriteLine("Enemy dodged!");
            }


        }
    }
}

