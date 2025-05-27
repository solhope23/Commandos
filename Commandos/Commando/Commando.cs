using System;

public class Commando
{
    protected string _name;
    protected string _coodeName;
    protected string[] _tools;
    protected string _status;

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

    public virtual void Attack()
    {
        Console.WriteLine(this._coodeName + " soldier attacking");
    }

    public string SayName(string yourCommanderRank)
    {
        switch (yourCommanderRank)
        {
            case "General":
                return this._name;
            case "Colonel":
                return this._coodeName;
            default:
                throw new Exception("you are not allowed");
        }
    }
}