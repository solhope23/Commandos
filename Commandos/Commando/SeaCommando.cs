using System;

public class SeaCommando : Commando
{
    public SeaCommando(string name, string codeName) : base(name, codeName)
    {
    }

    public void Swims()
    {
        Console.WriteLine("The soldier is swimming.");
    }

    public override void Attack()
    {
        Console.WriteLine("Marine commando soldier attacks");
    }

}