using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swodags
{
    class Program
    {
        static void Main(string[] args)
        {
            Swods[] Party = { new Fire("Fire"), new Water("Water"), new Ice("Ice") };
            DisplaySwod(Party);

            Swods character = SelectSwod();
            character.QuickDetails();

            Console.WriteLine("A wild enemy appeared, press any button to continue and see stats.");
            Console.ReadLine();
            Swods enemy = new Fire("Enemy");
            enemy.QuickDetails();
            Console.WriteLine("attack?");
            Console.ReadLine();
            Attack(character,enemy);
            enemy.QuickDetails();
        }

        public static void Attack(Swods c ,Swods e)
        {
            int damage = (c.Attack / 10);
            if (c.Special == 0)
            {
                Random r = new Random();
                decimal bonus = (r.Next(10, 20))/10 ;
                Console.WriteLine(bonus);
                decimal predamage = (c.Attack) * bonus;
                Math.Round(predamage, MidpointRounding.AwayFromZero);
                damage = (int)predamage;
                Console.WriteLine(damage);
                Console.WriteLine("You dealed {0} damage!", damage);
            }
            e.Health -= damage;
            Console.WriteLine("Enemies health is now {0}.",e.Health);
        }

        private static Swods SelectSwod()
        {
            Swods res = new Fire("Bob");
            bool charcreate = false;
            while (!charcreate)
            {
                Console.WriteLine("Please select your class...");
                Console.WriteLine();
                string type = Console.ReadLine();
                res = new Fire("default");

                if (type == "Fire")
                {
                    charcreate = true;
                    Console.WriteLine("You selected Fire");
                    Console.WriteLine("Choose your characters name...");
                    string name = Console.ReadLine();
                    res = new Fire(name);
                }
                else if (type == "Water")
                {
                    charcreate = true;
                    Console.WriteLine("You selected Water");
                    Console.WriteLine("Choose your characters name...");
                    string name = Console.ReadLine();
                    res = new Water(name);
                }
                else if (type == "Ice")
                {
                    charcreate = true;
                    Console.WriteLine("You selected Ice");
                    Console.WriteLine("Choose your characters name...");
                    string name = Console.ReadLine();
                    res = new Ice(name);
                }
                else
                {
                    Console.WriteLine("Invalid, try again and make sure you enter the type exactly.");
                }
            }
            return res;
        }


        private static void DisplaySwod(Swods[] Party)
        {
            foreach (Swods s in Party)
            {
                List<String> details = new List<string>();
                
                s.ShowDetails(details);
                
                foreach (String x in details)
                {
                    
                    Console.WriteLine(x);
                }
                Console.WriteLine("*******************");


            }
        }
    }
}
