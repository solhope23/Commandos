using System;

public class CommandoFactory
{
    private Commando[] CommandoList;

    public CommandoFactory(int AmountOfCommandos)
    {
        this.CommandoList = new Commando[AmountOfCommandos];
    }


    private Commando newComando(string hisType, string Name, string codeName)
    {
        switch (hisType)
        {
            case "AirCommando":
                return new AirCommando(Name, codeName);
            case "SeaCommando":
                return new SeaCommando(Name, codeName);
            case "Commando":
                return new Commando(Name, codeName);
            default:
                throw new Exception ("There is no such type of commando.");
        }
    }

    public void AddCommando(string hisType, string Name, string codeName)
    {
        for (int i = 0; i < CommandoList.Length; i++)
        {
            if (CommandoList[i] != null)
            {
                CommandoList[i] = newComando(hisType, Name, codeName);
                break;
            }
        }
    }
}