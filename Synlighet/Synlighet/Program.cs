Enemy e1 = new();
e1.Xp += 90;
e1.Hp = 67;
e1.Hp -= 50;
// e1.SetHp(67);

// e1.Name = "Jimmy";
// e1.SetHp(e1.GetHp() - 50);

Console.WriteLine(e1.GetHp());
Console.ReadLine();