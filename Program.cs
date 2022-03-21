using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fighters.PrintList();
            Console.WriteLine($"{Fighters.Battle(Fighters.ChooseFighter(), Fighters.ChooseFighter())}");
            
        }
       
    }

    public class Fighters
    {
        string name;
        int health;
        int attack;
        int shield;
        public Fighters(string name, int health, int attack, int shield)
        {
            this.name = name;
            this.health = health;
            this.attack = attack;
            this.shield = shield;
        }
        public static Fighters ChooseFighter()
        {
            switch (Console.ReadLine())
            {
                case "frank":
                    Fighters Frank = new Fighters("frank", 100, 24, 10);
                    return Frank;
                case "mortis":
                    Fighters Mortis = new Fighters("mortis", 60, 45, 8);
                    return Mortis;
                case "el-fuego":
                    Fighters ElFuego = new Fighters("el-fuego", 90, 26, 8);
                    return ElFuego;
                case "shang-che":
                    Fighters Shangche = new Fighters("shang-che", 80, 30, 6);
                    return Shangche;
                case "edgar":
                    Fighters Edgar = new Fighters("edgar", 50, 50, 5);
                    return Edgar;
                default:
                    return null;
            }
        }
        public static void PrintList()
        {
            Console.WriteLine("Choose your figher:");
            Console.WriteLine("frank: 100 hp - 24 atk - 10 shld\nmortis: 60 hp - 45 atk - 8 shld\nel-fuego: 90 hp - 26 atk - 8 shld\nshang-che: 80 hp - 30 atk - 6 shld\nedgar: 50 hp - 50 atk - 5 shld");
            Console.WriteLine("Enetr the name:");
        }
        public static string Battle(Fighters player1, Fighters player2)
        {

            while (player1.health > 0 & player2.health > 0)
                {
                    Console.WriteLine($"{player1.name} HP = {player1.health}\t{player2.name} HP = {player2.health}");
                    player2.health = player2.health - (player1.attack - player2.shield);

                    Console.WriteLine($"{player1.name} HP = {player1.health}\t{player2.name} HP = {player2.health}");
                    player1.health = player1.health - (player2.attack - player1.shield);
                   
                }

            if (player1.health > player2.health)
            {
                return $"{player1.name} is winner";
            }
            else
            {
                return $"{player2.name} is winner";
            }

        }

    }

   
}
