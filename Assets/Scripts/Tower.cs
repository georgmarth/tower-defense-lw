using UnityEngine;

public class Tower : MonoBehaviour
{
    public TowerBlueprint Blueprint;
    public PlayerStats PlayerStats;

    public void Sell()
    {
        PlayerStats.GainMoney((int)(Blueprint.Cost * 0.5f));
    }
}
