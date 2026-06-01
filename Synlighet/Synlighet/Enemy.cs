public class Enemy
{
    protected int hp = 100;
    public int Xp { get; set; }
    private int damage = 5;
public int Hp
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;
            if (hp < 0) hp = 0;
    }
}
    public string Name;


    // Gamla lösningar
    public void SetHp(int h)
    {
        hp = h;
    }
    public int GetHp()
    {
        return hp;
    }
public void Update()
    {
        if (hp < 0) hp = 0;
    }
}

public class Goomba : Enemy
{
    public void Hurt()
    {
        
    }
}