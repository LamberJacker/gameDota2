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
            Hero[] arrheroes = new Hero[2];
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)            
            {
                int rndHero = rnd.Next(1, 5);
                switch (rndHero)
                {
                case 1:
                    Teemo teemo = new Teemo();
                    teemo.addItem(teemo);
                    arrheroes[i] = teemo;
                    break;
                case 2:
                    Draven draven = new Draven();
                    draven.addItem(draven);
                    arrheroes[i] = draven;
                    break;
                case 3:
                    Brand brand = new Brand();
                    brand.addItem(brand);
                    arrheroes[i] = brand;
                    break;
                case 4:
                    Darius darius = new Darius();
                    darius.addItem(darius);
                    arrheroes[i] = darius;
                    break;
                case 5:
                    Kayle kayle = new Kayle();
                    kayle.addItem(kayle);
                    arrheroes[i] = kayle;
                    break;
                }
            }
            int turn = 0;
            Console.WriteLine("На арену выходят два чемпиона :");
            Console.WriteLine("......................................\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Первый ");
            arrheroes[0].getAllInfo();
            Console.WriteLine("--------------------------------------\n");
            Console.Write("Второй ");
            arrheroes[1].getAllInfo();
            Console.ResetColor();
            Console.WriteLine("\n======================================");
            Console.WriteLine("           БОЙ НАЧИНАЕТЬСЯ!");
            Console.WriteLine("======================================\n");
            do
            {
                Console.WriteLine("Герой #1 " + arrheroes[0].getInfo());
                Console.WriteLine("Герой #2 " + arrheroes[1].getInfo());
                Console.WriteLine("--------------------------------------\n");
                System.Threading.Thread.Sleep(1000);  
                if (arrheroes[0].getHP() <= 0D)
                {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вот он лузер! {0} умирает!", arrheroes[0].getName());
                Console.ResetColor();
                flag = false;
                }
                else if (arrheroes[1].getHP() <= 0D)
                {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вот он лузер! {0} умирает!", arrheroes[1].getName());
                Console.ResetColor();
                flag = false;
                }
                else if (turn%2 == 0)
                {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Бьет герой #1 : {0}, и наносит {1:#.##} урона!", arrheroes[0].getName(), arrheroes[0].getStrikepower());
                arrheroes[1].setHP(arrheroes[1].getHP()-arrheroes[0].getStrikepower());
                Console.ResetColor();
                turn++;
                }
                else
                {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Бьет герой #2 : {0}, и наносит {1:#.##} урона!", arrheroes[1].getName(), arrheroes[1].getStrikepower());
                arrheroes[0].setHP(arrheroes[0].getHP()-arrheroes[1].getStrikepower());
                Console.ResetColor();
                turn++;
                }
            } while (flag == true);
            Console.WriteLine("\nБитва оконченна, но ты можешь узреть еще легендарный бой,\n жми на любую кнопку что бы продолжить...");
            Console.ReadKey();
        }
    }
    class Hero
    {
        protected String name;
        protected double strikepower;
        protected double health;
        protected double intellect;
        protected double agility;
        protected double strength;
        private Item[] arritems = new Item[2];
        public String getInfo()
        {
            return name + " : " + Math.Round(health, 0, MidpointRounding.AwayFromZero) + " HP";
        }
        public void getAllInfo()
        {
            Console.WriteLine("герой : " + name);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Характеристики героя: \nЗдоровье : " + health + " HP \nИнтелект: " + intellect);
            Console.WriteLine("Ловкость : " + agility + "\nСила : " + strength);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Сила одного удара равна : " + Math.Round(strikepower, 2, MidpointRounding.AwayFromZero));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("В левой руке у него : " + arritems[0].getNameItem());
            Console.WriteLine("В правой руке у него : " + arritems[1].getNameItem());
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
        public void addItem(Hero hero)
        {
            Random rnd = new Random();
            for (int j = 0; j < 2; j++)
            {
                int rndItem = rnd.Next(1, 5);
                switch (rndItem)
                {
                    case 1:
                        Sword sword = new Sword();
                        hero.arritems[j] = sword;
                        hero.agility += sword.getAgilityItem();
                        hero.strength += sword.getStrengthItem();
                        hero.intellect += sword.getIntellctItem();
                        break;
                    case 2:
                        Bow bow = new Bow();
                        hero.arritems[j] = bow;
                        hero.agility += bow.getAgilityItem();
                        hero.strength += bow.getStrengthItem();
                        hero.intellect += bow.getIntellctItem();
                        break;
                    case 3:
                        Staff staff = new Staff();
                        hero.arritems[j] = staff;
                        hero.agility += staff.getAgilityItem();
                        hero.strength += staff.getStrengthItem();
                        hero.intellect += staff.getIntellctItem();
                        break;
                    case 4:
                        Shield shield = new Shield();
                        hero.arritems[j] = shield;
                        hero.agility += shield.getAgilityItem();
                        hero.strength += shield.getStrengthItem();
                        hero.intellect += shield.getIntellctItem();
                        break;
                    case 5:
                        EmptySlot empty = new EmptySlot();
                        hero.arritems[j] = empty;
                        break;
                }
            }
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
    class Darius : Hero
    {
        public Darius()
        {
            base.name = "Darius";
            base.health = 210D;
            base.intellect = 0D;
            base.agility = 3D;
            base.strength = 10D;
            base.strikepower = (0.95D * intellect + 1.1 * agility + 1.5D * strength);
        }
    }
    class Kayle : Hero
    {
        public Kayle()
        {
            base.name = "Kayle";
            base.health = 190D;
            base.intellect = 15D;
            base.agility = 5D;
            base.strength = 3D;
            base.strikepower = (1.7D * intellect + 1 * agility + 1D * strength);
        }
    }
    class Item
    {
        protected String name;
        protected double intellect;
        protected double agility;
        protected double strength;

        public string getNameItem()
        {
            return name;
        }
        public double getIntellctItem()
        {
            return intellect;
        }
        public double getAgilityItem()
        {
            return agility;
        }
        public double getStrengthItem()
        {
            return strength;
        }
    }
    class Bow : Item
    {
        public Bow()
        {
            base.name = "ArowOfShadowPriest";
            base.intellect = 1D;
            base.agility = 10D;
            base.strength = 4D;
        }
    }
    class Sword : Item
    {
        public Sword()
        {
            base.name = "B.F.Sword";
            base.intellect = 0D;
            base.agility = 6D;
            base.strength = 15D;
        }
    }
    class Staff : Item
    {
        public Staff()
        {
            base.name = "StaffOfDeath";
            base.intellect = 20D;
            base.agility = 0D;
            base.strength = 0D;
        }
    }
    class Shield : Item
    {
        public Shield()
        {
            base.name = "ShieldOfGladiator";
            base.intellect = 0D;
            base.agility = 10D;
            base.strength = 15D;
        }
    }
    class EmptySlot : Item
    {
        public EmptySlot()
        {
            base.name = "EmptySlot";
            base.intellect = 0D;
            base.agility = 0D;
            base.strength = 0D;
        }
    }
    class Program
    {
        static void Main()
        {
            Boolean check = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Что бы начать игру напиши \"GO\", для выхода напиши \"OFF\"");
                string inputFromUser = Console.ReadLine();
                switch (inputFromUser)
                {
                    case "GO":
                        new Game();
                        break;
                    case "OFF":
                        check = false;
                        break;
                }
            } while (check == true);
        }
    }
}
