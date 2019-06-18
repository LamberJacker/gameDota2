using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDota2
{
    class StartGame
    {
        Hero firstHero = new Hero();
        Hero secondHero = new Hero();

        public StartGame()
        {
            Console.WriteLine("Ты начинаешь великую битву легендарных героев лиги!!!");
            Console.WriteLine("На арену выйдут два героя, они будут биться не на жизнь а на СМЕРТЬ!");
            Console.WriteLine("Кто победит велит воля случая и конечно же владения своими навыками...");
            Console.WriteLine("Да начнеться битва...");
        }
    }
    class Hero
    {
        private int intellect;
        private int agility;
        private int strength;

        public Hero()
        {}
    }
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
                        new StartGame();
                        break;
                    case "q":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("пиши то что хочу я а не то что ты сам себе придумываешь!");
                        break;
                }
            } while (check == true);
        }
    }
}
