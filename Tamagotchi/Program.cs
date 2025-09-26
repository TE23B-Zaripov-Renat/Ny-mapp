
Console.WriteLine("Wellcome to Tamagotchi");
Tamagotchi tama = new();
Console.WriteLine("Write the name of your pet:");
tama.name = Console.ReadLine();
while (tama.IsAlive() == true)
{
    Console.Clear();
    tama.PrintStats();
    Console.WriteLine($"1.Feed 2.Play 3.Teach a word 4.Show {tama.name} new words 5.Do nothing");
    string answer = Console.ReadLine();
    if (answer == "1")
    {
        tama.Feed();
    }
    else if (answer == "2")
    {
        tama.Play();
    }
    else if (answer == "3")
    {
        tama.Teach();
    }
    else if (answer == "4")
    {
        tama.TaughtWords();
    }
    else if (answer == "5")
    {

    }

}

Console.ReadLine();