public class Tamagotchi
{
    private int hunger = 10;
    private int boredom = 10;
    public string name= "";
    private List<string> words = [];
    

    


    public void tick()
    {
        hunger++;
        boredom++;
    }

    public void Feed()
    {
        hunger++;
    }

    public void Play()
    {
        boredom--;
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
        if (hunger < 0 || boredom < 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}