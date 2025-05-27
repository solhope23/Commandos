using System;

public class Commando
{
    private string _name { get; set; }
    private string _coodeName { get; set; }
    private string[] _tools { get; set; }
    private string _status { get; set; }

    public Commando(string name, string codeName)
    {
        this._name = name;
        this._coodeName = codeName;
        this._tools = new string[5] { "Hammer", "chisel", "rope", "bag", "water" };
        this._status = "Hide";
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