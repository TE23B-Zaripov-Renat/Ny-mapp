Console.WriteLine("Vilket monster vill du spela som?");
Console.WriteLine("1) TheGoat 2) Godzilla");
string choice = Console.ReadLine();



if (choice == "1")
{
    TheGoat m1 = new();
}
else if (choice == "2")
{
    Godzilla m1 = new();
}
// Monster m1 = new();
// if (choice == "1")
// {
//     m1 = new();
// }
// else if (choice == "2")
// {
//     m1 = new();
// }
// Console.WriteLine(m1.Name);