using System;
using System.Linq;


namespace LINQ_Cook_Jakob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //an array of Games called games, it has 10 games
            Game[] games = new Game[]
            {
                new Game("Minecraft", 'E', "Action-Adventure"),
                new Game("CS:GO", 'M', "FPS"),
                new Game("Elden Ring", 'M', "Action-Adventure"),
                new Game("Valorant", 'T', "FPS"),
                new Game("Halo 3", 'M', "Action"),
                new Game("Zombcube", 'E', "FPS Survival"),
                new Game("Magnet Destroyer", 'E', "Hyper-Casual"),
                new Game("Paddle Balls", 'E', "Arcade Casual"),
                new Game("Rocket League", 'E', "Action Racing"),
                new Game("Fifa 22", 'E', "Sport"),
            };

            //a LINQ Query to get all games with less than 9 characters in the title and assign it to a var called shortGames.
            var shortGames = from game in games
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";

            //Loops through and prints each element in shortGames.
            foreach (var game in shortGames)
            {
                Console.WriteLine(game);
            }

            //a LINQ method query to find the game "Minecraft" from the games array and assign it to a var called mineCraft.
            var mineCraft = games.Where(game => game.Title == "Minecraft")
                             .Select(Game => $"Title: {Game.Title}, ESRB: {Game.Esrb}, Genre: {Game.Genre}");

            //Print all the game properties of mineCraft to console using the FirstOrDefault method.
            Console.WriteLine(mineCraft.FirstOrDefault());

            //Creates a var named tRated and selects the titles where the esrb rating is 'T'. 
            var tRated = from game in games
                         where game.Esrb == 'T'
                         select game.Title;

            //Prints t rated games
            Console.WriteLine("T Rated Games:");

            //Loops through tRated and prints each element to console.
            foreach (var game in tRated)
            {
                Console.WriteLine(game);
            }

            //a var called eRatedAction and selects the titles where the esrb rating is 'E' and genre is "Action".
            var eRatedAction = from game in games
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;

            //Prints e rated action games
            Console.WriteLine("E Rated Action Games:");

            //Loops through eRatedAction and prints each element to console.
            foreach (var game in eRatedAction)
            {
                Console.WriteLine(game);
            }
        }
    }
}