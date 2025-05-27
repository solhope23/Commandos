using System;

public class CommandoFactory
{
    private Commando[] CommandoList;

    public CommandoFactory(int AmountOfCommandos)
    {
        this.CommandoList = new Commando[AmountOfCommandos];
    }


    private Commando newComando(string Name, string codeName)
    {
        Random random = new Random();
        int randomType = random.Next(1,4);

        switch (randomType)
        {
            case 1:
                return new AirCommando(Name, codeName);
            case 2:
                return new SeaCommando(Name, codeName);
            default:
                return new Commando(Name, codeName);
        }
    }

    public void AddCommando(string Name, string codeName)
    {
        for (int i = 0; i < CommandoList.Length; i++)
        {
            if (CommandoList[i] != null)
            {
                CommandoList[i] = newComando(Name, codeName);
                break;
            }
        }
    }
}