public class Tamagotchi
{
    private int hunger = 0;
    private int boredom = 0;
    public string name= "";
    private List<string> words = [];
    

    


    public void tick()
    {
        hunger++;
        boredom++;
    }

    public void Feed()
    {
        hunger -= 2;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }

    public void Play()
    {
        boredom -= 2;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }

    public void Teach()
    {
        Console.WriteLine($"What word do you want {name} to learn?");
        words.Add(Console.ReadLine());
        Console.WriteLine($"You have taught {name} {words.Last()}");
        Console.ReadKey();
    }

    public void PrintStats()
    {
        Console.WriteLine($"Boredom: {boredom}, hunger: {hunger}");
    }
    public void TaughtWords()
    {
        foreach (string word in words)
        {
            Console.WriteLine($"You have taught these words " + $"{word}");
        }
         Console.ReadKey();
    }
    public bool IsAlive()
    {
        if (hunger > 10 || boredom > 10)
        {
            Console.WriteLine("Your tamagotchi have died!");
            return false;
        }
        else
        {
            return true;
        }
    }
}