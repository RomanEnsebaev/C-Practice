using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight(100, 25, 15);
            Barbarian barbarian = new Barbarian(100, 10, 25);

            barbarian.BattleCry();  
            knight.TakeDamage(barbarian.Damage);
            barbarian.TakeDamage(knight.Damage);

            Console.Write("ХП Рыцаря:");
            knight.ShowInfo();
            Console.Write("ХП Варвара:");
            barbarian.ShowInfo();

        }

        class Warrior
        {
            protected double Health;
            protected double Armor;
            public double Damage;

            public Warrior(double health, double armor, double damage)
            {
                Health = health;
                Armor = armor;
                Damage = damage;
            }

            public void TakeDamage(double damage)
            {
                double _takenDamage = damage-Armor*0.5;
                if (_takenDamage < 0)
                {
                    _takenDamage = 0;
                }
                Health -= _takenDamage;
            }

            public void ShowInfo()
            {
                Console.WriteLine(Health);
            }
        }

        class Knight:Warrior
        {
            public Knight(double health, double armor, double damage) : base(health, armor, damage) { }
            public void Pray()
            {
                Armor += 10;
            }
        }

        class Barbarian : Warrior
        {
            public Barbarian(double health, double armor, double damage) : base(health, armor, damage) { }
            public void BattleCry()
            {
                Health -= 5;
                Damage += 10;
            }
        }
    }
}
