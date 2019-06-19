using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GameLegueOfLegend
{
    class Game
    {
        public Game()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ты начинаешь великую битву легендарных героев лиги!!!");
            Console.WriteLine("На арену выйдут два героя, они будут биться не на жизнь а на СМЕРТЬ!");
            Console.WriteLine("Кто победит? На это велит воля случая и конечно же владения своими навыками...");
            Console.WriteLine("Да начнеться битва...");
            Console.ResetColor();
            Boolean flag = true;
            Hero firstHero = new Hero();
            Hero secondHero = new Hero();
            int turn = 0;
            do
            {
              Console.WriteLine("Герой #1 " + firstHero.getInfo());
              Console.WriteLine("Герой #2 " + secondHero.getInfo());
              System.Threading.Thread.Sleep(1000);  
              if (firstHero.getHP() <= 0D)
              {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вот он лузер! {0} умирает!", firstHero.getName());
                Console.ResetColor();
                flag = false;
              }
              else if (secondHero.getHP() <= 0D)
              {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вот он лузер! {0} умирает!", secondHero.getName());
                Console.ResetColor();
                flag = false;
              }
              else if (turn%2 == 0)
              {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Бьет герой #1 : {0}, и наносит {1} урона!", firstHero.getName(), firstHero.getStrikepower());
                secondHero.setHP(secondHero.getHP()-firstHero.getStrikepower());
                Console.ResetColor();
                turn++;
              }
              else
              {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Бьет герой #2 : {0}, и наносит {1} урона!", secondHero.getName(), secondHero.getStrikepower());
                firstHero.setHP(firstHero.getHP()-secondHero.getStrikepower());
                Console.ResetColor();
                turn++;
              }
            } while (flag == true);
        }
        //private void getInfoHero()
        //{
        //    firstHero.getInfo;
        //    secondHero.getInfo;
        //}
    }
    class Hero
    {
        protected String name;
        protected double strikepower;
        protected double health;
        protected double intellect;
        protected double agility;
        protected double strength;
        //private Item[] items = new Item[2];

        public Hero()
        {
            Random rnd = new Random();
            int rndHero = rnd.Next(1, 3);
            switch (rndHero)
            {
                case 1:
                    new Teemo();
                    break;
                case 2:
                    new Draven();
                    break;
                case 3:
                    new Brand();
                    break;
            }
        }
        public String getInfo()
        {
            return name + " : " + "Здоровье: " + health + ", Интеллект: " + intellect + ", Ловкость: " + agility;
        }
        public double getHP()
        {
            return health;
        }
        public void setHP(double health)
        {
            this.health = health;
        }
        public double getStrikepower()
        {
            return strikepower;
        }
        public String getName()
        {
            return name;
        }
    }
    class Teemo : Hero
    {
        public Teemo()
        {
            base.name = "Teemo";
            base.health = 150D;
            base.intellect = 5D;
            base.agility = 7D;
            base.strength = 4D;
            base.strikepower = (1D * intellect + 1.4 * agility + (strength/health+1) * strength);
        }
    }
    class Draven : Hero
    {
        public Draven()
        {
            base.name = "Draven";
            base.health = 160D;
            base.intellect = 3D;
            base.agility = 6D;
            base.strength = 8D;
            base.strikepower = (0.9 * intellect + 1.6 * agility + (strength / health * 1.05) * strength);
        }
    }
    class Brand : Hero 
    {
        public Brand()
        {
            base.name = "Brand";
            base.health = 120D;
            base.intellect = 9D;
            base.agility = 3D;
            base.strength = 1D;
            base.strikepower = (2D * intellect + 0.97 * agility + 1D * strength);
        }
    }
    //class Item
    //{
    //    protected String name;
    //    protected int intellect;
    //    protected int agility;
    //    protected int strength;
    //}
    class Program
    {
        static void Main()
        {
            Boolean check = true;
            do
            {
                Console.WriteLine("Что бы начать игру напиши \"s\", для выхода нажми \"q\"");
                string inputFromUser = Console.ReadLine();
                switch (inputFromUser)
                {
                    case "s":
                        new Game();
                        break;
                    case "q":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Пиши то что хочу Я! А не то что ты сам себе придумываешь!");
                        break;
                }
            } while (check == true);
        }
    }
}
