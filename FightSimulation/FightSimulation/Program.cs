using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fighter[] fighters =
            {
                new Fighter("Роман", 200, 15,30),
                new Fighter("Алекс", 150, 10,40),
                new Fighter("Денис", 100, 25,15),
                new Fighter("Адиль", 250, 0,20)
            };

           for(int i = 0; i < fighters.Length; i++)
            {
                Console.Write(i + 1 + ") ");
                fighters[i].ShowFighterStats();
            }
            int choosenFigther;
            Console.WriteLine("\n***" + new string('-', 50) + "***\n");
            Console.Write("Выберите первого бойца:");
            choosenFigther = Convert.ToInt32(Console.ReadLine())-1;
            Fighter firstFighter = fighters[choosenFigther];
            Console.Write("Выберите второго бойца:");
            choosenFigther = Convert.ToInt32(Console.ReadLine())-1;
            Fighter secondFighter = fighters[choosenFigther];
            Console.WriteLine("\n***" + new string('-', 50) + "***\n");

            while (firstFighter.Health > 0 && secondFighter.Health > 0)
            {
                secondFighter.TakeDamage(firstFighter.Damage);
                firstFighter.TakeDamage(secondFighter.Damage);   
                secondFighter.ShowCurrentHealth();
                firstFighter.ShowCurrentHealth();
                Console.WriteLine("\n***" + new string('-', 50) + "***\n");

                if (firstFighter.Health <= 0 || secondFighter.Health <= 0)
                {
                    Console.Write($"\nБитва окончена! Победил - ");
                    if (firstFighter.Health > 0)
                    {
                        Console.WriteLine(firstFighter.Name);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(secondFighter.Name);
                        Console.WriteLine();
                    }
                }
            }
        }
    }

    class Fighter
    {
        private string _name;
        private double _health;
        private double _armor;
        private double _damage;

        public Fighter(string name,double health, double armor, double damage)
        {
            _name = name;
            _health = health;
            _armor = armor;
            _damage = damage;
        }

        public double Health
        {
            get { return _health; }
        }
        public double Damage
        {
            get { return _damage; }
        }
        public string Name
        {
            get { return _name; }
        }

        public void ShowFighterStats()
        {
            Console.WriteLine($"Имя - {_name}, здоровье:{_health}, броня: {_armor}, урон: {_damage}");
        }
        public void TakeDamage(double damage)
        {
            double takenDamage = damage -_armor*0.5;
            _health -= takenDamage;
        }
        public void ShowCurrentHealth()
        {
            Console.WriteLine($"Имя - {_name}, осталось здоровья: {_health}");
        }

    }
}
