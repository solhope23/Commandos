public class WeaponsFactory
{
    private Weapon[] weaponList;

    public WeaponsFactory(int AmountOfWeapons)
    {
        this.weaponList = new Weapon[AmountOfWeapons];
    }

    public void newWeapon(string name, string manufacturer, int numberOfBullets)
    {
        for (int i = 0; i < weaponList.Length; i++)
        {
            if (weaponList[i] != null)
            {
                weaponList[i] = new Weapon(name, manufacturer, numberOfBullets);
                break;
            }
        }
    }
}