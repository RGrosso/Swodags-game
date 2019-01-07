using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swodags
{
    public class Swods
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int KillCount { get; set; }
        public int Special { get; set; }
        public Swods Type { get; set; }


        public Swods(string name)
        {
            Name = name;
            Health = 100;
            Attack = 100;
            Defence = 100;
            KillCount = 0;

        }
        public virtual List<string> ShowDetails(List<String> result)
        {
            result.Add(String.Format("Type:{0}", this.ToString()));
            result.Add(String.Format("Health:{0}", Health));
            result.Add(String.Format("Attack:{0}", Attack));
            result.Add(String.Format("Defence:{0}", Defence));
            return result;
        }
        public virtual void QuickDetails()
        {
            Console.WriteLine("******************");
            Console.WriteLine($"Name:    {Name}");
            Console.WriteLine($"Type:    {this.ToString()}");
            Console.WriteLine($"Health:  {Health}");
            Console.WriteLine($"Attack:  {Attack}");
            Console.WriteLine($"Defence:{Defence}");
            Console.WriteLine("******************");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }

    }
    public class Fire : Swods //attack
    {
        public int CriticalBonus { get; set; }
        public Fire(string name):base(name)
        {
            Health = 70;
            Attack = 150;
            Special = 0;//Critical bonus damage
        }
    }
    public class Water : Swods //tanky
    {
        public int Armour { get; set; }
        public Water(string name):base(name)
        {
            Health = 150;
            Attack = 70;
            Armour = 50;
            Special = 1;//"Heavy armour set"
        }
    }
    public class Ice : Swods //special
    {
        public int StatusDamage { get; set; }
        //public int HealingFactor { get; set; }
        public Ice(string name):base(name)
        {
            StatusDamage = 5;
            Special = 2;// "Status damage bonus"

        }
    }
   

}
