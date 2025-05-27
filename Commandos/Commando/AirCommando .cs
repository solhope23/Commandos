using System;

public class AirCommando : Commando
{
    public AirCommando(string name, string codeName) : base(name, codeName)
    {
    }

    public void Parachuting()
    {
        Console.WriteLine("The soldier is parachuting now.");
    }


    public override void Attack()
    {
        Console.WriteLine("Airborne Commando Soldier Attacks");
    }
}