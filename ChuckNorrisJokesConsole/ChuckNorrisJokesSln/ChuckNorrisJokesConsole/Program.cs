using ChuckNorrisJokesLibrary;
using System;
using System.Threading.Tasks;

namespace ChuckNorrisJokesConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            JokeGenerator jokeGenerator = new JokeGenerator();
            string randomJoke = await jokeGenerator.GetRandomJokeAsync();

            string[] categories = await jokeGenerator.GetCatagories();

            
           
            Console.WriteLine(randomJoke);
        }
    }
}
 