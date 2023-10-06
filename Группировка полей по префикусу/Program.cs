using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Группировка_полей_по_префикусу
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Player
    {
        private readonly Weapon _weapon;
        private readonly Movement _movement;

        public Player(Weapon weapon, Movement movement)
        {
            _weapon = weapon;
            _movement = movement;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }

        public void Move()
        {
            //Do move
        }

        public void Attack()
        {
            //attack
        }

        public bool IsReloading()
        {
            throw new NotImplementedException();
        }
    }

    class Weapon
    {
        public float Cooldown { get; private set; }
        public int Damage { get; private set; }
    }

    class Movement
    {
        public float Speed { get; private set; }
        public float DirectionX { get; private set; }
        public float DirectionY { get; private set; }
    }
}
