using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotMenu : MonoBehaviour
{
    public PlayerStats playerStats;
    public Plot plot;

    public void OpenMenu()
    {

    }

    public void CloseMenu()
    {

    }

    public void Buy(TowerBlueprint tower)
    {
        if (playerStats.Pay(tower.Cost))
        {
            plot.BuildTower(tower);
        }
    }

    public void Sell()
    {
        plot.SellTower();
    }
}
