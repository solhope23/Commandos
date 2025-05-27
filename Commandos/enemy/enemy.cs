using System;

public class enemy
{
    private string _name;
    private int _live;
    private bool _IsLive;

    public enemy(string name)
    {
        this._name = name;
        this._live = 100;
        this._IsLive = true;
    }

    public void shout()
    {
        Console.WriteLine("I am an enemy");
    }
}