using System;
using System.Threading;
using System.Threading.Tasks;
//Threading library used to force program to force methods to take a
//certain amount of time

namespace AysncCake;

class Program
{
    public async static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my birthday party");
        await HaveAPartyAsync();
        Console.WriteLine("Thanks for a lovely party");
        Console.ReadLine();
    }

    private async static Task HaveAPartyAsync()
    {
        var name = "Cathy";
        var cakeTask = BakeCakeAsync();
        PlayPartyGames();
        OpenPresents();
        Console.WriteLine($"Happy birthday, {name}, {cakeTask}!!");
    }

    //Task <>, async key

    private async static Task<Cake> BakeCakeAsync()
    {
        Console.WriteLine("Cake is in the oven");
        //Thread.Sleep(TimeSpan.FromSeconds(5));
        await Task.Delay(TimeSpan.FromSeconds(5));
        Console.WriteLine("Cake is done");
        return new Cake();
    }

    private static void PlayPartyGames()
    {
        Console.WriteLine("Starting games");
        Thread.Sleep(TimeSpan.FromSeconds(2));
        Console.WriteLine("Finishing Games");
    }

    private static void OpenPresents()
    {
        Console.WriteLine("Opening Presents");
        Thread.Sleep(TimeSpan.FromSeconds(1));
        Console.WriteLine("Finished Opening Presents");
    }
}

public class Cake
{
    public override string ToString()
    {
        return "Here's a cake";
    }
}
