using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Boolean flag = false;
            Hero firstHero = new Hero();
            Hero secondHero = new Hero();
            do
            {
                
                if (firstHero.getHP <= 0D)
                {
                    Console.WriteLine("Проиграл " + firstHero.getName);
                    flag = false;
                }
                else if (secondHero.getHP <= 0D)
                {
                    Console.WriteLine("Проиграл " + secondHero.getName);
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Герой №1 " + firstHero.getInfo);
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
            int rndHero = rnd.Next(0, 3);
            switch (rndHero)
            {
                case 1:
                    Teemo teemo = new Teemo();
                    break;
                case 2:
                    Draven draven = new Draven();
                    break;
                case 3:
                    Brand brand = new Brand();
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
        public double setHP(double health)
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
        private void setCharacteristic()
        {
            this.name = "Teemo";
            this.health = 150D;
            this.intellect = 5D;
            this.agility = 7D;
            this.strength = 4D;
            this.strikepower = (1D * intellect + 1.4 * agility + (strength/health+1) * strength);
        }
    }
    class Draven : Hero
    {
        private void setCharacteristic()
        {
            this.name = "Draven";
            this.health = 160D;
            this.intellect = 3D;
            this.agility = 6D;
            this.strength = 8D;
            this.strikepower = (0.9 * intellect + 1.6 * agility + (strength / health * 1.05) * strength);
        }
    }
    class Brand : Hero
    {
        private void setCharacteristic()
        {
            this.name = "Brand";
            this.health = 120D;
            this.intellect = 9D;
            this.agility = 3D;
            this.strength = 1D;
            this.strikepower = (2D * intellect + 0.97 * agility + 1D * strength);
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
            Console.WriteLine("Что бы начать игру впиши \"KILL THEM ALL!\", для выхода нажми \"q\"");
            Boolean check = true;
            do
            {
                string inputFromUser = Console.ReadLine();
                switch (inputFromUser)
                {
                    case "KILL THEM ALL!":
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
