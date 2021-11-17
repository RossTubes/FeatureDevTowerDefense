using System;

namespace Knight
{
    abstract class Equipment
    {
        public int x;
        public int y;

        static void Main(string[] args)
        {

        }

        public virtual void Equip()
        {
            Console.WriteLine("Equipment slot");
        }

        public virtual void Hitbymouse(int x, int y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }

    abstract class Consumable
    {
        public virtual void Consume()
        {
            Console.WriteLine("drinking");
        }

        public virtual void Spend()
        {
            Console.WriteLine("add value");
        }

        public bool CanConsume = true;
    }

    class Armor : Equipment
    {
        public override void Equip()
        {
            Console.WriteLine("health");
        }

        public override void Hitbymouse(int x, int y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }

    class Weapon : Equipment
    {
        public override void Equip()
        {
            Console.WriteLine("weapon attachment");
        }

        public override void Hitbymouse(int x, int y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }

    class Money : Consumable
    {
        public bool CanPickup = true;
    }

    class PotionHeal : Consumable
    {
        public override void Consume()
        {
            Console.WriteLine("eating");
        }
    }

    class PotionMana : Consumable
    {
        public override void Consume()
        {
            Console.WriteLine("gainded xp");
        }
    }


}
