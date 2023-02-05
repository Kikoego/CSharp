using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Unit
    {
        private String name;
        private int damage;
        private int health;
        
        public Unit(string n, int d, int h)
        {
            name = n;
            damage = d;
            health = h;

        }

        public bool Attack(Unit enemy)
        {
        if (enemy.health <= 0 || health <= 0) return false;
                System.Console.Write(name + " атакует " + enemy.name);
                System.Console.Write(" и наносит " + damage + " урона\n");
                enemy.health -= damage;
        return true;
        }
        public void Display()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Урон: " + damage);
            Console.WriteLine("Здоровье: " + health);
        }
    }
