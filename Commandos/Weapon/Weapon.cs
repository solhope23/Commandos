using System;

public class Weapon
{
    private string _name;
    private string _manufacturer;
    private int _numberOfBullets;

    public Weapon(string name, string manufacturer, int numberOfBullets)
    {
        this._name = name;
        this._manufacturer = manufacturer;
        this._numberOfBullets = numberOfBullets;
    }

    public void Shoot()
    {
        Console.WriteLine("A shot was fired.");
        this._numberOfBullets --;
    }

}