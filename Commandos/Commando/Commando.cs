using System;

public class Commando
{
    private string _name;
    private string _coodeName;
    private string[] _tools { get;}
    private string _status { get;}

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

    public string SayName(string rankGeneralOrColonel)
    {
        switch (rankGeneralOrColonel)
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