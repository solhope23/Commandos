using System;

public class Commando
{
    private string _name;
    private string _coodeName;
    private string[] _tools = { "Hammer", "chisel", "rope", "bag", "water" };
    private string _status = "Hide";

    public Commando(string name, string codeName, string status)
    {
        this._name = name;
        this._coodeName = codeName;
    }

    public void Walk()
    {
        this._status = "Walk";
        Console.WriteLine("The soldier is walking ");
    }

    public void Hide()
    {
        this._status = "Hide";
        Console.WriteLine("The soldier is hiding");
    }

    public void Attack()
    {
        Console.WriteLine(this._coodeName + " soldier attacking");
    }
}