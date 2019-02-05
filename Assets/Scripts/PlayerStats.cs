using UnityEngine;

public class PlayerStats : ScriptableObject
{
    public readonly int StartingHealth = 100;
    public readonly int StartingMoney = 100;

    public int Health { get; private set; }
    public int Money { get; private set; }

    public void Initialize()
    {
        Health = StartingHealth;
        Money = StartingMoney;
    }

    public bool Pay(int amount)
    {
        if (Money >= amount)
        {
            Money -= amount;
            return true;
        }
        return false;
    }

    public void GainMoney(int amount)
    {
        Money += amount;
    }
}
