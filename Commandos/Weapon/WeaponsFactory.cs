public class WeaponsFactory
{
    private weapon[] weaponList;

    public weaponsFactory(int AmountOfWeapons)
    {
        this.weaponList = new enemy[AmountOfWeapons];
    }

    public void newEnemy(string Name)
    {
        for (int i = 0; i < weaponList.Length; i++)
        {
            if (weaponList[i] != null)
            {
                weaponList[i] = new enemy(Name);
                break;
            }
        }
    }
}