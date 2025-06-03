public class EnemyFactory
{
    private enemy[] enemyList;

    public EnemyFactory(int AmountOfEnemies)
    {
        this.enemyList = new enemy[AmountOfEnemies];
    }

    public void newEnemy(string Name)
    {
        for (int i = 0; i < enemyList.Length; i++)
        {
            if (enemyList[i] != null)
            {
                enemyList[i] = new enemy(Name);
                break;
            }
        }
    }
}